# GTANatives

GTA 5 Library for PS4 to create desktop tools.
This library allows you to call over 2000 native functions
that can be found here [Nativedb](http://www.dev-c.com/nativedb/)

<p align="center">
<img alt=".." src="https://x0.at/vq-.png"/>

</p>

# How to use
* Inject the **[PS4API.BIN](https://github.com/BISOON/ps4-api-server)** whether 4.05 or 4.55
* Reference the **[GTANative.dll](https://github.com/BISOON/GTA5-Native-Caller/tree/master/GTANatives/bin/Release)** to your project
* Call the Natives after the connection established

# Brief Examples
#### Initialize PS4API to pass it to the RPC.Enable(PS4API);
```csharp
PS4API PS4 = new PS4API();
PS4.ConnectTarget("192.168.0.0");
PS4.AttachProcess();
RPC.Enable(PS4); // must be called after AttachProcess();
```

#### Call some natives function
```csharp
Vector3 vec = ENTITY.GET_ENTITY_COORDS(PLAYER.PLAYER_PED_ID(), true);
PED.CREATE_RANDOM_PED(vec.X, vec.Y, vec.Z);
```
```csharp
VEHICLE.EXPLODE_VEHICLE(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), true, false);
```
```csharp
VEHICLE.SET_VEHICLE_FORWARD_SPEED(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), 100f);
```
```csharp
WEAPON.SET_PED_INFINITE_AMMO_CLIP(PLAYER.PLAYER_PED_ID(), true);
```
```csharp
TIME.SET_CLOCK_TIME(23, 59, 59);
```
*More can be found here **[Natives.cs](https://github.com/BISOON/GTA5-Native-Caller/blob/master/GTANatives/Natives.cs)**

# Note
For now only works on 1.0 version of GTA if you need to use this with higher update
make sure you update __Native Table Address__ by passing it to the second argument.
```csharp
RPC.Enable(PS4API, native_table_address);
```

# Credits
* Alexander Blade
* 2much4u
* Everyone
