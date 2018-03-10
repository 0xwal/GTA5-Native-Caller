using System;
using System.Text;
using PS4Lib;
using System.Threading;

internal partial  struct Address
{
    public static ulong
        ExecutableSpace = 0x2B9D2B0,
        FreeSpace = 0x2DCD830,
        NativeTable = 0x3644A28;
}
public class RPC
{
    public static PS4API PS4;
    private static ulong _executableSpace = Address.ExecutableSpace;
    private static ulong _freeSpace = Address.FreeSpace;
    public static ulong FreePointer = _freeSpace + 0x150;
    private static object _locker = new object();
    private static void _DestroyAll()
    {
        PS4.SetMemory(_freeSpace, new byte[0xFF]);
    }
    public static void Enable(PS4API ps4, ulong? nativeTableAddress = null)
    {
        if (nativeTableAddress != null)
            Address.NativeTable = nativeTableAddress.Value;
        PS4 = ps4;
        _DestroyAll();
        byte[] freeSpace = BitConverter.GetBytes(_freeSpace);
        byte[] exeSpace = BitConverter.GetBytes(_executableSpace);
        #region rpcOpcode
        byte[] rpc_code =
        {
            0x55, 0x48, 0x89, 0xE5, 0x53, 0x48, 0xBB,
            freeSpace[0], freeSpace[1], freeSpace[2], freeSpace[3],
            freeSpace[4], freeSpace[5], freeSpace[6], freeSpace[7],
            0x48, 0x83, 0x3B, 0x00, 0x74, 0x1F, 0x48,
            0x8D, 0x7B, 0x08, 0x48, 0x8D, 0x83, 0xA8,
            0x00, 0x00, 0x00, 0x48, 0x89, 0x07, 0x48,
            0x8D, 0x43, 0x28, 0x48, 0x89, 0x47, 0x10,
            0xFF, 0x13, 0x48, 0xC7, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x5B, 0x48, 0x31, 0xC0, 0x48,
            0x89, 0xEC, 0x5D, 0xC3
        };
        #endregion
        PS4.SetMemory(_executableSpace, rpc_code);
        PS4.SetMemory(NativeAddress(0xF25D331DC2627BBC) + 0x9,
            new byte[]
            {
                0x51, 0x48, 0xB9,
                exeSpace[0], exeSpace[1], exeSpace[2], exeSpace[3],
                exeSpace[4], exeSpace[5], exeSpace[6], exeSpace[7],
                0xFF, 0xD1, 0x59, 0x48, 0x83, 0xC4, 0x08, 0x5B,
                0x5D, 0xC3
            });
    }
   
    public static uint NativeAddress(UInt64 nativeHash)
    {
        ulong nativeTable;
        uint index;
        UInt64 nativeAddress;
        nativeTable = Address.NativeTable;
        index = (uint)nativeHash & 0xFF;
        byte[] test = PS4.GetBytes(nativeTable + (index * 8), 8);
        nativeAddress = PS4.Extension.ReadUInt64(nativeTable + (index * 8));
        while (nativeAddress != 0)
        {
            uint count = PS4.Extension.ReadUInt32(nativeAddress + 0x40);
            for (uint i = 0; i < count; i++)
            {
                UInt64 hash = PS4.Extension.ReadUInt64(nativeAddress + 0x48 + (i * 8));
                if (hash == nativeHash)
                {
                    return PS4.Extension.ReadUInt32(nativeAddress + 0x8 + (i * 8));
                }
            }
            nativeAddress = PS4.Extension.ReadUInt64(nativeAddress);
        }

        return 0;
    }
    private static byte[] GetBytes(object input) 
    {
        Type type = input.GetType();
        if (!type.IsValueType)
            return new byte[0];
        byte[] bytes = (byte[])typeof(BitConverter)
                .GetMethod("GetBytes", new Type[] { input.GetType() })
            ?.Invoke(null, new object[] { input });
        return bytes;
    }
    private static T ToPrimitive<T>(byte[] input, string dataTypeName)
    {
        Type type = input.GetType();
        string methodName = "To" + dataTypeName;
        T retValue = (T)typeof(BitConverter)
                .GetMethod(methodName)
            ?.Invoke(null, new object[] { input , 0});
        return retValue;
    }
    public static T Call<T>(ulong address, params object[] parameters)
    {
        lock (_locker)
        {
            if (address > uint.MaxValue)
            {
                address = NativeAddress(address);
            }
            if (address == 0)
            {
                throw new Exception("not correct address");
            }
            int parametersLength = parameters.Length;
            ulong freeSpace = _freeSpace;
            ulong pFunction = freeSpace;
            ulong pReturn = freeSpace + 0xA8;
            ulong pArgs = freeSpace + 0x28;
            ulong pString = freeSpace + 0xC8;
            ulong offset = 0;
            _DestroyAll();
            for (int i = 0; i < parametersLength; i++)
            {
                var currentParameter = parameters[i];
                var currentParameterType = currentParameter.GetType();
                if (currentParameterType != typeof(string) && currentParameterType.BaseType != typeof(ValueType))
                    throw new Exception("only string/value type (primitive) is allowed");
                offset = pArgs + (ulong)i * 8;
                if (currentParameterType.IsPrimitive)
                {
                    PS4.SetMemory(offset, GetBytes(currentParameter));
                }
                else if (currentParameterType == typeof(string))
                {
                    string currentString = currentParameter.ToString() + "\0";
                    int currentStringLength = currentString.Length;
                    byte[] stringAsBytes = Encoding.UTF8.GetBytes(currentString);
                    PS4.SetMemory(pString, stringAsBytes);
                    PS4.Extension.WriteUInt64(offset, pString);
                    pString += (ulong)currentStringLength;
                }
            }
            PS4.Extension.WriteUInt64(pFunction, address);
            Type retType = typeof(T);
            if (retType == typeof(Void))
            {
                return default(T);
            }
            Thread.Sleep(50);
            object retValue = null;
            if (retType.IsPrimitive)
            {
                retValue = PS4.GetBytes(pReturn, 8);
                retValue = ToPrimitive<T>((byte[])retValue, typeof(T).Name);
            }
            else if (retType == typeof(string))
            {
                retValue = PS4.Extension.ReadString(PS4.Extension.ReadUInt64(pReturn));
            }
            else
            {
                Vector3 vec;
                byte[] vec3 = PS4.GetBytes(pReturn, 8 * 3);
                vec.X = BitConverter.ToSingle(vec3, 0);
                vec.Y = BitConverter.ToSingle(vec3, 8); ;
                vec.Z = BitConverter.ToSingle(vec3, 16); ;
                retValue = vec;
            }
            return (T)retValue;
        }
    }
}



