
using Natives;
using PS4Lib;
public enum Weapons : uint
{
    ADVANCEDRIFLE = 0xaf113f99,
    ANIMAL = 0xf9fbaebe,
    APPISTOL = 0x22d8fe39,
    ASSAULTRIFLE = 0xbfefff6d,
    ASSAULTSHOTGUN = 0xe284c527,
    ASSAULTSMG = 0xefe7e2df,
    BALL = 0x23c9f95c,
    BOTTLE = 0xf9e6aa4b,
    BRIEFCASE = 0x88c78eb7,
    BRIEFCASE_02 = 0x1b79f17,
    BULLPUPRIFLE = 0x7f229f94,
    BULLPUPSHOTGUN = 0x9d61e50f,
    BZGAS = 0xa0973d5e,
    CARBINERIFLE = 0x83bf0278,
    COMBATMG = 0x7fd62962,
    COMBATPDW = 0xa3d4d34,
    COMBATPISTOL = 0x5ef9fec4,
    COUGAR = 0x8d4be52,
    CROWBAR = 0x84bd7bfd,
    DAGGER = 0x92a27487,
    DIGISCANNER = 0xfdbadced,
    FIREEXTINGUISHER = 0x60ec506,
    FIREWORK = 0x7f7497e5,
    FLARE = 0x497facc3,
    FLAREGUN = 0x47757124,
    GOLFCLUB = 0x440e4788,
    GRENADE = 0x93e220bd,
    GRENADELAUNCHER = 0xa284510b,
    GRENADELAUNCHER_SMOKE = 0x4dd2dc56,
    GUSENBERG = 0x61012683,
    HAMMER = 0x4e875f73,
    HEAVYPISTOL = 0xd205520e,
    HEAVYSHOTGUN = 0x3aabbbaa,
    HEAVYSNIPER = 0xc472fe2,
    HOMINGLAUNCHER = 0x63ab0442,
    KNIFE = 0x99b507ea,
    MARKSMANRIFLE = 0xc734385a,
    MICROSMG = 0x13532244,
    MINIGUN = 0x42bf8a85,
    MOLOTOV = 0x24b17070,
    MUSKET = 0xa89cb99e,
    NIGHTSTICK = 0x678b81b1,
    PETROLCAN = 0x34a67b97,
    PISTOL = 0x1b06d571,
    PISTOL50 = 0x99aeeb3b,
    PROXMINE = 0xab564b93,
    PUMPSHOTGUN = 0x1d073a89,
    SAWNOFFSHOTGUN = 0x7846a318,
    SMOKEGRENADE = 0xfdbc8a50,
    SNIPERRIFLE = 0x5fc3c11,
    SNOWBALL = 0x787f0bb,
    SNSPISTOL = 0xbfd21232,
    SPECIALCARBINE = 0xc0a3098d,
    STICKYBOMB = 0x2c3731d9,
    STINGER = 0x687652ce,
    STUNGUN = 0x3656c8c1,
    UNARMED = 0xa2719263,
    VINTAGEPISTOL = 0x83839c4,
}
public class Script
{
    public static PS4API PS4 = RPC.PS4;
    public static Vector3 GetPosition()
    {
        return ENTITY.GET_ENTITY_COORDS(PLAYER.PLAYER_PED_ID(), true);
    }
    public static int SpawnVehicle(string vehName, bool intoVehicle = true)
    {
        int vehHash = GAMEPLAY.GET_HASH_KEY(vehName);
        int newVec = 0;
        STREAMING.REQUEST_MODEL(vehHash);
        for (int i = 0; i < 100; i++)
        {
            if (STREAMING.HAS_MODEL_LOADED(vehHash))
            {
                int playerPed = PLAYER.PLAYER_PED_ID();
                Vector3 myCoords = GetPosition();
                newVec = VEHICLE.CREATE_VEHICLE(vehHash, myCoords.X, myCoords.Y, myCoords.Z, ENTITY.GET_ENTITY_HEADING(playerPed), true, true);

                if (intoVehicle)
                    PED.SET_PED_INTO_VEHICLE(playerPed, newVec, -1);
                STREAMING.SET_MODEL_AS_NO_LONGER_NEEDED(vehHash);
                break;
            }
        }
        return newVec;
    }
    public static int CreateRandomPed()
    {
        Vector3 vec = GetPosition();
        return PED.CREATE_RANDOM_PED(vec.X, vec.Y, vec.Z);
    }
    public static int Clone()
    {
        int ped = PLAYER.PLAYER_PED_ID();
        int pedCloned = PED.CLONE_PED(ped, 1f, false, true);
        MakeHimAsGuard(pedCloned);
        return pedCloned;
    }
    public static void MakeHimAsGuard(int ped)
    {
        int groupId = PLAYER.GET_PLAYER_GROUP(PLAYER.PLAYER_ID());
        int leader = PLAYER.PLAYER_PED_ID();
        PED.SET_PED_AS_GROUP_LEADER(leader, groupId);
        PED.SET_PED_AS_GROUP_MEMBER(ped, groupId);
        PED.SET_PED_NEVER_LEAVES_GROUP(ped, true);
        PED.SET_PED_CAN_SWITCH_WEAPON(ped, true);
        PED.SET_PED_COMBAT_ABILITY(ped, 1);
    }
    public static int GetSelectedWeapon()
    {
        return WEAPON.GET_SELECTED_PED_WEAPON(PLAYER.PLAYER_PED_ID());
    }
    public static void SetModel(string modelName)
    {

        int player = PLAYER.PLAYER_ID();
        int modelHash = GAMEPLAY.GET_HASH_KEY(modelName);
        STREAMING.REQUEST_MODEL(modelHash);
        int timeOut = 0;
        while (!STREAMING.HAS_MODEL_LOADED(modelHash))
        {
            timeOut++;
            if (timeOut == 5000)
                break;
        }
        PLAYER.SET_PLAYER_MODEL(player, modelHash);
        STREAMING.SET_MODEL_AS_NO_LONGER_NEEDED(modelHash);
    }
    public static int CreatePickup(string pickName, string probsName, int value = 1)
    {
        int pickHash = GAMEPLAY.GET_HASH_KEY(pickName.ToString());
        int propHash = 0;
        if (probsName != "default")
            propHash = GAMEPLAY.GET_HASH_KEY(probsName.ToString());
        Vector3 vec = GetPosition();
        return OBJECT.CREATE_PICKUP(pickHash, vec.X, vec.Y, vec.Z, 700, value, true, propHash);
    }


    public static void Upgrade_Downgrade(bool true_upgrade)
    {

        int VehID = VEHICLE.GET_LAST_DRIVEN_VEHICLE();
        if (true_upgrade)
        {
            VEHICLE.SET_VEHICLE_MOD_KIT(VehID, (int)0);
            VEHICLE.SET_VEHICLE_COLOURS(VehID, 120, 120);
            VEHICLE.SET_VEHICLE_NUMBER_PLATE_TEXT(VehID, " BISOON ");
            VEHICLE.SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(VehID, (int)1);
            VEHICLE.TOGGLE_VEHICLE_MOD(VehID, (int)18, true);
            VEHICLE.TOGGLE_VEHICLE_MOD(VehID, (int)22, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)16, (int)4, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)12, (int)2, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)11, (int)3, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)14, (int)14, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)15, (int)3, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)13, (int)3, true);
            VEHICLE.SET_VEHICLE_WHEEL_TYPE(VehID, (int)7);
            VEHICLE.SET_VEHICLE_WINDOW_TINT(VehID, (int)2);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)23, (int)19, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)0, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)1, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)2, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)3, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)4, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)5, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)6, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)7, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)8, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)9, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)10, 0, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)24, (int)12, true);
        }
        else
        {
            VEHICLE.SET_VEHICLE_MOD_KIT(VehID, (int)0);
            VEHICLE.SET_VEHICLE_COLOURS(VehID, 0x84, 0x84);
            VEHICLE.SET_VEHICLE_NUMBER_PLATE_TEXT(VehID, " BISOON ");
            VEHICLE.SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(VehID, (int)1);
            VEHICLE.TOGGLE_VEHICLE_MOD(VehID, (int)18, false);
            VEHICLE.TOGGLE_VEHICLE_MOD(VehID, (int)22, false);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)16, (int)-1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)12, (int)-1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)11, (int)-1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)14, (int)-1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)15, (int)-1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)13, (int)-1, true);
            VEHICLE.SET_VEHICLE_WHEEL_TYPE(VehID, (int)-1);
            VEHICLE.SET_VEHICLE_WINDOW_TINT(VehID, (int)-1);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)23, (int)-1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)0, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)1, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)2, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)3, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)4, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)5, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)6, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)7, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)8, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)9, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)10, -1, true);
            VEHICLE.SET_VEHICLE_MOD(VehID, (int)24, (int)-1, true);
        }

    }

    public static void NoDamage(int entity)
    {
        ENTITY.SET_ENTITY_PROOFS(entity, true, true, true, true, true, true, true, true);
        ENTITY.SET_ENTITY_INVINCIBLE(entity, true);
        ENTITY.SET_ENTITY_CAN_BE_DAMAGED(entity, false);
        VEHICLE.SET_VEHICLE_STRONG(entity, true);
        VEHICLE.SET_VEHICLE_TYRES_CAN_BURST(entity, true);
        VEHICLE.SET_VEHICLE_WHEELS_CAN_BREAK(entity, true);
    }
    public static void FlipVehicleUpright()
    {
        VEHICLE.SET_VEHICLE_ON_GROUND_PROPERLY(VEHICLE.GET_LAST_DRIVEN_VEHICLE());
    }
    public static void ExplodeVehicle()
    {
        VEHICLE.EXPLODE_VEHICLE(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), true, false);
    }
    public static void ChangeColor(int r, int g, int b)
    {
        VEHICLE.SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), r, g, b);
        VEHICLE.SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), r, g, b);
    }
    public static void Boost(float bst)
    {
        VEHICLE.SET_VEHICLE_FORWARD_SPEED(VEHICLE.GET_LAST_DRIVEN_VEHICLE(), bst);
    }
    public static void Fix()
    {
        VEHICLE.SET_VEHICLE_FIXED(VEHICLE.GET_LAST_DRIVEN_VEHICLE());
    }
    public static void DeleteEntity(int entity)
    {
        PS4.Extension.WriteInt32(RPC.FreePointer, entity);
        ENTITY.SET_ENTITY_AS_NO_LONGER_NEEDED(RPC.FreePointer);
        ENTITY.DELETE_ENTITY(RPC.FreePointer);
    }
    public static void RagDoll(bool toggle)
    {
        int ped = PLAYER.PLAYER_PED_ID();
        PED.SET_PED_CAN_RAGDOLL(ped, !toggle);
        PED.SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(ped, !toggle);
        ENTITY.SET_ENTITY_INVINCIBLE(ped, toggle);
        PED.SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(ped, 1);
        PLAYER.GIVE_PLAYER_RAGDOLL_CONTROL(ped, !toggle);
        PED.SET_PED_RAGDOLL_ON_COLLISION(ped, !toggle);
    }
    public static void NighVision(bool toggle)
    {
        GRAPHICS.SET_NIGHTVISION(toggle);
    }
    public static void SeeThrough(bool toggle)
    {
        GRAPHICS.SET_SEETHROUGH(toggle);
    }
    public static void NoCops(bool toggle)
    {
        PLAYER.SET_MAX_WANTED_LEVEL(toggle ? 0 : 5);
    }
    public static void Invisible(int entity, bool toggle)
    {
        ENTITY.SET_ENTITY_VISIBLE(entity, !toggle, true);
    }
    public static void SkyDive()
    {
        int ped = PLAYER.PLAYER_PED_ID();
        Vector3 vec = ENTITY.GET_ENTITY_COORDS(ped, true);
        ENTITY.SET_ENTITY_COORDS(ped, vec.X, vec.Y, 2500f, true, true, true, true);
        AI.TASK_SKY_DIVE(ped);
    }
    public static void SetGravity(bool toggle)
    {
        GAMEPLAY.SET_GRAVITY_LEVEL(toggle ? 3 : 0);
    }
    public static Vector3 WayPoint()
    {
        if (UI.IS_WAYPOINT_ACTIVE())
        {
            int blip = UI.GET_FIRST_BLIP_INFO_ID(8);
            return UI.GET_BLIP_COORDS(blip);
        }
        return default(Vector3);
    }
    public static void TeleportToWaypoint()
    {
        Vector3 wp = WayPoint();
        if (wp.X == 0)
            return;
        GAMEPLAY.GET_GROUND_Z_FOR_3D_COORD(wp.X, wp.Y, 5000.0f, RPC.FreePointer, true);
        float z = PS4.Extension.ReadFloat(RPC.FreePointer);
        int veh = 0;
        int ped = PLAYER.PLAYER_PED_ID();
        veh = PED.GET_VEHICLE_PED_IS_IN(ped, false);
        ENTITY.SET_ENTITY_COORDS(veh == 0 ? ped : veh, wp.X, wp.Y, z, true, true, true, true);
    }
    public static void InfiniteAmmo(bool toggle)
    {
        WEAPON.SET_PED_INFINITE_AMMO_CLIP(PLAYER.PLAYER_PED_ID(), toggle);
    }
    public static void GiveWeapon(Weapons weapon)
    {
        WEAPON.GIVE_WEAPON_TO_PED(PLAYER.PLAYER_PED_ID(), (int)weapon, 500, false, true);
    }
    public static void SetTime(int hours, int minutes, int seconds)
    {
        TIME.SET_CLOCK_TIME(hours, minutes, seconds);
    }
    public static void PauseTime(bool toggle)
    {
        TIME.PAUSE_CLOCK(toggle);
    }
    public static void SetWeather(string weather)
    {
        GAMEPLAY.SET_OVERRIDE_WEATHER(weather);
    }
    public static void UnlockTrophies()
    {
        for (int i = 0; i < 57; i++)
        {
            if (!PLAYER.HAS_ACHIEVEMENT_BEEN_PASSED(i))
                PLAYER.GIVE_ACHIEVEMENT_TO_PLAYER(i);
        }
    }
    public static void ChangePed(int player, int ped)
    {
        int currentPed = PLAYER.PLAYER_PED_ID();
        if (currentPed != ped)
            PLAYER.CHANGE_PLAYER_PED(player, ped, false, false);
    }
    public static void SwapToAimedPed()
    {
        int player = PLAYER.PLAYER_ID();
        if (!PLAYER.GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(player, RPC.FreePointer))
            return;
        int aimedEntity = PS4.Extension.ReadInt32(RPC.FreePointer);
        if (!ENTITY.IS_ENTITY_A_PED(aimedEntity))
            return;

        ChangePed(player, aimedEntity);
    }
}