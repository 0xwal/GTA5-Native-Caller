public struct Vector3
{
    public float X, Y, Z;
}
public struct Void{}
internal class Invoker
{
    public static T Call<T>(ulong address, params object[] parameters)
    {
        return RPC.Call<T>(address, parameters);
    }
}