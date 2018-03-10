/*              8-3-2018
 *  GTA V Natives http://www.dev-c.com/nativedb/
 *      ____ ___ ____   ___   ___  _   _ 
 *     | __ )_ _/ ___| / _ \ / _ \| \ | |
 *     |  _ \| |\___ \| | | | | | |  \| |
 *     | |_) | | ___) | |_| | |_| | |\  |
 *     |____/___|____/ \___/ \___/|_| \_|
 *                                       
 */
namespace Natives
{
    public static class PLAYER
    {

        public static int GET_PLAYER_PED(int playerID)
        {
            return Invoker.Call<int>(0x43A66C31C68491C0, playerID);
        }

        public static int GET_PLAYER_PED_SCRIPT_INDEX(int Player)
        {
            return Invoker.Call<int>(0x50FAC3A3E030A6E1, Player);
        }

        public static void SET_PLAYER_MODEL(int player, int model)
        {
            Invoker.Call<Void>(0x00A1CADD00108836, player, model);
        }

        public static void CHANGE_PLAYER_PED(int Player, int ped, bool b2, bool b3)
        {
            Invoker.Call<Void>(0x048189FAC643DEEE, Player, ped, b2, b3);
        }

        public static void GET_PLAYER_RGB_COLOUR(int Player, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0xE902EF951DCE178F, Player, r_ptr, g_ptr, b_ptr);
        }

        public static int GET_NUMBER_OF_PLAYERS()
        {
            return Invoker.Call<int>(0x407C7F91DDB46C16);
        }

        public static int GET_PLAYER_TEAM(int player)
        {
            return Invoker.Call<int>(0x37039302F4E0A008, player);
        }

        public static void SET_PLAYER_TEAM(int player, int team)
        {
            Invoker.Call<Void>(0x0299FA38396A4940, player, team);
        }

        public static string GET_PLAYER_NAME(int player)
        {
            return Invoker.Call<string>(0x6D0DE6A7B5DA71F8, player);
        }

        public static int GET_WANTED_LEVEL_RADIUS(int player)
        {
            return Invoker.Call<int>(0x085DEB493BE80812, player);
        }

        public static Vector3 GET_PLAYER_WANTED_CENTRE_POSITION(int player)
        {
            return Invoker.Call<Vector3>(0x0C92BA89F1AF26F8, player);
        }

        public static void SET_PLAYER_WANTED_CENTRE_POSITION(int player, float x, float y, float z)
        {
            Invoker.Call<Void>(0x520E541A97A13354, player, x, y, z);
        }

        public static int GET_WANTED_LEVEL_THRESHOLD(int wantedLevel)
        {
            return Invoker.Call<int>(0xFDD179EAF45B556C, wantedLevel);
        }

        public static void SET_PLAYER_WANTED_LEVEL(int player, int wantedLevel, bool disableNoMission)
        {
            Invoker.Call<Void>(0x39FF19C64EF7DA5B, player, wantedLevel, disableNoMission);
        }

        public static void SET_PLAYER_WANTED_LEVEL_NO_DROP(int player, int wantedLevel, bool p2)
        {
            Invoker.Call<Void>(0x340E61DE7F471565, player, wantedLevel, p2);
        }

        public static void SET_PLAYER_WANTED_LEVEL_NOW(int player, bool p1)
        {
            Invoker.Call<Void>(0xE0A7D1E497FFCD6F, player, p1);
        }

        public static bool ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP(int player)
        {
            return Invoker.Call<bool>(0xAFAF86043E5874E9, player);
        }

        public static bool ARE_PLAYER_STARS_GREYED_OUT(int player)
        {
            return Invoker.Call<bool>(0x0A6EB355EE14A2DB, player);
        }

        public static void SET_DISPATCH_COPS_FOR_PLAYER(int player, bool toggle)
        {
            Invoker.Call<Void>(0xDB172424876553F4, player, toggle);
        }

        public static bool IS_PLAYER_WANTED_LEVEL_GREATER(int player, int wantedLevel)
        {
            return Invoker.Call<bool>(0x238DB2A2C23EE9EF, player, wantedLevel);
        }

        public static void CLEAR_PLAYER_WANTED_LEVEL(int player)
        {
            Invoker.Call<Void>(0xB302540597885499, player);
        }

        public static bool IS_PLAYER_DEAD(int player)
        {
            return Invoker.Call<bool>(0x424D4687FA1E5652, player);
        }

        public static bool IS_PLAYER_PRESSING_HORN(int player)
        {
            return Invoker.Call<bool>(0xFA1E2BF8B10598F9, player);
        }

        public static void SET_PLAYER_CONTROL(int player, bool toggle, int flags)
        {
            Invoker.Call<Void>(0x8D32347D6D4C40A2, player, toggle, flags);
        }

        public static int GET_PLAYER_WANTED_LEVEL(int player)
        {
            return Invoker.Call<int>(0xE28E54788CE8F12D, player);
        }

        public static void SET_MAX_WANTED_LEVEL(int maxWantedLevel)
        {
            Invoker.Call<Void>(0xAA5F02DB48D704B9, maxWantedLevel);
        }

        public static void SET_POLICE_RADAR_BLIPS(int toggle)
        {
            Invoker.Call<Void>(0x43286D561B72B8BF, toggle);
        }

        public static void SET_POLICE_IGNORE_PLAYER(int player, bool toggle)
        {
            Invoker.Call<Void>(0x32C62AA929C2DA6A, player, toggle);
        }

        public static bool IS_PLAYER_PLAYING(int player)
        {
            return Invoker.Call<bool>(0x5E9564D8246B909A, player);
        }

        public static void SET_EVERYONE_IGNORE_PLAYER(int player, bool toggle)
        {
            Invoker.Call<Void>(0x8EEDA153AD141BA4, player, toggle);
        }

        public static void SET_ALL_RANDOM_PEDS_FLEE(int player, bool toggle)
        {
            Invoker.Call<Void>(0x056E0FE8534C2949, player, toggle);
        }

        public static void SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME(int player)
        {
            Invoker.Call<Void>(0x471D2FF42A94B4F2, player);
        }

        public static void _0xDE45D1A1EF45EE61(int player, bool toggle)
        {
            Invoker.Call<Void>(0xDE45D1A1EF45EE61, player, toggle);
        }

        public static void _0xC3376F42B1FACCC6(int player)
        {
            Invoker.Call<Void>(0xC3376F42B1FACCC6, player);
        }

        public static void SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS(int player, bool toggle)
        {
            Invoker.Call<Void>(0x596976B02B6B5700, player, toggle);
        }

        public static void SET_WANTED_LEVEL_MULTIPLIER(float multiplier)
        {
            Invoker.Call<Void>(0x020E5F00CDA207BA, multiplier);
        }

        public static void SET_WANTED_LEVEL_DIFFICULTY(int player, float difficulty)
        {
            Invoker.Call<Void>(0x9B0BB33B04405E7A, player, difficulty);
        }

        public static void RESET_WANTED_LEVEL_DIFFICULTY(int player)
        {
            Invoker.Call<Void>(0xB9D0DD990DC141DD, player);
        }

        public static void START_FIRING_AMNESTY(int duration)
        {
            Invoker.Call<Void>(0xBF9BD71691857E48, duration);
        }

        public static void REPORT_CRIME(int player, int crimeType, int wantedLvlThresh)
        {
            Invoker.Call<Void>(0xE9B09589827545E7, player, crimeType, wantedLvlThresh);
        }

        public static void _SWITCH_CRIME_TYPE(int player, int p1)
        {
            Invoker.Call<Void>(0x9A987297ED8BD838, player, p1);
        }

        public static void _0xBC9490CA15AEA8FB(int player)
        {
            Invoker.Call<Void>(0xBC9490CA15AEA8FB, player);
        }

        public static int _0x4669B3ED80F24B4E(int player)
        {
            return Invoker.Call<int>(0x4669B3ED80F24B4E, player);
        }

        public static int _0xAD73CE5A09E42D12(int player)
        {
            return Invoker.Call<int>(0xAD73CE5A09E42D12, player);
        }

        public static void _0x36F1B38855F2A8DF(int player)
        {
            Invoker.Call<Void>(0x36F1B38855F2A8DF, player);
        }

        public static void _0xDC64D2C53493ED12(int player)
        {
            Invoker.Call<Void>(0xDC64D2C53493ED12, player);
        }

        public static void _0xB45EFF719D8427A6(float p0)
        {
            Invoker.Call<Void>(0xB45EFF719D8427A6, p0);
        }

        public static void _0x0032A6DBA562C518()
        {
            Invoker.Call<Void>(0x0032A6DBA562C518);
        }

        public static bool CAN_PLAYER_START_MISSION(int player)
        {
            return Invoker.Call<bool>(0xDE7465A27D403C06, player);
        }

        public static bool IS_PLAYER_READY_FOR_CUTSCENE(int player)
        {
            return Invoker.Call<bool>(0x908CBECC2CAA3690, player);
        }

        public static bool IS_PLAYER_TARGETTING_ENTITY(int player, int entity)
        {
            return Invoker.Call<bool>(0x7912F7FC4F6264B6, player, entity);
        }

        public static bool GET_PLAYER_TARGET_ENTITY(int player, ulong entity_ptr)
        {
            return Invoker.Call<bool>(0x13EDE1A5DBF797C9, player, entity_ptr);
        }

        public static bool IS_PLAYER_FREE_AIMING(int player)
        {
            return Invoker.Call<bool>(0x2E397FD2ECD37C87, player);
        }

        public static bool IS_PLAYER_FREE_AIMING_AT_ENTITY(int player, int entity)
        {
            return Invoker.Call<bool>(0x3C06B5C839B38F7B, player, entity);
        }

        public static bool GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(int player, ulong entity_ptr)
        {
            return Invoker.Call<bool>(0x2975C866E6713290, player, entity_ptr);
        }

        public static void SET_PLAYER_LOCKON_RANGE_OVERRIDE(int player, float range)
        {
            Invoker.Call<Void>(0x29961D490E5814FD, player, range);
        }

        public static void SET_PLAYER_CAN_DO_DRIVE_BY(int player, bool toggle)
        {
            Invoker.Call<Void>(0x6E8834B52EC20C77, player, toggle);
        }

        public static void SET_PLAYER_CAN_BE_HASSLED_BY_GANGS(int player, bool toggle)
        {
            Invoker.Call<Void>(0xD5E460AD7020A246, player, toggle);
        }

        public static int SET_PLAYER_CAN_USE_COVER(int player, bool toggle)
        {
            return Invoker.Call<int>(0xD465A8599DFF6814, player, toggle);
        }

        public static int GET_MAX_WANTED_LEVEL()
        {
            return Invoker.Call<int>(0x462E0DB9B137DC5F);
        }

        public static bool IS_PLAYER_TARGETTING_ANYTHING(int player)
        {
            return Invoker.Call<bool>(0x78CFE51896B6B8A4, player);
        }

        public static void SET_PLAYER_SPRINT(int player, bool toggle)
        {
            Invoker.Call<Void>(0xA01B8075D8B92DF4, player, toggle);
        }

        public static void RESET_PLAYER_STAMINA(int player)
        {
            Invoker.Call<Void>(0xA6F312FCCE9C1DFE, player);
        }

        public static void RESTORE_PLAYER_STAMINA(int player, float p1)
        {
            Invoker.Call<Void>(0xA352C1B864CAFD33, player, p1);
        }

        public static float GET_PLAYER_SPRINT_STAMINA_REMAINING(int player)
        {
            return Invoker.Call<float>(0x3F9F16F8E65A7ED7, player);
        }

        public static float GET_PLAYER_SPRINT_TIME_REMAINING(int player)
        {
            return Invoker.Call<float>(0x1885BC9B108B4C99, player);
        }

        public static float GET_PLAYER_UNDERWATER_TIME_REMAINING(int player)
        {
            return Invoker.Call<float>(0xA1FCF8E6AF40B731, player);
        }

        public static int GET_PLAYER_GROUP(int player)
        {
            return Invoker.Call<int>(0x0D127585F77030AF, player);
        }

        public static int GET_PLAYER_MAX_ARMOUR(int player)
        {
            return Invoker.Call<int>(0x92659B4CE1863CB3, player);
        }

        public static bool IS_PLAYER_CONTROL_ON(int player)
        {
            return Invoker.Call<bool>(0x49C32D60007AFA47, player);
        }

        public static bool _IS_PLAYER_CAM_CONTROL_DISABLED()
        {
            return Invoker.Call<bool>(0x7C814D2FB49F40C0);
        }

        public static bool IS_PLAYER_SCRIPT_CONTROL_ON(int player)
        {
            return Invoker.Call<bool>(0x8A876A65283DD7D7, player);
        }

        public static bool IS_PLAYER_CLIMBING(int player)
        {
            return Invoker.Call<bool>(0x95E8F73DC65EFB9C, player);
        }

        public static bool IS_PLAYER_BEING_ARRESTED(int player, bool atArresting)
        {
            return Invoker.Call<bool>(0x388A47C51ABDAC8E, player, atArresting);
        }

        public static void RESET_PLAYER_ARREST_STATE(int player)
        {
            Invoker.Call<Void>(0x2D03E13C460760D6, player);
        }

        public static int GET_PLAYERS_LAST_VEHICLE()
        {
            return Invoker.Call<int>(0xB6997A7EB3F5C8C0);
        }

        public static int GET_PLAYER_INDEX()
        {
            return Invoker.Call<int>(0xA5EDC40EF369B48D);
        }

        public static int INT_TO_PLAYERINDEX(int value)
        {
            return Invoker.Call<int>(0x41BD2A6B006AF756, value);
        }

        public static int INT_TO_PARTICIPANTINDEX(int value)
        {
            return Invoker.Call<int>(0x9EC6603812C24710, value);
        }

        public static int GET_TIME_SINCE_PLAYER_HIT_VEHICLE(int player)
        {
            return Invoker.Call<int>(0x5D35ECF3A81A0EE0, player);
        }

        public static int GET_TIME_SINCE_PLAYER_HIT_PED(int player)
        {
            return Invoker.Call<int>(0xE36A25322DC35F42, player);
        }

        public static int GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT(int player)
        {
            return Invoker.Call<int>(0xD559D2BE9E37853B, player);
        }

        public static int GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC(int player)
        {
            return Invoker.Call<int>(0xDB89591E290D9182, player);
        }

        public static int IS_PLAYER_FREE_FOR_AMBIENT_TASK(int player)
        {
            return Invoker.Call<int>(0xDCCFD3F106C36AB4, player);
        }

        public static int PLAYER_ID()
        {
            return Invoker.Call<int>(0x4F8644AF03D0E0D6);
        }

        public static int PLAYER_PED_ID()
        {
            return Invoker.Call<int>(0xD80958FC74E988A6);
        }

        public static int NETWORK_PLAYER_ID_TO_INT()
        {
            return Invoker.Call<int>(0xEE68096F9F37341E);
        }

        public static bool HAS_FORCE_CLEANUP_OCCURRED(int cleanupFlags)
        {
            return Invoker.Call<bool>(0xC968670BFACE42D9, cleanupFlags);
        }

        public static void FORCE_CLEANUP(int cleanupFlags)
        {
            Invoker.Call<Void>(0xBC8983F38F78ED51, cleanupFlags);
        }

        public static void FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME(string name, int cleanupFlags)
        {
            Invoker.Call<Void>(0x4C68DDDDF0097317, name, cleanupFlags);
        }

        public static void FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID(int id, int cleanupFlags)
        {
            Invoker.Call<Void>(0xF745B37630DF176B, id, cleanupFlags);
        }

        public static int GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP()
        {
            return Invoker.Call<int>(0x9A41CF4674A12272);
        }

        public static void SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE(int player, int vehicle)
        {
            Invoker.Call<Void>(0x8026FF78F208978A, player, vehicle);
        }

        public static void SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE(ulong player_ptr)
        {
            Invoker.Call<Void>(0x1DE37BBF9E9CC14A, player_ptr);
        }

        public static int GIVE_ACHIEVEMENT_TO_PLAYER(int achievement)
        {
            return Invoker.Call<int>(0xBEC7076D64130195, achievement);
        }

        public static bool _SET_ACHIEVEMENT_PROGRESSION(int achId, int progression)
        {
            return Invoker.Call<bool>(0xC2AFFFDABBDC2C5C, achId, progression);
        }

        public static int _GET_ACHIEVEMENT_PROGRESSION(int achId)
        {
            return Invoker.Call<int>(0x1C186837D0619335, achId);
        }

        public static bool HAS_ACHIEVEMENT_BEEN_PASSED(int achievement)
        {
            return Invoker.Call<bool>(0x867365E111A3B6EB, achievement);
        }

        public static bool IS_PLAYER_ONLINE()
        {
            return Invoker.Call<bool>(0xF25D331DC2627BBC);
        }

        public static bool IS_PLAYER_LOGGING_IN_NP()
        {
            return Invoker.Call<bool>(0x74556E1420867ECA);
        }

        public static void DISPLAY_SYSTEM_SIGNIN_UI(bool unk)
        {
            Invoker.Call<Void>(0x94DD7888C10A979E, unk);
        }

        public static bool IS_SYSTEM_UI_BEING_DISPLAYED()
        {
            return Invoker.Call<bool>(0x5D511E3867C87139);
        }

        public static void SET_PLAYER_INVINCIBLE(int player, bool toggle)
        {
            Invoker.Call<Void>(0x239528EACDC3E7DE, player, toggle);
        }

        public static bool GET_PLAYER_INVINCIBLE(int player)
        {
            return Invoker.Call<bool>(0xB721981B2B939E07, player);
        }

        public static void _0xCAC57395B151135F(int player, bool p1)
        {
            Invoker.Call<Void>(0xCAC57395B151135F, player, p1);
        }

        public static int REMOVE_PLAYER_HELMET(int player, bool p2)
        {
            return Invoker.Call<int>(0xF3AC26D3CC576528, player, p2);
        }

        public static void GIVE_PLAYER_RAGDOLL_CONTROL(int player, bool toggle)
        {
            Invoker.Call<Void>(0x3C49C870E66F0A28, player, toggle);
        }

        public static void SET_PLAYER_LOCKON(int player, bool toggle)
        {
            Invoker.Call<Void>(0x5C8B2F450EE4328E, player, toggle);
        }

        public static void SET_PLAYER_TARGETING_MODE(int targetMode)
        {
            Invoker.Call<Void>(0xB1906895227793F3, targetMode);
        }

        public static void _0x5702B917B99DB1CD(int p0)
        {
            Invoker.Call<Void>(0x5702B917B99DB1CD, p0);
        }

        public static bool _0xB9CF1F793A9F1BF1()
        {
            return Invoker.Call<bool>(0xB9CF1F793A9F1BF1);
        }

        public static void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED(int player)
        {
            Invoker.Call<Void>(0xF0B67A4DE6AB5F98, player);
        }

        public static bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED(int player)
        {
            return Invoker.Call<bool>(0x20CE80B0C2BF4ACC, player);
        }

        public static void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)
        {
            Invoker.Call<Void>(0x4AACB96203D11A31, player);
        }

        public static bool HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player)
        {
            return Invoker.Call<bool>(0xE4B90F367BD81752, player);
        }

        public static void SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE(int player, float multiplier)
        {
            Invoker.Call<Void>(0xCA7DC8329F0A1E9E, player, multiplier);
        }

        public static void SET_SWIM_MULTIPLIER_FOR_PLAYER(int player, float multiplier)
        {
            Invoker.Call<Void>(0xA91C6F0FF7D16A13, player, multiplier);
        }

        public static void SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER(int player, float multiplier)
        {
            Invoker.Call<Void>(0x6DB47AA77FD94E09, player, multiplier);
        }

        public static int GET_TIME_SINCE_LAST_ARREST()
        {
            return Invoker.Call<int>(0x5063F92F07C2A316);
        }

        public static int GET_TIME_SINCE_LAST_DEATH()
        {
            return Invoker.Call<int>(0xC7034807558DDFCA);
        }

        public static void ASSISTED_MOVEMENT_CLOSE_ROUTE()
        {
            Invoker.Call<Void>(0xAEBF081FFC0A0E5E);
        }

        public static void ASSISTED_MOVEMENT_FLUSH_ROUTE()
        {
            Invoker.Call<Void>(0x8621390F0CDCFE1F);
        }

        public static void SET_PLAYER_FORCED_AIM(int player, bool toggle)
        {
            Invoker.Call<Void>(0x0FEE4F80AC44A726, player, toggle);
        }

        public static void SET_PLAYER_FORCED_ZOOM(int player, bool toggle)
        {
            Invoker.Call<Void>(0x75E7D505F2B15902, player, toggle);
        }

        public static void SET_PLAYER_FORCE_SKIP_AIM_INTRO(int player, bool toggle)
        {
            Invoker.Call<Void>(0x7651BC64AE59E128, player, toggle);
        }

        public static void DISABLE_PLAYER_FIRING(int player, bool toggle)
        {
            Invoker.Call<Void>(0x5E6CC07646BBEAB8, player, toggle);
        }

        public static void _0xB885852C39CC265D()
        {
            Invoker.Call<Void>(0xB885852C39CC265D);
        }

        public static void SET_DISABLE_AMBIENT_MELEE_MOVE(int player, bool toggle)
        {
            Invoker.Call<Void>(0x2E8AABFA40A84F8C, player, toggle);
        }

        public static void SET_PLAYER_MAX_ARMOUR(int player, int value)
        {
            Invoker.Call<Void>(0x77DFCCF5948B8C71, player, value);
        }

        public static void SPECIAL_ABILITY_DEACTIVATE(int player)
        {
            Invoker.Call<Void>(0xD6A953C6D1492057, player);
        }

        public static void SPECIAL_ABILITY_DEACTIVATE_FAST(int player)
        {
            Invoker.Call<Void>(0x9CB5CE07A3968D5A, player);
        }

        public static void SPECIAL_ABILITY_RESET(int player)
        {
            Invoker.Call<Void>(0x375F0E738F861A94, player);
        }

        public static void _0xC9A763D8FE87436A(int player)
        {
            Invoker.Call<Void>(0xC9A763D8FE87436A, player);
        }

        public static void SPECIAL_ABILITY_CHARGE_SMALL(int player, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x2E7B9B683481687D, player, p1, p2);
        }

        public static void SPECIAL_ABILITY_CHARGE_MEDIUM(int player, int p1, int p2)
        {
            Invoker.Call<Void>(0xF113E3AA9BC54613, player, p1, p2);
        }

        public static void SPECIAL_ABILITY_CHARGE_LARGE(int player, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xF733F45FA4497D93, player, p1, p2);
        }

        public static void SPECIAL_ABILITY_CHARGE_CONTINUOUS(int player, int p2)
        {
            Invoker.Call<Void>(0xED481732DFF7E997, player, p2);
        }

        public static void SPECIAL_ABILITY_CHARGE_ABSOLUTE(int player, int p1, bool p2)
        {
            Invoker.Call<Void>(0xB7B0870EB531D08D, player, p1, p2);
        }

        public static void SPECIAL_ABILITY_CHARGE_NORMALIZED(int player, float normalizedValue, bool p2)
        {
            Invoker.Call<Void>(0xA0696A65F009EE18, player, normalizedValue, p2);
        }

        public static void SPECIAL_ABILITY_FILL_METER(int player, bool p1)
        {
            Invoker.Call<Void>(0x3DACA8DDC6FD4980, player, p1);
        }

        public static void SPECIAL_ABILITY_DEPLETE_METER(int player, bool p1)
        {
            Invoker.Call<Void>(0x1D506DBBBC51E64B, player, p1);
        }

        public static void SPECIAL_ABILITY_LOCK(int playerModel)
        {
            Invoker.Call<Void>(0x6A09D0D590A47D13, playerModel);
        }

        public static void SPECIAL_ABILITY_UNLOCK(int playerModel)
        {
            Invoker.Call<Void>(0xF145F3BE2EFA9A3B, playerModel);
        }

        public static bool IS_SPECIAL_ABILITY_UNLOCKED(int playerModel)
        {
            return Invoker.Call<bool>(0xC6017F6A6CDFA694, playerModel);
        }

        public static int IS_SPECIAL_ABILITY_ACTIVE(int player)
        {
            return Invoker.Call<int>(0x3E5F7FC85D854E15, player);
        }

        public static bool IS_SPECIAL_ABILITY_METER_FULL(int player)
        {
            return Invoker.Call<bool>(0x05A1FE504B7F2587, player);
        }

        public static void ENABLE_SPECIAL_ABILITY(int player, bool toggle)
        {
            Invoker.Call<Void>(0x181EC197DAEFE121, player, toggle);
        }

        public static bool IS_SPECIAL_ABILITY_ENABLED(int player)
        {
            return Invoker.Call<bool>(0xB1D200FE26AEF3CB, player);
        }

        public static void SET_SPECIAL_ABILITY_MULTIPLIER(float multiplier)
        {
            Invoker.Call<Void>(0xA49C426ED0CA4AB7, multiplier);
        }

        public static void _0xFFEE8FA29AB9A18E(int player)
        {
            Invoker.Call<Void>(0xFFEE8FA29AB9A18E, player);
        }

        public static bool _0x5FC472C501CCADB3(int player)
        {
            return Invoker.Call<bool>(0x5FC472C501CCADB3, player);
        }

        public static bool _0xF10B44FD479D69F3(int player, int p1)
        {
            return Invoker.Call<bool>(0xF10B44FD479D69F3, player, p1);
        }

        public static bool _0xDD2620B7B9D16FF1(int player, float p1)
        {
            return Invoker.Call<bool>(0xDD2620B7B9D16FF1, player, p1);
        }

        public static void START_PLAYER_TELEPORT(int player, float x, float y, float z, float heading, bool p5, bool p6, bool p7)
        {
            Invoker.Call<Void>(0xAD15F075A4DA0FDE, player, x, y, z, heading, p5, p6, p7);
        }

        public static bool _HAS_PLAYER_TELEPORT_FINISHED(int player)
        {
            return Invoker.Call<bool>(0xE23D5873C2394C61, player);
        }

        public static void STOP_PLAYER_TELEPORT()
        {
            Invoker.Call<Void>(0xC449EDED9D73009C);
        }

        public static bool IS_PLAYER_TELEPORT_ACTIVE()
        {
            return Invoker.Call<bool>(0x02B15662D7F8886F);
        }

        public static float GET_PLAYER_CURRENT_STEALTH_NOISE(int player)
        {
            return Invoker.Call<float>(0x2F395D61F3A1F877, player);
        }

        public static void SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(int player, float regenRate)
        {
            Invoker.Call<Void>(0x5DB660B38DD98A31, player, regenRate);
        }

        public static void SET_PLAYER_WEAPON_DAMAGE_MODIFIER(int player, float damageAmount)
        {
            Invoker.Call<Void>(0xCE07B9F7817AADA3, player, damageAmount);
        }

        public static void SET_PLAYER_WEAPON_DEFENSE_MODIFIER(int player, int modifier)
        {
            Invoker.Call<Void>(0x2D83BC011CA14A3C, player, modifier);
        }

        public static void SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER(int player, float modifier)
        {
            Invoker.Call<Void>(0x4A3DC7ECCC321032, player, modifier);
        }

        public static void SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER(int player, float modifier)
        {
            Invoker.Call<Void>(0xAE540335B4ABC4E2, player, modifier);
        }

        public static void SET_PLAYER_VEHICLE_DAMAGE_MODIFIER(int player, float damageAmount)
        {
            Invoker.Call<Void>(0xA50E117CDDF82F0C, player, damageAmount);
        }

        public static void SET_PLAYER_VEHICLE_DEFENSE_MODIFIER(int player, float modifier)
        {
            Invoker.Call<Void>(0x4C60E6EFDAFF2462, player, modifier);
        }

        public static void SET_PLAYER_PARACHUTE_TINT_INDEX(int player, int tintIndex)
        {
            Invoker.Call<Void>(0xA3D0E54541D9A5E5, player, tintIndex);
        }

        public static void GET_PLAYER_PARACHUTE_TINT_INDEX(int player, ulong tintIndex_ptr)
        {
            Invoker.Call<Void>(0x75D3F7A1B0D9B145, player, tintIndex_ptr);
        }

        public static void SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, int index)
        {
            Invoker.Call<Void>(0xAF04C87F5DC1DF38, player, index);
        }

        public static void GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(int player, ulong index_ptr)
        {
            Invoker.Call<Void>(0xD5A016BC3C09CF40, player, index_ptr);
        }

        public static void SET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, int tintIndex)
        {
            Invoker.Call<Void>(0x93B0FB27C9A04060, player, tintIndex);
        }

        public static void GET_PLAYER_PARACHUTE_PACK_TINT_INDEX(int player, ulong tintIndex_ptr)
        {
            Invoker.Call<Void>(0x6E9C742F340CE5A2, player, tintIndex_ptr);
        }

        public static void SET_PLAYER_HAS_RESERVE_PARACHUTE(int player)
        {
            Invoker.Call<Void>(0x7DDAB28D31FAC363, player);
        }

        public static bool GET_PLAYER_HAS_RESERVE_PARACHUTE(int player)
        {
            return Invoker.Call<bool>(0x5DDFE2FF727F3CA3, player);
        }

        public static void SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL(int player, bool enabled)
        {
            Invoker.Call<Void>(0xF401B182DBA8AF53, player, enabled);
        }

        public static void SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, int r, int g, int b)
        {
            Invoker.Call<Void>(0x8217FD371A4625CF, player, r, g, b);
        }

        public static void GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(int player, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0xEF56DBABD3CD4887, player, r_ptr, g_ptr, b_ptr);
        }

        public static void SET_PLAYER_RESET_FLAG_PREFER_REAR_SEATS(int player, int flags)
        {
            Invoker.Call<Void>(0x11D5F725F0E780E0, player, flags);
        }

        public static void SET_PLAYER_NOISE_MULTIPLIER(int player, float multiplier)
        {
            Invoker.Call<Void>(0xDB89EF50FF25FCE9, player, multiplier);
        }

        public static void SET_PLAYER_SNEAKING_NOISE_MULTIPLIER(int player, float multiplier)
        {
            Invoker.Call<Void>(0xB2C1A29588A9F47C, player, multiplier);
        }

        public static bool CAN_PED_HEAR_PLAYER(int player, int ped)
        {
            return Invoker.Call<bool>(0xF297383AA91DCA29, player, ped);
        }

        public static void SIMULATE_PLAYER_INPUT_GAIT(int control, float amount, int gaitType, float speed, bool p4, bool p5)
        {
            Invoker.Call<Void>(0x477D5D63E63ECA5D, control, amount, gaitType, speed, p4, p5);
        }

        public static void RESET_PLAYER_INPUT_GAIT(int player)
        {
            Invoker.Call<Void>(0x19531C47A2ABD691, player);
        }

        public static void SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE(int player, bool toggle)
        {
            Invoker.Call<Void>(0x9F343285A00B4BB6, player, toggle);
        }

        public static void _0xD2B315B6689D537D(int player, bool p1)
        {
            Invoker.Call<Void>(0xD2B315B6689D537D, player, p1);
        }

        public static void SET_PLAYER_STEALTH_PERCEPTION_MODIFIER(int player, float value)
        {
            Invoker.Call<Void>(0x4E9021C1FCDD507A, player, value);
        }

        public static bool _0x690A61A6D13583F6(int p0)
        {
            return Invoker.Call<bool>(0x690A61A6D13583F6, p0);
        }

        public static void _0x9EDD76E87D5D51BA(int player)
        {
            Invoker.Call<Void>(0x9EDD76E87D5D51BA, player);
        }

        public static void SET_PLAYER_SIMULATE_AIMING(int player, bool toggle)
        {
            Invoker.Call<Void>(0xC54C95DA968EC5B5, player, toggle);
        }

        public static void SET_PLAYER_CLOTH_PIN_FRAMES(int player, bool toggle)
        {
            Invoker.Call<Void>(0x749FADDF97DFE930, player, toggle);
        }

        public static void SET_PLAYER_CLOTH_PACKAGE_INDEX(int index)
        {
            Invoker.Call<Void>(0x9F7BBA2EA6372500, index);
        }

        public static void SET_PLAYER_CLOTH_LOCK_COUNTER(int value)
        {
            Invoker.Call<Void>(0x14D913B777DFF5DA, value);
        }

        public static void PLAYER_ATTACH_VIRTUAL_BOUND(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
        {
            Invoker.Call<Void>(0xED51733DC73AED51, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void PLAYER_DETACH_VIRTUAL_BOUND()
        {
            Invoker.Call<Void>(0x1DD5897E2FA6E7C9);
        }

        public static bool HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE(int player)
        {
            return Invoker.Call<bool>(0xD705740BB0A1CF4C, player);
        }

        public static bool _0x38D28DA81E4E9BF9(int player)
        {
            return Invoker.Call<bool>(0x38D28DA81E4E9BF9, player);
        }

        public static bool _0xBC0753C9CA14B506(int player, int p1, bool p2)
        {
            return Invoker.Call<bool>(0xBC0753C9CA14B506, player, p1, p2);
        }

        public static void _EXPAND_WORLD_LIMITS(float x, float y, float z)
        {
            Invoker.Call<Void>(0x5006D96C995A5827, x, y, z);
        }

        public static bool IS_PLAYER_RIDING_TRAIN(int player)
        {
            return Invoker.Call<bool>(0x4EC12697209F2196, player);
        }

        public static bool HAS_PLAYER_LEFT_THE_WORLD(int player)
        {
            return Invoker.Call<bool>(0xD55DDFB47991A294, player);
        }

        public static void _0xFF300C7649724A0B(int player, bool p1)
        {
            Invoker.Call<Void>(0xFF300C7649724A0B, player, p1);
        }

        public static void SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player, int p1, int p2, int p3, bool p4)
        {
            Invoker.Call<Void>(0xD9284A8C0D48352C, player, p1, p2, p3, p4);
        }

        public static void CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE(int player)
        {
            Invoker.Call<Void>(0x0F4CC924CF8C7B21, player);
        }

        public static void SET_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player, int model)
        {
            Invoker.Call<Void>(0x977DB4641F6FC3DB, player, model);
        }

        public static void CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE(int player)
        {
            Invoker.Call<Void>(0x8753997EB5F6EE3F, player);
        }

        public static void SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player, int model)
        {
            Invoker.Call<Void>(0xDC80A4C2F18A2B64, player, model);
        }

        public static void CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(int player)
        {
            Invoker.Call<Void>(0x10C54E4389C12B42, player);
        }

        public static void DISABLE_PLAYER_VEHICLE_REWARDS(int player)
        {
            Invoker.Call<Void>(0xC142BE3BB9CE125F, player);
        }

        public static void _0x2F7CEB6520288061(bool p0)
        {
            Invoker.Call<Void>(0x2F7CEB6520288061, p0);
        }

        public static void _0x5DC40A8869C22141(bool p0, int p1)
        {
            Invoker.Call<Void>(0x5DC40A8869C22141, p0, p1);
        }

        public static bool _0x65FAEE425DE637B0(int p0)
        {
            return Invoker.Call<bool>(0x65FAEE425DE637B0, p0);
        }

        public static void _0x5501B7A5CDB79D37(int p0)
        {
            Invoker.Call<Void>(0x5501B7A5CDB79D37, p0);
        }

        public static int _0x56105E599CAB0EFA(ulong p0_ptr)
        {
            return Invoker.Call<int>(0x56105E599CAB0EFA, p0_ptr);
        }

    }

    public static class ENTITY
    {

        public static bool DOES_ENTITY_EXIST(int entity)
        {
            return Invoker.Call<bool>(0x7239B21A38F536BA, entity);
        }

        public static bool DOES_ENTITY_BELONG_TO_THIS_SCRIPT(int entity, bool p2)
        {
            return Invoker.Call<bool>(0xDDE6DF5AE89981D2, entity, p2);
        }

        public static bool DOES_ENTITY_HAVE_DRAWABLE(int entity)
        {
            return Invoker.Call<bool>(0x060D6E96F8B8E48D, entity);
        }

        public static bool DOES_ENTITY_HAVE_PHYSICS(int entity)
        {
            return Invoker.Call<bool>(0xDA95EA3317CC5064, entity);
        }

        public static bool HAS_ENTITY_ANIM_FINISHED(int entity, string animDict, string animName, int p3)
        {
            return Invoker.Call<bool>(0x20B711662962B472, entity, animDict, animName, p3);
        }

        public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(int entity)
        {
            return Invoker.Call<bool>(0x95EB9964FF5C5C65, entity);
        }

        public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(int entity)
        {
            return Invoker.Call<bool>(0x605F5A140F202491, entity);
        }

        public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(int entity)
        {
            return Invoker.Call<bool>(0xDFD5033FDBA0A9C8, entity);
        }

        public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(int entity1, int entity2, bool p2)
        {
            return Invoker.Call<bool>(0xC86D67D52A707CF8, entity1, entity2, p2);
        }

        public static bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY(int entity1, int entity2, int traceType)
        {
            return Invoker.Call<bool>(0xFCDFF7B72D23A1AC, entity1, entity2, traceType);
        }

        public static bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(int entity1, int entity2)
        {
            return Invoker.Call<bool>(0x0267D00AF114F17A, entity1, entity2);
        }

        public static bool HAS_ENTITY_COLLIDED_WITH_ANYTHING(int entity)
        {
            return Invoker.Call<bool>(0x8BAD02F0368D9E14, entity);
        }

        public static int GET_LAST_MATERIAL_HIT_BY_ENTITY(int entity)
        {
            return Invoker.Call<int>(0x5C3D0A935F535C4C, entity);
        }

        public static Vector3 GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY(int entity)
        {
            return Invoker.Call<Vector3>(0xE465D4AB7CA6AE72, entity);
        }

        public static void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(int entity)
        {
            Invoker.Call<Void>(0x40FDEDB72F8293B2, entity);
        }

        public static float GET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDict, string animName)
        {
            return Invoker.Call<float>(0x346D81500D088F42, entity, animDict, animName);
        }

        public static float GET_ENTITY_ANIM_TOTAL_TIME(int entity, string animDict, string animName)
        {
            return Invoker.Call<float>(0x50BD2730B191E360, entity, animDict, animName);
        }

        public static float _GET_ANIM_DURATION(string animDict, string animName)
        {
            return Invoker.Call<float>(0xFEDDF04D62B8D790, animDict, animName);
        }

        public static int GET_ENTITY_ATTACHED_TO(int entity)
        {
            return Invoker.Call<int>(0x48C2BED9180FE123, entity);
        }

        public static Vector3 GET_ENTITY_COORDS(int entity, bool alive)
        {
            return Invoker.Call<Vector3>(0x3FEF770D40960D5A, entity, alive);
        }

        public static Vector3 GET_ENTITY_FORWARD_VECTOR(int entity)
        {
            return Invoker.Call<Vector3>(0x0A794A5A57F8DF91, entity);
        }

        public static float GET_ENTITY_FORWARD_X(int entity)
        {
            return Invoker.Call<float>(0x8BB4EF4214E0E6D5, entity);
        }

        public static float GET_ENTITY_FORWARD_Y(int entity)
        {
            return Invoker.Call<float>(0x866A4A5FAE349510, entity);
        }

        public static float GET_ENTITY_HEADING(int entity)
        {
            return Invoker.Call<float>(0xE83D4F9BA2A38914, entity);
        }

        public static float _GET_ENTITY_PHYSICS_HEADING(int entity)
        {
            return Invoker.Call<float>(0x846BF6291198A71E, entity);
        }

        public static int GET_ENTITY_HEALTH(int entity)
        {
            return Invoker.Call<int>(0xEEF059FAD016D209, entity);
        }

        public static int GET_ENTITY_MAX_HEALTH(int entity)
        {
            return Invoker.Call<int>(0x15D757606D170C3C, entity);
        }

        public static void SET_ENTITY_MAX_HEALTH(int entity, int value)
        {
            Invoker.Call<Void>(0x166E7CF68597D8B5, entity, value);
        }

        public static float GET_ENTITY_HEIGHT(int entity, float X, float Y, float Z, bool atTop, bool inWorldCoords)
        {
            return Invoker.Call<float>(0x5A504562485944DD, entity, X, Y, Z, atTop, inWorldCoords);
        }

        public static float GET_ENTITY_HEIGHT_ABOVE_GROUND(int entity)
        {
            return Invoker.Call<float>(0x1DD55701034110E5, entity);
        }

        public static void GET_ENTITY_MATRIX(int entity, ulong rightVector_ptr, ulong forwardVector_ptr, ulong upVector_ptr, ulong position_ptr)
        {
            Invoker.Call<Void>(0xECB2FC7235A7D137, entity, rightVector_ptr, forwardVector_ptr, upVector_ptr, position_ptr);
        }

        public static int GET_ENTITY_MODEL(int entity)
        {
            return Invoker.Call<int>(0x9F47B058362C84B5, entity);
        }

        public static Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(int entity, float posX, float posY, float posZ)
        {
            return Invoker.Call<Vector3>(0x2274BC1C4885E333, entity, posX, posY, posZ);
        }

        public static Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int entity, float offsetX, float offsetY, float offsetZ)
        {
            return Invoker.Call<Vector3>(0x1899F328B0E12848, entity, offsetX, offsetY, offsetZ);
        }

        public static float GET_ENTITY_PITCH(int entity)
        {
            return Invoker.Call<float>(0xD45DC2893621E1FE, entity);
        }

        public static void GET_ENTITY_QUATERNION(int entity, ulong x_ptr, ulong y_ptr, ulong z_ptr, ulong w_ptr)
        {
            Invoker.Call<Void>(0x7B3703D2D32DFA18, entity, x_ptr, y_ptr, z_ptr, w_ptr);
        }

        public static float GET_ENTITY_ROLL(int entity)
        {
            return Invoker.Call<float>(0x831E0242595560DF, entity);
        }

        public static Vector3 GET_ENTITY_ROTATION(int entity, int rotationOrder)
        {
            return Invoker.Call<Vector3>(0xAFBD61CC738D9EB9, entity, rotationOrder);
        }

        public static Vector3 GET_ENTITY_ROTATION_VELOCITY(int entity)
        {
            return Invoker.Call<Vector3>(0x213B91045D09B983, entity);
        }

        public static string GET_ENTITY_SCRIPT(int entity, ulong script_ptr)
        {
            return Invoker.Call<string>(0xA6E9C38DB51D7748, entity, script_ptr);
        }

        public static float GET_ENTITY_SPEED(int entity)
        {
            return Invoker.Call<float>(0xD5037BA82E12416F, entity);
        }

        public static Vector3 GET_ENTITY_SPEED_VECTOR(int entity, bool relative)
        {
            return Invoker.Call<Vector3>(0x9A8D700A51CB7B0D, entity, relative);
        }

        public static float GET_ENTITY_UPRIGHT_VALUE(int entity)
        {
            return Invoker.Call<float>(0x95EED5A694951F9F, entity);
        }

        public static Vector3 GET_ENTITY_VELOCITY(int entity)
        {
            return Invoker.Call<Vector3>(0x4805D2B1D8CF94A9, entity);
        }

        public static int GET_OBJECT_INDEX_FROM_ENTITY_INDEX(int entity)
        {
            return Invoker.Call<int>(0xD7E3B9735C0F89D6, entity);
        }

        public static int GET_PED_INDEX_FROM_ENTITY_INDEX(int entity)
        {
            return Invoker.Call<int>(0x04A2A40C73395041, entity);
        }

        public static int GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(int entity)
        {
            return Invoker.Call<int>(0x4B53F92932ADFAC0, entity);
        }

        public static Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(int entity, int boneIndex)
        {
            return Invoker.Call<Vector3>(0x44A8FCB8ED227738, entity, boneIndex);
        }

        public static int GET_NEAREST_PLAYER_TO_ENTITY(int entity)
        {
            return Invoker.Call<int>(0x7196842CB375CDB3, entity);
        }

        public static int GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(int entity, int team)
        {
            return Invoker.Call<int>(0x4DC9A62F844D9337, entity, team);
        }

        public static int GET_ENTITY_TYPE(int entity)
        {
            return Invoker.Call<int>(0x8ACD366038D14505, entity);
        }

        public static int _GET_ENTITY_POPULATION_TYPE(int entity)
        {
            return Invoker.Call<int>(0xF6F5161F4534EDFF, entity);
        }

        public static bool IS_AN_ENTITY(int handle)
        {
            return Invoker.Call<bool>(0x731EC8A916BD11A1, handle);
        }

        public static bool IS_ENTITY_A_PED(int entity)
        {
            return Invoker.Call<bool>(0x524AC5ECEA15343E, entity);
        }

        public static bool IS_ENTITY_A_MISSION_ENTITY(int entity)
        {
            return Invoker.Call<bool>(0x0A7B270912999B3C, entity);
        }

        public static bool IS_ENTITY_A_VEHICLE(int entity)
        {
            return Invoker.Call<bool>(0x6AC7003FA6E5575E, entity);
        }

        public static bool IS_ENTITY_AN_OBJECT(int entity)
        {
            return Invoker.Call<bool>(0x8D68C8FD0FACA94E, entity);
        }

        public static bool IS_ENTITY_AT_COORD(int entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, bool p7, bool p8, int p9)
        {
            return Invoker.Call<bool>(0x20B60995556D004F, entity, xPos, yPos, zPos, xSize, ySize, zSize, p7, p8, p9);
        }

        public static bool IS_ENTITY_AT_ENTITY(int entity1, int entity2, float xSize, float ySize, float zSize, bool p5, bool p6, int p7)
        {
            return Invoker.Call<bool>(0x751B70C3D034E187, entity1, entity2, xSize, ySize, zSize, p5, p6, p7);
        }

        public static bool IS_ENTITY_ATTACHED(int entity)
        {
            return Invoker.Call<bool>(0xB346476EF1A64897, entity);
        }

        public static bool IS_ENTITY_ATTACHED_TO_ANY_OBJECT(int entity)
        {
            return Invoker.Call<bool>(0xCF511840CEEDE0CC, entity);
        }

        public static bool IS_ENTITY_ATTACHED_TO_ANY_PED(int entity)
        {
            return Invoker.Call<bool>(0xB1632E9A5F988D11, entity);
        }

        public static bool IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(int entity)
        {
            return Invoker.Call<bool>(0x26AA915AD89BFB4B, entity);
        }

        public static bool IS_ENTITY_ATTACHED_TO_ENTITY(int from, int to)
        {
            return Invoker.Call<bool>(0xEFBE71898A993728, from, to);
        }

        public static bool IS_ENTITY_DEAD(int entity)
        {
            return Invoker.Call<bool>(0x5F9532F3B5CC2551, entity);
        }

        public static bool IS_ENTITY_IN_AIR(int entity)
        {
            return Invoker.Call<bool>(0x886E37EC497200B6, entity);
        }

        public static bool IS_ENTITY_IN_ANGLED_AREA(int entity, float originX, float originY, float originZ, float edgeX, float edgeY, float edgeZ, float angle, bool p8, bool p9, int p10)
        {
            return Invoker.Call<bool>(0x51210CED3DA1C78A, entity, originX, originY, originZ, edgeX, edgeY, edgeZ, angle, p8, p9, p10);
        }

        public static bool IS_ENTITY_IN_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8, int p9)
        {
            return Invoker.Call<bool>(0x54736AA40E271165, entity, x1, y1, z1, x2, y2, z2, p7, p8, p9);
        }

        public static bool IS_ENTITY_IN_ZONE(int entity, string zone)
        {
            return Invoker.Call<bool>(0xB6463CF6AF527071, entity, zone);
        }

        public static bool IS_ENTITY_IN_WATER(int entity)
        {
            return Invoker.Call<bool>(0xCFB0A0D8EDD145A3, entity);
        }

        public static float GET_ENTITY_SUBMERGED_LEVEL(int entity)
        {
            return Invoker.Call<float>(0xE81AFC1BC4CC41CE, entity);
        }

        public static void _0x694E00132F2823ED(int entity, bool p1)
        {
            Invoker.Call<Void>(0x694E00132F2823ED, entity, p1);
        }

        public static bool IS_ENTITY_ON_SCREEN(int entity)
        {
            return Invoker.Call<bool>(0xE659E47AF827484B, entity);
        }

        public static bool IS_ENTITY_PLAYING_ANIM(int entity, string animDict, string animName, int taskFlag)
        {
            return Invoker.Call<bool>(0x1F0B79228E461EC9, entity, animDict, animName, taskFlag);
        }

        public static bool IS_ENTITY_STATIC(int entity)
        {
            return Invoker.Call<bool>(0x1218E6886D3D8327, entity);
        }

        public static bool IS_ENTITY_TOUCHING_ENTITY(int entity, int targetEntity)
        {
            return Invoker.Call<bool>(0x17FFC1B2BA35A494, entity, targetEntity);
        }

        public static bool IS_ENTITY_TOUCHING_MODEL(int entity, int modelHash)
        {
            return Invoker.Call<bool>(0x0F42323798A58C8C, entity, modelHash);
        }

        public static bool IS_ENTITY_UPRIGHT(int entity, float angle)
        {
            return Invoker.Call<bool>(0x5333F526F6AB19AA, entity, angle);
        }

        public static bool IS_ENTITY_UPSIDEDOWN(int entity)
        {
            return Invoker.Call<bool>(0x1DBD58820FA61D71, entity);
        }

        public static bool IS_ENTITY_VISIBLE(int entity)
        {
            return Invoker.Call<bool>(0x47D6F43D77935C75, entity);
        }

        public static bool IS_ENTITY_VISIBLE_TO_SCRIPT(int entity)
        {
            return Invoker.Call<bool>(0xD796CB5BA8F20E32, entity);
        }

        public static bool IS_ENTITY_OCCLUDED(int entity)
        {
            return Invoker.Call<bool>(0xE31C2C72B8692B64, entity);
        }

        public static bool WOULD_ENTITY_BE_OCCLUDED(int entityModelHash, float x, float y, float z, bool p4)
        {
            return Invoker.Call<bool>(0xEE5D2A122E09EC42, entityModelHash, x, y, z, p4);
        }

        public static bool IS_ENTITY_WAITING_FOR_WORLD_COLLISION(int entity)
        {
            return Invoker.Call<bool>(0xD05BFF0C0A12C68F, entity);
        }

        public static void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(int entity, int forceType, float x, float y, float z, bool p5, bool isDirectionRel, bool isForceRel, bool p8)
        {
            Invoker.Call<Void>(0x18FF00FC7EFF559E, entity, forceType, x, y, z, p5, isDirectionRel, isForceRel, p8);
        }

        public static void APPLY_FORCE_TO_ENTITY(int entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, bool isDirectionRel, bool ignoreUpVec, bool isForceRel, bool p12, bool p13)
        {
            Invoker.Call<Void>(0xC5F68BE9613E2D18, entity, forceFlags, x, y, z, offX, offY, offZ, boneIndex, isDirectionRel, ignoreUpVec, isForceRel, p12, p13);
        }

        public static void ATTACH_ENTITY_TO_ENTITY(int entity1, int entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, bool p9, bool useSoftPinning, bool collision, bool isPed, int vertexIndex, bool fixedRot)
        {
            Invoker.Call<Void>(0x6B9BBD38AB0796DF, entity1, entity2, boneIndex, xPos, yPos, zPos, xRot, yRot, zRot, p9, useSoftPinning, collision, isPed, vertexIndex, fixedRot);
        }

        public static void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int entity1, int entity2, int boneIndex1, int boneIndex2, float xPos1, float yPos1, float zPos1, float xPos2, float yPos2, float zPos2, float xRot, float yRot, float zRot, float breakForce, bool fixedRot, bool p15, bool collision, bool teleport, int p18)
        {
            Invoker.Call<Void>(0xC3675780C92F90F9, entity1, entity2, boneIndex1, boneIndex2, xPos1, yPos1, zPos1, xPos2, yPos2, zPos2, xRot, yRot, zRot, breakForce, fixedRot, p15, collision, teleport, p18);
        }

        public static void PROCESS_ENTITY_ATTACHMENTS(int entity)
        {
            Invoker.Call<Void>(0xF4080490ADC51C6F, entity);
        }

        public static int GET_ENTITY_BONE_INDEX_BY_NAME(int entity, string boneName)
        {
            return Invoker.Call<int>(0xFB71170B7E76ACBA, entity, boneName);
        }

        public static int CLEAR_ENTITY_LAST_DAMAGE_ENTITY(int entity)
        {
            return Invoker.Call<int>(0xA72CD9CA74A5ECBA, entity);
        }

        public static void DELETE_ENTITY(ulong entity_ptr)
        {
            Invoker.Call<Void>(0xAE3CBE5BF394C9C9, entity_ptr);
        }

        public static void DETACH_ENTITY(int entity, bool p1, bool collision)
        {
            Invoker.Call<Void>(0x961AC54BF0613F5D, entity, p1, collision);
        }

        public static void FREEZE_ENTITY_POSITION(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x428CA6DBD1094446, entity, toggle);
        }

        public static void _SET_ENTITY_SOMETHING(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x3910051CCECDB00C, entity, toggle);
        }

        public static bool PLAY_ENTITY_ANIM(int entity, string animName, string animDict, float p3, bool loop, bool stayInAnim, bool p6, float delta, int bitset)
        {
            return Invoker.Call<bool>(0x7FB218262B810701, entity, animName, animDict, p3, loop, stayInAnim, p6, delta, bitset);
        }

        public static bool PLAY_SYNCHRONIZED_ENTITY_ANIM(int entity, int syncedScene, string animation, string propName, float p4, float p5, int p6, float p7)
        {
            return Invoker.Call<bool>(0xC77720A12FE14A86, entity, syncedScene, animation, propName, p4, p5, p6, p7);
        }

        public static bool PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM(float p0, float p1, float p2, float p3, int p4, int p5, ulong p6_ptr, ulong p7_ptr, float p8, float p9, int p10, float p11)
        {
            return Invoker.Call<bool>(0xB9C54555ED30FBC4, p0, p1, p2, p3, p4, p5, p6_ptr, p7_ptr, p8, p9, p10, p11);
        }

        public static bool STOP_SYNCHRONIZED_MAP_ENTITY_ANIM(float p0, float p1, float p2, float p3, int p4, float p5)
        {
            return Invoker.Call<bool>(0x11E79CAB7183B6F5, p0, p1, p2, p3, p4, p5);
        }

        public static int STOP_ENTITY_ANIM(int entity, string animation, string animGroup, float p3)
        {
            return Invoker.Call<int>(0x28004F88151E03E0, entity, animation, animGroup, p3);
        }

        public static bool STOP_SYNCHRONIZED_ENTITY_ANIM(int entity, float p1, bool p2)
        {
            return Invoker.Call<bool>(0x43D3807C077261E3, entity, p1, p2);
        }

        public static bool HAS_ANIM_EVENT_FIRED(int entity, int actionHash)
        {
            return Invoker.Call<bool>(0xEAF4CD9EA3E7E922, entity, actionHash);
        }

        public static bool FIND_ANIM_EVENT_PHASE(string animDictionary, string animName, string p2, ulong p3_ptr, ulong p4_ptr)
        {
            return Invoker.Call<bool>(0x07F1BE2BCCAA27A7, animDictionary, animName, p2, p3_ptr, p4_ptr);
        }

        public static void SET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDictionary, string animName, float time)
        {
            Invoker.Call<Void>(0x4487C259F0F70977, entity, animDictionary, animName, time);
        }

        public static void SET_ENTITY_ANIM_SPEED(int entity, string animDictionary, string animName, float speedMultiplier)
        {
            Invoker.Call<Void>(0x28D1A16553C51776, entity, animDictionary, animName, speedMultiplier);
        }

        public static void SET_ENTITY_AS_MISSION_ENTITY(int entity, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xAD738C3085FE7E11, entity, p1, p2);
        }

        public static void SET_ENTITY_AS_NO_LONGER_NEEDED(ulong entity_ptr)
        {
            Invoker.Call<Void>(0xB736A491E64A32CF, entity_ptr);
        }

        public static void SET_PED_AS_NO_LONGER_NEEDED(ulong ped_ptr)
        {
            Invoker.Call<Void>(0x2595DD4236549CE3, ped_ptr);
        }

        public static void SET_VEHICLE_AS_NO_LONGER_NEEDED(ulong vehicle_ptr)
        {
            Invoker.Call<Void>(0x629BFA74418D6239, vehicle_ptr);
        }

        public static void SET_OBJECT_AS_NO_LONGER_NEEDED(ulong _object_ptr)
        {
            Invoker.Call<Void>(0x3AE22DEB5BA5A3E6, _object_ptr);
        }

        public static void SET_ENTITY_CAN_BE_DAMAGED(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x1760FFA8AB074D66, entity, toggle);
        }

        public static void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool bCanBeDamaged, int relGroup)
        {
            Invoker.Call<Void>(0xE22D8FDE858B8119, entity, bCanBeDamaged, relGroup);
        }

        public static void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(int entity, bool toggle)
        {
            Invoker.Call<Void>(0xD3997889736FD899, entity, toggle);
        }

        public static void SET_ENTITY_COLLISION(int entity, bool toggle, bool keepPhysics)
        {
            Invoker.Call<Void>(0x1A9205C1B9EE827F, entity, toggle, keepPhysics);
        }

        public static bool _GET_ENTITY_COLLISON_DISABLED(int entity)
        {
            return Invoker.Call<bool>(0xCCF1E97BEFDAE480, entity);
        }

        public static void _SET_ENTITY_COLLISION_2(int entity, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x9EBC85ED0FFFE51C, entity, p1, p2);
        }

        public static void SET_ENTITY_COORDS(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)
        {
            Invoker.Call<Void>(0x06843DA7060A026B, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis, clearArea);
        }

        public static void _SET_ENTITY_COORDS_2(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)
        {
            Invoker.Call<Void>(0x621873ECE1178967, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis, clearArea);
        }

        public static void SET_ENTITY_COORDS_NO_OFFSET(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis)
        {
            Invoker.Call<Void>(0x239A3351AC1DA385, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis);
        }

        public static void SET_ENTITY_DYNAMIC(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x1718DE8E3F2823CA, entity, toggle);
        }

        public static void SET_ENTITY_HEADING(int entity, float heading)
        {
            Invoker.Call<Void>(0x8E2530AA8ADA980E, entity, heading);
        }

        public static void SET_ENTITY_HEALTH(int entity, int health)
        {
            Invoker.Call<Void>(0x6B76DC1F3AE6E6A3, entity, health);
        }

        public static void SET_ENTITY_INVINCIBLE(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x3882114BDE571AD4, entity, toggle);
        }

        public static void SET_ENTITY_IS_TARGET_PRIORITY(int entity, bool p1, float p2)
        {
            Invoker.Call<Void>(0xEA02E132F5C68722, entity, p1, p2);
        }

        public static void SET_ENTITY_LIGHTS(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x7CFBA6A80BDF3874, entity, toggle);
        }

        public static void SET_ENTITY_LOAD_COLLISION_FLAG(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x0DC7CABAB1E9B67E, entity, toggle);
        }

        public static bool HAS_COLLISION_LOADED_AROUND_ENTITY(int entity)
        {
            return Invoker.Call<bool>(0xE9676F61BC0B3321, entity);
        }

        public static void SET_ENTITY_MAX_SPEED(int entity, float speed)
        {
            Invoker.Call<Void>(0x0E46A3FCBDE2A1B1, entity, speed);
        }

        public static void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x79F020FF9EDC0748, entity, toggle);
        }

        public static void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, bool p1, int relationshipHash)
        {
            Invoker.Call<Void>(0x7022BD828FA0B082, entity, p1, relationshipHash);
        }

        public static void SET_ENTITY_PROOFS(int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool p6, bool p7, bool p8)
        {
            Invoker.Call<Void>(0xFAEE099C6F890BB8, entity, bulletProof, fireProof, explosionProof, collisionProof, meleeProof, p6, p7, p8);
        }

        public static void SET_ENTITY_QUATERNION(int entity, float x, float y, float z, float w)
        {
            Invoker.Call<Void>(0x77B21BE7AC540F07, entity, x, y, z, w);
        }

        public static void SET_ENTITY_RECORDS_COLLISIONS(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x0A50A1EEDAD01E65, entity, toggle);
        }

        public static void SET_ENTITY_ROTATION(int entity, float pitch, float roll, float yaw, int rotationOrder, bool p5)
        {
            Invoker.Call<Void>(0x8524A8B0171D5E07, entity, pitch, roll, yaw, rotationOrder, p5);
        }

        public static void SET_ENTITY_VISIBLE(int entity, bool toggle, bool unk)
        {
            Invoker.Call<Void>(0xEA1C610A04DB6BBB, entity, toggle, unk);
        }

        public static void SET_ENTITY_VELOCITY(int entity, float x, float y, float z)
        {
            Invoker.Call<Void>(0x1C99BB7B6E96D16F, entity, x, y, z);
        }

        public static void SET_ENTITY_HAS_GRAVITY(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x4A4722448F18EEF5, entity, toggle);
        }

        public static void SET_ENTITY_LOD_DIST(int entity, int value)
        {
            Invoker.Call<Void>(0x5927F96A78577363, entity, value);
        }

        public static int GET_ENTITY_LOD_DIST(int entity)
        {
            return Invoker.Call<int>(0x4159C2762B5791D6, entity);
        }

        public static void SET_ENTITY_ALPHA(int entity, int alphaLevel, int skin)
        {
            Invoker.Call<Void>(0x44A0870B7E92D7C0, entity, alphaLevel, skin);
        }

        public static int GET_ENTITY_ALPHA(int entity)
        {
            return Invoker.Call<int>(0x5A47B3B5E63E94C6, entity);
        }

        public static int RESET_ENTITY_ALPHA(int entity)
        {
            return Invoker.Call<int>(0x9B1E824FFBB7027A, entity);
        }

        public static void _0x5C3B791D580E0BC2(int entity, float p1)
        {
            Invoker.Call<Void>(0x5C3B791D580E0BC2, entity, p1);
        }

        public static void SET_ENTITY_ALWAYS_PRERENDER(int entity, bool toggle)
        {
            Invoker.Call<Void>(0xACAD101E1FB66689, entity, toggle);
        }

        public static void SET_ENTITY_RENDER_SCORCHED(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x730F5F8D3F0F2050, entity, toggle);
        }

        public static void SET_ENTITY_TRAFFICLIGHT_OVERRIDE(int entity, int state)
        {
            Invoker.Call<Void>(0x57C5DB656185EAC4, entity, state);
        }

        public static void _0x78E8E3A640178255(int entity)
        {
            Invoker.Call<Void>(0x78E8E3A640178255, entity);
        }

        public static void CREATE_MODEL_SWAP(float x, float y, float z, float radius, int originalModel, int newModel, bool p6)
        {
            Invoker.Call<Void>(0x92C47782FDA8B2A3, x, y, z, radius, originalModel, newModel, p6);
        }

        public static void REMOVE_MODEL_SWAP(float x, float y, float z, float radius, int originalModel, int newModel, bool p6)
        {
            Invoker.Call<Void>(0x033C0F9A64E229AE, x, y, z, radius, originalModel, newModel, p6);
        }

        public static void CREATE_MODEL_HIDE(float x, float y, float z, float radius, int model, bool p5)
        {
            Invoker.Call<Void>(0x8A97BCA30A0CE478, x, y, z, radius, model, p5);
        }

        public static void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x, float y, float z, float radius, int model, bool p5)
        {
            Invoker.Call<Void>(0x3A52AE588830BF7F, x, y, z, radius, model, p5);
        }

        public static void REMOVE_MODEL_HIDE(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0xD9E3006FB3CBD765, p0, p1, p2, p3, p4, p5);
        }

        public static void CREATE_FORCED_OBJECT(float x, float y, float z, int p3, int modelHash, bool p5)
        {
            Invoker.Call<Void>(0x150E808B375A385A, x, y, z, p3, modelHash, p5);
        }

        public static void REMOVE_FORCED_OBJECT(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x61B6775E83C0DB6F, p0, p1, p2, p3, p4);
        }

        public static void SET_ENTITY_NO_COLLISION_ENTITY(int entity1, int entity2, bool unknown)
        {
            Invoker.Call<Void>(0xA53ED5520C07654A, entity1, entity2, unknown);
        }

        public static void SET_ENTITY_MOTION_BLUR(int entity, bool toggle)
        {
            Invoker.Call<Void>(0x295D82A8559F9150, entity, toggle);
        }

        public static void _0xE12ABE5E3A389A6C(int entity, bool p1)
        {
            Invoker.Call<Void>(0xE12ABE5E3A389A6C, entity, p1);
        }

        public static void _0xA80AE305E0A3044F(int entity, bool p1)
        {
            Invoker.Call<Void>(0xA80AE305E0A3044F, entity, p1);
        }

        public static void _0xDC6F8601FAF2E893(int entity, bool p1)
        {
            Invoker.Call<Void>(0xDC6F8601FAF2E893, entity, p1);
        }

        public static void _0x2C2E3DC128F44309(int entity, bool p1)
        {
            Invoker.Call<Void>(0x2C2E3DC128F44309, entity, p1);
        }

        public static void _0x1A092BB0C3808B96(int entity, bool p1)
        {
            Invoker.Call<Void>(0x1A092BB0C3808B96, entity, p1);
        }

    }

    public static class PED
    {

        public static int CREATE_PED(int pedType, int modelHash, float x, float y, float z, float heading, bool isNetwork, bool thisScriptCheck)
        {
            return Invoker.Call<int>(0xD49F9B0955C367DE, pedType, modelHash, x, y, z, heading, isNetwork, thisScriptCheck);
        }

        public static void DELETE_PED(ulong ped_ptr)
        {
            Invoker.Call<Void>(0x9614299DCB53E54B, ped_ptr);
        }

        public static int CLONE_PED(int ped, float heading, bool isNetwork, bool thisScriptCheck)
        {
            return Invoker.Call<int>(0xEF29A16337FACADB, ped, heading, isNetwork, thisScriptCheck);
        }

        public static void CLONE_PED_TO_TARGET(int ped, int targetPed)
        {
            Invoker.Call<Void>(0xE952D6431689AD9A, ped, targetPed);
        }

        public static bool IS_PED_IN_VEHICLE(int ped, int vehicle, bool atGetIn)
        {
            return Invoker.Call<bool>(0xA3EE4A07279BB9DB, ped, vehicle, atGetIn);
        }

        public static bool IS_PED_IN_MODEL(int ped, int modelHash)
        {
            return Invoker.Call<bool>(0x796D90EFB19AA332, ped, modelHash);
        }

        public static bool IS_PED_IN_ANY_VEHICLE(int ped, bool atGetIn)
        {
            return Invoker.Call<bool>(0x997ABD671D25CA0B, ped, atGetIn);
        }

        public static bool IS_COP_PED_IN_AREA_3D(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<bool>(0x16EC4839969F9F5E, x1, y1, z1, x2, y2, z2);
        }

        public static bool IS_PED_INJURED(int ped)
        {
            return Invoker.Call<bool>(0x84A2DD9AC37C35C1, ped);
        }

        public static bool IS_PED_HURT(int ped)
        {
            return Invoker.Call<bool>(0x5983BB449D7FDB12, ped);
        }

        public static bool IS_PED_FATALLY_INJURED(int ped)
        {
            return Invoker.Call<bool>(0xD839450756ED5A80, ped);
        }

        public static bool IS_PED_DEAD_OR_DYING(int ped, bool p1)
        {
            return Invoker.Call<bool>(0x3317DEDB88C95038, ped, p1);
        }

        public static bool IS_CONVERSATION_PED_DEAD(int ped)
        {
            return Invoker.Call<bool>(0xE0A0AEC214B1FABA, ped);
        }

        public static bool IS_PED_AIMING_FROM_COVER(int ped)
        {
            return Invoker.Call<bool>(0x3998B1276A3300E5, ped);
        }

        public static bool IS_PED_RELOADING(int ped)
        {
            return Invoker.Call<bool>(0x24B100C68C645951, ped);
        }

        public static bool IS_PED_A_PLAYER(int ped)
        {
            return Invoker.Call<bool>(0x12534C348C6CB68B, ped);
        }

        public static int CREATE_PED_INSIDE_VEHICLE(int vehicle, int pedType, int modelHash, int seat, bool isNetwork, bool thisScriptCheck)
        {
            return Invoker.Call<int>(0x7DD959874C1FD534, vehicle, pedType, modelHash, seat, isNetwork, thisScriptCheck);
        }

        public static void SET_PED_DESIRED_HEADING(int ped, float heading)
        {
            Invoker.Call<Void>(0xAA5A7ECE2AA8FE70, ped, heading);
        }

        public static void _FREEZE_PED_CAMERA_ROTATION(int ped)
        {
            Invoker.Call<Void>(0xFF287323B0E2C69A, ped);
        }

        public static bool IS_PED_FACING_PED(int ped, int otherPed, float angle)
        {
            return Invoker.Call<bool>(0xD71649DB0A545AA3, ped, otherPed, angle);
        }

        public static bool IS_PED_IN_MELEE_COMBAT(int ped)
        {
            return Invoker.Call<bool>(0x4E209B2C1EAD5159, ped);
        }

        public static bool IS_PED_STOPPED(int ped)
        {
            return Invoker.Call<bool>(0x530944F6F4B8A214, ped);
        }

        public static bool IS_PED_SHOOTING_IN_AREA(int ped, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8)
        {
            return Invoker.Call<bool>(0x7E9DFE24AC1E58EF, ped, x1, y1, z1, x2, y2, z2, p7, p8);
        }

        public static bool IS_ANY_PED_SHOOTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7)
        {
            return Invoker.Call<bool>(0xA0D3D71EA1086C55, x1, y1, z1, x2, y2, z2, p6, p7);
        }

        public static bool IS_PED_SHOOTING(int ped)
        {
            return Invoker.Call<bool>(0x34616828CD07F1A1, ped);
        }

        public static int SET_PED_ACCURACY(int ped, int accuracy)
        {
            return Invoker.Call<int>(0x7AEFB85C1D49DEB6, ped, accuracy);
        }

        public static int GET_PED_ACCURACY(int ped)
        {
            return Invoker.Call<int>(0x37F4AD56ECBC0CD6, ped);
        }

        public static bool IS_PED_MODEL(int ped, int modelHash)
        {
            return Invoker.Call<bool>(0xC9D55B1A358A5BF7, ped, modelHash);
        }

        public static void EXPLODE_PED_HEAD(int ped, int weaponHash)
        {
            Invoker.Call<Void>(0x2D05CED3A38D0F3A, ped, weaponHash);
        }

        public static void REMOVE_PED_ELEGANTLY(ulong ped_ptr)
        {
            Invoker.Call<Void>(0xAC6D445B994DF95E, ped_ptr);
        }

        public static void ADD_ARMOUR_TO_PED(int ped, int amount)
        {
            Invoker.Call<Void>(0x5BA652A0CD14DF2F, ped, amount);
        }

        public static void SET_PED_ARMOUR(int ped, int amount)
        {
            Invoker.Call<Void>(0xCEA04D83135264CC, ped, amount);
        }

        public static void SET_PED_INTO_VEHICLE(int ped, int vehicle, int seatIndex)
        {
            Invoker.Call<Void>(0xF75B0D629E1C063D, ped, vehicle, seatIndex);
        }

        public static void SET_PED_ALLOW_VEHICLES_OVERRIDE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x3C028C636A414ED9, ped, toggle);
        }

        public static bool CAN_CREATE_RANDOM_PED(bool unk)
        {
            return Invoker.Call<bool>(0x3E8349C08E4B82E4, unk);
        }

        public static int CREATE_RANDOM_PED(float posX, float posY, float posZ)
        {
            return Invoker.Call<int>(0xB4AC7D0CF06BFE8F, posX, posY, posZ);
        }

        public static int CREATE_RANDOM_PED_AS_DRIVER(int vehicle, bool returnHandle)
        {
            return Invoker.Call<int>(0x9B62392B474F44A0, vehicle, returnHandle);
        }

        public static bool CAN_CREATE_RANDOM_DRIVER()
        {
            return Invoker.Call<bool>(0xB8EB95E5B4E56978);
        }

        public static bool CAN_CREATE_RANDOM_BIKE_RIDER()
        {
            return Invoker.Call<bool>(0xEACEEDA81751915C);
        }

        public static void SET_PED_MOVE_ANIMS_BLEND_OUT(int ped)
        {
            Invoker.Call<Void>(0x9E8C908F41584ECD, ped);
        }

        public static void SET_PED_CAN_BE_DRAGGED_OUT(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xC1670E958EEE24E5, ped, toggle);
        }

        public static void _0xF2BEBCDFAFDAA19E(bool toggle)
        {
            Invoker.Call<Void>(0xF2BEBCDFAFDAA19E, toggle);
        }

        public static bool IS_PED_MALE(int ped)
        {
            return Invoker.Call<bool>(0x6D9F5FAA7488BA46, ped);
        }

        public static bool IS_PED_HUMAN(int ped)
        {
            return Invoker.Call<bool>(0xB980061DA992779D, ped);
        }

        public static int GET_VEHICLE_PED_IS_IN(int ped, bool lastVehicle)
        {
            return Invoker.Call<int>(0x9A9112A0FE9A4713, ped, lastVehicle);
        }

        public static void RESET_PED_LAST_VEHICLE(int ped)
        {
            Invoker.Call<Void>(0xBB8DE8CF6A8DD8BB, ped);
        }

        public static void SET_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
        {
            Invoker.Call<Void>(0x95E3D6257B166CF2, multiplier);
        }

        public static void SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME(float p0, float p1)
        {
            Invoker.Call<Void>(0x7A556143A1C03898, p0, p1);
        }

        public static void _0x5A7F62FDA59759BD()
        {
            Invoker.Call<Void>(0x5A7F62FDA59759BD);
        }

        public static void SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME(float x, float y, float z)
        {
            Invoker.Call<Void>(0x5086C7843552CF85, x, y, z);
        }

        public static void SET_PED_NON_CREATION_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            Invoker.Call<Void>(0xEE01041D559983EA, x1, y1, z1, x2, y2, z2);
        }

        public static void CLEAR_PED_NON_CREATION_AREA()
        {
            Invoker.Call<Void>(0x2E05208086BA0651);
        }

        public static void _0x4759CC730F947C81()
        {
            Invoker.Call<Void>(0x4759CC730F947C81);
        }

        public static bool IS_PED_ON_MOUNT(int ped)
        {
            return Invoker.Call<bool>(0x460BC76A0E10655E, ped);
        }

        public static int GET_MOUNT(int ped)
        {
            return Invoker.Call<int>(0xE7E11B8DCBED1058, ped);
        }

        public static bool IS_PED_ON_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x67722AEB798E5FAB, ped);
        }

        public static bool IS_PED_ON_SPECIFIC_VEHICLE(int ped, int vehicle)
        {
            return Invoker.Call<bool>(0xEC5F66E459AF3BB2, ped, vehicle);
        }

        public static void SET_PED_MONEY(int ped, int amount)
        {
            Invoker.Call<Void>(0xA9C8960E8684C1B5, ped, amount);
        }

        public static int GET_PED_MONEY(int ped)
        {
            return Invoker.Call<int>(0x3F69145BBA87BAE7, ped);
        }

        public static void _0xFF4803BC019852D9(float p0, int p1)
        {
            Invoker.Call<Void>(0xFF4803BC019852D9, p0, p1);
        }

        public static void _0x6B0E6172C9A4D902(bool p0)
        {
            Invoker.Call<Void>(0x6B0E6172C9A4D902, p0);
        }

        public static void _0x9911F4A24485F653(bool p0)
        {
            Invoker.Call<Void>(0x9911F4A24485F653, p0);
        }

        public static void SET_PED_SUFFERS_CRITICAL_HITS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xEBD76F2359F190AC, ped, toggle);
        }

        public static void _0xAFC976FD0580C7B3(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xAFC976FD0580C7B3, ped, toggle);
        }

        public static bool IS_PED_SITTING_IN_VEHICLE(int ped, int vehicle)
        {
            return Invoker.Call<bool>(0xA808AA1D79230FC2, ped, vehicle);
        }

        public static bool IS_PED_SITTING_IN_ANY_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x826AA586EDB9FEF8, ped);
        }

        public static bool IS_PED_ON_FOOT(int ped)
        {
            return Invoker.Call<bool>(0x01FEE67DB37F59B2, ped);
        }

        public static bool IS_PED_ON_ANY_BIKE(int ped)
        {
            return Invoker.Call<bool>(0x94495889E22C6479, ped);
        }

        public static bool IS_PED_PLANTING_BOMB(int ped)
        {
            return Invoker.Call<bool>(0xC70B5FAE151982D8, ped);
        }

        public static Vector3 GET_DEAD_PED_PICKUP_COORDS(int ped, float p1, float p2)
        {
            return Invoker.Call<Vector3>(0xCD5003B097200F36, ped, p1, p2);
        }

        public static bool IS_PED_IN_ANY_BOAT(int ped)
        {
            return Invoker.Call<bool>(0x2E0E1C2B4F6CB339, ped);
        }

        public static bool IS_PED_IN_ANY_SUB(int ped)
        {
            return Invoker.Call<bool>(0xFBFC01CCFB35D99E, ped);
        }

        public static bool IS_PED_IN_ANY_HELI(int ped)
        {
            return Invoker.Call<bool>(0x298B91AE825E5705, ped);
        }

        public static bool IS_PED_IN_ANY_PLANE(int ped)
        {
            return Invoker.Call<bool>(0x5FFF4CFC74D8FB80, ped);
        }

        public static bool IS_PED_IN_FLYING_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x9134873537FA419C, ped);
        }

        public static void SET_PED_DIES_IN_WATER(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x56CEF0AC79073BDE, ped, toggle);
        }

        public static void SET_PED_DIES_IN_SINKING_VEHICLE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xD718A22995E2B4BC, ped, toggle);
        }

        public static int GET_PED_ARMOUR(int ped)
        {
            return Invoker.Call<int>(0x9483AF821605B1D8, ped);
        }

        public static void SET_PED_STAY_IN_VEHICLE_WHEN_JACKED(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xEDF4079F9D54C9A1, ped, toggle);
        }

        public static void SET_PED_CAN_BE_SHOT_IN_VEHICLE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xC7EF1BA83230BA07, ped, toggle);
        }

        public static bool GET_PED_LAST_DAMAGE_BONE(int ped, ulong _outBone_ptr)
        {
            return Invoker.Call<bool>(0xD75960F6BD9EA49C, ped, _outBone_ptr);
        }

        public static void CLEAR_PED_LAST_DAMAGE_BONE(int ped)
        {
            Invoker.Call<Void>(0x8EF6B7AC68E2F01B, ped);
        }

        public static void SET_AI_WEAPON_DAMAGE_MODIFIER(float value)
        {
            Invoker.Call<Void>(0x1B1E2A40A65B8521, value);
        }

        public static void RESET_AI_WEAPON_DAMAGE_MODIFIER()
        {
            Invoker.Call<Void>(0xEA16670E7BA4743C);
        }

        public static void SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER(float modifier)
        {
            Invoker.Call<Void>(0x66460DEDDD417254, modifier);
        }

        public static void RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER()
        {
            Invoker.Call<Void>(0x46E56A7CD1D63C3F);
        }

        public static void _0x2F3C3D9F50681DE4(int p0, bool p1)
        {
            Invoker.Call<Void>(0x2F3C3D9F50681DE4, p0, p1);
        }

        public static void SET_PED_CAN_BE_TARGETTED(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x63F58F7C80513AAD, ped, toggle);
        }

        public static void SET_PED_CAN_BE_TARGETTED_BY_TEAM(int ped, int team, bool toggle)
        {
            Invoker.Call<Void>(0xBF1CA77833E58F2C, ped, team, toggle);
        }

        public static void SET_PED_CAN_BE_TARGETTED_BY_PLAYER(int ped, int player, bool toggle)
        {
            Invoker.Call<Void>(0x66B57B72E0836A76, ped, player, toggle);
        }

        public static void _0x061CB768363D6424(int p0, bool p1)
        {
            Invoker.Call<Void>(0x061CB768363D6424, p0, p1);
        }

        public static void SET_TIME_EXCLUSIVE_DISPLAY_TEXTURE(int p0, bool p1)
        {
            Invoker.Call<Void>(0xFD325494792302D7, p0, p1);
        }

        public static bool IS_PED_IN_ANY_POLICE_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x0BD04E29640C9C12, ped);
        }

        public static void FORCE_PED_TO_OPEN_PARACHUTE(int ped)
        {
            Invoker.Call<Void>(0x16E42E800B472221, ped);
        }

        public static bool IS_PED_IN_PARACHUTE_FREE_FALL(int ped)
        {
            return Invoker.Call<bool>(0x7DCE8BDA0F1C1200, ped);
        }

        public static bool IS_PED_FALLING(int ped)
        {
            return Invoker.Call<bool>(0xFB92A102F1C4DFA3, ped);
        }

        public static bool IS_PED_JUMPING(int ped)
        {
            return Invoker.Call<bool>(0xCEDABC5900A0BF97, ped);
        }

        public static bool IS_PED_CLIMBING(int ped)
        {
            return Invoker.Call<bool>(0x53E8CB4F48BFE623, ped);
        }

        public static bool IS_PED_VAULTING(int ped)
        {
            return Invoker.Call<bool>(0x117C70D1F5730B5E, ped);
        }

        public static bool IS_PED_DIVING(int ped)
        {
            return Invoker.Call<bool>(0x5527B8246FEF9B11, ped);
        }

        public static bool IS_PED_JUMPING_OUT_OF_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x433DDFFE2044B636, ped);
        }

        public static bool _0x26AF0E8E30BD2A2C(int ped)
        {
            return Invoker.Call<bool>(0x26AF0E8E30BD2A2C, ped);
        }

        public static int GET_PED_PARACHUTE_STATE(int ped)
        {
            return Invoker.Call<int>(0x79CFD9827CC979B6, ped);
        }

        public static int GET_PED_PARACHUTE_LANDING_TYPE(int ped)
        {
            return Invoker.Call<int>(0x8B9F1FC6AE8166C0, ped);
        }

        public static void SET_PED_PARACHUTE_TINT_INDEX(int ped, int tintIndex)
        {
            Invoker.Call<Void>(0x333FC8DB079B7186, ped, tintIndex);
        }

        public static void GET_PED_PARACHUTE_TINT_INDEX(int ped, ulong _outTintIndex_ptr)
        {
            Invoker.Call<Void>(0xEAF5F7E5AE7C6C9D, ped, _outTintIndex_ptr);
        }

        public static void SET_PED_RESERVE_PARACHUTE_TINT_INDEX(int ped, int p1)
        {
            Invoker.Call<Void>(0xE88DA0751C22A2AD, ped, p1);
        }

        public static int _0x8C4F3BF23B6237DB(int ped, bool p1, bool p2)
        {
            return Invoker.Call<int>(0x8C4F3BF23B6237DB, ped, p1, p2);
        }

        public static void SET_PED_DUCKING(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x030983CA930B692D, ped, toggle);
        }

        public static bool IS_PED_DUCKING(int ped)
        {
            return Invoker.Call<bool>(0xD125AE748725C6BC, ped);
        }

        public static bool IS_PED_IN_ANY_TAXI(int ped)
        {
            return Invoker.Call<bool>(0x6E575D6A898AB852, ped);
        }

        public static void SET_PED_ID_RANGE(int ped, float value)
        {
            Invoker.Call<Void>(0xF107E836A70DCE05, ped, value);
        }

        public static void _0x52D59AB61DDC05DD(int ped, bool p1)
        {
            Invoker.Call<Void>(0x52D59AB61DDC05DD, ped, p1);
        }

        public static void _0xEC4B4B3B9908052A(int ped, float unk)
        {
            Invoker.Call<Void>(0xEC4B4B3B9908052A, ped, unk);
        }

        public static void _0x733C87D4CE22BEA2(int p0)
        {
            Invoker.Call<Void>(0x733C87D4CE22BEA2, p0);
        }

        public static void SET_PED_SEEING_RANGE(int ped, float value)
        {
            Invoker.Call<Void>(0xF29CF591C4BF6CEE, ped, value);
        }

        public static void SET_PED_HEARING_RANGE(int ped, float value)
        {
            Invoker.Call<Void>(0x33A8F7F7D5F7F33C, ped, value);
        }

        public static void SET_PED_VISUAL_FIELD_MIN_ANGLE(int ped, float value)
        {
            Invoker.Call<Void>(0x2DB492222FB21E26, ped, value);
        }

        public static void SET_PED_VISUAL_FIELD_MAX_ANGLE(int ped, float value)
        {
            Invoker.Call<Void>(0x70793BDCA1E854D4, ped, value);
        }

        public static void SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE(int ped, float angle)
        {
            Invoker.Call<Void>(0x7A276EB2C224D70F, ped, angle);
        }

        public static void SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE(int ped, float angle)
        {
            Invoker.Call<Void>(0x78D0B67629D75856, ped, angle);
        }

        public static void SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE(int ped, float range)
        {
            Invoker.Call<Void>(0x9C74B0BC831B753A, ped, range);
        }

        public static void SET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped, float angle)
        {
            Invoker.Call<Void>(0x3B6405E8AB34A907, ped, angle);
        }

        public static void SET_PED_STEALTH_MOVEMENT(int ped, bool p1, string action)
        {
            Invoker.Call<Void>(0x88CBB5CEB96B7BD2, ped, p1, action);
        }

        public static bool GET_PED_STEALTH_MOVEMENT(int ped)
        {
            return Invoker.Call<bool>(0x7C2AC9CA66575FBF, ped);
        }

        public static int CREATE_GROUP(int unused)
        {
            return Invoker.Call<int>(0x90370EBE0FEE1A3D, unused);
        }

        public static void SET_PED_AS_GROUP_LEADER(int ped, int groupId)
        {
            Invoker.Call<Void>(0x2A7819605465FBCE, ped, groupId);
        }

        public static void SET_PED_AS_GROUP_MEMBER(int ped, int groupId)
        {
            Invoker.Call<Void>(0x9F3480FE65DB31B5, ped, groupId);
        }

        public static void SET_PED_CAN_TELEPORT_TO_GROUP_LEADER(int pedHandle, int groupHandle, bool toggle)
        {
            Invoker.Call<Void>(0x2E2F4240B3F24647, pedHandle, groupHandle, toggle);
        }

        public static void REMOVE_GROUP(int groupId)
        {
            Invoker.Call<Void>(0x8EB2F69076AF7053, groupId);
        }

        public static void REMOVE_PED_FROM_GROUP(int ped)
        {
            Invoker.Call<Void>(0xED74007FFB146BC2, ped);
        }

        public static bool IS_PED_GROUP_MEMBER(int ped, int groupId)
        {
            return Invoker.Call<bool>(0x9BB01E3834671191, ped, groupId);
        }

        public static bool IS_PED_HANGING_ON_TO_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x1C86D8AEF8254B78, ped);
        }

        public static void SET_GROUP_SEPARATION_RANGE(int groupHandle, float separationRange)
        {
            Invoker.Call<Void>(0x4102C7858CFEE4E4, groupHandle, separationRange);
        }

        public static void SET_PED_MIN_GROUND_TIME_FOR_STUNGUN(int ped, int ms)
        {
            Invoker.Call<Void>(0xFA0675AB151073FA, ped, ms);
        }

        public static bool IS_PED_PRONE(int ped)
        {
            return Invoker.Call<bool>(0xD6A86331A537A7B9, ped);
        }

        public static bool IS_PED_IN_COMBAT(int ped, int target)
        {
            return Invoker.Call<bool>(0x4859F1FC66A6278E, ped, target);
        }

        public static bool CAN_PED_IN_COMBAT_SEE_TARGET(int ped, int target)
        {
            return Invoker.Call<bool>(0xEAD42DE3610D0721, ped, target);
        }

        public static bool IS_PED_DOING_DRIVEBY(int ped)
        {
            return Invoker.Call<bool>(0xB2C086CC1BF8F2BF, ped);
        }

        public static bool IS_PED_JACKING(int ped)
        {
            return Invoker.Call<bool>(0x4AE4FF911DFB61DA, ped);
        }

        public static bool IS_PED_BEING_JACKED(int ped)
        {
            return Invoker.Call<bool>(0x9A497FE2DF198913, ped);
        }

        public static bool IS_PED_BEING_STUNNED(int ped, int p1)
        {
            return Invoker.Call<bool>(0x4FBACCE3B4138EE8, ped, p1);
        }

        public static int GET_PEDS_JACKER(int ped)
        {
            return Invoker.Call<int>(0x9B128DC36C1E04CF, ped);
        }

        public static int GET_JACK_TARGET(int ped)
        {
            return Invoker.Call<int>(0x5486A79D9FBD342D, ped);
        }

        public static bool IS_PED_FLEEING(int ped)
        {
            return Invoker.Call<bool>(0xBBCCE00B381F8482, ped);
        }

        public static bool IS_PED_IN_COVER(int ped, bool exceptUseWeapon)
        {
            return Invoker.Call<bool>(0x60DFD0691A170B88, ped, exceptUseWeapon);
        }

        public static bool IS_PED_IN_COVER_FACING_LEFT(int ped)
        {
            return Invoker.Call<bool>(0x845333B3150583AB, ped);
        }

        public static bool _IS_PED_STANDING_IN_COVER(int ped)
        {
            return Invoker.Call<bool>(0x6A03BF943D767C93, ped);
        }

        public static bool IS_PED_GOING_INTO_COVER(int ped)
        {
            return Invoker.Call<bool>(0x9F65DBC537E59AD5, ped);
        }

        public static int SET_PED_PINNED_DOWN(int ped, bool pinned, int p2)
        {
            return Invoker.Call<int>(0xAAD6D1ACF08F4612, ped, pinned, p2);
        }

        public static int GET_SEAT_PED_IS_TRYING_TO_ENTER(int ped)
        {
            return Invoker.Call<int>(0x6F4C85ACD641BCD2, ped);
        }

        public static int GET_VEHICLE_PED_IS_TRYING_TO_ENTER(int ped)
        {
            return Invoker.Call<int>(0x814FA8BE5449445D, ped);
        }

        public static int GET_PED_SOURCE_OF_DEATH(int ped)
        {
            return Invoker.Call<int>(0x93C8B64DEB84728C, ped);
        }

        public static int GET_PED_CAUSE_OF_DEATH(int ped)
        {
            return Invoker.Call<int>(0x16FFE42AB2D2DC59, ped);
        }

        public static int _0x1E98817B311AE98A(int ped)
        {
            return Invoker.Call<int>(0x1E98817B311AE98A, ped);
        }

        public static int _0x5407B7288D0478B7(int p0)
        {
            return Invoker.Call<int>(0x5407B7288D0478B7, p0);
        }

        public static int _0x336B3D200AB007CB(int p0, float p1, float p2, float p3, float p4)
        {
            return Invoker.Call<int>(0x336B3D200AB007CB, p0, p1, p2, p3, p4);
        }

        public static void SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped, int hash)
        {
            Invoker.Call<Void>(0xADB3F206518799E8, ped, hash);
        }

        public static void SET_PED_RELATIONSHIP_GROUP_HASH(int ped, int hash)
        {
            Invoker.Call<Void>(0xC80A74AC829DDD92, ped, hash);
        }

        public static void SET_RELATIONSHIP_BETWEEN_GROUPS(int relationship, int group1, int group2)
        {
            Invoker.Call<Void>(0xBF25EB89375A37AD, relationship, group1, group2);
        }

        public static void CLEAR_RELATIONSHIP_BETWEEN_GROUPS(int relationship, int group1, int group2)
        {
            Invoker.Call<Void>(0x5E29243FB56FC6D4, relationship, group1, group2);
        }

        public static int ADD_RELATIONSHIP_GROUP(string name, ulong groupHash_ptr)
        {
            return Invoker.Call<int>(0xF372BC22FCB88606, name, groupHash_ptr);
        }

        public static void REMOVE_RELATIONSHIP_GROUP(int groupHash)
        {
            Invoker.Call<Void>(0xB6BA2444AB393DA2, groupHash);
        }

        public static int GET_RELATIONSHIP_BETWEEN_PEDS(int ped1, int ped2)
        {
            return Invoker.Call<int>(0xEBA5AD3A0EAF7121, ped1, ped2);
        }

        public static int GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped)
        {
            return Invoker.Call<int>(0x42FDD0F017B1E38E, ped);
        }

        public static int GET_PED_RELATIONSHIP_GROUP_HASH(int ped)
        {
            return Invoker.Call<int>(0x7DBDD04862D95F04, ped);
        }

        public static int GET_RELATIONSHIP_BETWEEN_GROUPS(int group1, int group2)
        {
            return Invoker.Call<int>(0x9E6B70061662AE5C, group1, group2);
        }

        public static void SET_PED_CAN_BE_TARGETED_WITHOUT_LOS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x4328652AE5769C71, ped, toggle);
        }

        public static void SET_PED_TO_INFORM_RESPECTED_FRIENDS(int ped, float radius, int maxFriends)
        {
            Invoker.Call<Void>(0x112942C6E708F70B, ped, radius, maxFriends);
        }

        public static bool IS_PED_RESPONDING_TO_EVENT(int ped, int _event)
        {
            return Invoker.Call<bool>(0x625B774D75C87068, ped, _event);
        }

        public static void SET_PED_FIRING_PATTERN(int ped, int patternHash)
        {
            Invoker.Call<Void>(0x9AC577F5A12AD8A9, ped, patternHash);
        }

        public static void SET_PED_SHOOT_RATE(int ped, int shootRate)
        {
            Invoker.Call<Void>(0x614DA022990752DC, ped, shootRate);
        }

        public static void SET_COMBAT_FLOAT(int ped, int combatType, float p2)
        {
            Invoker.Call<Void>(0xFF41B4B141ED981C, ped, combatType, p2);
        }

        public static float GET_COMBAT_FLOAT(int ped, int p1)
        {
            return Invoker.Call<float>(0x52DFF8A10508090A, ped, p1);
        }

        public static void GET_GROUP_SIZE(int groupID, ulong unknown_ptr, ulong sizeInMembers_ptr)
        {
            Invoker.Call<Void>(0x8DE69FE35CA09A45, groupID, unknown_ptr, sizeInMembers_ptr);
        }

        public static bool DOES_GROUP_EXIST(int groupId)
        {
            return Invoker.Call<bool>(0x7C6B0C22F9F40BBE, groupId);
        }

        public static int GET_PED_GROUP_INDEX(int ped)
        {
            return Invoker.Call<int>(0xF162E133B4E7A675, ped);
        }

        public static bool IS_PED_IN_GROUP(int ped)
        {
            return Invoker.Call<bool>(0x5891CAC5D4ACFF74, ped);
        }

        public static int GET_PLAYER_PED_IS_FOLLOWING(int ped)
        {
            return Invoker.Call<int>(0x6A3975DEA89F9A17, ped);
        }

        public static void SET_GROUP_FORMATION(int groupId, int formationType)
        {
            Invoker.Call<Void>(0xCE2F5FC3AF7E8C1E, groupId, formationType);
        }

        public static void SET_GROUP_FORMATION_SPACING(int groupId, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x1D9D45004C28C916, groupId, p1, p2, p3);
        }

        public static void RESET_GROUP_FORMATION_DEFAULT_SPACING(int groupHandle)
        {
            Invoker.Call<Void>(0x63DAB4CCB3273205, groupHandle);
        }

        public static int GET_VEHICLE_PED_IS_USING(int ped)
        {
            return Invoker.Call<int>(0x6094AD011A2EA87D, ped);
        }

        public static int SET_EXCLUSIVE_PHONE_RELATIONSHIPS(int ped)
        {
            return Invoker.Call<int>(0xF92691AED837A5FC, ped);
        }

        public static void SET_PED_GRAVITY(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x9FF447B6B6AD960A, ped, toggle);
        }

        public static void APPLY_DAMAGE_TO_PED(int ped, int damageAmount, bool armorFirst)
        {
            Invoker.Call<Void>(0x697157CED63F18D4, ped, damageAmount, armorFirst);
        }

        public static int _0x36B77BB84687C318(int ped, int p1)
        {
            return Invoker.Call<int>(0x36B77BB84687C318, ped, p1);
        }

        public static void SET_PED_ALLOWED_TO_DUCK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xDA1F1B7BE1A8766F, ped, toggle);
        }

        public static void SET_PED_NEVER_LEAVES_GROUP(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x3DBFC55D5C9BB447, ped, toggle);
        }

        public static int GET_PED_TYPE(int ped)
        {
            return Invoker.Call<int>(0xFF059E1E4C01E63C, ped);
        }

        public static void SET_PED_AS_COP(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xBB03C38DD3FB7FFD, ped, toggle);
        }

        public static void SET_PED_MAX_HEALTH(int ped, int value)
        {
            Invoker.Call<Void>(0xF5F6378C4F3419D3, ped, value);
        }

        public static int GET_PED_MAX_HEALTH(int ped)
        {
            return Invoker.Call<int>(0x4700A416E8324EF3, ped);
        }

        public static void SET_PED_MAX_TIME_IN_WATER(int ped, float value)
        {
            Invoker.Call<Void>(0x43C851690662113D, ped, value);
        }

        public static void SET_PED_MAX_TIME_UNDERWATER(int ped, float value)
        {
            Invoker.Call<Void>(0x6BA428C528D9E522, ped, value);
        }

        public static void _0x2735233A786B1BEF(int ped, float p1)
        {
            Invoker.Call<Void>(0x2735233A786B1BEF, ped, p1);
        }

        public static void _0x952F06BEECD775CC(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x952F06BEECD775CC, p0, p1, p2, p3);
        }

        public static void _0xE6CA85E7259CE16B(int p0)
        {
            Invoker.Call<Void>(0xE6CA85E7259CE16B, p0);
        }

        public static void SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(int ped, int state)
        {
            Invoker.Call<Void>(0x7A6535691B477C48, ped, state);
        }

        public static bool CAN_KNOCK_PED_OFF_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x51AC07A44D4F5B8A, ped);
        }

        public static void KNOCK_PED_OFF_VEHICLE(int ped)
        {
            Invoker.Call<Void>(0x45BBCBA77C29A841, ped);
        }

        public static void SET_PED_COORDS_NO_GANG(int ped, float posX, float posY, float posZ)
        {
            Invoker.Call<Void>(0x87052FE446E07247, ped, posX, posY, posZ);
        }

        public static int GET_PED_AS_GROUP_MEMBER(int groupID, int memberNumber)
        {
            return Invoker.Call<int>(0x51455483CF23ED97, groupID, memberNumber);
        }

        public static int _GET_PED_AS_GROUP_LEADER(int groupID)
        {
            return Invoker.Call<int>(0x5CCE68DBD5FE93EC, groupID);
        }

        public static void SET_PED_KEEP_TASK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x971D38760FBC02EF, ped, toggle);
        }

        public static void _0x49E50BDB8BA4DAB2(int ped, bool p1)
        {
            Invoker.Call<Void>(0x49E50BDB8BA4DAB2, ped, p1);
        }

        public static bool IS_PED_SWIMMING(int ped)
        {
            return Invoker.Call<bool>(0x9DE327631295B4C2, ped);
        }

        public static bool IS_PED_SWIMMING_UNDER_WATER(int ped)
        {
            return Invoker.Call<bool>(0xC024869A53992F34, ped);
        }

        public static void SET_PED_COORDS_KEEP_VEHICLE(int ped, float posX, float posY, float posZ)
        {
            Invoker.Call<Void>(0x9AFEFF481A85AB2E, ped, posX, posY, posZ);
        }

        public static void SET_PED_DIES_IN_VEHICLE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x2A30922C90C9B42C, ped, toggle);
        }

        public static void SET_CREATE_RANDOM_COPS(bool toggle)
        {
            Invoker.Call<Void>(0x102E68B2024D536D, toggle);
        }

        public static void SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS(bool toggle)
        {
            Invoker.Call<Void>(0x8A4986851C4EF6E7, toggle);
        }

        public static void SET_CREATE_RANDOM_COPS_ON_SCENARIOS(bool toggle)
        {
            Invoker.Call<Void>(0x444CB7D7DBE6973D, toggle);
        }

        public static bool CAN_CREATE_RANDOM_COPS()
        {
            return Invoker.Call<bool>(0x5EE2CAFF7F17770D);
        }

        public static void SET_PED_AS_ENEMY(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x02A0C9720B854BFA, ped, toggle);
        }

        public static void SET_PED_CAN_SMASH_GLASS(int ped, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x1CCE141467FF42A2, ped, p1, p2);
        }

        public static bool IS_PED_IN_ANY_TRAIN(int ped)
        {
            return Invoker.Call<bool>(0x6F972C1AB75A1ED0, ped);
        }

        public static bool IS_PED_GETTING_INTO_A_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0xBB062B2B5722478E, ped);
        }

        public static bool IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE(int ped)
        {
            return Invoker.Call<bool>(0x44D28D5DDFE5F68C, ped);
        }

        public static void SET_ENABLE_HANDCUFFS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xDF1AF8B5D56542FA, ped, toggle);
        }

        public static void SET_ENABLE_BOUND_ANKLES(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xC52E0F855C58FC2E, ped, toggle);
        }

        public static void SET_ENABLE_SCUBA(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xF99F62004024D506, ped, toggle);
        }

        public static void SET_CAN_ATTACK_FRIENDLY(int ped, bool toggle, bool p2)
        {
            Invoker.Call<Void>(0xB3B1CB349FF9C75D, ped, toggle, p2);
        }

        public static int GET_PED_ALERTNESS(int ped)
        {
            return Invoker.Call<int>(0xF6AA118530443FD2, ped);
        }

        public static void SET_PED_ALERTNESS(int ped, int value)
        {
            Invoker.Call<Void>(0xDBA71115ED9941A6, ped, value);
        }

        public static void SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xBC0ED94165A48BC2, ped, toggle);
        }

        public static void SET_PED_MOVEMENT_CLIPSET(int ped, string clipSet, float p2)
        {
            Invoker.Call<Void>(0xAF8A94EDE7712BEF, ped, clipSet, p2);
        }

        public static void RESET_PED_MOVEMENT_CLIPSET(int ped, float p1)
        {
            Invoker.Call<Void>(0xAA74EC0CB0AAEA2C, ped, p1);
        }

        public static void SET_PED_STRAFE_CLIPSET(int ped, string clipSet)
        {
            Invoker.Call<Void>(0x29A28F3F8CF6D854, ped, clipSet);
        }

        public static void RESET_PED_STRAFE_CLIPSET(int ped)
        {
            Invoker.Call<Void>(0x20510814175EA477, ped);
        }

        public static void SET_PED_WEAPON_MOVEMENT_CLIPSET(int ped, string clipSet)
        {
            Invoker.Call<Void>(0x2622E35B77D3ACA2, ped, clipSet);
        }

        public static void RESET_PED_WEAPON_MOVEMENT_CLIPSET(int ped)
        {
            Invoker.Call<Void>(0x97B0DB5B4AA74E77, ped);
        }

        public static void SET_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped, string clipset)
        {
            Invoker.Call<Void>(0xED34AB6C5CB36520, ped, clipset);
        }

        public static void CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE(int ped)
        {
            Invoker.Call<Void>(0x4AFE3690D7E0B5AC, ped);
        }

        public static void _0x9DBA107B4937F809(int p0, string p1)
        {
            Invoker.Call<Void>(0x9DBA107B4937F809, p0, p1);
        }

        public static void _0xC79196DCB36F6121(int p0)
        {
            Invoker.Call<Void>(0xC79196DCB36F6121, p0);
        }

        public static void _0x80054D7FCC70EEC6(int p0)
        {
            Invoker.Call<Void>(0x80054D7FCC70EEC6, p0);
        }

        public static void SET_PED_IN_VEHICLE_CONTEXT(int ped, int context)
        {
            Invoker.Call<Void>(0x530071295899A8C6, ped, context);
        }

        public static void RESET_PED_IN_VEHICLE_CONTEXT(int ped)
        {
            Invoker.Call<Void>(0x22EF8FF8778030EB, ped);
        }

        public static bool IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM(int ped, string animDict, string anim)
        {
            return Invoker.Call<bool>(0x6EC47A344923E1ED, ped, animDict, anim);
        }

        public static void SET_PED_ALTERNATE_WALK_ANIM(int ped, string animDict, string animName, float p3, bool p4)
        {
            Invoker.Call<Void>(0x6C60394CB4F75E9A, ped, animDict, animName, p3, p4);
        }

        public static void CLEAR_PED_ALTERNATE_WALK_ANIM(int ped, float p1)
        {
            Invoker.Call<Void>(0x8844BBFCE30AA9E9, ped, p1);
        }

        public static void SET_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, string animDictionary, string animationName, float p4, bool p5)
        {
            Invoker.Call<Void>(0x90A43CC281FFAB46, ped, stance, animDictionary, animationName, p4, p5);
        }

        public static void CLEAR_PED_ALTERNATE_MOVEMENT_ANIM(int ped, int stance, float p2)
        {
            Invoker.Call<Void>(0xD8D19675ED5FBDCE, ped, stance, p2);
        }

        public static void SET_PED_GESTURE_GROUP(int ped, string animGroupGesture)
        {
            Invoker.Call<Void>(0xDDF803377F94AAA8, ped, animGroupGesture);
        }

        public static Vector3 GET_ANIM_INITIAL_OFFSET_POSITION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)
        {
            return Invoker.Call<Vector3>(0xBE22B26DD764C040, animDict, animName, x, y, z, xRot, yRot, zRot, p8, p9);
        }

        public static Vector3 GET_ANIM_INITIAL_OFFSET_ROTATION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9)
        {
            return Invoker.Call<Vector3>(0x4B805E6046EE9E47, animDict, animName, x, y, z, xRot, yRot, zRot, p8, p9);
        }

        public static int GET_PED_DRAWABLE_VARIATION(int ped, int componentId)
        {
            return Invoker.Call<int>(0x67F3780DD425D4FC, ped, componentId);
        }

        public static int GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS(int ped, int componentId)
        {
            return Invoker.Call<int>(0x27561561732A7842, ped, componentId);
        }

        public static int GET_PED_TEXTURE_VARIATION(int ped, int componentId)
        {
            return Invoker.Call<int>(0x04A355E041E004E6, ped, componentId);
        }

        public static int GET_NUMBER_OF_PED_TEXTURE_VARIATIONS(int ped, int componentId, int drawableId)
        {
            return Invoker.Call<int>(0x8F7156A3142A6BAD, ped, componentId, drawableId);
        }

        public static int GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(int ped, int propId)
        {
            return Invoker.Call<int>(0x5FAF9754E789FB47, ped, propId);
        }

        public static int GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(int ped, int propId, int drawableId)
        {
            return Invoker.Call<int>(0xA6E7F1CEB523E171, ped, propId, drawableId);
        }

        public static int GET_PED_PALETTE_VARIATION(int ped, int componentId)
        {
            return Invoker.Call<int>(0xE3DD5F2A84B42281, ped, componentId);
        }

        public static bool _0x9E30E91FB03A2CAF(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x9E30E91FB03A2CAF, p0_ptr, p1_ptr);
        }

        public static int _0x1E77FA7A62EE6C4C(int p0)
        {
            return Invoker.Call<int>(0x1E77FA7A62EE6C4C, p0);
        }

        public static int _0xF033419D1B81FAE8(int p0)
        {
            return Invoker.Call<int>(0xF033419D1B81FAE8, p0);
        }

        public static bool IS_PED_COMPONENT_VARIATION_VALID(int ped, int componentId, int drawableId, int textureId)
        {
            return Invoker.Call<bool>(0xE825F6B6CEA7671D, ped, componentId, drawableId, textureId);
        }

        public static void SET_PED_COMPONENT_VARIATION(int ped, int componentId, int drawableId, int textureId, int paletteId)
        {
            Invoker.Call<Void>(0x262B14F48D29DE80, ped, componentId, drawableId, textureId, paletteId);
        }

        public static void SET_PED_RANDOM_COMPONENT_VARIATION(int ped, bool p1)
        {
            Invoker.Call<Void>(0xC8A9481A01E63C28, ped, p1);
        }

        public static void SET_PED_RANDOM_PROPS(int ped)
        {
            Invoker.Call<Void>(0xC44AA05345C992C6, ped);
        }

        public static void SET_PED_DEFAULT_COMPONENT_VARIATION(int ped)
        {
            Invoker.Call<Void>(0x45EEE61580806D63, ped);
        }

        public static void SET_PED_BLEND_FROM_PARENTS(int ped, int father, int mother, float fathersSide, float mothersSide)
        {
            Invoker.Call<Void>(0x137BBD05230DB22D, ped, father, mother, fathersSide, mothersSide);
        }

        public static void SET_PED_HEAD_BLEND_DATA(int ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)
        {
            Invoker.Call<Void>(0x9414E18B9434C2FE, ped, shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix, isParent);
        }

        public static bool _GET_PED_HEAD_BLEND_DATA(int ped, ulong headBlendData_ptr)
        {
            return Invoker.Call<bool>(0x2746BD9D88C5C5D0, ped, headBlendData_ptr);
        }

        public static void UPDATE_PED_HEAD_BLEND_DATA(int ped, float shapeMix, float skinMix, float thirdMix)
        {
            Invoker.Call<Void>(0x723538F61C647C5A, ped, shapeMix, skinMix, thirdMix);
        }

        public static void _SET_PED_EYE_COLOR(int ped, int index)
        {
            Invoker.Call<Void>(0x50B56988B170AFDF, ped, index);
        }

        public static void SET_PED_HEAD_OVERLAY(int ped, int overlayID, int index, float opacity)
        {
            Invoker.Call<Void>(0x48F44967FA05CC1E, ped, overlayID, index, opacity);
        }

        public static int _GET_PED_HEAD_OVERLAY_VALUE(int ped, int overlayID)
        {
            return Invoker.Call<int>(0xA60EF3B6461A4D43, ped, overlayID);
        }

        public static int _GET_NUM_HEAD_OVERLAY_VALUES(int overlayID)
        {
            return Invoker.Call<int>(0xCF1CE768BB43480E, overlayID);
        }

        public static void _SET_PED_HEAD_OVERLAY_COLOR(int ped, int overlayID, int colorType, int colorID, int secondColorID)
        {
            Invoker.Call<Void>(0x497BF74A7B9CB952, ped, overlayID, colorType, colorID, secondColorID);
        }

        public static void _SET_PED_HAIR_COLOR(int ped, int colorID, int highlightColorID)
        {
            Invoker.Call<Void>(0x4CFFC65454C93A49, ped, colorID, highlightColorID);
        }

        public static int _GET_NUM_HAIR_COLORS()
        {
            return Invoker.Call<int>(0xE5C0CF872C2AD150);
        }

        public static int _GET_NUM_MAKEUP_COLORS()
        {
            return Invoker.Call<int>(0xD1F7CA1535D22818);
        }

        public static void _GET_HAIR_COLOR(int colorID, ulong R_ptr, ulong G_ptr, ulong B_ptr)
        {
            Invoker.Call<Void>(0x4852FC386E2E1BB5, colorID, R_ptr, G_ptr, B_ptr);
        }

        public static void _GET_LIPSTICK_COLOR(int colorID, ulong R_ptr, ulong G_ptr, ulong B_ptr)
        {
            Invoker.Call<Void>(0x013E5CFC38CD5387, colorID, R_ptr, G_ptr, B_ptr);
        }

        public static bool _0xED6D8E27A43B8CDE(int ColorID)
        {
            return Invoker.Call<bool>(0xED6D8E27A43B8CDE, ColorID);
        }

        public static int _0xEA9960D07DADCF10(int p0)
        {
            return Invoker.Call<int>(0xEA9960D07DADCF10, p0);
        }

        public static bool _0x3E802F11FBE27674(int p0)
        {
            return Invoker.Call<bool>(0x3E802F11FBE27674, p0);
        }

        public static bool _0xF41B5D290C99A3D6(int p0)
        {
            return Invoker.Call<bool>(0xF41B5D290C99A3D6, p0);
        }

        public static bool _IS_PED_HAIR_COLOR_VALID(int colorID)
        {
            return Invoker.Call<bool>(0xE0D36E5D9E99CC21, colorID);
        }

        public static int _0xAAA6A3698A69E048(int p0)
        {
            return Invoker.Call<int>(0xAAA6A3698A69E048, p0);
        }

        public static bool _IS_PED_LIPSTICK_COLOR_VALID(int colorID)
        {
            return Invoker.Call<bool>(0x0525A2C2562F3CD4, colorID);
        }

        public static bool _IS_PED_BLUSH_COLOR_VALID(int colorID)
        {
            return Invoker.Call<bool>(0x604E810189EE3A59, colorID);
        }

        public static int _0xC56FBF2F228E1DAC(int modelHash, int p1, int p2)
        {
            return Invoker.Call<int>(0xC56FBF2F228E1DAC, modelHash, p1, p2);
        }

        public static void _SET_PED_FACE_FEATURE(int ped, int index, float scale)
        {
            Invoker.Call<Void>(0x71A5C1DBA060049E, ped, index, scale);
        }

        public static bool HAS_PED_HEAD_BLEND_FINISHED(int ped)
        {
            return Invoker.Call<bool>(0x654CD0A825161131, ped);
        }

        public static void _0x4668D80430D6C299(int ped)
        {
            Invoker.Call<Void>(0x4668D80430D6C299, ped);
        }

        public static void _0xCC9682B8951C5229(int ped, int r, int g, int b, int p4)
        {
            Invoker.Call<Void>(0xCC9682B8951C5229, ped, r, g, b, p4);
        }

        public static void _0xA21C118553BBDF02(int ped)
        {
            Invoker.Call<Void>(0xA21C118553BBDF02, ped);
        }

        public static int _GET_FIRST_PARENT_ID_FOR_PED_TYPE(int type)
        {
            return Invoker.Call<int>(0x68D353AB88B97E0C, type);
        }

        public static int _GET_NUM_PARENT_PEDS_OF_TYPE(int type)
        {
            return Invoker.Call<int>(0x5EF37013A6539C9D, type);
        }

        public static int _0x39D55A620FCB6A3A(int ped, int slot, int drawableId, int textureId)
        {
            return Invoker.Call<int>(0x39D55A620FCB6A3A, ped, slot, drawableId, textureId);
        }

        public static bool _0x66680A92700F43DF(int p0)
        {
            return Invoker.Call<bool>(0x66680A92700F43DF, p0);
        }

        public static void _0x5AAB586FFEC0FD96(int p0)
        {
            Invoker.Call<Void>(0x5AAB586FFEC0FD96, p0);
        }

        public static bool _IS_PED_PROP_VALID(int ped, int componentId, int drawableId, int TextureId)
        {
            return Invoker.Call<bool>(0x2B16A3BFF1FBCE49, ped, componentId, drawableId, TextureId);
        }

        public static bool _0x784002A632822099(int ped)
        {
            return Invoker.Call<bool>(0x784002A632822099, ped);
        }

        public static void _0xF79F9DEF0AADE61A(int ped)
        {
            Invoker.Call<Void>(0xF79F9DEF0AADE61A, ped);
        }

        public static int GET_PED_PROP_INDEX(int ped, int componentId)
        {
            return Invoker.Call<int>(0x898CC20EA75BACD8, ped, componentId);
        }

        public static void SET_PED_PROP_INDEX(int ped, int componentId, int drawableId, int TextureId, bool attach)
        {
            Invoker.Call<Void>(0x93376B65A266EB5F, ped, componentId, drawableId, TextureId, attach);
        }

        public static void KNOCK_OFF_PED_PROP(int ped, bool p1, bool p2, bool p3, bool p4)
        {
            Invoker.Call<Void>(0x6FD7816A36615F48, ped, p1, p2, p3, p4);
        }

        public static void CLEAR_PED_PROP(int ped, int propId)
        {
            Invoker.Call<Void>(0x0943E5B8E078E76E, ped, propId);
        }

        public static void CLEAR_ALL_PED_PROPS(int ped)
        {
            Invoker.Call<Void>(0xCD8A7537A9B52F06, ped);
        }

        public static void _0xAFF4710E2A0A6C12(int ped)
        {
            Invoker.Call<Void>(0xAFF4710E2A0A6C12, ped);
        }

        public static int GET_PED_PROP_TEXTURE_INDEX(int ped, int componentId)
        {
            return Invoker.Call<int>(0xE131A28626F81AB2, ped, componentId);
        }

        public static void _0x1280804F7CFD2D6C(int p0)
        {
            Invoker.Call<Void>(0x1280804F7CFD2D6C, p0);
        }

        public static void _0x36C6984C3ED0C911(int p0)
        {
            Invoker.Call<Void>(0x36C6984C3ED0C911, p0);
        }

        public static void _0xB50EB4CCB29704AC(int p0)
        {
            Invoker.Call<Void>(0xB50EB4CCB29704AC, p0);
        }

        public static bool _0xFEC9A3B1820F3331(int p0)
        {
            return Invoker.Call<bool>(0xFEC9A3B1820F3331, p0);
        }

        public static void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x9F8AA94D6D97DBF4, ped, toggle);
        }

        public static void SET_PED_BOUNDS_ORIENTATION(int ped, float p1, float p2, float p3, float p4, float p5)
        {
            Invoker.Call<Void>(0x4F5F651ACCC9C4CF, ped, p1, p2, p3, p4, p5);
        }

        public static void REGISTER_TARGET(int ped, int target)
        {
            Invoker.Call<Void>(0x2F25D9AEFA34FBA2, ped, target);
        }

        public static void REGISTER_HATED_TARGETS_AROUND_PED(int ped, float radius)
        {
            Invoker.Call<Void>(0x9222F300BF8354FE, ped, radius);
        }

        public static int GET_RANDOM_PED_AT_COORD(float x, float y, float z, float xRadius, float yRadius, float zRadius, int pedType)
        {
            return Invoker.Call<int>(0x876046A8E3A4B71C, x, y, z, xRadius, yRadius, zRadius, pedType);
        }

        public static bool GET_CLOSEST_PED(float x, float y, float z, float radius, bool p4, bool p5, ulong _outPed_ptr, bool p7, bool p8, int pedType)
        {
            return Invoker.Call<bool>(0xC33AB876A77F8164, x, y, z, radius, p4, p5, _outPed_ptr, p7, p8, pedType);
        }

        public static void SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND(bool value)
        {
            Invoker.Call<Void>(0x14F19A8782C8071E, value);
        }

        public static bool _0x03EA03AF85A85CB7(int ped, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7, int p8)
        {
            return Invoker.Call<bool>(0x03EA03AF85A85CB7, ped, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void _0xDED5AF5A0EA4B297(int driver, float p1)
        {
            Invoker.Call<Void>(0xDED5AF5A0EA4B297, driver, p1);
        }

        public static void SET_DRIVER_ABILITY(int driver, float ability)
        {
            Invoker.Call<Void>(0xB195FFA8042FC5C3, driver, ability);
        }

        public static void SET_DRIVER_AGGRESSIVENESS(int driver, float aggressiveness)
        {
            Invoker.Call<Void>(0xA731F608CA104E3C, driver, aggressiveness);
        }

        public static bool CAN_PED_RAGDOLL(int ped)
        {
            return Invoker.Call<bool>(0x128F79EDCECE4FD5, ped);
        }

        public static bool SET_PED_TO_RAGDOLL(int ped, int time1, int time2, int ragdollType, bool p4, bool p5, bool p6)
        {
            return Invoker.Call<bool>(0xAE99FB955581844A, ped, time1, time2, ragdollType, p4, p5, p6);
        }

        public static bool SET_PED_TO_RAGDOLL_WITH_FALL(int ped, int time, int p2, int ragdollType, float x, float y, float z, float p7, float p8, float p9, float p10, float p11, float p12, float p13)
        {
            return Invoker.Call<bool>(0xD76632D99E4966C8, ped, time, p2, ragdollType, x, y, z, p7, p8, p9, p10, p11, p12, p13);
        }

        public static void SET_PED_RAGDOLL_ON_COLLISION(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xF0A4F1BBF4FA7497, ped, toggle);
        }

        public static bool IS_PED_RAGDOLL(int ped)
        {
            return Invoker.Call<bool>(0x47E4E977581C5B55, ped);
        }

        public static bool IS_PED_RUNNING_RAGDOLL_TASK(int ped)
        {
            return Invoker.Call<bool>(0xE3B6097CC25AA69E, ped);
        }

        public static int SET_PED_RAGDOLL_FORCE_FALL(int ped)
        {
            return Invoker.Call<int>(0x01F6594B923B9251, ped);
        }

        public static void RESET_PED_RAGDOLL_TIMER(int ped)
        {
            Invoker.Call<Void>(0x9FA4664CF62E47E8, ped);
        }

        public static void SET_PED_CAN_RAGDOLL(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xB128377056A54E2A, ped, toggle);
        }

        public static bool _0xD1871251F3B5ACD7(int ped)
        {
            return Invoker.Call<bool>(0xD1871251F3B5ACD7, ped);
        }

        public static bool IS_PED_RUNNING_MOBILE_PHONE_TASK(int ped)
        {
            return Invoker.Call<bool>(0x2AFE52F782F25775, ped);
        }

        public static bool _0xA3F3564A5B3646C0(int ped)
        {
            return Invoker.Call<bool>(0xA3F3564A5B3646C0, ped);
        }

        public static void _SET_PED_RAGDOLL_BLOCKING_FLAGS(int ped, int flags)
        {
            Invoker.Call<Void>(0x26695EC767728D84, ped, flags);
        }

        public static void _RESET_PED_RAGDOLL_BLOCKING_FLAGS(int ped, int flags)
        {
            Invoker.Call<Void>(0xD86D101FCFD00A4B, ped, flags);
        }

        public static void SET_PED_ANGLED_DEFENSIVE_AREA(int ped, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8, bool p9)
        {
            Invoker.Call<Void>(0xC7F76DF27A5045A1, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        public static void SET_PED_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius, bool p5, bool p6)
        {
            Invoker.Call<Void>(0x9D3151A373974804, ped, x, y, z, radius, p5, p6);
        }

        public static void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED(int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6)
        {
            Invoker.Call<Void>(0xF9B8F91AAD3B953E, ped, target, xOffset, yOffset, zOffset, radius, p6);
        }

        public static void _0xE4723DB6E736CCFF(int ped, int p1, float p2, float p3, float p4, float p5, bool p6)
        {
            Invoker.Call<Void>(0xE4723DB6E736CCFF, ped, p1, p2, p3, p4, p5, p6);
        }

        public static void SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED(int ped, int attachPed, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9, bool p10)
        {
            Invoker.Call<Void>(0x4EF47FE21698A8B6, ped, attachPed, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }

        public static void SET_PED_DEFENSIVE_AREA_DIRECTION(int ped, float p1, float p2, float p3, bool p4)
        {
            Invoker.Call<Void>(0x413C6C763A4AFFAD, ped, p1, p2, p3, p4);
        }

        public static void REMOVE_PED_DEFENSIVE_AREA(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x74D4E028107450A9, ped, toggle);
        }

        public static Vector3 GET_PED_DEFENSIVE_AREA_POSITION(int ped, bool p1)
        {
            return Invoker.Call<Vector3>(0x3C06B8786DD94CD1, ped, p1);
        }

        public static bool _0xBA63D9FE45412247(int ped, bool p1)
        {
            return Invoker.Call<bool>(0xBA63D9FE45412247, ped, p1);
        }

        public static void SET_PED_PREFERRED_COVER_SET(int ped, int itemSet)
        {
            Invoker.Call<Void>(0x8421EB4DA7E391B9, ped, itemSet);
        }

        public static void REMOVE_PED_PREFERRED_COVER_SET(int ped)
        {
            Invoker.Call<Void>(0xFDDB234CF74073D9, ped);
        }

        public static void REVIVE_INJURED_PED(int ped)
        {
            Invoker.Call<Void>(0x8D8ACD8388CD99CE, ped);
        }

        public static void RESURRECT_PED(int ped)
        {
            Invoker.Call<Void>(0x71BC8E838B9C6035, ped);
        }

        public static void SET_PED_NAME_DEBUG(int ped, string name)
        {
            Invoker.Call<Void>(0x98EFA132A4117BE1, ped, name);
        }

        public static Vector3 GET_PED_EXTRACTED_DISPLACEMENT(int ped, bool worldSpace)
        {
            return Invoker.Call<Vector3>(0xE0AF41401ADF87E3, ped, worldSpace);
        }

        public static int SET_PED_DIES_WHEN_INJURED(int ped, bool toggle)
        {
            return Invoker.Call<int>(0x5BA7919BED300023, ped, toggle);
        }

        public static int SET_PED_ENABLE_WEAPON_BLOCKING(int ped, bool toggle)
        {
            return Invoker.Call<int>(0x97A790315D3831FD, ped, toggle);
        }

        public static void _0xF9ACF4A08098EA25(int ped, bool p1)
        {
            Invoker.Call<Void>(0xF9ACF4A08098EA25, ped, p1);
        }

        public static int RESET_PED_VISIBLE_DAMAGE(int ped)
        {
            return Invoker.Call<int>(0x3AC1F7B898F30C05, ped);
        }

        public static void APPLY_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1, float p2, float p3, int p4)
        {
            Invoker.Call<Void>(0x816F6981C60BF53B, ped, p1, p2, p3, p4);
        }

        public static void APPLY_PED_BLOOD(int ped, int boneIndex, float xRot, float yRot, float zRot, string woundType)
        {
            Invoker.Call<Void>(0x83F7E01C7B769A26, ped, boneIndex, xRot, yRot, zRot, woundType);
        }

        public static void APPLY_PED_BLOOD_BY_ZONE(int ped, int p1, float p2, float p3, ulong p4_ptr)
        {
            Invoker.Call<Void>(0x3311E47B91EDCBBC, ped, p1, p2, p3, p4_ptr);
        }

        public static void APPLY_PED_BLOOD_SPECIFIC(int ped, int p1, float p2, float p3, float p4, float p5, int p6, float p7, ulong p8_ptr)
        {
            Invoker.Call<Void>(0xEF0D582CBF2D9B0F, ped, p1, p2, p3, p4, p5, p6, p7, p8_ptr);
        }

        public static void APPLY_PED_DAMAGE_DECAL(int ped, int p1, float p2, float p3, float p4, float p5, float p6, int p7, bool p8, string p9)
        {
            Invoker.Call<Void>(0x397C38AA7B4A5F83, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        public static void APPLY_PED_DAMAGE_PACK(int ped, string damagePack, float damage, float mult)
        {
            Invoker.Call<Void>(0x46DF918788CB093F, ped, damagePack, damage, mult);
        }

        public static void CLEAR_PED_BLOOD_DAMAGE(int ped)
        {
            Invoker.Call<Void>(0x8FE22675A5A45817, ped);
        }

        public static void CLEAR_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1)
        {
            Invoker.Call<Void>(0x56E3B78C5408D9F4, ped, p1);
        }

        public static void HIDE_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1, bool p2)
        {
            Invoker.Call<Void>(0x62AB793144DE75DC, ped, p1, p2);
        }

        public static void CLEAR_PED_DAMAGE_DECAL_BY_ZONE(int ped, int p1, string p2)
        {
            Invoker.Call<Void>(0x523C79AEEFCC4A2A, ped, p1, p2);
        }

        public static int GET_PED_DECORATIONS_STATE(int ped)
        {
            return Invoker.Call<int>(0x71EAB450D86954A1, ped);
        }

        public static void _0x2B694AFCF64E6994(int ped, bool p1)
        {
            Invoker.Call<Void>(0x2B694AFCF64E6994, ped, p1);
        }

        public static void CLEAR_PED_WETNESS(int ped)
        {
            Invoker.Call<Void>(0x9C720776DAA43E7E, ped);
        }

        public static void SET_PED_WETNESS_HEIGHT(int ped, float height)
        {
            Invoker.Call<Void>(0x44CB6447D2571AA0, ped, height);
        }

        public static void SET_PED_WETNESS_ENABLED_THIS_FRAME(int ped)
        {
            Invoker.Call<Void>(0xB5485E4907B53019, ped);
        }

        public static int _0x6585D955A68452A5(int ped)
        {
            return Invoker.Call<int>(0x6585D955A68452A5, ped);
        }

        public static void SET_PED_SWEAT(int ped, float sweat)
        {
            Invoker.Call<Void>(0x27B0405F59637D1F, ped, sweat);
        }

        public static void _SET_PED_DECORATION(int ped, int collection, int overlay)
        {
            Invoker.Call<Void>(0x5F5D1665E352A839, ped, collection, overlay);
        }

        public static void _SET_PED_FACIAL_DECORATION(int ped, int collection, int overlay)
        {
            Invoker.Call<Void>(0x5619BFA07CFD7833, ped, collection, overlay);
        }

        public static int _GET_TATTOO_ZONE(int collection, int overlay)
        {
            return Invoker.Call<int>(0x9FD452BFBE7A7A8B, collection, overlay);
        }

        public static void CLEAR_PED_DECORATIONS(int ped)
        {
            Invoker.Call<Void>(0x0E5173C163976E38, ped);
        }

        public static void _CLEAR_PED_FACIAL_DECORATIONS(int ped)
        {
            Invoker.Call<Void>(0xE3B27E70CEAB9F0C, ped);
        }

        public static bool WAS_PED_SKELETON_UPDATED(int ped)
        {
            return Invoker.Call<bool>(0x11B499C1E0FF8559, ped);
        }

        public static Vector3 GET_PED_BONE_COORDS(int ped, int boneId, float offsetX, float offsetY, float offsetZ)
        {
            return Invoker.Call<Vector3>(0x17C07FC640E86B4E, ped, boneId, offsetX, offsetY, offsetZ);
        }

        public static void CREATE_NM_MESSAGE(bool startImmediately, int messageId)
        {
            Invoker.Call<Void>(0x418EF2A1BCE56685, startImmediately, messageId);
        }

        public static void GIVE_PED_NM_MESSAGE(int ped)
        {
            Invoker.Call<Void>(0xB158DFCCC56E5C5B, ped);
        }

        public static int ADD_SCENARIO_BLOCKING_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7, bool p8, bool p9)
        {
            return Invoker.Call<int>(0x1B5C85C612E5256E, x1, y1, z1, x2, y2, z2, p6, p7, p8, p9);
        }

        public static void REMOVE_SCENARIO_BLOCKING_AREAS()
        {
            Invoker.Call<Void>(0xD37401D78A929A49);
        }

        public static void REMOVE_SCENARIO_BLOCKING_AREA(int areaHandle, bool p1)
        {
            Invoker.Call<Void>(0x31D16B74C6E29D66, areaHandle, p1);
        }

        public static void SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA(float x, float y, float z, float range, int p4)
        {
            Invoker.Call<Void>(0x28157D43CF600981, x, y, z, range, p4);
        }

        public static bool IS_PED_USING_SCENARIO(int ped, string scenario)
        {
            return Invoker.Call<bool>(0x1BF094736DD62C2E, ped, scenario);
        }

        public static bool IS_PED_USING_ANY_SCENARIO(int ped)
        {
            return Invoker.Call<bool>(0x57AB4A3080F85143, ped);
        }

        public static int _0xFE07FF6495D52E2A(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xFE07FF6495D52E2A, p0, p1, p2, p3);
        }

        public static void _0x9A77DFD295E29B09(int p0, bool p1)
        {
            Invoker.Call<Void>(0x9A77DFD295E29B09, p0, p1);
        }

        public static int _0x25361A96E0F7E419(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0x25361A96E0F7E419, p0, p1, p2, p3);
        }

        public static int _0xEC6935EBE0847B90(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xEC6935EBE0847B90, p0, p1, p2, p3);
        }

        public static void _0xA3A9299C4F2ADB98(int p0)
        {
            Invoker.Call<Void>(0xA3A9299C4F2ADB98, p0);
        }

        public static void _0xF1C03A5352243A30(int p0)
        {
            Invoker.Call<Void>(0xF1C03A5352243A30, p0);
        }

        public static int _0xEEED8FAFEC331A70(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xEEED8FAFEC331A70, p0, p1, p2, p3);
        }

        public static void _0x425AECF167663F48(int ped, bool p1)
        {
            Invoker.Call<Void>(0x425AECF167663F48, ped, p1);
        }

        public static void _0x5B6010B3CBC29095(int p0, bool p1)
        {
            Invoker.Call<Void>(0x5B6010B3CBC29095, p0, p1);
        }

        public static void _0xCEDA60A74219D064(int p0, bool p1)
        {
            Invoker.Call<Void>(0xCEDA60A74219D064, p0, p1);
        }

        public static void PLAY_FACIAL_ANIM(int ped, string animName, string animDict)
        {
            Invoker.Call<Void>(0xE1E65CA8AC9C00ED, ped, animName, animDict);
        }

        public static void SET_FACIAL_IDLE_ANIM_OVERRIDE(int ped, string animName, string animDict)
        {
            Invoker.Call<Void>(0xFFC24B988B938B38, ped, animName, animDict);
        }

        public static void CLEAR_FACIAL_IDLE_ANIM_OVERRIDE(int ped)
        {
            Invoker.Call<Void>(0x726256CC1EEB182F, ped);
        }

        public static void SET_PED_CAN_PLAY_GESTURE_ANIMS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xBAF20C5432058024, ped, toggle);
        }

        public static void SET_PED_CAN_PLAY_VISEME_ANIMS(int ped, bool toggle, bool p2)
        {
            Invoker.Call<Void>(0xF833DDBA3B104D43, ped, toggle, p2);
        }

        public static void _SET_PED_CAN_PLAY_INJURED_ANIMS(int ped, bool p1)
        {
            Invoker.Call<Void>(0x33A60D8BDD6E508C, ped, p1);
        }

        public static void SET_PED_CAN_PLAY_AMBIENT_ANIMS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x6373D1349925A70E, ped, toggle);
        }

        public static void SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x0EB0585D15254740, ped, toggle);
        }

        public static void _0xC2EE020F5FB4DB53(int ped)
        {
            Invoker.Call<Void>(0xC2EE020F5FB4DB53, ped);
        }

        public static void SET_PED_CAN_ARM_IK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x6C3B4D6D13B4C841, ped, toggle);
        }

        public static void SET_PED_CAN_HEAD_IK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xC11C18092C5530DC, ped, toggle);
        }

        public static void SET_PED_CAN_LEG_IK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x73518ECE2485412B, ped, toggle);
        }

        public static void SET_PED_CAN_TORSO_IK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xF2B7106D37947CE0, ped, toggle);
        }

        public static void _0xF5846EDB26A98A24(int ped, bool p1)
        {
            Invoker.Call<Void>(0xF5846EDB26A98A24, ped, p1);
        }

        public static void _0x6647C5F6F5792496(int ped, bool p1)
        {
            Invoker.Call<Void>(0x6647C5F6F5792496, ped, p1);
        }

        public static void SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xEC4686EC06434678, ped, toggle);
        }

        public static bool IS_PED_HEADTRACKING_PED(int ped1, int ped2)
        {
            return Invoker.Call<bool>(0x5CD3CB88A7F8850D, ped1, ped2);
        }

        public static bool IS_PED_HEADTRACKING_ENTITY(int ped, int entity)
        {
            return Invoker.Call<bool>(0x813A0A7C9D2E831F, ped, entity);
        }

        public static void SET_PED_PRIMARY_LOOKAT(int ped, int lookAt)
        {
            Invoker.Call<Void>(0xCD17B554996A8D9E, ped, lookAt);
        }

        public static void _0x78C4E9961DB3EB5B(int p0, int p1)
        {
            Invoker.Call<Void>(0x78C4E9961DB3EB5B, p0, p1);
        }

        public static void SET_PED_CLOTH_PRONE(int p0, int p1)
        {
            Invoker.Call<Void>(0x82A3D6D9CC2CB8E3, p0, p1);
        }

        public static void _0xA660FAF550EB37E5(int p0, bool p1)
        {
            Invoker.Call<Void>(0xA660FAF550EB37E5, p0, p1);
        }

        public static void SET_PED_CONFIG_FLAG(int ped, int flagId, bool value)
        {
            Invoker.Call<Void>(0x1913FE4CBF41C463, ped, flagId, value);
        }

        public static void SET_PED_RESET_FLAG(int ped, int flagId, bool doReset)
        {
            Invoker.Call<Void>(0xC1E8A365BF3B29F2, ped, flagId, doReset);
        }

        public static bool GET_PED_CONFIG_FLAG(int ped, int flagId, bool p2)
        {
            return Invoker.Call<bool>(0x7EE53118C892B513, ped, flagId, p2);
        }

        public static bool GET_PED_RESET_FLAG(int ped, int flagId)
        {
            return Invoker.Call<bool>(0xAF9E59B1B1FBF2A0, ped, flagId);
        }

        public static void SET_PED_GROUP_MEMBER_PASSENGER_INDEX(int ped, int index)
        {
            Invoker.Call<Void>(0x0BDDB8D9EC6BCF3C, ped, index);
        }

        public static void SET_PED_CAN_EVASIVE_DIVE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x6B7A646C242A7059, ped, toggle);
        }

        public static bool IS_PED_EVASIVE_DIVING(int ped, ulong evadingEntity_ptr)
        {
            return Invoker.Call<bool>(0x414641C26E105898, ped, evadingEntity_ptr);
        }

        public static void SET_PED_SHOOTS_AT_COORD(int ped, float x, float y, float z, bool toggle)
        {
            Invoker.Call<Void>(0x96A05E4FB321B1BA, ped, x, y, z, toggle);
        }

        public static void SET_PED_MODEL_IS_SUPPRESSED(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xE163A4BCE4DE6F11, ped, toggle);
        }

        public static void STOP_ANY_PED_MODEL_BEING_SUPPRESSED()
        {
            Invoker.Call<Void>(0xB47BD05FA66B40CF);
        }

        public static void SET_PED_CAN_BE_TARGETED_WHEN_INJURED(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x638C03B0F9878F57, ped, toggle);
        }

        public static void SET_PED_GENERATES_DEAD_BODY_EVENTS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x7FB17BA2E7DECA5B, ped, toggle);
        }

        public static void _0xE43A13C9E4CCCBCF(int ped, bool p1)
        {
            Invoker.Call<Void>(0xE43A13C9E4CCCBCF, ped, p1);
        }

        public static void SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xDF993EE5E90ABA25, ped, toggle);
        }

        public static void GIVE_PED_HELMET(int ped, bool cannotRemove, int helmetFlag, int textureIndex)
        {
            Invoker.Call<Void>(0x54C7C4A94367717E, ped, cannotRemove, helmetFlag, textureIndex);
        }

        public static void REMOVE_PED_HELMET(int ped, bool instantly)
        {
            Invoker.Call<Void>(0xA7B2458D0AD6DED8, ped, instantly);
        }

        public static bool _0x14590DDBEDB1EC85(int ped)
        {
            return Invoker.Call<bool>(0x14590DDBEDB1EC85, ped);
        }

        public static void SET_PED_HELMET(int ped, bool canWearHelmet)
        {
            Invoker.Call<Void>(0x560A43136EB58105, ped, canWearHelmet);
        }

        public static void SET_PED_HELMET_FLAG(int ped, int helmetFlag)
        {
            Invoker.Call<Void>(0xC0E78D5C2CE3EB25, ped, helmetFlag);
        }

        public static void SET_PED_HELMET_PROP_INDEX(int ped, int propIndex)
        {
            Invoker.Call<Void>(0x26D83693ED99291C, ped, propIndex);
        }

        public static void SET_PED_HELMET_TEXTURE_INDEX(int ped, int textureIndex)
        {
            Invoker.Call<Void>(0xF1550C4BD22582E2, ped, textureIndex);
        }

        public static bool IS_PED_WEARING_HELMET(int ped)
        {
            return Invoker.Call<bool>(0xF33BDFE19B309B19, ped);
        }

        public static void _0x687C0B594907D2E8(int ped)
        {
            Invoker.Call<Void>(0x687C0B594907D2E8, ped);
        }

        public static bool _0x451294E859ECC018(int p0)
        {
            return Invoker.Call<bool>(0x451294E859ECC018, p0);
        }

        public static int _0x9D728C1E12BF5518(int p0)
        {
            return Invoker.Call<int>(0x9D728C1E12BF5518, p0);
        }

        public static bool _0xF2385935BFFD4D92(int p0)
        {
            return Invoker.Call<bool>(0xF2385935BFFD4D92, p0);
        }

        public static void SET_PED_TO_LOAD_COVER(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x332B562EEDA62399, ped, toggle);
        }

        public static void SET_PED_CAN_COWER_IN_COVER(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xCB7553CDCEF4A735, ped, toggle);
        }

        public static void SET_PED_CAN_PEEK_IN_COVER(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xC514825C507E3736, ped, toggle);
        }

        public static void SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x94D94BF1A75AED3D, ped, toggle);
        }

        public static void SET_PED_LEG_IK_MODE(int ped, int mode)
        {
            Invoker.Call<Void>(0xC396F5B86FF9FEBD, ped, mode);
        }

        public static void SET_PED_MOTION_BLUR(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x0A986918B102B448, ped, toggle);
        }

        public static void SET_PED_CAN_SWITCH_WEAPON(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xED7F7EFE9FABF340, ped, toggle);
        }

        public static void SET_PED_DIES_INSTANTLY_IN_WATER(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xEEB64139BA29A7CF, ped, toggle);
        }

        public static void _0x1A330D297AAC6BC1(int ped, int p1)
        {
            Invoker.Call<Void>(0x1A330D297AAC6BC1, ped, p1);
        }

        public static void STOP_PED_WEAPON_FIRING_WHEN_DROPPED(int ped)
        {
            Invoker.Call<Void>(0xC158D28142A34608, ped);
        }

        public static void SET_SCRIPTED_ANIM_SEAT_OFFSET(int ped, float p1)
        {
            Invoker.Call<Void>(0x5917BBA32D06C230, ped, p1);
        }

        public static void SET_PED_COMBAT_MOVEMENT(int ped, int combatMovement)
        {
            Invoker.Call<Void>(0x4D9CA1009AFBD057, ped, combatMovement);
        }

        public static int GET_PED_COMBAT_MOVEMENT(int ped)
        {
            return Invoker.Call<int>(0xDEA92412FCAEB3F5, ped);
        }

        public static void SET_PED_COMBAT_ABILITY(int ped, int p1)
        {
            Invoker.Call<Void>(0xC7622C0D36B2FDA8, ped, p1);
        }

        public static void SET_PED_COMBAT_RANGE(int ped, int p1)
        {
            Invoker.Call<Void>(0x3C606747B23E497B, ped, p1);
        }

        public static int GET_PED_COMBAT_RANGE(int ped)
        {
            return Invoker.Call<int>(0xF9D9F7F2DB8E2FA0, ped);
        }

        public static void SET_PED_COMBAT_ATTRIBUTES(int ped, int attributeIndex, bool enabled)
        {
            Invoker.Call<Void>(0x9F7794730795E019, ped, attributeIndex, enabled);
        }

        public static void SET_PED_TARGET_LOSS_RESPONSE(int ped, int responseType)
        {
            Invoker.Call<Void>(0x0703B9079823DA4A, ped, responseType);
        }

        public static bool _0xDCCA191DF9980FD7(int ped)
        {
            return Invoker.Call<bool>(0xDCCA191DF9980FD7, ped);
        }

        public static bool IS_PED_PERFORMING_STEALTH_KILL(int ped)
        {
            return Invoker.Call<bool>(0xFD4CCDBCC59941B7, ped);
        }

        public static bool _0xEBD0EDBA5BE957CF(int ped)
        {
            return Invoker.Call<bool>(0xEBD0EDBA5BE957CF, ped);
        }

        public static bool IS_PED_BEING_STEALTH_KILLED(int ped)
        {
            return Invoker.Call<bool>(0x863B23EFDE9C5DF2, ped);
        }

        public static int GET_MELEE_TARGET_FOR_PED(int ped)
        {
            return Invoker.Call<int>(0x18A3E9EE1297FD39, ped);
        }

        public static bool WAS_PED_KILLED_BY_STEALTH(int ped)
        {
            return Invoker.Call<bool>(0xF9800AA1A771B000, ped);
        }

        public static bool WAS_PED_KILLED_BY_TAKEDOWN(int ped)
        {
            return Invoker.Call<bool>(0x7F08E26039C7347C, ped);
        }

        public static bool _0x61767F73EACEED21(int ped)
        {
            return Invoker.Call<bool>(0x61767F73EACEED21, ped);
        }

        public static void SET_PED_FLEE_ATTRIBUTES(int ped, int attributes, bool p2)
        {
            Invoker.Call<Void>(0x70A2D1137C8ED7C9, ped, attributes, p2);
        }

        public static void SET_PED_COWER_HASH(int ped, string p1)
        {
            Invoker.Call<Void>(0xA549131166868ED3, ped, p1);
        }

        public static void _0x2016C603D6B8987C(int p0, bool p1)
        {
            Invoker.Call<Void>(0x2016C603D6B8987C, p0, p1);
        }

        public static void SET_PED_STEERS_AROUND_PEDS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x46F2193B3AD1D891, ped, toggle);
        }

        public static void SET_PED_STEERS_AROUND_OBJECTS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x1509C089ADC208BF, ped, toggle);
        }

        public static void SET_PED_STEERS_AROUND_VEHICLES(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xEB6FB9D48DDE23EC, ped, toggle);
        }

        public static void _0xA9B61A329BFDCBEA(int p0, bool p1)
        {
            Invoker.Call<Void>(0xA9B61A329BFDCBEA, p0, p1);
        }

        public static void _0x570389D1C3DE3C6B(int p0)
        {
            Invoker.Call<Void>(0x570389D1C3DE3C6B, p0);
        }

        public static void _0x576594E8D64375E2(int p0, bool p1)
        {
            Invoker.Call<Void>(0x576594E8D64375E2, p0, p1);
        }

        public static void _0xA52D5247A4227E14(int p0)
        {
            Invoker.Call<Void>(0xA52D5247A4227E14, p0);
        }

        public static bool IS_ANY_PED_NEAR_POINT(float x, float y, float z, float radius)
        {
            return Invoker.Call<bool>(0x083961498679DC9F, x, y, z, radius);
        }

        public static void _0x2208438012482A1A(int ped, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x2208438012482A1A, ped, p1, p2);
        }

        public static bool _0xFCF37A457CB96DC0(int p0, float p1, float p2, float p3, float p4)
        {
            return Invoker.Call<bool>(0xFCF37A457CB96DC0, p0, p1, p2, p3, p4);
        }

        public static void _0x7D7A2E43E74E2EB8(int p0)
        {
            Invoker.Call<Void>(0x7D7A2E43E74E2EB8, p0);
        }

        public static void GET_PED_FLOOD_INVINCIBILITY(int ped, bool p1)
        {
            Invoker.Call<Void>(0x2BC338A7B21F4608, ped, p1);
        }

        public static void _0xCD018C591F94CB43(int p0, bool p1)
        {
            Invoker.Call<Void>(0xCD018C591F94CB43, p0, p1);
        }

        public static void _0x75BA1CB3B7D40CAF(int ped, bool p1)
        {
            Invoker.Call<Void>(0x75BA1CB3B7D40CAF, ped, p1);
        }

        public static bool IS_TRACKED_PED_VISIBLE(int ped)
        {
            return Invoker.Call<bool>(0x91C8E617F64188AC, ped);
        }

        public static int _0x511F1A683387C7E2(int p0)
        {
            return Invoker.Call<int>(0x511F1A683387C7E2, p0);
        }

        public static bool IS_PED_TRACKED(int ped)
        {
            return Invoker.Call<bool>(0x4C5E1F087CD10BB7, ped);
        }

        public static bool HAS_PED_RECEIVED_EVENT(int ped, int p1)
        {
            return Invoker.Call<bool>(0x8507BCB710FA6DC0, ped, p1);
        }

        public static bool _CAN_PED_SEE_PED(int ped1, int ped2)
        {
            return Invoker.Call<bool>(0x6CD5A433374D4CFB, ped1, ped2);
        }

        public static bool _0x9C6A6C19B6C0C496(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x9C6A6C19B6C0C496, p0, p1_ptr);
        }

        public static int GET_PED_BONE_INDEX(int ped, int boneId)
        {
            return Invoker.Call<int>(0x3F428D08BE5AAE31, ped, boneId);
        }

        public static int GET_PED_RAGDOLL_BONE_INDEX(int ped, int bone)
        {
            return Invoker.Call<int>(0x2057EF813397A772, ped, bone);
        }

        public static void SET_PED_ENVEFF_SCALE(int ped, float value)
        {
            Invoker.Call<Void>(0xBF29516833893561, ped, value);
        }

        public static float GET_PED_ENVEFF_SCALE(int ped)
        {
            return Invoker.Call<float>(0x9C14D30395A51A3C, ped);
        }

        public static void SET_ENABLE_PED_ENVEFF_SCALE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xD2C5AA0C0E8D0F1E, ped, toggle);
        }

        public static void _0x110F526AB784111F(int ped, float p1)
        {
            Invoker.Call<Void>(0x110F526AB784111F, ped, p1);
        }

        public static void _0xD69411AA0CEBF9E9(int ped, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xD69411AA0CEBF9E9, ped, p1, p2, p3);
        }

        public static void _0x1216E0BFA72CC703(int p0, int p1)
        {
            Invoker.Call<Void>(0x1216E0BFA72CC703, p0, p1);
        }

        public static void _0x2B5AA717A181FB4C(int p0, bool p1)
        {
            Invoker.Call<Void>(0x2B5AA717A181FB4C, p0, p1);
        }

        public static bool _0xB8B52E498014F5B0(int ped)
        {
            return Invoker.Call<bool>(0xB8B52E498014F5B0, ped);
        }

        public static int CREATE_SYNCHRONIZED_SCENE(float x, float y, float z, float roll, float pitch, float yaw, int p6)
        {
            return Invoker.Call<int>(0x8C18E0F9080ADD73, x, y, z, roll, pitch, yaw, p6);
        }

        public static int _CREATE_SYNCHRONIZED_SCENE_2(float x, float y, float z, float radius, int _object)
        {
            return Invoker.Call<int>(0x62EC273D00187DCA, x, y, z, radius, _object);
        }

        public static bool IS_SYNCHRONIZED_SCENE_RUNNING(int sceneId)
        {
            return Invoker.Call<bool>(0x25D39B935A038A26, sceneId);
        }

        public static void SET_SYNCHRONIZED_SCENE_ORIGIN(int sceneID, float x, float y, float z, float roll, float pitch, float yaw, bool p7)
        {
            Invoker.Call<Void>(0x6ACF6B7225801CD7, sceneID, x, y, z, roll, pitch, yaw, p7);
        }

        public static void SET_SYNCHRONIZED_SCENE_PHASE(int sceneID, float phase)
        {
            Invoker.Call<Void>(0x734292F4F0ABF6D0, sceneID, phase);
        }

        public static float GET_SYNCHRONIZED_SCENE_PHASE(int sceneID)
        {
            return Invoker.Call<float>(0xE4A310B1D7FA73CC, sceneID);
        }

        public static void SET_SYNCHRONIZED_SCENE_RATE(int sceneID, float rate)
        {
            Invoker.Call<Void>(0xB6C49F8A5E295A5D, sceneID, rate);
        }

        public static float GET_SYNCHRONIZED_SCENE_RATE(int sceneID)
        {
            return Invoker.Call<float>(0xD80932D577274D40, sceneID);
        }

        public static void SET_SYNCHRONIZED_SCENE_LOOPED(int sceneID, bool toggle)
        {
            Invoker.Call<Void>(0xD9A897A4C6C2974F, sceneID, toggle);
        }

        public static bool IS_SYNCHRONIZED_SCENE_LOOPED(int sceneID)
        {
            return Invoker.Call<bool>(0x62522002E0C391BA, sceneID);
        }

        public static void _SET_SYNCHRONIZED_SCENE_OCCLUSION_PORTAL(int sceneID, bool p1)
        {
            Invoker.Call<Void>(0x394B9CD12435C981, sceneID, p1);
        }

        public static bool _0x7F2F4F13AC5257EF(int p0)
        {
            return Invoker.Call<bool>(0x7F2F4F13AC5257EF, p0);
        }

        public static void ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY(int sceneID, int entity, int boneIndex)
        {
            Invoker.Call<Void>(0x272E4723B56A3B96, sceneID, entity, boneIndex);
        }

        public static void DETACH_SYNCHRONIZED_SCENE(int sceneID)
        {
            Invoker.Call<Void>(0x6D38F1F04CBB37EA, sceneID);
        }

        public static void _DISPOSE_SYNCHRONIZED_SCENE(int scene)
        {
            Invoker.Call<Void>(0xCD9CC7E200A52A6F, scene);
        }

        public static bool FORCE_PED_MOTION_STATE(int ped, int motionStateHash, bool p2, bool p3, bool p4)
        {
            return Invoker.Call<bool>(0xF28965D04F570DCA, ped, motionStateHash, p2, p3, p4);
        }

        public static bool _0xF60165E1D2C5370B(int ped, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xF60165E1D2C5370B, ped, p1_ptr, p2_ptr);
        }

        public static void SET_PED_MAX_MOVE_BLEND_RATIO(int ped, float value)
        {
            Invoker.Call<Void>(0x433083750C5E064A, ped, value);
        }

        public static void SET_PED_MIN_MOVE_BLEND_RATIO(int ped, float value)
        {
            Invoker.Call<Void>(0x01A898D26E2333DD, ped, value);
        }

        public static void SET_PED_MOVE_RATE_OVERRIDE(int ped, float value)
        {
            Invoker.Call<Void>(0x085BF80FA50A39D1, ped, value);
        }

        public static bool _0x46B05BCAE43856B0(int ped, int flag)
        {
            return Invoker.Call<bool>(0x46B05BCAE43856B0, ped, flag);
        }

        public static int GET_PED_NEARBY_VEHICLES(int ped, ulong sizeAndVehs_ptr)
        {
            return Invoker.Call<int>(0xCFF869CBFA210D82, ped, sizeAndVehs_ptr);
        }

        public static int GET_PED_NEARBY_PEDS(int ped, ulong sizeAndPeds_ptr, int ignore)
        {
            return Invoker.Call<int>(0x23F8F5FC7E8C4A6B, ped, sizeAndPeds_ptr, ignore);
        }

        public static bool _0x7350823473013C02(int ped)
        {
            return Invoker.Call<bool>(0x7350823473013C02, ped);
        }

        public static bool IS_PED_USING_ACTION_MODE(int ped)
        {
            return Invoker.Call<bool>(0x00E73468D085F745, ped);
        }

        public static void SET_PED_USING_ACTION_MODE(int ped, bool p1, int p2, string action)
        {
            Invoker.Call<Void>(0xD75ACCF5E0FB5367, ped, p1, p2, action);
        }

        public static void _0x781DE8FA214E87D2(int ped, string p1)
        {
            Invoker.Call<Void>(0x781DE8FA214E87D2, ped, p1);
        }

        public static void SET_PED_CAPSULE(int ped, float value)
        {
            Invoker.Call<Void>(0x364DF566EC833DE2, ped, value);
        }

        public static int REGISTER_PEDHEADSHOT(int ped)
        {
            return Invoker.Call<int>(0x4462658788425076, ped);
        }

        public static int _0x953563CE563143AF(int p0)
        {
            return Invoker.Call<int>(0x953563CE563143AF, p0);
        }

        public static void UNREGISTER_PEDHEADSHOT(int handle)
        {
            Invoker.Call<Void>(0x96B1361D9B24C2FF, handle);
        }

        public static bool IS_PEDHEADSHOT_VALID(int handle)
        {
            return Invoker.Call<bool>(0xA0A9668F158129A2, handle);
        }

        public static bool IS_PEDHEADSHOT_READY(int handle)
        {
            return Invoker.Call<bool>(0x7085228842B13A67, handle);
        }

        public static string GET_PEDHEADSHOT_TXD_STRING(int handle)
        {
            return Invoker.Call<string>(0xDB4EACD4AD0A5D6B, handle);
        }

        public static bool _0xF0DAEF2F545BEE25(int p0)
        {
            return Invoker.Call<bool>(0xF0DAEF2F545BEE25, p0);
        }

        public static void _0x5D517B27CF6ECD04(int p0)
        {
            Invoker.Call<Void>(0x5D517B27CF6ECD04, p0);
        }

        public static int _0xEBB376779A760AA8()
        {
            return Invoker.Call<int>(0xEBB376779A760AA8);
        }

        public static int _0x876928DDDFCCC9CD()
        {
            return Invoker.Call<int>(0x876928DDDFCCC9CD);
        }

        public static int _0xE8A169E666CBC541()
        {
            return Invoker.Call<int>(0xE8A169E666CBC541);
        }

        public static void _0xC1F6EBF9A3D55538(int p0, int p1)
        {
            Invoker.Call<Void>(0xC1F6EBF9A3D55538, p0, p1);
        }

        public static void _0x600048C60D5C2C51(int p0)
        {
            Invoker.Call<Void>(0x600048C60D5C2C51, p0);
        }

        public static void _0x2DF9038C90AD5264(float p0, float p1, float p2, float p3, float p4, int interiorFlags, float scale, int duration)
        {
            Invoker.Call<Void>(0x2DF9038C90AD5264, p0, p1, p2, p3, p4, interiorFlags, scale, duration);
        }

        public static void _0xB2AFF10216DEFA2F(float x, float y, float z, float p3, float p4, float p5, float p6, int interiorFlags, float scale, int duration)
        {
            Invoker.Call<Void>(0xB2AFF10216DEFA2F, x, y, z, p3, p4, p5, p6, interiorFlags, scale, duration);
        }

        public static void _0xFEE4A5459472A9F8()
        {
            Invoker.Call<Void>(0xFEE4A5459472A9F8);
        }

        public static int _0x3C67506996001F5E()
        {
            return Invoker.Call<int>(0x3C67506996001F5E);
        }

        public static int _0xA586FBEB32A53DBB()
        {
            return Invoker.Call<int>(0xA586FBEB32A53DBB);
        }

        public static int _0xF445DE8DA80A1792()
        {
            return Invoker.Call<int>(0xF445DE8DA80A1792);
        }

        public static int _0xA635C11B8C44AFC2()
        {
            return Invoker.Call<int>(0xA635C11B8C44AFC2);
        }

        public static void _0x280C7E3AC7F56E90(int p0, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0x280C7E3AC7F56E90, p0, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _0xB782F8238512BAD5(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0xB782F8238512BAD5, p0, p1_ptr);
        }

        public static void SET_IK_TARGET(int ped, int ikIndex, int entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, int p7, int blendInDuration, int blendOutDuration)
        {
            Invoker.Call<Void>(0xC32779C16FCEECD9, ped, ikIndex, entityLookAt, boneLookAt, offsetX, offsetY, offsetZ, p7, blendInDuration, blendOutDuration);
        }

        public static void _0xED3C76ADFA6D07C4(int ped)
        {
            Invoker.Call<Void>(0xED3C76ADFA6D07C4, ped);
        }

        public static void REQUEST_ACTION_MODE_ASSET(string asset)
        {
            Invoker.Call<Void>(0x290E2780BB7AA598, asset);
        }

        public static bool HAS_ACTION_MODE_ASSET_LOADED(string asset)
        {
            return Invoker.Call<bool>(0xE4B5F4BF2CB24E65, asset);
        }

        public static void REMOVE_ACTION_MODE_ASSET(string asset)
        {
            Invoker.Call<Void>(0x13E940F88470FA51, asset);
        }

        public static void REQUEST_STEALTH_MODE_ASSET(string asset)
        {
            Invoker.Call<Void>(0x2A0A62FCDEE16D4F, asset);
        }

        public static bool HAS_STEALTH_MODE_ASSET_LOADED(string asset)
        {
            return Invoker.Call<bool>(0xE977FC5B08AF3441, asset);
        }

        public static void REMOVE_STEALTH_MODE_ASSET(string asset)
        {
            Invoker.Call<Void>(0x9219857D21F0E842, asset);
        }

        public static void SET_PED_LOD_MULTIPLIER(int ped, float multiplier)
        {
            Invoker.Call<Void>(0xDC2C5C242AAC342B, ped, multiplier);
        }

        public static void _0xE861D0B05C7662B8(int p0, int p1, ulong p2_ptr)
        {
            Invoker.Call<Void>(0xE861D0B05C7662B8, p0, p1, p2_ptr);
        }

        public static void _0x129466ED55140F8D(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x129466ED55140F8D, ped, toggle);
        }

        public static void _0xCB968B53FC7F916D(int p0, bool p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xCB968B53FC7F916D, p0, p1, p2, p3);
        }

        public static bool _0x68772DB2B2526F9F(int ped, float x, float y, float z, float range)
        {
            return Invoker.Call<bool>(0x68772DB2B2526F9F, ped, x, y, z, range);
        }

        public static bool _0x06087579E7AA85A9(int p0, int p1, float p2, float p3, float p4, float p5)
        {
            return Invoker.Call<bool>(0x06087579E7AA85A9, p0, p1, p2, p3, p4, p5);
        }

        public static void _0xD8C3BE3EE94CAF2D(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0xD8C3BE3EE94CAF2D, p0, p1, p2, p3, p4);
        }

        public static void _0xD33DAA36272177C4(int ped)
        {
            Invoker.Call<Void>(0xD33DAA36272177C4, ped);
        }

        public static void _0x83A169EABCDB10A2(int p0, int p1)
        {
            Invoker.Call<Void>(0x83A169EABCDB10A2, p0, p1);
        }

        public static void _0x288DF530C92DAD6F(int p0, float p1)
        {
            Invoker.Call<Void>(0x288DF530C92DAD6F, p0, p1);
        }

    }

    public static class VEHICLE
    {

        public static int CREATE_VEHICLE(int modelHash, float x, float y, float z, float heading, bool isNetwork, bool thisScriptCheck)
        {
            return Invoker.Call<int>(0xAF35D0D2583051B0, modelHash, x, y, z, heading, isNetwork, thisScriptCheck);
        }

        public static void DELETE_VEHICLE(ulong vehicle_ptr)
        {
            Invoker.Call<Void>(0xEA386986E786A54F, vehicle_ptr);
        }

        public static void _0x7D6F9A3EF26136A0(int vehicle, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x7D6F9A3EF26136A0, vehicle, p1, p2);
        }

        public static void SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON(int veh, bool toggle)
        {
            Invoker.Call<Void>(0x5D14D4154BFE7B2C, veh, toggle);
        }

        public static int _0xE6B0E8CFC3633BF0(int vehicle)
        {
            return Invoker.Call<int>(0xE6B0E8CFC3633BF0, vehicle);
        }

        public static bool IS_VEHICLE_MODEL(int vehicle, int model)
        {
            return Invoker.Call<bool>(0x423E8DE37D934D89, vehicle, model);
        }

        public static bool DOES_SCRIPT_VEHICLE_GENERATOR_EXIST(int v)
        {
            return Invoker.Call<bool>(0xF6086BC836400876, v);
        }

        public static int CREATE_SCRIPT_VEHICLE_GENERATOR(float x, float y, float z, float heading, float p4, float p5, int modelHash, int p7, int p8, int p9, int p10, bool p11, bool p12, bool p13, bool p14, bool p15, int p16)
        {
            return Invoker.Call<int>(0x9DEF883114668116, x, y, z, heading, p4, p5, modelHash, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }

        public static void DELETE_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator)
        {
            Invoker.Call<Void>(0x22102C9ABFCF125D, vehicleGenerator);
        }

        public static void SET_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator, bool enabled)
        {
            Invoker.Call<Void>(0xD9D620E0AC6DC4B0, vehicleGenerator, enabled);
        }

        public static void SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7)
        {
            Invoker.Call<Void>(0xC12321827687FE4D, x1, y1, z1, x2, y2, z2, p6, p7);
        }

        public static void SET_ALL_VEHICLE_GENERATORS_ACTIVE()
        {
            Invoker.Call<Void>(0x34AD89078831A4BC);
        }

        public static void SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE(bool active)
        {
            Invoker.Call<Void>(0x608207E7A8FB787C, active);
        }

        public static void _0x9A75585FB2E54FAD(float p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x9A75585FB2E54FAD, p0, p1, p2, p3);
        }

        public static void _0x0A436B8643716D14()
        {
            Invoker.Call<Void>(0x0A436B8643716D14);
        }

        public static bool SET_VEHICLE_ON_GROUND_PROPERLY(int vehicle)
        {
            return Invoker.Call<bool>(0x49733E92263139D1, vehicle);
        }

        public static int SET_ALL_VEHICLES_SPAWN(int p0, bool p1, bool p2, bool p3)
        {
            return Invoker.Call<int>(0xE023E8AC4EF7C117, p0, p1, p2, p3);
        }

        public static bool IS_VEHICLE_STUCK_ON_ROOF(int vehicle)
        {
            return Invoker.Call<bool>(0xB497F06B288DCFDF, vehicle);
        }

        public static void ADD_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)
        {
            Invoker.Call<Void>(0xB72E26D81006005B, vehicle);
        }

        public static void REMOVE_VEHICLE_UPSIDEDOWN_CHECK(int vehicle)
        {
            Invoker.Call<Void>(0xC53EB42A499A7E90, vehicle);
        }

        public static bool IS_VEHICLE_STOPPED(int vehicle)
        {
            return Invoker.Call<bool>(0x5721B434AD84D57A, vehicle);
        }

        public static int GET_VEHICLE_NUMBER_OF_PASSENGERS(int vehicle)
        {
            return Invoker.Call<int>(0x24CB2137731FFE89, vehicle);
        }

        public static int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int vehicle)
        {
            return Invoker.Call<int>(0xA7C4F2C6E744A550, vehicle);
        }

        public static int GET_VEHICLE_MODEL_NUMBER_OF_SEATS(int modelHash)
        {
            return Invoker.Call<int>(0x2AD93716F184EDA4, modelHash);
        }

        public static bool _0xF7F203E31F96F6A1(int vehicle, bool flag)
        {
            return Invoker.Call<bool>(0xF7F203E31F96F6A1, vehicle, flag);
        }

        public static bool _0xE33FFA906CE74880(int vehicle, int p1)
        {
            return Invoker.Call<bool>(0xE33FFA906CE74880, vehicle, p1);
        }

        public static void SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
        {
            Invoker.Call<Void>(0x245A6883D966D537, multiplier);
        }

        public static void SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
        {
            Invoker.Call<Void>(0xB3B3359379FE77D3, multiplier);
        }

        public static void SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier)
        {
            Invoker.Call<Void>(0xEAE6DCC7EEE3DB1D, multiplier);
        }

        public static void _SET_SOMETHING_MULTIPLIER_THIS_FRAME(bool toggle)
        {
            Invoker.Call<Void>(0xD4B8E3D1917BC86B, toggle);
        }

        public static void _SET_SOME_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float value)
        {
            Invoker.Call<Void>(0x90B6DA738A9A25DA, value);
        }

        public static void SET_FAR_DRAW_VEHICLES(bool toggle)
        {
            Invoker.Call<Void>(0x26324F33423F3CC3, toggle);
        }

        public static int SET_NUMBER_OF_PARKED_VEHICLES(int value)
        {
            return Invoker.Call<int>(0xCAA15F13EBD417FF, value);
        }

        public static void SET_VEHICLE_DOORS_LOCKED(int vehicle, int doorLockStatus)
        {
            Invoker.Call<Void>(0xB664292EAECF7FA6, vehicle, doorLockStatus);
        }

        public static void SET_PED_TARGETTABLE_VEHICLE_DESTROY(int vehicle, int doorIndex, int destroyType)
        {
            Invoker.Call<Void>(0xBE70724027F85BCD, vehicle, doorIndex, destroyType);
        }

        public static void DISABLE_VEHICLE_IMPACT_EXPLOSION_ACTIVATION(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xD8050E0EB60CF274, vehicle, toggle);
        }

        public static void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player, bool toggle)
        {
            Invoker.Call<Void>(0x517AAF684BB50CD1, vehicle, player, toggle);
        }

        public static bool GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player)
        {
            return Invoker.Call<bool>(0xF6AF6CB341349015, vehicle, player);
        }

        public static void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xA2F80B8D040727CC, vehicle, toggle);
        }

        public static void _0x9737A37136F07E75(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x9737A37136F07E75, vehicle, toggle);
        }

        public static void SET_VEHICLE_DOORS_LOCKED_FOR_TEAM(int vehicle, int team, bool toggle)
        {
            Invoker.Call<Void>(0xB81F6D4A8F5EEBA8, vehicle, team, toggle);
        }

        public static void EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible)
        {
            Invoker.Call<Void>(0xBA71116ADF5B514C, vehicle, isAudible, isInvisible);
        }

        public static void SET_VEHICLE_OUT_OF_CONTROL(int vehicle, bool killDriver, bool explodeOnImpact)
        {
            Invoker.Call<Void>(0xF19D095E42D430CC, vehicle, killDriver, explodeOnImpact);
        }

        public static void SET_VEHICLE_TIMED_EXPLOSION(int vehicle, int ped, bool toggle)
        {
            Invoker.Call<Void>(0x2E0A74E1002380B1, vehicle, ped, toggle);
        }

        public static void _0x99AD4CCCB128CBC9(int vehicle)
        {
            Invoker.Call<Void>(0x99AD4CCCB128CBC9, vehicle);
        }

        public static int _0x6ADAABD3068C5235()
        {
            return Invoker.Call<int>(0x6ADAABD3068C5235);
        }

        public static void _REQUEST_VEHICLE_PHONE_EXPLOSION()
        {
            Invoker.Call<Void>(0xEF49CF0270307CBE);
        }

        public static bool _0xAE3FEE8709B39DCB(int vehicle)
        {
            return Invoker.Call<bool>(0xAE3FEE8709B39DCB, vehicle);
        }

        public static void SET_TAXI_LIGHTS(int vehicle, bool state)
        {
            Invoker.Call<Void>(0x598803E85E8448D9, vehicle, state);
        }

        public static bool IS_TAXI_LIGHT_ON(int vehicle)
        {
            return Invoker.Call<bool>(0x7504C0F113AB50FC, vehicle);
        }

        public static bool IS_VEHICLE_IN_GARAGE_AREA(string garageName, int vehicle)
        {
            return Invoker.Call<bool>(0xCEE4490CD57BB3C2, garageName, vehicle);
        }

        public static void SET_VEHICLE_COLOURS(int vehicle, int colorPrimary, int colorSecondary)
        {
            Invoker.Call<Void>(0x4F1D4BE3A7F24601, vehicle, colorPrimary, colorSecondary);
        }

        public static void SET_VEHICLE_FULLBEAM(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x8B7FD87F0DDB421E, vehicle, toggle);
        }

        public static void STEER_UNLOCK_BIAS(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x07116E24E9D1929D, vehicle, toggle);
        }

        public static void SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, int r, int g, int b)
        {
            Invoker.Call<Void>(0x7141766F91D15BEA, vehicle, r, g, b);
        }

        public static void GET_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0xB64CF2CCA9D95F52, vehicle, r_ptr, g_ptr, b_ptr);
        }

        public static int CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR(int vehicle)
        {
            return Invoker.Call<int>(0x55E1D2758F34E437, vehicle);
        }

        public static bool GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM(int vehicle)
        {
            return Invoker.Call<bool>(0xF095C0405307B21B, vehicle);
        }

        public static void SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, int r, int g, int b)
        {
            Invoker.Call<Void>(0x36CED73BFED89754, vehicle, r, g, b);
        }

        public static void GET_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0x8389CD56CA8072DC, vehicle, r_ptr, g_ptr, b_ptr);
        }

        public static int CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR(int vehicle)
        {
            return Invoker.Call<int>(0x5FFBDEEC3E8E2009, vehicle);
        }

        public static bool GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM(int vehicle)
        {
            return Invoker.Call<bool>(0x910A32E7AAD2656C, vehicle);
        }

        public static void SET_VEHICLE_ENVEFF_SCALE(int vehicle, float fade)
        {
            Invoker.Call<Void>(0x3AFDC536C3D01674, vehicle, fade);
        }

        public static float GET_VEHICLE_ENVEFF_SCALE(int vehicle)
        {
            return Invoker.Call<float>(0xA82819CAC9C4C403, vehicle);
        }

        public static void SET_CAN_RESPRAY_VEHICLE(int vehicle, bool state)
        {
            Invoker.Call<Void>(0x52BBA29D5EC69356, vehicle, state);
        }

        public static void _0x33506883545AC0DF(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x33506883545AC0DF, vehicle, p1);
        }

        public static void _JITTER_VEHICLE(int vehicle, bool p1, float yaw, float pitch, float roll)
        {
            Invoker.Call<Void>(0xC59872A5134879C7, vehicle, p1, yaw, pitch, roll);
        }

        public static void SET_BOAT_ANCHOR(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x75DBEC174AEEAD10, vehicle, toggle);
        }

        public static bool _GET_BOAT_ANCHOR(int vehicle)
        {
            return Invoker.Call<bool>(0x26C10ECBDA5D043B, vehicle);
        }

        public static void _0xE3EBAAE484798530(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xE3EBAAE484798530, vehicle, p1);
        }

        public static void _0xB28B1FE5BFADD7F5(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xB28B1FE5BFADD7F5, vehicle, p1);
        }

        public static void _0xE842A9398079BD82(int vehicle, float p1)
        {
            Invoker.Call<Void>(0xE842A9398079BD82, vehicle, p1);
        }

        public static void _0x8F719973E1445BA2(int vehicle, int p1)
        {
            Invoker.Call<Void>(0x8F719973E1445BA2, vehicle, p1);
        }

        public static void SET_VEHICLE_SIREN(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xF4924635A19EB37D, vehicle, toggle);
        }

        public static bool IS_VEHICLE_SIREN_ON(int vehicle)
        {
            return Invoker.Call<bool>(0x4C9BF537BE2634B2, vehicle);
        }

        public static bool _IS_VEHICLE_SIREN_SOUND_ON(int vehicle)
        {
            return Invoker.Call<bool>(0xB5CC40FBCB586380, vehicle);
        }

        public static void SET_VEHICLE_STRONG(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x3E8C8727991A8A0B, vehicle, toggle);
        }

        public static void REMOVE_VEHICLE_STUCK_CHECK(int vehicle)
        {
            Invoker.Call<Void>(0x8386BFB614D06749, vehicle);
        }

        public static void GET_VEHICLE_COLOURS(int vehicle, ulong colorPrimary_ptr, ulong colorSecondary_ptr)
        {
            Invoker.Call<Void>(0xA19435F193E081AC, vehicle, colorPrimary_ptr, colorSecondary_ptr);
        }

        public static bool IS_VEHICLE_SEAT_FREE(int vehicle, int seatIndex)
        {
            return Invoker.Call<bool>(0x22AC59A870E6A669, vehicle, seatIndex);
        }

        public static int GET_PED_IN_VEHICLE_SEAT(int vehicle, int index)
        {
            return Invoker.Call<int>(0xBB40DD2270B65366, vehicle, index);
        }

        public static int GET_LAST_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex)
        {
            return Invoker.Call<int>(0x83F969AA1EE2A664, vehicle, seatIndex);
        }

        public static bool GET_VEHICLE_LIGHTS_STATE(int vehicle, ulong lightsOn_ptr, ulong highbeamsOn_ptr)
        {
            return Invoker.Call<bool>(0xB91B4C20085BD12F, vehicle, lightsOn_ptr, highbeamsOn_ptr);
        }

        public static int IS_VEHICLE_TYRE_BURST(int vehicle, int wheel_rf, bool completely)
        {
            return Invoker.Call<int>(0xBA291848A0815CA9, vehicle, wheel_rf, completely);
        }

        public static void SET_VEHICLE_FORWARD_SPEED(int vehicle, float speed)
        {
            Invoker.Call<Void>(0xAB54A438726D25D5, vehicle, speed);
        }

        public static void _SET_VEHICLE_HALT(int vehicle, float distance, int killEngine, bool unknown)
        {
            Invoker.Call<Void>(0x260BE8F09E326A20, vehicle, distance, killEngine, unknown);
        }

        public static void _0x37EBBF3117BD6A25(int vehicle, float height)
        {
            Invoker.Call<Void>(0x37EBBF3117BD6A25, vehicle, height);
        }

        public static bool SET_PED_ENABLED_BIKE_RINGTONE(int vehicle, int entity)
        {
            return Invoker.Call<bool>(0x57715966069157AD, vehicle, entity);
        }

        public static bool _0x62CA17B74C435651(int vehicle)
        {
            return Invoker.Call<bool>(0x62CA17B74C435651, vehicle);
        }

        public static int _GET_VEHICLE_ATTACHED_TO_ENTITY(int _object)
        {
            return Invoker.Call<int>(0x375E7FC44F21C8AB, _object);
        }

        public static bool _0x89D630CF5EA96D23(int vehicle, int entity)
        {
            return Invoker.Call<bool>(0x89D630CF5EA96D23, vehicle, entity);
        }

        public static void _0x6A98C2ECF57FA5D4(int vehicle, int entity)
        {
            Invoker.Call<Void>(0x6A98C2ECF57FA5D4, vehicle, entity);
        }

        public static void _0x7C0043FDFF6436BC(int x)
        {
            Invoker.Call<Void>(0x7C0043FDFF6436BC, x);
        }

        public static void _0x8AA9180DE2FEDD45(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x8AA9180DE2FEDD45, vehicle, p1);
        }

        public static void _0x0A6A279F3AA4FD70(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x0A6A279F3AA4FD70, vehicle, p1);
        }

        public static bool _0x634148744F385576(int vehicle)
        {
            return Invoker.Call<bool>(0x634148744F385576, vehicle);
        }

        public static void _0xE6F13851780394DA(int vehicle, float p1)
        {
            Invoker.Call<Void>(0xE6F13851780394DA, vehicle, p1);
        }

        public static void SET_VEHICLE_TYRE_BURST(int vehicle, int index, bool onRim, float p3)
        {
            Invoker.Call<Void>(0xEC6A202EE4960385, vehicle, index, onRim, p3);
        }

        public static void SET_VEHICLE_DOORS_SHUT(int vehicle, bool closeInstantly)
        {
            Invoker.Call<Void>(0x781B3D62BB013EF5, vehicle, closeInstantly);
        }

        public static void SET_VEHICLE_TYRES_CAN_BURST(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xEB9DC3C7D8596C46, vehicle, toggle);
        }

        public static bool GET_VEHICLE_TYRES_CAN_BURST(int vehicle)
        {
            return Invoker.Call<bool>(0x678B9BB8C3F58FEB, vehicle);
        }

        public static int SET_VEHICLE_WHEELS_CAN_BREAK(int vehicle, bool enabled)
        {
            return Invoker.Call<int>(0x29B18B4FD460CA8F, vehicle, enabled);
        }

        public static void SET_VEHICLE_DOOR_OPEN(int vehicle, int doorIndex, bool loose, bool openInstantly)
        {
            Invoker.Call<Void>(0x7C65DAC73C35C862, vehicle, doorIndex, loose, openInstantly);
        }

        public static void REMOVE_VEHICLE_WINDOW(int vehicle, int windowIndex)
        {
            Invoker.Call<Void>(0xA711568EEDB43069, vehicle, windowIndex);
        }

        public static void ROLL_DOWN_WINDOWS(int vehicle)
        {
            Invoker.Call<Void>(0x85796B0549DDE156, vehicle);
        }

        public static int ROLL_DOWN_WINDOW(int vehicle, int windowIndex)
        {
            return Invoker.Call<int>(0x7AD9E6CE657D69E3, vehicle, windowIndex);
        }

        public static int ROLL_UP_WINDOW(int vehicle, int windowIndex)
        {
            return Invoker.Call<int>(0x602E548F46E24D59, vehicle, windowIndex);
        }

        public static int SMASH_VEHICLE_WINDOW(int vehicle, int index)
        {
            return Invoker.Call<int>(0x9E5B5E4D2CCD2259, vehicle, index);
        }

        public static int FIX_VEHICLE_WINDOW(int vehicle, int index)
        {
            return Invoker.Call<int>(0x772282EBEB95E682, vehicle, index);
        }

        public static void _DETACH_VEHICLE_WINDSCREEN(int vehicle)
        {
            Invoker.Call<Void>(0x6D645D59FB5F5AD3, vehicle);
        }

        public static void _EJECT_JB700_ROOF(int vehicle, float x, float y, float z)
        {
            Invoker.Call<Void>(0xE38CB9D7D39FDBCC, vehicle, x, y, z);
        }

        public static void SET_VEHICLE_LIGHTS(int vehicle, int state)
        {
            Invoker.Call<Void>(0x34E710FF01247C5A, vehicle, state);
        }

        public static void _0xC45C27EF50F36ADC(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xC45C27EF50F36ADC, vehicle, p1);
        }

        public static void _SET_VEHICLE_LIGHTS_MODE(int vehicle, int p1)
        {
            Invoker.Call<Void>(0x1FD09E7390A74D54, vehicle, p1);
        }

        public static void SET_VEHICLE_ALARM(int vehicle, bool state)
        {
            Invoker.Call<Void>(0xCDE5E70C1DDB954C, vehicle, state);
        }

        public static int START_VEHICLE_ALARM(int vehicle)
        {
            return Invoker.Call<int>(0xB8FF7AB45305C345, vehicle);
        }

        public static bool IS_VEHICLE_ALARM_ACTIVATED(int vehicle)
        {
            return Invoker.Call<bool>(0x4319E335B71FFF34, vehicle);
        }

        public static void SET_VEHICLE_INTERIORLIGHT(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xBC2042F090AF6AD3, vehicle, toggle);
        }

        public static void SET_VEHICLE_LIGHT_MULTIPLIER(int vehicle, float multiplier)
        {
            Invoker.Call<Void>(0xB385454F8791F57C, vehicle, multiplier);
        }

        public static void ATTACH_VEHICLE_TO_TRAILER(int vehicle, int trailer, float radius)
        {
            Invoker.Call<Void>(0x3C7D42D58F770B54, vehicle, trailer, radius);
        }

        public static void _0x16B5E274BDE402F8(int vehicle, int trailer, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11)
        {
            Invoker.Call<Void>(0x16B5E274BDE402F8, vehicle, trailer, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        public static void _0x374706271354CB18(int vehicle, int p1, float p2)
        {
            Invoker.Call<Void>(0x374706271354CB18, vehicle, p1, p2);
        }

        public static void DETACH_VEHICLE_FROM_TRAILER(int vehicle)
        {
            Invoker.Call<Void>(0x90532EDF0D2BDD86, vehicle);
        }

        public static bool IS_VEHICLE_ATTACHED_TO_TRAILER(int vehicle)
        {
            return Invoker.Call<bool>(0xE7CF3C4F9F489F0C, vehicle);
        }

        public static void _0x2A8F319B392E7B3F(int vehicle, float p1)
        {
            Invoker.Call<Void>(0x2A8F319B392E7B3F, vehicle, p1);
        }

        public static void _0x95CF53B3D687F9FA(int vehicle)
        {
            Invoker.Call<Void>(0x95CF53B3D687F9FA, vehicle);
        }

        public static void SET_VEHICLE_TYRE_FIXED(int vehicle, int tyreIndex)
        {
            Invoker.Call<Void>(0x6E13FC662B882D1D, vehicle, tyreIndex);
        }

        public static void SET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle, string plateText)
        {
            Invoker.Call<Void>(0x95A88F0B409CDA47, vehicle, plateText);
        }

        public static string GET_VEHICLE_NUMBER_PLATE_TEXT(int vehicle)
        {
            return Invoker.Call<string>(0x7CE1CCB9B293020E, vehicle);
        }

        public static int GET_NUMBER_OF_VEHICLE_NUMBER_PLATES()
        {
            return Invoker.Call<int>(0x4C4D6B2644F458CB);
        }

        public static void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int vehicle, int plateIndex)
        {
            Invoker.Call<Void>(0x9088EB5A43FFB0A1, vehicle, plateIndex);
        }

        public static int GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int elegy)
        {
            return Invoker.Call<int>(0xF11BC2DD9A3E7195, elegy);
        }

        public static void SET_RANDOM_TRAINS(bool toggle)
        {
            Invoker.Call<Void>(0x80D9F74197EA47D9, toggle);
        }

        public static int CREATE_MISSION_TRAIN(int variation, float x, float y, float z, bool direction)
        {
            return Invoker.Call<int>(0x63C6CCA8E68AE8C8, variation, x, y, z, direction);
        }

        public static int SWITCH_TRAIN_TRACK(int intersectionId, bool state)
        {
            return Invoker.Call<int>(0xFD813BB7DB977F20, intersectionId, state);
        }

        public static void _0x21973BBF8D17EDFA(int p0, int p1)
        {
            Invoker.Call<Void>(0x21973BBF8D17EDFA, p0, p1);
        }

        public static void DELETE_ALL_TRAINS()
        {
            Invoker.Call<Void>(0x736A718577F39C7D);
        }

        public static int SET_TRAIN_SPEED(int train, float speed)
        {
            return Invoker.Call<int>(0xAA0BC91BE0B796E3, train, speed);
        }

        public static int SET_TRAIN_CRUISE_SPEED(int train, float speed)
        {
            return Invoker.Call<int>(0x16469284DB8C62B5, train, speed);
        }

        public static int SET_RANDOM_BOATS(bool toggle)
        {
            return Invoker.Call<int>(0x84436EC293B1415F, toggle);
        }

        public static int SET_GARBAGE_TRUCKS(bool toggle)
        {
            return Invoker.Call<int>(0x2AFD795EEAC8D30D, toggle);
        }

        public static bool DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK(int vehicle)
        {
            return Invoker.Call<bool>(0x57E4C39DE5EE8470, vehicle);
        }

        public static int GET_VEHICLE_RECORDING_ID(int p0, string p1)
        {
            return Invoker.Call<int>(0x21543C612379DB3C, p0, p1);
        }

        public static void REQUEST_VEHICLE_RECORDING(int i, string name)
        {
            Invoker.Call<Void>(0xAF514CABE74CBF15, i, name);
        }

        public static bool HAS_VEHICLE_RECORDING_BEEN_LOADED(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x300D614A4C785FC4, p0, p1_ptr);
        }

        public static void REMOVE_VEHICLE_RECORDING(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0xF1160ACCF98A3FC8, p0, p1_ptr);
        }

        public static int _0x92523B76657A517D(int p0, float p1)
        {
            return Invoker.Call<int>(0x92523B76657A517D, p0, p1);
        }

        public static Vector3 GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME(int p0, float p1, string p2)
        {
            return Invoker.Call<Vector3>(0xD242728AA6F0FBA2, p0, p1, p2);
        }

        public static Vector3 _0xF0F2103EFAF8CBA7(int p0, float p1)
        {
            return Invoker.Call<Vector3>(0xF0F2103EFAF8CBA7, p0, p1);
        }

        public static int GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME(int p0, float p1, ulong p2_ptr)
        {
            return Invoker.Call<int>(0x2058206FBE79A8AD, p0, p1, p2_ptr);
        }

        public static float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID(int recordingID)
        {
            return Invoker.Call<float>(0x102D125411A7B6E6, recordingID);
        }

        public static int GET_TOTAL_DURATION_OF_VEHICLE_RECORDING(int p0, int p1)
        {
            return Invoker.Call<int>(0x0E48D1C262390950, p0, p1);
        }

        public static float GET_POSITION_IN_RECORDING(int p0)
        {
            return Invoker.Call<float>(0x2DACD605FC681475, p0);
        }

        public static float GET_TIME_POSITION_IN_RECORDING(int p0)
        {
            return Invoker.Call<float>(0x5746F3A7AB7FE544, p0);
        }

        public static void START_PLAYBACK_RECORDED_VEHICLE(int vehicle, int p1, string playback, bool p3)
        {
            Invoker.Call<Void>(0x3F878F92B3A7A071, vehicle, p1, playback, p3);
        }

        public static void START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS(int vehicle, int p1, string playback, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0x7D80FD645D4DA346, vehicle, p1, playback, p3, p4, p5);
        }

        public static void _0x1F2E4E06DEA8992B(int p0, bool p1)
        {
            Invoker.Call<Void>(0x1F2E4E06DEA8992B, p0, p1);
        }

        public static void STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle)
        {
            Invoker.Call<Void>(0x54833611C17ABDEA, vehicle);
        }

        public static void PAUSE_PLAYBACK_RECORDED_VEHICLE(int p0)
        {
            Invoker.Call<Void>(0x632A689BF42301B1, p0);
        }

        public static void UNPAUSE_PLAYBACK_RECORDED_VEHICLE(int p0)
        {
            Invoker.Call<Void>(0x8879EE09268305D5, p0);
        }

        public static bool IS_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle)
        {
            return Invoker.Call<bool>(0x1C8A4C2C19E68EEC, vehicle);
        }

        public static bool IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE(int p0)
        {
            return Invoker.Call<bool>(0xAEA8FD591FAD4106, p0);
        }

        public static int GET_CURRENT_PLAYBACK_FOR_VEHICLE(int vehicle)
        {
            return Invoker.Call<int>(0x42BC05C27A946054, vehicle);
        }

        public static void SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE(int p0)
        {
            Invoker.Call<Void>(0xAB8E2EDA0C0A5883, p0);
        }

        public static void SET_PLAYBACK_SPEED(int vehicle, float speed)
        {
            Invoker.Call<Void>(0x6683AB880E427778, vehicle, speed);
        }

        public static void START_PLAYBACK_RECORDED_VEHICLE_USING_AI(int p0, int p1, ulong p2_ptr, float p3, int p4)
        {
            Invoker.Call<Void>(0x29DE5FA52D00428C, p0, p1, p2_ptr, p3, p4);
        }

        public static void SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE(int p0, float p1)
        {
            Invoker.Call<Void>(0x9438F7AD68771A20, p0, p1);
        }

        public static void SET_PLAYBACK_TO_USE_AI(int vehicle, int flag)
        {
            Invoker.Call<Void>(0xA549C3B37EA28131, vehicle, flag);
        }

        public static void SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER(int p0, int p1, int p2, bool p3)
        {
            Invoker.Call<Void>(0x6E63860BBB190730, p0, p1, p2, p3);
        }

        public static void _0x5845066D8A1EA7F7(int vehicle, float x, float y, float z, int p4)
        {
            Invoker.Call<Void>(0x5845066D8A1EA7F7, vehicle, x, y, z, p4);
        }

        public static void _0x796A877E459B99EA(int p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x796A877E459B99EA, p0, p1, p2, p3);
        }

        public static void _0xFAF2A78061FD9EF4(int p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0xFAF2A78061FD9EF4, p0, p1, p2, p3);
        }

        public static void _0x063AE2B2CC273588(int p0, bool p1)
        {
            Invoker.Call<Void>(0x063AE2B2CC273588, p0, p1);
        }

        public static void EXPLODE_VEHICLE_IN_CUTSCENE(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x786A4EB67B01BF0B, vehicle, p1);
        }

        public static void ADD_VEHICLE_STUCK_CHECK_WITH_WARP(int p0, float p1, int p2, bool p3, bool p4, bool p5, int p6)
        {
            Invoker.Call<Void>(0x2FA9923062DD396C, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void SET_VEHICLE_MODEL_IS_SUPPRESSED(int model, bool suppressed)
        {
            Invoker.Call<Void>(0x0FC2D89AC25A5814, model, suppressed);
        }

        public static int GET_RANDOM_VEHICLE_IN_SPHERE(float x, float y, float z, float radius, int modelHash, int flags)
        {
            return Invoker.Call<int>(0x386F6CE5BAF6091C, x, y, z, radius, modelHash, flags);
        }

        public static int GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)
        {
            return Invoker.Call<int>(0xC5574E0AEB86BA68, p0, p1, p2, p3, p4, p5, p6);
        }

        public static int GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6)
        {
            return Invoker.Call<int>(0xB50807EABE20A8DC, p0, p1, p2, p3, p4, p5, p6);
        }

        public static int GET_CLOSEST_VEHICLE(float x, float y, float z, float radius, int modelHash, int flags)
        {
            return Invoker.Call<int>(0xF73EB622C4F1689B, x, y, z, radius, modelHash, flags);
        }

        public static int GET_TRAIN_CARRIAGE(int train, int trailerNumber)
        {
            return Invoker.Call<int>(0x08AAFD0814722BC3, train, trailerNumber);
        }

        public static void DELETE_MISSION_TRAIN(ulong train_ptr)
        {
            Invoker.Call<Void>(0x5B76B14AE875C795, train_ptr);
        }

        public static void SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED(ulong train_ptr, bool p1)
        {
            Invoker.Call<Void>(0xBBE7648349B49BE8, train_ptr, p1);
        }

        public static void SET_MISSION_TRAIN_COORDS(int train, float x, float y, float z)
        {
            Invoker.Call<Void>(0x591CA673AA6AB736, train, x, y, z);
        }

        public static bool IS_THIS_MODEL_A_BOAT(int model)
        {
            return Invoker.Call<bool>(0x45A9187928F4B9E3, model);
        }

        public static bool _IS_THIS_MODEL_A_JETSKI(int model)
        {
            return Invoker.Call<bool>(0x9537097412CF75FE, model);
        }

        public static bool IS_THIS_MODEL_A_PLANE(int model)
        {
            return Invoker.Call<bool>(0xA0948AB42D7BA0DE, model);
        }

        public static bool IS_THIS_MODEL_A_HELI(int model)
        {
            return Invoker.Call<bool>(0xDCE4334788AF94EA, model);
        }

        public static bool IS_THIS_MODEL_A_CAR(int model)
        {
            return Invoker.Call<bool>(0x7F6DB52EEFC96DF8, model);
        }

        public static bool IS_THIS_MODEL_A_TRAIN(int model)
        {
            return Invoker.Call<bool>(0xAB935175B22E822B, model);
        }

        public static bool IS_THIS_MODEL_A_BIKE(int model)
        {
            return Invoker.Call<bool>(0xB50C0B0CEDC6CE84, model);
        }

        public static bool IS_THIS_MODEL_A_BICYCLE(int model)
        {
            return Invoker.Call<bool>(0xBF94DD42F63BDED2, model);
        }

        public static bool IS_THIS_MODEL_A_QUADBIKE(int model)
        {
            return Invoker.Call<bool>(0x39DAC362EE65FA28, model);
        }

        public static void SET_HELI_BLADES_FULL_SPEED(int vehicle)
        {
            Invoker.Call<Void>(0xA178472EBB8AE60D, vehicle);
        }

        public static void SET_HELI_BLADES_SPEED(int vehicle, float speed)
        {
            Invoker.Call<Void>(0xFD280B4D7F3ABC4D, vehicle, speed);
        }

        public static void _0x99CAD8E7AFDB60FA(int vehicle, float p1, float p2)
        {
            Invoker.Call<Void>(0x99CAD8E7AFDB60FA, vehicle, p1, p2);
        }

        public static void SET_VEHICLE_CAN_BE_TARGETTED(int vehicle, bool state)
        {
            Invoker.Call<Void>(0x3750146A28097A82, vehicle, state);
        }

        public static void _0xDBC631F109350B8C(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xDBC631F109350B8C, vehicle, p1);
        }

        public static void SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(int vehicle, bool state)
        {
            Invoker.Call<Void>(0x4C7028F78FFD3681, vehicle, state);
        }

        public static void _0x1AA8A837D2169D94(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x1AA8A837D2169D94, vehicle, p1);
        }

        public static void _0x2311DD7159F00582(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x2311DD7159F00582, vehicle, p1);
        }

        public static float GET_VEHICLE_DIRT_LEVEL(int vehicle)
        {
            return Invoker.Call<float>(0x8F17BC8BA08DA62B, vehicle);
        }

        public static void SET_VEHICLE_DIRT_LEVEL(int vehicle, float dirtLevel)
        {
            Invoker.Call<Void>(0x79D3B596FE44EE8B, vehicle, dirtLevel);
        }

        public static bool _IS_VEHICLE_DAMAGED(int vehicle)
        {
            return Invoker.Call<bool>(0xBCDC5017D3CE1E9E, vehicle);
        }

        public static int IS_VEHICLE_DOOR_FULLY_OPEN(int v, int rwing)
        {
            return Invoker.Call<int>(0x3E933CFF7B111C22, v, rwing);
        }

        public static void SET_VEHICLE_ENGINE_ON(int vehicle, bool value, bool instantly, bool otherwise)
        {
            Invoker.Call<Void>(0x2497C4717C8B881E, vehicle, value, instantly, otherwise);
        }

        public static void SET_VEHICLE_UNDRIVEABLE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x8ABA6AF54B942B95, vehicle, toggle);
        }

        public static void SET_VEHICLE_PROVIDES_COVER(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x5AFEEDD9BB2899D7, vehicle, toggle);
        }

        public static void SET_VEHICLE_DOOR_CONTROL(int vehicle, int doorIndex, int speed, float angle)
        {
            Invoker.Call<Void>(0xF2BFA0430F0A0FCB, vehicle, doorIndex, speed, angle);
        }

        public static void SET_VEHICLE_DOOR_LATCHED(int vehicle, int doorIndex, bool forceClose, bool _lock, bool p4)
        {
            Invoker.Call<Void>(0xA5A9653A8D2CAF48, vehicle, doorIndex, forceClose, _lock, p4);
        }

        public static float GET_VEHICLE_DOOR_ANGLE_RATIO(int vehicle, int door)
        {
            return Invoker.Call<float>(0xFE3F9C29F7B32BD5, vehicle, door);
        }

        public static int _GET_PED_USING_VEHICLE_DOOR(int vehicle, int doorIndex)
        {
            return Invoker.Call<int>(0x218297BF0CFD853B, vehicle, doorIndex);
        }

        public static void SET_VEHICLE_DOOR_SHUT(int vehicle, int doorIndex, bool closeInstantly)
        {
            Invoker.Call<Void>(0x93D9BD300D7789E5, vehicle, doorIndex, closeInstantly);
        }

        public static void SET_VEHICLE_DOOR_BROKEN(int vehicle, int doorIndex, bool deleteDoor)
        {
            Invoker.Call<Void>(0xD4D4F6A4AB575A33, vehicle, doorIndex, deleteDoor);
        }

        public static void SET_VEHICLE_CAN_BREAK(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x59BF8C3D52C92F66, vehicle, toggle);
        }

        public static bool DOES_VEHICLE_HAVE_ROOF(int vehicle)
        {
            return Invoker.Call<bool>(0x8AC862B0B32C5B80, vehicle);
        }

        public static bool IS_BIG_VEHICLE(int vehicle)
        {
            return Invoker.Call<bool>(0x9F243D3919F442FE, vehicle);
        }

        public static int GET_NUMBER_OF_VEHICLE_COLOURS(int vehicle)
        {
            return Invoker.Call<int>(0x3B963160CD65D41E, vehicle);
        }

        public static void SET_VEHICLE_COLOUR_COMBINATION(int vehicle, int colorCombination)
        {
            Invoker.Call<Void>(0x33E8CD3322E2FE31, vehicle, colorCombination);
        }

        public static int GET_VEHICLE_COLOUR_COMBINATION(int vehicle)
        {
            return Invoker.Call<int>(0x6A842D197F845D56, vehicle);
        }

        public static void SET_VEHICLE_IS_CONSIDERED_BY_PLAYER(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x31B927BBC44156CD, vehicle, toggle);
        }

        public static void _0xBE5C1255A1830FF5(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xBE5C1255A1830FF5, vehicle, toggle);
        }

        public static void _0x9BECD4B9FEF3F8A6(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x9BECD4B9FEF3F8A6, vehicle, p1);
        }

        public static void _0x88BC673CA9E0AE99(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x88BC673CA9E0AE99, vehicle, p1);
        }

        public static void _0xE851E480B814D4BA(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xE851E480B814D4BA, vehicle, p1);
        }

        public static void GET_RANDOM_VEHICLE_MODEL_IN_MEMORY(bool p0, ulong modelHash_ptr, ulong p2_ptr)
        {
            Invoker.Call<Void>(0x055BF0AC0C34F4FD, p0, modelHash_ptr, p2_ptr);
        }

        public static int GET_VEHICLE_DOOR_LOCK_STATUS(int vehicle)
        {
            return Invoker.Call<int>(0x25BC98A59C2EA962, vehicle);
        }

        public static bool IS_VEHICLE_DOOR_DAMAGED(int veh, int doorID)
        {
            return Invoker.Call<bool>(0xB8E181E559464527, veh, doorID);
        }

        public static void _SET_VEHICLE_DOOR_CAN_BREAK(int vehicle, int doorIndex, bool isBreakable)
        {
            Invoker.Call<Void>(0x2FA133A4A9D37ED8, vehicle, doorIndex, isBreakable);
        }

        public static bool _0x27B926779DEB502D(int vehicle, bool frontBumper)
        {
            return Invoker.Call<bool>(0x27B926779DEB502D, vehicle, frontBumper);
        }

        public static bool IS_VEHICLE_BUMPER_BROKEN_OFF(int vehicle, bool front)
        {
            return Invoker.Call<bool>(0x468056A6BB6F3846, vehicle, front);
        }

        public static bool IS_COP_VEHICLE_IN_AREA_3D(float x1, float x2, float y1, float y2, float z1, float z2)
        {
            return Invoker.Call<bool>(0x7EEF65D5F153E26A, x1, x2, y1, y2, z1, z2);
        }

        public static bool IS_VEHICLE_ON_ALL_WHEELS(int vehicle)
        {
            return Invoker.Call<bool>(0xB104CD1BABF302E2, vehicle);
        }

        public static int GET_VEHICLE_LAYOUT_HASH(int vehicle)
        {
            return Invoker.Call<int>(0x28D37D4F71AC5C58, vehicle);
        }

        public static int _0xA01BC64DD4BFBBAC(int vehicle, int p1)
        {
            return Invoker.Call<int>(0xA01BC64DD4BFBBAC, vehicle, p1);
        }

        public static void SET_RENDER_TRAIN_AS_DERAILED(int train, bool toggle)
        {
            Invoker.Call<Void>(0x317B11A312DF5534, train, toggle);
        }

        public static void SET_VEHICLE_EXTRA_COLOURS(int vehicle, int pearlescentColor, int wheelColor)
        {
            Invoker.Call<Void>(0x2036F561ADD12E33, vehicle, pearlescentColor, wheelColor);
        }

        public static void GET_VEHICLE_EXTRA_COLOURS(int vehicle, ulong pearlescentColor_ptr, ulong wheelColor_ptr)
        {
            Invoker.Call<Void>(0x3BC4245933A166F7, vehicle, pearlescentColor_ptr, wheelColor_ptr);
        }

        public static void STOP_ALL_GARAGE_ACTIVITY()
        {
            Invoker.Call<Void>(0x0F87E938BDF29D66);
        }

        public static void SET_VEHICLE_FIXED(int vehicle)
        {
            Invoker.Call<Void>(0x115722B1B9C14C1C, vehicle);
        }

        public static void SET_VEHICLE_DEFORMATION_FIXED(int vehicle)
        {
            Invoker.Call<Void>(0x953DA1E1B12C0491, vehicle);
        }

        public static void _0x206BC5DC9D1AC70A(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x206BC5DC9D1AC70A, vehicle, p1);
        }

        public static void _0x51BB2D88D31A914B(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x51BB2D88D31A914B, vehicle, p1);
        }

        public static void _0x192547247864DFDD(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x192547247864DFDD, vehicle, p1);
        }

        public static void SET_DISABLE_VEHICLE_PETROL_TANK_FIRES(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x465BF26AB9684352, vehicle, toggle);
        }

        public static void SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x37C8252A7C92D017, vehicle, toggle);
        }

        public static void _0x91A0BD635321F145(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x91A0BD635321F145, vehicle, p1);
        }

        public static void _0xC50CE861B55EAB8B(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xC50CE861B55EAB8B, vehicle, p1);
        }

        public static void _0x6EBFB22D646FFC18(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x6EBFB22D646FFC18, vehicle, p1);
        }

        public static void _0x25367DE49D64CF16(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x25367DE49D64CF16, vehicle, p1);
        }

        public static void REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, int unk)
        {
            Invoker.Call<Void>(0x46A1E1A299EC4BBA, x1, y1, z1, x2, y2, z2, unk);
        }

        public static void SET_VEHICLE_STEER_BIAS(int vehicle, float value)
        {
            Invoker.Call<Void>(0x42A8EC77D5150CBE, vehicle, value);
        }

        public static bool IS_VEHICLE_EXTRA_TURNED_ON(int vehicle, int extraId)
        {
            return Invoker.Call<bool>(0xD2E6822DBFD6C8BD, vehicle, extraId);
        }

        public static void SET_VEHICLE_EXTRA(int vehicle, int extraId, bool disable)
        {
            Invoker.Call<Void>(0x7EE3A3C5E4A40CC9, vehicle, extraId, disable);
        }

        public static bool DOES_EXTRA_EXIST(int vehicle, int extraId)
        {
            return Invoker.Call<bool>(0x1262D55792428154, vehicle, extraId);
        }

        public static void SET_CONVERTIBLE_ROOF(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xF39C4F538B5124C2, vehicle, p1);
        }

        public static void LOWER_CONVERTIBLE_ROOF(int vehicle, bool instantlyLower)
        {
            Invoker.Call<Void>(0xDED51F703D0FA83D, vehicle, instantlyLower);
        }

        public static void RAISE_CONVERTIBLE_ROOF(int vehicle, bool instantlyRaise)
        {
            Invoker.Call<Void>(0x8F5FB35D7E88FC70, vehicle, instantlyRaise);
        }

        public static int GET_CONVERTIBLE_ROOF_STATE(int vehicle)
        {
            return Invoker.Call<int>(0xF8C397922FC03F41, vehicle);
        }

        public static bool IS_VEHICLE_A_CONVERTIBLE(int vehicle, bool p1)
        {
            return Invoker.Call<bool>(0x52F357A30698BCCE, vehicle, p1);
        }

        public static bool IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS(int vehicle)
        {
            return Invoker.Call<bool>(0x2959F696AE390A99, vehicle);
        }

        public static void SET_VEHICLE_DAMAGE(int vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, bool p6)
        {
            Invoker.Call<Void>(0xA1DD317EA8FD4F29, vehicle, xOffset, yOffset, zOffset, damage, radius, p6);
        }

        public static float GET_VEHICLE_ENGINE_HEALTH(int vehicle)
        {
            return Invoker.Call<float>(0xC45D23BAF168AAB8, vehicle);
        }

        public static void SET_VEHICLE_ENGINE_HEALTH(int vehicle, float health)
        {
            Invoker.Call<Void>(0x45F6D8EEF34ABEF1, vehicle, health);
        }

        public static float GET_VEHICLE_PETROL_TANK_HEALTH(int vehicle)
        {
            return Invoker.Call<float>(0x7D5DABE888D2D074, vehicle);
        }

        public static void SET_VEHICLE_PETROL_TANK_HEALTH(int vehicle, float health)
        {
            Invoker.Call<Void>(0x70DB57649FA8D0D8, vehicle, health);
        }

        public static bool IS_VEHICLE_STUCK_TIMER_UP(int vehicle, int p1, int p2)
        {
            return Invoker.Call<bool>(0x679BE1DAF71DA874, vehicle, p1, p2);
        }

        public static void RESET_VEHICLE_STUCK_TIMER(int vehicle, int nullAttributes)
        {
            Invoker.Call<Void>(0xD7591B0065AFAA7A, vehicle, nullAttributes);
        }

        public static bool IS_VEHICLE_DRIVEABLE(int vehicle, bool isOnFireCheck)
        {
            return Invoker.Call<bool>(0x4C241E39B23DF959, vehicle, isOnFireCheck);
        }

        public static void SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER(int vehicle, bool owned)
        {
            Invoker.Call<Void>(0x2B5F9D2AF1F1722D, vehicle, owned);
        }

        public static void SET_VEHICLE_NEEDS_TO_BE_HOTWIRED(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xFBA550EA44404EE6, vehicle, toggle);
        }

        public static void _0x9F3F689B814F2599(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x9F3F689B814F2599, vehicle, p1);
        }

        public static void _0x4E74E62E0A97E901(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x4E74E62E0A97E901, vehicle, p1);
        }

        public static void START_VEHICLE_HORN(int vehicle, int duration, int mode, bool forever)
        {
            Invoker.Call<Void>(0x9C8C6504B5B63D2C, vehicle, duration, mode, forever);
        }

        public static void _SET_VEHICLE_SILENT(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x9D44FCCE98450843, vehicle, toggle);
        }

        public static void SET_VEHICLE_HAS_STRONG_AXLES(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x92F0CF722BC4202F, vehicle, toggle);
        }

        public static string GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(int modelHash)
        {
            return Invoker.Call<string>(0xB215AAC32D25D019, modelHash);
        }

        public static Vector3 GET_VEHICLE_DEFORMATION_AT_POS(int vehicle, float offsetX, float offsetY, float offsetZ)
        {
            return Invoker.Call<Vector3>(0x4EC6CFBC7B2E9536, vehicle, offsetX, offsetY, offsetZ);
        }

        public static void SET_VEHICLE_LIVERY(int vehicle, int liveryIndex)
        {
            Invoker.Call<Void>(0x60BF608F1B8CD1B6, vehicle, liveryIndex);
        }

        public static int GET_VEHICLE_LIVERY(int trailers2)
        {
            return Invoker.Call<int>(0x2BB9230590DA5E8A, trailers2);
        }

        public static int GET_VEHICLE_LIVERY_COUNT(int vehicle)
        {
            return Invoker.Call<int>(0x87B63E25A529D526, vehicle);
        }

        public static bool IS_VEHICLE_WINDOW_INTACT(int vehicle, int windowIndex)
        {
            return Invoker.Call<bool>(0x46E571A0E20D01F1, vehicle, windowIndex);
        }

        public static bool ARE_ALL_VEHICLE_WINDOWS_INTACT(int vehicle)
        {
            return Invoker.Call<bool>(0x11D862A3E977A9EF, vehicle);
        }

        public static bool ARE_ANY_VEHICLE_SEATS_FREE(int vehicle)
        {
            return Invoker.Call<bool>(0x2D34FC3BC4ADB780, vehicle);
        }

        public static void RESET_VEHICLE_WHEELS(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x21D2E5662C1F6FED, vehicle, toggle);
        }

        public static bool IS_HELI_PART_BROKEN(int vehicle, bool p1, bool p2, bool p3)
        {
            return Invoker.Call<bool>(0xBC74B4BE25EB6C8A, vehicle, p1, p2, p3);
        }

        public static float _GET_HELI_MAIN_ROTOR_HEALTH(int vehicle)
        {
            return Invoker.Call<float>(0xE4CB7541F413D2C5, vehicle);
        }

        public static float _GET_HELI_TAIL_ROTOR_HEALTH(int vehicle)
        {
            return Invoker.Call<float>(0xAE8CE82A4219AC8C, vehicle);
        }

        public static float _GET_HELI_ENGINE_HEALTH(int vehicle)
        {
            return Invoker.Call<float>(0xAC51915D27E4A5F7, vehicle);
        }

        public static bool WAS_COUNTER_ACTIVATED(int vehicle, int p1)
        {
            return Invoker.Call<bool>(0x3EC8BF18AA453FE9, vehicle, p1);
        }

        public static void SET_VEHICLE_NAME_DEBUG(int vehicle, string name)
        {
            Invoker.Call<Void>(0xBFDF984E2C22B94F, vehicle, name);
        }

        public static void SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x71B0892EC081D60A, vehicle, toggle);
        }

        public static void _0x3441CAD2F2231923(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x3441CAD2F2231923, vehicle, p1);
        }

        public static int _0x2B6747FAA9DB9D6B(int vehicle, bool p1)
        {
            return Invoker.Call<int>(0x2B6747FAA9DB9D6B, vehicle, p1);
        }

        public static void CONTROL_LANDING_GEAR(int vehicle, int state)
        {
            Invoker.Call<Void>(0xCFC8BE9A5E1FE575, vehicle, state);
        }

        public static int GET_LANDING_GEAR_STATE(int vehicle)
        {
            return Invoker.Call<int>(0x9B0F3DCA3DB0F4CD, vehicle);
        }

        public static bool IS_ANY_VEHICLE_NEAR_POINT(float x, float y, float z, float radius)
        {
            return Invoker.Call<bool>(0x61E1DD6125A3EEE6, x, y, z, radius);
        }

        public static void REQUEST_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)
        {
            Invoker.Call<Void>(0xA6E9FDCB2C76785E, vehicle);
        }

        public static void REMOVE_VEHICLE_HIGH_DETAIL_MODEL(int vehicle)
        {
            Invoker.Call<Void>(0x00689CDE5F7C6787, vehicle);
        }

        public static bool IS_VEHICLE_HIGH_DETAIL(int vehicle)
        {
            return Invoker.Call<bool>(0x1F25887F3C104278, vehicle);
        }

        public static void REQUEST_VEHICLE_ASSET(int vehicleHash, int vehicleAsset)
        {
            Invoker.Call<Void>(0x81A15811460FAB3A, vehicleHash, vehicleAsset);
        }

        public static bool HAS_VEHICLE_ASSET_LOADED(int vehicleAsset)
        {
            return Invoker.Call<bool>(0x1BBE0523B8DB9A21, vehicleAsset);
        }

        public static void REMOVE_VEHICLE_ASSET(int vehicleAsset)
        {
            Invoker.Call<Void>(0xACE699C71AB9DEB5, vehicleAsset);
        }

        public static void _SET_TOW_TRUCK_CRANE_HEIGHT(int towTruck, float height)
        {
            Invoker.Call<Void>(0xFE54B92A344583CA, towTruck, height);
        }

        public static void ATTACH_VEHICLE_TO_TOW_TRUCK(int towTruck, int vehicle, bool rear, float hookOffsetX, float hookOffsetY, float hookOffsetZ)
        {
            Invoker.Call<Void>(0x29A16F8D621C4508, towTruck, vehicle, rear, hookOffsetX, hookOffsetY, hookOffsetZ);
        }

        public static void DETACH_VEHICLE_FROM_TOW_TRUCK(int towTruck, int vehicle)
        {
            Invoker.Call<Void>(0xC2DB6B6708350ED8, towTruck, vehicle);
        }

        public static bool DETACH_VEHICLE_FROM_ANY_TOW_TRUCK(int vehicle)
        {
            return Invoker.Call<bool>(0xD0E9CE05A1E68CD8, vehicle);
        }

        public static bool IS_VEHICLE_ATTACHED_TO_TOW_TRUCK(int towTruck, int vehicle)
        {
            return Invoker.Call<bool>(0x146DF9EC4C4B9FD4, towTruck, vehicle);
        }

        public static int GET_ENTITY_ATTACHED_TO_TOW_TRUCK(int towTruck)
        {
            return Invoker.Call<int>(0xEFEA18DCF10F8F75, towTruck);
        }

        public static int SET_VEHICLE_AUTOMATICALLY_ATTACHES(int vehicle, bool p1, int p2)
        {
            return Invoker.Call<int>(0x8BA6F76BC53A1493, vehicle, p1, p2);
        }

        public static void _0xF8EBCCC96ADB9FB7(int p0, float p1, bool p2)
        {
            Invoker.Call<Void>(0xF8EBCCC96ADB9FB7, p0, p1, p2);
        }

        public static void _0x56B94C6D7127DFBA(int p0, float p1, bool p2)
        {
            Invoker.Call<Void>(0x56B94C6D7127DFBA, p0, p1, p2);
        }

        public static void _0x1093408B4B9D1146(int p0, float p1)
        {
            Invoker.Call<Void>(0x1093408B4B9D1146, p0, p1);
        }

        public static void _SET_DESIRED_VERTICAL_FLIGHT_PHASE(int vehicle, float angleRatio)
        {
            Invoker.Call<Void>(0x30D779DE7C4F6DD3, vehicle, angleRatio);
        }

        public static void _SET_VERTICAL_FLIGHT_PHASE(int vehicle, float angle)
        {
            Invoker.Call<Void>(0x9AA47FFF660CB932, vehicle, angle);
        }

        public static bool _0xA4822F1CF23F4810(ulong _outVec_ptr, int p1, ulong _outVec1_ptr, int p3, int p4, int p5, int p6, int p7, int p8)
        {
            return Invoker.Call<bool>(0xA4822F1CF23F4810, _outVec_ptr, p1, _outVec1_ptr, p3, p4, p5, p6, p7, p8);
        }

        public static void SET_VEHICLE_BURNOUT(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xFB8794444A7D60FB, vehicle, toggle);
        }

        public static bool IS_VEHICLE_IN_BURNOUT(int vehicle)
        {
            return Invoker.Call<bool>(0x1297A88E081430EB, vehicle);
        }

        public static void SET_VEHICLE_REDUCE_GRIP(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x222FF6A823D122E2, vehicle, toggle);
        }

        public static void SET_VEHICLE_INDICATOR_LIGHTS(int vehicle, int turnSignal, bool toggle)
        {
            Invoker.Call<Void>(0xB5D45264751B7DF0, vehicle, turnSignal, toggle);
        }

        public static void SET_VEHICLE_BRAKE_LIGHTS(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x92B35082E0B42F66, vehicle, toggle);
        }

        public static void SET_VEHICLE_HANDBRAKE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x684785568EF26A22, vehicle, toggle);
        }

        public static void _0x48ADC8A773564670()
        {
            Invoker.Call<Void>(0x48ADC8A773564670);
        }

        public static bool _0x91D6DD290888CBAB()
        {
            return Invoker.Call<bool>(0x91D6DD290888CBAB);
        }

        public static void _0x51DB102F4A3BA5E0(bool p0)
        {
            Invoker.Call<Void>(0x51DB102F4A3BA5E0, p0);
        }

        public static bool GET_VEHICLE_TRAILER_VEHICLE(int vehicle, ulong trailer_ptr)
        {
            return Invoker.Call<bool>(0x1CDD6BADC297830D, vehicle, trailer_ptr);
        }

        public static void _0xCAC66558B944DA67(string vehicle, bool p1)
        {
            Invoker.Call<Void>(0xCAC66558B944DA67, vehicle, p1);
        }

        public static void SET_VEHICLE_RUDDER_BROKEN(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x09606148B6C71DEF, vehicle, p1);
        }

        public static void _0x1A78AD3D8240536F(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x1A78AD3D8240536F, vehicle, p1);
        }

        public static float _GET_VEHICLE_MAX_SPEED(int vehicle)
        {
            return Invoker.Call<float>(0x53AF99BAA671CA47, vehicle);
        }

        public static float GET_VEHICLE_MAX_BRAKING(int vehicle)
        {
            return Invoker.Call<float>(0xAD7E85FC227197C4, vehicle);
        }

        public static float GET_VEHICLE_MAX_TRACTION(int vehicle)
        {
            return Invoker.Call<float>(0xA132FB5370554DB0, vehicle);
        }

        public static float GET_VEHICLE_ACCELERATION(int vehicle)
        {
            return Invoker.Call<float>(0x5DD35C8D074E57AE, vehicle);
        }

        public static float _GET_VEHICLE_MODEL_MAX_SPEED(int modelHash)
        {
            return Invoker.Call<float>(0xF417C2502FFFED43, modelHash);
        }

        public static float GET_VEHICLE_MODEL_MAX_BRAKING(int modelHash)
        {
            return Invoker.Call<float>(0xDC53FD41B4ED944C, modelHash);
        }

        public static float _GET_VEHICLE_MODEL_HAND_BRAKE(int modelHash)
        {
            return Invoker.Call<float>(0xBFBA3BA79CFF7EBF, modelHash);
        }

        public static float GET_VEHICLE_MODEL_MAX_TRACTION(int modelHash)
        {
            return Invoker.Call<float>(0x539DE94D44FDFD0D, modelHash);
        }

        public static float GET_VEHICLE_MODEL_ACCELERATION(int modelHash)
        {
            return Invoker.Call<float>(0x8C044C5C84505B6A, modelHash);
        }

        public static float _GET_VEHICLE_MODEL_DOWN_FORCE(int modelHash)
        {
            return Invoker.Call<float>(0x53409B5163D5B846, modelHash);
        }

        public static float _GET_VEHICLE_MODEL_MAX_KNOTS(int modelHash)
        {
            return Invoker.Call<float>(0xC6AD107DDC9054CC, modelHash);
        }

        public static float _GET_VEHICLE_MODEL_MOVE_RESISTANCE(int modelHash)
        {
            return Invoker.Call<float>(0x5AA3F878A178C4FC, modelHash);
        }

        public static float _GET_VEHICLE_CLASS_MAX_SPEED(int vehicleClass)
        {
            return Invoker.Call<float>(0x00C09F246ABEDD82, vehicleClass);
        }

        public static float GET_VEHICLE_CLASS_MAX_TRACTION(int vehicleClass)
        {
            return Invoker.Call<float>(0xDBC86D85C5059461, vehicleClass);
        }

        public static float GET_VEHICLE_CLASS_MAX_AGILITY(int vehicleClass)
        {
            return Invoker.Call<float>(0x4F930AD022D6DE3B, vehicleClass);
        }

        public static float GET_VEHICLE_CLASS_MAX_ACCELERATION(int vehicleClass)
        {
            return Invoker.Call<float>(0x2F83E7E45D9EA7AE, vehicleClass);
        }

        public static float GET_VEHICLE_CLASS_MAX_BRAKING(int vehicleClass)
        {
            return Invoker.Call<float>(0x4BF54C16EC8FEC03, vehicleClass);
        }

        public static int _ADD_SPEED_ZONE_FOR_COORD(float x, float y, float z, float radius, float speed, bool p5)
        {
            return Invoker.Call<int>(0x2CE544C68FB812A0, x, y, z, radius, speed, p5);
        }

        public static bool _REMOVE_SPEED_ZONE(int speedzone)
        {
            return Invoker.Call<bool>(0x1033371FC8E842A7, speedzone);
        }

        public static void OPEN_BOMB_BAY_DOORS(int vehicle)
        {
            Invoker.Call<Void>(0x87E7F24270732CB1, vehicle);
        }

        public static void CLOSE_BOMB_BAY_DOORS(int vehicle)
        {
            Invoker.Call<Void>(0x3556041742A0DC74, vehicle);
        }

        public static bool IS_VEHICLE_SEARCHLIGHT_ON(int vehicle)
        {
            return Invoker.Call<bool>(0xC0F97FCE55094987, vehicle);
        }

        public static void SET_VEHICLE_SEARCHLIGHT(int heli, bool toggle, bool canBeUsedByAI)
        {
            Invoker.Call<Void>(0x14E85C5EE7A4D542, heli, toggle, canBeUsedByAI);
        }

        public static bool _0x639431E895B9AA57(int ped, int vehicle, bool p2, bool p3, bool p4)
        {
            return Invoker.Call<bool>(0x639431E895B9AA57, ped, vehicle, p2, p3, p4);
        }

        public static bool CAN_SHUFFLE_SEAT(int vehicle, int p1)
        {
            return Invoker.Call<bool>(0x30785D90C956BF35, vehicle, p1);
        }

        public static int GET_NUM_MOD_KITS(int vehicle)
        {
            return Invoker.Call<int>(0x33F2E3FE70EAAE1D, vehicle);
        }

        public static void SET_VEHICLE_MOD_KIT(int vehicle, int modKit)
        {
            Invoker.Call<Void>(0x1F2AA07F00B3217A, vehicle, modKit);
        }

        public static int GET_VEHICLE_MOD_KIT(int vehicle)
        {
            return Invoker.Call<int>(0x6325D1A044AE510D, vehicle);
        }

        public static int GET_VEHICLE_MOD_KIT_TYPE(int vehicle)
        {
            return Invoker.Call<int>(0xFC058F5121E54C32, vehicle);
        }

        public static int GET_VEHICLE_WHEEL_TYPE(int vehicle)
        {
            return Invoker.Call<int>(0xB3ED1BFB4BE636DC, vehicle);
        }

        public static void SET_VEHICLE_WHEEL_TYPE(int vehicle, int WheelType)
        {
            Invoker.Call<Void>(0x487EB21CC7295BA1, vehicle, WheelType);
        }

        public static int GET_NUM_MOD_COLORS(int p0, bool p1)
        {
            return Invoker.Call<int>(0xA551BE18C11A476D, p0, p1);
        }

        public static void SET_VEHICLE_MOD_COLOR_1(int vehicle, int paintType, int color, int p3)
        {
            Invoker.Call<Void>(0x43FEB945EE7F85B8, vehicle, paintType, color, p3);
        }

        public static void SET_VEHICLE_MOD_COLOR_2(int vehicle, int paintType, int color)
        {
            Invoker.Call<Void>(0x816562BADFDEC83E, vehicle, paintType, color);
        }

        public static void GET_VEHICLE_MOD_COLOR_1(int vehicle, ulong paintType_ptr, ulong color_ptr, ulong pearlescentColor_ptr)
        {
            Invoker.Call<Void>(0xE8D65CA700C9A693, vehicle, paintType_ptr, color_ptr, pearlescentColor_ptr);
        }

        public static void GET_VEHICLE_MOD_COLOR_2(int vehicle, ulong paintType_ptr, ulong color_ptr)
        {
            Invoker.Call<Void>(0x81592BE4E3878728, vehicle, paintType_ptr, color_ptr);
        }

        public static string GET_VEHICLE_MOD_COLOR_1_NAME(int vehicle, bool p1)
        {
            return Invoker.Call<string>(0xB45085B721EFD38C, vehicle, p1);
        }

        public static string GET_VEHICLE_MOD_COLOR_2_NAME(int vehicle)
        {
            return Invoker.Call<string>(0x4967A516ED23A5A1, vehicle);
        }

        public static bool _IS_VEHICLE_MOD_LOAD_DONE(int vehicle)
        {
            return Invoker.Call<bool>(0x9A83F5F9963775EF, vehicle);
        }

        public static void SET_VEHICLE_MOD(int vehicle, int modType, int modIndex, bool customTires)
        {
            Invoker.Call<Void>(0x6AF0636DDEDCB6DD, vehicle, modType, modIndex, customTires);
        }

        public static int GET_VEHICLE_MOD(int vehicle, int modType)
        {
            return Invoker.Call<int>(0x772960298DA26FDB, vehicle, modType);
        }

        public static bool GET_VEHICLE_MOD_VARIATION(int vehicle, int modType)
        {
            return Invoker.Call<bool>(0xB3924ECD70E095DC, vehicle, modType);
        }

        public static int GET_NUM_VEHICLE_MODS(int vehicle, int modType)
        {
            return Invoker.Call<int>(0xE38E9162A2500646, vehicle, modType);
        }

        public static void REMOVE_VEHICLE_MOD(int vehicle, int modType)
        {
            Invoker.Call<Void>(0x92D619E420858204, vehicle, modType);
        }

        public static void TOGGLE_VEHICLE_MOD(int vehicle, int modType, bool toggle)
        {
            Invoker.Call<Void>(0x2A1F4F37F95BAD08, vehicle, modType, toggle);
        }

        public static bool IS_TOGGLE_MOD_ON(int vehicle, int modType)
        {
            return Invoker.Call<bool>(0x84B233A8C8FC8AE7, vehicle, modType);
        }

        public static string GET_MOD_TEXT_LABEL(int vehicle, int modType, int modValue)
        {
            return Invoker.Call<string>(0x8935624F8C5592CC, vehicle, modType, modValue);
        }

        public static string GET_MOD_SLOT_NAME(int vehicle, int modType)
        {
            return Invoker.Call<string>(0x51F0FEB9F6AE98C0, vehicle, modType);
        }

        public static string GET_LIVERY_NAME(int vehicle, int liveryIndex)
        {
            return Invoker.Call<string>(0xB4C7A93837C91A1F, vehicle, liveryIndex);
        }

        public static float GET_VEHICLE_MOD_MODIFIER_VALUE(int vehicle, int modType, int modIndex)
        {
            return Invoker.Call<float>(0x90A38E9838E0A8C1, vehicle, modType, modIndex);
        }

        public static int _GET_VEHICLE_MOD_DATA(int vehicle, int modType, int modIndex)
        {
            return Invoker.Call<int>(0x4593CF82AA179706, vehicle, modType, modIndex);
        }

        public static void PRELOAD_VEHICLE_MOD(int p0, int modType, int p2)
        {
            Invoker.Call<Void>(0x758F49C24925568A, p0, modType, p2);
        }

        public static bool HAS_PRELOAD_MODS_FINISHED(int p0)
        {
            return Invoker.Call<bool>(0x06F43E5175EB6D96, p0);
        }

        public static void RELEASE_PRELOAD_MODS(int vehicle)
        {
            Invoker.Call<Void>(0x445D79F995508307, vehicle);
        }

        public static void SET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, int r, int g, int b)
        {
            Invoker.Call<Void>(0xB5BA80F839791C0F, vehicle, r, g, b);
        }

        public static void GET_VEHICLE_TYRE_SMOKE_COLOR(int vehicle, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0xB635392A4938B3C3, vehicle, r_ptr, g_ptr, b_ptr);
        }

        public static void SET_VEHICLE_WINDOW_TINT(int vehicle, int tint)
        {
            Invoker.Call<Void>(0x57C51E6BAD752696, vehicle, tint);
        }

        public static int GET_VEHICLE_WINDOW_TINT(int vehicle)
        {
            return Invoker.Call<int>(0x0EE21293DAD47C95, vehicle);
        }

        public static int GET_NUM_VEHICLE_WINDOW_TINTS()
        {
            return Invoker.Call<int>(0x9D1224004B3A6707);
        }

        public static void GET_VEHICLE_COLOR(int vehicle, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0xF3CC740D36221548, vehicle, r_ptr, g_ptr, b_ptr);
        }

        public static int _0xEEBFC7A7EFDC35B4(int vehicle)
        {
            return Invoker.Call<int>(0xEEBFC7A7EFDC35B4, vehicle);
        }

        public static int GET_VEHICLE_CAUSE_OF_DESTRUCTION(int vehicle)
        {
            return Invoker.Call<int>(0xE495D1EF4C91FD20, vehicle);
        }

        public static bool GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)
        {
            return Invoker.Call<bool>(0x5EF77C9ADD3B11A3, vehicle);
        }

        public static bool GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED(int vehicle)
        {
            return Invoker.Call<bool>(0xA7ECB73355EB2F20, vehicle);
        }

        public static void _SET_VEHICLE_ENGINE_POWER_MULTIPLIER(int vehicle, float value)
        {
            Invoker.Call<Void>(0x93A3996368C94158, vehicle, value);
        }

        public static void _SET_VEHICLE_ST(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x1CF38D529D7441D9, vehicle, toggle);
        }

        public static void _0x1F9FB66F3A3842D2(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x1F9FB66F3A3842D2, vehicle, p1);
        }

        public static int _0x54B0F614960F4A5F(float p0, float p1, float p2, float p3, float p4, float p5, float p6)
        {
            return Invoker.Call<int>(0x54B0F614960F4A5F, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void _0xE30524E1871F481D(int p0)
        {
            Invoker.Call<Void>(0xE30524E1871F481D, p0);
        }

        public static bool _ANY_PASSENGERS_RAPPELING(int vehicle)
        {
            return Invoker.Call<bool>(0x291E373D483E7EE7, vehicle);
        }

        public static void _SET_VEHICLE_ENGINE_TORQUE_MULTIPLIER(int vehicle, float value)
        {
            Invoker.Call<Void>(0xB59E4BD37AE292DB, vehicle, value);
        }

        public static void _0x0AD9E8F87FF7C16F(int p0, bool p1)
        {
            Invoker.Call<Void>(0x0AD9E8F87FF7C16F, p0, p1);
        }

        public static void SET_VEHICLE_IS_WANTED(int vehicle, bool state)
        {
            Invoker.Call<Void>(0xF7EC25A3EBEEC726, vehicle, state);
        }

        public static void _0xF488C566413B4232(int p0, float p1)
        {
            Invoker.Call<Void>(0xF488C566413B4232, p0, p1);
        }

        public static void _0xC1F981A6F74F0C23(int p0, bool p1)
        {
            Invoker.Call<Void>(0xC1F981A6F74F0C23, p0, p1);
        }

        public static void _0x0F3B4D4E43177236(int p0, bool p1)
        {
            Invoker.Call<Void>(0x0F3B4D4E43177236, p0, p1);
        }

        public static float _0x6636C535F6CC2725(int vehicle)
        {
            return Invoker.Call<float>(0x6636C535F6CC2725, vehicle);
        }

        public static void DISABLE_PLANE_AILERON(int vehicle, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x23428FC53C60919C, vehicle, p1, p2);
        }

        public static bool GET_IS_VEHICLE_ENGINE_RUNNING(int vehicle)
        {
            return Invoker.Call<bool>(0xAE31E7DF9B5B132E, vehicle);
        }

        public static void _0x1D97D1E3A70A649F(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x1D97D1E3A70A649F, vehicle, p1);
        }

        public static void _SET_BIKE_LEAN_ANGLE(int vehicle, float x, float y)
        {
            Invoker.Call<Void>(0x9CFA4896C3A53CBB, vehicle, x, y);
        }

        public static void _0xAB04325045427AAE(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xAB04325045427AAE, vehicle, p1);
        }

        public static void _0xCFD778E7904C255E(int vehicle)
        {
            Invoker.Call<Void>(0xCFD778E7904C255E, vehicle);
        }

        public static void SET_LAST_DRIVEN_VEHICLE(int vehicle)
        {
            Invoker.Call<Void>(0xACFB2463CC22BED2, vehicle);
        }

        public static int GET_LAST_DRIVEN_VEHICLE()
        {
            return Invoker.Call<int>(0xB2D06FAEDE65B577);
        }

        public static void _0xE01903C47C7AC89E()
        {
            Invoker.Call<Void>(0xE01903C47C7AC89E);
        }

        public static void _0x02398B627547189C(int p0, bool p1)
        {
            Invoker.Call<Void>(0x02398B627547189C, p0, p1);
        }

        public static void _SET_PLANE_MIN_HEIGHT_ABOVE_TERRAIN(int plane, int height)
        {
            Invoker.Call<Void>(0xB893215D8D4C015B, plane, height);
        }

        public static void SET_VEHICLE_LOD_MULTIPLIER(int vehicle, float multiplier)
        {
            Invoker.Call<Void>(0x93AE6A61BE015BF1, vehicle, multiplier);
        }

        public static void _0x428BACCDF5E26EAD(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x428BACCDF5E26EAD, vehicle, p1);
        }

        public static int _0x42A4BEB35D372407(int p0)
        {
            return Invoker.Call<int>(0x42A4BEB35D372407, p0);
        }

        public static int _0x2C8CBFE1EA5FC631(int p0)
        {
            return Invoker.Call<int>(0x2C8CBFE1EA5FC631, p0);
        }

        public static void _0x4D9D109F63FEE1D4(int p0, bool p1)
        {
            Invoker.Call<Void>(0x4D9D109F63FEE1D4, p0, p1);
        }

        public static void _0x279D50DE5652D935(int p0, bool p1)
        {
            Invoker.Call<Void>(0x279D50DE5652D935, p0, p1);
        }

        public static void _0xE44A982368A4AF23(int vehicle, int vehicle2)
        {
            Invoker.Call<Void>(0xE44A982368A4AF23, vehicle, vehicle2);
        }

        public static void _0xF25E02CB9C5818F8()
        {
            Invoker.Call<Void>(0xF25E02CB9C5818F8);
        }

        public static void _0xBC3CCA5844452B06(float p0)
        {
            Invoker.Call<Void>(0xBC3CCA5844452B06, p0);
        }

        public static void SET_VEHICLE_SHOOT_AT_TARGET(int driver, int entity, float xTarget, float yTarget, float zTarget)
        {
            Invoker.Call<Void>(0x74CD9A9327A282EA, driver, entity, xTarget, yTarget, zTarget);
        }

        public static bool _GET_VEHICLE_OWNER(int vehicle, ulong entity_ptr)
        {
            return Invoker.Call<bool>(0x8F5EBAB1F260CFCE, vehicle, entity_ptr);
        }

        public static void SET_FORCE_HD_VEHICLE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x97CE68CB032583F0, vehicle, toggle);
        }

        public static void _0x182F266C2D9E2BEB(int vehicle, float p1)
        {
            Invoker.Call<Void>(0x182F266C2D9E2BEB, vehicle, p1);
        }

        public static int GET_VEHICLE_PLATE_TYPE(int vehicle)
        {
            return Invoker.Call<int>(0x9CCC9525BF2408E0, vehicle);
        }

        public static void TRACK_VEHICLE_VISIBILITY(int vehicle)
        {
            Invoker.Call<Void>(0x64473AEFDCF47DCA, vehicle);
        }

        public static bool IS_VEHICLE_VISIBLE(int vehicle)
        {
            return Invoker.Call<bool>(0xAA0A52D24FB98293, vehicle);
        }

        public static void SET_VEHICLE_GRAVITY(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x89F149B6131E57DA, vehicle, toggle);
        }

        public static void _0xE6C0C80B8C867537(bool p0)
        {
            Invoker.Call<Void>(0xE6C0C80B8C867537, p0);
        }

        public static int _0x36492C2F0D134C56(int p0)
        {
            return Invoker.Call<int>(0x36492C2F0D134C56, p0);
        }

        public static void _0x06582AFF74894C75(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x06582AFF74894C75, vehicle, p1);
        }

        public static void _0xDFFCEF48E511DB48(int p0, bool p1)
        {
            Invoker.Call<Void>(0xDFFCEF48E511DB48, p0, p1);
        }

        public static bool _IS_VEHICLE_SHOP_RESPRAY_ALLOWED(int vehicle)
        {
            return Invoker.Call<bool>(0x8D474C8FAEFF6CDE, vehicle);
        }

        public static void SET_VEHICLE_ENGINE_CAN_DEGRADE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x983765856F2564F9, vehicle, toggle);
        }

        public static void _0xF0E4BA16D1DB546C(int vehicle, int p1, int p2)
        {
            Invoker.Call<Void>(0xF0E4BA16D1DB546C, vehicle, p1, p2);
        }

        public static void _0xF87D9F2301F7D206(int p0)
        {
            Invoker.Call<Void>(0xF87D9F2301F7D206, p0);
        }

        public static bool _VEHICLE_HAS_LANDING_GEAR(int vehicle)
        {
            return Invoker.Call<bool>(0x4198AB0022B15F87, vehicle);
        }

        public static bool _ARE_PROPELLERS_UNDAMAGED(int vehicle)
        {
            return Invoker.Call<bool>(0x755D6D5267CBBD7E, vehicle);
        }

        public static void _0x0CDDA42F9E360CA6(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x0CDDA42F9E360CA6, vehicle, p1);
        }

        public static bool IS_VEHICLE_STOLEN(int vehicle)
        {
            return Invoker.Call<bool>(0x4AF9BD80EEBEB453, vehicle);
        }

        public static int SET_VEHICLE_IS_STOLEN(int vehicle, bool isStolen)
        {
            return Invoker.Call<int>(0x67B2C79AA7FF5738, vehicle, isStolen);
        }

        public static void _0xAD2D28A1AFDFF131(int vehicle, float value)
        {
            Invoker.Call<Void>(0xAD2D28A1AFDFF131, vehicle, value);
        }

        public static bool _ARE_VEHICLE_WINGS_INTACT(int vehicle)
        {
            return Invoker.Call<bool>(0x5991A01434CE9677, vehicle);
        }

        public static void _0xB264C4D2F2B0A78B(int vehicle)
        {
            Invoker.Call<Void>(0xB264C4D2F2B0A78B, vehicle);
        }

        public static void DETACH_VEHICLE_FROM_CARGOBOB(int vehicle, int cargobob)
        {
            Invoker.Call<Void>(0x0E21D3DF1051399D, vehicle, cargobob);
        }

        public static bool DETACH_VEHICLE_FROM_ANY_CARGOBOB(int vehicle)
        {
            return Invoker.Call<bool>(0xADF7BE450512C12F, vehicle);
        }

        public static bool IS_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob, int vehicleAttached)
        {
            return Invoker.Call<bool>(0xD40148F22E81A1D9, cargobob, vehicleAttached);
        }

        public static int GET_VEHICLE_ATTACHED_TO_CARGOBOB(int cargobob)
        {
            return Invoker.Call<int>(0x873B82D42AC2B9E5, cargobob);
        }

        public static void ATTACH_VEHICLE_TO_CARGOBOB(int vehicle, int cargobob, int p2, float x, float y, float z)
        {
            Invoker.Call<Void>(0x4127F1D84E347769, vehicle, cargobob, p2, x, y, z);
        }

        public static void _0x571FEB383F629926(int cargobob, bool p1)
        {
            Invoker.Call<Void>(0x571FEB383F629926, cargobob, p1);
        }

        public static Vector3 _GET_CARGOBOB_HOOK_POSITION(int cargobob)
        {
            return Invoker.Call<Vector3>(0xCBDB9B923CACC92D, cargobob);
        }

        public static bool DOES_CARGOBOB_HAVE_PICK_UP_ROPE(int cargobob)
        {
            return Invoker.Call<bool>(0x1821D91AD4B56108, cargobob);
        }

        public static void CREATE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob, int state)
        {
            Invoker.Call<Void>(0x7BEB0C7A235F6F3B, cargobob, state);
        }

        public static void REMOVE_PICK_UP_ROPE_FOR_CARGOBOB(int cargobob)
        {
            Invoker.Call<Void>(0x9768CF648F54C804, cargobob);
        }

        public static void _SET_CARGOBOB_HOOK_POSITION(int cargobob, float xOffset, float yOffset, int state)
        {
            Invoker.Call<Void>(0x877C1EAEAC531023, cargobob, xOffset, yOffset, state);
        }

        public static void _0xCF1182F682F65307(int p0, int p1)
        {
            Invoker.Call<Void>(0xCF1182F682F65307, p0, p1);
        }

        public static bool _DOES_CARGOBOB_HAVE_PICKUP_MAGNET(int cargobob)
        {
            return Invoker.Call<bool>(0x6E08BF5B3722BAC9, cargobob);
        }

        public static void _SET_CARGOBOB_PICKUP_MAGNET_ACTIVE(int cargobob, bool isActive)
        {
            Invoker.Call<Void>(0x9A665550F8DA349B, cargobob, isActive);
        }

        public static void _SET_CARGOBOB_PICKUP_MAGNET_STRENGTH(int cargobob, float strength)
        {
            Invoker.Call<Void>(0xBCBFCD9D1DAC19E2, cargobob, strength);
        }

        public static void _0xA17BAD153B51547E(int cargobob, float p1)
        {
            Invoker.Call<Void>(0xA17BAD153B51547E, cargobob, p1);
        }

        public static void _0x66979ACF5102FD2F(int cargobob, float p1)
        {
            Invoker.Call<Void>(0x66979ACF5102FD2F, cargobob, p1);
        }

        public static void _0x6D8EAC07506291FB(int cargobob, float p1)
        {
            Invoker.Call<Void>(0x6D8EAC07506291FB, cargobob, p1);
        }

        public static void _0xED8286F71A819BAA(int cargobob, float p1)
        {
            Invoker.Call<Void>(0xED8286F71A819BAA, cargobob, p1);
        }

        public static void _0x685D5561680D088B(int vehicle, float p1)
        {
            Invoker.Call<Void>(0x685D5561680D088B, vehicle, p1);
        }

        public static void _0xE301BD63E9E13CF0(int vehicle, int cargobob)
        {
            Invoker.Call<Void>(0xE301BD63E9E13CF0, vehicle, cargobob);
        }

        public static void _0x9BDDC73CC6A115D4(int vehicle, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x9BDDC73CC6A115D4, vehicle, p1, p2);
        }

        public static void _0x56EB5E94318D3FB6(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x56EB5E94318D3FB6, vehicle, p1);
        }

        public static bool DOES_VEHICLE_HAVE_WEAPONS(int vehicle)
        {
            return Invoker.Call<bool>(0x25ECB9F8017D98E0, vehicle);
        }

        public static void _0x2C4A1590ABF43E8B(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x2C4A1590ABF43E8B, vehicle, p1);
        }

        public static void DISABLE_VEHICLE_WEAPON(bool disabled, int weaponHash, int vehicle, int owner)
        {
            Invoker.Call<Void>(0xF4FC6A6F67D8D856, disabled, weaponHash, vehicle, owner);
        }

        public static void _0xE05DD0E9707003A3(int p0, bool p1)
        {
            Invoker.Call<Void>(0xE05DD0E9707003A3, p0, p1);
        }

        public static void _0x21115BCD6E44656A(int p0, bool p1)
        {
            Invoker.Call<Void>(0x21115BCD6E44656A, p0, p1);
        }

        public static int GET_VEHICLE_CLASS(int vehicle)
        {
            return Invoker.Call<int>(0x29439776AAA00A62, vehicle);
        }

        public static int GET_VEHICLE_CLASS_FROM_NAME(int modelHash)
        {
            return Invoker.Call<int>(0xDEDF1C8BD47C2200, modelHash);
        }

        public static int SET_PLAYERS_LAST_VEHICLE(int vehicle)
        {
            return Invoker.Call<int>(0xBCDF8BAF56C87B6A, vehicle);
        }

        public static void SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x300504B23BD3B711, vehicle, toggle);
        }

        public static void _0xE5810AC70602F2F5(int vehicle, float p1)
        {
            Invoker.Call<Void>(0xE5810AC70602F2F5, vehicle, p1);
        }

        public static void _SET_VEHICLE_CREATES_MONEY_PICKUPS_WHEN_EXPLODED(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x068F64F2470F9656, vehicle, toggle);
        }

        public static void _SET_VEHICLE_JET_ENGINE_ON(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xB8FBC8B1330CA9B4, vehicle, toggle);
        }

        public static void _0x10655FAB9915623D(int p0, int p1)
        {
            Invoker.Call<Void>(0x10655FAB9915623D, p0, p1);
        }

        public static void _0x79DF7E806202CE01(int p0, int p1)
        {
            Invoker.Call<Void>(0x79DF7E806202CE01, p0, p1);
        }

        public static void _0x9007A2F21DC108D4(int p0, float p1)
        {
            Invoker.Call<Void>(0x9007A2F21DC108D4, p0, p1);
        }

        public static void _SET_HELICOPTER_ROLL_PITCH_YAW_MULT(int helicopter, float multiplier)
        {
            Invoker.Call<Void>(0x6E0859B530A365CC, helicopter, multiplier);
        }

        public static void SET_VEHICLE_FRICTION_OVERRIDE(int vehicle, float friction)
        {
            Invoker.Call<Void>(0x1837AF7C627009BA, vehicle, friction);
        }

        public static void SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xA37B9A517B133349, vehicle, toggle);
        }

        public static bool _0xF78F94D60248C737(int p0, bool p1)
        {
            return Invoker.Call<bool>(0xF78F94D60248C737, p0, p1);
        }

        public static void SET_VEHICLE_CEILING_HEIGHT(int vehicle, float p1)
        {
            Invoker.Call<Void>(0xA46413066687A328, vehicle, p1);
        }

        public static void _0x5E569EC46EC21CAE(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x5E569EC46EC21CAE, vehicle, toggle);
        }

        public static void _0x6D6AF961B72728AE(int vehicle)
        {
            Invoker.Call<Void>(0x6D6AF961B72728AE, vehicle);
        }

        public static bool DOES_VEHICLE_EXIST_WITH_DECORATOR(string decorator)
        {
            return Invoker.Call<bool>(0x956B409B984D9BF7, decorator);
        }

        public static void SET_VEHICLE_EXCLUSIVE_DRIVER(int vehicle, int ped)
        {
            Invoker.Call<Void>(0x41062318F23ED854, vehicle, ped);
        }

        public static void _SET_VEHICLE_EXCLUSIVE_DRIVER_2(int vehicle, int ped, int p2)
        {
            Invoker.Call<Void>(0xB5C51B5502E85E83, vehicle, ped, p2);
        }

        public static void _0x500873A45724C863(int vehicle, int p1)
        {
            Invoker.Call<Void>(0x500873A45724C863, vehicle, p1);
        }

        public static void _0xB055A34527CB8FD7(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xB055A34527CB8FD7, vehicle, p1);
        }

        public static void _DISPLAY_DISTANT_VEHICLES(bool toggle)
        {
            Invoker.Call<Void>(0xF796359A959DF65D, toggle);
        }

        public static void _SET_VEHICLE_NEON_LIGHTS_COLOUR(int vehicle, int r, int g, int b)
        {
            Invoker.Call<Void>(0x8E0A582209A62695, vehicle, r, g, b);
        }

        public static void _GET_VEHICLE_NEON_LIGHTS_COLOUR(int vehicle, ulong r_ptr, ulong g_ptr, ulong b_ptr)
        {
            Invoker.Call<Void>(0x7619EEE8C886757F, vehicle, r_ptr, g_ptr, b_ptr);
        }

        public static void _SET_VEHICLE_NEON_LIGHT_ENABLED(int vehicle, int index, bool toggle)
        {
            Invoker.Call<Void>(0x2AA720E4287BF269, vehicle, index, toggle);
        }

        public static bool _IS_VEHICLE_NEON_LIGHT_ENABLED(int vehicle, int index)
        {
            return Invoker.Call<bool>(0x8C4B92553E4766A5, vehicle, index);
        }

        public static void _0x35E0654F4BAD7971(bool p0)
        {
            Invoker.Call<Void>(0x35E0654F4BAD7971, p0);
        }

        public static void _0xB088E9A47AE6EDD5(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xB088E9A47AE6EDD5, vehicle, p1);
        }

        public static void _0xDBA3C090E3D74690(int vehicle)
        {
            Invoker.Call<Void>(0xDBA3C090E3D74690, vehicle);
        }

        public static float GET_VEHICLE_BODY_HEALTH(int vehicle)
        {
            return Invoker.Call<float>(0xF271147EB7B40F12, vehicle);
        }

        public static void SET_VEHICLE_BODY_HEALTH(int vehicle, float value)
        {
            Invoker.Call<Void>(0xB77D05AC8C78AADB, vehicle, value);
        }

        public static void _0xDF7E3EEB29642C38(int vehicle, ulong _out1_ptr, ulong _out2_ptr)
        {
            Invoker.Call<Void>(0xDF7E3EEB29642C38, vehicle, _out1_ptr, _out2_ptr);
        }

        public static float _GET_VEHICLE_SUSPENSION_HEIGHT(int vehicle)
        {
            return Invoker.Call<float>(0x53952FD2BAA19F17, vehicle);
        }

        public static void _SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER(float multiplier)
        {
            Invoker.Call<Void>(0x84FD40F56075E816, multiplier);
        }

        public static void _0xA7DCDF4DED40A8F4(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xA7DCDF4DED40A8F4, vehicle, p1);
        }

        public static float _GET_VEHICLE_BODY_HEALTH_2(int vehicle)
        {
            return Invoker.Call<float>(0xB8EF61207C2393A9, vehicle);
        }

        public static bool _0xD4C4642CB7F50B5D(int vehicle)
        {
            return Invoker.Call<bool>(0xD4C4642CB7F50B5D, vehicle);
        }

        public static void _0xC361AA040D6637A8(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xC361AA040D6637A8, vehicle, p1);
        }

        public static void _SET_VEHICLE_HUD_SPECIAL_ABILITY_BAR_ACTIVE(int vehicle, bool active)
        {
            Invoker.Call<Void>(0x99C82F8A139F3E4E, vehicle, active);
        }

        public static void _0xE16142B94664DEFD(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0xE16142B94664DEFD, vehicle, p1);
        }

    }

    public static class OBJECT
    {

        public static int CREATE_OBJECT(int modelHash, float x, float y, float z, bool isNetwork, bool thisScriptCheck, bool dynamic)
        {
            return Invoker.Call<int>(0x509D5878EB39E842, modelHash, x, y, z, isNetwork, thisScriptCheck, dynamic);
        }

        public static int CREATE_OBJECT_NO_OFFSET(int modelHash, float x, float y, float z, bool isNetwork, bool thisScriptCheck, bool dynamic)
        {
            return Invoker.Call<int>(0x9A294B2138ABB884, modelHash, x, y, z, isNetwork, thisScriptCheck, dynamic);
        }

        public static void DELETE_OBJECT(ulong _object_ptr)
        {
            Invoker.Call<Void>(0x539E0AE3E6634B9F, _object_ptr);
        }

        public static bool PLACE_OBJECT_ON_GROUND_PROPERLY(int _object)
        {
            return Invoker.Call<bool>(0x58A850EAEE20FAA3, _object);
        }

        public static bool SLIDE_OBJECT(int _object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, bool collision)
        {
            return Invoker.Call<bool>(0x2FDFF4107B8C1147, _object, toX, toY, toZ, speedX, speedY, speedZ, collision);
        }

        public static int SET_OBJECT_TARGETTABLE(int _object, bool targettable)
        {
            return Invoker.Call<int>(0x8A7391690F5AFD81, _object, targettable);
        }

        public static void _SET_OBJECT_SOMETHING(int _object, bool p1)
        {
            Invoker.Call<Void>(0x77F33F2CCF64B3AA, _object, p1);
        }

        public static int GET_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, int modelHash, bool isMission, bool p6, bool p7)
        {
            return Invoker.Call<int>(0xE143FA2249364369, x, y, z, radius, modelHash, isMission, p6, p7);
        }

        public static bool HAS_OBJECT_BEEN_BROKEN(int _object)
        {
            return Invoker.Call<bool>(0x8ABFB70C49CC43E2, _object);
        }

        public static bool HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN(float p0, float p1, float p2, float p3, int modelHash, int p5)
        {
            return Invoker.Call<bool>(0x761B0E69AC4D007E, p0, p1, p2, p3, modelHash, p5);
        }

        public static bool _0x46494A2475701343(float p0, float p1, float p2, float p3, int modelHash, bool p5)
        {
            return Invoker.Call<bool>(0x46494A2475701343, p0, p1, p2, p3, modelHash, p5);
        }

        public static Vector3 _GET_OBJECT_OFFSET_FROM_COORDS(float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset)
        {
            return Invoker.Call<Vector3>(0x163E252DE035A133, xPos, yPos, zPos, heading, xOffset, yOffset, zOffset);
        }

        public static int _0x163F8B586BC95F2A(int coords, float radius, int modelHash, float x, float y, float z, ulong p6_ptr, int p7)
        {
            return Invoker.Call<int>(0x163F8B586BC95F2A, coords, radius, modelHash, x, y, z, p6_ptr, p7);
        }

        public static void SET_STATE_OF_CLOSEST_DOOR_OF_TYPE(int type, float x, float y, float z, bool _locked, float heading, bool p6)
        {
            Invoker.Call<Void>(0xF82D8F1926A02C3D, type, x, y, z, _locked, heading, p6);
        }

        public static void GET_STATE_OF_CLOSEST_DOOR_OF_TYPE(int type, float x, float y, float z, ulong _locked_ptr, ulong heading_ptr)
        {
            Invoker.Call<Void>(0xEDC1A5B84AEF33FF, type, x, y, z, _locked_ptr, heading_ptr);
        }

        public static void _DOOR_CONTROL(int doorHash, float x, float y, float z, bool _locked, float xRotMult, float yRotMult, float zRotMult)
        {
            Invoker.Call<Void>(0x9B12F9A24FABEDB0, doorHash, x, y, z, _locked, xRotMult, yRotMult, zRotMult);
        }

        public static void ADD_DOOR_TO_SYSTEM(int doorHash, int modelHash, float x, float y, float z, bool p5, bool p6, bool p7)
        {
            Invoker.Call<Void>(0x6F8838D03D1DC226, doorHash, modelHash, x, y, z, p5, p6, p7);
        }

        public static void REMOVE_DOOR_FROM_SYSTEM(int doorHash)
        {
            Invoker.Call<Void>(0x464D8E1427156FE4, doorHash);
        }

        public static void _SET_DOOR_ACCELERATION_LIMIT(int doorHash, int limit, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x6BAB9442830C7F53, doorHash, limit, p2, p3);
        }

        public static int _0x160AA1B32F6139B8(int doorHash)
        {
            return Invoker.Call<int>(0x160AA1B32F6139B8, doorHash);
        }

        public static int _0x4BC2854478F3A749(int doorHash)
        {
            return Invoker.Call<int>(0x4BC2854478F3A749, doorHash);
        }

        public static void _0x03C27E13B42A0E82(int doorHash, float p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x03C27E13B42A0E82, doorHash, p1, p2, p3);
        }

        public static void _0x9BA001CB45CBF627(int doorHash, float heading, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x9BA001CB45CBF627, doorHash, heading, p2, p3);
        }

        public static void _SET_DOOR_AJAR_ANGLE(int doorHash, float ajar, bool p2, bool p3)
        {
            Invoker.Call<Void>(0xB6E6FBA95C7324AC, doorHash, ajar, p2, p3);
        }

        public static float _0x65499865FCA6E5EC(int doorHash)
        {
            return Invoker.Call<float>(0x65499865FCA6E5EC, doorHash);
        }

        public static void _0xC485E07E4F0B7958(int doorHash, bool p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0xC485E07E4F0B7958, doorHash, p1, p2, p3);
        }

        public static void _0xD9B71952F78A2640(int doorHash, bool p1)
        {
            Invoker.Call<Void>(0xD9B71952F78A2640, doorHash, p1);
        }

        public static void _0xA85A21582451E951(int doorHash, bool p1)
        {
            Invoker.Call<Void>(0xA85A21582451E951, doorHash, p1);
        }

        public static bool _DOES_DOOR_EXIST(int doorHash)
        {
            return Invoker.Call<bool>(0xC153C43EA202C8C1, doorHash);
        }

        public static bool IS_DOOR_CLOSED(int door)
        {
            return Invoker.Call<bool>(0xC531EE8A1145A149, door);
        }

        public static void _0xC7F29CA00F46350E(bool p0)
        {
            Invoker.Call<Void>(0xC7F29CA00F46350E, p0);
        }

        public static void _0x701FDA1E82076BA4()
        {
            Invoker.Call<Void>(0x701FDA1E82076BA4);
        }

        public static bool _0xDF97CDD4FC08FD34(int p0)
        {
            return Invoker.Call<bool>(0xDF97CDD4FC08FD34, p0);
        }

        public static bool _0x589F80B325CC82C5(float p0, float p1, float p2, int p3, ulong p4_ptr)
        {
            return Invoker.Call<bool>(0x589F80B325CC82C5, p0, p1, p2, p3, p4_ptr);
        }

        public static bool IS_GARAGE_EMPTY(int garage, bool p1, int p2)
        {
            return Invoker.Call<bool>(0x90E47239EA1980B8, garage, p1, p2);
        }

        public static bool _0x024A60DEB0EA69F0(int p0, int player, float p2, int p3)
        {
            return Invoker.Call<bool>(0x024A60DEB0EA69F0, p0, player, p2, p3);
        }

        public static bool _0x1761DC5D8471CBAA(int p0, int player, int p2)
        {
            return Invoker.Call<bool>(0x1761DC5D8471CBAA, p0, player, p2);
        }

        public static bool _0x85B6C850546FDDE2(int p0, bool p1, bool p2, bool p3, int p4)
        {
            return Invoker.Call<bool>(0x85B6C850546FDDE2, p0, p1, p2, p3, p4);
        }

        public static bool _0x673ED815D6E323B7(int p0, bool p1, bool p2, bool p3, int p4)
        {
            return Invoker.Call<bool>(0x673ED815D6E323B7, p0, p1, p2, p3, p4);
        }

        public static bool _0x372EF6699146A1E4(int p0, int entity, float p2, int p3)
        {
            return Invoker.Call<bool>(0x372EF6699146A1E4, p0, entity, p2, p3);
        }

        public static bool _0xF0EED5A6BC7B237A(int p0, int entity, int p2)
        {
            return Invoker.Call<bool>(0xF0EED5A6BC7B237A, p0, entity, p2);
        }

        public static void _0x190428512B240692(int p0, bool p1, bool p2, bool p3, bool p4)
        {
            Invoker.Call<Void>(0x190428512B240692, p0, p1, p2, p3, p4);
        }

        public static void _0xF2E1A7133DD356A6(int hash, bool toggle)
        {
            Invoker.Call<Void>(0xF2E1A7133DD356A6, hash, toggle);
        }

        public static void _0x66A49D021870FE88()
        {
            Invoker.Call<Void>(0x66A49D021870FE88);
        }

        public static bool DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS(float x, float y, float z, float radius, int hash, bool p5)
        {
            return Invoker.Call<bool>(0xBFA48E2FF417213F, x, y, z, radius, hash, p5);
        }

        public static bool IS_POINT_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, bool p10, bool p11)
        {
            return Invoker.Call<bool>(0x2A70BAE8883E4C81, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        public static void _0x4D89D607CB3DD1D2(int _object, bool toggle)
        {
            Invoker.Call<Void>(0x4D89D607CB3DD1D2, _object, toggle);
        }

        public static void SET_OBJECT_PHYSICS_PARAMS(int _object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy)
        {
            Invoker.Call<Void>(0xF6DF6E90DE7DF90F, _object, weight, p2, p3, p4, p5, gravity, p7, p8, p9, p10, buoyancy);
        }

        public static float GET_OBJECT_FRAGMENT_DAMAGE_HEALTH(int p0, bool p1)
        {
            return Invoker.Call<float>(0xB6FBFD079B8D0596, p0, p1);
        }

        public static void SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN(int _object, bool toggle)
        {
            Invoker.Call<Void>(0x406137F8EF90EAF5, _object, toggle);
        }

        public static bool IS_ANY_OBJECT_NEAR_POINT(float x, float y, float z, float range, bool p4)
        {
            return Invoker.Call<bool>(0x397DC58FF00298D1, x, y, z, range, p4);
        }

        public static bool IS_OBJECT_NEAR_POINT(int _objectHash, float x, float y, float z, float range)
        {
            return Invoker.Call<bool>(0x8C90FE4B381BA60A, _objectHash, x, y, z, range);
        }

        public static void _0x4A39DB43E47CF3AA(int p0)
        {
            Invoker.Call<Void>(0x4A39DB43E47CF3AA, p0);
        }

        public static void _0xE7E4C198B0185900(int p0, int p1, bool p2)
        {
            Invoker.Call<Void>(0xE7E4C198B0185900, p0, p1, p2);
        }

        public static void _0xF9C1681347C8BD15(int _object)
        {
            Invoker.Call<Void>(0xF9C1681347C8BD15, _object);
        }

        public static void TRACK_OBJECT_VISIBILITY(int p0)
        {
            Invoker.Call<Void>(0xB252BC036B525623, p0);
        }

        public static bool IS_OBJECT_VISIBLE(int _object)
        {
            return Invoker.Call<bool>(0x8B32ACE6326A7546, _object);
        }

        public static void _0xC6033D32241F6FB5(int p0, bool p1)
        {
            Invoker.Call<Void>(0xC6033D32241F6FB5, p0, p1);
        }

        public static void _0xEB6F1A9B5510A5D2(int p0, bool p1)
        {
            Invoker.Call<Void>(0xEB6F1A9B5510A5D2, p0, p1);
        }

        public static void _0xBCE595371A5FBAAF(int p0, bool p1)
        {
            Invoker.Call<Void>(0xBCE595371A5FBAAF, p0, p1);
        }

        public static int _GET_DES_OBJECT(float x, float y, float z, float rotation, string name)
        {
            return Invoker.Call<int>(0xB48FCED898292E52, x, y, z, rotation, name);
        }

        public static void _SET_DES_OBJECT_STATE(int handle, int state)
        {
            Invoker.Call<Void>(0x5C29F698D404C5E1, handle, state);
        }

        public static int _GET_DES_OBJECT_STATE(int handle)
        {
            return Invoker.Call<int>(0x899BA936634A322E, handle);
        }

        public static bool _DOES_DES_OBJECT_EXIST(int handle)
        {
            return Invoker.Call<bool>(0x52AF537A0C5B8AAD, handle);
        }

        public static float _0x260EE4FDBDF4DB01(int p0)
        {
            return Invoker.Call<float>(0x260EE4FDBDF4DB01, p0);
        }

        public static int CREATE_PICKUP(int pickupHash, float posX, float posY, float posZ, int p4, int value, bool p6, int modelHash)
        {
            return Invoker.Call<int>(0xFBA08C503DD5FA58, pickupHash, posX, posY, posZ, p4, value, p6, modelHash);
        }

        public static int CREATE_PICKUP_ROTATE(int pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flag, int amount, int p9, bool p10, int modelHash)
        {
            return Invoker.Call<int>(0x891804727E0A98B7, pickupHash, posX, posY, posZ, rotX, rotY, rotZ, flag, amount, p9, p10, modelHash);
        }

        public static int CREATE_AMBIENT_PICKUP(int pickupHash, float posX, float posY, float posZ, int p4, int value, int modelHash, bool returnHandle, bool p8)
        {
            return Invoker.Call<int>(0x673966A0C0FD7171, pickupHash, posX, posY, posZ, p4, value, modelHash, returnHandle, p8);
        }

        public static int CREATE_PORTABLE_PICKUP(int pickupHash, float x, float y, float z, bool placeOnGround, int modelHash)
        {
            return Invoker.Call<int>(0x2EAF1FDB2FB55698, pickupHash, x, y, z, placeOnGround, modelHash);
        }

        public static int _CREATE_PORTABLE_PICKUP_2(int pickupHash, float x, float y, float z, bool placeOnGround, int modelHash)
        {
            return Invoker.Call<int>(0x125494B98A21AAF7, pickupHash, x, y, z, placeOnGround, modelHash);
        }

        public static void ATTACH_PORTABLE_PICKUP_TO_PED(int ped, int p1)
        {
            Invoker.Call<Void>(0x8DC39368BDD57755, ped, p1);
        }

        public static void DETACH_PORTABLE_PICKUP_FROM_PED(int ped)
        {
            Invoker.Call<Void>(0xCF463D1E9A0AECB1, ped);
        }

        public static void _0x0BF3B3BD47D79C08(int hash, int p1)
        {
            Invoker.Call<Void>(0x0BF3B3BD47D79C08, hash, p1);
        }

        public static void _0x78857FC65CADB909(bool p0)
        {
            Invoker.Call<Void>(0x78857FC65CADB909, p0);
        }

        public static Vector3 GET_SAFE_PICKUP_COORDS(float x, float y, float z, int p3, int p4)
        {
            return Invoker.Call<Vector3>(0x6E16BC2503FF1FF0, x, y, z, p3, p4);
        }

        public static Vector3 GET_PICKUP_COORDS(int pickup)
        {
            return Invoker.Call<Vector3>(0x225B8B35C88029B3, pickup);
        }

        public static void REMOVE_ALL_PICKUPS_OF_TYPE(int pickupHash)
        {
            Invoker.Call<Void>(0x27F9D613092159CF, pickupHash);
        }

        public static bool HAS_PICKUP_BEEN_COLLECTED(int pickup)
        {
            return Invoker.Call<bool>(0x80EC48E6679313F9, pickup);
        }

        public static void REMOVE_PICKUP(int pickup)
        {
            Invoker.Call<Void>(0x3288D8ACAECD2AB2, pickup);
        }

        public static void CREATE_MONEY_PICKUPS(float x, float y, float z, int value, int amount, int model)
        {
            Invoker.Call<Void>(0x0589B5E791CE9B2B, x, y, z, value, amount, model);
        }

        public static bool DOES_PICKUP_EXIST(int pickup)
        {
            return Invoker.Call<bool>(0xAFC1CA75AD4074D1, pickup);
        }

        public static bool DOES_PICKUP_OBJECT_EXIST(int pickupObject)
        {
            return Invoker.Call<bool>(0xD9EFB6DBF7DAAEA3, pickupObject);
        }

        public static int GET_PICKUP_OBJECT(int pickup)
        {
            return Invoker.Call<int>(0x5099BC55630B25AE, pickup);
        }

        public static bool _0x0378C08504160D0D(int p0)
        {
            return Invoker.Call<bool>(0x0378C08504160D0D, p0);
        }

        public static bool _IS_PICKUP_WITHIN_RADIUS(int pickupHash, float x, float y, float z, float radius)
        {
            return Invoker.Call<bool>(0xF9C36251F6E48E33, pickupHash, x, y, z, radius);
        }

        public static void SET_PICKUP_REGENERATION_TIME(int pickup, int duration)
        {
            Invoker.Call<Void>(0x78015C9B4B3ECC9D, pickup, duration);
        }

        public static void _0x616093EC6B139DD9(int player, int pickupHash, bool p2)
        {
            Invoker.Call<Void>(0x616093EC6B139DD9, player, pickupHash, p2);
        }

        public static void _0x88EAEC617CD26926(int p0, bool p1)
        {
            Invoker.Call<Void>(0x88EAEC617CD26926, p0, p1);
        }

        public static void SET_TEAM_PICKUP_OBJECT(int _object, int p1, bool p2)
        {
            Invoker.Call<Void>(0x53E0DF1A2A3CF0CA, _object, p1, p2);
        }

        public static void _0x92AEFB5F6E294023(int _object, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x92AEFB5F6E294023, _object, p1, p2);
        }

        public static void _0xA08FE5E49BDC39DD(int p0, float p1, bool p2)
        {
            Invoker.Call<Void>(0xA08FE5E49BDC39DD, p0, p1, p2);
        }

        public static int _0xDB41D07A45A6D4B7(int p0)
        {
            return Invoker.Call<int>(0xDB41D07A45A6D4B7, p0);
        }

        public static void _0x318516E02DE3ECE2(float p0)
        {
            Invoker.Call<Void>(0x318516E02DE3ECE2, p0);
        }

        public static void _0x31F924B53EADDF65(bool p0)
        {
            Invoker.Call<Void>(0x31F924B53EADDF65, p0);
        }

        public static void _0xF92099527DB8E2A7(int p0, int p1)
        {
            Invoker.Call<Void>(0xF92099527DB8E2A7, p0, p1);
        }

        public static void _0xA2C1F5E92AFE49ED()
        {
            Invoker.Call<Void>(0xA2C1F5E92AFE49ED);
        }

        public static void _0x762DB2D380B48D04(int p0)
        {
            Invoker.Call<Void>(0x762DB2D380B48D04, p0);
        }

        public static void _HIGHLIGHT_PLACEMENT_COORDS(float x, float y, float z, int colorIndex)
        {
            Invoker.Call<Void>(0x3430676B11CDF21D, x, y, z, colorIndex);
        }

        public static void _0xB2D0BDE54F0E8E5A(int _object, bool toggle)
        {
            Invoker.Call<Void>(0xB2D0BDE54F0E8E5A, _object, toggle);
        }

        public static int _GET_WEAPON_HASH_FROM_PICKUP(int pickupHash)
        {
            return Invoker.Call<int>(0x08F96CA6C551AD51, pickupHash);
        }

        public static bool _0x11D1E53A726891FE(int _object)
        {
            return Invoker.Call<bool>(0x11D1E53A726891FE, _object);
        }

        public static void _SET_OBJECT_TEXTURE_VARIANT(int _object, int paintIndex)
        {
            Invoker.Call<Void>(0x971DA0055324D033, _object, paintIndex);
        }

        public static int _GET_PICKUP_HASH(int pickupHash)
        {
            return Invoker.Call<int>(0x5EAAD83F8CFB4575, pickupHash);
        }

        public static void SET_FORCE_OBJECT_THIS_FRAME(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xF538081986E49E9D, p0, p1, p2, p3);
        }

        public static void _MARK_OBJECT_FOR_DELETION(int _object)
        {
            Invoker.Call<Void>(0xADBE4809F19F927A, _object);
        }

    }

    public static class AI
    {

        public static void TASK_PAUSE(int ped, int ms)
        {
            Invoker.Call<Void>(0xE73A266DB0CA9042, ped, ms);
        }

        public static void TASK_STAND_STILL(int ped, int time)
        {
            Invoker.Call<Void>(0x919BE13EED931959, ped, time);
        }

        public static void TASK_JUMP(int ped, bool unused)
        {
            Invoker.Call<Void>(0x0AE4086104E067B1, ped, unused);
        }

        public static void TASK_COWER(int ped, int duration)
        {
            Invoker.Call<Void>(0x3EB1FE9E8E908E15, ped, duration);
        }

        public static void TASK_HANDS_UP(int ped, int duration, int facingPed, int p3, bool p4)
        {
            Invoker.Call<Void>(0xF2EAB31979A7F910, ped, duration, facingPed, p3, p4);
        }

        public static void UPDATE_TASK_HANDS_UP_DURATION(int ped, int duration)
        {
            Invoker.Call<Void>(0xA98FCAFD7893C834, ped, duration);
        }

        public static void TASK_OPEN_VEHICLE_DOOR(int ped, int vehicle, int timeOut, int doorIndex, float speed)
        {
            Invoker.Call<Void>(0x965791A9A488A062, ped, vehicle, timeOut, doorIndex, speed);
        }

        public static void TASK_ENTER_VEHICLE(int ped, int vehicle, int time_out, int seat, float speed, int flag, int p6)
        {
            Invoker.Call<Void>(0xC20E50AA46D09CA8, ped, vehicle, time_out, seat, speed, flag, p6);
        }

        public static void TASK_LEAVE_VEHICLE(int ped, int vehicle, int flags)
        {
            Invoker.Call<Void>(0xD3DBCE61A490BE02, ped, vehicle, flags);
        }

        public static void _TASK_GET_OFF_BOAT(int ped, int boat)
        {
            Invoker.Call<Void>(0x9C00E77AF14B2DFF, ped, boat);
        }

        public static void TASK_SKY_DIVE(int ped)
        {
            Invoker.Call<Void>(0x601736CFE536B0A0, ped);
        }

        public static void TASK_PARACHUTE(int ped, bool p1)
        {
            Invoker.Call<Void>(0xD2F1C53C97EE81AB, ped, p1);
        }

        public static void TASK_PARACHUTE_TO_TARGET(int ped, float x, float y, float z)
        {
            Invoker.Call<Void>(0xB33E291AFA6BD03A, ped, x, y, z);
        }

        public static void SET_PARACHUTE_TASK_TARGET(int ped, float x, float y, float z)
        {
            Invoker.Call<Void>(0xC313379AF0FCEDA7, ped, x, y, z);
        }

        public static void SET_PARACHUTE_TASK_THRUST(int ped, float thrust)
        {
            Invoker.Call<Void>(0x0729BAC1B8C64317, ped, thrust);
        }

        public static void TASK_RAPPEL_FROM_HELI(int ped, int unused)
        {
            Invoker.Call<Void>(0x09693B0312F91649, ped, unused);
        }

        public static void TASK_VEHICLE_DRIVE_TO_COORD(int ped, int vehicle, float x, float y, float z, float speed, int p6, int vehicleModel, int drivingMode, float stopRange, float p10)
        {
            Invoker.Call<Void>(0xE2A2AA2F659D77A7, ped, vehicle, x, y, z, speed, p6, vehicleModel, drivingMode, stopRange, p10);
        }

        public static void TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE(int ped, int vehicle, float x, float y, float z, float speed, int driveMode, float stopRange)
        {
            Invoker.Call<Void>(0x158BB33F920D360C, ped, vehicle, x, y, z, speed, driveMode, stopRange);
        }

        public static void TASK_VEHICLE_DRIVE_WANDER(int ped, int vehicle, float speed, int drivingStyle)
        {
            Invoker.Call<Void>(0x480142959D337D00, ped, vehicle, speed, drivingStyle);
        }

        public static void TASK_FOLLOW_TO_OFFSET_OF_ENTITY(int ped, int entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int time_out, float stoppingRange, bool persistFollowing)
        {
            Invoker.Call<Void>(0x304AE42E357B8C7E, ped, entity, offsetX, offsetY, offsetZ, movementSpeed, time_out, stoppingRange, persistFollowing);
        }

        public static void TASK_GO_STRAIGHT_TO_COORD(int ped, float x, float y, float z, float speed, int time_out, float targetHeading, float distanceToSlide)
        {
            Invoker.Call<Void>(0xD76B57B44F1E6F8B, ped, x, y, z, speed, time_out, targetHeading, distanceToSlide);
        }

        public static void TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY(int entity1, int entity2, float p2, float p3, float p4, float p5, int p6)
        {
            Invoker.Call<Void>(0x61E360B7E040D12E, entity1, entity2, p2, p3, p4, p5, p6);
        }

        public static void TASK_ACHIEVE_HEADING(int ped, float heading, int time_out)
        {
            Invoker.Call<Void>(0x93B93A37987F1F3D, ped, heading, time_out);
        }

        public static void TASK_FLUSH_ROUTE()
        {
            Invoker.Call<Void>(0x841142A1376E9006);
        }

        public static void TASK_EXTEND_ROUTE(float x, float y, float z)
        {
            Invoker.Call<Void>(0x1E7889778264843A, x, y, z);
        }

        public static void TASK_FOLLOW_POINT_ROUTE(int ped, float speed, int unknown)
        {
            Invoker.Call<Void>(0x595583281858626E, ped, speed, unknown);
        }

        public static void TASK_GO_TO_ENTITY(int entity, int target, int duration, float distance, float speed, float p5, int p6)
        {
            Invoker.Call<Void>(0x6A071245EB0D1882, entity, target, duration, distance, speed, p5, p6);
        }

        public static void TASK_SMART_FLEE_COORD(int ped, float x, float y, float z, float distance, int time, bool p6, bool p7)
        {
            Invoker.Call<Void>(0x94587F17E9C365D5, ped, x, y, z, distance, time, p6, p7);
        }

        public static void TASK_SMART_FLEE_PED(int ped, int fleeTarget, float distance, int fleeTime, bool p4, bool p5)
        {
            Invoker.Call<Void>(0x22B0D0E37CCB840D, ped, fleeTarget, distance, fleeTime, p4, p5);
        }

        public static void TASK_REACT_AND_FLEE_PED(int ped, int fleeTarget)
        {
            Invoker.Call<Void>(0x72C896464915D1B1, ped, fleeTarget);
        }

        public static void TASK_SHOCKING_EVENT_REACT(int ped, int _eventHandle)
        {
            Invoker.Call<Void>(0x452419CBD838065B, ped, _eventHandle);
        }

        public static void TASK_WANDER_IN_AREA(int ped, float x, float y, float z, float radius, float minimalLength, float timeBetweenWalks)
        {
            Invoker.Call<Void>(0xE054346CA3A0F315, ped, x, y, z, radius, minimalLength, timeBetweenWalks);
        }

        public static void TASK_WANDER_STANDARD(int ped, float p1, int p2)
        {
            Invoker.Call<Void>(0xBB9CE077274F6A1B, ped, p1, p2);
        }

        public static void TASK_VEHICLE_PARK(int ped, int vehicle, float x, float y, float z, float heading, int mode, float radius, bool keepEngineOn)
        {
            Invoker.Call<Void>(0x0F3E34E968EA374E, ped, vehicle, x, y, z, heading, mode, radius, keepEngineOn);
        }

        public static void TASK_STEALTH_KILL(int killer, int target, int actionType, float p3, int p4)
        {
            Invoker.Call<Void>(0xAA5DC05579D60BD9, killer, target, actionType, p3, p4);
        }

        public static void TASK_PLANT_BOMB(int ped, float x, float y, float z, float heading)
        {
            Invoker.Call<Void>(0x965FEC691D55E9BF, ped, x, y, z, heading);
        }

        public static void TASK_FOLLOW_NAV_MESH_TO_COORD(int ped, float x, float y, float z, float speed, int time_out, float stoppingRange, bool persistFollowing, float unk)
        {
            Invoker.Call<Void>(0x15D3A79D4E44B913, ped, x, y, z, speed, time_out, stoppingRange, persistFollowing, unk);
        }

        public static void TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED(int ped, float x, float y, float z, float speed, int time_out, float unkFloat, int unkInt, float unkX, float unkY, float unkZ, float unk_40000f)
        {
            Invoker.Call<Void>(0x17F58B88D085DBAC, ped, x, y, z, speed, time_out, unkFloat, unkInt, unkX, unkY, unkZ, unk_40000f);
        }

        public static int SET_PED_PATH_CAN_USE_CLIMBOVERS(int ped, bool Toggle)
        {
            return Invoker.Call<int>(0x8E06A6FE76C9EFF4, ped, Toggle);
        }

        public static int SET_PED_PATH_CAN_USE_LADDERS(int ped, bool Toggle)
        {
            return Invoker.Call<int>(0x77A5B103C87F476E, ped, Toggle);
        }

        public static void SET_PED_PATH_CAN_DROP_FROM_HEIGHT(int ped, bool Toggle)
        {
            Invoker.Call<Void>(0xE361C5C71C431A4F, ped, Toggle);
        }

        public static void _0x88E32DB8C1A4AA4B(int ped, float p1)
        {
            Invoker.Call<Void>(0x88E32DB8C1A4AA4B, ped, p1);
        }

        public static void SET_PED_PATHS_WIDTH_PLANT(int ped, bool mayEnterWater)
        {
            Invoker.Call<Void>(0xF35425A4204367EC, ped, mayEnterWater);
        }

        public static void SET_PED_PATH_PREFER_TO_AVOID_WATER(int ped, bool avoidWater)
        {
            Invoker.Call<Void>(0x38FE1EC73743793C, ped, avoidWater);
        }

        public static void SET_PED_PATH_AVOID_FIRE(int ped, bool avoidFire)
        {
            Invoker.Call<Void>(0x4455517B28441E60, ped, avoidFire);
        }

        public static void SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT(float height)
        {
            Invoker.Call<Void>(0x6C6B148586F934F7, height);
        }

        public static int GET_NAVMESH_ROUTE_DISTANCE_REMAINING(int ped, ulong distRemaining_ptr, ulong isPathReady_ptr)
        {
            return Invoker.Call<int>(0xC6F5C0BCDC74D62D, ped, distRemaining_ptr, isPathReady_ptr);
        }

        public static int GET_NAVMESH_ROUTE_RESULT(int ped)
        {
            return Invoker.Call<int>(0x632E831F382A0FA8, ped);
        }

        public static bool _0x3E38E28A1D80DDF6(int ped)
        {
            return Invoker.Call<bool>(0x3E38E28A1D80DDF6, ped);
        }

        public static void TASK_GO_TO_COORD_ANY_MEANS(int ped, float x, float y, float z, float speed, int p5, bool p6, int walkingStyle, float p8)
        {
            Invoker.Call<Void>(0x5BC448CB78FA3E88, ped, x, y, z, speed, p5, p6, walkingStyle, p8);
        }

        public static void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS(int ped, float x, float y, float z, float speed, int p5, bool p6, int walkingStyle, float p8, int p9, int p10, int p11)
        {
            Invoker.Call<Void>(0x1DD45F9ECFDB1BC9, ped, x, y, z, speed, p5, p6, walkingStyle, p8, p9, p10, p11);
        }

        public static void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED(int ped, float x, float y, float z, float speed, int p5, bool p6, int walkingStyle, float p8, int p9, int p10, int p11, int p12)
        {
            Invoker.Call<Void>(0xB8ECD61F531A7B02, ped, x, y, z, speed, p5, p6, walkingStyle, p8, p9, p10, p11, p12);
        }

        public static void TASK_PLAY_ANIM(int ped, string animDictionary, string animationName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, bool _lockX, bool _lockY, bool _lockZ)
        {
            Invoker.Call<Void>(0xEA47FE3719165B94, ped, animDictionary, animationName, speed, speedMultiplier, duration, flag, playbackRate, _lockX, _lockY, _lockZ);
        }

        public static void TASK_PLAY_ANIM_ADVANCED(int ped, string animDict, string animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float speed, float speedMultiplier, int duration, int flag, float animTime, int p14, int p15)
        {
            Invoker.Call<Void>(0x83CDB10EA29B370B, ped, animDict, animName, posX, posY, posZ, rotX, rotY, rotZ, speed, speedMultiplier, duration, flag, animTime, p14, p15);
        }

        public static void STOP_ANIM_TASK(int ped, string animDictionary, string animationName, float p3)
        {
            Invoker.Call<Void>(0x97FF36A1D40EA00A, ped, animDictionary, animationName, p3);
        }

        public static void TASK_SCRIPTED_ANIMATION(int ped, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr, float p4, float p5)
        {
            Invoker.Call<Void>(0x126EF75F1E17ABE5, ped, p1_ptr, p2_ptr, p3_ptr, p4, p5);
        }

        public static void PLAY_ENTITY_SCRIPTED_ANIM(int p0, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr, float p4, float p5)
        {
            Invoker.Call<Void>(0x77A1EEC547E7FCF1, p0, p1_ptr, p2_ptr, p3_ptr, p4, p5);
        }

        public static void STOP_ANIM_PLAYBACK(int ped, int p1, bool p2)
        {
            Invoker.Call<Void>(0xEE08C992D238C5D1, ped, p1, p2);
        }

        public static void SET_ANIM_WEIGHT(int p0, float p1, int p2, int p3, bool p4)
        {
            Invoker.Call<Void>(0x207F1A47C0342F48, p0, p1, p2, p3, p4);
        }

        public static void SET_ANIM_RATE(int p0, float p1, int p2, bool p3)
        {
            Invoker.Call<Void>(0x032D49C5E359C847, p0, p1, p2, p3);
        }

        public static void SET_ANIM_LOOPED(int p0, bool p1, int p2, bool p3)
        {
            Invoker.Call<Void>(0x70033C3CC29A1FF4, p0, p1, p2, p3);
        }

        public static void TASK_PLAY_PHONE_GESTURE_ANIMATION(int ped, string animDict, string animation, string boneMaskType, float p4, float p5, bool p6, bool p7)
        {
            Invoker.Call<Void>(0x8FBB6758B3B3E9EC, ped, animDict, animation, boneMaskType, p4, p5, p6, p7);
        }

        public static void _TASK_STOP_PHONE_GESTURE_ANIMATION(int ped)
        {
            Invoker.Call<Void>(0x3FA00D4F4641BFAE, ped);
        }

        public static bool IS_PLAYING_PHONE_GESTURE_ANIM(int ped)
        {
            return Invoker.Call<bool>(0xB8EBB1E9D3588C10, ped);
        }

        public static float GET_PHONE_GESTURE_ANIM_CURRENT_TIME(int ped)
        {
            return Invoker.Call<float>(0x47619ABE8B268C60, ped);
        }

        public static float GET_PHONE_GESTURE_ANIM_TOTAL_TIME(int ped)
        {
            return Invoker.Call<float>(0x1EE0F68A7C25DEC6, ped);
        }

        public static void TASK_VEHICLE_PLAY_ANIM(int vehicle, string animation_set, string animation_name)
        {
            Invoker.Call<Void>(0x69F5C3BD0F3EBD89, vehicle, animation_set, animation_name);
        }

        public static void TASK_LOOK_AT_COORD(int entity, float x, float y, float z, float duration, int p5, int p6)
        {
            Invoker.Call<Void>(0x6FA46612594F7973, entity, x, y, z, duration, p5, p6);
        }

        public static void TASK_LOOK_AT_ENTITY(int ped, int lookAt, int duration, int unknown1, int unknown2)
        {
            Invoker.Call<Void>(0x69F4BE8C8CC4796C, ped, lookAt, duration, unknown1, unknown2);
        }

        public static void TASK_CLEAR_LOOK_AT(int ped)
        {
            Invoker.Call<Void>(0x0F804F1DB19B9689, ped);
        }

        public static int OPEN_SEQUENCE_TASK(ulong taskSequence_ptr)
        {
            return Invoker.Call<int>(0xE8854A4326B9E12B, taskSequence_ptr);
        }

        public static int CLOSE_SEQUENCE_TASK(int taskSequence)
        {
            return Invoker.Call<int>(0x39E72BC99E6360CB, taskSequence);
        }

        public static int TASK_PERFORM_SEQUENCE(int ped, int taskSequence)
        {
            return Invoker.Call<int>(0x5ABA3986D90D8A3B, ped, taskSequence);
        }

        public static int CLEAR_SEQUENCE_TASK(ulong taskSequence_ptr)
        {
            return Invoker.Call<int>(0x3841422E9C488D8C, taskSequence_ptr);
        }

        public static void SET_SEQUENCE_TO_REPEAT(int taskSequence, bool repeat)
        {
            Invoker.Call<Void>(0x58C70CF3A41E4AE7, taskSequence, repeat);
        }

        public static int GET_SEQUENCE_PROGRESS(int ped)
        {
            return Invoker.Call<int>(0x00A9010CFE1E3533, ped);
        }

        public static bool GET_IS_TASK_ACTIVE(int ped, int taskNumber)
        {
            return Invoker.Call<bool>(0xB0760331C7AA4155, ped, taskNumber);
        }

        public static int GET_SCRIPT_TASK_STATUS(int targetPed, int taskHash)
        {
            return Invoker.Call<int>(0x77F1BEB8863288D5, targetPed, taskHash);
        }

        public static int GET_ACTIVE_VEHICLE_MISSION_TYPE(int veh)
        {
            return Invoker.Call<int>(0x534AEBA6E5ED4CAB, veh);
        }

        public static void TASK_LEAVE_ANY_VEHICLE(int ped, int p1, int p2)
        {
            Invoker.Call<Void>(0x504D54DF3F6F2247, ped, p1, p2);
        }

        public static void TASK_AIM_GUN_SCRIPTED(int ped, int scriptTask, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x7A192BE16D373D00, ped, scriptTask, p2, p3);
        }

        public static void TASK_AIM_GUN_SCRIPTED_WITH_TARGET(int p0, int p1, float p2, float p3, float p4, int p5, bool p6, bool p7)
        {
            Invoker.Call<Void>(0x8605AF0DE8B3A5AC, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET(int p0, int p1, float p2, float p3, float p4, bool p5)
        {
            Invoker.Call<Void>(0x9724FB59A3E72AD0, p0, p1, p2, p3, p4, p5);
        }

        public static string GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK(int p0)
        {
            return Invoker.Call<string>(0x3A8CADC7D37AACC5, p0);
        }

        public static void TASK_AIM_GUN_AT_ENTITY(int ped, int entity, int duration, bool p3)
        {
            Invoker.Call<Void>(0x9B53BB6E8943AF53, ped, entity, duration, p3);
        }

        public static void TASK_TURN_PED_TO_FACE_ENTITY(int ped, int entity, int duration)
        {
            Invoker.Call<Void>(0x5AD23D40115353AC, ped, entity, duration);
        }

        public static void TASK_AIM_GUN_AT_COORD(int ped, float x, float y, float z, int time, bool p5, bool p6)
        {
            Invoker.Call<Void>(0x6671F3EEC681BDA1, ped, x, y, z, time, p5, p6);
        }

        public static void TASK_SHOOT_AT_COORD(int ped, float x, float y, float z, int duration, int firingPattern)
        {
            Invoker.Call<Void>(0x46A6CC01E0826106, ped, x, y, z, duration, firingPattern);
        }

        public static void TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT(int ped, int vehicle)
        {
            Invoker.Call<Void>(0x7AA80209BDA643EB, ped, vehicle);
        }

        public static void CLEAR_PED_TASKS(int ped)
        {
            Invoker.Call<Void>(0xE1EF3C1216AFF2CD, ped);
        }

        public static void CLEAR_PED_SECONDARY_TASK(int ped)
        {
            Invoker.Call<Void>(0x176CECF6F920D707, ped);
        }

        public static void TASK_EVERYONE_LEAVE_VEHICLE(int vehicle)
        {
            Invoker.Call<Void>(0x7F93691AB4B92272, vehicle);
        }

        public static void TASK_GOTO_ENTITY_OFFSET(int ped, int p1, int p2, float x, float y, float z, int duration)
        {
            Invoker.Call<Void>(0xE39B4FF4FDEBDE27, ped, p1, p2, x, y, z, duration);
        }

        public static void TASK_GOTO_ENTITY_OFFSET_XY(int ped, int entity, int duration, float xOffset, float yOffset, float zOffset, float moveBlendRatio, bool useNavmesh)
        {
            Invoker.Call<Void>(0x338E7EF52B6095A9, ped, entity, duration, xOffset, yOffset, zOffset, moveBlendRatio, useNavmesh);
        }

        public static void TASK_TURN_PED_TO_FACE_COORD(int ped, float x, float y, float z, int duration)
        {
            Invoker.Call<Void>(0x1DDA930A0AC38571, ped, x, y, z, duration);
        }

        public static void TASK_VEHICLE_TEMP_ACTION(int driver, int vehicle, int action, int time)
        {
            Invoker.Call<Void>(0xC429DCEEB339E129, driver, vehicle, action, time);
        }

        public static void TASK_VEHICLE_MISSION(int p0, int p1, int veh, int p3, float p4, int p5, float p6, float p7, bool p8)
        {
            Invoker.Call<Void>(0x659427E0EF36BCDE, p0, p1, veh, p3, p4, p5, p6, p7, p8);
        }

        public static void TASK_VEHICLE_MISSION_PED_TARGET(int ped, int vehicle, int pedTarget, int mode, float maxSpeed, int drivingStyle, float minDistance, float p7, bool p8)
        {
            Invoker.Call<Void>(0x9454528DF15D657A, ped, vehicle, pedTarget, mode, maxSpeed, drivingStyle, minDistance, p7, p8);
        }

        public static void TASK_VEHICLE_MISSION_COORS_TARGET(int ped, int vehicle, float x, float y, float z, int p5, int p6, int p7, float p8, float p9, bool p10)
        {
            Invoker.Call<Void>(0xF0AF20AA7731F8C3, ped, vehicle, x, y, z, p5, p6, p7, p8, p9, p10);
        }

        public static void TASK_VEHICLE_ESCORT(int ped, int vehicle, int targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int p7, float noRoadsDistance)
        {
            Invoker.Call<Void>(0x0FA6E4B75F302400, ped, vehicle, targetVehicle, mode, speed, drivingStyle, minDistance, p7, noRoadsDistance);
        }

        public static void _TASK_VEHICLE_FOLLOW(int driver, int vehicle, int targetEntity, float speed, int drivingStyle, int minDistance)
        {
            Invoker.Call<Void>(0xFC545A9F0626E3B6, driver, vehicle, targetEntity, speed, drivingStyle, minDistance);
        }

        public static void TASK_VEHICLE_CHASE(int driver, int targetEnt)
        {
            Invoker.Call<Void>(0x3C08A8E30363B353, driver, targetEnt);
        }

        public static void TASK_VEHICLE_HELI_PROTECT(int pilot, int vehicle, int entityToFollow, float targetSpeed, int p4, float radius, int altitude, int p7)
        {
            Invoker.Call<Void>(0x1E09C32048FEFD1C, pilot, vehicle, entityToFollow, targetSpeed, p4, radius, altitude, p7);
        }

        public static void SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG(int ped, int flag, bool set)
        {
            Invoker.Call<Void>(0xCC665AAC360D31E7, ped, flag, set);
        }

        public static void SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE(int ped, float distance)
        {
            Invoker.Call<Void>(0x639B642FACBE4EDD, ped, distance);
        }

        public static void TASK_HELI_CHASE(int pilot, int entityToFollow, float x, float y, float z)
        {
            Invoker.Call<Void>(0xAC83B1DB38D0ADA0, pilot, entityToFollow, x, y, z);
        }

        public static void TASK_PLANE_CHASE(int pilot, int entityToFollow, float x, float y, float z)
        {
            Invoker.Call<Void>(0x2D2386F273FF7A25, pilot, entityToFollow, x, y, z);
        }

        public static void TASK_PLANE_LAND(int pilot, int plane, float runwayStartX, float runwayStartY, float runwayStartZ, float runwayEndX, float runwayEndY, float runwayEndZ)
        {
            Invoker.Call<Void>(0xBF19721FA34D32C0, pilot, plane, runwayStartX, runwayStartY, runwayStartZ, runwayEndX, runwayEndY, runwayEndZ);
        }

        public static void TASK_HELI_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float maxSpeed, float landingRadius, float targetHeading, int unk1, int unk2, int unk3, int landingFlags)
        {
            Invoker.Call<Void>(0xDAD029E187A2BEB4, pilot, aircraft, targetVehicle, targetPed, destinationX, destinationY, destinationZ, missionFlag, maxSpeed, landingRadius, targetHeading, unk1, unk2, unk3, landingFlags);
        }

        public static void TASK_PLANE_MISSION(int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float angularDrag, float unk, float targetHeading, float maxZ, float minZ)
        {
            Invoker.Call<Void>(0x23703CD154E83B88, pilot, aircraft, targetVehicle, targetPed, destinationX, destinationY, destinationZ, missionFlag, angularDrag, unk, targetHeading, maxZ, minZ);
        }

        public static void TASK_BOAT_MISSION(int pedDriver, int boat, int p2, int p3, float x, float y, float z, int p7, float maxSpeed, int drivingStyle, float p10, int p11)
        {
            Invoker.Call<Void>(0x15C86013127CE63F, pedDriver, boat, p2, p3, x, y, z, p7, maxSpeed, drivingStyle, p10, p11);
        }

        public static void TASK_DRIVE_BY(int driverPed, int targetPed, int targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, bool p8, int firingPattern)
        {
            Invoker.Call<Void>(0x2F8AF0E82773A171, driverPed, targetPed, targetVehicle, targetX, targetY, targetZ, distanceToShoot, pedAccuracy, p8, firingPattern);
        }

        public static void SET_DRIVEBY_TASK_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z)
        {
            Invoker.Call<Void>(0xE5B302114D8162EE, shootingPed, targetPed, targetVehicle, x, y, z);
        }

        public static void CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)
        {
            Invoker.Call<Void>(0xC35B5CDB2824CF69, ped);
        }

        public static bool IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped)
        {
            return Invoker.Call<bool>(0x8785E6E40C7A8818, ped);
        }

        public static bool CONTROL_MOUNTED_WEAPON(int ped)
        {
            return Invoker.Call<bool>(0xDCFE42068FE0135A, ped);
        }

        public static void SET_MOUNTED_WEAPON_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z)
        {
            Invoker.Call<Void>(0xCCD892192C6D2BB9, shootingPed, targetPed, targetVehicle, x, y, z);
        }

        public static bool IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK(int ped)
        {
            return Invoker.Call<bool>(0xA320EF046186FA3B, ped);
        }

        public static void TASK_USE_MOBILE_PHONE(int ped, int p1)
        {
            Invoker.Call<Void>(0xBD2A8EC3AF4DE7DB, ped, p1);
        }

        public static void TASK_USE_MOBILE_PHONE_TIMED(int ped, int duration)
        {
            Invoker.Call<Void>(0x5EE02954A14C69DB, ped, duration);
        }

        public static void TASK_CHAT_TO_PED(int ped, int target, int p2, float p3, float p4, float p5, float p6, float p7)
        {
            Invoker.Call<Void>(0x8C338E0263E4FD19, ped, target, p2, p3, p4, p5, p6, p7);
        }

        public static void TASK_WARP_PED_INTO_VEHICLE(int ped, int vehicle, int seat)
        {
            Invoker.Call<Void>(0x9A7D091411C5F684, ped, vehicle, seat);
        }

        public static void TASK_SHOOT_AT_ENTITY(int entity, int target, int duration, int firingPattern)
        {
            Invoker.Call<Void>(0x08DA95E8298AE772, entity, target, duration, firingPattern);
        }

        public static void TASK_CLIMB(int ped, bool unused)
        {
            Invoker.Call<Void>(0x89D9FCC2435112F1, ped, unused);
        }

        public static void TASK_CLIMB_LADDER(int ped, int p1)
        {
            Invoker.Call<Void>(0xB6C987F9285A3814, ped, p1);
        }

        public static void CLEAR_PED_TASKS_IMMEDIATELY(int ped)
        {
            Invoker.Call<Void>(0xAAA34F8A7CB32098, ped);
        }

        public static void TASK_PERFORM_SEQUENCE_FROM_PROGRESS(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x89221B16730234F0, p0, p1, p2, p3);
        }

        public static void SET_NEXT_DESIRED_MOVE_STATE(float p0)
        {
            Invoker.Call<Void>(0xF1B9F16E89E2C93A, p0);
        }

        public static void SET_PED_DESIRED_MOVE_BLEND_RATIO(int ped, float p1)
        {
            Invoker.Call<Void>(0x1E982AC8716912C5, ped, p1);
        }

        public static float GET_PED_DESIRED_MOVE_BLEND_RATIO(int ped)
        {
            return Invoker.Call<float>(0x8517D4A6CA8513ED, ped);
        }

        public static void TASK_GOTO_ENTITY_AIMING(int ped, int target, float distanceToStopAt, float StartAimingDist)
        {
            Invoker.Call<Void>(0xA9DA48FAB8A76C12, ped, target, distanceToStopAt, StartAimingDist);
        }

        public static void TASK_SET_DECISION_MAKER(int p0, int p1)
        {
            Invoker.Call<Void>(0xEB8517DDA73720DA, p0, p1);
        }

        public static void TASK_SET_SPHERE_DEFENSIVE_AREA(int p0, float p1, float p2, float p3, float p4)
        {
            Invoker.Call<Void>(0x933C06518B52A9A4, p0, p1, p2, p3, p4);
        }

        public static void TASK_CLEAR_DEFENSIVE_AREA(int p0)
        {
            Invoker.Call<Void>(0x95A6C46A31D1917D, p0);
        }

        public static void TASK_PED_SLIDE_TO_COORD(int ped, float x, float y, float z, float heading, float duration)
        {
            Invoker.Call<Void>(0xD04FE6765D990A06, ped, x, y, z, heading, duration);
        }

        public static void TASK_PED_SLIDE_TO_COORD_HDG_RATE(int ped, float x, float y, float z, float heading, float p5, float p6)
        {
            Invoker.Call<Void>(0x5A4A6A6D3DC64F52, ped, x, y, z, heading, p5, p6);
        }

        public static int ADD_COVER_POINT(float p0, float p1, float p2, float p3, int p4, int p5, int p6, bool p7)
        {
            return Invoker.Call<int>(0xD5C12A75C7B9497F, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void REMOVE_COVER_POINT(int coverpoint)
        {
            Invoker.Call<Void>(0xAE287C923D891715, coverpoint);
        }

        public static bool DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS(float x, float y, float z)
        {
            return Invoker.Call<bool>(0xA98B8E3C088E5A31, x, y, z);
        }

        public static Vector3 GET_SCRIPTED_COVER_POINT_COORDS(int coverpoint)
        {
            return Invoker.Call<Vector3>(0x594A1028FC2A3E85, coverpoint);
        }

        public static void TASK_COMBAT_PED(int ped, int targetPed, int p2, int p3)
        {
            Invoker.Call<Void>(0xF166E48407BAC484, ped, targetPed, p2, p3);
        }

        public static void TASK_COMBAT_PED_TIMED(int p0, int ped, int p2, int p3)
        {
            Invoker.Call<Void>(0x944F30DCB7096BDE, p0, ped, p2, p3);
        }

        public static void TASK_SEEK_COVER_FROM_POS(int ped, float x, float y, float z, int duration, bool p5)
        {
            Invoker.Call<Void>(0x75AC2B60386D89F2, ped, x, y, z, duration, p5);
        }

        public static void TASK_SEEK_COVER_FROM_PED(int ped, int target, int duration, bool p3)
        {
            Invoker.Call<Void>(0x84D32B3BEC531324, ped, target, duration, p3);
        }

        public static void TASK_SEEK_COVER_TO_COVER_POINT(int p0, int p1, float p2, float p3, float p4, int p5, bool p6)
        {
            Invoker.Call<Void>(0xD43D95C7A869447F, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void TASK_SEEK_COVER_TO_COORDS(int ped, float x1, float y1, float z1, float x2, float y2, float z2, int p7, bool p8)
        {
            Invoker.Call<Void>(0x39246A6958EF072C, ped, x1, y1, z1, x2, y2, z2, p7, p8);
        }

        public static void TASK_PUT_PED_DIRECTLY_INTO_COVER(int ped, float x, float y, float z, int time_out, bool p5, float p6, bool p7, bool p8, int p9, bool p10)
        {
            Invoker.Call<Void>(0x4172393E6BE1FECE, ped, x, y, z, time_out, p5, p6, p7, p8, p9, p10);
        }

        public static void TASK_EXIT_COVER(int p0, int p1, float p2, float p3, float p4)
        {
            Invoker.Call<Void>(0x79B258E397854D29, p0, p1, p2, p3, p4);
        }

        public static void TASK_PUT_PED_DIRECTLY_INTO_MELEE(int ped, int meleeTarget, float p2, float p3, float p4, bool p5)
        {
            Invoker.Call<Void>(0x1C6CD14A876FFE39, ped, meleeTarget, p2, p3, p4, p5);
        }

        public static void TASK_TOGGLE_DUCK(bool p0, bool p1)
        {
            Invoker.Call<Void>(0xAC96609B9995EDF8, p0, p1);
        }

        public static void TASK_GUARD_CURRENT_POSITION(int p0, float p1, float p2, bool p3)
        {
            Invoker.Call<Void>(0x4A58A47A72E3FCB4, p0, p1, p2, p3);
        }

        public static void TASK_GUARD_ASSIGNED_DEFENSIVE_AREA(int p0, float p1, float p2, float p3, float p4, float p5, int p6)
        {
            Invoker.Call<Void>(0xD2A207EEBDF9889B, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void TASK_GUARD_SPHERE_DEFENSIVE_AREA(int p0, float p1, float p2, float p3, float p4, float p5, int p6, float p7, float p8, float p9, float p10)
        {
            Invoker.Call<Void>(0xC946FE14BE0EB5E2, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }

        public static void TASK_STAND_GUARD(int ped, float x, float y, float z, float heading, string scenarioName)
        {
            Invoker.Call<Void>(0xAE032F8BBA959E90, ped, x, y, z, heading, scenarioName);
        }

        public static void SET_DRIVE_TASK_CRUISE_SPEED(int driver, float cruiseSpeed)
        {
            Invoker.Call<Void>(0x5C9B84BD7D31D908, driver, cruiseSpeed);
        }

        public static void SET_DRIVE_TASK_MAX_CRUISE_SPEED(int p0, float p1)
        {
            Invoker.Call<Void>(0x404A5AA9B9F0B746, p0, p1);
        }

        public static void SET_DRIVE_TASK_DRIVING_STYLE(int ped, int drivingStyle)
        {
            Invoker.Call<Void>(0xDACE1BE37D88AF67, ped, drivingStyle);
        }

        public static void ADD_COVER_BLOCKING_AREA(float playerX, float playerY, float playerZ, float radiusX, float radiusY, float radiusZ, bool p6, bool p7, bool p8, bool p9)
        {
            Invoker.Call<Void>(0x45C597097DD7CB81, playerX, playerY, playerZ, radiusX, radiusY, radiusZ, p6, p7, p8, p9);
        }

        public static void REMOVE_ALL_COVER_BLOCKING_AREAS()
        {
            Invoker.Call<Void>(0xDB6708C0B46F56D8);
        }

        public static void TASK_START_SCENARIO_IN_PLACE(int ped, string scenarioName, int unkDelay, bool playEnterAnim)
        {
            Invoker.Call<Void>(0x142A02425FF02BD9, ped, scenarioName, unkDelay, playEnterAnim);
        }

        public static void TASK_START_SCENARIO_AT_POSITION(int ped, string scenarioName, float x, float y, float z, float heading, int duration, bool sittingScenario, bool teleport)
        {
            Invoker.Call<Void>(0xFA4EFC79F69D4F07, ped, scenarioName, x, y, z, heading, duration, sittingScenario, teleport);
        }

        public static void TASK_USE_NEAREST_SCENARIO_TO_COORD(int ped, float x, float y, float z, float distance, int duration)
        {
            Invoker.Call<Void>(0x277F471BA9DB000B, ped, x, y, z, distance, duration);
        }

        public static void TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP(int ped, float x, float y, float z, float radius, int p5)
        {
            Invoker.Call<Void>(0x58E2E0F23F6B76C3, ped, x, y, z, radius, p5);
        }

        public static void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD(int p0, float p1, float p2, float p3, float p4, int p5)
        {
            Invoker.Call<Void>(0x9FDA1B3D7E7028B3, p0, p1, p2, p3, p4, p5);
        }

        public static void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP(int p0, float p1, float p2, float p3, float p4, int p5)
        {
            Invoker.Call<Void>(0x97A28E63F0BA5631, p0, p1, p2, p3, p4, p5);
        }

        public static bool DOES_SCENARIO_EXIST_IN_AREA(float x, float y, float z, float radius, bool b)
        {
            return Invoker.Call<bool>(0x5A59271FFADD33C1, x, y, z, radius, b);
        }

        public static bool DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA(float p0, float p1, float p2, ulong p3_ptr, float p4, bool p5)
        {
            return Invoker.Call<bool>(0x0A9D0C2A3BBC86C1, p0, p1, p2, p3_ptr, p4, p5);
        }

        public static bool IS_SCENARIO_OCCUPIED(float p0, float p1, float p2, float p3, bool p4)
        {
            return Invoker.Call<bool>(0x788756D73AC2E07C, p0, p1, p2, p3, p4);
        }

        public static bool PED_HAS_USE_SCENARIO_TASK(int ped)
        {
            return Invoker.Call<bool>(0x295E3CCEC879CCD7, ped);
        }

        public static void PLAY_ANIM_ON_RUNNING_SCENARIO(int ped, string animDict, string animName)
        {
            Invoker.Call<Void>(0x748040460F8DF5DC, ped, animDict, animName);
        }

        public static bool DOES_SCENARIO_GROUP_EXIST(string scenarioGroup)
        {
            return Invoker.Call<bool>(0xF9034C136C9E00D3, scenarioGroup);
        }

        public static bool IS_SCENARIO_GROUP_ENABLED(string scenarioGroup)
        {
            return Invoker.Call<bool>(0x367A09DED4E05B99, scenarioGroup);
        }

        public static void SET_SCENARIO_GROUP_ENABLED(string scenarioGroup, bool p1)
        {
            Invoker.Call<Void>(0x02C8E5B49848664E, scenarioGroup, p1);
        }

        public static void RESET_SCENARIO_GROUPS_ENABLED()
        {
            Invoker.Call<Void>(0xDD902D0349AFAD3A);
        }

        public static void SET_EXCLUSIVE_SCENARIO_GROUP(string scenarioGroup)
        {
            Invoker.Call<Void>(0x535E97E1F7FC0C6A, scenarioGroup);
        }

        public static void RESET_EXCLUSIVE_SCENARIO_GROUP()
        {
            Invoker.Call<Void>(0x4202BBCB8684563D);
        }

        public static bool IS_SCENARIO_TYPE_ENABLED(string scenarioType)
        {
            return Invoker.Call<bool>(0x3A815DB3EA088722, scenarioType);
        }

        public static void SET_SCENARIO_TYPE_ENABLED(string scenarioType, bool toggle)
        {
            Invoker.Call<Void>(0xEB47EC4E34FB7EE1, scenarioType, toggle);
        }

        public static void RESET_SCENARIO_TYPES_ENABLED()
        {
            Invoker.Call<Void>(0x0D40EE2A7F2B2D6D);
        }

        public static bool IS_PED_ACTIVE_IN_SCENARIO(int ped)
        {
            return Invoker.Call<bool>(0xAA135F9482C82CC3, ped);
        }

        public static bool _0x621C6E4729388E41(int ped)
        {
            return Invoker.Call<bool>(0x621C6E4729388E41, ped);
        }

        public static void _0x8FD89A6240813FD0(int ped, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x8FD89A6240813FD0, ped, p1, p2);
        }

        public static void TASK_COMBAT_HATED_TARGETS_IN_AREA(int ped, float x, float y, float z, float radius, int p5)
        {
            Invoker.Call<Void>(0x4CF5F55DAC3280A0, ped, x, y, z, radius, p5);
        }

        public static void TASK_COMBAT_HATED_TARGETS_AROUND_PED(int ped, float radius, int p2)
        {
            Invoker.Call<Void>(0x7BF835BB9E2698C8, ped, radius, p2);
        }

        public static void TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED(int p0, float p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x2BBA30B854534A0C, p0, p1, p2, p3);
        }

        public static void TASK_THROW_PROJECTILE(int ped, float x, float y, float z)
        {
            Invoker.Call<Void>(0x7285951DBF6B5A51, ped, x, y, z);
        }

        public static void TASK_SWAP_WEAPON(int ped, bool p1)
        {
            Invoker.Call<Void>(0xA21C51255B205245, ped, p1);
        }

        public static void TASK_RELOAD_WEAPON(int ped, bool unused)
        {
            Invoker.Call<Void>(0x62D2916F56B9CD2D, ped, unused);
        }

        public static bool IS_PED_GETTING_UP(int ped)
        {
            return Invoker.Call<bool>(0x2A74E1D5F2F00EEC, ped);
        }

        public static void TASK_WRITHE(int ped, int target, int time, int p3)
        {
            Invoker.Call<Void>(0xCDDC2B77CE54AC6E, ped, target, time, p3);
        }

        public static bool IS_PED_IN_WRITHE(int ped)
        {
            return Invoker.Call<bool>(0xDEB6D52126E7D640, ped);
        }

        public static void OPEN_PATROL_ROUTE(string patrolR_oute)
        {
            Invoker.Call<Void>(0xA36BFB5EE89F3D82, patrolR_oute);
        }

        public static void CLOSE_PATROL_ROUTE()
        {
            Invoker.Call<Void>(0xB043ECA801B8CBC1);
        }

        public static void ADD_PATROL_ROUTE_NODE(int p0, string p1, float x1, float y1, float z1, float x2, float y2, float z2, int p8)
        {
            Invoker.Call<Void>(0x8EDF950167586B7C, p0, p1, x1, y1, z1, x2, y2, z2, p8);
        }

        public static void ADD_PATROL_ROUTE_LINK(int p0, int p1)
        {
            Invoker.Call<Void>(0x23083260DEC3A551, p0, p1);
        }

        public static void CREATE_PATROL_ROUTE()
        {
            Invoker.Call<Void>(0xAF8A443CCC8018DC);
        }

        public static void DELETE_PATROL_ROUTE(string patrolR_oute)
        {
            Invoker.Call<Void>(0x7767DD9D65E91319, patrolR_oute);
        }

        public static void TASK_PATROL(int ped, string p1, int p2, bool p3, bool p4)
        {
            Invoker.Call<Void>(0xBDA5DF49D080FE4E, ped, p1, p2, p3, p4);
        }

        public static void TASK_STAY_IN_COVER(int ped)
        {
            Invoker.Call<Void>(0xE5DA8615A6180789, ped);
        }

        public static void ADD_VEHICLE_SUBTASK_ATTACK_COORD(int ped, float x, float y, float z)
        {
            Invoker.Call<Void>(0x5CF0D8F9BBA0DD75, ped, x, y, z);
        }

        public static void ADD_VEHICLE_SUBTASK_ATTACK_PED(int ped, int ped2)
        {
            Invoker.Call<Void>(0x85F462BADC7DA47F, ped, ped2);
        }

        public static void TASK_VEHICLE_SHOOT_AT_PED(int ped, int target, float p2)
        {
            Invoker.Call<Void>(0x10AB107B887214D8, ped, target, p2);
        }

        public static void TASK_VEHICLE_AIM_AT_PED(int ped, int target)
        {
            Invoker.Call<Void>(0xE41885592B08B097, ped, target);
        }

        public static void TASK_VEHICLE_SHOOT_AT_COORD(int ped, float x, float y, float z, float p4)
        {
            Invoker.Call<Void>(0x5190796ED39C9B6D, ped, x, y, z, p4);
        }

        public static void TASK_VEHICLE_AIM_AT_COORD(int ped, float x, float y, float z)
        {
            Invoker.Call<Void>(0x447C1E9EF844BC0F, ped, x, y, z);
        }

        public static void TASK_VEHICLE_GOTO_NAVMESH(int ped, int vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange)
        {
            Invoker.Call<Void>(0x195AEEB13CEFE2EE, ped, vehicle, x, y, z, speed, behaviorFlag, stoppingRange);
        }

        public static void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD(int ped, float x, float y, float z, float aimAtX, float aimAtY, float aimAtZ, float moveSpeed, bool p8, float p9, float p10, bool p11, int flags, bool p13, int firingPattern)
        {
            Invoker.Call<Void>(0x11315AB3385B8AC0, ped, x, y, z, aimAtX, aimAtY, aimAtZ, moveSpeed, p8, p9, p10, p11, flags, p13, firingPattern);
        }

        public static void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY(int p0, float p1, float p2, float p3, int p4, float p5, bool p6, float p7, float p8, bool p9, int p10, bool p11, int p12, int p13)
        {
            Invoker.Call<Void>(0xB2A16444EAD9AE47, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }

        public static void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(int pedHandle, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, bool shootAtEnemies, float distanceToStopAt, float noRoadsDistance, bool unkTrue, int unkFlag, int aimingFlag, int firingPattern)
        {
            Invoker.Call<Void>(0xA55547801EB331FC, pedHandle, goToLocationX, goToLocationY, goToLocationZ, focusLocationX, focusLocationY, focusLocationZ, speed, shootAtEnemies, distanceToStopAt, noRoadsDistance, unkTrue, unkFlag, aimingFlag, firingPattern);
        }

        public static void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD(int p0, int p1, float p2, float p3, float p4, float p5, bool p6, float p7, float p8, bool p9, bool p10, int p11)
        {
            Invoker.Call<Void>(0x04701832B739DCE5, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        public static void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY(int ped, int entityToWalkTo, int entityToAimAt, float speed, bool shootatEntity, float p5, float p6, bool p7, bool p8, int firingPattern)
        {
            Invoker.Call<Void>(0x97465886D35210E9, ped, entityToWalkTo, entityToAimAt, speed, shootatEntity, p5, p6, p7, p8, firingPattern);
        }

        public static void SET_HIGH_FALL_TASK(int ped, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x8C825BDC7741D37C, ped, p1, p2, p3);
        }

        public static void REQUEST_WAYPOINT_RECORDING(string name)
        {
            Invoker.Call<Void>(0x9EEFB62EB27B5792, name);
        }

        public static bool GET_IS_WAYPOINT_RECORDING_LOADED(string name)
        {
            return Invoker.Call<bool>(0xCB4E8BE8A0063C5D, name);
        }

        public static void REMOVE_WAYPOINT_RECORDING(string name)
        {
            Invoker.Call<Void>(0xFF1B8B4AA1C25DC8, name);
        }

        public static bool WAYPOINT_RECORDING_GET_NUM_POINTS(string name, ulong points_ptr)
        {
            return Invoker.Call<bool>(0x5343532C01A07234, name, points_ptr);
        }

        public static bool WAYPOINT_RECORDING_GET_COORD(string name, int point, ulong coord_ptr)
        {
            return Invoker.Call<bool>(0x2FB897405C90B361, name, point, coord_ptr);
        }

        public static float WAYPOINT_RECORDING_GET_SPEED_AT_POINT(string name, int point)
        {
            return Invoker.Call<float>(0x005622AEBC33ACA9, name, point);
        }

        public static bool WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT(string name, float x, float y, float z, ulong point_ptr)
        {
            return Invoker.Call<bool>(0xB629A298081F876F, name, x, y, z, point_ptr);
        }

        public static void TASK_FOLLOW_WAYPOINT_RECORDING(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x0759591819534F7B, p0, p1, p2, p3, p4);
        }

        public static bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED(int p0)
        {
            return Invoker.Call<bool>(0xE03B3F2D3DC59B64, p0);
        }

        public static int GET_PED_WAYPOINT_PROGRESS(int ped)
        {
            return Invoker.Call<int>(0x2720AAA75001E094, ped);
        }

        public static float GET_PED_WAYPOINT_DISTANCE(int p0)
        {
            return Invoker.Call<float>(0xE6A877C64CAF1BC5, p0);
        }

        public static int SET_PED_WAYPOINT_ROUTE_OFFSET(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xED98E10B0AFCE4B4, p0, p1, p2, p3);
        }

        public static float GET_WAYPOINT_DISTANCE_ALONG_ROUTE(string p0, int p1)
        {
            return Invoker.Call<float>(0xA5B769058763E497, p0, p1);
        }

        public static bool WAYPOINT_PLAYBACK_GET_IS_PAUSED(int p0)
        {
            return Invoker.Call<bool>(0x701375A7D43F01CB, p0);
        }

        public static void WAYPOINT_PLAYBACK_PAUSE(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x0F342546AA06FED5, p0, p1, p2);
        }

        public static void WAYPOINT_PLAYBACK_RESUME(int p0, bool p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x244F70C84C547D2D, p0, p1, p2, p3);
        }

        public static void WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int p0, float p1, bool p2)
        {
            Invoker.Call<Void>(0x7D7D2B47FA788E85, p0, p1, p2);
        }

        public static void WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int p0)
        {
            Invoker.Call<Void>(0x6599D834B12D0800, p0);
        }

        public static void USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE(ulong p0_ptr, bool p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x5A353B8E6B1095B5, p0_ptr, p1, p2, p3);
        }

        public static void WAYPOINT_PLAYBACK_START_AIMING_AT_PED(int p0, int p1, bool p2)
        {
            Invoker.Call<Void>(0x20E330937C399D29, p0, p1, p2);
        }

        public static void WAYPOINT_PLAYBACK_START_AIMING_AT_COORD(int p0, float p1, float p2, float p3, bool p4)
        {
            Invoker.Call<Void>(0x8968400D900ED8B3, p0, p1, p2, p3, p4);
        }

        public static void _0xE70BA7B90F8390DC(int p0, int p1, bool p2, int p3)
        {
            Invoker.Call<Void>(0xE70BA7B90F8390DC, p0, p1, p2, p3);
        }

        public static void WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD(int p0, float p1, float p2, float p3, bool p4, int p5)
        {
            Invoker.Call<Void>(0x057A25CFCC9DB671, p0, p1, p2, p3, p4, p5);
        }

        public static void WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING(int p0)
        {
            Invoker.Call<Void>(0x47EFA040EBB8E2EA, p0);
        }

        public static void ASSISTED_MOVEMENT_REQUEST_ROUTE(string r_oute)
        {
            Invoker.Call<Void>(0x817268968605947A, r_oute);
        }

        public static void ASSISTED_MOVEMENT_REMOVE_ROUTE(string r_oute)
        {
            Invoker.Call<Void>(0x3548536485DD792B, r_oute);
        }

        public static bool ASSISTED_MOVEMENT_IS_ROUTE_LOADED(string r_oute)
        {
            return Invoker.Call<bool>(0x60F9A4393A21F741, r_oute);
        }

        public static void ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES(string r_oute, int props)
        {
            Invoker.Call<Void>(0xD5002D78B7162E1B, r_oute, props);
        }

        public static void ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME(float dist)
        {
            Invoker.Call<Void>(0x13945951E16EF912, dist);
        }

        public static void TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING(int ped, int vehicle, string WPRecording, int p3, int p4, int p5, int p6, float p7, bool p8, float p9)
        {
            Invoker.Call<Void>(0x3123FAA6DB1CF7ED, ped, vehicle, WPRecording, p3, p4, p5, p6, p7, p8, p9);
        }

        public static bool IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE(int p0)
        {
            return Invoker.Call<bool>(0xF5134943EA29868C, p0);
        }

        public static int GET_VEHICLE_WAYPOINT_PROGRESS(int vehicle)
        {
            return Invoker.Call<int>(0x9824CFF8FC66E159, vehicle);
        }

        public static int GET_VEHICLE_WAYPOINT_TARGET_POINT(int p0)
        {
            return Invoker.Call<int>(0x416B62AC8B9E5BBD, p0);
        }

        public static void VEHICLE_WAYPOINT_PLAYBACK_PAUSE(int p0)
        {
            Invoker.Call<Void>(0x8A4E6AC373666BC5, p0);
        }

        public static void VEHICLE_WAYPOINT_PLAYBACK_RESUME(int p0)
        {
            Invoker.Call<Void>(0xDC04FCAA7839D492, p0);
        }

        public static void VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int p0)
        {
            Invoker.Call<Void>(0x5CEB25A7D2848963, p0);
        }

        public static void VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int p0, float p1)
        {
            Invoker.Call<Void>(0x121F0593E0A431D7, p0, p1);
        }

        public static void TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x90D2156198831D69, ped, toggle);
        }

        public static void TASK_FORCE_MOTION_STATE(int ped, int state, bool p2)
        {
            Invoker.Call<Void>(0x4F056E1AFFEF17AB, ped, state, p2);
        }

        public static void _TASK_MOVE_NETWORK(int ped, string task, float multiplier, bool p3, string animDict, int flags)
        {
            Invoker.Call<Void>(0x2D537BA194896636, ped, task, multiplier, p3, animDict, flags);
        }

        public static void _TASK_MOVE_NETWORK_ADVANCED(int ped, string p1, float p2, float p3, float p4, float p5, float p6, float p7, int p8, float p9, bool p10, string animDict, int flags)
        {
            Invoker.Call<Void>(0xD5B35BEA41919ACB, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, animDict, flags);
        }

        public static bool _0x921CE12C489C4C41(int PlayerID)
        {
            return Invoker.Call<bool>(0x921CE12C489C4C41, PlayerID);
        }

        public static bool _0x30ED88D5E0C56A37(int p0)
        {
            return Invoker.Call<bool>(0x30ED88D5E0C56A37, p0);
        }

        public static int _0xD01015C7316AE176(int ped, string p1)
        {
            return Invoker.Call<int>(0xD01015C7316AE176, ped, p1);
        }

        public static int _0xAB13A5565480B6D9(int p0, int p1)
        {
            return Invoker.Call<int>(0xAB13A5565480B6D9, p0, p1);
        }

        public static string _0x717E4D1F2048376D(int ped)
        {
            return Invoker.Call<string>(0x717E4D1F2048376D, ped);
        }

        public static void _0xD5BB4025AE449A4E(int ped, string p1, float p2)
        {
            Invoker.Call<Void>(0xD5BB4025AE449A4E, ped, p1, p2);
        }

        public static void _0xB0A6CFD2C69C1088(int ped, string p1, bool p2)
        {
            Invoker.Call<Void>(0xB0A6CFD2C69C1088, ped, p1, p2);
        }

        public static bool _0xA7FFBA498E4AAF67(int ped, string p1)
        {
            return Invoker.Call<bool>(0xA7FFBA498E4AAF67, ped, p1);
        }

        public static bool _0xB4F47213DF45A64C(int ped, string p1)
        {
            return Invoker.Call<bool>(0xB4F47213DF45A64C, ped, p1);
        }

        public static bool IS_MOVE_BLEND_RATIO_STILL(int ped)
        {
            return Invoker.Call<bool>(0x349CE7B56DAFD95C, ped);
        }

        public static bool IS_MOVE_BLEND_RATIO_WALKING(int ped)
        {
            return Invoker.Call<bool>(0xF133BBBE91E1691F, ped);
        }

        public static bool IS_MOVE_BLEND_RATIO_RUNNING(int ped)
        {
            return Invoker.Call<bool>(0xD4D8636C0199A939, ped);
        }

        public static bool IS_MOVE_BLEND_RATIO_SPRINTING(int ped)
        {
            return Invoker.Call<bool>(0x24A2AD74FA9814E2, ped);
        }

        public static bool IS_PED_STILL(int ped)
        {
            return Invoker.Call<bool>(0xAC29253EEF8F0180, ped);
        }

        public static bool IS_PED_WALKING(int ped)
        {
            return Invoker.Call<bool>(0xDE4C184B2B9B071A, ped);
        }

        public static bool IS_PED_RUNNING(int ped)
        {
            return Invoker.Call<bool>(0xC5286FFC176F28A2, ped);
        }

        public static bool IS_PED_SPRINTING(int ped)
        {
            return Invoker.Call<bool>(0x57E457CD2C0FC168, ped);
        }

        public static bool IS_PED_STRAFING(int ped)
        {
            return Invoker.Call<bool>(0xE45B7F222DE47E09, ped);
        }

        public static void TASK_SYNCHRONIZED_SCENE(int ped, int scene, string animDictionary, string animationName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, int p9)
        {
            Invoker.Call<Void>(0xEEA929141F699854, ped, scene, animDictionary, animationName, speed, speedMultiplier, duration, flag, playbackRate, p9);
        }

        public static void TASK_SWEEP_AIM_ENTITY(int ped, string anim, string p2, string p3, string p4, int p5, int vehicle, float p7, float p8)
        {
            Invoker.Call<Void>(0x2047C02158D6405A, ped, anim, p2, p3, p4, p5, vehicle, p7, p8);
        }

        public static void UPDATE_TASK_SWEEP_AIM_ENTITY(int ped, int entity)
        {
            Invoker.Call<Void>(0xE4973DBDBE6E44B3, ped, entity);
        }

        public static void TASK_SWEEP_AIM_POSITION(int p0, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr, ulong p4_ptr, int p5, float p6, float p7, float p8, float p9, float p10)
        {
            Invoker.Call<Void>(0x7AFE8FDC10BC07D2, p0, p1_ptr, p2_ptr, p3_ptr, p4_ptr, p5, p6, p7, p8, p9, p10);
        }

        public static void UPDATE_TASK_SWEEP_AIM_POSITION(int p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0xBB106883F5201FC4, p0, p1, p2, p3);
        }

        public static void TASK_ARREST_PED(int ped, int target)
        {
            Invoker.Call<Void>(0xF3B9A78A178572B1, ped, target);
        }

        public static bool IS_PED_RUNNING_ARREST_TASK(int ped)
        {
            return Invoker.Call<bool>(0x3DC52677769B4AE0, ped);
        }

        public static bool IS_PED_BEING_ARRESTED(int ped)
        {
            return Invoker.Call<bool>(0x90A09F3A45FED688, ped);
        }

        public static void UNCUFF_PED(int ped)
        {
            Invoker.Call<Void>(0x67406F2C8F87FC4F, ped);
        }

        public static bool IS_PED_CUFFED(int ped)
        {
            return Invoker.Call<bool>(0x74E559B3BC910685, ped);
        }

    }

    public static class GAMEPLAY
    {

        public static int GET_ALLOCATED_STACK_SIZE()
        {
            return Invoker.Call<int>(0x8B3CA62B1EF19B62);
        }

        public static int _GET_FREE_STACK_SLOTS_COUNT(int threadId)
        {
            return Invoker.Call<int>(0xFEAD16FC8F9DFC0F, threadId);
        }

        public static void SET_RANDOM_SEED(int time)
        {
            Invoker.Call<Void>(0x444D98F98C11F3EC, time);
        }

        public static void SET_TIME_SCALE(float time)
        {
            Invoker.Call<Void>(0x1D408577D440E81E, time);
        }

        public static void SET_MISSION_FLAG(bool toggle)
        {
            Invoker.Call<Void>(0xC4301E5121A0ED73, toggle);
        }

        public static bool GET_MISSION_FLAG()
        {
            return Invoker.Call<bool>(0xA33CDCCDA663159E);
        }

        public static void SET_RANDOM_EVENT_FLAG(int p0)
        {
            Invoker.Call<Void>(0x971927086CFD2158, p0);
        }

        public static int GET_RANDOM_EVENT_FLAG()
        {
            return Invoker.Call<int>(0xD2D57F1D764117B1);
        }

        public static string _GET_GLOBAL_CHAR_BUFFER()
        {
            return Invoker.Call<string>(0x24DA7D7667FD7B09);
        }

        public static void _0x4DCDF92BF64236CD(string p0, string p1)
        {
            Invoker.Call<Void>(0x4DCDF92BF64236CD, p0, p1);
        }

        public static void _0x31125FD509D9043F(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x31125FD509D9043F, p0_ptr);
        }

        public static void _0xEBD3205A207939ED(ulong p0_ptr)
        {
            Invoker.Call<Void>(0xEBD3205A207939ED, p0_ptr);
        }

        public static void _0x97E7E2C04245115B(int p0)
        {
            Invoker.Call<Void>(0x97E7E2C04245115B, p0);
        }

        public static void _0xEB078CA2B5E82ADD(int p0, int p1)
        {
            Invoker.Call<Void>(0xEB078CA2B5E82ADD, p0, p1);
        }

        public static void _0x703CC7F60CBB2B57(int p0)
        {
            Invoker.Call<Void>(0x703CC7F60CBB2B57, p0);
        }

        public static void _0x8951EB9C6906D3C8()
        {
            Invoker.Call<Void>(0x8951EB9C6906D3C8);
        }

        public static void _0xBA4B8D83BDC75551(int p0)
        {
            Invoker.Call<Void>(0xBA4B8D83BDC75551, p0);
        }

        public static bool _0xE8B9C0EC9E183F35()
        {
            return Invoker.Call<bool>(0xE8B9C0EC9E183F35);
        }

        public static void _0x65D2EBB47E1CEC21(bool p0)
        {
            Invoker.Call<Void>(0x65D2EBB47E1CEC21, p0);
        }

        public static void _0x6F2135B6129620C1(bool p0)
        {
            Invoker.Call<Void>(0x6F2135B6129620C1, p0);
        }

        public static void _0x8D74E26F54B4E5C3(string p0)
        {
            Invoker.Call<Void>(0x8D74E26F54B4E5C3, p0);
        }

        public static bool _0xB335F761606DB47C(ulong p1_ptr, ulong p2_ptr, int p3, bool p4)
        {
            return Invoker.Call<bool>(0xB335F761606DB47C, p1_ptr, p2_ptr, p3, p4);
        }

        public static int GET_PREV_WEATHER_TYPE_HASH_NAME()
        {
            return Invoker.Call<int>(0x564B884A05EC45A3);
        }

        public static int GET_NEXT_WEATHER_TYPE_HASH_NAME()
        {
            return Invoker.Call<int>(0x711327CD09C8F162);
        }

        public static bool IS_PREV_WEATHER_TYPE(string weatherType)
        {
            return Invoker.Call<bool>(0x44F28F86433B10A9, weatherType);
        }

        public static bool IS_NEXT_WEATHER_TYPE(string weatherType)
        {
            return Invoker.Call<bool>(0x2FAA3A30BEC0F25D, weatherType);
        }

        public static void SET_WEATHER_TYPE_PERSIST(string weatherType)
        {
            Invoker.Call<Void>(0x704983DF373B198F, weatherType);
        }

        public static void SET_WEATHER_TYPE_NOW_PERSIST(string weatherType)
        {
            Invoker.Call<Void>(0xED712CA327900C8A, weatherType);
        }

        public static void SET_WEATHER_TYPE_NOW(string weatherType)
        {
            Invoker.Call<Void>(0x29B487C359E19889, weatherType);
        }

        public static void _SET_WEATHER_TYPE_OVER_TIME(string weatherType, float time)
        {
            Invoker.Call<Void>(0xFB5045B7C42B75BF, weatherType, time);
        }

        public static void SET_RANDOM_WEATHER_TYPE()
        {
            Invoker.Call<Void>(0x8B05F884CF7E8020);
        }

        public static void CLEAR_WEATHER_TYPE_PERSIST()
        {
            Invoker.Call<Void>(0xCCC39339BEF76CF5);
        }

        public static void _GET_WEATHER_TYPE_TRANSITION(ulong weatherType1_ptr, ulong weatherType2_ptr, ulong percentWeather2_ptr)
        {
            Invoker.Call<Void>(0xF3BBE884A14BB413, weatherType1_ptr, weatherType2_ptr, percentWeather2_ptr);
        }

        public static void _SET_WEATHER_TYPE_TRANSITION(int weatherType1, int weatherType2, float percentWeather2)
        {
            Invoker.Call<Void>(0x578C752848ECFA0C, weatherType1, weatherType2, percentWeather2);
        }

        public static void SET_OVERRIDE_WEATHER(string weatherType)
        {
            Invoker.Call<Void>(0xA43D5C6FE51ADBEF, weatherType);
        }

        public static void CLEAR_OVERRIDE_WEATHER()
        {
            Invoker.Call<Void>(0x338D2E3477711050);
        }

        public static void _0xB8F87EAD7533B176(float p0)
        {
            Invoker.Call<Void>(0xB8F87EAD7533B176, p0);
        }

        public static void _0xC3EAD29AB273ECE8(float p0)
        {
            Invoker.Call<Void>(0xC3EAD29AB273ECE8, p0);
        }

        public static void _0xA7A1127490312C36(float p0)
        {
            Invoker.Call<Void>(0xA7A1127490312C36, p0);
        }

        public static void _0x31727907B2C43C55(float p0)
        {
            Invoker.Call<Void>(0x31727907B2C43C55, p0);
        }

        public static void _0x405591EC8FD9096D(float p0)
        {
            Invoker.Call<Void>(0x405591EC8FD9096D, p0);
        }

        public static void _0xF751B16FB32ABC1D(float p0)
        {
            Invoker.Call<Void>(0xF751B16FB32ABC1D, p0);
        }

        public static void _0xB3E6360DDE733E82(float p0)
        {
            Invoker.Call<Void>(0xB3E6360DDE733E82, p0);
        }

        public static void _0x7C9C0B1EEB1F9072(float p0)
        {
            Invoker.Call<Void>(0x7C9C0B1EEB1F9072, p0);
        }

        public static void _0x6216B116083A7CB4(float p0)
        {
            Invoker.Call<Void>(0x6216B116083A7CB4, p0);
        }

        public static void _0x9F5E6BB6B34540DA(float p0)
        {
            Invoker.Call<Void>(0x9F5E6BB6B34540DA, p0);
        }

        public static void _0xB9854DFDE0D833D6(float p0)
        {
            Invoker.Call<Void>(0xB9854DFDE0D833D6, p0);
        }

        public static void _0xC54A08C85AE4D410(float p0)
        {
            Invoker.Call<Void>(0xC54A08C85AE4D410, p0);
        }

        public static void _0xA8434F1DFF41D6E7(float p0)
        {
            Invoker.Call<Void>(0xA8434F1DFF41D6E7, p0);
        }

        public static void _0xC3C221ADDDE31A11(float p0)
        {
            Invoker.Call<Void>(0xC3C221ADDDE31A11, p0);
        }

        public static void SET_WIND(float speed)
        {
            Invoker.Call<Void>(0xAC3A74E8384A9919, speed);
        }

        public static void SET_WIND_SPEED(float speed)
        {
            Invoker.Call<Void>(0xEE09ECEDBABE47FC, speed);
        }

        public static float GET_WIND_SPEED()
        {
            return Invoker.Call<float>(0xA8CF1CC0AFCD3F12);
        }

        public static void SET_WIND_DIRECTION(float direction)
        {
            Invoker.Call<Void>(0xEB0F4468467B4528, direction);
        }

        public static Vector3 GET_WIND_DIRECTION()
        {
            return Invoker.Call<Vector3>(0x1F400FEF721170DA);
        }

        public static void _SET_RAIN_FX_INTENSITY(float intensity)
        {
            Invoker.Call<Void>(0x643E26EA6E024D92, intensity);
        }

        public static ulong GET_RAIN_LEVEL()
        {
            return Invoker.Call<ulong>(0x96695E368AD855F3);
        }

        public static int GET_SNOW_LEVEL()
        {
            return Invoker.Call<int>(0xC5868A966E5BE3AE);
        }

        public static void _CREATE_LIGHTNING_THUNDER()
        {
            Invoker.Call<Void>(0xF6062E089251C898);
        }

        public static void _0x02DEAAC8F8EA7FE7(string p0)
        {
            Invoker.Call<Void>(0x02DEAAC8F8EA7FE7, p0);
        }

        public static void _0x11B56FBBF7224868(string p0)
        {
            Invoker.Call<Void>(0x11B56FBBF7224868, p0);
        }

        public static void _SET_CLOUD_HAT_TRANSITION(string type, float transitionTime)
        {
            Invoker.Call<Void>(0xFC4842A34657BFCB, type, transitionTime);
        }

        public static void _0xA74802FB8D0B7814(string p0, float p1)
        {
            Invoker.Call<Void>(0xA74802FB8D0B7814, p0, p1);
        }

        public static void _CLEAR_CLOUD_HAT()
        {
            Invoker.Call<Void>(0x957E790EA1727B64);
        }

        public static void _SET_CLOUD_HAT_OPACITY(float opacity)
        {
            Invoker.Call<Void>(0xF36199225D6D8C86, opacity);
        }

        public static float _GET_CLOUD_HAT_OPACITY()
        {
            return Invoker.Call<float>(0x20AC25E781AE4A84);
        }

        public static int GET_GAME_TIMER()
        {
            return Invoker.Call<int>(0x9CD27B0045628463);
        }

        public static float GET_FRAME_TIME()
        {
            return Invoker.Call<float>(0x15C40837039FFAF7);
        }

        public static float _GET_BENCHMARK_TIME()
        {
            return Invoker.Call<float>(0xE599A503B3837E1B);
        }

        public static int GET_FRAME_COUNT()
        {
            return Invoker.Call<int>(0xFC8202EFC642E6F2);
        }

        public static float GET_RANDOM_FLOAT_IN_RANGE(float startRange, float endRange)
        {
            return Invoker.Call<float>(0x313CE5879CEB6FCD, startRange, endRange);
        }

        public static int GET_RANDOM_INT_IN_RANGE(int startRange, int endRange)
        {
            return Invoker.Call<int>(0xD53343AA4FB7DD28, startRange, endRange);
        }

        public static bool GET_GROUND_Z_FOR_3D_COORD(float x, float y, float z, ulong groundZ_ptr, bool unk)
        {
            return Invoker.Call<bool>(0xC906A7DAB05C8D2B, x, y, z, groundZ_ptr, unk);
        }

        public static bool _GET_GROUND_Z_COORD_WITH_OFFSETS(float x, float y, float z, ulong groundZ_ptr, ulong offsets_ptr)
        {
            return Invoker.Call<bool>(0x8BDC7BFC57A81E76, x, y, z, groundZ_ptr, offsets_ptr);
        }

        public static float ASIN(float p0)
        {
            return Invoker.Call<float>(0xC843060B5765DCE7, p0);
        }

        public static float ACOS(float p0)
        {
            return Invoker.Call<float>(0x1D08B970013C34B6, p0);
        }

        public static float TAN(float p0)
        {
            return Invoker.Call<float>(0x632106CC96E82E91, p0);
        }

        public static float ATAN(float p0)
        {
            return Invoker.Call<float>(0xA9D1795CD5043663, p0);
        }

        public static float ATAN2(float p0, float p1)
        {
            return Invoker.Call<float>(0x8927CBF9D22261A4, p0, p1);
        }

        public static float GET_DISTANCE_BETWEEN_COORDS(float x1, float y1, float z1, float x2, float y2, float z2, bool useZ)
        {
            return Invoker.Call<float>(0xF1B760881820C952, x1, y1, z1, x2, y2, z2, useZ);
        }

        public static float GET_ANGLE_BETWEEN_2D_VECTORS(float x1, float y1, float x2, float y2)
        {
            return Invoker.Call<float>(0x186FC4BE848E1C92, x1, y1, x2, y2);
        }

        public static float GET_HEADING_FROM_VECTOR_2D(float dx, float dy)
        {
            return Invoker.Call<float>(0x2FFB6B224F4B2926, dx, dy);
        }

        public static float _0x7F8F6405F4777AF6(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9)
        {
            return Invoker.Call<float>(0x7F8F6405F4777AF6, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        public static Vector3 _0x21C235BC64831E5A(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9)
        {
            return Invoker.Call<Vector3>(0x21C235BC64831E5A, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        public static bool _0xF56DFB7B61BE7276(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, ulong p12_ptr)
        {
            return Invoker.Call<bool>(0xF56DFB7B61BE7276, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12_ptr);
        }

        public static void SET_BIT(ulong address_ptr, int offset)
        {
            Invoker.Call<Void>(0x933D6A9EEC1BACD0, address_ptr, offset);
        }

        public static void CLEAR_BIT(ulong address_ptr, int offset)
        {
            Invoker.Call<Void>(0xE80492A9AC099A93, address_ptr, offset);
        }

        public static int GET_HASH_KEY(string _string)
        {
            return Invoker.Call<int>(0xD24D37CC275948CC, _string);
        }

        public static void _0xF2F6A2FA49278625(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, ulong p9_ptr, ulong p10_ptr, ulong p11_ptr, ulong p12_ptr)
        {
            Invoker.Call<Void>(0xF2F6A2FA49278625, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9_ptr, p10_ptr, p11_ptr, p12_ptr);
        }

        public static bool IS_AREA_OCCUPIED(float p0, float p1, float p2, float p3, float p4, float p5, bool p6, bool p7, bool p8, bool p9, bool p10, int p11, bool p12)
        {
            return Invoker.Call<bool>(0xA61B4DF533DCB56E, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }

        public static bool IS_POSITION_OCCUPIED(float x, float y, float z, float range, bool p4, bool p5, bool p6, bool p7, bool p8, int p9, bool p10)
        {
            return Invoker.Call<bool>(0xADCDE75E1C60F32D, x, y, z, range, p4, p5, p6, p7, p8, p9, p10);
        }

        public static bool IS_POINT_OBSCURED_BY_A_MISSION_ENTITY(float p0, float p1, float p2, float p3, float p4, float p5, int p6)
        {
            return Invoker.Call<bool>(0xE54E209C35FFA18D, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void CLEAR_AREA(float X, float Y, float Z, float radius, bool p4, bool ignoreCopCars, bool ignoreObjects, bool p7)
        {
            Invoker.Call<Void>(0xA56F01F3765B93A0, X, Y, Z, radius, p4, ignoreCopCars, ignoreObjects, p7);
        }

        public static void _CLEAR_AREA_OF_EVERYTHING(float x, float y, float z, float radius, bool p4, bool p5, bool p6, bool p7)
        {
            Invoker.Call<Void>(0x957838AAF91BD12D, x, y, z, radius, p4, p5, p6, p7);
        }

        public static void CLEAR_AREA_OF_VEHICLES(float x, float y, float z, float radius, bool p4, bool p5, bool p6, bool p7, bool p8)
        {
            Invoker.Call<Void>(0x01C7B9B38428AEB6, x, y, z, radius, p4, p5, p6, p7, p8);
        }

        public static void CLEAR_ANGLED_AREA_OF_VEHICLES(float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, bool p8, bool p9, bool p10, bool p11)
        {
            Invoker.Call<Void>(0x11DB3500F042A8AA, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        public static void CLEAR_AREA_OF_OBJECTS(float x, float y, float z, float radius, int flags)
        {
            Invoker.Call<Void>(0xDD9B9B385AAC7F5B, x, y, z, radius, flags);
        }

        public static void CLEAR_AREA_OF_PEDS(float x, float y, float z, float radius, int flags)
        {
            Invoker.Call<Void>(0xBE31FD6CE464AC59, x, y, z, radius, flags);
        }

        public static void CLEAR_AREA_OF_COPS(float x, float y, float z, float radius, int flags)
        {
            Invoker.Call<Void>(0x04F8FC8FCF58F88D, x, y, z, radius, flags);
        }

        public static void CLEAR_AREA_OF_PROJECTILES(float x, float y, float z, float radius, bool isNetworkGame)
        {
            Invoker.Call<Void>(0x0A1CB9094635D1A6, x, y, z, radius, isNetworkGame);
        }

        public static void _0x7EC6F9A478A6A512()
        {
            Invoker.Call<Void>(0x7EC6F9A478A6A512);
        }

        public static void SET_SAVE_MENU_ACTIVE(bool unk)
        {
            Invoker.Call<Void>(0xC9BF75D28165FF77, unk);
        }

        public static int _0x397BAA01068BAA96()
        {
            return Invoker.Call<int>(0x397BAA01068BAA96);
        }

        public static void SET_CREDITS_ACTIVE(bool toggle)
        {
            Invoker.Call<Void>(0xB938B7E6D3C0620C, toggle);
        }

        public static void _0xB51B9AB9EF81868C(bool toggle)
        {
            Invoker.Call<Void>(0xB51B9AB9EF81868C, toggle);
        }

        public static int _0x075F1D57402C93BA()
        {
            return Invoker.Call<int>(0x075F1D57402C93BA);
        }

        public static void TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME(string scriptName)
        {
            Invoker.Call<Void>(0x9DC711BC69C548DF, scriptName);
        }

        public static void NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME()
        {
            Invoker.Call<Void>(0x9243BAC96D64C050);
        }

        public static int ADD_HOSPITAL_RESTART(float x, float y, float z, float p3, int p4)
        {
            return Invoker.Call<int>(0x1F464EF988465A81, x, y, z, p3, p4);
        }

        public static void DISABLE_HOSPITAL_RESTART(int hospitalIndex, bool toggle)
        {
            Invoker.Call<Void>(0xC8535819C450EBA8, hospitalIndex, toggle);
        }

        public static int ADD_POLICE_RESTART(float p0, float p1, float p2, float p3, int p4)
        {
            return Invoker.Call<int>(0x452736765B31FC4B, p0, p1, p2, p3, p4);
        }

        public static void DISABLE_POLICE_RESTART(int policeIndex, bool toggle)
        {
            Invoker.Call<Void>(0x23285DED6EBD7EA3, policeIndex, toggle);
        }

        public static void _SET_CUSTOM_RESPAWN_POSITION(float x, float y, float z, float heading)
        {
            Invoker.Call<Void>(0x706B5EDCAA7FA663, x, y, z, heading);
        }

        public static void _SET_NEXT_RESPAWN_TO_CUSTOM()
        {
            Invoker.Call<Void>(0xA2716D40842EAF79);
        }

        public static void _DISABLE_AUTOMATIC_RESPAWN(bool disableRespawn)
        {
            Invoker.Call<Void>(0x2C2B3493FBF51C71, disableRespawn);
        }

        public static void IGNORE_NEXT_RESTART(bool toggle)
        {
            Invoker.Call<Void>(0x21FFB63D8C615361, toggle);
        }

        public static void SET_FADE_OUT_AFTER_DEATH(bool toggle)
        {
            Invoker.Call<Void>(0x4A18E01DF2C87B86, toggle);
        }

        public static void SET_FADE_OUT_AFTER_ARREST(bool toggle)
        {
            Invoker.Call<Void>(0x1E0B4DC0D990A4E7, toggle);
        }

        public static void SET_FADE_IN_AFTER_DEATH_ARREST(bool toggle)
        {
            Invoker.Call<Void>(0xDA66D2796BA33F12, toggle);
        }

        public static void SET_FADE_IN_AFTER_LOAD(bool toggle)
        {
            Invoker.Call<Void>(0xF3D78F59DFE18D79, toggle);
        }

        public static int REGISTER_SAVE_HOUSE(float p0, float p1, float p2, float p3, ulong p4_ptr, int p5, int p6)
        {
            return Invoker.Call<int>(0xC0714D0A7EEECA54, p0, p1, p2, p3, p4_ptr, p5, p6);
        }

        public static void SET_SAVE_HOUSE(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x4F548CABEAE553BC, p0, p1, p2);
        }

        public static bool OVERRIDE_SAVE_HOUSE(bool p0, float p1, float p2, float p3, float p4, bool p5, float p6, float p7)
        {
            return Invoker.Call<bool>(0x1162EA8AE9D24EEA, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static int _0xA4A0065E39C9F25C(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xA4A0065E39C9F25C, p0, p1, p2, p3);
        }

        public static void DO_AUTO_SAVE()
        {
            Invoker.Call<Void>(0x50EEAAD86232EE55);
        }

        public static int _0x6E04F06094C87047()
        {
            return Invoker.Call<int>(0x6E04F06094C87047);
        }

        public static bool IS_AUTO_SAVE_IN_PROGRESS()
        {
            return Invoker.Call<bool>(0x69240733738C19A0);
        }

        public static int _0x2107A3773771186D()
        {
            return Invoker.Call<int>(0x2107A3773771186D);
        }

        public static void _0x06462A961E94B67C()
        {
            Invoker.Call<Void>(0x06462A961E94B67C);
        }

        public static void BEGIN_REPLAY_STATS(int p0, int p1)
        {
            Invoker.Call<Void>(0xE0E500246FF73D66, p0, p1);
        }

        public static void _0x69FE6DC87BD2A5E9(int p0)
        {
            Invoker.Call<Void>(0x69FE6DC87BD2A5E9, p0);
        }

        public static void END_REPLAY_STATS()
        {
            Invoker.Call<Void>(0xA23E821FBDF8A5F2);
        }

        public static int _0xD642319C54AADEB6()
        {
            return Invoker.Call<int>(0xD642319C54AADEB6);
        }

        public static int _0x5B1F2E327B6B6FE1()
        {
            return Invoker.Call<int>(0x5B1F2E327B6B6FE1);
        }

        public static int _0x2B626A0150E4D449()
        {
            return Invoker.Call<int>(0x2B626A0150E4D449);
        }

        public static int _0xDC9274A7EF6B2867()
        {
            return Invoker.Call<int>(0xDC9274A7EF6B2867);
        }

        public static int _0x8098C8D6597AAE18(int p0)
        {
            return Invoker.Call<int>(0x8098C8D6597AAE18, p0);
        }

        public static void CLEAR_REPLAY_STATS()
        {
            Invoker.Call<Void>(0x1B1AB132A16FDA55);
        }

        public static int _0x72DE52178C291CB5()
        {
            return Invoker.Call<int>(0x72DE52178C291CB5);
        }

        public static int _0x44A0BDC559B35F6E()
        {
            return Invoker.Call<int>(0x44A0BDC559B35F6E);
        }

        public static int _0xEB2104E905C6F2E9()
        {
            return Invoker.Call<int>(0xEB2104E905C6F2E9);
        }

        public static int _0x2B5E102E4A42F2BF()
        {
            return Invoker.Call<int>(0x2B5E102E4A42F2BF);
        }

        public static bool IS_MEMORY_CARD_IN_USE()
        {
            return Invoker.Call<bool>(0x8A75CE2956274ADD);
        }

        public static void SHOOT_SINGLE_BULLET_BETWEEN_COORDS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, bool p7, int weaponHash, int ownerPed, bool isAudible, bool isInvisible, float speed)
        {
            Invoker.Call<Void>(0x867654CBC7606F2C, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed);
        }

        public static void _SHOOT_SINGLE_BULLET_BETWEEN_COORDS_PRESET_PARAMS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, bool p7, int weaponHash, int ownerPed, bool isAudible, bool isInvisible, float speed, int entity)
        {
            Invoker.Call<Void>(0xE3A7742E0B7A2F8B, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed, entity);
        }

        public static void _SHOOT_SINGLE_BULLET_BETWEEN_COORDS_WITH_EXTRA_PARAMS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, bool p7, int weaponHash, int ownerPed, bool isAudible, bool isInvisible, float speed, int entity, bool p14, bool p15, bool p16, bool p17)
        {
            Invoker.Call<Void>(0xBFE5756E7407064A, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed, entity, p14, p15, p16, p17);
        }

        public static void GET_MODEL_DIMENSIONS(int modelHash, ulong minimum_ptr, ulong maximum_ptr)
        {
            Invoker.Call<Void>(0x03E8D3D5F549087A, modelHash, minimum_ptr, maximum_ptr);
        }

        public static void SET_FAKE_WANTED_LEVEL(int fakeWantedLevel)
        {
            Invoker.Call<Void>(0x1454F2448DE30163, fakeWantedLevel);
        }

        public static int GET_FAKE_WANTED_LEVEL()
        {
            return Invoker.Call<int>(0x4C9296CBCD1B971E);
        }

        public static bool IS_BIT_SET(int address, int offset)
        {
            return Invoker.Call<bool>(0xA921AA820C25702F, address, offset);
        }

        public static void USING_MISSION_CREATOR(bool toggle)
        {
            Invoker.Call<Void>(0xF14878FC50BEC6EE, toggle);
        }

        public static void _0xDEA36202FC3382DF(bool p0)
        {
            Invoker.Call<Void>(0xDEA36202FC3382DF, p0);
        }

        public static void SET_MINIGAME_IN_PROGRESS(bool toggle)
        {
            Invoker.Call<Void>(0x19E00D7322C6F85B, toggle);
        }

        public static bool IS_MINIGAME_IN_PROGRESS()
        {
            return Invoker.Call<bool>(0x2B4A15E44DE0F478);
        }

        public static bool IS_THIS_A_MINIGAME_SCRIPT()
        {
            return Invoker.Call<bool>(0x7B30F65D7B710098);
        }

        public static bool IS_SNIPER_INVERTED()
        {
            return Invoker.Call<bool>(0x61A23B7EDA9BDA24);
        }

        public static bool _0xD3D15555431AB793()
        {
            return Invoker.Call<bool>(0xD3D15555431AB793);
        }

        public static int GET_PROFILE_SETTING(int profileSetting)
        {
            return Invoker.Call<int>(0xC488FF2356EA7791, profileSetting);
        }

        public static bool ARE_STRINGS_EQUAL(string _string1, string _string2)
        {
            return Invoker.Call<bool>(0x0C515FAB3FF9EA92, _string1, _string2);
        }

        public static int COMPARE_STRINGS(string str1, string str2, bool matchCase, int maxLength)
        {
            return Invoker.Call<int>(0x1E34710ECD4AB0EB, str1, str2, matchCase, maxLength);
        }

        public static int ABSI(int value)
        {
            return Invoker.Call<int>(0xF0D31AD191A74F87, value);
        }

        public static float ABSF(float value)
        {
            return Invoker.Call<float>(0x73D57CFFDD12C355, value);
        }

        public static bool IS_SNIPER_BULLET_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<bool>(0xFEFCF11B01287125, x1, y1, z1, x2, y2, z2);
        }

        public static bool IS_PROJECTILE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool ownedByPlayer)
        {
            return Invoker.Call<bool>(0x5270A8FBC098C3F8, x1, y1, z1, x2, y2, z2, ownedByPlayer);
        }

        public static bool IS_PROJECTILE_TYPE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, int type, bool p7)
        {
            return Invoker.Call<bool>(0x2E0DC353342C4A6D, x1, y1, z1, x2, y2, z2, type, p7);
        }

        public static bool IS_PROJECTILE_TYPE_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, int p7, bool p8)
        {
            return Invoker.Call<bool>(0xF0BC12401061DEA0, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static bool _IS_PROJECTILE_TYPE_IN_RADIUS(float x, float y, float z, int projHash, float radius, bool ownedByPlayer)
        {
            return Invoker.Call<bool>(0x34318593248C8FB2, x, y, z, projHash, radius, ownedByPlayer);
        }

        public static bool _GET_IS_PROJECTILE_TYPE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, int projHash, ulong projPos_ptr, bool ownedByPlayer)
        {
            return Invoker.Call<bool>(0x8D7A43EC6A5FEA45, x1, y1, z1, x2, y2, z2, projHash, projPos_ptr, ownedByPlayer);
        }

        public static bool _GET_PROJECTILE_NEAR_PED_COORDS(int ped, int projHash, float radius, ulong projPos_ptr, bool ownedByPlayer)
        {
            return Invoker.Call<bool>(0xDFB4138EEFED7B81, ped, projHash, radius, projPos_ptr, ownedByPlayer);
        }

        public static bool _GET_PROJECTILE_NEAR_PED(int ped, int projHash, float radius, ulong projPos_ptr, ulong projEnt_ptr, bool ownedByPlayer)
        {
            return Invoker.Call<bool>(0x82FDE6A57EE4EE44, ped, projHash, radius, projPos_ptr, projEnt_ptr, ownedByPlayer);
        }

        public static bool IS_BULLET_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7)
        {
            return Invoker.Call<bool>(0x1A8B5F3C01E2B477, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static bool IS_BULLET_IN_AREA(float p0, float p1, float p2, float p3, bool p4)
        {
            return Invoker.Call<bool>(0x3F2023999AD51C1F, p0, p1, p2, p3, p4);
        }

        public static bool IS_BULLET_IN_BOX(float p0, float p1, float p2, float p3, float p4, float p5, bool p6)
        {
            return Invoker.Call<bool>(0xDE0F6D7450D37351, p0, p1, p2, p3, p4, p5, p6);
        }

        public static bool HAS_BULLET_IMPACTED_IN_AREA(float x, float y, float z, float p3, bool p4, bool p5)
        {
            return Invoker.Call<bool>(0x9870ACFB89A90995, x, y, z, p3, p4, p5);
        }

        public static bool HAS_BULLET_IMPACTED_IN_BOX(float p0, float p1, float p2, float p3, float p4, float p5, bool p6, bool p7)
        {
            return Invoker.Call<bool>(0xDC8C5D7CFEAB8394, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static bool IS_ORBIS_VERSION()
        {
            return Invoker.Call<bool>(0xA72BC0B675B1519E);
        }

        public static bool IS_DURANGO_VERSION()
        {
            return Invoker.Call<bool>(0x4D982ADB1978442D);
        }

        public static bool IS_XBOX360_VERSION()
        {
            return Invoker.Call<bool>(0xF6201B4DAF662A9D);
        }

        public static bool IS_PS3_VERSION()
        {
            return Invoker.Call<bool>(0xCCA1072C29D096C2);
        }

        public static bool IS_PC_VERSION()
        {
            return Invoker.Call<bool>(0x48AF36444B965238);
        }

        public static bool IS_AUSSIE_VERSION()
        {
            return Invoker.Call<bool>(0x9F1935CA1F724008);
        }

        public static bool IS_STRING_NULL(string _string)
        {
            return Invoker.Call<bool>(0xF22B6C47C6EAB066, _string);
        }

        public static bool IS_STRING_NULL_OR_EMPTY(string _string)
        {
            return Invoker.Call<bool>(0xCA042B6957743895, _string);
        }

        public static bool STRING_TO_INT(string _string, ulong _outInteger_ptr)
        {
            return Invoker.Call<bool>(0x5A5F40FE637EB584, _string, _outInteger_ptr);
        }

        public static void SET_BITS_IN_RANGE(ulong var_ptr, int rangeStart, int rangeEnd, int p3)
        {
            Invoker.Call<Void>(0x8EF07E15701D61ED, var_ptr, rangeStart, rangeEnd, p3);
        }

        public static int GET_BITS_IN_RANGE(int var, int rangeStart, int rangeEnd)
        {
            return Invoker.Call<int>(0x53158863FCC0893A, var, rangeStart, rangeEnd);
        }

        public static int ADD_STUNT_JUMP(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12, float p13, float p14, int p15, int p16)
        {
            return Invoker.Call<int>(0x1A992DA297A4630C, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }

        public static int ADD_STUNT_JUMP_ANGLED(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12, float p13, float p14, float p15, float p16, int p17, int p18)
        {
            return Invoker.Call<int>(0xBBE5D803A5360CBF, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18);
        }

        public static void DELETE_STUNT_JUMP(int p0)
        {
            Invoker.Call<Void>(0xDC518000E39DAE1F, p0);
        }

        public static void ENABLE_STUNT_JUMP_SET(int p0)
        {
            Invoker.Call<Void>(0xE369A5783B866016, p0);
        }

        public static void DISABLE_STUNT_JUMP_SET(int p0)
        {
            Invoker.Call<Void>(0xA5272EBEDD4747F6, p0);
        }

        public static void _0xD79185689F8FD5DF(bool p0)
        {
            Invoker.Call<Void>(0xD79185689F8FD5DF, p0);
        }

        public static bool IS_STUNT_JUMP_IN_PROGRESS()
        {
            return Invoker.Call<bool>(0x7A3F19700A4D0525);
        }

        public static bool IS_STUNT_JUMP_MESSAGE_SHOWING()
        {
            return Invoker.Call<bool>(0x2272B0A1343129F4);
        }

        public static int _0x996DD1E1E02F1008()
        {
            return Invoker.Call<int>(0x996DD1E1E02F1008);
        }

        public static int _0x6856EC3D35C81EA4()
        {
            return Invoker.Call<int>(0x6856EC3D35C81EA4);
        }

        public static void CANCEL_STUNT_JUMP()
        {
            Invoker.Call<Void>(0xE6B7B0ACD4E4B75E);
        }

        public static void SET_GAME_PAUSED(bool toggle)
        {
            Invoker.Call<Void>(0x577D1284D6873711, toggle);
        }

        public static void SET_THIS_SCRIPT_CAN_BE_PAUSED(bool toggle)
        {
            Invoker.Call<Void>(0xAA391C728106F7AF, toggle);
        }

        public static void SET_THIS_SCRIPT_CAN_REMOVE_BLIPS_CREATED_BY_ANY_SCRIPT(bool toggle)
        {
            Invoker.Call<Void>(0xB98236CAAECEF897, toggle);
        }

        public static bool _HAS_BUTTON_COMBINATION_JUST_BEEN_ENTERED(int hash, int amount)
        {
            return Invoker.Call<bool>(0x071E2A839DE82D90, hash, amount);
        }

        public static bool _HAS_CHEAT_STRING_JUST_BEEN_ENTERED(int hash)
        {
            return Invoker.Call<bool>(0x557E43C447E700A8, hash);
        }

        public static void _USE_FREEMODE_MAP_BEHAVIOR(bool toggle)
        {
            Invoker.Call<Void>(0x9BAE5AD2508DF078, toggle);
        }

        public static void _SET_UNK_MAP_FLAG(int flag)
        {
            Invoker.Call<Void>(0xC5F0A8EBD3F361CE, flag);
        }

        public static bool IS_FRONTEND_FADING()
        {
            return Invoker.Call<bool>(0x7EA2B6AF97ECA6ED);
        }

        public static void POPULATE_NOW()
        {
            Invoker.Call<Void>(0x7472BB270D7B4F3E);
        }

        public static int GET_INDEX_OF_CURRENT_LEVEL()
        {
            return Invoker.Call<int>(0xCBAD6729F7B1F4FC);
        }

        public static void SET_GRAVITY_LEVEL(int level)
        {
            Invoker.Call<Void>(0x740E14FAD5842351, level);
        }

        public static void START_SAVE_DATA(ulong p0_ptr, int p1, bool p2)
        {
            Invoker.Call<Void>(0xA9575F812C6A7997, p0_ptr, p1, p2);
        }

        public static void STOP_SAVE_DATA()
        {
            Invoker.Call<Void>(0x74E20C9145FB66FD);
        }

        public static int _0xA09F896CE912481F(bool p0)
        {
            return Invoker.Call<int>(0xA09F896CE912481F, p0);
        }

        public static void REGISTER_INT_TO_SAVE(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0x34C9EE5986258415, p0_ptr, name);
        }

        public static void _0xA735353C77334EA0(ulong p0_ptr, ulong p1_ptr)
        {
            Invoker.Call<Void>(0xA735353C77334EA0, p0_ptr, p1_ptr);
        }

        public static void REGISTER_ENUM_TO_SAVE(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0x10C2FA78D0E128A1, p0_ptr, name);
        }

        public static void REGISTER_FLOAT_TO_SAVE(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0x7CAEC29ECB5DFEBB, p0_ptr, name);
        }

        public static void REGISTER_BOOL_TO_SAVE(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0xC8F4131414C835A1, p0_ptr, name);
        }

        public static void REGISTER_TEXT_LABEL_TO_SAVE(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0xEDB1232C5BEAE62F, p0_ptr, name);
        }

        public static void _0x6F7794F28C6B2535(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0x6F7794F28C6B2535, p0_ptr, name);
        }

        public static void _0x48F069265A0E4BEC(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0x48F069265A0E4BEC, p0_ptr, name);
        }

        public static void _0x8269816F6CFD40F8(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0x8269816F6CFD40F8, p0_ptr, name);
        }

        public static void _0xFAA457EF263E8763(ulong p0_ptr, string name)
        {
            Invoker.Call<Void>(0xFAA457EF263E8763, p0_ptr, name);
        }

        public static void _START_SAVE_STRUCT(ulong p0_ptr, int p1, string structName)
        {
            Invoker.Call<Void>(0xBF737600CDDBEADD, p0_ptr, p1, structName);
        }

        public static void STOP_SAVE_STRUCT()
        {
            Invoker.Call<Void>(0xEB1774DF12BB9F12);
        }

        public static void _START_SAVE_ARRAY(ulong p0_ptr, int p1, string arrayName)
        {
            Invoker.Call<Void>(0x60FE567DF1B1AF9D, p0_ptr, p1, arrayName);
        }

        public static void STOP_SAVE_ARRAY()
        {
            Invoker.Call<Void>(0x04456F95153C6BE4);
        }

        public static void ENABLE_DISPATCH_SERVICE(int dispatchService, bool toggle)
        {
            Invoker.Call<Void>(0xDC0F817884CDD856, dispatchService, toggle);
        }

        public static void _0x9B2BD3773123EA2F(int type, bool toggle)
        {
            Invoker.Call<Void>(0x9B2BD3773123EA2F, type, toggle);
        }

        public static int _GET_NUMBER_OF_DISPATCHED_UNITS_FOR_PLAYER(int dispatchService)
        {
            return Invoker.Call<int>(0xEB4A0C2D56441717, dispatchService);
        }

        public static bool CREATE_INCIDENT(int incidentType, float x, float y, float z, int p5, float radius, ulong _outIncidentID_ptr)
        {
            return Invoker.Call<bool>(0x3F892CAF67444AE7, incidentType, x, y, z, p5, radius, _outIncidentID_ptr);
        }

        public static bool CREATE_INCIDENT_WITH_ENTITY(int incidentType, int ped, int amountOfPeople, float radius, ulong _outIncidentID_ptr)
        {
            return Invoker.Call<bool>(0x05983472F0494E60, incidentType, ped, amountOfPeople, radius, _outIncidentID_ptr);
        }

        public static void DELETE_INCIDENT(int incidentId)
        {
            Invoker.Call<Void>(0x556C1AA270D5A207, incidentId);
        }

        public static bool IS_INCIDENT_VALID(int incidentId)
        {
            return Invoker.Call<bool>(0xC8BC6461E629BEAA, incidentId);
        }

        public static void _0xB08B85D860E7BA3C(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0xB08B85D860E7BA3C, p0, p1, p2);
        }

        public static void _0xD261BA3E7E998072(int p0, float p1)
        {
            Invoker.Call<Void>(0xD261BA3E7E998072, p0, p1);
        }

        public static bool FIND_SPAWN_POINT_IN_DIRECTION(float x1, float y1, float z1, float x2, float y2, float z2, float distance, ulong spawnPoint_ptr)
        {
            return Invoker.Call<bool>(0x6874E2190B0C1972, x1, y1, z1, x2, y2, z2, distance, spawnPoint_ptr);
        }

        public static int _0x67F6413D3220E18D(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
        {
            return Invoker.Call<int>(0x67F6413D3220E18D, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static bool _0x1327E2FE9746BAEE(int p0)
        {
            return Invoker.Call<bool>(0x1327E2FE9746BAEE, p0);
        }

        public static void _0xB129E447A2EDA4BF(int p0, bool p1)
        {
            Invoker.Call<Void>(0xB129E447A2EDA4BF, p0, p1);
        }

        public static int _0x32C7A7E8C43A1F80(float p0, float p1, float p2, float p3, float p4, float p5, bool p6, bool p7)
        {
            return Invoker.Call<int>(0x32C7A7E8C43A1F80, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void _0xE6869BECDD8F2403(int p0, bool p1)
        {
            Invoker.Call<Void>(0xE6869BECDD8F2403, p0, p1);
        }

        public static void ENABLE_TENNIS_MODE(int ped, bool toggle, bool p2)
        {
            Invoker.Call<Void>(0x28A04B411933F8A6, ped, toggle, p2);
        }

        public static bool IS_TENNIS_MODE(int ped)
        {
            return Invoker.Call<bool>(0x5D5479D115290C3F, ped);
        }

        public static void _0xE266ED23311F24D4(int p0, ulong p1_ptr, ulong p2_ptr, float p3, float p4, bool p5)
        {
            Invoker.Call<Void>(0xE266ED23311F24D4, p0, p1_ptr, p2_ptr, p3, p4, p5);
        }

        public static bool _0x17DF68D720AA77F8(int p0)
        {
            return Invoker.Call<bool>(0x17DF68D720AA77F8, p0);
        }

        public static bool _0x19BFED045C647C49(int p0)
        {
            return Invoker.Call<bool>(0x19BFED045C647C49, p0);
        }

        public static bool _0xE95B0C7D5BA3B96B(int p0)
        {
            return Invoker.Call<bool>(0xE95B0C7D5BA3B96B, p0);
        }

        public static void _0x8FA9C42FC5D7C64B(int p0, int p1, float p2, float p3, float p4, bool p5)
        {
            Invoker.Call<Void>(0x8FA9C42FC5D7C64B, p0, p1, p2, p3, p4, p5);
        }

        public static void _0x54F157E0336A3822(int p0, string p1, float p2)
        {
            Invoker.Call<Void>(0x54F157E0336A3822, p0, p1, p2);
        }

        public static void _0xD10F442036302D50(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0xD10F442036302D50, p0, p1, p2);
        }

        public static void RESET_DISPATCH_IDEAL_SPAWN_DISTANCE()
        {
            Invoker.Call<Void>(0x77A84429DD9F0A15);
        }

        public static void SET_DISPATCH_IDEAL_SPAWN_DISTANCE(float p0)
        {
            Invoker.Call<Void>(0x6FE601A64180D423, p0);
        }

        public static void SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS(int p0, float p1)
        {
            Invoker.Call<Void>(0x44F7CBC1BEB3327D, p0, p1);
        }

        public static void SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS_MULTIPLIER(int p0, float p1)
        {
            Invoker.Call<Void>(0x48838ED9937A15D1, p0, p1);
        }

        public static int _0x918C7B2D2FF3928B(float p0, float p1, float p2, float p3, float p4, float p5, float p6)
        {
            return Invoker.Call<int>(0x918C7B2D2FF3928B, p0, p1, p2, p3, p4, p5, p6);
        }

        public static int _0x2D4259F1FEB81DA9(float p0, float p1, float p2, float p3)
        {
            return Invoker.Call<int>(0x2D4259F1FEB81DA9, p0, p1, p2, p3);
        }

        public static void REMOVE_DISPATCH_SPAWN_BLOCKING_AREA(int p0)
        {
            Invoker.Call<Void>(0x264AC28B01B353A5, p0);
        }

        public static void RESET_DISPATCH_SPAWN_BLOCKING_AREAS()
        {
            Invoker.Call<Void>(0xAC7BFD5C1D83EA75);
        }

        public static void _0xD9F692D349249528()
        {
            Invoker.Call<Void>(0xD9F692D349249528);
        }

        public static void _0xE532EC1A63231B4F(int p0, int p1)
        {
            Invoker.Call<Void>(0xE532EC1A63231B4F, p0, p1);
        }

        public static void _0xB8721407EE9C3FF6(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0xB8721407EE9C3FF6, p0, p1, p2);
        }

        public static void _0xB3CD58CCA6CDA852()
        {
            Invoker.Call<Void>(0xB3CD58CCA6CDA852);
        }

        public static void _0x2587A48BC88DFADF(bool p0)
        {
            Invoker.Call<Void>(0x2587A48BC88DFADF, p0);
        }

        public static void _DISPLAY_ONSCREEN_KEYBOARD_2(int p0, string windowTitle, ulong p2_ptr, string defaultText, string defaultConcat1, string defaultConcat2, string defaultConcat3, string defaultConcat4, string defaultConcat5, string defaultConcat6, string defaultConcat7, int maxInputLength)
        {
            Invoker.Call<Void>(0xCA78CFA0366592FE, p0, windowTitle, p2_ptr, defaultText, defaultConcat1, defaultConcat2, defaultConcat3, defaultConcat4, defaultConcat5, defaultConcat6, defaultConcat7, maxInputLength);
        }

        public static void DISPLAY_ONSCREEN_KEYBOARD(int p0, string windowTitle, string p2, string defaultText, string defaultConcat1, string defaultConcat2, string defaultConcat3, int maxInputLength)
        {
            Invoker.Call<Void>(0x00DC833F2568DBF6, p0, windowTitle, p2, defaultText, defaultConcat1, defaultConcat2, defaultConcat3, maxInputLength);
        }

        public static int UPDATE_ONSCREEN_KEYBOARD()
        {
            return Invoker.Call<int>(0x0CF2B696BBF945AE);
        }

        public static string GET_ONSCREEN_KEYBOARD_RESULT()
        {
            return Invoker.Call<string>(0x8362B09B91893647);
        }

        public static void _0x3ED1438C1F5C6612(int p0)
        {
            Invoker.Call<Void>(0x3ED1438C1F5C6612, p0);
        }

        public static void _REMOVE_STEALTH_KILL(int hash, bool p1)
        {
            Invoker.Call<Void>(0xA6A12939F16D85BE, hash, p1);
        }

        public static void _0x1EAE0A6E978894A2(int p0, bool p1)
        {
            Invoker.Call<Void>(0x1EAE0A6E978894A2, p0, p1);
        }

        public static void SET_EXPLOSIVE_AMMO_THIS_FRAME(int player)
        {
            Invoker.Call<Void>(0xA66C71C98D5F2CFB, player);
        }

        public static int SET_FIRE_AMMO_THIS_FRAME(int player)
        {
            return Invoker.Call<int>(0x11879CDD803D30F4, player);
        }

        public static int SET_EXPLOSIVE_MELEE_THIS_FRAME(int player)
        {
            return Invoker.Call<int>(0xFF1BED81BFDC0FE0, player);
        }

        public static void SET_SUPER_JUMP_THIS_FRAME(int player)
        {
            Invoker.Call<Void>(0x57FFF03E423A4C0B, player);
        }

        public static bool _0x6FDDF453C0C756EC()
        {
            return Invoker.Call<bool>(0x6FDDF453C0C756EC);
        }

        public static void _0xFB00CA71DA386228()
        {
            Invoker.Call<Void>(0xFB00CA71DA386228);
        }

        public static int _0x5AA3BEFA29F03AD4()
        {
            return Invoker.Call<int>(0x5AA3BEFA29F03AD4);
        }

        public static void _0xE3D969D2785FFB5E()
        {
            Invoker.Call<Void>(0xE3D969D2785FFB5E);
        }

        public static void _RESET_LOCALPLAYER_STATE()
        {
            Invoker.Call<Void>(0xC0AA53F866B3134D);
        }

        public static void _0x0A60017F841A54F2(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x0A60017F841A54F2, p0, p1, p2, p3);
        }

        public static void _0x1FF6BF9A63E5757F()
        {
            Invoker.Call<Void>(0x1FF6BF9A63E5757F);
        }

        public static void _0x1BB299305C3E8C13(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x1BB299305C3E8C13, p0, p1, p2, p3);
        }

        public static bool _0x8EF5573A1F801A5C(int p0, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x8EF5573A1F801A5C, p0, p1_ptr, p2_ptr);
        }

        public static void _0x92790862E36C2ADA()
        {
            Invoker.Call<Void>(0x92790862E36C2ADA);
        }

        public static void _0xC7DB36C24634F52B()
        {
            Invoker.Call<Void>(0xC7DB36C24634F52B);
        }

        public static void _0x437138B6A830166A()
        {
            Invoker.Call<Void>(0x437138B6A830166A);
        }

        public static void _0x37DEB0AA183FB6D8()
        {
            Invoker.Call<Void>(0x37DEB0AA183FB6D8);
        }

        public static int _0xEA2F2061875EED90()
        {
            return Invoker.Call<int>(0xEA2F2061875EED90);
        }

        public static int _0x3BBBD13E5041A79E()
        {
            return Invoker.Call<int>(0x3BBBD13E5041A79E);
        }

        public static bool _0xA049A5BE0F04F2F8()
        {
            return Invoker.Call<bool>(0xA049A5BE0F04F2F8);
        }

        public static int _0x4750FC27570311EC()
        {
            return Invoker.Call<int>(0x4750FC27570311EC);
        }

        public static int _0x1B2366C3F2A5C8DF()
        {
            return Invoker.Call<int>(0x1B2366C3F2A5C8DF);
        }

        public static void _FORCE_SOCIAL_CLUB_UPDATE()
        {
            Invoker.Call<Void>(0xEB6891F03362FB12);
        }

        public static int _0x14832BF2ABA53FC5()
        {
            return Invoker.Call<int>(0x14832BF2ABA53FC5);
        }

        public static void _0xC79AE21974B01FB2()
        {
            Invoker.Call<Void>(0xC79AE21974B01FB2);
        }

        public static bool _0x684A41975F077262()
        {
            return Invoker.Call<bool>(0x684A41975F077262);
        }

        public static int _0xABB2FA71C83A1B72()
        {
            return Invoker.Call<int>(0xABB2FA71C83A1B72);
        }

        public static void _SHOW_PED_IN_PAUSE_MENU(bool toggle)
        {
            Invoker.Call<Void>(0x4EBB7E87AA0DBED4, toggle);
        }

        public static bool _0x9689123E3F213AA5()
        {
            return Invoker.Call<bool>(0x9689123E3F213AA5);
        }

        public static void _0x9D8D44ADBBA61EF2(bool p0)
        {
            Invoker.Call<Void>(0x9D8D44ADBBA61EF2, p0);
        }

        public static void _0x23227DF0B2115469()
        {
            Invoker.Call<Void>(0x23227DF0B2115469);
        }

        public static int _0xD10282B6E3751BA0()
        {
            return Invoker.Call<int>(0xD10282B6E3751BA0);
        }

    }

    public static class AUDIO
    {

        public static void PLAY_PED_RINGTONE(string ringtoneName, int ped, bool p2)
        {
            Invoker.Call<Void>(0xF9E56683CA8E11A5, ringtoneName, ped, p2);
        }

        public static bool IS_PED_RINGTONE_PLAYING(int ped)
        {
            return Invoker.Call<bool>(0x1E8E5E20937E3137, ped);
        }

        public static void STOP_PED_RINGTONE(int ped)
        {
            Invoker.Call<Void>(0x6C5AE23EFA885092, ped);
        }

        public static bool IS_MOBILE_PHONE_CALL_ONGOING()
        {
            return Invoker.Call<bool>(0x7497D2CE2C30D24C);
        }

        public static int _0xC8B1B2425604CDD0()
        {
            return Invoker.Call<int>(0xC8B1B2425604CDD0);
        }

        public static void CREATE_NEW_SCRIPTED_CONVERSATION()
        {
            Invoker.Call<Void>(0xD2C91A0B572AAE56);
        }

        public static void ADD_LINE_TO_CONVERSATION(int p0, string p1, string p2, int p3, int p4, bool p5, bool p6, bool p7, bool p8, int p9, bool p10, bool p11, bool p12)
        {
            Invoker.Call<Void>(0xC5EF963405593646, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }

        public static void ADD_PED_TO_CONVERSATION(int pedIndex, int ped, string name)
        {
            Invoker.Call<Void>(0x95D9F4BC443956E7, pedIndex, ped, name);
        }

        public static void _0x33E3C6C6F2F0B506(int p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x33E3C6C6F2F0B506, p0, p1, p2, p3);
        }

        public static void _0x892B6AB8F33606F5(int p0, int p1)
        {
            Invoker.Call<Void>(0x892B6AB8F33606F5, p0, p1);
        }

        public static void SET_MICROPHONE_POSITION(bool p0, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3)
        {
            Invoker.Call<Void>(0xB6AE90EDDE95C762, p0, x1, y1, z1, x2, y2, z2, x3, y3, z3);
        }

        public static void _0x0B568201DD99F0EB(bool p0)
        {
            Invoker.Call<Void>(0x0B568201DD99F0EB, p0);
        }

        public static void _0x61631F5DF50D1C34(bool p0)
        {
            Invoker.Call<Void>(0x61631F5DF50D1C34, p0);
        }

        public static void START_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x252E5F915EABB675, p0, p1);
        }

        public static void PRELOAD_SCRIPT_PHONE_CONVERSATION(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x6004BCB0E226AAEA, p0, p1);
        }

        public static void START_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x6B17C62C9635D2DC, p0, p1, p2, p3);
        }

        public static void PRELOAD_SCRIPT_CONVERSATION(bool p0, bool p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x3B3CAD6166916D87, p0, p1, p2, p3);
        }

        public static void START_PRELOADED_CONVERSATION()
        {
            Invoker.Call<Void>(0x23641AFE870AF385);
        }

        public static int _0xE73364DB90778FFA()
        {
            return Invoker.Call<int>(0xE73364DB90778FFA);
        }

        public static bool IS_SCRIPTED_CONVERSATION_ONGOING()
        {
            return Invoker.Call<bool>(0x16754C556D2EDE3D);
        }

        public static bool IS_SCRIPTED_CONVERSATION_LOADED()
        {
            return Invoker.Call<bool>(0xDF0D54BE7A776737);
        }

        public static int GET_CURRENT_SCRIPTED_CONVERSATION_LINE()
        {
            return Invoker.Call<int>(0x480357EE890C295A);
        }

        public static void PAUSE_SCRIPTED_CONVERSATION(bool p0)
        {
            Invoker.Call<Void>(0x8530AD776CD72B12, p0);
        }

        public static void RESTART_SCRIPTED_CONVERSATION()
        {
            Invoker.Call<Void>(0x9AEB285D1818C9AC);
        }

        public static int STOP_SCRIPTED_CONVERSATION(bool p0)
        {
            return Invoker.Call<int>(0xD79DEEFB53455EBA, p0);
        }

        public static void SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE()
        {
            Invoker.Call<Void>(0x9663FE6B7A61EB00);
        }

        public static void INTERRUPT_CONVERSATION(int p0, ulong p1_ptr, ulong p2_ptr)
        {
            Invoker.Call<Void>(0xA018A12E5C5C2FA6, p0, p1_ptr, p2_ptr);
        }

        public static void _0x8A694D7A68F8DC38(int p0, string p1, string p2)
        {
            Invoker.Call<Void>(0x8A694D7A68F8DC38, p0, p1, p2);
        }

        public static int _0xAA19F5572C38B564(ulong p0_ptr)
        {
            return Invoker.Call<int>(0xAA19F5572C38B564, p0_ptr);
        }

        public static void _0xB542DE8C3D1CB210(bool p0)
        {
            Invoker.Call<Void>(0xB542DE8C3D1CB210, p0);
        }

        public static void REGISTER_SCRIPT_WITH_AUDIO(int p0)
        {
            Invoker.Call<Void>(0xC6ED9D5092438D91, p0);
        }

        public static void UNREGISTER_SCRIPT_WITH_AUDIO()
        {
            Invoker.Call<Void>(0xA8638BE228D4751A);
        }

        public static bool REQUEST_MISSION_AUDIO_BANK(string p0, bool p1)
        {
            return Invoker.Call<bool>(0x7345BDD95E62E0F2, p0, p1);
        }

        public static bool REQUEST_AMBIENT_AUDIO_BANK(string p0, bool p1)
        {
            return Invoker.Call<bool>(0xFE02FFBED8CA9D99, p0, p1);
        }

        public static bool REQUEST_SCRIPT_AUDIO_BANK(string p0, bool p1)
        {
            return Invoker.Call<bool>(0x2F844A8B08D76685, p0, p1);
        }

        public static int HINT_AMBIENT_AUDIO_BANK(int p0, int p1)
        {
            return Invoker.Call<int>(0x8F8C0E370AE62F5C, p0, p1);
        }

        public static int HINT_SCRIPT_AUDIO_BANK(int p0, int p1)
        {
            return Invoker.Call<int>(0xFB380A29641EC31A, p0, p1);
        }

        public static void RELEASE_MISSION_AUDIO_BANK()
        {
            Invoker.Call<Void>(0x0EC92A1BF0857187);
        }

        public static void RELEASE_AMBIENT_AUDIO_BANK()
        {
            Invoker.Call<Void>(0x65475A218FFAA93D);
        }

        public static void RELEASE_NAMED_SCRIPT_AUDIO_BANK(string audioBank)
        {
            Invoker.Call<Void>(0x77ED170667F50170, audioBank);
        }

        public static void RELEASE_SCRIPT_AUDIO_BANK()
        {
            Invoker.Call<Void>(0x7A2D8AD0A9EB9C3F);
        }

        public static void _0x19AF7ED9B9D23058()
        {
            Invoker.Call<Void>(0x19AF7ED9B9D23058);
        }

        public static void _0x9AC92EED5E4793AB()
        {
            Invoker.Call<Void>(0x9AC92EED5E4793AB);
        }

        public static int GET_SOUND_ID()
        {
            return Invoker.Call<int>(0x430386FE9BF80B45);
        }

        public static void RELEASE_SOUND_ID(int soundId)
        {
            Invoker.Call<Void>(0x353FC880830B88FA, soundId);
        }

        public static void PLAY_SOUND(int soundId, string audioName, string audioRef, bool p3, int p4, bool p5)
        {
            Invoker.Call<Void>(0x7FF4944CC209192D, soundId, audioName, audioRef, p3, p4, p5);
        }

        public static void PLAY_SOUND_FRONTEND(int soundId, string audioName, string audioRef, bool p3)
        {
            Invoker.Call<Void>(0x67C540AA08E4A6F5, soundId, audioName, audioRef, p3);
        }

        public static void _0xCADA5A0D0702381E(string p0, string soundset)
        {
            Invoker.Call<Void>(0xCADA5A0D0702381E, p0, soundset);
        }

        public static void PLAY_SOUND_FROM_ENTITY(int soundId, string audioName, int entity, string audioRef, bool p4, int p5)
        {
            Invoker.Call<Void>(0xE65F427EB70AB1ED, soundId, audioName, entity, audioRef, p4, p5);
        }

        public static void PLAY_SOUND_FROM_COORD(int soundId, string audioName, float x, float y, float z, string audioRef, bool p6, int range, bool p8)
        {
            Invoker.Call<Void>(0x8D8686B622B88120, soundId, audioName, x, y, z, audioRef, p6, range, p8);
        }

        public static void STOP_SOUND(int soundId)
        {
            Invoker.Call<Void>(0xA3B0C41BA5CC0BB5, soundId);
        }

        public static int GET_NETWORK_ID_FROM_SOUND_ID(int soundId)
        {
            return Invoker.Call<int>(0x2DE3F0A134FFBC0D, soundId);
        }

        public static int GET_SOUND_ID_FROM_NETWORK_ID(int netId)
        {
            return Invoker.Call<int>(0x75262FD12D0A1C84, netId);
        }

        public static void SET_VARIABLE_ON_SOUND(int soundId, string variableName, float value)
        {
            Invoker.Call<Void>(0xAD6B3148A78AE9B6, soundId, variableName, value);
        }

        public static void SET_VARIABLE_ON_STREAM(string p0, float p1)
        {
            Invoker.Call<Void>(0x2F9D3834AEB9EF79, p0, p1);
        }

        public static void OVERRIDE_UNDERWATER_STREAM(ulong p0_ptr, bool p1)
        {
            Invoker.Call<Void>(0xF2A9CDABCEA04BD6, p0_ptr, p1);
        }

        public static void _0x733ADF241531E5C2(string name, float p1)
        {
            Invoker.Call<Void>(0x733ADF241531E5C2, name, p1);
        }

        public static bool HAS_SOUND_FINISHED(int soundId)
        {
            return Invoker.Call<bool>(0xFCBDCE714A7C88E5, soundId);
        }

        public static void _PLAY_AMBIENT_SPEECH1(int ped, string speechName, string speechParam)
        {
            Invoker.Call<Void>(0x8E04FEDD28D42462, ped, speechName, speechParam);
        }

        public static void _PLAY_AMBIENT_SPEECH2(int ped, string speechName, string speechParam)
        {
            Invoker.Call<Void>(0xC6941B4A3A8FBBB9, ped, speechName, speechParam);
        }

        public static void _PLAY_AMBIENT_SPEECH_WITH_VOICE(int p0, string speechName, string voiceName, string speechParam, bool p4)
        {
            Invoker.Call<Void>(0x3523634255FC3318, p0, speechName, voiceName, speechParam, p4);
        }

        public static void _PLAY_AMBIENT_SPEECH_AT_COORDS(string p0, string p1, float p2, float p3, float p4, string p5)
        {
            Invoker.Call<Void>(0xED640017ED337E45, p0, p1, p2, p3, p4, p5);
        }

        public static void OVERRIDE_TREVOR_RAGE(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x13AD665062541A7E, p0_ptr);
        }

        public static void RESET_TREVOR_RAGE()
        {
            Invoker.Call<Void>(0xE78503B10C4314E0);
        }

        public static void SET_PLAYER_ANGRY(int playerPed, bool disabled)
        {
            Invoker.Call<Void>(0xEA241BB04110F091, playerPed, disabled);
        }

        public static void PLAY_PAIN(int ped, int painID, int p1)
        {
            Invoker.Call<Void>(0xBC9AE166038A5CEC, ped, painID, p1);
        }

        public static void _0xD01005D2BA2EB778(string p0)
        {
            Invoker.Call<Void>(0xD01005D2BA2EB778, p0);
        }

        public static void _0xDDC635D5B3262C56(string p0)
        {
            Invoker.Call<Void>(0xDDC635D5B3262C56, p0);
        }

        public static void SET_AMBIENT_VOICE_NAME(int ped, string name)
        {
            Invoker.Call<Void>(0x6C8065A3B780185B, ped, name);
        }

        public static void _SET_PED_SCREAM(int ped)
        {
            Invoker.Call<Void>(0x40CF0D12D142A9E8, ped);
        }

        public static void _0x7CDC8C3B89F661B3(int playerPed, int p1)
        {
            Invoker.Call<Void>(0x7CDC8C3B89F661B3, playerPed, p1);
        }

        public static void _0xA5342D390CDA41D6(int p0, bool p1)
        {
            Invoker.Call<Void>(0xA5342D390CDA41D6, p0, p1);
        }

        public static void _SET_PED_MUTE(int ped)
        {
            Invoker.Call<Void>(0x7A73D05A607734C7, ped);
        }

        public static void STOP_CURRENT_PLAYING_AMBIENT_SPEECH(int ped)
        {
            Invoker.Call<Void>(0xB8BEC0CA6F0EDB0F, ped);
        }

        public static bool IS_AMBIENT_SPEECH_PLAYING(int p0)
        {
            return Invoker.Call<bool>(0x9072C8B49907BFAD, p0);
        }

        public static bool IS_SCRIPTED_SPEECH_PLAYING(int p0)
        {
            return Invoker.Call<bool>(0xCC9AA18DCC7084F4, p0);
        }

        public static bool IS_ANY_SPEECH_PLAYING(int ped)
        {
            return Invoker.Call<bool>(0x729072355FA39EC9, ped);
        }

        public static bool _CAN_PED_SPEAK(int ped, string speechName, bool unk)
        {
            return Invoker.Call<bool>(0x49B99BF3FDA89A7A, ped, speechName, unk);
        }

        public static bool IS_PED_IN_CURRENT_CONVERSATION(int ped)
        {
            return Invoker.Call<bool>(0x049E937F18F4020C, ped);
        }

        public static void SET_PED_IS_DRUNK(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x95D2D383D5396B8A, ped, toggle);
        }

        public static void _0xEE066C7006C49C0A(int p0, int p1, ulong p2_ptr)
        {
            Invoker.Call<Void>(0xEE066C7006C49C0A, p0, p1, p2_ptr);
        }

        public static bool _0xC265DF9FB44A9FBD(int p0)
        {
            return Invoker.Call<bool>(0xC265DF9FB44A9FBD, p0);
        }

        public static void SET_ANIMAL_MOOD(int animal, int mood)
        {
            Invoker.Call<Void>(0xCC97B29285B1DC3B, animal, mood);
        }

        public static bool IS_MOBILE_PHONE_RADIO_ACTIVE()
        {
            return Invoker.Call<bool>(0xB35CE999E8EF317E);
        }

        public static void SET_MOBILE_PHONE_RADIO_STATE(bool state)
        {
            Invoker.Call<Void>(0xBF286C554784F3DF, state);
        }

        public static int GET_PLAYER_RADIO_STATION_INDEX()
        {
            return Invoker.Call<int>(0xE8AF77C4C06ADC93);
        }

        public static string GET_PLAYER_RADIO_STATION_NAME()
        {
            return Invoker.Call<string>(0xF6D733C32076AD03);
        }

        public static string GET_RADIO_STATION_NAME(int radioStation)
        {
            return Invoker.Call<string>(0xB28ECA15046CA8B9, radioStation);
        }

        public static int GET_PLAYER_RADIO_STATION_GENRE()
        {
            return Invoker.Call<int>(0xA571991A7FE6CCEB);
        }

        public static bool IS_RADIO_RETUNING()
        {
            return Invoker.Call<bool>(0xA151A7394A214E65);
        }

        public static int _0x0626A247D2405330()
        {
            return Invoker.Call<int>(0x0626A247D2405330);
        }

        public static void _0xFF266D1D0EB1195D()
        {
            Invoker.Call<Void>(0xFF266D1D0EB1195D);
        }

        public static void _0xDD6BCF9E94425DF9()
        {
            Invoker.Call<Void>(0xDD6BCF9E94425DF9);
        }

        public static void SET_RADIO_TO_STATION_NAME(string stationName)
        {
            Invoker.Call<Void>(0xC69EDA28699D5107, stationName);
        }

        public static void SET_VEH_RADIO_STATION(int vehicle, string radioStation)
        {
            Invoker.Call<Void>(0x1B9C0099CB942AC6, vehicle, radioStation);
        }

        public static void _0xC1805D05E6D4FE10(int vehicle)
        {
            Invoker.Call<Void>(0xC1805D05E6D4FE10, vehicle);
        }

        public static void SET_EMITTER_RADIO_STATION(string emitterName, string radioStation)
        {
            Invoker.Call<Void>(0xACF57305B12AF907, emitterName, radioStation);
        }

        public static void SET_STATIC_EMITTER_ENABLED(string emitterName, bool toggle)
        {
            Invoker.Call<Void>(0x399D2D3B33F1B8EB, emitterName, toggle);
        }

        public static void SET_RADIO_TO_STATION_INDEX(int radioStation)
        {
            Invoker.Call<Void>(0xA619B168B8A8570F, radioStation);
        }

        public static void SET_FRONTEND_RADIO_ACTIVE(bool active)
        {
            Invoker.Call<Void>(0xF7F26C6E9CC9EBB8, active);
        }

        public static void UNLOCK_MISSION_NEWS_STORY(int newsStory)
        {
            Invoker.Call<Void>(0xB165AB7C248B2DC1, newsStory);
        }

        public static int GET_NUMBER_OF_PASSENGER_VOICE_VARIATIONS(int p0)
        {
            return Invoker.Call<int>(0x66E49BF55B4B1874, p0);
        }

        public static int GET_AUDIBLE_MUSIC_TRACK_TEXT_ID()
        {
            return Invoker.Call<int>(0x50B196FC9ED6545B);
        }

        public static void PLAY_END_CREDITS_MUSIC(bool play)
        {
            Invoker.Call<Void>(0xCD536C4D33DCC900, play);
        }

        public static void SKIP_RADIO_FORWARD()
        {
            Invoker.Call<Void>(0x6DDBBDD98E2E9C25);
        }

        public static void FREEZE_RADIO_STATION(string radioStation)
        {
            Invoker.Call<Void>(0x344F393B027E38C3, radioStation);
        }

        public static void UNFREEZE_RADIO_STATION(string radioStation)
        {
            Invoker.Call<Void>(0xFC00454CF60B91DD, radioStation);
        }

        public static void SET_RADIO_AUTO_UNFREEZE(bool toggle)
        {
            Invoker.Call<Void>(0xC1AA9F53CE982990, toggle);
        }

        public static void SET_INITIAL_PLAYER_STATION(string radioStation)
        {
            Invoker.Call<Void>(0x88795F13FACDA88D, radioStation);
        }

        public static void SET_USER_RADIO_CONTROL_ENABLED(bool toggle)
        {
            Invoker.Call<Void>(0x19F21E63AE6EAE4E, toggle);
        }

        public static void SET_RADIO_TRACK(string radioStation, string radioTrack)
        {
            Invoker.Call<Void>(0xB39786F201FEE30B, radioStation, radioTrack);
        }

        public static void SET_VEHICLE_RADIO_LOUD(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xBB6F1CAEC68B0BCE, vehicle, toggle);
        }

        public static bool _IS_VEHICLE_RADIO_LOUD(int vehicle)
        {
            return Invoker.Call<bool>(0x032A116663A4D5AC, vehicle);
        }

        public static void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(bool Toggle)
        {
            Invoker.Call<Void>(0x1098355A16064BB3, Toggle);
        }

        public static bool _0x109697E2FFBAC8A1()
        {
            return Invoker.Call<bool>(0x109697E2FFBAC8A1);
        }

        public static bool _IS_PLAYER_VEHICLE_RADIO_ENABLED()
        {
            return Invoker.Call<bool>(0x5F43D83FD6738741);
        }

        public static void SET_VEHICLE_RADIO_ENABLED(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x3B988190C0AA6C0B, vehicle, toggle);
        }

        public static void _0x4E404A9361F75BB2(string radioStation, string p1, bool p2)
        {
            Invoker.Call<Void>(0x4E404A9361F75BB2, radioStation, p1, p2);
        }

        public static void _0x1654F24A88A8E3FE(string radioStation)
        {
            Invoker.Call<Void>(0x1654F24A88A8E3FE, radioStation);
        }

        public static int _MAX_RADIO_STATION_INDEX()
        {
            return Invoker.Call<int>(0xF1620ECB50E01DE7);
        }

        public static int FIND_RADIO_STATION_INDEX(int station)
        {
            return Invoker.Call<int>(0x8D67489793FF428B, station);
        }

        public static void _0x774BD811F656A122(string radioStation, bool p1)
        {
            Invoker.Call<Void>(0x774BD811F656A122, radioStation, p1);
        }

        public static void _0x2C96CDB04FCA358E(float p0)
        {
            Invoker.Call<Void>(0x2C96CDB04FCA358E, p0);
        }

        public static void _0x031ACB6ABA18C729(string radioStation, string p1)
        {
            Invoker.Call<Void>(0x031ACB6ABA18C729, radioStation, p1);
        }

        public static void _0xF3365489E0DD50F9(int p0, bool p1)
        {
            Invoker.Call<Void>(0xF3365489E0DD50F9, p0, p1);
        }

        public static void SET_AMBIENT_ZONE_STATE(ulong p0_ptr, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xBDA07E5950085E46, p0_ptr, p1, p2);
        }

        public static void CLEAR_AMBIENT_ZONE_STATE(string zoneName, bool p1)
        {
            Invoker.Call<Void>(0x218DD44AAAC964FF, zoneName, p1);
        }

        public static void SET_AMBIENT_ZONE_LIST_STATE(string p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x9748FA4DE50CCE3E, p0, p1, p2);
        }

        public static void CLEAR_AMBIENT_ZONE_LIST_STATE(ulong p0_ptr, bool p1)
        {
            Invoker.Call<Void>(0x120C48C614909FA4, p0_ptr, p1);
        }

        public static void SET_AMBIENT_ZONE_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x1D6650420CEC9D3B, ambientZone, p1, p2);
        }

        public static void SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT(string ambientZone, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xF3638DAE8C4045E1, ambientZone, p1, p2);
        }

        public static bool IS_AMBIENT_ZONE_ENABLED(string ambientZone)
        {
            return Invoker.Call<bool>(0x01E2817A479A7F9B, ambientZone);
        }

        public static void SET_CUTSCENE_AUDIO_OVERRIDE(string p0)
        {
            Invoker.Call<Void>(0x3B4BF5F0859204D9, p0);
        }

        public static void GET_PLAYER_HEADSET_SOUND_ALTERNATE(string p0, float p1)
        {
            Invoker.Call<Void>(0xBCC29F935ED07688, p0, p1);
        }

        public static int PLAY_POLICE_REPORT(string name, float p1)
        {
            return Invoker.Call<int>(0xDFEBD56D9BD1EB16, name, p1);
        }

        public static void _DISABLE_POLICE_REPORTS()
        {
            Invoker.Call<Void>(0xB4F90FAF7670B16F);
        }

        public static void BLIP_SIREN(int vehicle)
        {
            Invoker.Call<Void>(0x1B9025BDA76822B6, vehicle);
        }

        public static void OVERRIDE_VEH_HORN(int vehicle, bool mute, int p2)
        {
            Invoker.Call<Void>(0x3CDC1E622CCE0356, vehicle, mute, p2);
        }

        public static bool IS_HORN_ACTIVE(int vehicle)
        {
            return Invoker.Call<bool>(0x9D6BFC12B05C6121, vehicle);
        }

        public static void SET_AGGRESSIVE_HORNS(bool toggle)
        {
            Invoker.Call<Void>(0x395BF71085D1B1D9, toggle);
        }

        public static void _0x02E93C796ABD3A97(bool p0)
        {
            Invoker.Call<Void>(0x02E93C796ABD3A97, p0);
        }

        public static void _0x58BB377BEC7CD5F4(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x58BB377BEC7CD5F4, p0, p1);
        }

        public static bool IS_STREAM_PLAYING()
        {
            return Invoker.Call<bool>(0xD11FA52EB849D978);
        }

        public static int GET_STREAM_PLAY_TIME()
        {
            return Invoker.Call<int>(0x4E72BBDBCA58A3DB);
        }

        public static bool LOAD_STREAM(string streamName, string soundSet)
        {
            return Invoker.Call<bool>(0x1F1F957154EC51DF, streamName, soundSet);
        }

        public static bool LOAD_STREAM_WITH_START_OFFSET(string streamName, int startOffset, string soundSet)
        {
            return Invoker.Call<bool>(0x59C16B79F53B3712, streamName, startOffset, soundSet);
        }

        public static void PLAY_STREAM_FROM_PED(int ped)
        {
            Invoker.Call<Void>(0x89049DD63C08B5D1, ped);
        }

        public static void PLAY_STREAM_FROM_VEHICLE(int vehicle)
        {
            Invoker.Call<Void>(0xB70374A758007DFA, vehicle);
        }

        public static void PLAY_STREAM_FROM_OBJECT(int _object)
        {
            Invoker.Call<Void>(0xEBAA9B64D76356FD, _object);
        }

        public static void PLAY_STREAM_FRONTEND()
        {
            Invoker.Call<Void>(0x58FCE43488F9F5F4);
        }

        public static void SPECIAL_FRONTEND_EQUAL(float x, float y, float z)
        {
            Invoker.Call<Void>(0x21442F412E8DE56B, x, y, z);
        }

        public static void STOP_STREAM()
        {
            Invoker.Call<Void>(0xA4718A1419D18151);
        }

        public static void STOP_PED_SPEAKING(int ped, bool shaking)
        {
            Invoker.Call<Void>(0x9D64D7405520E3D3, ped, shaking);
        }

        public static void DISABLE_PED_PAIN_AUDIO(int ped, bool toggle)
        {
            Invoker.Call<Void>(0xA9A41C1E940FB0E8, ped, toggle);
        }

        public static bool IS_AMBIENT_SPEECH_DISABLED(int ped)
        {
            return Invoker.Call<bool>(0x932C2D096A2C3FFF, ped);
        }

        public static void SET_SIREN_WITH_NO_DRIVER(ulong vehicle_ptr, ulong toggle_ptr)
        {
            Invoker.Call<Void>(0x1FEF0683B96EBCF2, vehicle_ptr, toggle_ptr);
        }

        public static void _SOUND_VEHICLE_HORN_THIS_FRAME(int vehicle)
        {
            Invoker.Call<Void>(0x9C11908013EA4715, vehicle);
        }

        public static void SET_HORN_ENABLED(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0x76D683C108594D0E, vehicle, toggle);
        }

        public static void SET_AUDIO_VEHICLE_PRIORITY(int vehicle, int p1)
        {
            Invoker.Call<Void>(0xE5564483E407F914, vehicle, p1);
        }

        public static void _0x9D3AF56E94C9AE98(int p0, float p1)
        {
            Invoker.Call<Void>(0x9D3AF56E94C9AE98, p0, p1);
        }

        public static void USE_SIREN_AS_HORN(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xFA932DE350266EF8, vehicle, toggle);
        }

        public static void _FORCE_VEHICLE_ENGINE_AUDIO(int vehicle, string audioName)
        {
            Invoker.Call<Void>(0x4F0C413926060B38, vehicle, audioName);
        }

        public static void _0xF1F8157B8C3F171C(int p0, string p1, string p2)
        {
            Invoker.Call<Void>(0xF1F8157B8C3F171C, p0, p1, p2);
        }

        public static void _0xD2DCCD8E16E20997(int p0)
        {
            Invoker.Call<Void>(0xD2DCCD8E16E20997, p0);
        }

        public static bool _0x5DB8010EE71FDEF2(int vehicle)
        {
            return Invoker.Call<bool>(0x5DB8010EE71FDEF2, vehicle);
        }

        public static void _0x59E7B488451F4D3A(int p0, float p1)
        {
            Invoker.Call<Void>(0x59E7B488451F4D3A, p0, p1);
        }

        public static void _0x01BB4D577D38BD9E(int p0, float p1)
        {
            Invoker.Call<Void>(0x01BB4D577D38BD9E, p0, p1);
        }

        public static void _0x1C073274E065C6D2(int p0, bool p1)
        {
            Invoker.Call<Void>(0x1C073274E065C6D2, p0, p1);
        }

        public static void _0x2BE4BC731D039D5A(int p0, bool p1)
        {
            Invoker.Call<Void>(0x2BE4BC731D039D5A, p0, p1);
        }

        public static void SET_VEHICLE_BOOST_ACTIVE(int vehicle, bool Toggle)
        {
            Invoker.Call<Void>(0x4A04DE7CAB2739A1, vehicle, Toggle);
        }

        public static void _0x6FDDAD856E36988A(int p0, bool p1)
        {
            Invoker.Call<Void>(0x6FDDAD856E36988A, p0, p1);
        }

        public static void _0x06C0023BED16DD6B(int p0, bool p1)
        {
            Invoker.Call<Void>(0x06C0023BED16DD6B, p0, p1);
        }

        public static void PLAY_VEHICLE_DOOR_OPEN_SOUND(int vehicle, int p1)
        {
            Invoker.Call<Void>(0x3A539D52857EA82D, vehicle, p1);
        }

        public static void PLAY_VEHICLE_DOOR_CLOSE_SOUND(int vehicle, int p1)
        {
            Invoker.Call<Void>(0x62A456AA4769EF34, vehicle, p1);
        }

        public static void _0xC15907D667F7CFB2(int vehicle, bool toggle)
        {
            Invoker.Call<Void>(0xC15907D667F7CFB2, vehicle, toggle);
        }

        public static bool IS_GAME_IN_CONTROL_OF_MUSIC()
        {
            return Invoker.Call<bool>(0x6D28DC1671E334FD);
        }

        public static void SET_GPS_ACTIVE(bool active)
        {
            Invoker.Call<Void>(0x3BD3F52BA9B1E4E8, active);
        }

        public static void PLAY_MISSION_COMPLETE_AUDIO(string audioName)
        {
            Invoker.Call<Void>(0xB138AAB8A70D3C69, audioName);
        }

        public static bool IS_MISSION_COMPLETE_PLAYING()
        {
            return Invoker.Call<bool>(0x19A30C23F5827F8A);
        }

        public static int _0x6F259F82D873B8B8()
        {
            return Invoker.Call<int>(0x6F259F82D873B8B8);
        }

        public static void _0xF154B8D1775B2DEC(bool p0)
        {
            Invoker.Call<Void>(0xF154B8D1775B2DEC, p0);
        }

        public static bool START_AUDIO_SCENE(string scene)
        {
            return Invoker.Call<bool>(0x013A80FC08F6E4F2, scene);
        }

        public static void STOP_AUDIO_SCENE(string scene)
        {
            Invoker.Call<Void>(0xDFE8422B3B94E688, scene);
        }

        public static void STOP_AUDIO_SCENES()
        {
            Invoker.Call<Void>(0xBAC7FC81A75EC1A1);
        }

        public static bool IS_AUDIO_SCENE_ACTIVE(string scene)
        {
            return Invoker.Call<bool>(0xB65B60556E2A9225, scene);
        }

        public static void SET_AUDIO_SCENE_VARIABLE(string scene, string variable, float value)
        {
            Invoker.Call<Void>(0xEF21A9EF089A2668, scene, variable, value);
        }

        public static void _0xA5F377B175A699C5(int p0)
        {
            Invoker.Call<Void>(0xA5F377B175A699C5, p0);
        }

        public static void _DYNAMIC_MIXER_RELATED_FN(int p0, string p1, float p2)
        {
            Invoker.Call<Void>(0x153973AB99FE8980, p0, p1, p2);
        }

        public static void _0x18EB48CFC41F2EA0(int p0, float p1)
        {
            Invoker.Call<Void>(0x18EB48CFC41F2EA0, p0, p1);
        }

        public static int AUDIO_IS_SCRIPTED_MUSIC_PLAYING()
        {
            return Invoker.Call<int>(0x845FFC3A4FEEFA3E);
        }

        public static bool PREPARE_MUSIC_EVENT(string _eventName)
        {
            return Invoker.Call<bool>(0x1E5185B72EF5158A, _eventName);
        }

        public static bool CANCEL_MUSIC_EVENT(string _eventName)
        {
            return Invoker.Call<bool>(0x5B17A90291133DA5, _eventName);
        }

        public static bool TRIGGER_MUSIC_EVENT(string _eventName)
        {
            return Invoker.Call<bool>(0x706D57B0F50DA710, _eventName);
        }

        public static int _0xA097AB275061FB21()
        {
            return Invoker.Call<int>(0xA097AB275061FB21);
        }

        public static int GET_MUSIC_PLAYTIME()
        {
            return Invoker.Call<int>(0xE7A0D23DC414507B);
        }

        public static void _0xFBE20329593DEC9D(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xFBE20329593DEC9D, p0, p1, p2, p3);
        }

        public static void CLEAR_ALL_BROKEN_GLASS()
        {
            Invoker.Call<Void>(0xB32209EFFDC04913);
        }

        public static void _0x70B8EC8FC108A634(bool p0, int p1)
        {
            Invoker.Call<Void>(0x70B8EC8FC108A634, p0, p1);
        }

        public static void _0x149AEE66F0CB3A99(float p0, float p1)
        {
            Invoker.Call<Void>(0x149AEE66F0CB3A99, p0, p1);
        }

        public static void _0x8BF907833BE275DE(float p0, float p1)
        {
            Invoker.Call<Void>(0x8BF907833BE275DE, p0, p1);
        }

        public static void _0x062D5EAD4DA2FA6A()
        {
            Invoker.Call<Void>(0x062D5EAD4DA2FA6A);
        }

        public static bool PREPARE_ALARM(string alarmName)
        {
            return Invoker.Call<bool>(0x9D74AE343DB65533, alarmName);
        }

        public static void START_ALARM(string alarmName, bool p2)
        {
            Invoker.Call<Void>(0x0355EF116C4C97B2, alarmName, p2);
        }

        public static void STOP_ALARM(string alarmName, bool toggle)
        {
            Invoker.Call<Void>(0xA1CADDCD98415A41, alarmName, toggle);
        }

        public static void STOP_ALL_ALARMS(bool stop)
        {
            Invoker.Call<Void>(0x2F794A877ADD4C92, stop);
        }

        public static bool IS_ALARM_PLAYING(string alarmName)
        {
            return Invoker.Call<bool>(0x226435CB96CCFC8C, alarmName);
        }

        public static int GET_VEHICLE_DEFAULT_HORN(int vehicle)
        {
            return Invoker.Call<int>(0x02165D55000219AC, vehicle);
        }

        public static int _GET_VEHICLE_HORN_HASH(int vehicle)
        {
            return Invoker.Call<int>(0xACB5DCCA1EC76840, vehicle);
        }

        public static void RESET_PED_AUDIO_FLAGS(int ped)
        {
            Invoker.Call<Void>(0xF54BB7B61036F335, ped);
        }

        public static void _0xD2CC78CD3D0B50F9(int p0, bool p1)
        {
            Invoker.Call<Void>(0xD2CC78CD3D0B50F9, p0, p1);
        }

        public static void _0xBF4DC1784BE94DFA(int p0, bool p1, int p2)
        {
            Invoker.Call<Void>(0xBF4DC1784BE94DFA, p0, p1, p2);
        }

        public static void _0x75773E11BA459E90(int p0, bool p1)
        {
            Invoker.Call<Void>(0x75773E11BA459E90, p0, p1);
        }

        public static void _0xD57AAAE0E2214D11()
        {
            Invoker.Call<Void>(0xD57AAAE0E2214D11);
        }

        public static void _FORCE_AMBIENT_SIREN(bool value)
        {
            Invoker.Call<Void>(0x552369F549563AD5, value);
        }

        public static void _0x43FA0DFC5DF87815(int vehicle, bool p1)
        {
            Invoker.Call<Void>(0x43FA0DFC5DF87815, vehicle, p1);
        }

        public static void SET_AUDIO_FLAG(string flagName, bool toggle)
        {
            Invoker.Call<Void>(0xB9EFD5C25018725A, flagName, toggle);
        }

        public static int PREPARE_SYNCHRONIZED_AUDIO_EVENT(string p0, int p1)
        {
            return Invoker.Call<int>(0xC7ABCACA4985A766, p0, p1);
        }

        public static bool PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x029FE7CD1B7E2E75, p0, p1_ptr);
        }

        public static bool PLAY_SYNCHRONIZED_AUDIO_EVENT(int p0)
        {
            return Invoker.Call<bool>(0x8B2FD4560E55DD2D, p0);
        }

        public static bool STOP_SYNCHRONIZED_AUDIO_EVENT(int p0)
        {
            return Invoker.Call<bool>(0x92D6A88E64A94430, p0);
        }

        public static void _0xC8EDE9BDBCCBA6D4(ulong p0_ptr, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0xC8EDE9BDBCCBA6D4, p0_ptr, p1, p2, p3);
        }

        public static void _SET_SYNCHRONIZED_AUDIO_EVENT_POSITION_THIS_FRAME(string p0, int p1)
        {
            Invoker.Call<Void>(0x950A154B8DAB6185, p0, p1);
        }

        public static void _0x12561FCBB62D5B9C(int p0)
        {
            Invoker.Call<Void>(0x12561FCBB62D5B9C, p0);
        }

        public static void _0x044DBAD7A7FA2BE5(string p0, string p1)
        {
            Invoker.Call<Void>(0x044DBAD7A7FA2BE5, p0, p1);
        }

        public static void _0xB4BBFD9CD8B3922B(string p0)
        {
            Invoker.Call<Void>(0xB4BBFD9CD8B3922B, p0);
        }

        public static void _0xE4E6DD5566D28C82()
        {
            Invoker.Call<Void>(0xE4E6DD5566D28C82);
        }

        public static int _0x3A48AB4445D499BE()
        {
            return Invoker.Call<int>(0x3A48AB4445D499BE);
        }

        public static void _SET_PED_TALK(int ped)
        {
            Invoker.Call<Void>(0x4ADA3F19BE4A6047, ped);
        }

        public static void _0x0150B6FF25A9E2E5()
        {
            Invoker.Call<Void>(0x0150B6FF25A9E2E5);
        }

        public static void _0xBEF34B1D9624D5DD(bool p0)
        {
            Invoker.Call<Void>(0xBEF34B1D9624D5DD, p0);
        }

        public static void _0x806058BBDC136E06()
        {
            Invoker.Call<Void>(0x806058BBDC136E06);
        }

        public static int _0x544810ED9DB6BBE6()
        {
            return Invoker.Call<int>(0x544810ED9DB6BBE6);
        }

        public static int _0x5B50ABB1FE3746F4()
        {
            return Invoker.Call<int>(0x5B50ABB1FE3746F4);
        }

    }

    public static class CUTSCENE
    {

        public static void REQUEST_CUTSCENE(string cutsceneName, int p1)
        {
            Invoker.Call<Void>(0x7A86743F475D9E09, cutsceneName, p1);
        }

        public static void _REQUEST_CUTSCENE_EX(string cutsceneName, int p1, int p2)
        {
            Invoker.Call<Void>(0xC23DE0E91C30B58C, cutsceneName, p1, p2);
        }

        public static void REMOVE_CUTSCENE()
        {
            Invoker.Call<Void>(0x440AF51A3462B86F);
        }

        public static bool HAS_CUTSCENE_LOADED()
        {
            return Invoker.Call<bool>(0xC59F528E9AB9F339);
        }

        public static bool HAS_THIS_CUTSCENE_LOADED(string cutsceneName)
        {
            return Invoker.Call<bool>(0x228D3D94F8A11C3C, cutsceneName);
        }

        public static void _0x8D9DF6ECA8768583(int p0)
        {
            Invoker.Call<Void>(0x8D9DF6ECA8768583, p0);
        }

        public static bool _0xB56BBBCC2955D9CB()
        {
            return Invoker.Call<bool>(0xB56BBBCC2955D9CB);
        }

        public static bool _0x71B74D2AE19338D0(int p0)
        {
            return Invoker.Call<bool>(0x71B74D2AE19338D0, p0);
        }

        public static void _0x4C61C75BEE8184C2(string p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x4C61C75BEE8184C2, p0, p1, p2);
        }

        public static void _0x06A3524161C502BA(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x06A3524161C502BA, p0_ptr);
        }

        public static bool _0xA1C996C2A744262E(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xA1C996C2A744262E, p0_ptr);
        }

        public static void _0xD00D76A7DFC9D852(ulong p0_ptr)
        {
            Invoker.Call<Void>(0xD00D76A7DFC9D852, p0_ptr);
        }

        public static int _0x0ABC54DE641DC0FC(ulong p0_ptr)
        {
            return Invoker.Call<int>(0x0ABC54DE641DC0FC, p0_ptr);
        }

        public static void START_CUTSCENE(int p0)
        {
            Invoker.Call<Void>(0x186D5CB5E7B0FF7B, p0);
        }

        public static void START_CUTSCENE_AT_COORDS(float x, float y, float z, int p3)
        {
            Invoker.Call<Void>(0x1C9ADDA3244A1FBF, x, y, z, p3);
        }

        public static void STOP_CUTSCENE(bool p0)
        {
            Invoker.Call<Void>(0xC7272775B4DC786E, p0);
        }

        public static void STOP_CUTSCENE_IMMEDIATELY()
        {
            Invoker.Call<Void>(0xD220BDD222AC4A1E);
        }

        public static void SET_CUTSCENE_ORIGIN(float x, float y, float z, float p3, int p4)
        {
            Invoker.Call<Void>(0xB812B3FD1C01CF27, x, y, z, p3, p4);
        }

        public static void _0x011883F41211432A(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Invoker.Call<Void>(0x011883F41211432A, p0, p1, p2, p3, p4, p5, p6);
        }

        public static int GET_CUTSCENE_TIME()
        {
            return Invoker.Call<int>(0xE625BEABBAFFDAB9);
        }

        public static int GET_CUTSCENE_TOTAL_DURATION()
        {
            return Invoker.Call<int>(0xEE53B14A19E480D4);
        }

        public static bool WAS_CUTSCENE_SKIPPED()
        {
            return Invoker.Call<bool>(0x40C8656EDAEDD569);
        }

        public static bool HAS_CUTSCENE_FINISHED()
        {
            return Invoker.Call<bool>(0x7C0A893088881D57);
        }

        public static bool IS_CUTSCENE_ACTIVE()
        {
            return Invoker.Call<bool>(0x991251AFC3981F84);
        }

        public static bool IS_CUTSCENE_PLAYING()
        {
            return Invoker.Call<bool>(0xD3C2E180A40F031E);
        }

        public static int GET_CUTSCENE_SECTION_PLAYING()
        {
            return Invoker.Call<int>(0x49010A6A396553D8);
        }

        public static int GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY(string cutsceneEntName, int modelHash)
        {
            return Invoker.Call<int>(0x0A2E9FDB9A8C62F6, cutsceneEntName, modelHash);
        }

        public static int _0x583DF8E3D4AFBD98()
        {
            return Invoker.Call<int>(0x583DF8E3D4AFBD98);
        }

        public static bool _0x4CEBC1ED31E8925E(string cutsceneName)
        {
            return Invoker.Call<bool>(0x4CEBC1ED31E8925E, cutsceneName);
        }

        public static void REGISTER_ENTITY_FOR_CUTSCENE(int cutscenePed, string cutsceneEntName, int p2, int modelHash, int p4)
        {
            Invoker.Call<Void>(0xE40C1C56DF95C2E8, cutscenePed, cutsceneEntName, p2, modelHash, p4);
        }

        public static int GET_ENTITY_INDEX_OF_REGISTERED_ENTITY(string cutsceneEntName, int modelHash)
        {
            return Invoker.Call<int>(0xC0741A26499654CD, cutsceneEntName, modelHash);
        }

        public static void _0x7F96F23FA9B73327(int modelHash)
        {
            Invoker.Call<Void>(0x7F96F23FA9B73327, modelHash);
        }

        public static void SET_CUTSCENE_TRIGGER_AREA(float p0, float p1, float p2, float p3, float p4, float p5)
        {
            Invoker.Call<Void>(0x9896CE4721BE84BA, p0, p1, p2, p3, p4, p5);
        }

        public static bool CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, int modelHash)
        {
            return Invoker.Call<bool>(0x645D0B458D8E17B5, cutsceneEntName, modelHash);
        }

        public static bool CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY(string cutsceneEntName, int modelHash)
        {
            return Invoker.Call<bool>(0x4C6A6451C79E4662, cutsceneEntName, modelHash);
        }

        public static bool CAN_SET_EXIT_STATE_FOR_CAMERA(bool p0)
        {
            return Invoker.Call<bool>(0xB2CBCD0930DFB420, p0);
        }

        public static void _0xC61B86C9F61EB404(bool toggle)
        {
            Invoker.Call<Void>(0xC61B86C9F61EB404, toggle);
        }

        public static void SET_CUTSCENE_FADE_VALUES(bool p0, bool p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x8093F23ABACCC7D4, p0, p1, p2, p3);
        }

        public static void _0x20746F7B1032A3C7(bool p0, bool p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x20746F7B1032A3C7, p0, p1, p2, p3);
        }

        public static void _0x06EE9048FD080382(bool p0)
        {
            Invoker.Call<Void>(0x06EE9048FD080382, p0);
        }

        public static int _0xA0FE76168A189DDB()
        {
            return Invoker.Call<int>(0xA0FE76168A189DDB);
        }

        public static void _0x2F137B508DE238F2(bool p0)
        {
            Invoker.Call<Void>(0x2F137B508DE238F2, p0);
        }

        public static void _0xE36A98D8AB3D3C66(bool p0)
        {
            Invoker.Call<Void>(0xE36A98D8AB3D3C66, p0);
        }

        public static bool _0x5EDEF0CF8C1DAB3C()
        {
            return Invoker.Call<bool>(0x5EDEF0CF8C1DAB3C);
        }

        public static void _0x41FAA8FB2ECE8720(bool p0)
        {
            Invoker.Call<Void>(0x41FAA8FB2ECE8720, p0);
        }

        public static void REGISTER_SYNCHRONISED_SCRIPT_SPEECH()
        {
            Invoker.Call<Void>(0x2131046957F31B04);
        }

        public static void SET_CUTSCENE_PED_COMPONENT_VARIATION(string cutsceneEntName, int p1, int p2, int p3, int modelHash)
        {
            Invoker.Call<Void>(0xBA01E7B6DEEFBBC9, cutsceneEntName, p1, p2, p3, modelHash);
        }

        public static void _0x2A56C06EBEF2B0D9(string cutsceneEntName, int ped, int modelHash)
        {
            Invoker.Call<Void>(0x2A56C06EBEF2B0D9, cutsceneEntName, ped, modelHash);
        }

        public static bool DOES_CUTSCENE_ENTITY_EXIST(string cutsceneEntName, int modelHash)
        {
            return Invoker.Call<bool>(0x499EF20C5DB25C59, cutsceneEntName, modelHash);
        }

        public static void SET_CUTSCENE_PED_PROP_VARIATION(string cutsceneEntName, int p1, int p2, int p3, int modelHash)
        {
            Invoker.Call<Void>(0x0546524ADE2E9723, cutsceneEntName, p1, p2, p3, modelHash);
        }

        public static ulong _0x708BDD8CD795B043()
        {
            return Invoker.Call<ulong>(0x708BDD8CD795B043);
        }

    }

    public static class INTERIOR
    {

        public static int GET_INTERIOR_GROUP_ID(int interiorID)
        {
            return Invoker.Call<int>(0xE4A84ABF135EF91A, interiorID);
        }

        public static Vector3 GET_OFFSET_FROM_INTERIOR_IN_WORLD_COORDS(int interiorID, float x, float y, float z)
        {
            return Invoker.Call<Vector3>(0x9E3B3E6D66F6E22F, interiorID, x, y, z);
        }

        public static bool IS_INTERIOR_SCENE()
        {
            return Invoker.Call<bool>(0xBC72B5D7A1CBD54D);
        }

        public static bool IS_VALID_INTERIOR(int interiorID)
        {
            return Invoker.Call<bool>(0x26B0E73D7EAAF4D3, interiorID);
        }

        public static void CLEAR_ROOM_FOR_ENTITY(int entity)
        {
            Invoker.Call<Void>(0xB365FC0C4E27FFA7, entity);
        }

        public static void FORCE_ROOM_FOR_ENTITY(int entity, int interiorID, int roomHashKey)
        {
            Invoker.Call<Void>(0x52923C4710DD9907, entity, interiorID, roomHashKey);
        }

        public static int GET_ROOM_KEY_FROM_ENTITY(int entity)
        {
            return Invoker.Call<int>(0x47C2A06D4F5F424B, entity);
        }

        public static int GET_KEY_FOR_ENTITY_IN_ROOM(int entity)
        {
            return Invoker.Call<int>(0x399685DB942336BC, entity);
        }

        public static int GET_INTERIOR_FROM_ENTITY(int entity)
        {
            return Invoker.Call<int>(0x2107BA504071A6BB, entity);
        }

        public static void _0x82EBB79E258FA2B7(int entity, int interiorID)
        {
            Invoker.Call<Void>(0x82EBB79E258FA2B7, entity, interiorID);
        }

        public static void _0x920D853F3E17F1DA(int interiorID, int roomHashKey)
        {
            Invoker.Call<Void>(0x920D853F3E17F1DA, interiorID, roomHashKey);
        }

        public static void _0xAF348AFCB575A441(string roomName)
        {
            Invoker.Call<Void>(0xAF348AFCB575A441, roomName);
        }

        public static void _0x405DC2AEF6AF95B9(int roomHashKey)
        {
            Invoker.Call<Void>(0x405DC2AEF6AF95B9, roomHashKey);
        }

        public static int _GET_ROOM_KEY_FROM_GAMEPLAY_CAM()
        {
            return Invoker.Call<int>(0xA6575914D2A0B450);
        }

        public static void _0x23B59D8912F94246()
        {
            Invoker.Call<Void>(0x23B59D8912F94246);
        }

        public static int GET_INTERIOR_AT_COORDS(float x, float y, float z)
        {
            return Invoker.Call<int>(0xB0F7F8663821D9C3, x, y, z);
        }

        public static void ADD_PICKUP_TO_INTERIOR_ROOM_BY_NAME(int pickup, string roomName)
        {
            Invoker.Call<Void>(0x3F6167F351168730, pickup, roomName);
        }

        public static void _LOAD_INTERIOR(int interiorID)
        {
            Invoker.Call<Void>(0x2CA429C029CCF247, interiorID);
        }

        public static void UNPIN_INTERIOR(int interiorID)
        {
            Invoker.Call<Void>(0x261CCE7EED010641, interiorID);
        }

        public static bool IS_INTERIOR_READY(int interiorID)
        {
            return Invoker.Call<bool>(0x6726BDCCC1932F0E, interiorID);
        }

        public static int _0x4C2330E61D3DEB56(int interiorID)
        {
            return Invoker.Call<int>(0x4C2330E61D3DEB56, interiorID);
        }

        public static int GET_INTERIOR_AT_COORDS_WITH_TYPE(float x, float y, float z, string interiorType)
        {
            return Invoker.Call<int>(0x05B7A89BD78797FC, x, y, z, interiorType);
        }

        public static int _UNK_GET_INTERIOR_AT_COORDS(float x, float y, float z, int unk)
        {
            return Invoker.Call<int>(0xF0F77ADB9F67E79D, x, y, z, unk);
        }

        public static bool _ARE_COORDS_COLLIDING_WITH_EXTERIOR(float x, float y, float z)
        {
            return Invoker.Call<bool>(0xEEA5AC2EDA7C33E8, x, y, z);
        }

        public static int GET_INTERIOR_FROM_COLLISION(float x, float y, float z)
        {
            return Invoker.Call<int>(0xEC4CF9FCB29A4424, x, y, z);
        }

        public static void _ENABLE_INTERIOR_PROP(int interiorID, string propName)
        {
            Invoker.Call<Void>(0x55E86AF2712B36A1, interiorID, propName);
        }

        public static void _DISABLE_INTERIOR_PROP(int interiorID, string propName)
        {
            Invoker.Call<Void>(0x420BD37289EEE162, interiorID, propName);
        }

        public static bool _IS_INTERIOR_PROP_ENABLED(int interiorID, string propName)
        {
            return Invoker.Call<bool>(0x35F7DD45E8C0A16D, interiorID, propName);
        }

        public static void REFRESH_INTERIOR(int interiorID)
        {
            Invoker.Call<Void>(0x41F37C3427C75AE0, interiorID);
        }

        public static void _HIDE_MAP_OBJECT_THIS_FRAME(int mapObjectHash)
        {
            Invoker.Call<Void>(0xA97F257D0151A6AB, mapObjectHash);
        }

        public static void DISABLE_INTERIOR(int interiorID, bool toggle)
        {
            Invoker.Call<Void>(0x6170941419D7D8EC, interiorID, toggle);
        }

        public static bool IS_INTERIOR_DISABLED(int interiorID)
        {
            return Invoker.Call<bool>(0xBC5115A5A939DD15, interiorID);
        }

        public static void CAP_INTERIOR(int interiorID, bool toggle)
        {
            Invoker.Call<Void>(0xD9175F941610DB54, interiorID, toggle);
        }

        public static bool IS_INTERIOR_CAPPED(int interiorID)
        {
            return Invoker.Call<bool>(0x92BAC8ACF88CEC26, interiorID);
        }

        public static void _0x9E6542F0CE8E70A3(bool toggle)
        {
            Invoker.Call<Void>(0x9E6542F0CE8E70A3, toggle);
        }

    }

    public static class CAM
    {

        public static void RENDER_SCRIPT_CAMS(bool render, bool ease, int easeTime, bool p3, bool p4)
        {
            Invoker.Call<Void>(0x07E5B515DB0636FC, render, ease, easeTime, p3, p4);
        }

        public static void _RENDER_FIRST_PERSON_CAM(bool render, float p1, int p2)
        {
            Invoker.Call<Void>(0xC819F3CBB62BF692, render, p1, p2);
        }

        public static int CREATE_CAM(string Gippo, bool p1)
        {
            return Invoker.Call<int>(0xC3981DCE61D9E13F, Gippo, p1);
        }

        public static int CREATE_CAM_WITH_PARAMS(string camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, int p9)
        {
            return Invoker.Call<int>(0xB51194800B257161, camName, posX, posY, posZ, rotX, rotY, rotZ, fov, p8, p9);
        }

        public static int CREATE_CAMERA(int camHash, bool p1)
        {
            return Invoker.Call<int>(0x5E3CF89C6BCCA67D, camHash, p1);
        }

        public static int CREATE_CAMERA_WITH_PARAMS(int camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, int p9)
        {
            return Invoker.Call<int>(0x6ABFA3E16460F22D, camHash, posX, posY, posZ, rotX, rotY, rotZ, fov, p8, p9);
        }

        public static void DESTROY_CAM(int cam, bool thisScriptCheck)
        {
            Invoker.Call<Void>(0x865908C81A2C22E9, cam, thisScriptCheck);
        }

        public static void DESTROY_ALL_CAMS(bool thisScriptCheck)
        {
            Invoker.Call<Void>(0x8E5FB15663F79120, thisScriptCheck);
        }

        public static bool DOES_CAM_EXIST(int cam)
        {
            return Invoker.Call<bool>(0xA7A932170592B50E, cam);
        }

        public static void SET_CAM_ACTIVE(int cam, bool active)
        {
            Invoker.Call<Void>(0x026FB97D0A425F84, cam, active);
        }

        public static bool IS_CAM_ACTIVE(int cam)
        {
            return Invoker.Call<bool>(0xDFB2B516207D3534, cam);
        }

        public static bool IS_CAM_RENDERING(int cam)
        {
            return Invoker.Call<bool>(0x02EC0AF5C5A49B7A, cam);
        }

        public static int GET_RENDERING_CAM()
        {
            return Invoker.Call<int>(0x5234F9F10919EABA);
        }

        public static Vector3 GET_CAM_COORD(int cam)
        {
            return Invoker.Call<Vector3>(0xBAC038F7459AE5AE, cam);
        }

        public static Vector3 GET_CAM_ROT(int cam, int rotationOrder)
        {
            return Invoker.Call<Vector3>(0x7D304C1C955E3E12, cam, rotationOrder);
        }

        public static float GET_CAM_FOV(int cam)
        {
            return Invoker.Call<float>(0xC3330A45CCCDB26A, cam);
        }

        public static float GET_CAM_NEAR_CLIP(int cam)
        {
            return Invoker.Call<float>(0xC520A34DAFBF24B1, cam);
        }

        public static float GET_CAM_FAR_CLIP(int cam)
        {
            return Invoker.Call<float>(0xB60A9CFEB21CA6AA, cam);
        }

        public static float GET_CAM_FAR_DOF(int cam)
        {
            return Invoker.Call<float>(0x255F8DAFD540D397, cam);
        }

        public static void SET_CAM_PARAMS(int cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, int p8, int p9, int p10, int p11)
        {
            Invoker.Call<Void>(0xBFD8727AEA3CCEBA, cam, posX, posY, posZ, rotX, rotY, rotZ, fieldOfView, p8, p9, p10, p11);
        }

        public static void SET_CAM_COORD(int cam, float posX, float posY, float posZ)
        {
            Invoker.Call<Void>(0x4D41783FB745E42E, cam, posX, posY, posZ);
        }

        public static void SET_CAM_ROT(int cam, float rotX, float rotY, float rotZ, int rotationOrder)
        {
            Invoker.Call<Void>(0x85973643155D0B07, cam, rotX, rotY, rotZ, rotationOrder);
        }

        public static void SET_CAM_FOV(int cam, float fieldOfView)
        {
            Invoker.Call<Void>(0xB13C14F66A00D047, cam, fieldOfView);
        }

        public static void SET_CAM_NEAR_CLIP(int cam, float nearClip)
        {
            Invoker.Call<Void>(0xC7848EFCCC545182, cam, nearClip);
        }

        public static void SET_CAM_FAR_CLIP(int cam, float farClip)
        {
            Invoker.Call<Void>(0xAE306F2A904BF86E, cam, farClip);
        }

        public static void SET_CAM_MOTION_BLUR_STRENGTH(int cam, float strength)
        {
            Invoker.Call<Void>(0x6F0F77FBA9A8F2E6, cam, strength);
        }

        public static void SET_CAM_NEAR_DOF(int cam, float nearDOF)
        {
            Invoker.Call<Void>(0x3FA4BF0A7AB7DE2C, cam, nearDOF);
        }

        public static void SET_CAM_FAR_DOF(int cam, float farDOF)
        {
            Invoker.Call<Void>(0xEDD91296CD01AEE0, cam, farDOF);
        }

        public static void SET_CAM_DOF_STRENGTH(int cam, float dofStrength)
        {
            Invoker.Call<Void>(0x5EE29B4D7D5DF897, cam, dofStrength);
        }

        public static void SET_CAM_DOF_PLANES(int cam, float p1, float p2, float p3, float p4)
        {
            Invoker.Call<Void>(0x3CF48F6F96E749DC, cam, p1, p2, p3, p4);
        }

        public static void SET_CAM_USE_SHALLOW_DOF_MODE(int cam, bool toggle)
        {
            Invoker.Call<Void>(0x16A96863A17552BB, cam, toggle);
        }

        public static void SET_USE_HI_DOF()
        {
            Invoker.Call<Void>(0xA13B0222F3D94A94);
        }

        public static void _0xF55E4046F6F831DC(int p0, float p1)
        {
            Invoker.Call<Void>(0xF55E4046F6F831DC, p0, p1);
        }

        public static void _0xE111A7C0D200CBC5(int p0, float p1)
        {
            Invoker.Call<Void>(0xE111A7C0D200CBC5, p0, p1);
        }

        public static void _SET_CAM_DOF_FNUMBER_OF_LENS(int camera, float p1)
        {
            Invoker.Call<Void>(0x7DD234D6F3914C5B, camera, p1);
        }

        public static void _SET_CAM_DOF_FOCUS_DISTANCE_BIAS(int camera, float p1)
        {
            Invoker.Call<Void>(0xC669EEA5D031B7DE, camera, p1);
        }

        public static void _SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE(int camera, float p1)
        {
            Invoker.Call<Void>(0xC3654A441402562D, camera, p1);
        }

        public static void _SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL(int camera, float p1)
        {
            Invoker.Call<Void>(0x2C654B4943BDDF7C, camera, p1);
        }

        public static void ATTACH_CAM_TO_ENTITY(int cam, int entity, float xOffset, float yOffset, float zOffset, bool isRelative)
        {
            Invoker.Call<Void>(0xFEDB7D269E8C60E3, cam, entity, xOffset, yOffset, zOffset, isRelative);
        }

        public static void ATTACH_CAM_TO_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool heading)
        {
            Invoker.Call<Void>(0x61A3DBA14AB7F411, cam, ped, boneIndex, x, y, z, heading);
        }

        public static void DETACH_CAM(int cam)
        {
            Invoker.Call<Void>(0xA2FABBE87F4BAD82, cam);
        }

        public static void SET_CAM_INHERIT_ROLL_VEHICLE(int cam, bool p1)
        {
            Invoker.Call<Void>(0x45F1DE9C34B93AE6, cam, p1);
        }

        public static void POINT_CAM_AT_COORD(int cam, float x, float y, float z)
        {
            Invoker.Call<Void>(0xF75497BB865F0803, cam, x, y, z);
        }

        public static void POINT_CAM_AT_ENTITY(int cam, int entity, float p2, float p3, float p4, bool p5)
        {
            Invoker.Call<Void>(0x5640BFF86B16E8DC, cam, entity, p2, p3, p4, p5);
        }

        public static void POINT_CAM_AT_PED_BONE(int cam, int ped, int boneIndex, float x, float y, float z, bool p6)
        {
            Invoker.Call<Void>(0x68B2B5F33BA63C41, cam, ped, boneIndex, x, y, z, p6);
        }

        public static void STOP_CAM_POINTING(int cam)
        {
            Invoker.Call<Void>(0xF33AB75780BA57DE, cam);
        }

        public static void SET_CAM_AFFECTS_AIMING(int cam, bool toggle)
        {
            Invoker.Call<Void>(0x8C1DC7770C51DC8D, cam, toggle);
        }

        public static void _0x661B5C8654ADD825(int p0, bool p1)
        {
            Invoker.Call<Void>(0x661B5C8654ADD825, p0, p1);
        }

        public static void _0xA2767257A320FC82(int p0, bool p1)
        {
            Invoker.Call<Void>(0xA2767257A320FC82, p0, p1);
        }

        public static void _0x271017B9BA825366(int p0, bool p1)
        {
            Invoker.Call<Void>(0x271017B9BA825366, p0, p1);
        }

        public static void SET_CAM_DEBUG_NAME(int camera, string name)
        {
            Invoker.Call<Void>(0x1B93E0107865DD40, camera, name);
        }

        public static void ADD_CAM_SPLINE_NODE(int camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int p8, int transitionType)
        {
            Invoker.Call<Void>(0x8609C75EC438FB3B, camera, x, y, z, xRot, yRot, zRot, length, p8, transitionType);
        }

        public static void _0x0A9F2A468B328E74(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x0A9F2A468B328E74, p0, p1, p2, p3);
        }

        public static void _0x0FB82563989CF4FB(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x0FB82563989CF4FB, p0, p1, p2, p3);
        }

        public static void _0x609278246A29CA34(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x609278246A29CA34, p0, p1, p2);
        }

        public static void SET_CAM_SPLINE_PHASE(int cam, float p1)
        {
            Invoker.Call<Void>(0x242B5874F0A4E052, cam, p1);
        }

        public static float GET_CAM_SPLINE_PHASE(int cam)
        {
            return Invoker.Call<float>(0xB5349E36C546509A, cam);
        }

        public static float GET_CAM_SPLINE_NODE_PHASE(int cam)
        {
            return Invoker.Call<float>(0xD9D0E694C8282C96, cam);
        }

        public static void SET_CAM_SPLINE_DURATION(int cam, int timeDuration)
        {
            Invoker.Call<Void>(0x1381539FEE034CDA, cam, timeDuration);
        }

        public static void _0xD1B0F412F109EA5D(int p0, int p1)
        {
            Invoker.Call<Void>(0xD1B0F412F109EA5D, p0, p1);
        }

        public static int GET_CAM_SPLINE_NODE_INDEX(int cam)
        {
            return Invoker.Call<int>(0xB22B17DF858716A6, cam);
        }

        public static void _0x83B8201ED82A9A2D(int p0, int p1, int p2, float p3)
        {
            Invoker.Call<Void>(0x83B8201ED82A9A2D, p0, p1, p2, p3);
        }

        public static void _0xA6385DEB180F319F(int p0, int p1, float p2)
        {
            Invoker.Call<Void>(0xA6385DEB180F319F, p0, p1, p2);
        }

        public static void OVERRIDE_CAM_SPLINE_VELOCITY(int cam, int p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x40B62FA033EB0346, cam, p1, p2, p3);
        }

        public static void OVERRIDE_CAM_SPLINE_MOTION_BLUR(int cam, int p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x7DCF7C708D292D55, cam, p1, p2, p3);
        }

        public static void _0x7BF1A54AE67AC070(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x7BF1A54AE67AC070, p0, p1, p2);
        }

        public static bool IS_CAM_SPLINE_PAUSED(int p0)
        {
            return Invoker.Call<bool>(0x0290F35C0AD97864, p0);
        }

        public static void SET_CAM_ACTIVE_WITH_INTERP(int camTo, int camFrom, int duration, int easeLocation, int easeRotation)
        {
            Invoker.Call<Void>(0x9FBDA379383A52A4, camTo, camFrom, duration, easeLocation, easeRotation);
        }

        public static bool IS_CAM_INTERPOLATING(int cam)
        {
            return Invoker.Call<bool>(0x036F97C908C2B52C, cam);
        }

        public static void SHAKE_CAM(int cam, string type, float amplitude)
        {
            Invoker.Call<Void>(0x6A25241C340D3822, cam, type, amplitude);
        }

        public static void ANIMATED_SHAKE_CAM(int cam, string p1, string p2, string p3, float amplitude)
        {
            Invoker.Call<Void>(0xA2746EEAE3E577CD, cam, p1, p2, p3, amplitude);
        }

        public static bool IS_CAM_SHAKING(int cam)
        {
            return Invoker.Call<bool>(0x6B24BFE83A2BE47B, cam);
        }

        public static void SET_CAM_SHAKE_AMPLITUDE(int cam, float amplitude)
        {
            Invoker.Call<Void>(0xD93DB43B82BC0D00, cam, amplitude);
        }

        public static void STOP_CAM_SHAKING(int cam, bool p1)
        {
            Invoker.Call<Void>(0xBDECF64367884AC3, cam, p1);
        }

        public static void _0xF4C8CF9E353AFECA(string p0, float p1)
        {
            Invoker.Call<Void>(0xF4C8CF9E353AFECA, p0, p1);
        }

        public static void _0xC2EAE3FB8CDBED31(string p0, string p1, string p2, float p3)
        {
            Invoker.Call<Void>(0xC2EAE3FB8CDBED31, p0, p1, p2, p3);
        }

        public static bool IS_SCRIPT_GLOBAL_SHAKING()
        {
            return Invoker.Call<bool>(0xC912AF078AF19212);
        }

        public static void STOP_SCRIPT_GLOBAL_SHAKING(bool p0)
        {
            Invoker.Call<Void>(0x1C9D7949FA533490, p0);
        }

        public static bool PLAY_CAM_ANIM(int cam, string animName, string animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, bool p9, int p10)
        {
            return Invoker.Call<bool>(0x9A2D0FB2E7852392, cam, animName, animDictionary, x, y, z, xRot, yRot, zRot, p9, p10);
        }

        public static bool IS_CAM_PLAYING_ANIM(int cam, string animName, string animDictionary)
        {
            return Invoker.Call<bool>(0xC90621D8A0CEECF2, cam, animName, animDictionary);
        }

        public static void SET_CAM_ANIM_CURRENT_PHASE(int cam, float phase)
        {
            Invoker.Call<Void>(0x4145A4C44FF3B5A6, cam, phase);
        }

        public static float GET_CAM_ANIM_CURRENT_PHASE(int cam)
        {
            return Invoker.Call<float>(0xA10B2DB49E92A6B0, cam);
        }

        public static bool PLAY_SYNCHRONIZED_CAM_ANIM(int p0, int p1, string animName, string animDictionary)
        {
            return Invoker.Call<bool>(0xE32EFE9AB4A9AA0C, p0, p1, animName, animDictionary);
        }

        public static void _0x503F5920162365B2(int p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0x503F5920162365B2, p0, p1, p2, p3);
        }

        public static void _SET_CAMERA_RANGE(int cam, float range)
        {
            Invoker.Call<Void>(0xF9D02130ECDD1D77, cam, range);
        }

        public static void _0xC91C6C55199308CA(int p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0xC91C6C55199308CA, p0, p1, p2, p3);
        }

        public static void _0xC8B5C4A79CC18B94(int p0)
        {
            Invoker.Call<Void>(0xC8B5C4A79CC18B94, p0);
        }

        public static bool _0x5C48A1D6E3B33179(int p0)
        {
            return Invoker.Call<bool>(0x5C48A1D6E3B33179, p0);
        }

        public static bool IS_SCREEN_FADED_OUT()
        {
            return Invoker.Call<bool>(0xB16FCE9DDC7BA182);
        }

        public static bool IS_SCREEN_FADED_IN()
        {
            return Invoker.Call<bool>(0x5A859503B0C08678);
        }

        public static bool IS_SCREEN_FADING_OUT()
        {
            return Invoker.Call<bool>(0x797AC7CB535BA28F);
        }

        public static bool IS_SCREEN_FADING_IN()
        {
            return Invoker.Call<bool>(0x5C544BC6C57AC575);
        }

        public static void DO_SCREEN_FADE_IN(int duration)
        {
            Invoker.Call<Void>(0xD4E8E24955024033, duration);
        }

        public static void DO_SCREEN_FADE_OUT(int duration)
        {
            Invoker.Call<Void>(0x891B5B39AC6302AF, duration);
        }

        public static int SET_WIDESCREEN_BORDERS(bool p0, int p1)
        {
            return Invoker.Call<int>(0xDCD4EA924F42D01A, p0, p1);
        }

        public static Vector3 GET_GAMEPLAY_CAM_COORD()
        {
            return Invoker.Call<Vector3>(0x14D6F5678D8F1B37);
        }

        public static Vector3 GET_GAMEPLAY_CAM_ROT(int rotationOrder)
        {
            return Invoker.Call<Vector3>(0x837765A25378F0BB, rotationOrder);
        }

        public static float GET_GAMEPLAY_CAM_FOV()
        {
            return Invoker.Call<float>(0x65019750A0324133);
        }

        public static void CUSTOM_MENU_COORDINATES(float p0)
        {
            Invoker.Call<Void>(0x487A82C650EB7799, p0);
        }

        public static void _0x0225778816FDC28C(float p0)
        {
            Invoker.Call<Void>(0x0225778816FDC28C, p0);
        }

        public static float GET_GAMEPLAY_CAM_RELATIVE_HEADING()
        {
            return Invoker.Call<float>(0x743607648ADD4587);
        }

        public static void SET_GAMEPLAY_CAM_RELATIVE_HEADING(float heading)
        {
            Invoker.Call<Void>(0xB4EC2312F4E5B1F1, heading);
        }

        public static float GET_GAMEPLAY_CAM_RELATIVE_PITCH()
        {
            return Invoker.Call<float>(0x3A6867B4845BEDA2);
        }

        public static void SET_GAMEPLAY_CAM_RELATIVE_PITCH(float x, float Value2)
        {
            Invoker.Call<Void>(0x6D0858B8EDFD2B7D, x, Value2);
        }

        public static void _SET_GAMEPLAY_CAM_RAW_YAW(float yaw)
        {
            Invoker.Call<Void>(0x103991D4A307D472, yaw);
        }

        public static void _SET_GAMEPLAY_CAM_RAW_PITCH(float pitch)
        {
            Invoker.Call<Void>(0x759E13EBC1C15C5A, pitch);
        }

        public static void _0x469F2ECDEC046337(bool p0)
        {
            Invoker.Call<Void>(0x469F2ECDEC046337, p0);
        }

        public static void SHAKE_GAMEPLAY_CAM(string shakeName, float intensity)
        {
            Invoker.Call<Void>(0xFD55E49555E017CF, shakeName, intensity);
        }

        public static bool IS_GAMEPLAY_CAM_SHAKING()
        {
            return Invoker.Call<bool>(0x016C090630DF1F89);
        }

        public static void SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE(float amplitude)
        {
            Invoker.Call<Void>(0xA87E00932DB4D85D, amplitude);
        }

        public static void STOP_GAMEPLAY_CAM_SHAKING(bool p0)
        {
            Invoker.Call<Void>(0x0EF93E9F3D08C178, p0);
        }

        public static void _0x8BBACBF51DA047A8(int p0)
        {
            Invoker.Call<Void>(0x8BBACBF51DA047A8, p0);
        }

        public static bool IS_GAMEPLAY_CAM_RENDERING()
        {
            return Invoker.Call<bool>(0x39B5D1B10383F0C8);
        }

        public static bool _0x3044240D2E0FA842()
        {
            return Invoker.Call<bool>(0x3044240D2E0FA842);
        }

        public static bool _0x705A276EBFF3133D()
        {
            return Invoker.Call<bool>(0x705A276EBFF3133D);
        }

        public static void _0xDB90C6CCA48940F1(bool p0)
        {
            Invoker.Call<Void>(0xDB90C6CCA48940F1, p0);
        }

        public static void _ENABLE_CROSSHAIR_THIS_FRAME()
        {
            Invoker.Call<Void>(0xEA7F0AD7E9BA676F);
        }

        public static bool IS_GAMEPLAY_CAM_LOOKING_BEHIND()
        {
            return Invoker.Call<bool>(0x70FDA869F3317EA9);
        }

        public static void _0x2AED6301F67007D5(int entity)
        {
            Invoker.Call<Void>(0x2AED6301F67007D5, entity);
        }

        public static void _0x49482F9FCD825AAA(int entity)
        {
            Invoker.Call<Void>(0x49482F9FCD825AAA, entity);
        }

        public static void _0xFD3151CD37EA2245(int p0)
        {
            Invoker.Call<Void>(0xFD3151CD37EA2245, p0);
        }

        public static void _0xDD79DF9F4D26E1C9()
        {
            Invoker.Call<Void>(0xDD79DF9F4D26E1C9);
        }

        public static bool IS_SPHERE_VISIBLE(float x, float y, float z, float radius)
        {
            return Invoker.Call<bool>(0xE33D59DA70B58FDF, x, y, z, radius);
        }

        public static bool IS_FOLLOW_PED_CAM_ACTIVE()
        {
            return Invoker.Call<bool>(0xC6D3D26810C8E0F9);
        }

        public static bool SET_FOLLOW_PED_CAM_CUTSCENE_CHAT(string p0, int p1)
        {
            return Invoker.Call<bool>(0x44A113DD6FFC48D1, p0, p1);
        }

        public static void _0x271401846BD26E92(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x271401846BD26E92, p0, p1);
        }

        public static void _0xC8391C309684595A()
        {
            Invoker.Call<Void>(0xC8391C309684595A);
        }

        public static int _CLAMP_GAMEPLAY_CAM_YAW(float minimum, float maximum)
        {
            return Invoker.Call<int>(0x8F993D26E0CA5E8E, minimum, maximum);
        }

        public static int _CLAMP_GAMEPLAY_CAM_PITCH(float minimum, float maximum)
        {
            return Invoker.Call<int>(0xA516C198B7DCA1E1, minimum, maximum);
        }

        public static void _ANIMATE_GAMEPLAY_CAM_ZOOM(float p0, float distance)
        {
            Invoker.Call<Void>(0xDF2E1F7742402E81, p0, distance);
        }

        public static int _0xE9EA16D6E54CDCA4(int p0, int p1)
        {
            return Invoker.Call<int>(0xE9EA16D6E54CDCA4, p0, p1);
        }

        public static void _DISABLE_FIRST_PERSON_CAM_THIS_FRAME()
        {
            Invoker.Call<Void>(0xDE2EF5DA284CC8DF);
        }

        public static void _0x59424BD75174C9B1()
        {
            Invoker.Call<Void>(0x59424BD75174C9B1);
        }

        public static int GET_FOLLOW_PED_CAM_ZOOM_LEVEL()
        {
            return Invoker.Call<int>(0x33E6C8EFD0CD93E9);
        }

        public static int GET_FOLLOW_PED_CAM_VIEW_MODE()
        {
            return Invoker.Call<int>(0x8D4D46230B2C353A);
        }

        public static void SET_FOLLOW_PED_CAM_VIEW_MODE(int viewMode)
        {
            Invoker.Call<Void>(0x5A4F9EDF1673F704, viewMode);
        }

        public static bool IS_FOLLOW_VEHICLE_CAM_ACTIVE()
        {
            return Invoker.Call<bool>(0xCBBDE6D335D6D496);
        }

        public static void _0x91EF6EE6419E5B97(bool p0)
        {
            Invoker.Call<Void>(0x91EF6EE6419E5B97, p0);
        }

        public static void SET_TIME_IDLE_DROP(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x9DFE13ECDC1EC196, p0, p1);
        }

        public static int GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL()
        {
            return Invoker.Call<int>(0xEE82280AB767B690);
        }

        public static void SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL(int zoomLevel)
        {
            Invoker.Call<Void>(0x19464CB6E4078C8A, zoomLevel);
        }

        public static int GET_FOLLOW_VEHICLE_CAM_VIEW_MODE()
        {
            return Invoker.Call<int>(0xA4FF579AC0E3AAAE);
        }

        public static void SET_FOLLOW_VEHICLE_CAM_VIEW_MODE(int viewMode)
        {
            Invoker.Call<Void>(0xAC253D7842768F48, viewMode);
        }

        public static int _0xEE778F8C7E1142E2(int p0)
        {
            return Invoker.Call<int>(0xEE778F8C7E1142E2, p0);
        }

        public static void _0x2A2173E46DAECD12(int p0, int p1)
        {
            Invoker.Call<Void>(0x2A2173E46DAECD12, p0, p1);
        }

        public static int _0x19CAFA3C87F7C2FF()
        {
            return Invoker.Call<int>(0x19CAFA3C87F7C2FF);
        }

        public static bool IS_AIM_CAM_ACTIVE()
        {
            return Invoker.Call<bool>(0x68EDDA28A5976D07);
        }

        public static bool _0x74BD83EA840F6BC9()
        {
            return Invoker.Call<bool>(0x74BD83EA840F6BC9);
        }

        public static bool IS_FIRST_PERSON_AIM_CAM_ACTIVE()
        {
            return Invoker.Call<bool>(0x5E346D934122613F);
        }

        public static void DISABLE_AIM_CAM_THIS_UPDATE()
        {
            Invoker.Call<Void>(0x1A31FE0049E542F6);
        }

        public static float _GET_GAMEPLAY_CAM_ZOOM()
        {
            return Invoker.Call<float>(0x7EC52CC40597D170);
        }

        public static int _0x70894BD0915C5BCA(float p0)
        {
            return Invoker.Call<int>(0x70894BD0915C5BCA, p0);
        }

        public static void _0xCED08CBE8EBB97C7(float p0, float p1)
        {
            Invoker.Call<Void>(0xCED08CBE8EBB97C7, p0, p1);
        }

        public static void _0x2F7F2B26DD3F18EE(float p0, float p1)
        {
            Invoker.Call<Void>(0x2F7F2B26DD3F18EE, p0, p1);
        }

        public static void _SET_FIRST_PERSON_CAM_PITCH_RANGE(float minAngle, float maxAngle)
        {
            Invoker.Call<Void>(0xBCFC632DB7673BF0, minAngle, maxAngle);
        }

        public static void _SET_FIRST_PERSON_CAM_NEAR_CLIP(float distance)
        {
            Invoker.Call<Void>(0x0AF7B437918103B3, distance);
        }

        public static void _SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP(float distance)
        {
            Invoker.Call<Void>(0x42156508606DE65E, distance);
        }

        public static void _0x4008EDF7D6E48175(bool p0)
        {
            Invoker.Call<Void>(0x4008EDF7D6E48175, p0);
        }

        public static Vector3 _GET_GAMEPLAY_CAM_COORDS()
        {
            return Invoker.Call<Vector3>(0xA200EB1EE790F448);
        }

        public static Vector3 _GET_GAMEPLAY_CAM_ROT(int rotationOrder)
        {
            return Invoker.Call<Vector3>(0x5B4E4C817FCC2DFB, rotationOrder);
        }

        public static int _0x26903D9CD1175F2C(int p0, int p1)
        {
            return Invoker.Call<int>(0x26903D9CD1175F2C, p0, p1);
        }

        public static float _0x80EC114669DAEFF4()
        {
            return Invoker.Call<float>(0x80EC114669DAEFF4);
        }

        public static float _0x5F35F6732C3FBBA0(int p0)
        {
            return Invoker.Call<float>(0x5F35F6732C3FBBA0, p0);
        }

        public static float _0xD0082607100D7193()
        {
            return Invoker.Call<float>(0xD0082607100D7193);
        }

        public static float _GET_GAMEPLAY_CAM_FAR_CLIP()
        {
            return Invoker.Call<float>(0xDFC8CBC606FDB0FC);
        }

        public static float _GET_GAMEPLAY_CAM_NEAR_DOF()
        {
            return Invoker.Call<float>(0xA03502FC581F7D9B);
        }

        public static float _GET_GAMEPLAY_CAM_FAR_DOF()
        {
            return Invoker.Call<float>(0x9780F32BCAF72431);
        }

        public static float _0x162F9D995753DC19()
        {
            return Invoker.Call<float>(0x162F9D995753DC19);
        }

        public static void SET_GAMEPLAY_COORD_HINT(float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int unk)
        {
            Invoker.Call<Void>(0xD51ADCD2D8BC0FB3, x, y, z, duration, blendOutDuration, blendInDuration, unk);
        }

        public static void SET_GAMEPLAY_PED_HINT(int p0, float x1, float y1, float z1, bool p4, int p5, int p6, int p7)
        {
            Invoker.Call<Void>(0x2B486269ACD548D3, p0, x1, y1, z1, p4, p5, p6, p7);
        }

        public static void SET_GAMEPLAY_VEHICLE_HINT(int p0, float p1, float p2, float p3, bool p4, int p5, int p6, int p7)
        {
            Invoker.Call<Void>(0xA2297E18F3E71C2E, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void SET_GAMEPLAY_OBJECT_HINT(int p0, float p1, float p2, float p3, bool p4, int p5, int p6, int p7)
        {
            Invoker.Call<Void>(0x83E87508A2CA2AC6, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void SET_GAMEPLAY_ENTITY_HINT(int entity, float xOffset, float yOffset, float zOffset, bool p4, int p5, int p6, int p7, int p8)
        {
            Invoker.Call<Void>(0x189E955A8313E298, entity, xOffset, yOffset, zOffset, p4, p5, p6, p7, p8);
        }

        public static bool IS_GAMEPLAY_HINT_ACTIVE()
        {
            return Invoker.Call<bool>(0xE520FF1AD2785B40);
        }

        public static void STOP_GAMEPLAY_HINT(bool p0)
        {
            Invoker.Call<Void>(0xF46C581C61718916, p0);
        }

        public static void _0xCCD078C2665D2973(bool p0)
        {
            Invoker.Call<Void>(0xCCD078C2665D2973, p0);
        }

        public static void _0x247ACBC4ABBC9D1C(bool p0)
        {
            Invoker.Call<Void>(0x247ACBC4ABBC9D1C, p0);
        }

        public static int _0xBF72910D0F26F025()
        {
            return Invoker.Call<int>(0xBF72910D0F26F025);
        }

        public static void SET_GAMEPLAY_HINT_FOV(float FOV)
        {
            Invoker.Call<Void>(0x513403FB9C56211F, FOV);
        }

        public static void _0xF8BDBF3D573049A1(float p0)
        {
            Invoker.Call<Void>(0xF8BDBF3D573049A1, p0);
        }

        public static void _0xD1F8363DFAD03848(float p0)
        {
            Invoker.Call<Void>(0xD1F8363DFAD03848, p0);
        }

        public static void _0x5D7B620DAE436138(float p0)
        {
            Invoker.Call<Void>(0x5D7B620DAE436138, p0);
        }

        public static void _0xC92717EF615B6704(float p0)
        {
            Invoker.Call<Void>(0xC92717EF615B6704, p0);
        }

        public static void GET_IS_MULTIPLAYER_BRIEF(bool p0)
        {
            Invoker.Call<Void>(0xE3433EADAAF7EE40, p0);
        }

        public static void SET_CINEMATIC_BUTTON_ACTIVE(bool p0)
        {
            Invoker.Call<Void>(0x51669F7D1FB53D9F, p0);
        }

        public static bool IS_CINEMATIC_CAM_RENDERING()
        {
            return Invoker.Call<bool>(0xB15162CB5826E9E8);
        }

        public static void SHAKE_CINEMATIC_CAM(string p0, float p1)
        {
            Invoker.Call<Void>(0xDCE214D9ED58F3CF, p0, p1);
        }

        public static bool IS_CINEMATIC_CAM_SHAKING()
        {
            return Invoker.Call<bool>(0xBBC08F6B4CB8FF0A);
        }

        public static void SET_CINEMATIC_CAM_SHAKE_AMPLITUDE(float p0)
        {
            Invoker.Call<Void>(0xC724C701C30B2FE7, p0);
        }

        public static void STOP_CINEMATIC_CAM_SHAKING(bool p0)
        {
            Invoker.Call<Void>(0x2238E588E588A6D7, p0);
        }

        public static void _DISABLE_VEHICLE_FIRST_PERSON_CAM_THIS_FRAME()
        {
            Invoker.Call<Void>(0xADFF1B2A555F5FBA);
        }

        public static void _0x62ECFCFDEE7885D6()
        {
            Invoker.Call<Void>(0x62ECFCFDEE7885D6);
        }

        public static void _0x9E4CFFF989258472()
        {
            Invoker.Call<Void>(0x9E4CFFF989258472);
        }

        public static void _0xF4F2C0D4EE209E20()
        {
            Invoker.Call<Void>(0xF4F2C0D4EE209E20);
        }

        public static bool _0xCA9D2AA3E326D720()
        {
            return Invoker.Call<bool>(0xCA9D2AA3E326D720);
        }

        public static bool _IS_IN_VEHICLE_CAM_DISABLED()
        {
            return Invoker.Call<bool>(0x4F32C0D5A90A9B40);
        }

        public static void CREATE_CINEMATIC_SHOT(int p0, int p1, int p2, int entity)
        {
            Invoker.Call<Void>(0x741B0129D4560F31, p0, p1, p2, entity);
        }

        public static bool IS_CINEMATIC_SHOT_ACTIVE(int p0)
        {
            return Invoker.Call<bool>(0xCC9F3371A7C28BC9, p0);
        }

        public static void STOP_CINEMATIC_SHOT(int p0)
        {
            Invoker.Call<Void>(0x7660C6E75D3A078E, p0);
        }

        public static void _0xA41BCD7213805AAC(bool p0)
        {
            Invoker.Call<Void>(0xA41BCD7213805AAC, p0);
        }

        public static void _0xDC9DA9E8789F5246()
        {
            Invoker.Call<Void>(0xDC9DA9E8789F5246);
        }

        public static void SET_CINEMATIC_MODE_ACTIVE(bool p0)
        {
            Invoker.Call<Void>(0xDCF0754AC3D6FD4E, p0);
        }

        public static int _0x1F2300CB7FA7B7F6()
        {
            return Invoker.Call<int>(0x1F2300CB7FA7B7F6);
        }

        public static int _0x17FCA7199A530203()
        {
            return Invoker.Call<int>(0x17FCA7199A530203);
        }

        public static void STOP_CUTSCENE_CAM_SHAKING()
        {
            Invoker.Call<Void>(0xDB629FFD9285FA06);
        }

        public static void _0x12DED8CA53D47EA5(float p0)
        {
            Invoker.Call<Void>(0x12DED8CA53D47EA5, p0);
        }

        public static int _0x89215EC747DF244A(float p0, int p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8)
        {
            return Invoker.Call<int>(0x89215EC747DF244A, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void _0x5A43C76F7FC7BA5F()
        {
            Invoker.Call<Void>(0x5A43C76F7FC7BA5F);
        }

        public static void _SET_CAM_EFFECT(int p0)
        {
            Invoker.Call<Void>(0x80C8B1846639BB19, p0);
        }

        public static void _0x5C41E6BABC9E2112(int p0)
        {
            Invoker.Call<Void>(0x5C41E6BABC9E2112, p0);
        }

        public static void _0x21E253A7F8DA5DFB(string vehicleName)
        {
            Invoker.Call<Void>(0x21E253A7F8DA5DFB, vehicleName);
        }

        public static void _0x11FA5D3479C7DD47(int p0)
        {
            Invoker.Call<Void>(0x11FA5D3479C7DD47, p0);
        }

        public static int _0xEAF0FA793D05C592()
        {
            return Invoker.Call<int>(0xEAF0FA793D05C592);
        }

        public static int _0x8BFCEB5EA1B161B6()
        {
            return Invoker.Call<int>(0x8BFCEB5EA1B161B6);
        }

    }

    public static class WEAPON
    {

        public static void ENABLE_LASER_SIGHT_RENDERING(bool toggle)
        {
            Invoker.Call<Void>(0xC8B46D7727D864AA, toggle);
        }

        public static int GET_WEAPON_COMPONENT_TYPE_MODEL(int componentHash)
        {
            return Invoker.Call<int>(0x0DB57B41EC1DB083, componentHash);
        }

        public static int GET_WEAPONTYPE_MODEL(int weaponHash)
        {
            return Invoker.Call<int>(0xF46CDC33180FDA94, weaponHash);
        }

        public static int GET_WEAPONTYPE_SLOT(int weaponHash)
        {
            return Invoker.Call<int>(0x4215460B9B8B7FA0, weaponHash);
        }

        public static int GET_WEAPONTYPE_GROUP(int weaponHash)
        {
            return Invoker.Call<int>(0xC3287EE3050FB74C, weaponHash);
        }

        public static void SET_CURRENT_PED_WEAPON(int ped, int weaponHash, bool equipNow)
        {
            Invoker.Call<Void>(0xADF692B254977C0C, ped, weaponHash, equipNow);
        }

        public static bool GET_CURRENT_PED_WEAPON(int ped, ulong weaponHash_ptr, bool p2)
        {
            return Invoker.Call<bool>(0x3A87E44BB9A01D54, ped, weaponHash_ptr, p2);
        }

        public static int GET_CURRENT_PED_WEAPON_ENTITY_INDEX(int ped)
        {
            return Invoker.Call<int>(0x3B390A939AF0B5FC, ped);
        }

        public static int GET_BEST_PED_WEAPON(int ped, bool p1)
        {
            return Invoker.Call<int>(0x8483E98E8B888AE2, ped, p1);
        }

        public static bool SET_CURRENT_PED_VEHICLE_WEAPON(int ped, int weaponHash)
        {
            return Invoker.Call<bool>(0x75C55983C2C39DAA, ped, weaponHash);
        }

        public static bool GET_CURRENT_PED_VEHICLE_WEAPON(int ped, ulong weaponHash_ptr)
        {
            return Invoker.Call<bool>(0x1017582BCD3832DC, ped, weaponHash_ptr);
        }

        public static bool IS_PED_ARMED(int ped, int p1)
        {
            return Invoker.Call<bool>(0x475768A975D5AD17, ped, p1);
        }

        public static bool IS_WEAPON_VALID(int weaponHash)
        {
            return Invoker.Call<bool>(0x937C71165CF334B3, weaponHash);
        }

        public static bool HAS_PED_GOT_WEAPON(int ped, int weaponHash, bool p2)
        {
            return Invoker.Call<bool>(0x8DECB02F88F428BC, ped, weaponHash, p2);
        }

        public static bool IS_PED_WEAPON_READY_TO_SHOOT(int ped)
        {
            return Invoker.Call<bool>(0xB80CA294F2F26749, ped);
        }

        public static int GET_PED_WEAPONTYPE_IN_SLOT(int ped, int weaponSlot)
        {
            return Invoker.Call<int>(0xEFFED78E9011134D, ped, weaponSlot);
        }

        public static int GET_AMMO_IN_PED_WEAPON(int ped, int weaponhash)
        {
            return Invoker.Call<int>(0x015A522136D7F951, ped, weaponhash);
        }

        public static void ADD_AMMO_TO_PED(int ped, int weaponHash, int ammo)
        {
            Invoker.Call<Void>(0x78F0424C34306220, ped, weaponHash, ammo);
        }

        public static void SET_PED_AMMO(int ped, int weaponHash, int ammo)
        {
            Invoker.Call<Void>(0x14E56BC5B5DB6A19, ped, weaponHash, ammo);
        }

        public static void SET_PED_INFINITE_AMMO(int ped, bool toggle, int weaponHash)
        {
            Invoker.Call<Void>(0x3EDCB0505123623B, ped, toggle, weaponHash);
        }

        public static void SET_PED_INFINITE_AMMO_CLIP(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x183DADC6AA953186, ped, toggle);
        }

        public static void GIVE_WEAPON_TO_PED(int ped, int weaponHash, int ammoCount, bool isHidden, bool equipNow)
        {
            Invoker.Call<Void>(0xBF0FD6E56C964FCB, ped, weaponHash, ammoCount, isHidden, equipNow);
        }

        public static void GIVE_DELAYED_WEAPON_TO_PED(int ped, int weaponHash, int ammoCount, bool equipNow)
        {
            Invoker.Call<Void>(0xB282DC6EBD803C75, ped, weaponHash, ammoCount, equipNow);
        }

        public static void REMOVE_ALL_PED_WEAPONS(int ped, bool p1)
        {
            Invoker.Call<Void>(0xF25DF915FA38C5F3, ped, p1);
        }

        public static void REMOVE_WEAPON_FROM_PED(int ped, int weaponHash)
        {
            Invoker.Call<Void>(0x4899CB088EDF59B8, ped, weaponHash);
        }

        public static void HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x6F6981D2253C208F, ped, toggle);
        }

        public static void SET_PED_CURRENT_WEAPON_VISIBLE(int ped, bool visible, bool deselectWeapon, bool p3, bool p4)
        {
            Invoker.Call<Void>(0x0725A4CCFDED9A70, ped, visible, deselectWeapon, p3, p4);
        }

        public static void SET_PED_DROPS_WEAPONS_WHEN_DEAD(int ped, bool toggle)
        {
            Invoker.Call<Void>(0x476AE72C1D19D1A8, ped, toggle);
        }

        public static bool HAS_PED_BEEN_DAMAGED_BY_WEAPON(int ped, int weaponHash, int weaponType)
        {
            return Invoker.Call<bool>(0x2D343D2219CD027A, ped, weaponHash, weaponType);
        }

        public static void CLEAR_PED_LAST_WEAPON_DAMAGE(int ped)
        {
            Invoker.Call<Void>(0x0E98F88A24C5F4B8, ped);
        }

        public static bool HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON(int entity, int weaponHash, int weaponType)
        {
            return Invoker.Call<bool>(0x131D401334815E94, entity, weaponHash, weaponType);
        }

        public static void CLEAR_ENTITY_LAST_WEAPON_DAMAGE(int entity)
        {
            Invoker.Call<Void>(0xAC678E40BE7C74D2, entity);
        }

        public static void SET_PED_DROPS_WEAPON(int ped)
        {
            Invoker.Call<Void>(0x6B7513D9966FBEC0, ped);
        }

        public static void SET_PED_DROPS_INVENTORY_WEAPON(int ped, int weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount)
        {
            Invoker.Call<Void>(0x208A1888007FC0E6, ped, weaponHash, xOffset, yOffset, zOffset, ammoCount);
        }

        public static int GET_MAX_AMMO_IN_CLIP(int ped, int weaponHash, bool p2)
        {
            return Invoker.Call<int>(0xA38DCFFCEA8962FA, ped, weaponHash, p2);
        }

        public static bool GET_AMMO_IN_CLIP(int ped, int weaponHash, ulong ammo_ptr)
        {
            return Invoker.Call<bool>(0x2E1202248937775C, ped, weaponHash, ammo_ptr);
        }

        public static bool SET_AMMO_IN_CLIP(int ped, int weaponHash, int ammo)
        {
            return Invoker.Call<bool>(0xDCD2A934D65CB497, ped, weaponHash, ammo);
        }

        public static bool GET_MAX_AMMO(int ped, int weaponHash, ulong ammo_ptr)
        {
            return Invoker.Call<bool>(0xDC16122C7A20C933, ped, weaponHash, ammo_ptr);
        }

        public static void SET_PED_AMMO_BY_TYPE(int ped, int ammoType, int ammo)
        {
            Invoker.Call<Void>(0x5FD1E1F011E76D7E, ped, ammoType, ammo);
        }

        public static int GET_PED_AMMO_BY_TYPE(int ped, int ammoType)
        {
            return Invoker.Call<int>(0x39D22031557946C1, ped, ammoType);
        }

        public static void SET_PED_AMMO_TO_DROP(int ammoType, int ammo)
        {
            Invoker.Call<Void>(0xA4EFEF9440A5B0EF, ammoType, ammo);
        }

        public static void _0xE620FD3512A04F18(float p0)
        {
            Invoker.Call<Void>(0xE620FD3512A04F18, p0);
        }

        public static int GET_PED_AMMO_TYPE_FROM_WEAPON(int ped, int weaponHash)
        {
            return Invoker.Call<int>(0x7FEAD38B326B9F74, ped, weaponHash);
        }

        public static bool GET_PED_LAST_WEAPON_IMPACT_COORD(int ped, ulong coords_ptr)
        {
            return Invoker.Call<bool>(0x6C4D0409BA1A2BC2, ped, coords_ptr);
        }

        public static void SET_PED_GADGET(int ped, int gadgetHash, bool p2)
        {
            Invoker.Call<Void>(0xD0D7B1E680ED4A1A, ped, gadgetHash, p2);
        }

        public static bool GET_IS_PED_GADGET_EQUIPPED(int ped, int gadgetHash)
        {
            return Invoker.Call<bool>(0xF731332072F5156C, ped, gadgetHash);
        }

        public static int GET_SELECTED_PED_WEAPON(int ped)
        {
            return Invoker.Call<int>(0x0A6DB4965674D243, ped);
        }

        public static void EXPLODE_PROJECTILES(int ped, int weaponHash, bool p2)
        {
            Invoker.Call<Void>(0xFC4BD125DE7611E4, ped, weaponHash, p2);
        }

        public static void REMOVE_ALL_PROJECTILES_OF_TYPE(int weaponHash, bool p1)
        {
            Invoker.Call<Void>(0xFC52E0F37E446528, weaponHash, p1);
        }

        public static float _GET_LOCKON_RANGE_OF_CURRENT_PED_WEAPON(int ped)
        {
            return Invoker.Call<float>(0x840F03E9041E2C9C, ped);
        }

        public static float GET_MAX_RANGE_OF_CURRENT_PED_WEAPON(int ped)
        {
            return Invoker.Call<float>(0x814C9D19DFD69679, ped);
        }

        public static bool HAS_VEHICLE_GOT_PROJECTILE_ATTACHED(int driver, int vehicle, int weaponHash, int p3)
        {
            return Invoker.Call<bool>(0x717C8481234E3B88, driver, vehicle, weaponHash, p3);
        }

        public static void GIVE_WEAPON_COMPONENT_TO_PED(int ped, int weaponHash, int componentHash)
        {
            Invoker.Call<Void>(0xD966D51AA5B28BB9, ped, weaponHash, componentHash);
        }

        public static void REMOVE_WEAPON_COMPONENT_FROM_PED(int ped, int weaponHash, int componentHash)
        {
            Invoker.Call<Void>(0x1E8BE90C74FB4C09, ped, weaponHash, componentHash);
        }

        public static bool HAS_PED_GOT_WEAPON_COMPONENT(int ped, int weaponHash, int componentHash)
        {
            return Invoker.Call<bool>(0xC593212475FAE340, ped, weaponHash, componentHash);
        }

        public static bool IS_PED_WEAPON_COMPONENT_ACTIVE(int ped, int weaponHash, int componentHash)
        {
            return Invoker.Call<bool>(0x0D78DE0572D3969E, ped, weaponHash, componentHash);
        }

        public static bool _PED_SKIP_NEXT_RELOADING(int ped)
        {
            return Invoker.Call<bool>(0x8C0D57EA686FAD87, ped);
        }

        public static bool MAKE_PED_RELOAD(int ped)
        {
            return Invoker.Call<bool>(0x20AE33F3AC9C0033, ped);
        }

        public static void REQUEST_WEAPON_ASSET(int weaponHash, int p1, int p2)
        {
            Invoker.Call<Void>(0x5443438F033E29C3, weaponHash, p1, p2);
        }

        public static bool HAS_WEAPON_ASSET_LOADED(int weaponHash)
        {
            return Invoker.Call<bool>(0x36E353271F0E90EE, weaponHash);
        }

        public static void REMOVE_WEAPON_ASSET(int weaponHash)
        {
            Invoker.Call<Void>(0xAA08EF13F341C8FC, weaponHash);
        }

        public static int CREATE_WEAPON_OBJECT(int weaponHash, int ammoCount, float x, float y, float z, bool showWorldModel, float heading, int p7)
        {
            return Invoker.Call<int>(0x9541D3CF0D398F36, weaponHash, ammoCount, x, y, z, showWorldModel, heading, p7);
        }

        public static void GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT(int weaponObject, int addonHash)
        {
            Invoker.Call<Void>(0x33E179436C0B31DB, weaponObject, addonHash);
        }

        public static void REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT(int p0, int p1)
        {
            Invoker.Call<Void>(0xF7D82B0D66777611, p0, p1);
        }

        public static bool HAS_WEAPON_GOT_WEAPON_COMPONENT(int weapon, int addonHash)
        {
            return Invoker.Call<bool>(0x76A18844E743BF91, weapon, addonHash);
        }

        public static void GIVE_WEAPON_OBJECT_TO_PED(int weaponObject, int ped)
        {
            Invoker.Call<Void>(0xB1FA61371AF7C4B7, weaponObject, ped);
        }

        public static bool DOES_WEAPON_TAKE_WEAPON_COMPONENT(int weaponHash, int componentHash)
        {
            return Invoker.Call<bool>(0x5CEE3DF569CECAB0, weaponHash, componentHash);
        }

        public static int GET_WEAPON_OBJECT_FROM_PED(int ped, bool p1)
        {
            return Invoker.Call<int>(0xCAE1DC9A0E22A16D, ped, p1);
        }

        public static void SET_PED_WEAPON_TINT_INDEX(int ped, int weaponHash, int tintIndex)
        {
            Invoker.Call<Void>(0x50969B9B89ED5738, ped, weaponHash, tintIndex);
        }

        public static int GET_PED_WEAPON_TINT_INDEX(int ped, int weaponHash)
        {
            return Invoker.Call<int>(0x2B9EEDC07BD06B9F, ped, weaponHash);
        }

        public static void SET_WEAPON_OBJECT_TINT_INDEX(int weapon, int tintIndex)
        {
            Invoker.Call<Void>(0xF827589017D4E4A9, weapon, tintIndex);
        }

        public static int GET_WEAPON_OBJECT_TINT_INDEX(int weapon)
        {
            return Invoker.Call<int>(0xCD183314F7CD2E57, weapon);
        }

        public static int GET_WEAPON_TINT_COUNT(int weaponHash)
        {
            return Invoker.Call<int>(0x5DCF6C5CAB2E9BF7, weaponHash);
        }

        public static bool GET_WEAPON_HUD_STATS(int weaponHash, ulong _outData_ptr)
        {
            return Invoker.Call<bool>(0xD92C739EE34C9EBA, weaponHash, _outData_ptr);
        }

        public static bool GET_WEAPON_COMPONENT_HUD_STATS(int componentHash, ulong _outData_ptr)
        {
            return Invoker.Call<bool>(0xB3CAF387AE12E9F8, componentHash, _outData_ptr);
        }

        public static float _0x3133B907D8B32053(int p0, int p1)
        {
            return Invoker.Call<float>(0x3133B907D8B32053, p0, p1);
        }

        public static int GET_WEAPON_CLIP_SIZE(int weaponHash)
        {
            return Invoker.Call<int>(0x583BE370B1EC6EB4, weaponHash);
        }

        public static void SET_PED_CHANCE_OF_FIRING_BLANKS(int ped, float xBias, float yBias)
        {
            Invoker.Call<Void>(0x8378627201D5497D, ped, xBias, yBias);
        }

        public static int _0xB4C8D77C80C0421E(int ped, float p1)
        {
            return Invoker.Call<int>(0xB4C8D77C80C0421E, ped, p1);
        }

        public static void REQUEST_WEAPON_HIGH_DETAIL_MODEL(int weaponObject)
        {
            Invoker.Call<Void>(0x48164DBB970AC3F0, weaponObject);
        }

        public static bool IS_PED_CURRENT_WEAPON_SILENCED(int ped)
        {
            return Invoker.Call<bool>(0x65F0C5AE05943EC7, ped);
        }

        public static bool SET_WEAPON_SMOKEGRENADE_ASSIGNED(int ped)
        {
            return Invoker.Call<bool>(0x4B7620C47217126C, ped);
        }

        public static int SET_FLASH_LIGHT_FADE_DISTANCE(float distance)
        {
            return Invoker.Call<int>(0xCEA66DAD478CD39B, distance);
        }

        public static void SET_WEAPON_ANIMATION_OVERRIDE(int ped, int animStyle)
        {
            Invoker.Call<Void>(0x1055AC3A667F09D9, ped, animStyle);
        }

        public static int GET_WEAPON_DAMAGE_TYPE(int weaponHash)
        {
            return Invoker.Call<int>(0x3BE0BB12D25FB305, weaponHash);
        }

        public static void _0xE4DCEC7FD5B739A5(int ped)
        {
            Invoker.Call<Void>(0xE4DCEC7FD5B739A5, ped);
        }

        public static bool CAN_USE_WEAPON_ON_PARACHUTE(int weaponHash)
        {
            return Invoker.Call<bool>(0xBC7BE5ABC0879F74, weaponHash);
        }

    }

    public static class ITEMSET
    {

        public static int CREATE_ITEMSET(int distri)
        {
            return Invoker.Call<int>(0x35AD299F50D91B24, distri);
        }

        public static void DESTROY_ITEMSET(int p0)
        {
            Invoker.Call<Void>(0xDE18220B1C183EDA, p0);
        }

        public static bool IS_ITEMSET_VALID(int p0)
        {
            return Invoker.Call<bool>(0xB1B1EA596344DFAB, p0);
        }

        public static bool ADD_TO_ITEMSET(int p0, int p1)
        {
            return Invoker.Call<bool>(0xE3945201F14637DD, p0, p1);
        }

        public static void REMOVE_FROM_ITEMSET(int p0, int p1)
        {
            Invoker.Call<Void>(0x25E68244B0177686, p0, p1);
        }

        public static int GET_ITEMSET_SIZE(int x)
        {
            return Invoker.Call<int>(0xD9127E83ABF7C631, x);
        }

        public static int GET_INDEXED_ITEM_IN_ITEMSET(int p0, int p1)
        {
            return Invoker.Call<int>(0x7A197E2521EE2BAB, p0, p1);
        }

        public static bool IS_IN_ITEMSET(int p0, int p1)
        {
            return Invoker.Call<bool>(0x2D0FC594D1E9C107, p0, p1);
        }

        public static void CLEAN_ITEMSET(int p0)
        {
            Invoker.Call<Void>(0x41BC0D722FC04221, p0);
        }

    }

    public static class STREAMING
    {

        public static void LOAD_ALL_OBJECTS_NOW()
        {
            Invoker.Call<Void>(0xBD6E84632DD4CB3F);
        }

        public static void LOAD_SCENE(float x, float y, float z)
        {
            Invoker.Call<Void>(0x4448EB75B4904BDB, x, y, z);
        }

        public static ulong NETWORK_UPDATE_LOAD_SCENE()
        {
            return Invoker.Call<ulong>(0xC4582015556D1C46);
        }

        public static void NETWORK_STOP_LOAD_SCENE()
        {
            Invoker.Call<Void>(0x64E630FAF5F60F44);
        }

        public static bool IS_NETWORK_LOADING_SCENE()
        {
            return Invoker.Call<bool>(0x41CA5A33160EA4AB);
        }

        public static void SET_INTERIOR_ACTIVE(int interiorID, bool toggle)
        {
            Invoker.Call<Void>(0xE37B76C387BE28ED, interiorID, toggle);
        }

        public static void REQUEST_MODEL(int model)
        {
            Invoker.Call<Void>(0x963D27A58DF860AC, model);
        }

        public static void REQUEST_MENU_PED_MODEL(int model)
        {
            Invoker.Call<Void>(0xA0261AEF7ACFC51E, model);
        }

        public static bool HAS_MODEL_LOADED(int model)
        {
            return Invoker.Call<bool>(0x98A4EB5D89A0C952, model);
        }

        public static void _REQUEST_INTERIOR_ROOM_BY_NAME(int interiorID, string roomName)
        {
            Invoker.Call<Void>(0x8A7A40100EDFEC58, interiorID, roomName);
        }

        public static void SET_MODEL_AS_NO_LONGER_NEEDED(int model)
        {
            Invoker.Call<Void>(0xE532F5D78798DAAB, model);
        }

        public static bool IS_MODEL_IN_CDIMAGE(int model)
        {
            return Invoker.Call<bool>(0x35B9E0803292B641, model);
        }

        public static bool IS_MODEL_VALID(int model)
        {
            return Invoker.Call<bool>(0xC0296A2EDF545E92, model);
        }

        public static bool IS_MODEL_A_VEHICLE(int model)
        {
            return Invoker.Call<bool>(0x19AAC8F07BFEC53E, model);
        }

        public static int REQUEST_COLLISION_AT_COORD(float x, float y, float z)
        {
            return Invoker.Call<int>(0x07503F7948F491A7, x, y, z);
        }

        public static void REQUEST_COLLISION_FOR_MODEL(int model)
        {
            Invoker.Call<Void>(0x923CB32A3B874FCB, model);
        }

        public static bool HAS_COLLISION_FOR_MODEL_LOADED(int model)
        {
            return Invoker.Call<bool>(0x22CCA434E368F03A, model);
        }

        public static void REQUEST_ADDITIONAL_COLLISION_AT_COORD(float x, float y, float z)
        {
            Invoker.Call<Void>(0xC9156DC11411A9EA, x, y, z);
        }

        public static bool DOES_ANIM_DICT_EXIST(string animDict)
        {
            return Invoker.Call<bool>(0x2DA49C3B79856961, animDict);
        }

        public static void REQUEST_ANIM_DICT(string animDict)
        {
            Invoker.Call<Void>(0xD3BD40951412FEF6, animDict);
        }

        public static bool HAS_ANIM_DICT_LOADED(string animDict)
        {
            return Invoker.Call<bool>(0xD031A9162D01088C, animDict);
        }

        public static void REMOVE_ANIM_DICT(string animDict)
        {
            Invoker.Call<Void>(0xF66A602F829E2A06, animDict);
        }

        public static void REQUEST_ANIM_SET(string animSet)
        {
            Invoker.Call<Void>(0x6EA47DAE7FAD0EED, animSet);
        }

        public static bool HAS_ANIM_SET_LOADED(string animSet)
        {
            return Invoker.Call<bool>(0xC4EA073D86FB29B0, animSet);
        }

        public static void REMOVE_ANIM_SET(string animSet)
        {
            Invoker.Call<Void>(0x16350528F93024B3, animSet);
        }

        public static void REQUEST_CLIP_SET(string clipSet)
        {
            Invoker.Call<Void>(0xD2A71E1A77418A49, clipSet);
        }

        public static bool HAS_CLIP_SET_LOADED(string clipSet)
        {
            return Invoker.Call<bool>(0x318234F4F3738AF3, clipSet);
        }

        public static void REMOVE_CLIP_SET(string clipSet)
        {
            Invoker.Call<Void>(0x01F73A131C18CD94, clipSet);
        }

        public static void REQUEST_IPL(string iplName)
        {
            Invoker.Call<Void>(0x41B4893843BBDB74, iplName);
        }

        public static void REMOVE_IPL(string iplName)
        {
            Invoker.Call<Void>(0xEE6C5AD3ECE0A82D, iplName);
        }

        public static bool IS_IPL_ACTIVE(string iplName)
        {
            return Invoker.Call<bool>(0x88A741E44A2B3495, iplName);
        }

        public static void SET_STREAMING(bool toggle)
        {
            Invoker.Call<Void>(0x6E0C692677008888, toggle);
        }

        public static void SET_GAME_PAUSES_FOR_STREAMING(bool toggle)
        {
            Invoker.Call<Void>(0x717CD6E6FAEBBEDC, toggle);
        }

        public static void SET_REDUCE_PED_MODEL_BUDGET(bool toggle)
        {
            Invoker.Call<Void>(0x77B5F9A36BF96710, toggle);
        }

        public static void SET_REDUCE_VEHICLE_MODEL_BUDGET(bool toggle)
        {
            Invoker.Call<Void>(0x80C527893080CCF3, toggle);
        }

        public static void SET_DITCH_POLICE_MODELS(bool toggle)
        {
            Invoker.Call<Void>(0x42CBE54462D92634, toggle);
        }

        public static int GET_NUMBER_OF_STREAMING_REQUESTS()
        {
            return Invoker.Call<int>(0x4060057271CEBC89);
        }

        public static int REQUEST_PTFX_ASSET()
        {
            return Invoker.Call<int>(0x944955FB2A3935C8);
        }

        public static bool HAS_PTFX_ASSET_LOADED()
        {
            return Invoker.Call<bool>(0xCA7D9B86ECA7481B);
        }

        public static void REMOVE_PTFX_ASSET()
        {
            Invoker.Call<Void>(0x88C6814073DD4A73);
        }

        public static void REQUEST_NAMED_PTFX_ASSET(string assetName)
        {
            Invoker.Call<Void>(0xB80D8756B4668AB6, assetName);
        }

        public static bool HAS_NAMED_PTFX_ASSET_LOADED(string assetName)
        {
            return Invoker.Call<bool>(0x8702416E512EC454, assetName);
        }

        public static void _REMOVE_NAMED_PTFX_ASSET(string assetName)
        {
            Invoker.Call<Void>(0x5F61EBBE1A00F96D, assetName);
        }

        public static void SET_VEHICLE_POPULATION_BUDGET(int p0)
        {
            Invoker.Call<Void>(0xCB9E1EB3BE2AF4E9, p0);
        }

        public static void SET_PED_POPULATION_BUDGET(int p0)
        {
            Invoker.Call<Void>(0x8C95333CFC3340F3, p0);
        }

        public static void CLEAR_FOCUS()
        {
            Invoker.Call<Void>(0x31B73D1EA9F01DA2);
        }

        public static void _SET_FOCUS_AREA(float x, float y, float z, float offsetX, float offsetY, float offsetZ)
        {
            Invoker.Call<Void>(0xBB7454BAFF08FE25, x, y, z, offsetX, offsetY, offsetZ);
        }

        public static void SET_FOCUS_ENTITY(int entity)
        {
            Invoker.Call<Void>(0x198F77705FA0931D, entity);
        }

        public static bool IS_ENTITY_FOCUS(int entity)
        {
            return Invoker.Call<bool>(0x2DDFF3FB9075D747, entity);
        }

        public static void _0x0811381EF5062FEC(int p0)
        {
            Invoker.Call<Void>(0x0811381EF5062FEC, p0);
        }

        public static void _0xAF12610C644A35C9(string p0, bool p1)
        {
            Invoker.Call<Void>(0xAF12610C644A35C9, p0, p1);
        }

        public static void _0x4E52E752C76E7E7A(int p0)
        {
            Invoker.Call<Void>(0x4E52E752C76E7E7A, p0);
        }

        public static int FORMAT_FOCUS_HEADING(float x, float y, float z, float rad, int p4, int p5)
        {
            return Invoker.Call<int>(0x219C7B8D53E429FD, x, y, z, rad, p4, p5);
        }

        public static int _0x1F3F018BC3AFA77C(float p0, float p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8)
        {
            return Invoker.Call<int>(0x1F3F018BC3AFA77C, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static int _0x0AD9710CEE2F590F(float p0, float p1, float p2, float p3, float p4, float p5, int p6)
        {
            return Invoker.Call<int>(0x0AD9710CEE2F590F, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void _0x1EE7D8DF4425F053(int p0)
        {
            Invoker.Call<Void>(0x1EE7D8DF4425F053, p0);
        }

        public static int _0x7D41E9D2D17C5B2D(int p0)
        {
            return Invoker.Call<int>(0x7D41E9D2D17C5B2D, p0);
        }

        public static int _0x07C313F94746702C(int p0)
        {
            return Invoker.Call<int>(0x07C313F94746702C, p0);
        }

        public static int _0xBC9823AB80A3DCAC()
        {
            return Invoker.Call<int>(0xBC9823AB80A3DCAC);
        }

        public static bool NEW_LOAD_SCENE_START(float p0, float p1, float p2, float p3, float p4, float p5, float p6, int p7)
        {
            return Invoker.Call<bool>(0x212A8D0D2BABFAC2, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static bool NEW_LOAD_SCENE_START_SPHERE(float x, float y, float z, float radius, int p4)
        {
            return Invoker.Call<bool>(0xACCFB4ACF53551B0, x, y, z, radius, p4);
        }

        public static void NEW_LOAD_SCENE_STOP()
        {
            Invoker.Call<Void>(0xC197616D221FF4A4);
        }

        public static bool IS_NEW_LOAD_SCENE_ACTIVE()
        {
            return Invoker.Call<bool>(0xA41A05B6CB741B85);
        }

        public static bool IS_NEW_LOAD_SCENE_LOADED()
        {
            return Invoker.Call<bool>(0x01B8247A7A8B9AD1);
        }

        public static int _0x71E7B2E657449AAD()
        {
            return Invoker.Call<int>(0x71E7B2E657449AAD);
        }

        public static void START_PLAYER_SWITCH(int from, int to, int flags, int switchType)
        {
            Invoker.Call<Void>(0xFAA23F2CBA159D67, from, to, flags, switchType);
        }

        public static void STOP_PLAYER_SWITCH()
        {
            Invoker.Call<Void>(0x95C0A5BBDC189AA1);
        }

        public static bool IS_PLAYER_SWITCH_IN_PROGRESS()
        {
            return Invoker.Call<bool>(0xD9D2CFFF49FAB35F);
        }

        public static int GET_PLAYER_SWITCH_TYPE()
        {
            return Invoker.Call<int>(0xB3C94A90D9FC9E62);
        }

        public static int GET_IDEAL_PLAYER_SWITCH_TYPE(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<int>(0xB5D7B26B45720E05, x1, y1, z1, x2, y2, z2);
        }

        public static int GET_PLAYER_SWITCH_STATE()
        {
            return Invoker.Call<int>(0x470555300D10B2A5);
        }

        public static int GET_PLAYER_SHORT_SWITCH_STATE()
        {
            return Invoker.Call<int>(0x20F898A5D9782800);
        }

        public static void _0x5F2013F8BC24EE69(int p0)
        {
            Invoker.Call<Void>(0x5F2013F8BC24EE69, p0);
        }

        public static int _0x78C0D93253149435()
        {
            return Invoker.Call<int>(0x78C0D93253149435);
        }

        public static void SET_PLAYER_SWITCH_OUTRO(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, int p8)
        {
            Invoker.Call<Void>(0xC208B673CE446B61, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void _0x0FDE9DBFC0A6BC65(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x0FDE9DBFC0A6BC65, p0_ptr);
        }

        public static void _0x43D1680C6D19A8E9()
        {
            Invoker.Call<Void>(0x43D1680C6D19A8E9);
        }

        public static void _0x74DE2E8739086740()
        {
            Invoker.Call<Void>(0x74DE2E8739086740);
        }

        public static void _0x8E2A065ABDAE6994()
        {
            Invoker.Call<Void>(0x8E2A065ABDAE6994);
        }

        public static void _0xAD5FDF34B81BFE79()
        {
            Invoker.Call<Void>(0xAD5FDF34B81BFE79);
        }

        public static int _0xDFA80CB25D0A19B3()
        {
            return Invoker.Call<int>(0xDFA80CB25D0A19B3);
        }

        public static void _0xD4793DFF3AF2ABCD()
        {
            Invoker.Call<Void>(0xD4793DFF3AF2ABCD);
        }

        public static void _0xBD605B8E0E18B3BB()
        {
            Invoker.Call<Void>(0xBD605B8E0E18B3BB);
        }

        public static void _SWITCH_OUT_PLAYER(int ped, int flags, int unknown)
        {
            Invoker.Call<Void>(0xAAB3200ED59016BC, ped, flags, unknown);
        }

        public static void _0xD8295AF639FD9CB8(int p0)
        {
            Invoker.Call<Void>(0xD8295AF639FD9CB8, p0);
        }

        public static int _0x933BBEEB8C61B5F4()
        {
            return Invoker.Call<int>(0x933BBEEB8C61B5F4);
        }

        public static int SET_PLAYER_INVERTED_UP()
        {
            return Invoker.Call<int>(0x08C2D6C52A3104BB);
        }

        public static int _0x5B48A06DD0E792A5()
        {
            return Invoker.Call<int>(0x5B48A06DD0E792A5);
        }

        public static int DESTROY_PLAYER_IN_PAUSE_MENU()
        {
            return Invoker.Call<int>(0x5B74EA8CFD5E3E7E);
        }

        public static void _0x1E9057A74FD73E23()
        {
            Invoker.Call<Void>(0x1E9057A74FD73E23);
        }

        public static int _0x0C15B0E443B2349D()
        {
            return Invoker.Call<int>(0x0C15B0E443B2349D);
        }

        public static void _0xA76359FC80B2438E(float p0)
        {
            Invoker.Call<Void>(0xA76359FC80B2438E, p0);
        }

        public static void _0xBED8CA5FF5E04113(float p0, float p1, float p2, float p3)
        {
            Invoker.Call<Void>(0xBED8CA5FF5E04113, p0, p1, p2, p3);
        }

        public static void _0x472397322E92A856()
        {
            Invoker.Call<Void>(0x472397322E92A856);
        }

        public static void _0x40AEFD1A244741F2(bool p0)
        {
            Invoker.Call<Void>(0x40AEFD1A244741F2, p0);
        }

        public static void _0x03F1A106BDA7DD3E()
        {
            Invoker.Call<Void>(0x03F1A106BDA7DD3E);
        }

        public static void _0x95A7DABDDBB78AE7(ulong p0_ptr, ulong p1_ptr)
        {
            Invoker.Call<Void>(0x95A7DABDDBB78AE7, p0_ptr, p1_ptr);
        }

        public static void _0x63EB2B972A218CAC()
        {
            Invoker.Call<Void>(0x63EB2B972A218CAC);
        }

        public static int _0xFB199266061F820A()
        {
            return Invoker.Call<int>(0xFB199266061F820A);
        }

        public static void _0xF4A0DADB70F57FA6()
        {
            Invoker.Call<Void>(0xF4A0DADB70F57FA6);
        }

        public static int _0x5068F488DDB54DD8()
        {
            return Invoker.Call<int>(0x5068F488DDB54DD8);
        }

        public static void PREFETCH_SRL(string srl)
        {
            Invoker.Call<Void>(0x3D245789CE12982C, srl);
        }

        public static bool IS_SRL_LOADED()
        {
            return Invoker.Call<bool>(0xD0263801A4C5B0BB);
        }

        public static void BEGIN_SRL()
        {
            Invoker.Call<Void>(0x9BADDC94EF83B823);
        }

        public static void END_SRL()
        {
            Invoker.Call<Void>(0x0A41540E63C9EE17);
        }

        public static void SET_SRL_TIME(float p0)
        {
            Invoker.Call<Void>(0xA74A541C6884E7B8, p0);
        }

        public static void _0xEF39EE20C537E98C(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0xEF39EE20C537E98C, p0, p1, p2, p3, p4, p5);
        }

        public static void _0xBEB2D9A1D9A8F55A(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xBEB2D9A1D9A8F55A, p0, p1, p2, p3);
        }

        public static void _0x20C6C7E4EB082A7F(bool p0)
        {
            Invoker.Call<Void>(0x20C6C7E4EB082A7F, p0);
        }

        public static void _0xF8155A7F03DDFC8E(int p0)
        {
            Invoker.Call<Void>(0xF8155A7F03DDFC8E, p0);
        }

        public static void SET_HD_AREA(float x, float y, float z, float radius)
        {
            Invoker.Call<Void>(0xB85F26619073E775, x, y, z, radius);
        }

        public static void CLEAR_HD_AREA()
        {
            Invoker.Call<Void>(0xCE58B1CFB9290813);
        }

        public static void _LOAD_MISSION_CREATOR_DATA()
        {
            Invoker.Call<Void>(0xB5A4DB34FE89B88A);
        }

        public static void SHUTDOWN_CREATOR_BUDGET()
        {
            Invoker.Call<Void>(0xCCE26000E9A6FAD7);
        }

        public static bool _0x0BC3144DEB678666(int modelHash)
        {
            return Invoker.Call<bool>(0x0BC3144DEB678666, modelHash);
        }

        public static void _0xF086AD9354FAC3A3(int p0)
        {
            Invoker.Call<Void>(0xF086AD9354FAC3A3, p0);
        }

        public static int _0x3D3D8B3BE5A83D35()
        {
            return Invoker.Call<int>(0x3D3D8B3BE5A83D35);
        }

    }

    public static class SCRIPT
    {

        public static void REQUEST_SCRIPT(string scriptName)
        {
            Invoker.Call<Void>(0x6EB5F71AA68F2E8E, scriptName);
        }

        public static void SET_SCRIPT_AS_NO_LONGER_NEEDED(string scriptName)
        {
            Invoker.Call<Void>(0xC90D2DCACD56184C, scriptName);
        }

        public static bool HAS_SCRIPT_LOADED(string scriptName)
        {
            return Invoker.Call<bool>(0xE6CC9F3BA0FB9EF1, scriptName);
        }

        public static bool DOES_SCRIPT_EXIST(string scriptName)
        {
            return Invoker.Call<bool>(0xFC04745FBE67C19A, scriptName);
        }

        public static void REQUEST_SCRIPT_WITH_NAME_HASH(int scriptHash)
        {
            Invoker.Call<Void>(0xD62A67D26D9653E6, scriptHash);
        }

        public static void SET_SCRIPT_WITH_NAME_HASH_AS_NO_LONGER_NEEDED(int scriptHash)
        {
            Invoker.Call<Void>(0xC5BC038960E9DB27, scriptHash);
        }

        public static bool HAS_SCRIPT_WITH_NAME_HASH_LOADED(int scriptHash)
        {
            return Invoker.Call<bool>(0x5F0F0C783EB16C04, scriptHash);
        }

        public static bool _DOES_SCRIPT_WITH_NAME_HASH_EXIST(int scriptHash)
        {
            return Invoker.Call<bool>(0xF86AA3C56BA31381, scriptHash);
        }

        public static void TERMINATE_THREAD(int threadId)
        {
            Invoker.Call<Void>(0xC8B189ED9138BCD4, threadId);
        }

        public static bool IS_THREAD_ACTIVE(int threadId)
        {
            return Invoker.Call<bool>(0x46E9AE36D8FA6417, threadId);
        }

        public static string _GET_NAME_OF_THREAD(int threadId)
        {
            return Invoker.Call<string>(0x05A42BA9FC8DA96B, threadId);
        }

        public static void _BEGIN_ENUMERATING_THREADS()
        {
            Invoker.Call<Void>(0xDADFADA5A20143A8);
        }

        public static int _GET_ID_OF_NEXT_THREAD_IN_ENUMERATION()
        {
            return Invoker.Call<int>(0x30B4FA1C82DD4B9F);
        }

        public static int GET_ID_OF_THIS_THREAD()
        {
            return Invoker.Call<int>(0xC30338E8088E2E21);
        }

        public static void TERMINATE_THIS_THREAD()
        {
            Invoker.Call<Void>(0x1090044AD1DA76FA);
        }

        public static int _GET_NUMBER_OF_INSTANCES_OF_SCRIPT_WITH_NAME_HASH(int scriptHash)
        {
            return Invoker.Call<int>(0x2C83A9DA6BFFC4F9, scriptHash);
        }

        public static string GET_THIS_SCRIPT_NAME()
        {
            return Invoker.Call<string>(0x442E0A7EDE4A738A);
        }

        public static int GET_HASH_OF_THIS_SCRIPT_NAME()
        {
            return Invoker.Call<int>(0x8A1C8B1738FFE87E);
        }

        public static int GET_NUMBER_OF_EVENTS(int _eventGroup)
        {
            return Invoker.Call<int>(0x5F92A689A06620AA, _eventGroup);
        }

        public static bool GET_EVENT_EXISTS(int _eventGroup, int _eventIndex)
        {
            return Invoker.Call<bool>(0x936E6168A9BCEDB5, _eventGroup, _eventIndex);
        }

        public static int GET_EVENT_AT_INDEX(int _eventGroup, int _eventIndex)
        {
            return Invoker.Call<int>(0xD8F66A3A60C62153, _eventGroup, _eventIndex);
        }

        public static bool GET_EVENT_DATA(int _eventGroup, int _eventIndex, ulong argStruct_ptr, int argStructSize)
        {
            return Invoker.Call<bool>(0x2902843FCD2B2D79, _eventGroup, _eventIndex, argStruct_ptr, argStructSize);
        }

        public static void TRIGGER_SCRIPT_EVENT(int _eventGroup, ulong args_ptr, int argCount, int bit)
        {
            Invoker.Call<Void>(0x5AE99C571D5BBE5D, _eventGroup, args_ptr, argCount, bit);
        }

        public static void SHUTDOWN_LOADING_SCREEN()
        {
            Invoker.Call<Void>(0x078EBE9809CCD637);
        }

        public static void SET_NO_LOADING_SCREEN(bool toggle)
        {
            Invoker.Call<Void>(0x5262CC1995D07E09, toggle);
        }

        public static bool _GET_NO_LOADING_SCREEN()
        {
            return Invoker.Call<bool>(0x18C1270EA7F199BC);
        }

        public static void _0xB1577667C3708F9B()
        {
            Invoker.Call<Void>(0xB1577667C3708F9B);
        }

    }

    public static class UI
    {

        public static void _BEGIN_TEXT_COMMAND_BUSY_STRING(string _string)
        {
            Invoker.Call<Void>(0xABA17D7CE615ADBF, _string);
        }

        public static void _END_TEXT_COMMAND_BUSY_STRING(int busySpinnerType)
        {
            Invoker.Call<Void>(0xBD12F8228410D9B4, busySpinnerType);
        }

        public static void _REMOVE_LOADING_PROMPT()
        {
            Invoker.Call<Void>(0x10D373323E5B9C0D);
        }

        public static void _0xC65AB383CD91DF98()
        {
            Invoker.Call<Void>(0xC65AB383CD91DF98);
        }

        public static string _IS_LOADING_PROMPT_BEING_DISPLAYED()
        {
            return Invoker.Call<string>(0xD422FCC5F239A915);
        }

        public static int _0xB2A592B04648A9CB()
        {
            return Invoker.Call<int>(0xB2A592B04648A9CB);
        }

        public static void _0x9245E81072704B8A(bool p0)
        {
            Invoker.Call<Void>(0x9245E81072704B8A, p0);
        }

        public static void _SHOW_CURSOR_THIS_FRAME()
        {
            Invoker.Call<Void>(0xAAE7CE1D63167423);
        }

        public static void _SET_CURSOR_SPRITE(int spriteId)
        {
            Invoker.Call<Void>(0x8DB8CFFD58B62552, spriteId);
        }

        public static void _0x98215325A695E78A(bool p0)
        {
            Invoker.Call<Void>(0x98215325A695E78A, p0);
        }

        public static int _0x3D9ACB1EB139E702()
        {
            return Invoker.Call<int>(0x3D9ACB1EB139E702);
        }

        public static bool _0x632B2940C67F4EA9(int scaleformHandle, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0x632B2940C67F4EA9, scaleformHandle, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _0x6F1554B0CC2089FA(bool p0)
        {
            Invoker.Call<Void>(0x6F1554B0CC2089FA, p0);
        }

        public static void _CLEAR_NOTIFICATIONS_POS(float pos)
        {
            Invoker.Call<Void>(0x55598D21339CB998, pos);
        }

        public static void _0x25F87B30C382FCA7()
        {
            Invoker.Call<Void>(0x25F87B30C382FCA7);
        }

        public static void _0xA8FDB297A8D25FBA()
        {
            Invoker.Call<Void>(0xA8FDB297A8D25FBA);
        }

        public static void _REMOVE_NOTIFICATION(int notificationId)
        {
            Invoker.Call<Void>(0xBE4390CB40B3E627, notificationId);
        }

        public static void _0xA13C11E1B5C06BFC()
        {
            Invoker.Call<Void>(0xA13C11E1B5C06BFC);
        }

        public static void _0x583049884A2EEE3C()
        {
            Invoker.Call<Void>(0x583049884A2EEE3C);
        }

        public static void _0xFDB423997FA30340()
        {
            Invoker.Call<Void>(0xFDB423997FA30340);
        }

        public static void _0xE1CD1E48E025E661()
        {
            Invoker.Call<Void>(0xE1CD1E48E025E661);
        }

        public static bool _0xA9CBFD40B3FA3010()
        {
            return Invoker.Call<bool>(0xA9CBFD40B3FA3010);
        }

        public static void _0xD4438C0564490E63()
        {
            Invoker.Call<Void>(0xD4438C0564490E63);
        }

        public static void _0xB695E2CD0A2DA9EE()
        {
            Invoker.Call<Void>(0xB695E2CD0A2DA9EE);
        }

        public static int _GET_CURRENT_NOTIFICATION()
        {
            return Invoker.Call<int>(0x82352748437638CA);
        }

        public static void _0x56C8B608CFD49854()
        {
            Invoker.Call<Void>(0x56C8B608CFD49854);
        }

        public static void _0xADED7F5748ACAFE6()
        {
            Invoker.Call<Void>(0xADED7F5748ACAFE6);
        }

        public static void _SET_NOTIFICATION_BACKGROUND_COLOR(int hudIndex)
        {
            Invoker.Call<Void>(0x92F0DA1E27DB96DC, hudIndex);
        }

        public static void _SET_NOTIFICATION_FLASH_COLOR(int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x17430B918701C342, red, green, blue, alpha);
        }

        public static void _0x17AD8C9706BDD88A(int p0)
        {
            Invoker.Call<Void>(0x17AD8C9706BDD88A, p0);
        }

        public static void _0x4A0C7C9BB10ABB36(bool p0)
        {
            Invoker.Call<Void>(0x4A0C7C9BB10ABB36, p0);
        }

        public static void _0xFDD85225B2DEA55E()
        {
            Invoker.Call<Void>(0xFDD85225B2DEA55E);
        }

        public static void _0xFDEC055AB549E328()
        {
            Invoker.Call<Void>(0xFDEC055AB549E328);
        }

        public static void _0x80FE4F3AB4E1B62A()
        {
            Invoker.Call<Void>(0x80FE4F3AB4E1B62A);
        }

        public static void _0xBAE4F9B97CD43B30(bool p0)
        {
            Invoker.Call<Void>(0xBAE4F9B97CD43B30, p0);
        }

        public static void _0x317EBA71D7543F52(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0x317EBA71D7543F52, p0_ptr, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _SET_NOTIFICATION_TEXT_ENTRY(string text)
        {
            Invoker.Call<Void>(0x202709F4C58A0424, text);
        }

        public static int _SET_NOTIFICATION_MESSAGE(string picName1, int picName2, bool flash, int iconType, bool p4, string sender, string subject)
        {
            return Invoker.Call<int>(0x2B7E9A4EAAA93C89, picName1, picName2, flash, iconType, p4, sender, subject);
        }

        public static int _SET_NOTIFICATION_MESSAGE_2(string picName1, string picName2, bool flash, int iconType, string sender, string subject)
        {
            return Invoker.Call<int>(0x1CCD9A37359072CF, picName1, picName2, flash, iconType, sender, subject);
        }

        public static int _SET_NOTIFICATION_MESSAGE_3(string picName1, string picName2, bool p2, int p3, string p4, string p5)
        {
            return Invoker.Call<int>(0xC6F580E4C94926AC, picName1, picName2, p2, p3, p4, p5);
        }

        public static int _SET_NOTIFICATION_MESSAGE_4(string picName1, string picName2, bool flash, int iconType, string sender, string subject, float duration)
        {
            return Invoker.Call<int>(0x1E6611149DB3DB6B, picName1, picName2, flash, iconType, sender, subject, duration);
        }

        public static int _SET_NOTIFICATION_MESSAGE_CLAN_TAG(string picName1, string picName2, bool flash, int iconType, string sender, string subject, float duration, string clanTag)
        {
            return Invoker.Call<int>(0x5CBF7BADE20DB93E, picName1, picName2, flash, iconType, sender, subject, duration, clanTag);
        }

        public static int _SET_NOTIFICATION_MESSAGE_CLAN_TAG_2(string picName1, string picName2, bool flash, int iconType1, string sender, string subject, float duration, string clanTag, int iconType2, int p9)
        {
            return Invoker.Call<int>(0x531B84E7DA981FB6, picName1, picName2, flash, iconType1, sender, subject, duration, clanTag, iconType2, p9);
        }

        public static int _DRAW_NOTIFICATION(bool blink, bool showInBrief)
        {
            return Invoker.Call<int>(0x2ED7843F8F801023, blink, showInBrief);
        }

        public static int _DRAW_NOTIFICATION_2(bool blink, bool p1)
        {
            return Invoker.Call<int>(0x44FA03975424A0EE, blink, p1);
        }

        public static int _DRAW_NOTIFICATION_3(bool blink, bool p1)
        {
            return Invoker.Call<int>(0x378E809BF61EC840, blink, p1);
        }

        public static int _DRAW_NOTIFICATION_AWARD(string p0, string p1, int p2, int p3, string p4)
        {
            return Invoker.Call<int>(0xAA295B6F28BD587D, p0, p1, p2, p3, p4);
        }

        public static int _DRAW_NOTIFICATION_APARTMENT_INVITE(bool p0, bool p1, ulong p2_ptr, int p3, bool isLeader, bool unk0, int clanDesc, int R, int G, int B)
        {
            return Invoker.Call<int>(0x97C9E4E7024A8F2C, p0, p1, p2_ptr, p3, isLeader, unk0, clanDesc, R, G, B);
        }

        public static int _DRAW_NOTIFICATION_CLAN_INVITE(bool p0, bool p1, ulong p2_ptr, int p3, bool isLeader, bool unk0, int clanDesc, string playerName, int R, int G, int B)
        {
            return Invoker.Call<int>(0x137BC35589E34E1E, p0, p1, p2_ptr, p3, isLeader, unk0, clanDesc, playerName, R, G, B);
        }

        public static int _0x33EE12743CCD6343(int p0, int p1, int p2)
        {
            return Invoker.Call<int>(0x33EE12743CCD6343, p0, p1, p2);
        }

        public static int _0xC8F3AAF93D0600BF(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xC8F3AAF93D0600BF, p0, p1, p2, p3);
        }

        public static int _0x7AE0589093A2E088(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            return Invoker.Call<int>(0x7AE0589093A2E088, p0, p1, p2, p3, p4, p5);
        }

        public static int _DRAW_NOTIFICATION_4(bool blink, bool p1)
        {
            return Invoker.Call<int>(0xF020C96915705B3A, blink, p1);
        }

        public static int _0x8EFCCF6EC66D85E4(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr, bool p3, bool p4)
        {
            return Invoker.Call<int>(0x8EFCCF6EC66D85E4, p0_ptr, p1_ptr, p2_ptr, p3, p4);
        }

        public static int _0xB6871B0555B02996(ulong p0_ptr, ulong p1_ptr, int p2, ulong p3_ptr, ulong p4_ptr, int p5)
        {
            return Invoker.Call<int>(0xB6871B0555B02996, p0_ptr, p1_ptr, p2, p3_ptr, p4_ptr, p5);
        }

        public static int _DRAW_NOTIFICATION_WITH_ICON(int type, int image, string text)
        {
            return Invoker.Call<int>(0xD202B92CBF1D816F, type, image, text);
        }

        public static int _DRAW_NOTIFICATION_WITH_BUTTON(int type, string button, string text)
        {
            return Invoker.Call<int>(0xDD6CB2CCE7C2735C, type, button, text);
        }

        public static void BEGIN_TEXT_COMMAND_PRINT(string GxtEntry)
        {
            Invoker.Call<Void>(0xB87A37EEB7FAA67D, GxtEntry);
        }

        public static void END_TEXT_COMMAND_PRINT(int duration, bool drawImmediately)
        {
            Invoker.Call<Void>(0x9D77056A530643F6, duration, drawImmediately);
        }

        public static void BEGIN_TEXT_COMMAND_IS_MESSAGE_DISPLAYED(string text)
        {
            Invoker.Call<Void>(0x853648FD1063A213, text);
        }

        public static bool END_TEXT_COMMAND_IS_MESSAGE_DISPLAYED()
        {
            return Invoker.Call<bool>(0x8A9BA1AB3E237613);
        }

        public static void BEGIN_TEXT_COMMAND_DISPLAY_TEXT(string text)
        {
            Invoker.Call<Void>(0x25FBB336DF1804CB, text);
        }

        public static void END_TEXT_COMMAND_DISPLAY_TEXT(float x, float y)
        {
            Invoker.Call<Void>(0xCD015E5BB0D96A57, x, y);
        }

        public static void _BEGIN_TEXT_COMMAND_WIDTH(string text)
        {
            Invoker.Call<Void>(0x54CE8AC98E120CAB, text);
        }

        public static float _END_TEXT_COMMAND_GET_WIDTH(bool p0)
        {
            return Invoker.Call<float>(0x85F061DA64ED2F67, p0);
        }

        public static void _BEGIN_TEXT_COMMAND_LINE_COUNT(string entry)
        {
            Invoker.Call<Void>(0x521FB041D93DD0E4, entry);
        }

        public static int _GET_TEXT_SCREEN_LINE_COUNT(float x, float y)
        {
            return Invoker.Call<int>(0x9040DFB09BE75706, x, y);
        }

        public static void BEGIN_TEXT_COMMAND_DISPLAY_HELP(string inputType)
        {
            Invoker.Call<Void>(0x8509B634FBE7DA11, inputType);
        }

        public static void END_TEXT_COMMAND_DISPLAY_HELP(int p0, bool loop, bool beep, int duration)
        {
            Invoker.Call<Void>(0x238FFE5C7B0498A6, p0, loop, beep, duration);
        }

        public static void BEGIN_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(string labelName)
        {
            Invoker.Call<Void>(0x0A24DA3A41B718F5, labelName);
        }

        public static bool END_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(int p0)
        {
            return Invoker.Call<bool>(0x10BDDBFC529428DD, p0);
        }

        public static void BEGIN_TEXT_COMMAND_SET_BLIP_NAME(string gxtentry)
        {
            Invoker.Call<Void>(0xF9113A30DE5C6670, gxtentry);
        }

        public static void END_TEXT_COMMAND_SET_BLIP_NAME(int blip)
        {
            Invoker.Call<Void>(0xBC38B49BCB83BC9B, blip);
        }

        public static void _BEGIN_TEXT_COMMAND_OBJECTIVE(string p0)
        {
            Invoker.Call<Void>(0x23D69E0465570028, p0);
        }

        public static void _END_TEXT_COMMAND_OBJECTIVE(bool p0)
        {
            Invoker.Call<Void>(0xCFDBDF5AE59BA0F4, p0);
        }

        public static void BEGIN_TEXT_COMMAND_CLEAR_PRINT(string text)
        {
            Invoker.Call<Void>(0xE124FA80A759019C, text);
        }

        public static void END_TEXT_COMMAND_CLEAR_PRINT()
        {
            Invoker.Call<Void>(0xFCC75460ABA29378);
        }

        public static void _BEGIN_TEXT_COMMAND_TIMER(string p0)
        {
            Invoker.Call<Void>(0x8F9EE5687F8EECCD, p0);
        }

        public static void _END_TEXT_COMMAND_TIMER(bool p0)
        {
            Invoker.Call<Void>(0xA86911979638106F, p0);
        }

        public static void ADD_TEXT_COMPONENT_INTEGER(int value)
        {
            Invoker.Call<Void>(0x03B504CF259931BC, value);
        }

        public static void ADD_TEXT_COMPONENT_FLOAT(float value, int decimalPlaces)
        {
            Invoker.Call<Void>(0xE7DCB5B874BCD96E, value, decimalPlaces);
        }

        public static void ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL(string labelName)
        {
            Invoker.Call<Void>(0xC63CD5D2920ACBE7, labelName);
        }

        public static void ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY(int gxtEntryHash)
        {
            Invoker.Call<Void>(0x17299B63C7683A2B, gxtEntryHash);
        }

        public static void ADD_TEXT_COMPONENT_SUBSTRING_BLIP_NAME(int blip)
        {
            Invoker.Call<Void>(0x80EAD8E2E1D5D52E, blip);
        }

        public static void ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(string text)
        {
            Invoker.Call<Void>(0x6C188BE134E074AA, text);
        }

        public static void ADD_TEXT_COMPONENT_SUBSTRING_TIME(int timestamp, int flags)
        {
            Invoker.Call<Void>(0x1115F16B8AB9E8BF, timestamp, flags);
        }

        public static void ADD_TEXT_COMPONENT_FORMATTED_INTEGER(int value, bool commaSeparated)
        {
            Invoker.Call<Void>(0x0E4C749FF9DE9CC4, value, commaSeparated);
        }

        public static void _ADD_TEXT_COMPONENT_APP_TITLE(string p0, int p1)
        {
            Invoker.Call<Void>(0x761B77454205A61D, p0, p1);
        }

        public static void ADD_TEXT_COMPONENT_SUBSTRING_WEBSITE(string website)
        {
            Invoker.Call<Void>(0x94CF4AC034C9C986, website);
        }

        public static void _ADD_TEXT_COMPONENT_SCALEFORM(string p0)
        {
            Invoker.Call<Void>(0x5F68520888E69014, p0);
        }

        public static void _SET_NOTIFICATION_COLOR_NEXT(int hudIndex)
        {
            Invoker.Call<Void>(0x39BBF623FC803EAC, hudIndex);
        }

        public static string _GET_TEXT_SUBSTRING(string text, int position, int length)
        {
            return Invoker.Call<string>(0x169BD9382084C8C0, text, position, length);
        }

        public static string _GET_TEXT_SUBSTRING_SAFE(string text, int position, int length, int maxLength)
        {
            return Invoker.Call<string>(0xB2798643312205C5, text, position, length, maxLength);
        }

        public static string _GET_TEXT_SUBSTRING_SLICE(string text, int startPosition, int endPosition)
        {
            return Invoker.Call<string>(0xCE94AEBA5D82908A, text, startPosition, endPosition);
        }

        public static string _GET_LABEL_TEXT(string labelName)
        {
            return Invoker.Call<string>(0x7B5280EBA9840C72, labelName);
        }

        public static void CLEAR_PRINTS()
        {
            Invoker.Call<Void>(0xCC33FA791322B9D9);
        }

        public static void CLEAR_BRIEF()
        {
            Invoker.Call<Void>(0x9D292F73ADBD9313);
        }

        public static void CLEAR_ALL_HELP_MESSAGES()
        {
            Invoker.Call<Void>(0x6178F68A87A4D3A0);
        }

        public static void CLEAR_THIS_PRINT(string p0)
        {
            Invoker.Call<Void>(0xCF708001E1E536DD, p0);
        }

        public static void CLEAR_SMALL_PRINTS()
        {
            Invoker.Call<Void>(0x2CEA2839313C09AC);
        }

        public static bool DOES_TEXT_BLOCK_EXIST(string gxt)
        {
            return Invoker.Call<bool>(0x1C7302E725259789, gxt);
        }

        public static void REQUEST_ADDITIONAL_TEXT(string gxt, int slot)
        {
            Invoker.Call<Void>(0x71A78003C8E71424, gxt, slot);
        }

        public static void _REQUEST_ADDITIONAL_TEXT_2(string gxt, int slot)
        {
            Invoker.Call<Void>(0x6009F9F1AE90D8A6, gxt, slot);
        }

        public static bool HAS_ADDITIONAL_TEXT_LOADED(int slot)
        {
            return Invoker.Call<bool>(0x02245FE4BED318B8, slot);
        }

        public static void CLEAR_ADDITIONAL_TEXT(int p0, bool p1)
        {
            Invoker.Call<Void>(0x2A179DF17CCF04CD, p0, p1);
        }

        public static bool IS_STREAMING_ADDITIONAL_TEXT(int p0)
        {
            return Invoker.Call<bool>(0x8B6817B71B85EBF0, p0);
        }

        public static bool HAS_THIS_ADDITIONAL_TEXT_LOADED(string gxt, int slot)
        {
            return Invoker.Call<bool>(0xADBF060E2B30C5BC, gxt, slot);
        }

        public static bool IS_MESSAGE_BEING_DISPLAYED()
        {
            return Invoker.Call<bool>(0x7984C03AA5CC2F41);
        }

        public static bool DOES_TEXT_LABEL_EXIST(string gxt)
        {
            return Invoker.Call<bool>(0xAC09CA973C564252, gxt);
        }

        public static int GET_LENGTH_OF_STRING_WITH_THIS_TEXT_LABEL(string gxt)
        {
            return Invoker.Call<int>(0x801BD273D3A23F74, gxt);
        }

        public static int GET_LENGTH_OF_LITERAL_STRING(string _string)
        {
            return Invoker.Call<int>(0xF030907CCBB8A9FD, _string);
        }

        public static int _GET_LENGTH_OF_STRING(string STRING)
        {
            return Invoker.Call<int>(0x43E4111189E54F0E, STRING);
        }

        public static string GET_STREET_NAME_FROM_HASH_KEY(int hash)
        {
            return Invoker.Call<string>(0xD0EF8A959B8A4CB9, hash);
        }

        public static bool IS_HUD_PREFERENCE_SWITCHED_ON()
        {
            return Invoker.Call<bool>(0x1930DFA731813EC4);
        }

        public static bool IS_RADAR_PREFERENCE_SWITCHED_ON()
        {
            return Invoker.Call<bool>(0x9EB6522EA68F22FE);
        }

        public static bool IS_SUBTITLE_PREFERENCE_SWITCHED_ON()
        {
            return Invoker.Call<bool>(0xAD6DACA4BA53E0A4);
        }

        public static void DISPLAY_HUD(bool toggle)
        {
            Invoker.Call<Void>(0xA6294919E56FF02A, toggle);
        }

        public static void _0x7669F9E39DC17063()
        {
            Invoker.Call<Void>(0x7669F9E39DC17063);
        }

        public static void _0x402F9ED62087E898()
        {
            Invoker.Call<Void>(0x402F9ED62087E898);
        }

        public static int DISPLAY_RADAR(bool Toggle)
        {
            return Invoker.Call<int>(0xA0EBB943C300E693, Toggle);
        }

        public static bool IS_HUD_HIDDEN()
        {
            return Invoker.Call<bool>(0xA86478C6958735C5);
        }

        public static bool IS_RADAR_HIDDEN()
        {
            return Invoker.Call<bool>(0x157F93B036700462);
        }

        public static bool _IS_RADAR_ENABLED()
        {
            return Invoker.Call<bool>(0xAF754F20EB5CD51A);
        }

        public static void SET_BLIP_ROUTE(int blip, bool enabled)
        {
            Invoker.Call<Void>(0x4F7D8A9BFB0B43E9, blip, enabled);
        }

        public static void SET_BLIP_ROUTE_COLOUR(int blip, int colour)
        {
            Invoker.Call<Void>(0x837155CD2F63DA09, blip, colour);
        }

        public static void ADD_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS(bool p0)
        {
            Invoker.Call<Void>(0x60296AF4BA14ABC5, p0);
        }

        public static void _0x57D760D55F54E071(bool p0)
        {
            Invoker.Call<Void>(0x57D760D55F54E071, p0);
        }

        public static void RESPONDING_AS_TEMP(float p0)
        {
            Invoker.Call<Void>(0xBD12C5EEE184C337, p0);
        }

        public static void SET_RADAR_ZOOM(int zoomLevel)
        {
            Invoker.Call<Void>(0x096EF57A0C999BBA, zoomLevel);
        }

        public static void _0xF98E4B3E56AFC7B1(int p0, float p1)
        {
            Invoker.Call<Void>(0xF98E4B3E56AFC7B1, p0, p1);
        }

        public static void _SET_RADAR_ZOOM_LEVEL_THIS_FRAME(float zoomLevel)
        {
            Invoker.Call<Void>(0xCB7CC0D58405AD41, zoomLevel);
        }

        public static void _0xD2049635DEB9C375()
        {
            Invoker.Call<Void>(0xD2049635DEB9C375);
        }

        public static void GET_HUD_COLOUR(int hudColorIndex, ulong r_ptr, ulong g_ptr, ulong b_ptr, ulong a_ptr)
        {
            Invoker.Call<Void>(0x7C9C91AB74A0360F, hudColorIndex, r_ptr, g_ptr, b_ptr, a_ptr);
        }

        public static void _0xD68A5FF8A3A89874(int r, int g, int b, int a)
        {
            Invoker.Call<Void>(0xD68A5FF8A3A89874, r, g, b, a);
        }

        public static void _0x16A304E6CB2BFAB9(int r, int g, int b, int a)
        {
            Invoker.Call<Void>(0x16A304E6CB2BFAB9, r, g, b, a);
        }

        public static void _SET_HUD_COLOURS_SWITCH(int hudColorIndex, int hudColorIndex2)
        {
            Invoker.Call<Void>(0x1CCC708F0F850613, hudColorIndex, hudColorIndex2);
        }

        public static void _SET_HUD_COLOUR(int hudColorIndex, int r, int g, int b, int a)
        {
            Invoker.Call<Void>(0xF314CF4F0211894E, hudColorIndex, r, g, b, a);
        }

        public static void FLASH_ABILITY_BAR(bool toggle)
        {
            Invoker.Call<Void>(0x02CFBA0C9E9275CE, toggle);
        }

        public static void SET_ABILITY_BAR_VALUE(float value, float maxValue)
        {
            Invoker.Call<Void>(0x9969599CCFF5D85E, value, maxValue);
        }

        public static int FLASH_WANTED_DISPLAY(bool p0)
        {
            return Invoker.Call<int>(0xA18AFB39081B6A1F, p0);
        }

        public static void _0xBA8D65C1C65702E5(bool p0)
        {
            Invoker.Call<Void>(0xBA8D65C1C65702E5, p0);
        }

        public static float _GET_TEXT_SCALE_HEIGHT(float size, int font)
        {
            return Invoker.Call<float>(0xDB88A37483346780, size, font);
        }

        public static void SET_TEXT_SCALE(float scale, float size)
        {
            Invoker.Call<Void>(0x07C837F9A01C34C9, scale, size);
        }

        public static void SET_TEXT_COLOUR(int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xBE6B23FFA53FB442, red, green, blue, alpha);
        }

        public static void SET_TEXT_CENTRE(bool align)
        {
            Invoker.Call<Void>(0xC02F4DBFB51D988B, align);
        }

        public static void SET_TEXT_RIGHT_JUSTIFY(bool toggle)
        {
            Invoker.Call<Void>(0x6B3C4650BC8BEE47, toggle);
        }

        public static void SET_TEXT_JUSTIFICATION(int justifyType)
        {
            Invoker.Call<Void>(0x4E096588B13FFECA, justifyType);
        }

        public static void SET_TEXT_WRAP(float start, float end)
        {
            Invoker.Call<Void>(0x63145D9C883A1A70, start, end);
        }

        public static void SET_TEXT_LEADING(bool p0)
        {
            Invoker.Call<Void>(0xA50ABC31E3CDFAFF, p0);
        }

        public static void SET_TEXT_PROPORTIONAL(bool p0)
        {
            Invoker.Call<Void>(0x038C1F517D7FDCF8, p0);
        }

        public static void SET_TEXT_FONT(int fontType)
        {
            Invoker.Call<Void>(0x66E0276CC5F6B9DA, fontType);
        }

        public static void SET_TEXT_DROP_SHADOW()
        {
            Invoker.Call<Void>(0x1CA3E9EAC9D93E5E);
        }

        public static void SET_TEXT_DROPSHADOW(int distance, int r, int g, int b, int a)
        {
            Invoker.Call<Void>(0x465C84BC39F1C351, distance, r, g, b, a);
        }

        public static void SET_TEXT_OUTLINE()
        {
            Invoker.Call<Void>(0x2513DFB0FB8400FE);
        }

        public static void SET_TEXT_EDGE(int p0, int r, int g, int b, int a)
        {
            Invoker.Call<Void>(0x441603240D202FA6, p0, r, g, b, a);
        }

        public static void SET_TEXT_RENDER_ID(int renderId)
        {
            Invoker.Call<Void>(0x5F15302936E07111, renderId);
        }

        public static int GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID()
        {
            return Invoker.Call<int>(0x52F0982D7FD156B6);
        }

        public static bool REGISTER_NAMED_RENDERTARGET(string p0, bool p1)
        {
            return Invoker.Call<bool>(0x57D9C12635E25CE3, p0, p1);
        }

        public static bool IS_NAMED_RENDERTARGET_REGISTERED(string p0)
        {
            return Invoker.Call<bool>(0x78DCDC15C9F116B4, p0);
        }

        public static bool RELEASE_NAMED_RENDERTARGET(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xE9F6FFE837354DD4, p0_ptr);
        }

        public static void LINK_NAMED_RENDERTARGET(int hash)
        {
            Invoker.Call<Void>(0xF6C09E276AEB3F2D, hash);
        }

        public static int GET_NAMED_RENDERTARGET_RENDER_ID(string p0)
        {
            return Invoker.Call<int>(0x1A6478B61C6BDC3B, p0);
        }

        public static bool IS_NAMED_RENDERTARGET_LINKED(int hash)
        {
            return Invoker.Call<bool>(0x113750538FA31298, hash);
        }

        public static void CLEAR_HELP(bool toggle)
        {
            Invoker.Call<Void>(0x8DFCED7A656F8802, toggle);
        }

        public static bool IS_HELP_MESSAGE_ON_SCREEN()
        {
            return Invoker.Call<bool>(0xDAD37F45428801AE);
        }

        public static bool _0x214CD562A939246A()
        {
            return Invoker.Call<bool>(0x214CD562A939246A);
        }

        public static bool IS_HELP_MESSAGE_BEING_DISPLAYED()
        {
            return Invoker.Call<bool>(0x4D79439A6B55AC67);
        }

        public static bool IS_HELP_MESSAGE_FADING_OUT()
        {
            return Invoker.Call<bool>(0x327EDEEEAC55C369);
        }

        public static bool _0x4A9923385BDB9DAD()
        {
            return Invoker.Call<bool>(0x4A9923385BDB9DAD);
        }

        public static int _GET_BLIP_INFO_ID_ITERATOR()
        {
            return Invoker.Call<int>(0x186E5D252FA50E7D);
        }

        public static int GET_NUMBER_OF_ACTIVE_BLIPS()
        {
            return Invoker.Call<int>(0x9A3FF3DE163034E8);
        }

        public static int GET_NEXT_BLIP_INFO_ID(int blipSprite)
        {
            return Invoker.Call<int>(0x14F96AA50D6FBEA7, blipSprite);
        }

        public static int GET_FIRST_BLIP_INFO_ID(int blipSprite)
        {
            return Invoker.Call<int>(0x1BEDE233E6CD2A1F, blipSprite);
        }

        public static Vector3 GET_BLIP_INFO_ID_COORD(int blip)
        {
            return Invoker.Call<Vector3>(0xFA7C7F0AADF25D09, blip);
        }

        public static int GET_BLIP_INFO_ID_DISPLAY(int blip)
        {
            return Invoker.Call<int>(0x1E314167F701DC3B, blip);
        }

        public static int GET_BLIP_INFO_ID_TYPE(int blip)
        {
            return Invoker.Call<int>(0xBE9B0959FFD0779B, blip);
        }

        public static int GET_BLIP_INFO_ID_ENTITY_INDEX(int blip)
        {
            return Invoker.Call<int>(0x4BA4E2553AFEDC2C, blip);
        }

        public static int GET_BLIP_INFO_ID_PICKUP_INDEX(int blip)
        {
            return Invoker.Call<int>(0x9B6786E4C03DD382, blip);
        }

        public static int GET_BLIP_FROM_ENTITY(int entity)
        {
            return Invoker.Call<int>(0xBC8DBDCA2436F7E8, entity);
        }

        public static int ADD_BLIP_FOR_RADIUS(float posX, float posY, float posZ, float radius)
        {
            return Invoker.Call<int>(0x46818D79B1F7499A, posX, posY, posZ, radius);
        }

        public static int ADD_BLIP_FOR_ENTITY(int entity)
        {
            return Invoker.Call<int>(0x5CDE92C702A8FCE7, entity);
        }

        public static int ADD_BLIP_FOR_PICKUP(int pickup)
        {
            return Invoker.Call<int>(0xBE339365C863BD36, pickup);
        }

        public static int ADD_BLIP_FOR_COORD(float x, float y, float z)
        {
            return Invoker.Call<int>(0x5A039BB0BCA604B6, x, y, z);
        }

        public static void _0x72DD432F3CDFC0EE(float posX, float posY, float posZ, float radius, int p4)
        {
            Invoker.Call<Void>(0x72DD432F3CDFC0EE, posX, posY, posZ, radius, p4);
        }

        public static void _0x60734CC207C9833C(bool p0)
        {
            Invoker.Call<Void>(0x60734CC207C9833C, p0);
        }

        public static void SET_BLIP_COORDS(int blip, float posX, float posY, float posZ)
        {
            Invoker.Call<Void>(0xAE2AF67E9D9AF65D, blip, posX, posY, posZ);
        }

        public static Vector3 GET_BLIP_COORDS(int blip)
        {
            return Invoker.Call<Vector3>(0x586AFE3FF72D996E, blip);
        }

        public static void SET_BLIP_SPRITE(int blip, int spriteId)
        {
            Invoker.Call<Void>(0xDF735600A4696DAF, blip, spriteId);
        }

        public static int GET_BLIP_SPRITE(int blip)
        {
            return Invoker.Call<int>(0x1FC877464A04FC4F, blip);
        }

        public static void SET_BLIP_NAME_FROM_TEXT_FILE(int blip, string gxtEntry)
        {
            Invoker.Call<Void>(0xEAA0FFE120D92784, blip, gxtEntry);
        }

        public static void SET_BLIP_NAME_TO_PLAYER_NAME(int blip, int player)
        {
            Invoker.Call<Void>(0x127DE7B20C60A6A3, blip, player);
        }

        public static void SET_BLIP_ALPHA(int blip, int alpha)
        {
            Invoker.Call<Void>(0x45FF974EEE1C8734, blip, alpha);
        }

        public static int GET_BLIP_ALPHA(int blip)
        {
            return Invoker.Call<int>(0x970F608F0EE6C885, blip);
        }

        public static void SET_BLIP_FADE(int blip, int opacity, int duration)
        {
            Invoker.Call<Void>(0x2AEE8F8390D2298C, blip, opacity, duration);
        }

        public static void SET_BLIP_ROTATION(int blip, int rotation)
        {
            Invoker.Call<Void>(0xF87683CDF73C3F6E, blip, rotation);
        }

        public static void SET_BLIP_FLASH_TIMER(int blip, int duration)
        {
            Invoker.Call<Void>(0xD3CD6FD297AE87CC, blip, duration);
        }

        public static void SET_BLIP_FLASH_INTERVAL(int blip, int p1)
        {
            Invoker.Call<Void>(0xAA51DB313C010A7E, blip, p1);
        }

        public static void SET_BLIP_COLOUR(int blip, int color)
        {
            Invoker.Call<Void>(0x03D7FB09E75D6B7E, blip, color);
        }

        public static void SET_BLIP_SECONDARY_COLOUR(int blip, float r, float g, float b)
        {
            Invoker.Call<Void>(0x14892474891E09EB, blip, r, g, b);
        }

        public static int GET_BLIP_COLOUR(int blip)
        {
            return Invoker.Call<int>(0xDF729E8D20CF7327, blip);
        }

        public static int GET_BLIP_HUD_COLOUR(int blip)
        {
            return Invoker.Call<int>(0x729B5F1EFBC0AAEE, blip);
        }

        public static bool IS_BLIP_SHORT_RANGE(int blip)
        {
            return Invoker.Call<bool>(0xDA5F8727EB75B926, blip);
        }

        public static bool IS_BLIP_ON_MINIMAP(int blip)
        {
            return Invoker.Call<bool>(0xE41CA53051197A27, blip);
        }

        public static bool _0xDD2238F57B977751(int p0)
        {
            return Invoker.Call<bool>(0xDD2238F57B977751, p0);
        }

        public static void _0x54318C915D27E4CE(int p0, bool p1)
        {
            Invoker.Call<Void>(0x54318C915D27E4CE, p0, p1);
        }

        public static void SET_BLIP_HIGH_DETAIL(int blip, bool toggle)
        {
            Invoker.Call<Void>(0xE2590BC29220CEBB, blip, toggle);
        }

        public static void SET_BLIP_AS_MISSION_CREATOR_BLIP(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x24AC0137444F9FD5, blip, toggle);
        }

        public static bool IS_MISSION_CREATOR_BLIP(int blip)
        {
            return Invoker.Call<bool>(0x26F49BF3381D933D, blip);
        }

        public static int DISABLE_BLIP_NAME_FOR_VAR()
        {
            return Invoker.Call<int>(0x5C90988E7C8E1AF4);
        }

        public static bool _0x4167EFE0527D706E()
        {
            return Invoker.Call<bool>(0x4167EFE0527D706E);
        }

        public static void _0xF1A6C18B35BCADE6(bool p0)
        {
            Invoker.Call<Void>(0xF1A6C18B35BCADE6, p0);
        }

        public static void SET_BLIP_FLASHES(int blip, bool toggle)
        {
            Invoker.Call<Void>(0xB14552383D39CE3E, blip, toggle);
        }

        public static void SET_BLIP_FLASHES_ALTERNATE(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x2E8D9498C56DD0D1, blip, toggle);
        }

        public static bool IS_BLIP_FLASHING(int blip)
        {
            return Invoker.Call<bool>(0xA5E41FD83AD6CEF0, blip);
        }

        public static void SET_BLIP_AS_SHORT_RANGE(int blip, bool toggle)
        {
            Invoker.Call<Void>(0xBE8BE4FE60E27B72, blip, toggle);
        }

        public static void SET_BLIP_SCALE(int blip, float scale)
        {
            Invoker.Call<Void>(0xD38744167B2FA257, blip, scale);
        }

        public static void SET_BLIP_PRIORITY(int blip, int priority)
        {
            Invoker.Call<Void>(0xAE9FC9EF6A9FAC79, blip, priority);
        }

        public static void SET_BLIP_DISPLAY(int blip, int displayId)
        {
            Invoker.Call<Void>(0x9029B2F3DA924928, blip, displayId);
        }

        public static void SET_BLIP_CATEGORY(int blip, int index)
        {
            Invoker.Call<Void>(0x234CDD44D996FD9A, blip, index);
        }

        public static void REMOVE_BLIP(ulong blip_ptr)
        {
            Invoker.Call<Void>(0x86A652570E5F25DD, blip_ptr);
        }

        public static void SET_BLIP_AS_FRIENDLY(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x6F6F290102C02AB4, blip, toggle);
        }

        public static void PULSE_BLIP(int blip)
        {
            Invoker.Call<Void>(0x742D6FD43115AF73, blip);
        }

        public static void SHOW_NUMBER_ON_BLIP(int blip, int number)
        {
            Invoker.Call<Void>(0xA3C0B359DCB848B6, blip, number);
        }

        public static void HIDE_NUMBER_ON_BLIP(int blip)
        {
            Invoker.Call<Void>(0x532CFF637EF80148, blip);
        }

        public static void _0x75A16C3DA34F1245(int blip, bool p1)
        {
            Invoker.Call<Void>(0x75A16C3DA34F1245, blip, p1);
        }

        public static void SHOW_TICK_ON_BLIP(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x74513EA3E505181E, blip, toggle);
        }

        public static void SHOW_HEADING_INDICATOR_ON_BLIP(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x5FBCA48327B914DF, blip, toggle);
        }

        public static void _SET_BLIP_FRIENDLY(int blip, bool toggle)
        {
            Invoker.Call<Void>(0xB81656BC81FE24D1, blip, toggle);
        }

        public static void _SET_BLIP_FRIEND(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x23C3EB807312F01A, blip, toggle);
        }

        public static void _0xDCFB5D4DB8BF367E(int p0, bool p1)
        {
            Invoker.Call<Void>(0xDCFB5D4DB8BF367E, p0, p1);
        }

        public static void _0xC4278F70131BAA6D(int p0, bool p1)
        {
            Invoker.Call<Void>(0xC4278F70131BAA6D, p0, p1);
        }

        public static void _SET_BLIP_SHRINK(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x2B6D467DAB714E8D, blip, toggle);
        }

        public static void _0x25615540D894B814(int p0, bool p1)
        {
            Invoker.Call<Void>(0x25615540D894B814, p0, p1);
        }

        public static bool DOES_BLIP_EXIST(int blip)
        {
            return Invoker.Call<bool>(0xA6DB27D19ECBB7DA, blip);
        }

        public static void SET_WAYPOINT_OFF()
        {
            Invoker.Call<Void>(0xA7E4E2D361C2627F);
        }

        public static void _0xD8E694757BCEA8E9()
        {
            Invoker.Call<Void>(0xD8E694757BCEA8E9);
        }

        public static void REFRESH_WAYPOINT()
        {
            Invoker.Call<Void>(0x81FA173F170560D1);
        }

        public static bool IS_WAYPOINT_ACTIVE()
        {
            return Invoker.Call<bool>(0x1DD1F58F493F1DA5);
        }

        public static void SET_NEW_WAYPOINT(float x, float y)
        {
            Invoker.Call<Void>(0xFE43368D2AA4F2FC, x, y);
        }

        public static void SET_BLIP_BRIGHT(int blip, bool toggle)
        {
            Invoker.Call<Void>(0xB203913733F27884, blip, toggle);
        }

        public static void SET_BLIP_SHOW_CONE(int blip, bool toggle)
        {
            Invoker.Call<Void>(0x13127EC3665E8EE1, blip, toggle);
        }

        public static void _0xC594B315EDF2D4AF(int ped)
        {
            Invoker.Call<Void>(0xC594B315EDF2D4AF, ped);
        }

        public static int SET_MINIMAP_COMPONENT(int p0, bool p1, int p2)
        {
            return Invoker.Call<int>(0x75A9A10948D1DEA6, p0, p1, p2);
        }

        public static void _0x60E892BA4F5BDCA4()
        {
            Invoker.Call<Void>(0x60E892BA4F5BDCA4);
        }

        public static int GET_MAIN_PLAYER_BLIP_ID()
        {
            return Invoker.Call<int>(0xDCD4EC3F419D02FA);
        }

        public static void _0x41350B4FC28E3941(bool p0)
        {
            Invoker.Call<Void>(0x41350B4FC28E3941, p0);
        }

        public static void HIDE_LOADING_ON_FADE_THIS_FRAME()
        {
            Invoker.Call<Void>(0x4B0311D3CDC4648F);
        }

        public static void SET_RADAR_AS_INTERIOR_THIS_FRAME(int interior, float x, float y, int heading, int zoom)
        {
            Invoker.Call<Void>(0x59E727A1C9D3E31A, interior, x, y, heading, zoom);
        }

        public static void SET_RADAR_AS_EXTERIOR_THIS_FRAME()
        {
            Invoker.Call<Void>(0xE81B7D2A3DAB2D81);
        }

        public static void _SET_PLAYER_BLIP_POSITION_THIS_FRAME(float x, float y)
        {
            Invoker.Call<Void>(0x77E2DD177910E1CF, x, y);
        }

        public static int _0x9049FE339D5F6F6F()
        {
            return Invoker.Call<int>(0x9049FE339D5F6F6F);
        }

        public static void _DISABLE_RADAR_THIS_FRAME()
        {
            Invoker.Call<Void>(0x5FBAE526203990C9);
        }

        public static void _0x20FE7FDFEEAD38C0()
        {
            Invoker.Call<Void>(0x20FE7FDFEEAD38C0);
        }

        public static void _CENTER_PLAYER_ON_RADAR_THIS_FRAME()
        {
            Invoker.Call<Void>(0x6D14BFDC33B34F55);
        }

        public static void SET_WIDESCREEN_FORMAT(int p0)
        {
            Invoker.Call<Void>(0xC3B07BA00A83B0F1, p0);
        }

        public static void DISPLAY_AREA_NAME(bool toggle)
        {
            Invoker.Call<Void>(0x276B6CE369C33678, toggle);
        }

        public static void DISPLAY_CASH(bool toggle)
        {
            Invoker.Call<Void>(0x96DEC8D5430208B7, toggle);
        }

        public static void _0x170F541E1CADD1DE(bool p0)
        {
            Invoker.Call<Void>(0x170F541E1CADD1DE, p0);
        }

        public static void _SET_PLAYER_CASH_CHANGE(int cash, int bank)
        {
            Invoker.Call<Void>(0x0772DF77852C2E30, cash, bank);
        }

        public static void DISPLAY_AMMO_THIS_FRAME(bool display)
        {
            Invoker.Call<Void>(0xA5E78BA2B1331C55, display);
        }

        public static void DISPLAY_SNIPER_SCOPE_THIS_FRAME()
        {
            Invoker.Call<Void>(0x73115226F4814E62);
        }

        public static void HIDE_HUD_AND_RADAR_THIS_FRAME()
        {
            Invoker.Call<Void>(0x719FF505F097FD20);
        }

        public static void _0xE67C6DFD386EA5E7(bool p0)
        {
            Invoker.Call<Void>(0xE67C6DFD386EA5E7, p0);
        }

        public static void _0xC2D15BEF167E27BC()
        {
            Invoker.Call<Void>(0xC2D15BEF167E27BC);
        }

        public static void _0x95CF81BD06EE1887()
        {
            Invoker.Call<Void>(0x95CF81BD06EE1887);
        }

        public static void SET_MULTIPLAYER_BANK_CASH()
        {
            Invoker.Call<Void>(0xDD21B55DF695CD0A);
        }

        public static void REMOVE_MULTIPLAYER_BANK_CASH()
        {
            Invoker.Call<Void>(0xC7C6789AA1CFEDD0);
        }

        public static void SET_MULTIPLAYER_HUD_CASH(int p0, int p1)
        {
            Invoker.Call<Void>(0xFD1D220394BCB824, p0, p1);
        }

        public static void REMOVE_MULTIPLAYER_HUD_CASH()
        {
            Invoker.Call<Void>(0x968F270E39141ECA);
        }

        public static void HIDE_HELP_TEXT_THIS_FRAME()
        {
            Invoker.Call<Void>(0xD46923FC481CA285);
        }

        public static void DISPLAY_HELP_TEXT_THIS_FRAME(string message, bool p1)
        {
            Invoker.Call<Void>(0x960C9FF8F616E41C, message, p1);
        }

        public static void _SHOW_WEAPON_WHEEL(bool forcedShow)
        {
            Invoker.Call<Void>(0xEB354E5376BC81A7, forcedShow);
        }

        public static void _BLOCK_WEAPON_WHEEL_THIS_FRAME()
        {
            Invoker.Call<Void>(0x0AFC4AF510774B47);
        }

        public static int _0xA48931185F0536FE()
        {
            return Invoker.Call<int>(0xA48931185F0536FE);
        }

        public static void _0x72C1056D678BB7D8(int weaponHash)
        {
            Invoker.Call<Void>(0x72C1056D678BB7D8, weaponHash);
        }

        public static int _0xA13E93403F26C812(int p0)
        {
            return Invoker.Call<int>(0xA13E93403F26C812, p0);
        }

        public static void _0x14C9FDCC41F81F63(bool p0)
        {
            Invoker.Call<Void>(0x14C9FDCC41F81F63, p0);
        }

        public static void SET_GPS_FLAGS(int p0, float p1)
        {
            Invoker.Call<Void>(0x5B440763A4C8D15B, p0, p1);
        }

        public static void CLEAR_GPS_FLAGS()
        {
            Invoker.Call<Void>(0x21986729D6A3A830);
        }

        public static void _0x1EAC5F91BCBC5073(bool p0)
        {
            Invoker.Call<Void>(0x1EAC5F91BCBC5073, p0);
        }

        public static void CLEAR_GPS_RACE_TRACK()
        {
            Invoker.Call<Void>(0x7AA5B4CE533C858B);
        }

        public static void _0xDB34E8D56FC13B08(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xDB34E8D56FC13B08, p0, p1, p2);
        }

        public static void _0x311438A071DD9B1A(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x311438A071DD9B1A, p0, p1, p2);
        }

        public static void _0x900086F371220B6F(bool p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x900086F371220B6F, p0, p1, p2);
        }

        public static void _0xE6DE0561D9232A64()
        {
            Invoker.Call<Void>(0xE6DE0561D9232A64);
        }

        public static void _0x3D3D15AF7BCAAF83(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x3D3D15AF7BCAAF83, p0, p1, p2);
        }

        public static void _0xA905192A6781C41B(float x, float y, float z)
        {
            Invoker.Call<Void>(0xA905192A6781C41B, x, y, z);
        }

        public static void _0x3DDA37128DD1ACA8(bool p0)
        {
            Invoker.Call<Void>(0x3DDA37128DD1ACA8, p0);
        }

        public static void _0x67EEDEA1B9BAFD94()
        {
            Invoker.Call<Void>(0x67EEDEA1B9BAFD94);
        }

        public static void CLEAR_GPS_PLAYER_WAYPOINT()
        {
            Invoker.Call<Void>(0xFF4FB7C8CDFA3DA7);
        }

        public static void SET_GPS_FLASHES(bool toggle)
        {
            Invoker.Call<Void>(0x320D0E0D936A0E9B, toggle);
        }

        public static void _0x7B21E0BB01E8224A(int p0)
        {
            Invoker.Call<Void>(0x7B21E0BB01E8224A, p0);
        }

        public static void FLASH_MINIMAP_DISPLAY()
        {
            Invoker.Call<Void>(0xF2DD778C22B15BDA);
        }

        public static void _0x6B1DE27EE78E6A19(int p0)
        {
            Invoker.Call<Void>(0x6B1DE27EE78E6A19, p0);
        }

        public static void TOGGLE_STEALTH_RADAR(bool toggle)
        {
            Invoker.Call<Void>(0x6AFDFB93754950C7, toggle);
        }

        public static void KEY_HUD_COLOUR(bool p0, int p1)
        {
            Invoker.Call<Void>(0x1A5CD7752DD28CD3, p0, p1);
        }

        public static void SET_MISSION_NAME(bool p0, string name)
        {
            Invoker.Call<Void>(0x5F28ECF5FC84772F, p0, name);
        }

        public static void _SET_MISSION_NAME_2(bool p0, string name)
        {
            Invoker.Call<Void>(0xE45087D85F468BC2, p0, name);
        }

        public static void _0x817B86108EB94E51(bool p0, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr, ulong p4_ptr, ulong p5_ptr, ulong p6_ptr, ulong p7_ptr, ulong p8_ptr)
        {
            Invoker.Call<Void>(0x817B86108EB94E51, p0, p1_ptr, p2_ptr, p3_ptr, p4_ptr, p5_ptr, p6_ptr, p7_ptr, p8_ptr);
        }

        public static void SET_MINIMAP_BLOCK_WAYPOINT(bool toggle)
        {
            Invoker.Call<Void>(0x58FADDED207897DC, toggle);
        }

        public static void _SET_NORTH_YANKTON_MAP(bool toggle)
        {
            Invoker.Call<Void>(0x9133955F1A2DA957, toggle);
        }

        public static void _SET_MINIMAP_REVEALED(bool toggle)
        {
            Invoker.Call<Void>(0xF8DEE0A5600CBB93, toggle);
        }

        public static float _0xE0130B41D3CF4574()
        {
            return Invoker.Call<float>(0xE0130B41D3CF4574);
        }

        public static bool _IS_MINIMAP_AREA_REVEALED(float x, float y, float radius)
        {
            return Invoker.Call<bool>(0x6E31B91145873922, x, y, radius);
        }

        public static void _0x62E849B7EB28E770(bool p0)
        {
            Invoker.Call<Void>(0x62E849B7EB28E770, p0);
        }

        public static void _0x0923DBF87DFF735E(float x, float y, float z)
        {
            Invoker.Call<Void>(0x0923DBF87DFF735E, x, y, z);
        }

        public static void _0x71BDB63DBAF8DA59(int p0)
        {
            Invoker.Call<Void>(0x71BDB63DBAF8DA59, p0);
        }

        public static void _0x35EDD5B2E3FF01C0()
        {
            Invoker.Call<Void>(0x35EDD5B2E3FF01C0);
        }

        public static void LOCK_MINIMAP_ANGLE(int angle)
        {
            Invoker.Call<Void>(0x299FAEBB108AE05B, angle);
        }

        public static void UNLOCK_MINIMAP_ANGLE()
        {
            Invoker.Call<Void>(0x8183455E16C42E3A);
        }

        public static void LOCK_MINIMAP_POSITION(float x, float y)
        {
            Invoker.Call<Void>(0x1279E861A329E73F, x, y);
        }

        public static void UNLOCK_MINIMAP_POSITION()
        {
            Invoker.Call<Void>(0x3E93E06DB8EF1F30);
        }

        public static void _SET_MINIMAP_ATTITUDE_INDICATOR_LEVEL(float altitude, bool p1)
        {
            Invoker.Call<Void>(0xD201F3FF917A506D, altitude, p1);
        }

        public static void _0x3F5CC444DCAAA8F2(int p0, int p1, bool p2)
        {
            Invoker.Call<Void>(0x3F5CC444DCAAA8F2, p0, p1, p2);
        }

        public static void _0x975D66A0BC17064C(int p0)
        {
            Invoker.Call<Void>(0x975D66A0BC17064C, p0);
        }

        public static void _0x06A320535F5F0248(int p0)
        {
            Invoker.Call<Void>(0x06A320535F5F0248, p0);
        }

        public static void _SET_RADAR_BIGMAP_ENABLED(bool toggleBigMap, bool showFullMap)
        {
            Invoker.Call<Void>(0x231C8F89D0539D8F, toggleBigMap, showFullMap);
        }

        public static bool IS_HUD_COMPONENT_ACTIVE(int id)
        {
            return Invoker.Call<bool>(0xBC4C9EA5391ECC0D, id);
        }

        public static bool IS_SCRIPTED_HUD_COMPONENT_ACTIVE(int id)
        {
            return Invoker.Call<bool>(0xDD100EB17A94FF65, id);
        }

        public static void HIDE_SCRIPTED_HUD_COMPONENT_THIS_FRAME(int id)
        {
            Invoker.Call<Void>(0xE374C498D8BADC14, id);
        }

        public static bool _0x09C0403ED9A751C2(int p0)
        {
            return Invoker.Call<bool>(0x09C0403ED9A751C2, p0);
        }

        public static void HIDE_HUD_COMPONENT_THIS_FRAME(int id)
        {
            Invoker.Call<Void>(0x6806C51AD12B83B8, id);
        }

        public static void SHOW_HUD_COMPONENT_THIS_FRAME(int id)
        {
            Invoker.Call<Void>(0x0B4DF1FA60C0E664, id);
        }

        public static void _0xA4DEDE28B1814289()
        {
            Invoker.Call<Void>(0xA4DEDE28B1814289);
        }

        public static void RESET_RETICULE_VALUES()
        {
            Invoker.Call<Void>(0x12782CE0A636E9F0);
        }

        public static void RESET_HUD_COMPONENT_VALUES(int id)
        {
            Invoker.Call<Void>(0x450930E616475D0D, id);
        }

        public static void SET_HUD_COMPONENT_POSITION(int id, float x, float y)
        {
            Invoker.Call<Void>(0xAABB1F56E2A17CED, id, x, y);
        }

        public static Vector3 GET_HUD_COMPONENT_POSITION(int id)
        {
            return Invoker.Call<Vector3>(0x223CA69A8C4417FD, id);
        }

        public static void CLEAR_REMINDER_MESSAGE()
        {
            Invoker.Call<Void>(0xB57D8DD645CFA2CF);
        }

        public static bool _GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, ulong screenX_ptr, ulong screenY_ptr)
        {
            return Invoker.Call<bool>(0xF9904D11F1ACBEC3, worldX, worldY, worldZ, screenX_ptr, screenY_ptr);
        }

        public static void _DISPLAY_JOB_REPORT()
        {
            Invoker.Call<Void>(0x523A590C1A3CC0D3);
        }

        public static void _0xEE4C0E6DBC6F2C6F()
        {
            Invoker.Call<Void>(0xEE4C0E6DBC6F2C6F);
        }

        public static int _0x9135584D09A3437E()
        {
            return Invoker.Call<int>(0x9135584D09A3437E);
        }

        public static bool _0x2432784ACA090DA4(int p0)
        {
            return Invoker.Call<bool>(0x2432784ACA090DA4, p0);
        }

        public static void _0x7679CC1BCEBE3D4C(int p0, float p1, float p2)
        {
            Invoker.Call<Void>(0x7679CC1BCEBE3D4C, p0, p1, p2);
        }

        public static void _0x784BA7E0ECEB4178(int p0, float x, float y, float z)
        {
            Invoker.Call<Void>(0x784BA7E0ECEB4178, p0, x, y, z);
        }

        public static void _0xB094BC1DB4018240(int p0, int p1, float p2, float p3)
        {
            Invoker.Call<Void>(0xB094BC1DB4018240, p0, p1, p2, p3);
        }

        public static void _0x788E7FD431BD67F1(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0x788E7FD431BD67F1, p0, p1, p2, p3, p4, p5);
        }

        public static void CLEAR_FLOATING_HELP(int p0, bool p1)
        {
            Invoker.Call<Void>(0x50085246ABD3FEFA, p0, p1);
        }

        public static void _SET_MP_GAMER_TAG_COLOR(int headDisplayId, string username, bool pointedClanTag, bool isRockstarClan, string clanTag, int p5, int r, int g, int b)
        {
            Invoker.Call<Void>(0x6DD05E9D83EFA4C9, headDisplayId, username, pointedClanTag, isRockstarClan, clanTag, p5, r, g, b);
        }

        public static bool _HAS_MP_GAMER_TAG()
        {
            return Invoker.Call<bool>(0x6E0EB3EB47C8D7AA);
        }

        public static int _CREATE_MP_GAMER_TAG(int ped, string username, bool pointedClanTag, bool isRockstarClan, string clanTag, int p5)
        {
            return Invoker.Call<int>(0xBFEFE3321A3F5015, ped, username, pointedClanTag, isRockstarClan, clanTag, p5);
        }

        public static void REMOVE_MP_GAMER_TAG(int gamerTagId)
        {
            Invoker.Call<Void>(0x31698AA80E0223F8, gamerTagId);
        }

        public static bool IS_MP_GAMER_TAG_ACTIVE(int gamerTagId)
        {
            return Invoker.Call<bool>(0x4E929E7A5796FD26, gamerTagId);
        }

        public static bool ADD_TREVOR_RANDOM_MODIFIER(int gamerTagId)
        {
            return Invoker.Call<bool>(0x595B5178E412E199, gamerTagId);
        }

        public static void SET_MP_GAMER_TAG_VISIBILITY(int gamerTagId, int component, bool toggle)
        {
            Invoker.Call<Void>(0x63BB75ABEDC1F6A0, gamerTagId, component, toggle);
        }

        public static void _SET_MP_GAMER_TAG_(int headDisplayId, bool p1)
        {
            Invoker.Call<Void>(0xEE76FF7E6A0166B0, headDisplayId, p1);
        }

        public static void _SET_MP_GAMER_TAG_ICONS(int headDisplayId, bool p1)
        {
            Invoker.Call<Void>(0xA67F9C46D612B6F1, headDisplayId, p1);
        }

        public static void SET_MP_GAMER_TAG_COLOUR(int gamerTagId, int flag, int color)
        {
            Invoker.Call<Void>(0x613ED644950626AE, gamerTagId, flag, color);
        }

        public static void SET_MP_GAMER_TAG_HEALTH_BAR_COLOUR(int headDisplayId, int color)
        {
            Invoker.Call<Void>(0x3158C77A7E888AB4, headDisplayId, color);
        }

        public static void SET_MP_GAMER_TAG_ALPHA(int gamerTagId, int component, int alpha)
        {
            Invoker.Call<Void>(0xD48FE545CD46F857, gamerTagId, component, alpha);
        }

        public static void SET_MP_GAMER_TAG_WANTED_LEVEL(int gamerTagId, int wantedlvl)
        {
            Invoker.Call<Void>(0xCF228E2AA03099C3, gamerTagId, wantedlvl);
        }

        public static void SET_MP_GAMER_TAG_NAME(int gamerTagId, string _string)
        {
            Invoker.Call<Void>(0xDEA2B8283BAA3944, gamerTagId, _string);
        }

        public static bool _HAS_MP_GAMER_TAG_2(int gamerTagId)
        {
            return Invoker.Call<bool>(0xEB709A36958ABE0D, gamerTagId);
        }

        public static void _SET_MP_GAMER_TAG_CHATTING(int gamerTagId, string _string)
        {
            Invoker.Call<Void>(0x7B7723747CCB55B6, gamerTagId, _string);
        }

        public static int _GET_ACTIVE_WEBSITE_ID()
        {
            return Invoker.Call<int>(0x01A358D9128B7A86);
        }

        public static int GET_CURRENT_WEBSITE_ID()
        {
            return Invoker.Call<int>(0x97D47996FC48CBAD);
        }

        public static int _0xE3B05614DCE1D014(int p0)
        {
            return Invoker.Call<int>(0xE3B05614DCE1D014, p0);
        }

        public static void _0xB99C4E4D9499DF29(bool p0)
        {
            Invoker.Call<Void>(0xB99C4E4D9499DF29, p0);
        }

        public static int _0xAF42195A42C63BBA()
        {
            return Invoker.Call<int>(0xAF42195A42C63BBA);
        }

        public static void SET_WARNING_MESSAGE(string entryLine1, int instructionalKey, string entryLine2, bool p3, int p4, ulong p5_ptr, ulong p6_ptr, bool background)
        {
            Invoker.Call<Void>(0x7B1776B3B53F8D74, entryLine1, instructionalKey, entryLine2, p3, p4, p5_ptr, p6_ptr, background);
        }

        public static void SET_WARNING_MESSAGE_WITH_HEADER(string entryHeader, string entryLine1, int instructionalKey, string entryLine2, bool p4, int p5, ulong p6_ptr, ulong p7_ptr, bool background)
        {
            Invoker.Call<Void>(0xDC38CC1E35B6A5D7, entryHeader, entryLine1, instructionalKey, entryLine2, p4, p5, p6_ptr, p7_ptr, background);
        }

        public static void _SET_WARNING_MESSAGE_3(string entryHeader, string entryLine1, int instructionalKey, string entryLine2, bool p4, int p5, int p6, ulong p7_ptr, ulong p8_ptr, bool p9)
        {
            Invoker.Call<Void>(0x701919482C74B5AB, entryHeader, entryLine1, instructionalKey, entryLine2, p4, p5, p6, p7_ptr, p8_ptr, p9);
        }

        public static bool _0x0C5A80A9E096D529(int p0, ulong p1_ptr, int p2, int p3, int p4, int p5)
        {
            return Invoker.Call<bool>(0x0C5A80A9E096D529, p0, p1_ptr, p2, p3, p4, p5);
        }

        public static bool _0xDAF87174BE7454FF(int p0)
        {
            return Invoker.Call<bool>(0xDAF87174BE7454FF, p0);
        }

        public static void _0x6EF54AB721DC6242()
        {
            Invoker.Call<Void>(0x6EF54AB721DC6242);
        }

        public static bool IS_WARNING_MESSAGE_ACTIVE()
        {
            return Invoker.Call<bool>(0xE18B138FABC53103);
        }

        public static void _0x7792424AA0EAC32E()
        {
            Invoker.Call<Void>(0x7792424AA0EAC32E);
        }

        public static void _SET_MAP_FULL_SCREEN(bool toggle)
        {
            Invoker.Call<Void>(0x5354C5BA2EA868A4, toggle);
        }

        public static void _0x1EAE6DD17B7A5EFA(int p0)
        {
            Invoker.Call<Void>(0x1EAE6DD17B7A5EFA, p0);
        }

        public static int _0x551DF99658DB6EE8(float p0, float p1, float p2)
        {
            return Invoker.Call<int>(0x551DF99658DB6EE8, p0, p1, p2);
        }

        public static void _0x2708FC083123F9FF()
        {
            Invoker.Call<Void>(0x2708FC083123F9FF);
        }

        public static int _0x1121BFA1A1A522A8()
        {
            return Invoker.Call<int>(0x1121BFA1A1A522A8);
        }

        public static void _0x82CEDC33687E1F50(bool p0)
        {
            Invoker.Call<Void>(0x82CEDC33687E1F50, p0);
        }

        public static void _0x211C4EF450086857()
        {
            Invoker.Call<Void>(0x211C4EF450086857);
        }

        public static void _0xBF4F34A85CA2970C()
        {
            Invoker.Call<Void>(0xBF4F34A85CA2970C);
        }

        public static void ACTIVATE_FRONTEND_MENU(int menuhash, bool Toggle_Pause, int component)
        {
            Invoker.Call<Void>(0xEF01D36B9C9D0C7B, menuhash, Toggle_Pause, component);
        }

        public static void RESTART_FRONTEND_MENU(int menuHash, int p1)
        {
            Invoker.Call<Void>(0x10706DC6AD2D49C0, menuHash, p1);
        }

        public static int _GET_CURRENT_FRONTEND_MENU()
        {
            return Invoker.Call<int>(0x2309595AD6145265);
        }

        public static void SET_PAUSE_MENU_ACTIVE(bool toggle)
        {
            Invoker.Call<Void>(0xDF47FC56C71569CF, toggle);
        }

        public static void DISABLE_FRONTEND_THIS_FRAME()
        {
            Invoker.Call<Void>(0x6D3465A73092F0E6);
        }

        public static void _0xBA751764F0821256()
        {
            Invoker.Call<Void>(0xBA751764F0821256);
        }

        public static void _0xCC3FDDED67BCFC63()
        {
            Invoker.Call<Void>(0xCC3FDDED67BCFC63);
        }

        public static void SET_FRONTEND_ACTIVE(bool active)
        {
            Invoker.Call<Void>(0x745711A75AB09277, active);
        }

        public static bool IS_PAUSE_MENU_ACTIVE()
        {
            return Invoker.Call<bool>(0xB0034A223497FFCB);
        }

        public static int _0x2F057596F2BD0061()
        {
            return Invoker.Call<int>(0x2F057596F2BD0061);
        }

        public static int GET_PAUSE_MENU_STATE()
        {
            return Invoker.Call<int>(0x272ACD84970869C5);
        }

        public static Vector3 _0x5BFF36D6ED83E0AE()
        {
            return Invoker.Call<Vector3>(0x5BFF36D6ED83E0AE);
        }

        public static bool IS_PAUSE_MENU_RESTARTING()
        {
            return Invoker.Call<bool>(0x1C491717107431C7);
        }

        public static void _LOG_DEBUG_INFO(string p0)
        {
            Invoker.Call<Void>(0x2162C446DFDF38FD, p0);
        }

        public static void _0x77F16B447824DA6C(int p0)
        {
            Invoker.Call<Void>(0x77F16B447824DA6C, p0);
        }

        public static void _0xCDCA26E80FAECB8F()
        {
            Invoker.Call<Void>(0xCDCA26E80FAECB8F);
        }

        public static void _ADD_FRONTEND_MENU_CONTEXT(int hash)
        {
            Invoker.Call<Void>(0xDD564BDD0472C936, hash);
        }

        public static void OBJECT_DECAL_TOGGLE(int hash)
        {
            Invoker.Call<Void>(0x444D8CF241EC25C5, hash);
        }

        public static bool _0x84698AB38D0C6636(int hash)
        {
            return Invoker.Call<bool>(0x84698AB38D0C6636, hash);
        }

        public static int _0x2A25ADC48F87841F()
        {
            return Invoker.Call<int>(0x2A25ADC48F87841F);
        }

        public static int _0xDE03620F8703A9DF()
        {
            return Invoker.Call<int>(0xDE03620F8703A9DF);
        }

        public static int _0x359AF31A4B52F5ED()
        {
            return Invoker.Call<int>(0x359AF31A4B52F5ED);
        }

        public static int _0x13C4B962653A5280()
        {
            return Invoker.Call<int>(0x13C4B962653A5280);
        }

        public static bool _0xC8E1071177A23BE5(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xC8E1071177A23BE5, p0_ptr, p1_ptr, p2_ptr);
        }

        public static void ENABLE_DEATHBLOOD_SEETHROUGH(bool p0)
        {
            Invoker.Call<Void>(0x4895BDEA16E7C080, p0);
        }

        public static void _0xC78E239AC5B2DDB9(bool p0, int p1, int p2)
        {
            Invoker.Call<Void>(0xC78E239AC5B2DDB9, p0, p1, p2);
        }

        public static void _0xF06EBB91A81E09E3(bool p0)
        {
            Invoker.Call<Void>(0xF06EBB91A81E09E3, p0);
        }

        public static int _0x3BAB9A4E4F2FF5C7()
        {
            return Invoker.Call<int>(0x3BAB9A4E4F2FF5C7);
        }

        public static void _0xEC9264727EEC0F28()
        {
            Invoker.Call<Void>(0xEC9264727EEC0F28);
        }

        public static void _0x14621BB1DF14E2B2()
        {
            Invoker.Call<Void>(0x14621BB1DF14E2B2);
        }

        public static int _0x66E7CB63C97B7D20()
        {
            return Invoker.Call<int>(0x66E7CB63C97B7D20);
        }

        public static int _0x593FEAE1F73392D4()
        {
            return Invoker.Call<int>(0x593FEAE1F73392D4);
        }

        public static int _0x4E3CD0EF8A489541()
        {
            return Invoker.Call<int>(0x4E3CD0EF8A489541);
        }

        public static int _0xF284AC67940C6812()
        {
            return Invoker.Call<int>(0xF284AC67940C6812);
        }

        public static int _0x2E22FEFA0100275E()
        {
            return Invoker.Call<int>(0x2E22FEFA0100275E);
        }

        public static void _0x0CF54F20DE43879C(int p0)
        {
            Invoker.Call<Void>(0x0CF54F20DE43879C, p0);
        }

        public static void _0x36C1451A88A09630(ulong p0_ptr, ulong p1_ptr)
        {
            Invoker.Call<Void>(0x36C1451A88A09630, p0_ptr, p1_ptr);
        }

        public static void _0x7E17BE53E1AAABAF(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            Invoker.Call<Void>(0x7E17BE53E1AAABAF, p0_ptr, p1_ptr, p2_ptr);
        }

        public static bool _0xA238192F33110615(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xA238192F33110615, p0_ptr, p1_ptr, p2_ptr);
        }

        public static bool SET_USERIDS_UIHIDDEN(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xEF4CED81CEBEDC6D, p0, p1_ptr);
        }

        public static bool _0xCA6B2F7CE32AB653(int p0, ulong p1_ptr, int p2)
        {
            return Invoker.Call<bool>(0xCA6B2F7CE32AB653, p0, p1_ptr, p2);
        }

        public static bool _0x90A6526CF0381030(int p0, ulong p1_ptr, int p2, int p3)
        {
            return Invoker.Call<bool>(0x90A6526CF0381030, p0, p1_ptr, p2, p3);
        }

        public static bool _0x24A49BEAF468DC90(int p0, ulong p1_ptr, int p2, int p3, int p4)
        {
            return Invoker.Call<bool>(0x24A49BEAF468DC90, p0, p1_ptr, p2, p3, p4);
        }

        public static bool _0x5FBD7095FE7AE57F(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x5FBD7095FE7AE57F, p0, p1_ptr);
        }

        public static bool _0x8F08017F9D7C47BD(int p0, ulong p1_ptr, int p2)
        {
            return Invoker.Call<bool>(0x8F08017F9D7C47BD, p0, p1_ptr, p2);
        }

        public static bool _0x052991E59076E4E4(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x052991E59076E4E4, p0, p1_ptr);
        }

        public static void CLEAR_PED_IN_PAUSE_MENU()
        {
            Invoker.Call<Void>(0x5E62BE5DC58E9E06);
        }

        public static void GIVE_PED_TO_PAUSE_MENU(int ped, int p1)
        {
            Invoker.Call<Void>(0xAC0BFBDC3BE00E14, ped, p1);
        }

        public static void _0x3CA6050692BC61B0(bool p0)
        {
            Invoker.Call<Void>(0x3CA6050692BC61B0, p0);
        }

        public static void _0xECF128344E9FF9F1(bool p0)
        {
            Invoker.Call<Void>(0xECF128344E9FF9F1, p0);
        }

        public static void _SHOW_SOCIAL_CLUB_LEGAL_SCREEN()
        {
            Invoker.Call<Void>(0x805D7CBB36FD6C4C);
        }

        public static int _0xF13FE2A80C05C561()
        {
            return Invoker.Call<int>(0xF13FE2A80C05C561);
        }

        public static int _0x6F72CD94F7B5B68C()
        {
            return Invoker.Call<int>(0x6F72CD94F7B5B68C);
        }

        public static void _0x75D3691713C3B05A()
        {
            Invoker.Call<Void>(0x75D3691713C3B05A);
        }

        public static void _0xD2B32BE3FC1626C6()
        {
            Invoker.Call<Void>(0xD2B32BE3FC1626C6);
        }

        public static void _0x9E778248D6685FE0(string p0)
        {
            Invoker.Call<Void>(0x9E778248D6685FE0, p0);
        }

        public static bool IS_SOCIAL_CLUB_ACTIVE()
        {
            return Invoker.Call<bool>(0xC406BE343FC4B9AF);
        }

        public static void _0x1185A8087587322C(bool p0)
        {
            Invoker.Call<Void>(0x1185A8087587322C, p0);
        }

        public static void _0x8817605C2BA76200()
        {
            Invoker.Call<Void>(0x8817605C2BA76200);
        }

        public static bool _IS_TEXT_CHAT_ACTIVE()
        {
            return Invoker.Call<bool>(0xB118AF58B5F332A1);
        }

        public static void _ABORT_TEXT_CHAT()
        {
            Invoker.Call<Void>(0x1AC8F4AD40E22127);
        }

        public static void _SET_TEXT_CHAT_UNK(bool p0)
        {
            Invoker.Call<Void>(0x1DB21A44B09E8BA3, p0);
        }

        public static void _0xCEF214315D276FD1(bool p0)
        {
            Invoker.Call<Void>(0xCEF214315D276FD1, p0);
        }

        public static void _SET_PED_AI_BLIP(int pedHandle, bool showViewCones)
        {
            Invoker.Call<Void>(0xD30C50DF888D58B5, pedHandle, showViewCones);
        }

        public static bool DOES_PED_HAVE_AI_BLIP(int ped)
        {
            return Invoker.Call<bool>(0x15B8ECF844EE67ED, ped);
        }

        public static void _SET_AI_BLIP_TYPE(int ped, int type)
        {
            Invoker.Call<Void>(0xE52B8E7F85D39A08, ped, type);
        }

        public static void HIDE_SPECIAL_ABILITY_LOCKON_OPERATION(int p0, bool p1)
        {
            Invoker.Call<Void>(0x3EED80DFF7325CAA, p0, p1);
        }

        public static void _IS_AI_BLIP_ALWAYS_SHOWN(int ped, bool flag)
        {
            Invoker.Call<Void>(0x0C4BBF625CA98C4E, ped, flag);
        }

        public static void _SET_AI_BLIP_MAX_DISTANCE(int ped, float distance)
        {
            Invoker.Call<Void>(0x97C65887D4B37FA9, ped, distance);
        }

        public static ulong _0x7CD934010E115C2C(int ped)
        {
            return Invoker.Call<ulong>(0x7CD934010E115C2C, ped);
        }

        public static int _GET_AI_BLIP(int ped)
        {
            return Invoker.Call<int>(0x56176892826A4FE8, ped);
        }

        public static int _0xA277800A9EAE340E()
        {
            return Invoker.Call<int>(0xA277800A9EAE340E);
        }

        public static void _0x2632482FD6B9AB87()
        {
            Invoker.Call<Void>(0x2632482FD6B9AB87);
        }

        public static void _SET_DIRECTOR_MODE(bool toggle)
        {
            Invoker.Call<Void>(0x808519373FD336A3, toggle);
        }

        public static void _0x04655F9D075D0AE5(bool p0)
        {
            Invoker.Call<Void>(0x04655F9D075D0AE5, p0);
        }

    }

    public static class GRAPHICS
    {

        public static void SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE(bool enabled)
        {
            Invoker.Call<Void>(0x175B6BFC15CDD0C5, enabled);
        }

        public static void DRAW_DEBUG_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x7FDFADE676AA3CB0, x1, y1, z1, x2, y2, z2, red, green, blue, alpha);
        }

        public static void DRAW_DEBUG_LINE_WITH_TWO_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, int r1, int g1, int b1, int r2, int g2, int b2, int alpha1, int alpha2)
        {
            Invoker.Call<Void>(0xD8B9A8AC5608FF94, x1, y1, z1, x2, y2, z2, r1, g1, b1, r2, g2, b2, alpha1, alpha2);
        }

        public static void DRAW_DEBUG_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xAAD68E1AB39DA632, x, y, z, radius, red, green, blue, alpha);
        }

        public static void DRAW_DEBUG_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x083A2CA4F2E573BD, x1, y1, z1, x2, y2, z2, red, green, blue, alpha);
        }

        public static void DRAW_DEBUG_CROSS(float x, float y, float z, float size, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x73B1189623049839, x, y, z, size, red, green, blue, alpha);
        }

        public static void DRAW_DEBUG_TEXT(string text, float x, float y, float z, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x3903E216620488E8, text, x, y, z, red, green, blue, alpha);
        }

        public static void DRAW_DEBUG_TEXT_2D(string text, float x, float y, float z, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xA3BB2E9555C05A8F, text, x, y, z, red, green, blue, alpha);
        }

        public static void DRAW_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x6B7256074AE34680, x1, y1, z1, x2, y2, z2, red, green, blue, alpha);
        }

        public static void DRAW_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xAC26716048436851, x1, y1, z1, x2, y2, z2, x3, y3, z3, red, green, blue, alpha);
        }

        public static void DRAW_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xD3A9971CADAC7252, x1, y1, z1, x2, y2, z2, red, green, blue, alpha);
        }

        public static void _0x23BA6B0C2AD7B0D3(bool toggle)
        {
            Invoker.Call<Void>(0x23BA6B0C2AD7B0D3, toggle);
        }

        public static bool _0x1DD2139A9A20DCE8()
        {
            return Invoker.Call<bool>(0x1DD2139A9A20DCE8);
        }

        public static int _0x90A78ECAA4E78453()
        {
            return Invoker.Call<int>(0x90A78ECAA4E78453);
        }

        public static void _0x0A46AF8A78DC5E0A()
        {
            Invoker.Call<Void>(0x0A46AF8A78DC5E0A);
        }

        public static bool _0x4862437A486F91B0(string p0, ulong p1_ptr, ulong p2_ptr, bool p3)
        {
            return Invoker.Call<bool>(0x4862437A486F91B0, p0, p1_ptr, p2_ptr, p3);
        }

        public static int _0x1670F8D05056F257(int p0)
        {
            return Invoker.Call<int>(0x1670F8D05056F257, p0);
        }

        public static bool _0x7FA5D82B8F58EC06()
        {
            return Invoker.Call<bool>(0x7FA5D82B8F58EC06);
        }

        public static int _0x5B0316762AFD4A64()
        {
            return Invoker.Call<int>(0x5B0316762AFD4A64);
        }

        public static void _0x346EF3ECAAAB149E()
        {
            Invoker.Call<Void>(0x346EF3ECAAAB149E);
        }

        public static bool _0xA67C35C56EB1BD9D()
        {
            return Invoker.Call<bool>(0xA67C35C56EB1BD9D);
        }

        public static int _0x0D6CA79EEEBD8CA3()
        {
            return Invoker.Call<int>(0x0D6CA79EEEBD8CA3);
        }

        public static void _0xD801CC02177FA3F1()
        {
            Invoker.Call<Void>(0xD801CC02177FA3F1);
        }

        public static void _0x1BBC135A4D25EDDE(bool p0)
        {
            Invoker.Call<Void>(0x1BBC135A4D25EDDE, p0);
        }

        public static bool _0x3DEC726C25A11BAC(int p0)
        {
            return Invoker.Call<bool>(0x3DEC726C25A11BAC, p0);
        }

        public static int _0x0C0C4E81E1AC60A0()
        {
            return Invoker.Call<int>(0x0C0C4E81E1AC60A0);
        }

        public static bool _0x759650634F07B6B4(int p0)
        {
            return Invoker.Call<bool>(0x759650634F07B6B4, p0);
        }

        public static int _0xCB82A0BF0E3E3265(int p0)
        {
            return Invoker.Call<int>(0xCB82A0BF0E3E3265, p0);
        }

        public static void _0x6A12D88881435DCA()
        {
            Invoker.Call<Void>(0x6A12D88881435DCA);
        }

        public static void _0x1072F115DAB0717E(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x1072F115DAB0717E, p0, p1);
        }

        public static int GET_MAXIMUM_NUMBER_OF_PHOTOS()
        {
            return Invoker.Call<int>(0x34D23450F028B0BF);
        }

        public static int _GET_MAXIMUM_NUMBER_OF_PHOTOS_2()
        {
            return Invoker.Call<int>(0xDC54A7AF8B3A14EF);
        }

        public static int _GET_NUMBER_OF_PHOTOS()
        {
            return Invoker.Call<int>(0x473151EBC762C6DA);
        }

        public static bool _0x2A893980E96B659A(bool p0)
        {
            return Invoker.Call<bool>(0x2A893980E96B659A, p0);
        }

        public static int _0xF5BED327CEA362B1(bool p0)
        {
            return Invoker.Call<int>(0xF5BED327CEA362B1, p0);
        }

        public static void _0x4AF92ACD3141D96C()
        {
            Invoker.Call<Void>(0x4AF92ACD3141D96C);
        }

        public static int _0xE791DF1F73ED2C8B(int p0)
        {
            return Invoker.Call<int>(0xE791DF1F73ED2C8B, p0);
        }

        public static int _0xEC72C258667BE5EA(int p0)
        {
            return Invoker.Call<int>(0xEC72C258667BE5EA, p0);
        }

        public static int _RETURN_TWO(int p0)
        {
            return Invoker.Call<int>(0x40AFB081F8ADD4EE, p0);
        }

        public static void _DRAW_LIGHT_WITH_RANGE_AND_SHADOW(float x, float y, float z, int r, int g, int b, float range, float intensity, float shadow)
        {
            Invoker.Call<Void>(0xF49E9A9716A04595, x, y, z, r, g, b, range, intensity, shadow);
        }

        public static void DRAW_LIGHT_WITH_RANGE(float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity)
        {
            Invoker.Call<Void>(0xF2A1B2771A01DBD4, posX, posY, posZ, colorR, colorG, colorB, range, intensity);
        }

        public static void DRAW_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float hardness, float radius, float falloff)
        {
            Invoker.Call<Void>(0xD0F64B265C8C8B33, posX, posY, posZ, dirX, dirY, dirZ, colorR, colorG, colorB, distance, brightness, hardness, radius, falloff);
        }

        public static void _DRAW_SPOT_LIGHT_WITH_SHADOW(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float roundness, float radius, float falloff, int shadowId)
        {
            Invoker.Call<Void>(0x5BCA583A583194DB, posX, posY, posZ, dirX, dirY, dirZ, colorR, colorG, colorB, distance, brightness, roundness, radius, falloff, shadowId);
        }

        public static void _0xC9B18B4619F48F7B(float p0)
        {
            Invoker.Call<Void>(0xC9B18B4619F48F7B, p0);
        }

        public static void _ENTITY_DESCRIPTION_TEXT(int entity)
        {
            Invoker.Call<Void>(0xDEADC0DEDEADC0DE, entity);
        }

        public static void DRAW_MARKER(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, int p19, bool rotate, string textureDict, string textureName, bool drawOnEnts)
        {
            Invoker.Call<Void>(0x28477EC23D892089, type, posX, posY, posZ, dirX, dirY, dirZ, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, red, green, blue, alpha, bobUpAndDown, faceCamera, p19, rotate, textureDict, textureName, drawOnEnts);
        }

        public static int CREATE_CHECKPOINT(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float radius, int red, int green, int blue, int alpha, int reserved)
        {
            return Invoker.Call<int>(0x0134F0835AB6BFCB, type, posX1, posY1, posZ1, posX2, posY2, posZ2, radius, red, green, blue, alpha, reserved);
        }

        public static void _SET_CHECKPOINT_SCALE(int checkpoint, float p0)
        {
            Invoker.Call<Void>(0x4B5B4DA5D79F1943, checkpoint, p0);
        }

        public static void SET_CHECKPOINT_CYLINDER_HEIGHT(int checkpoint, float nearHeight, float farHeight, float radius)
        {
            Invoker.Call<Void>(0x2707AAE9D9297D89, checkpoint, nearHeight, farHeight, radius);
        }

        public static void SET_CHECKPOINT_RGBA(int checkpoint, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x7167371E8AD747F7, checkpoint, red, green, blue, alpha);
        }

        public static void _SET_CHECKPOINT_ICON_RGBA(int checkpoint, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xB9EA40907C680580, checkpoint, red, green, blue, alpha);
        }

        public static void _0xF51D36185993515D(int checkpoint, float posX, float posY, float posZ, float unkX, float unkY, float unkZ)
        {
            Invoker.Call<Void>(0xF51D36185993515D, checkpoint, posX, posY, posZ, unkX, unkY, unkZ);
        }

        public static void _0x615D3925E87A3B26(int checkpoint)
        {
            Invoker.Call<Void>(0x615D3925E87A3B26, checkpoint);
        }

        public static void DELETE_CHECKPOINT(int checkpoint)
        {
            Invoker.Call<Void>(0xF5ED37F54CD4D52E, checkpoint);
        }

        public static void _0x22A249A53034450A(bool p0)
        {
            Invoker.Call<Void>(0x22A249A53034450A, p0);
        }

        public static void _0xDC459CFA0CCE245B(bool p0)
        {
            Invoker.Call<Void>(0xDC459CFA0CCE245B, p0);
        }

        public static void REQUEST_STREAMED_TEXTURE_DICT(string textureDict, bool p1)
        {
            Invoker.Call<Void>(0xDFA2EF8E04127DD5, textureDict, p1);
        }

        public static bool HAS_STREAMED_TEXTURE_DICT_LOADED(string textureDict)
        {
            return Invoker.Call<bool>(0x0145F696AAAAD2E4, textureDict);
        }

        public static void SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED(string textureDict)
        {
            Invoker.Call<Void>(0xBE2CACCF5A8AA805, textureDict);
        }

        public static void DRAW_RECT(float x, float y, float width, float height, int r, int g, int b, int a)
        {
            Invoker.Call<Void>(0x3A618A217E5154F0, x, y, width, height, r, g, b, a);
        }

        public static void _0xC6372ECD45D73BCD(bool p0)
        {
            Invoker.Call<Void>(0xC6372ECD45D73BCD, p0);
        }

        public static void _SET_UI_LAYER(int layer)
        {
            Invoker.Call<Void>(0x61BB1D9B3A95D802, layer);
        }

        public static void _SCREEN_DRAW_POSITION_BEGIN(int x, int y)
        {
            Invoker.Call<Void>(0xB8A850F20A067EB6, x, y);
        }

        public static void _SCREEN_DRAW_POSITION_END()
        {
            Invoker.Call<Void>(0xE3A3DB414A373DAB);
        }

        public static void _SCREEN_DRAW_POSITION_RATIO(float x, float y, float p2, float p3)
        {
            Invoker.Call<Void>(0xF5A2C681787E579D, x, y, p2, p3);
        }

        public static void _0x6DD8F5AA635EB4B2(float p0, float p1, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0x6DD8F5AA635EB4B2, p0, p1, p2_ptr, p3_ptr);
        }

        public static float GET_SAFE_ZONE_SIZE()
        {
            return Invoker.Call<float>(0xBAF107B6BB2C97F0);
        }

        public static void DRAW_SPRITE(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xE7FFAE5EBF23D890, textureDict, textureName, screenX, screenY, width, height, heading, red, green, blue, alpha);
        }

        public static int ADD_ENTITY_ICON(int entity, string icon)
        {
            return Invoker.Call<int>(0x9CD43EEE12BF4DD0, entity, icon);
        }

        public static void SET_ENTITY_ICON_VISIBILITY(int entity, bool toggle)
        {
            Invoker.Call<Void>(0xE0E8BEECCA96BA31, entity, toggle);
        }

        public static void SET_ENTITY_ICON_COLOR(int entity, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0x1D5F595CCAE2E238, entity, red, green, blue, alpha);
        }

        public static void SET_DRAW_ORIGIN(float x, float y, float z, int p3)
        {
            Invoker.Call<Void>(0xAA0008F3BBB8F416, x, y, z, p3);
        }

        public static void CLEAR_DRAW_ORIGIN()
        {
            Invoker.Call<Void>(0xFF0B610F6BE0D7AF);
        }

        public static void ATTACH_TV_AUDIO_TO_ENTITY(int entity)
        {
            Invoker.Call<Void>(0x845BAD77CC770633, entity);
        }

        public static void SET_TV_AUDIO_FRONTEND(bool toggle)
        {
            Invoker.Call<Void>(0x113D2C5DC57E1774, toggle);
        }

        public static int LOAD_MOVIE_MESH_SET(string movieMeshSetName)
        {
            return Invoker.Call<int>(0xB66064452270E8F1, movieMeshSetName);
        }

        public static void RELEASE_MOVIE_MESH_SET(int movieMeshSet)
        {
            Invoker.Call<Void>(0xEB119AA014E89183, movieMeshSet);
        }

        public static int _0x9B6E70C5CEEF4EEB(int p0)
        {
            return Invoker.Call<int>(0x9B6E70C5CEEF4EEB, p0);
        }

        public static void GET_SCREEN_RESOLUTION(ulong x_ptr, ulong y_ptr)
        {
            Invoker.Call<Void>(0x888D57E407E63624, x_ptr, y_ptr);
        }

        public static void _GET_ACTIVE_SCREEN_RESOLUTION(ulong x_ptr, ulong y_ptr)
        {
            Invoker.Call<Void>(0x873C9F3104101DD3, x_ptr, y_ptr);
        }

        public static float _GET_ASPECT_RATIO(bool b)
        {
            return Invoker.Call<float>(0xF1307EF624A80D87, b);
        }

        public static int _0xB2EBE8CBC58B90E9()
        {
            return Invoker.Call<int>(0xB2EBE8CBC58B90E9);
        }

        public static bool GET_IS_WIDESCREEN()
        {
            return Invoker.Call<bool>(0x30CF4BDA4FCB1905);
        }

        public static bool GET_IS_HIDEF()
        {
            return Invoker.Call<bool>(0x84ED31191CC5D2C9);
        }

        public static void _0xEFABC7722293DA7C()
        {
            Invoker.Call<Void>(0xEFABC7722293DA7C);
        }

        public static void SET_NIGHTVISION(bool toggle)
        {
            Invoker.Call<Void>(0x18F621F7A5B1F85D, toggle);
        }

        public static int _0x35FB78DC42B7BD21()
        {
            return Invoker.Call<int>(0x35FB78DC42B7BD21);
        }

        public static bool _IS_NIGHTVISION_ACTIVE()
        {
            return Invoker.Call<bool>(0x2202A3F42C8E5F79);
        }

        public static void _0xEF398BEEE4EF45F9(bool p0)
        {
            Invoker.Call<Void>(0xEF398BEEE4EF45F9, p0);
        }

        public static void SET_NOISEOVERIDE(bool toggle)
        {
            Invoker.Call<Void>(0xE787BF1C5CF823C9, toggle);
        }

        public static void SET_NOISINESSOVERIDE(float value)
        {
            Invoker.Call<Void>(0xCB6A7C3BB17A0C67, value);
        }

        public static bool GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, ulong screenX_ptr, ulong screenY_ptr)
        {
            return Invoker.Call<bool>(0x34E82F05DF2974F5, worldX, worldY, worldZ, screenX_ptr, screenY_ptr);
        }

        public static Vector3 GET_TEXTURE_RESOLUTION(string textureDict, string textureName)
        {
            return Invoker.Call<Vector3>(0x35736EE65BD00C11, textureDict, textureName);
        }

        public static void _0xE2892E7E55D7073A(float p0)
        {
            Invoker.Call<Void>(0xE2892E7E55D7073A, p0);
        }

        public static void SET_FLASH(float p0, float p1, float fadeIn, float duration, float fadeOut)
        {
            Invoker.Call<Void>(0x0AB84296FED9CFC6, p0, p1, fadeIn, duration, fadeOut);
        }

        public static void _0x3669F1B198DCAA4F()
        {
            Invoker.Call<Void>(0x3669F1B198DCAA4F);
        }

        public static void _SET_BLACKOUT(bool enable)
        {
            Invoker.Call<Void>(0x1268615ACE24D504, enable);
        }

        public static void _0xC35A6D07C93802B2()
        {
            Invoker.Call<Void>(0xC35A6D07C93802B2);
        }

        public static int CREATE_TRACKED_POINT()
        {
            return Invoker.Call<int>(0xE2C9439ED45DEA60);
        }

        public static void SET_TRACKED_POINT_INFO(int point, float x, float y, float z, float radius)
        {
            Invoker.Call<Void>(0x164ECBB3CF750CB0, point, x, y, z, radius);
        }

        public static bool IS_TRACKED_POINT_VISIBLE(int point)
        {
            return Invoker.Call<bool>(0xC45CCDAAC9221CA8, point);
        }

        public static void DESTROY_TRACKED_POINT(int point)
        {
            Invoker.Call<Void>(0xB25DC90BAD56CA42, point);
        }

        public static int _0xBE197EAA669238F4(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0xBE197EAA669238F4, p0, p1, p2, p3);
        }

        public static void _0x61F95E5BB3E0A8C6(int p0)
        {
            Invoker.Call<Void>(0x61F95E5BB3E0A8C6, p0);
        }

        public static void _0xAE51BC858F32BA66(int p0, float p1, float p2, float p3, float p4)
        {
            Invoker.Call<Void>(0xAE51BC858F32BA66, p0, p1, p2, p3, p4);
        }

        public static void _0x649C97D52332341A(int p0)
        {
            Invoker.Call<Void>(0x649C97D52332341A, p0);
        }

        public static int _0x2C42340F916C5930(int p0)
        {
            return Invoker.Call<int>(0x2C42340F916C5930, p0);
        }

        public static void _0x14FC5833464340A8()
        {
            Invoker.Call<Void>(0x14FC5833464340A8);
        }

        public static void _0x0218BA067D249DEA()
        {
            Invoker.Call<Void>(0x0218BA067D249DEA);
        }

        public static void _0x1612C45F9E3E0D44()
        {
            Invoker.Call<Void>(0x1612C45F9E3E0D44);
        }

        public static void _0x5DEBD9C4DC995692()
        {
            Invoker.Call<Void>(0x5DEBD9C4DC995692);
        }

        public static void _0x6D955F6A9E0295B1(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Invoker.Call<Void>(0x6D955F6A9E0295B1, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void _0x302C91AB2D477F7E()
        {
            Invoker.Call<Void>(0x302C91AB2D477F7E);
        }

        public static void _0x03FC694AE06C5A20()
        {
            Invoker.Call<Void>(0x03FC694AE06C5A20);
        }

        public static void _0xD2936CAB8B58FCBD(int p0, bool p1, float p2, float p3, float p4, float p5, bool p6, float p7)
        {
            Invoker.Call<Void>(0xD2936CAB8B58FCBD, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void _0x5F0F3F56635809EF(float p0)
        {
            Invoker.Call<Void>(0x5F0F3F56635809EF, p0);
        }

        public static void _0x5E9DAF5A20F15908(float p0)
        {
            Invoker.Call<Void>(0x5E9DAF5A20F15908, p0);
        }

        public static void _0x36F6626459D91457(float p0)
        {
            Invoker.Call<Void>(0x36F6626459D91457, p0);
        }

        public static void _SET_FAR_SHADOWS_SUPPRESSED(bool toggle)
        {
            Invoker.Call<Void>(0x80ECBC0C856D3B0B, toggle);
        }

        public static void _0x25FC3E33A31AD0C9(bool p0)
        {
            Invoker.Call<Void>(0x25FC3E33A31AD0C9, p0);
        }

        public static void _0xB11D94BC55F41932(string p0)
        {
            Invoker.Call<Void>(0xB11D94BC55F41932, p0);
        }

        public static void _0x27CB772218215325()
        {
            Invoker.Call<Void>(0x27CB772218215325);
        }

        public static void _0x6DDBF9DFFC4AC080(bool p0)
        {
            Invoker.Call<Void>(0x6DDBF9DFFC4AC080, p0);
        }

        public static void _0xD39D13C9FEBF0511(bool p0)
        {
            Invoker.Call<Void>(0xD39D13C9FEBF0511, p0);
        }

        public static int _0x02AC28F3A01FA04A(float p0)
        {
            return Invoker.Call<int>(0x02AC28F3A01FA04A, p0);
        }

        public static void _0x0AE73D8DF3A762B2(bool p0)
        {
            Invoker.Call<Void>(0x0AE73D8DF3A762B2, p0);
        }

        public static void _0xA51C4B86B71652AE(bool p0)
        {
            Invoker.Call<Void>(0xA51C4B86B71652AE, p0);
        }

        public static void _0x312342E1A4874F3F(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8)
        {
            Invoker.Call<Void>(0x312342E1A4874F3F, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void _0x2485D34E50A22E84(float p0, float p1, float p2)
        {
            Invoker.Call<Void>(0x2485D34E50A22E84, p0, p1, p2);
        }

        public static void _0x12995F2E53FFA601(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11)
        {
            Invoker.Call<Void>(0x12995F2E53FFA601, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        public static void _0xDBAA5EC848BA2D46(int p0, int p1)
        {
            Invoker.Call<Void>(0xDBAA5EC848BA2D46, p0, p1);
        }

        public static void _0xC0416B061F2B7E5E(bool p0)
        {
            Invoker.Call<Void>(0xC0416B061F2B7E5E, p0);
        }

        public static void _0xB1BB03742917A5D6(int type, float xPos, float yPos, float zPos, float p4, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xB1BB03742917A5D6, type, xPos, yPos, zPos, p4, red, green, blue, alpha);
        }

        public static void _0x9CFDD90B2B844BF7(float p0, float p1, float p2, float p3, float p4)
        {
            Invoker.Call<Void>(0x9CFDD90B2B844BF7, p0, p1, p2, p3, p4);
        }

        public static void _0x06F761EA47C1D3ED(bool p0)
        {
            Invoker.Call<Void>(0x06F761EA47C1D3ED, p0);
        }

        public static int _0xA4819F5E23E2FFAD()
        {
            return Invoker.Call<int>(0xA4819F5E23E2FFAD);
        }

        public static int _0xA4664972A9B8F8BA(int p0)
        {
            return Invoker.Call<int>(0xA4664972A9B8F8BA, p0);
        }

        public static void SET_SEETHROUGH(bool toggle)
        {
            Invoker.Call<Void>(0x7E08924259E08CE0, toggle);
        }

        public static bool _IS_SEETHROUGH_ACTIVE()
        {
            return Invoker.Call<bool>(0x44B80ABAB9D80BD3);
        }

        public static void _0xD7D0B00177485411(int p0, float p1)
        {
            Invoker.Call<Void>(0xD7D0B00177485411, p0, p1);
        }

        public static void _0xB3C641F3630BF6DA(float p0)
        {
            Invoker.Call<Void>(0xB3C641F3630BF6DA, p0);
        }

        public static int _0xE59343E9E96529E7()
        {
            return Invoker.Call<int>(0xE59343E9E96529E7);
        }

        public static void _0xE63D7C6EECECB66B(bool p0)
        {
            Invoker.Call<Void>(0xE63D7C6EECECB66B, p0);
        }

        public static void _0xE3E2C1B4C59DBC77(int unk)
        {
            Invoker.Call<Void>(0xE3E2C1B4C59DBC77, unk);
        }

        public static bool _TRANSITION_TO_BLURRED(float transitionTime)
        {
            return Invoker.Call<bool>(0xA328A24AAA6B7FDC, transitionTime);
        }

        public static bool _TRANSITION_FROM_BLURRED(float transitionTime)
        {
            return Invoker.Call<bool>(0xEFACC8AEF94430D5, transitionTime);
        }

        public static void _0xDE81239437E8C5A8()
        {
            Invoker.Call<Void>(0xDE81239437E8C5A8);
        }

        public static float IS_PARTICLE_FX_DELAYED_BLINK()
        {
            return Invoker.Call<float>(0x5CCABFFCA31DDE33);
        }

        public static int _0x7B226C785A52A0A9()
        {
            return Invoker.Call<int>(0x7B226C785A52A0A9);
        }

        public static void _SET_FROZEN_RENDERING_DISABLED(bool enabled)
        {
            Invoker.Call<Void>(0xDFC252D8A3E15AB7, enabled);
        }

        public static bool _0xEB3DAC2C86001E5E()
        {
            return Invoker.Call<bool>(0xEB3DAC2C86001E5E);
        }

        public static void _0xE1C8709406F2C41C()
        {
            Invoker.Call<Void>(0xE1C8709406F2C41C);
        }

        public static void _0x851CD923176EBA7C()
        {
            Invoker.Call<Void>(0x851CD923176EBA7C);
        }

        public static void _0xBA3D65906822BED5(bool p0, bool p1, float p2, float p3, float p4, float p5)
        {
            Invoker.Call<Void>(0xBA3D65906822BED5, p0, p1, p2, p3, p4, p5);
        }

        public static bool _0x7AC24EAB6D74118D(bool p0)
        {
            return Invoker.Call<bool>(0x7AC24EAB6D74118D, p0);
        }

        public static int _0xBCEDB009461DA156()
        {
            return Invoker.Call<int>(0xBCEDB009461DA156);
        }

        public static bool _0x27FEB5254759CDE3(string textureDict, bool p1)
        {
            return Invoker.Call<bool>(0x27FEB5254759CDE3, textureDict, p1);
        }

        public static int START_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<int>(0x25129531F77B9ED3, effectName, xPos, yPos, zPos, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis);
        }

        public static bool _START_PARTICLE_FX_NON_LOOPED_AT_COORD_2(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<bool>(0xF56B8137DF10135D, effectName, xPos, yPos, zPos, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis);
        }

        public static bool START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)
        {
            return Invoker.Call<bool>(0x0E7E72961BA18619, effectName, ped, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, boneIndex, scale, axisX, axisY, axisZ);
        }

        public static bool _START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE_2(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ)
        {
            return Invoker.Call<bool>(0xA41B6A43642AC2CF, effectName, ped, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, boneIndex, scale, axisX, axisY, axisZ);
        }

        public static bool START_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)
        {
            return Invoker.Call<bool>(0x0D53A3B8DA0809D2, effectName, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, scale, axisX, axisY, axisZ);
        }

        public static bool _START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_2(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ)
        {
            return Invoker.Call<bool>(0xC95EB1DB6E92113D, effectName, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, scale, axisX, axisY, axisZ);
        }

        public static void SET_PARTICLE_FX_NON_LOOPED_COLOUR(float r, float g, float b)
        {
            Invoker.Call<Void>(0x26143A59EF48B262, r, g, b);
        }

        public static void SET_PARTICLE_FX_NON_LOOPED_ALPHA(float alpha)
        {
            Invoker.Call<Void>(0x77168D722C58B2FC, alpha);
        }

        public static void _0x8CDE909A0370BB3A(bool p0)
        {
            Invoker.Call<Void>(0x8CDE909A0370BB3A, p0);
        }

        public static int START_PARTICLE_FX_LOOPED_AT_COORD(string effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11)
        {
            return Invoker.Call<int>(0xE184F4F0DC5910E7, effectName, x, y, z, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis, p11);
        }

        public static int START_PARTICLE_FX_LOOPED_ON_PED_BONE(string effectName, int ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<int>(0xF28DA9F38CD1787C, effectName, ped, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis);
        }

        public static int START_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<int>(0x1AE42C1660FD6517, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis);
        }

        public static int _START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<int>(0xC6EB449E33977F0B, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis);
        }

        public static int _START_PARTICLE_FX_LOOPED_ON_ENTITY_2(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<int>(0x6F60E89A7B64EE1D, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis);
        }

        public static int _START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE_2(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis)
        {
            return Invoker.Call<int>(0xDDE23F30CC5A0F03, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis);
        }

        public static void STOP_PARTICLE_FX_LOOPED(int ptfxHandle, bool p1)
        {
            Invoker.Call<Void>(0x8F75998877616996, ptfxHandle, p1);
        }

        public static void REMOVE_PARTICLE_FX(int ptfxHandle, bool p1)
        {
            Invoker.Call<Void>(0xC401503DFE8D53CF, ptfxHandle, p1);
        }

        public static void REMOVE_PARTICLE_FX_FROM_ENTITY(int entity)
        {
            Invoker.Call<Void>(0xB8FEAEEBCC127425, entity);
        }

        public static void REMOVE_PARTICLE_FX_IN_RANGE(float X, float Y, float Z, float radius)
        {
            Invoker.Call<Void>(0xDD19FA1C6D657305, X, Y, Z, radius);
        }

        public static bool DOES_PARTICLE_FX_LOOPED_EXIST(int ptfxHandle)
        {
            return Invoker.Call<bool>(0x74AFEF0D2E1E409B, ptfxHandle);
        }

        public static void SET_PARTICLE_FX_LOOPED_OFFSETS(int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ)
        {
            Invoker.Call<Void>(0xF7DDEBEC43483C43, ptfxHandle, x, y, z, rotX, rotY, rotZ);
        }

        public static void SET_PARTICLE_FX_LOOPED_EVOLUTION(int ptfxHandle, string propertyName, float amount, bool Id)
        {
            Invoker.Call<Void>(0x5F0C4B5B1C393BE2, ptfxHandle, propertyName, amount, Id);
        }

        public static void SET_PARTICLE_FX_LOOPED_COLOUR(int ptfxHandle, float r, float g, float b, bool p4)
        {
            Invoker.Call<Void>(0x7F8F65877F88783B, ptfxHandle, r, g, b, p4);
        }

        public static void SET_PARTICLE_FX_LOOPED_ALPHA(int ptfxHandle, float alpha)
        {
            Invoker.Call<Void>(0x726845132380142E, ptfxHandle, alpha);
        }

        public static void SET_PARTICLE_FX_LOOPED_SCALE(int ptfxHandle, float scale)
        {
            Invoker.Call<Void>(0xB44250AAA456492D, ptfxHandle, scale);
        }

        public static void _SET_PARTICLE_FX_LOOPED_RANGE(int ptfxHandle, float range)
        {
            Invoker.Call<Void>(0xDCB194B85EF7B541, ptfxHandle, range);
        }

        public static void SET_PARTICLE_FX_CAM_INSIDE_VEHICLE(bool p0)
        {
            Invoker.Call<Void>(0xEEC4047028426510, p0);
        }

        public static void SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE(int p0, bool p1)
        {
            Invoker.Call<Void>(0xACEE6F360FC1F6B6, p0, p1);
        }

        public static void SET_PARTICLE_FX_SHOOTOUT_BOAT(int p0)
        {
            Invoker.Call<Void>(0x96EF97DAEB89BEF5, p0);
        }

        public static void SET_PARTICLE_FX_BLOOD_SCALE(bool p0)
        {
            Invoker.Call<Void>(0x5F6DF3D92271E8A1, p0);
        }

        public static void ENABLE_CLOWN_BLOOD_VFX(bool toggle)
        {
            Invoker.Call<Void>(0xD821490579791273, toggle);
        }

        public static void ENABLE_ALIEN_BLOOD_VFX(bool Toggle)
        {
            Invoker.Call<Void>(0x9DCE1F0F78260875, Toggle);
        }

        public static void _0x27E32866E9A5C416(float p0)
        {
            Invoker.Call<Void>(0x27E32866E9A5C416, p0);
        }

        public static void _0xBB90E12CAC1DAB25(float p0)
        {
            Invoker.Call<Void>(0xBB90E12CAC1DAB25, p0);
        }

        public static void _0xCA4AE345A153D573(bool p0)
        {
            Invoker.Call<Void>(0xCA4AE345A153D573, p0);
        }

        public static void _0x54E22EA2C1956A8D(float p0)
        {
            Invoker.Call<Void>(0x54E22EA2C1956A8D, p0);
        }

        public static void _0x949F397A288B28B3(float p0)
        {
            Invoker.Call<Void>(0x949F397A288B28B3, p0);
        }

        public static void _0x9B079E5221D984D3(bool p0)
        {
            Invoker.Call<Void>(0x9B079E5221D984D3, p0);
        }

        public static void _USE_PARTICLE_FX_ASSET_NEXT_CALL(string name)
        {
            Invoker.Call<Void>(0x6C38AF3693A69A91, name);
        }

        public static void _SET_PARTICLE_FX_ASSET_OLD_TO_NEW(string oldAsset, string newAsset)
        {
            Invoker.Call<Void>(0xEA1E2D93F6F75ED9, oldAsset, newAsset);
        }

        public static void _RESET_PARTICLE_FX_ASSET_OLD_TO_NEW(string name)
        {
            Invoker.Call<Void>(0x89C8553DD3274AAE, name);
        }

        public static void _0xA46B73FAA3460AE1(bool p0)
        {
            Invoker.Call<Void>(0xA46B73FAA3460AE1, p0);
        }

        public static void _0xF78B803082D4386F(float p0)
        {
            Invoker.Call<Void>(0xF78B803082D4386F, p0);
        }

        public static void WASH_DECALS_IN_RANGE(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x9C30613D50A6ADEF, p0, p1, p2, p3, p4);
        }

        public static void WASH_DECALS_FROM_VEHICLE(int vehicle, float p1)
        {
            Invoker.Call<Void>(0x5B712761429DBC14, vehicle, p1);
        }

        public static void FADE_DECALS_IN_RANGE(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0xD77EDADB0420E6E0, p0, p1, p2, p3, p4);
        }

        public static void REMOVE_DECALS_IN_RANGE(float x, float y, float z, float range)
        {
            Invoker.Call<Void>(0x5D6B2D4830A67C62, x, y, z, range);
        }

        public static void REMOVE_DECALS_FROM_OBJECT(int obj)
        {
            Invoker.Call<Void>(0xCCF71CBDDF5B6CB9, obj);
        }

        public static void REMOVE_DECALS_FROM_OBJECT_FACING(int obj, float x, float y, float z)
        {
            Invoker.Call<Void>(0xA6F6F70FDC6D144C, obj, x, y, z);
        }

        public static void REMOVE_DECALS_FROM_VEHICLE(int vehicle)
        {
            Invoker.Call<Void>(0xE91F1B65F2B48D57, vehicle);
        }

        public static int ADD_DECAL(int decalType, float posX, float posY, float posZ, float p4, float p5, float p6, float p7, float p8, float p9, float width, float height, float rCoef, float gCoef, float bCoef, float opacity, float time_out, bool p17, bool p18, bool p19)
        {
            return Invoker.Call<int>(0xB302244A1839BDAD, decalType, posX, posY, posZ, p4, p5, p6, p7, p8, p9, width, height, rCoef, gCoef, bCoef, opacity, time_out, p17, p18, p19);
        }

        public static int ADD_PETROL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency)
        {
            return Invoker.Call<int>(0x4F5212C7AD880DF8, x, y, z, groundLvl, width, transparency);
        }

        public static void _0x99AC7F0D8B9C893D(float p0)
        {
            Invoker.Call<Void>(0x99AC7F0D8B9C893D, p0);
        }

        public static void _0x967278682CB6967A(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x967278682CB6967A, p0, p1, p2, p3);
        }

        public static void _0x0A123435A26C36CD()
        {
            Invoker.Call<Void>(0x0A123435A26C36CD);
        }

        public static void REMOVE_DECAL(int decal)
        {
            Invoker.Call<Void>(0xED3F346429CCD659, decal);
        }

        public static bool IS_DECAL_ALIVE(int decal)
        {
            return Invoker.Call<bool>(0xC694D74949CAFD0C, decal);
        }

        public static float GET_DECAL_WASH_LEVEL(int decal)
        {
            return Invoker.Call<float>(0x323F647679A09103, decal);
        }

        public static void _0xD9454B5752C857DC()
        {
            Invoker.Call<Void>(0xD9454B5752C857DC);
        }

        public static void _0x27CFB1B1E078CB2D()
        {
            Invoker.Call<Void>(0x27CFB1B1E078CB2D);
        }

        public static void _0x4B5CFC83122DF602()
        {
            Invoker.Call<Void>(0x4B5CFC83122DF602);
        }

        public static bool _0x2F09F7976C512404(float xCoord, float yCoord, float zCoord, float p3)
        {
            return Invoker.Call<bool>(0x2F09F7976C512404, xCoord, yCoord, zCoord, p3);
        }

        public static void _ADD_DECAL_TO_MARKER(int decalType, string textureDict, string textureName)
        {
            Invoker.Call<Void>(0x8A35C742130C6080, decalType, textureDict, textureName);
        }

        public static void _0xB7ED70C49521A61D(int decalType)
        {
            Invoker.Call<Void>(0xB7ED70C49521A61D, decalType);
        }

        public static void MOVE_VEHICLE_DECALS(int p0, int p1)
        {
            Invoker.Call<Void>(0x84C8D7C2D30D3280, p0, p1);
        }

        public static bool _ADD_CLAN_DECAL_TO_VEHICLE(int vehicle, int ped, int boneIndex, float x1, float x2, float x3, float y1, float y2, float y3, float z1, float z2, float z3, float scale, int p13, int alpha)
        {
            return Invoker.Call<bool>(0x428BDCB9DA58DA53, vehicle, ped, boneIndex, x1, x2, x3, y1, y2, y3, z1, z2, z3, scale, p13, alpha);
        }

        public static void _0xD2300034310557E4(int vehicle, int p1)
        {
            Invoker.Call<Void>(0xD2300034310557E4, vehicle, p1);
        }

        public static int _0xFE26117A5841B2FF(int vehicle, int p1)
        {
            return Invoker.Call<int>(0xFE26117A5841B2FF, vehicle, p1);
        }

        public static bool _DOES_VEHICLE_HAVE_DECAL(int vehicle, int p1)
        {
            return Invoker.Call<bool>(0x060D935D3981A275, vehicle, p1);
        }

        public static void _0x0E4299C549F0D1F1(bool p0)
        {
            Invoker.Call<Void>(0x0E4299C549F0D1F1, p0);
        }

        public static void _0x02369D5C8A51FDCF(bool p0)
        {
            Invoker.Call<Void>(0x02369D5C8A51FDCF, p0);
        }

        public static void _0x46D1A61A21F566FC(float p0)
        {
            Invoker.Call<Void>(0x46D1A61A21F566FC, p0);
        }

        public static void _0x2A2A52824DB96700(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x2A2A52824DB96700, p0_ptr);
        }

        public static void _0x1600FD8CF72EBC12(float p0)
        {
            Invoker.Call<Void>(0x1600FD8CF72EBC12, p0);
        }

        public static void _0xEFB55E7C25D3B3BE()
        {
            Invoker.Call<Void>(0xEFB55E7C25D3B3BE);
        }

        public static void _0xA44FF770DFBC5DAE()
        {
            Invoker.Call<Void>(0xA44FF770DFBC5DAE);
        }

        public static void DISABLE_VEHICLE_DISTANTLIGHTS(bool toggle)
        {
            Invoker.Call<Void>(0xC9F98AC1884E73A2, toggle);
        }

        public static void _0x03300B57FCAC6DDB(bool p0)
        {
            Invoker.Call<Void>(0x03300B57FCAC6DDB, p0);
        }

        public static void _0x98EDF76A7271E4F2()
        {
            Invoker.Call<Void>(0x98EDF76A7271E4F2);
        }

        public static void _SET_FORCE_PED_FOOTSTEPS_TRACKS(bool toggle)
        {
            Invoker.Call<Void>(0xAEEDAD1420C65CC0, toggle);
        }

        public static void _SET_FORCE_VEHICLE_TRAILS(bool toggle)
        {
            Invoker.Call<Void>(0x4CC7F0FEA5283FE0, toggle);
        }

        public static void _0xD7021272EB0A451E(string p0)
        {
            Invoker.Call<Void>(0xD7021272EB0A451E, p0);
        }

        public static void SET_TIMECYCLE_MODIFIER(string modifierName)
        {
            Invoker.Call<Void>(0x2C933ABF17A1DF41, modifierName);
        }

        public static void SET_TIMECYCLE_MODIFIER_STRENGTH(float strength)
        {
            Invoker.Call<Void>(0x82E7FFCD5B2326B3, strength);
        }

        public static void SET_TRANSITION_TIMECYCLE_MODIFIER(string modifierName, float transition)
        {
            Invoker.Call<Void>(0x3BCF567485E1971C, modifierName, transition);
        }

        public static void _0x1CBA05AE7BD7EE05(float p0)
        {
            Invoker.Call<Void>(0x1CBA05AE7BD7EE05, p0);
        }

        public static void CLEAR_TIMECYCLE_MODIFIER()
        {
            Invoker.Call<Void>(0x0F07E7745A236711);
        }

        public static int GET_TIMECYCLE_MODIFIER_INDEX()
        {
            return Invoker.Call<int>(0xFDF3D97C674AFB66);
        }

        public static int _0x459FD2C8D0AB78BC()
        {
            return Invoker.Call<int>(0x459FD2C8D0AB78BC);
        }

        public static void PUSH_TIMECYCLE_MODIFIER()
        {
            Invoker.Call<Void>(0x58F735290861E6B4);
        }

        public static void POP_TIMECYCLE_MODIFIER()
        {
            Invoker.Call<Void>(0x3C8938D7D872211E);
        }

        public static void _0xBBF327DED94E4DEB(string p0)
        {
            Invoker.Call<Void>(0xBBF327DED94E4DEB, p0);
        }

        public static void _0xBDEB86F4D5809204(float p0)
        {
            Invoker.Call<Void>(0xBDEB86F4D5809204, p0);
        }

        public static void _0xBF59707B3E5ED531(string p0)
        {
            Invoker.Call<Void>(0xBF59707B3E5ED531, p0);
        }

        public static void _0x1A8E2C8B9CF4549C(ulong p0_ptr, ulong p1_ptr)
        {
            Invoker.Call<Void>(0x1A8E2C8B9CF4549C, p0_ptr, p1_ptr);
        }

        public static void _0x15E33297C3E8DC60(int p0)
        {
            Invoker.Call<Void>(0x15E33297C3E8DC60, p0);
        }

        public static void _0x5096FD9CCB49056D(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x5096FD9CCB49056D, p0_ptr);
        }

        public static void _0x92CCC17A7A2285DA()
        {
            Invoker.Call<Void>(0x92CCC17A7A2285DA);
        }

        public static int _0xBB0527EC6341496D()
        {
            return Invoker.Call<int>(0xBB0527EC6341496D);
        }

        public static void _0x2C328AF17210F009(float p0)
        {
            Invoker.Call<Void>(0x2C328AF17210F009, p0);
        }

        public static void _0x2BF72AD5B41AA739()
        {
            Invoker.Call<Void>(0x2BF72AD5B41AA739);
        }

        public static int REQUEST_SCALEFORM_MOVIE(string scaleformName)
        {
            return Invoker.Call<int>(0x11FE353CF9733E6F, scaleformName);
        }

        public static int REQUEST_SCALEFORM_MOVIE_INSTANCE(string scaleformName)
        {
            return Invoker.Call<int>(0xC514489CFB8AF806, scaleformName);
        }

        public static int _REQUEST_SCALEFORM_MOVIE_INTERACTIVE(string scaleformName)
        {
            return Invoker.Call<int>(0xBD06C611BB9048C2, scaleformName);
        }

        public static bool HAS_SCALEFORM_MOVIE_LOADED(int scaleformHandle)
        {
            return Invoker.Call<bool>(0x85F01B8D5B90570E, scaleformHandle);
        }

        public static bool _HAS_NAMED_SCALEFORM_MOVIE_LOADED(string scaleformName)
        {
            return Invoker.Call<bool>(0x0C1C5D756FB5F337, scaleformName);
        }

        public static bool HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT(int scaleformHandle)
        {
            return Invoker.Call<bool>(0x8217150E1217EBFD, scaleformHandle);
        }

        public static void SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED(ulong scaleformHandle_ptr)
        {
            Invoker.Call<Void>(0x1D132D614DD86811, scaleformHandle_ptr);
        }

        public static void SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME(int scaleform, bool toggle)
        {
            Invoker.Call<Void>(0x6D8EB211944DCE08, scaleform, toggle);
        }

        public static void DRAW_SCALEFORM_MOVIE(int scaleformHandle, float x, float y, float width, float height, int red, int green, int blue, int alpha, int unk)
        {
            Invoker.Call<Void>(0x54972ADAF0294A93, scaleformHandle, x, y, width, height, red, green, blue, alpha, unk);
        }

        public static void DRAW_SCALEFORM_MOVIE_FULLSCREEN(int scaleform, int red, int green, int blue, int alpha, int unk)
        {
            Invoker.Call<Void>(0x0DF606929C105BE1, scaleform, red, green, blue, alpha, unk);
        }

        public static void DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED(int scaleform1, int scaleform2, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xCF537FDE4FBD4CE5, scaleform1, scaleform2, red, green, blue, alpha);
        }

        public static void DRAW_SCALEFORM_MOVIE_3D(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float sharpness, float p9, float scaleX, float scaleY, float scaleZ, int p13)
        {
            Invoker.Call<Void>(0x87D51D72255D4E78, scaleform, posX, posY, posZ, rotX, rotY, rotZ, p7, sharpness, p9, scaleX, scaleY, scaleZ, p13);
        }

        public static void _DRAW_SCALEFORM_MOVIE_3D_NON_ADDITIVE(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, int p13)
        {
            Invoker.Call<Void>(0x1CE592FDC749D6F5, scaleform, posX, posY, posZ, rotX, rotY, rotZ, p7, p8, p9, scaleX, scaleY, scaleZ, p13);
        }

        public static void CALL_SCALEFORM_MOVIE_METHOD(int scaleform, string method)
        {
            Invoker.Call<Void>(0xFBD96D87AC96D533, scaleform, method);
        }

        public static void _CALL_SCALEFORM_MOVIE_FUNCTION_FLOAT_PARAMS(int scaleform, string functionName, float param1, float param2, float param3, float param4, float param5)
        {
            Invoker.Call<Void>(0xD0837058AE2E4BEE, scaleform, functionName, param1, param2, param3, param4, param5);
        }

        public static void _CALL_SCALEFORM_MOVIE_FUNCTION_STRING_PARAMS(int scaleform, string functionName, string param1, string param2, string param3, string param4, string param5)
        {
            Invoker.Call<Void>(0x51BC1ED3CC44E8F7, scaleform, functionName, param1, param2, param3, param4, param5);
        }

        public static void _CALL_SCALEFORM_MOVIE_FUNCTION_MIXED_PARAMS(int scaleform, string functionName, float floatParam1, float floatParam2, float floatParam3, float floatParam4, float floatParam5, string _stringParam1, string _stringParam2, string _stringParam3, string _stringParam4, string _stringParam5)
        {
            Invoker.Call<Void>(0xEF662D8D57E290B1, scaleform, functionName, floatParam1, floatParam2, floatParam3, floatParam4, floatParam5, _stringParam1, _stringParam2, _stringParam3, _stringParam4, _stringParam5);
        }

        public static bool _BEGIN_SCALEFORM_MOVIE_METHOD_HUD_COMPONENT(int hudComponent, string functionName)
        {
            return Invoker.Call<bool>(0x98C494FD5BDFBFD5, hudComponent, functionName);
        }

        public static bool BEGIN_SCALEFORM_MOVIE_METHOD(int scaleform, string functionName)
        {
            return Invoker.Call<bool>(0xF6E48914C7A8694E, scaleform, functionName);
        }

        public static bool _BEGIN_SCALEFORM_MOVIE_METHOD_N(string functionName)
        {
            return Invoker.Call<bool>(0xAB58C27C2E6123C6, functionName);
        }

        public static bool _BEGIN_SCALEFORM_MOVIE_METHOD_V(string functionName)
        {
            return Invoker.Call<bool>(0xB9449845F73F5E9C, functionName);
        }

        public static void END_SCALEFORM_MOVIE_METHOD()
        {
            Invoker.Call<Void>(0xC6796A8FFA375E53);
        }

        public static int _END_SCALEFORM_MOVIE_METHOD_RETURN()
        {
            return Invoker.Call<int>(0xC50AA39A577AF886);
        }

        public static bool _GET_SCALEFORM_MOVIE_FUNCTION_RETURN_BOOL(int method_return)
        {
            return Invoker.Call<bool>(0x768FF8961BA904D6, method_return);
        }

        public static int _GET_SCALEFORM_MOVIE_FUNCTION_RETURN_INT(int method_return)
        {
            return Invoker.Call<int>(0x2DE7EFA66B906036, method_return);
        }

        public static string SITTING_TV(int method_return)
        {
            return Invoker.Call<string>(0xE1E258829A885245, method_return);
        }

        public static void _ADD_SCALEFORM_MOVIE_METHOD_PARAMETER_INT(int value)
        {
            Invoker.Call<Void>(0xC3D0841A0CC546A6, value);
        }

        public static void _ADD_SCALEFORM_MOVIE_METHOD_PARAMETER_FLOAT(float value)
        {
            Invoker.Call<Void>(0xD69736AAE04DB51A, value);
        }

        public static void _ADD_SCALEFORM_MOVIE_METHOD_PARAMETER_BOOL(bool value)
        {
            Invoker.Call<Void>(0xC58424BA936EB458, value);
        }

        public static void BEGIN_TEXT_COMMAND_SCALEFORM_STRING(string componentType)
        {
            Invoker.Call<Void>(0x80338406F3475E55, componentType);
        }

        public static void END_TEXT_COMMAND_SCALEFORM_STRING()
        {
            Invoker.Call<Void>(0x362E2D3FE93A9959);
        }

        public static void _END_TEXT_COMMAND_SCALEFORM_STRING_2()
        {
            Invoker.Call<Void>(0xAE4E8157D9ECF087);
        }

        public static void _ADD_SCALEFORM_MOVIE_METHOD_PARAMETER_STRING(string value)
        {
            Invoker.Call<Void>(0xBA7148484BD90365, value);
        }

        public static void _ADD_SCALEFORM_MOVIE_METHOD_PARAMETER_BUTTON_NAME(string button)
        {
            Invoker.Call<Void>(0xE83A3E3557A56640, button);
        }

        public static bool _0x5E657EF1099EDD65(int p0)
        {
            return Invoker.Call<bool>(0x5E657EF1099EDD65, p0);
        }

        public static void _0xEC52C631A1831C03(int p0)
        {
            Invoker.Call<Void>(0xEC52C631A1831C03, p0);
        }

        public static void _REQUEST_HUD_SCALEFORM(int hudComponent)
        {
            Invoker.Call<Void>(0x9304881D6F6537EA, hudComponent);
        }

        public static bool _HAS_HUD_SCALEFORM_LOADED(int hudComponent)
        {
            return Invoker.Call<bool>(0xDF6E5987D2B4D140, hudComponent);
        }

        public static void _0xF44A5456AC3F4F97(int p0)
        {
            Invoker.Call<Void>(0xF44A5456AC3F4F97, p0);
        }

        public static bool _0xD1C7CB175E012964(int scaleformHandle)
        {
            return Invoker.Call<bool>(0xD1C7CB175E012964, scaleformHandle);
        }

        public static void SET_TV_CHANNEL(int channel)
        {
            Invoker.Call<Void>(0xBAABBB23EB6E484E, channel);
        }

        public static int GET_TV_CHANNEL()
        {
            return Invoker.Call<int>(0xFC1E275A90D39995);
        }

        public static void SET_TV_VOLUME(float volume)
        {
            Invoker.Call<Void>(0x2982BF73F66E9DDC, volume);
        }

        public static float GET_TV_VOLUME()
        {
            return Invoker.Call<float>(0x2170813D3DD8661B);
        }

        public static void DRAW_TV_CHANNEL(float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha)
        {
            Invoker.Call<Void>(0xFDDC2B4ED3C69DF0, xPos, yPos, xScale, yScale, rotation, red, green, blue, alpha);
        }

        public static void _LOAD_TV_CHANNEL_SEQUENCE(int TV_Channel, string VideoSequence, bool Restart)
        {
            Invoker.Call<Void>(0xF7B38B8305F1FE8B, TV_Channel, VideoSequence, Restart);
        }

        public static void _0x2201C576FACAEBE8(int p0, string p1, int p2)
        {
            Invoker.Call<Void>(0x2201C576FACAEBE8, p0, p1, p2);
        }

        public static void _0xBEB3D46BB7F043C0(int p0)
        {
            Invoker.Call<Void>(0xBEB3D46BB7F043C0, p0);
        }

        public static bool _LOAD_TV_CHANNEL(int tvChannel)
        {
            return Invoker.Call<bool>(0x0AD973CA1E077B60, tvChannel);
        }

        public static void _0x74C180030FDE4B69(bool p0)
        {
            Invoker.Call<Void>(0x74C180030FDE4B69, p0);
        }

        public static void _0xD1C55B110E4DF534(int p0)
        {
            Invoker.Call<Void>(0xD1C55B110E4DF534, p0);
        }

        public static void ENABLE_MOVIE_SUBTITLES(bool toggle)
        {
            Invoker.Call<Void>(0x873FA65C778AD970, toggle);
        }

        public static bool _0xD3A10FC7FD8D98CD()
        {
            return Invoker.Call<bool>(0xD3A10FC7FD8D98CD);
        }

        public static bool _0xF1CEA8A4198D8E9A(string p0)
        {
            return Invoker.Call<bool>(0xF1CEA8A4198D8E9A, p0);
        }

        public static bool _DRAW_SHOWROOM(string p0, int ped, int p2, float posX, float posY, float posZ)
        {
            return Invoker.Call<bool>(0x98C4FE6EC34154CA, p0, ped, p2, posX, posY, posZ);
        }

        public static void _0x7A42B2E236E71415()
        {
            Invoker.Call<Void>(0x7A42B2E236E71415);
        }

        public static void _0x108BE26959A9D9BB(bool p0)
        {
            Invoker.Call<Void>(0x108BE26959A9D9BB, p0);
        }

        public static void _0xA356990E161C9E65(bool p0)
        {
            Invoker.Call<Void>(0xA356990E161C9E65, p0);
        }

        public static void _0x1C4FC5752BCD8E48(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12)
        {
            Invoker.Call<Void>(0x1C4FC5752BCD8E48, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }

        public static void _0x5CE62918F8D703C7(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11)
        {
            Invoker.Call<Void>(0x5CE62918F8D703C7, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        public static void _START_SCREEN_EFFECT(string effectName, int duration, bool looped)
        {
            Invoker.Call<Void>(0x2206BF9A37B7F724, effectName, duration, looped);
        }

        public static void _STOP_SCREEN_EFFECT(string effectName)
        {
            Invoker.Call<Void>(0x068E835A1D0DC0E3, effectName);
        }

        public static bool _GET_SCREEN_EFFECT_IS_ACTIVE(bool effectName)
        {
            return Invoker.Call<bool>(0x36AD3E690DA5ACEB, effectName);
        }

        public static void _STOP_ALL_SCREEN_EFFECTS()
        {
            Invoker.Call<Void>(0xB4EDDC19532BFB85);
        }

        public static void _0xD2209BE128B5418C(string graphicsName)
        {
            Invoker.Call<Void>(0xD2209BE128B5418C, graphicsName);
        }

    }

    public static class STATS
    {

        public static int STAT_CLEAR_SLOT_FOR_RELOAD(int statSlot)
        {
            return Invoker.Call<int>(0xEB0A72181D4AA4AD, statSlot);
        }

        public static bool STAT_LOAD(int p0)
        {
            return Invoker.Call<bool>(0xA651443F437B1CE6, p0);
        }

        public static bool STAT_SAVE(int p0, bool p1, int p2)
        {
            return Invoker.Call<bool>(0xE07BCA305B82D2FD, p0, p1, p2);
        }

        public static void _0x5688585E6D563CD8(int p0)
        {
            Invoker.Call<Void>(0x5688585E6D563CD8, p0);
        }

        public static bool STAT_LOAD_PENDING(int p0)
        {
            return Invoker.Call<bool>(0xA1750FFAFA181661, p0);
        }

        public static int STAT_SAVE_PENDING()
        {
            return Invoker.Call<int>(0x7D3A583856F2C5AC);
        }

        public static int STAT_SAVE_PENDING_OR_REQUESTED()
        {
            return Invoker.Call<int>(0xBBB6AD006F1BBEA3);
        }

        public static int STAT_DELETE_SLOT(int p0)
        {
            return Invoker.Call<int>(0x49A49BED12794D70, p0);
        }

        public static bool STAT_SLOT_IS_LOADED(int p0)
        {
            return Invoker.Call<bool>(0x0D0A9F0E7BD91E3C, p0);
        }

        public static bool _0x7F2C4CDF2E82DF4C(int p0)
        {
            return Invoker.Call<bool>(0x7F2C4CDF2E82DF4C, p0);
        }

        public static int _0xE496A53BA5F50A56(int p0)
        {
            return Invoker.Call<int>(0xE496A53BA5F50A56, p0);
        }

        public static void _0xF434A10BA01C37D0(bool p0)
        {
            Invoker.Call<Void>(0xF434A10BA01C37D0, p0);
        }

        public static bool _0x7E6946F68A38B74F(int p0)
        {
            return Invoker.Call<bool>(0x7E6946F68A38B74F, p0);
        }

        public static void _0xA8733668D1047B51(int p0)
        {
            Invoker.Call<Void>(0xA8733668D1047B51, p0);
        }

        public static bool _0xECB41AC6AB754401()
        {
            return Invoker.Call<bool>(0xECB41AC6AB754401);
        }

        public static void _0x9B4BD21D69B1E609()
        {
            Invoker.Call<Void>(0x9B4BD21D69B1E609);
        }

        public static int _0xC0E0D686DDFC6EAE()
        {
            return Invoker.Call<int>(0xC0E0D686DDFC6EAE);
        }

        public static bool STAT_SET_INT(int statName, int value, bool save)
        {
            return Invoker.Call<bool>(0xB3271D7AB655B441, statName, value, save);
        }

        public static bool STAT_SET_FLOAT(int statName, float value, bool save)
        {
            return Invoker.Call<bool>(0x4851997F37FE9B3C, statName, value, save);
        }

        public static bool STAT_SET_BOOL(int statName, bool value, bool save)
        {
            return Invoker.Call<bool>(0x4B33C4243DE0C432, statName, value, save);
        }

        public static bool STAT_SET_GXT_LABEL(int statName, string value, bool save)
        {
            return Invoker.Call<bool>(0x17695002FD8B2AE0, statName, value, save);
        }

        public static bool STAT_SET_DATE(int statName, ulong value_ptr, int numFields, bool save)
        {
            return Invoker.Call<bool>(0x2C29BFB64F4FCBE4, statName, value_ptr, numFields, save);
        }

        public static bool STAT_SET_STRING(int statName, string value, bool save)
        {
            return Invoker.Call<bool>(0xA87B2335D12531D7, statName, value, save);
        }

        public static bool STAT_SET_POS(int statName, float x, float y, float z, bool save)
        {
            return Invoker.Call<bool>(0xDB283FDE680FE72E, statName, x, y, z, save);
        }

        public static bool STAT_SET_MASKED_INT(int statName, int p1, int p2, int p3, bool save)
        {
            return Invoker.Call<bool>(0x7BBB1B54583ED410, statName, p1, p2, p3, save);
        }

        public static bool STAT_SET_USER_ID(int statName, string value, bool save)
        {
            return Invoker.Call<bool>(0x8CDDF1E452BABE11, statName, value, save);
        }

        public static bool STAT_SET_CURRENT_POSIX_TIME(int statName, bool p1)
        {
            return Invoker.Call<bool>(0xC2F84B7F9C4D0C61, statName, p1);
        }

        public static bool STAT_GET_INT(int statHash, ulong _outValue_ptr, int p2)
        {
            return Invoker.Call<bool>(0x767FBC2AC802EF3D, statHash, _outValue_ptr, p2);
        }

        public static bool STAT_GET_FLOAT(int statHash, ulong _outValue_ptr, int p2)
        {
            return Invoker.Call<bool>(0xD7AE6C9C9C6AC54C, statHash, _outValue_ptr, p2);
        }

        public static bool STAT_GET_BOOL(int statHash, ulong _outValue_ptr, int p2)
        {
            return Invoker.Call<bool>(0x11B5E6D2AE73F48E, statHash, _outValue_ptr, p2);
        }

        public static bool STAT_GET_DATE(int statHash, ulong p1_ptr, int p2, int p3)
        {
            return Invoker.Call<bool>(0x8B0FACEFC36C824B, statHash, p1_ptr, p2, p3);
        }

        public static string STAT_GET_STRING(int statHash, int p1)
        {
            return Invoker.Call<string>(0xE50384ACC2C3DB74, statHash, p1);
        }

        public static bool STAT_GET_POS(int p0, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr, int p4)
        {
            return Invoker.Call<bool>(0x350F82CCB186AA1B, p0, p1_ptr, p2_ptr, p3_ptr, p4);
        }

        public static bool STAT_GET_MASKED_INT(int p0, ulong p1_ptr, int p2, int p3, int p4)
        {
            return Invoker.Call<bool>(0x655185A06D9EEAAB, p0, p1_ptr, p2, p3, p4);
        }

        public static string STAT_GET_USER_ID(int p0)
        {
            return Invoker.Call<string>(0x2365C388E393BBE2, p0);
        }

        public static string STAT_GET_LICENSE_PLATE(int statName)
        {
            return Invoker.Call<string>(0x5473D4195058B2E4, statName);
        }

        public static bool STAT_SET_LICENSE_PLATE(int statName, string str)
        {
            return Invoker.Call<bool>(0x69FF13266D7296DA, statName, str);
        }

        public static void STAT_INCREMENT(int statName, float value)
        {
            Invoker.Call<Void>(0x9B5A68C6489E9909, statName, value);
        }

        public static bool _0x5A556B229A169402()
        {
            return Invoker.Call<bool>(0x5A556B229A169402);
        }

        public static bool _0xB1D2BB1E1631F5B1()
        {
            return Invoker.Call<bool>(0xB1D2BB1E1631F5B1);
        }

        public static bool _0xBED9F5693F34ED17(int statName, int p1, ulong _outValue_ptr)
        {
            return Invoker.Call<bool>(0xBED9F5693F34ED17, statName, p1, _outValue_ptr);
        }

        public static void _0x26D7399B9587FE89(int p0)
        {
            Invoker.Call<Void>(0x26D7399B9587FE89, p0);
        }

        public static void _0xA78B8FA58200DA56(int p0)
        {
            Invoker.Call<Void>(0xA78B8FA58200DA56, p0);
        }

        public static int STAT_GET_NUMBER_OF_DAYS(int statName)
        {
            return Invoker.Call<int>(0xE0E854F5280FB769, statName);
        }

        public static int STAT_GET_NUMBER_OF_HOURS(int statName)
        {
            return Invoker.Call<int>(0xF2D4B2FE415AAFC3, statName);
        }

        public static int STAT_GET_NUMBER_OF_MINUTES(int statName)
        {
            return Invoker.Call<int>(0x7583B4BE4C5A41B5, statName);
        }

        public static int STAT_GET_NUMBER_OF_SECONDS(int statName)
        {
            return Invoker.Call<int>(0x2CE056FF3723F00B, statName);
        }

        public static void _STAT_SET_PROFILE_SETTING(int profileSetting, int value)
        {
            Invoker.Call<Void>(0x68F01422BE1D838F, profileSetting, value);
        }

        public static int _0xF4D8E7AC2A27758C(int p0)
        {
            return Invoker.Call<int>(0xF4D8E7AC2A27758C, p0);
        }

        public static int _0x94F12ABF9C79E339(int p0)
        {
            return Invoker.Call<int>(0x94F12ABF9C79E339, p0);
        }

        public static int _GET_PSTAT_BOOL_HASH(int index, bool spStat, bool charStat, int character)
        {
            return Invoker.Call<int>(0x80C75307B1C42837, index, spStat, charStat, character);
        }

        public static int _GET_PSTAT_INT_HASH(int index, bool spStat, bool charStat, int character)
        {
            return Invoker.Call<int>(0x61E111E323419E07, index, spStat, charStat, character);
        }

        public static int _GET_TUPSTAT_BOOL_HASH(int index, bool spStat, bool charStat, int character)
        {
            return Invoker.Call<int>(0xC4BB08EE7907471E, index, spStat, charStat, character);
        }

        public static int _GET_TUPSTAT_INT_HASH(int index, bool spStat, bool charStat, int character)
        {
            return Invoker.Call<int>(0xD16C2AD6B8E32854, index, spStat, charStat, character);
        }

        public static int _GET_NGSTAT_BOOL_HASH(int index, bool spStat, bool charStat, int character, string section)
        {
            return Invoker.Call<int>(0xBA52FF538ED2BC71, index, spStat, charStat, character, section);
        }

        public static int _GET_NGSTAT_INT_HASH(int index, bool spStat, bool charStat, int character, string section)
        {
            return Invoker.Call<int>(0x2B4CDCA6F07FF3DA, index, spStat, charStat, character, section);
        }

        public static bool STAT_GET_BOOL_MASKED(int statName, int mask, int p2)
        {
            return Invoker.Call<bool>(0x10FE3F1B79F9B071, statName, mask, p2);
        }

        public static bool STAT_SET_BOOL_MASKED(int statName, bool value, int mask, bool save)
        {
            return Invoker.Call<bool>(0x5BC62EC1937B9E5B, statName, value, mask, save);
        }

        public static void _0x5009DFD741329729(string p0, int p1)
        {
            Invoker.Call<Void>(0x5009DFD741329729, p0, p1);
        }

        public static void PLAYSTATS_NPC_INVITE(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x93054C88E6AA7C44, p0_ptr);
        }

        public static void PLAYSTATS_AWARD_XP(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x46F917F6B4128FE4, p0, p1, p2);
        }

        public static void PLAYSTATS_RANK_UP(int p0)
        {
            Invoker.Call<Void>(0xC7F2DE41D102BFB4, p0);
        }

        public static void _0x098760C7461724CD()
        {
            Invoker.Call<Void>(0x098760C7461724CD);
        }

        public static void _0xA071E0ED98F91286(int p0, int p1)
        {
            Invoker.Call<Void>(0xA071E0ED98F91286, p0, p1);
        }

        public static void _0xC5BE134EC7BA96A0(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0xC5BE134EC7BA96A0, p0, p1, p2, p3, p4);
        }

        public static void PLAYSTATS_MISSION_STARTED(ulong p0_ptr, int p1, int p2, bool p3)
        {
            Invoker.Call<Void>(0xC19A2925C34D2231, p0_ptr, p1, p2, p3);
        }

        public static void PLAYSTATS_MISSION_OVER(ulong p0_ptr, int p1, int p2, bool p3, bool p4, bool p5)
        {
            Invoker.Call<Void>(0x7C4BB33A8CED7324, p0_ptr, p1, p2, p3, p4, p5);
        }

        public static void PLAYSTATS_MISSION_CHECKPOINT(ulong p0_ptr, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xC900596A63978C1D, p0_ptr, p1, p2, p3);
        }

        public static void _0x71862B1D855F32E1(ulong p0_ptr, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x71862B1D855F32E1, p0_ptr, p1, p2, p3);
        }

        public static void _0x121FB4DDDC2D5291(int p0, int p1, int p2, float p3)
        {
            Invoker.Call<Void>(0x121FB4DDDC2D5291, p0, p1, p2, p3);
        }

        public static void PLAYSTATS_RACE_CHECKPOINT(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x9C375C315099DDE4, p0, p1, p2, p3, p4);
        }

        public static bool _0x6DEE77AFF8C21BD1(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x6DEE77AFF8C21BD1, p0_ptr, p1_ptr);
        }

        public static void PLAYSTATS_MATCH_STARTED(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Invoker.Call<Void>(0xBC80E22DED931E3D, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void PLAYSTATS_SHOP_ITEM(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x176852ACAAC173D1, p0, p1, p2, p3, p4);
        }

        public static void _0x1CAE5D2E3F9A07F0(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0x1CAE5D2E3F9A07F0, p0, p1, p2, p3, p4, p5);
        }

        public static void _PLAYSTATS_AMBIENT_MISSION_CRATE_CREATED(float p0, float p1, float p2)
        {
            Invoker.Call<Void>(0xAFC7E5E075A96F46, p0, p1, p2);
        }

        public static void _0xCB00196B31C39EB1(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xCB00196B31C39EB1, p0, p1, p2, p3);
        }

        public static void _0x2B69F5074C894811(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x2B69F5074C894811, p0, p1, p2, p3);
        }

        public static void _0x7EEC2A316C250073(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x7EEC2A316C250073, p0, p1, p2);
        }

        public static void _0xADDD1C754E2E2914(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9)
        {
            Invoker.Call<Void>(0xADDD1C754E2E2914, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        public static void _0x79AB33F0FBFAC40C(int p0)
        {
            Invoker.Call<Void>(0x79AB33F0FBFAC40C, p0);
        }

        public static void PLAYSTATS_WEBSITE_VISITED(int scaleformHash, int p1)
        {
            Invoker.Call<Void>(0xDDF24D535060F811, scaleformHash, p1);
        }

        public static void PLAYSTATS_FRIEND_ACTIVITY(int p0, int p1)
        {
            Invoker.Call<Void>(0x0F71DE29AB2258F1, p0, p1);
        }

        public static void PLAYSTATS_ODDJOB_DONE(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x69DEA3E9DB727B4C, p0, p1, p2);
        }

        public static void PLAYSTATS_PROP_CHANGE(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0xBA739D6D5A05D6E7, p0, p1, p2, p3);
        }

        public static void PLAYSTATS_CLOTH_CHANGE(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x34B973047A2268B9, p0, p1, p2, p3, p4);
        }

        public static void _0xE95C8A1875A02CA4(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0xE95C8A1875A02CA4, p0, p1, p2);
        }

        public static void PLAYSTATS_CHEAT_APPLIED(string cheat)
        {
            Invoker.Call<Void>(0x6058665D72302D3F, cheat);
        }

        public static void _0xF8C54A461C3E11DC(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0xF8C54A461C3E11DC, p0_ptr, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _0xF5BB8DAC426A52C0(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0xF5BB8DAC426A52C0, p0_ptr, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _0xA736CF7FB7C5BFF4(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0xA736CF7FB7C5BFF4, p0_ptr, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _0x14E0B2D1AD1044E0(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr, ulong p3_ptr)
        {
            Invoker.Call<Void>(0x14E0B2D1AD1044E0, p0_ptr, p1_ptr, p2_ptr, p3_ptr);
        }

        public static void _0x90D0622866E80445(int p0, string p1)
        {
            Invoker.Call<Void>(0x90D0622866E80445, p0, p1);
        }

        public static void _0x5DA3A8DE8CB6226F(int time)
        {
            Invoker.Call<Void>(0x5DA3A8DE8CB6226F, time);
        }

        public static void _0xD1032E482629049E(bool p0)
        {
            Invoker.Call<Void>(0xD1032E482629049E, p0);
        }

        public static void _0xF4FF020A08BC8863(int p0, int p1)
        {
            Invoker.Call<Void>(0xF4FF020A08BC8863, p0, p1);
        }

        public static void _0x46326E13DA4E0546(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x46326E13DA4E0546, p0_ptr);
        }

        public static int LEADERBOARDS_GET_NUMBER_OF_COLUMNS(int p0, int p1)
        {
            return Invoker.Call<int>(0x117B45156D7EFF2E, p0, p1);
        }

        public static int LEADERBOARDS_GET_COLUMN_ID(int p0, int p1, int p2)
        {
            return Invoker.Call<int>(0xC4B5467A1886EA7E, p0, p1, p2);
        }

        public static int LEADERBOARDS_GET_COLUMN_TYPE(int p0, int p1, int p2)
        {
            return Invoker.Call<int>(0xBF4FEF46DB7894D3, p0, p1, p2);
        }

        public static int LEADERBOARDS_READ_CLEAR_ALL()
        {
            return Invoker.Call<int>(0xA34CB6E6F0DF4A0B);
        }

        public static int LEADERBOARDS_READ_CLEAR(int p0, int p1, int p2)
        {
            return Invoker.Call<int>(0x7CCE5C737A665701, p0, p1, p2);
        }

        public static bool LEADERBOARDS_READ_PENDING(int p0, int p1, int p2)
        {
            return Invoker.Call<bool>(0xAC392C8483342AC2, p0, p1, p2);
        }

        public static int _0xA31FD15197B192BD()
        {
            return Invoker.Call<int>(0xA31FD15197B192BD);
        }

        public static bool LEADERBOARDS_READ_SUCCESSFUL(int p0, int p1, int p2)
        {
            return Invoker.Call<bool>(0x2FB19228983E832C, p0, p1, p2);
        }

        public static bool LEADERBOARDS2_READ_FRIENDS_BY_ROW(ulong p0_ptr, ulong p1_ptr, int p2, bool p3, int p4, int p5)
        {
            return Invoker.Call<bool>(0x918B101666F9CB83, p0_ptr, p1_ptr, p2, p3, p4, p5);
        }

        public static bool LEADERBOARDS2_READ_BY_HANDLE(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xC30713A383BFBF0E, p0_ptr, p1_ptr);
        }

        public static bool LEADERBOARDS2_READ_BY_ROW(ulong p0_ptr, ulong p1_ptr, int p2, ulong p3_ptr, int p4, ulong p5_ptr, int p6)
        {
            return Invoker.Call<bool>(0xA9CDB1E3F0A49883, p0_ptr, p1_ptr, p2, p3_ptr, p4, p5_ptr, p6);
        }

        public static bool LEADERBOARDS2_READ_BY_RANK(ulong p0_ptr, int p1, int p2)
        {
            return Invoker.Call<bool>(0xBA2C7DB0C129449A, p0_ptr, p1, p2);
        }

        public static bool LEADERBOARDS2_READ_BY_RADIUS(ulong p0_ptr, int p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x5CE587FB5A42C8C4, p0_ptr, p1, p2_ptr);
        }

        public static bool LEADERBOARDS2_READ_BY_SCORE_INT(ulong p0_ptr, int p1, int p2)
        {
            return Invoker.Call<bool>(0x7EEC7E4F6984A16A, p0_ptr, p1, p2);
        }

        public static bool LEADERBOARDS2_READ_BY_SCORE_FLOAT(ulong p0_ptr, float p1, int p2)
        {
            return Invoker.Call<bool>(0xE662C8B759D08F3C, p0_ptr, p1, p2);
        }

        public static bool _0xC38DC1E90D22547C(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xC38DC1E90D22547C, p0_ptr, p1_ptr, p2_ptr);
        }

        public static bool _0xF1AE5DCDBFCA2721(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xF1AE5DCDBFCA2721, p0_ptr, p1_ptr, p2_ptr);
        }

        public static bool _0xA0F93D5465B3094D(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xA0F93D5465B3094D, p0_ptr);
        }

        public static void _0x71B008056E5692D6()
        {
            Invoker.Call<Void>(0x71B008056E5692D6);
        }

        public static bool _0x34770B9CE0E03B91(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x34770B9CE0E03B91, p0, p1_ptr);
        }

        public static int _0x88578F6EC36B4A3A(int p0, int p1)
        {
            return Invoker.Call<int>(0x88578F6EC36B4A3A, p0, p1);
        }

        public static float _0x38491439B6BA7F7D(int p0, int p1)
        {
            return Invoker.Call<float>(0x38491439B6BA7F7D, p0, p1);
        }

        public static bool LEADERBOARDS2_WRITE_DATA(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xAE2206545888AE49, p0_ptr);
        }

        public static void _0x0BCA1D2C47B0D269(int p0, int p1, float p2)
        {
            Invoker.Call<Void>(0x0BCA1D2C47B0D269, p0, p1, p2);
        }

        public static void _0x2E65248609523599(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x2E65248609523599, p0, p1, p2);
        }

        public static bool LEADERBOARDS_CACHE_DATA_ROW(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xB9BB18E2C40142ED, p0_ptr);
        }

        public static void LEADERBOARDS_CLEAR_CACHE_DATA()
        {
            Invoker.Call<Void>(0xD4B02A6B476E1FDC);
        }

        public static void _0x8EC74CEB042E7CFF(int p0)
        {
            Invoker.Call<Void>(0x8EC74CEB042E7CFF, p0);
        }

        public static bool LEADERBOARDS_GET_CACHE_EXISTS(int p0)
        {
            return Invoker.Call<bool>(0x9C51349BE6CDFE2C, p0);
        }

        public static int LEADERBOARDS_GET_CACHE_TIME(int p0)
        {
            return Invoker.Call<int>(0xF04C1C27DA35F6C8, p0);
        }

        public static int _0x58A651CD201D89AD(int p0)
        {
            return Invoker.Call<int>(0x58A651CD201D89AD, p0);
        }

        public static bool LEADERBOARDS_GET_CACHE_DATA_ROW(int p0, int p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x9120E8DBA3D69273, p0, p1, p2_ptr);
        }

        public static void _0x11FF1C80276097ED(string p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x11FF1C80276097ED, p0, p1, p2);
        }

        public static void _0x30A6614C1F7799B8(int p0, float p1, int p2)
        {
            Invoker.Call<Void>(0x30A6614C1F7799B8, p0, p1, p2);
        }

        public static void _0x6483C25849031C4F(int p0, int p1, int p2, ulong p3_ptr)
        {
            Invoker.Call<Void>(0x6483C25849031C4F, p0, p1, p2, p3_ptr);
        }

        public static bool _0x5EAD2BF6484852E4()
        {
            return Invoker.Call<bool>(0x5EAD2BF6484852E4);
        }

        public static void _0xC141B8917E0017EC()
        {
            Invoker.Call<Void>(0xC141B8917E0017EC);
        }

        public static void _0xB475F27C6A994D65()
        {
            Invoker.Call<Void>(0xB475F27C6A994D65);
        }

        public static void _0xF1A1803D3476F215(int value)
        {
            Invoker.Call<Void>(0xF1A1803D3476F215, value);
        }

        public static void _0x38BAAA5DD4C9D19F(int value)
        {
            Invoker.Call<Void>(0x38BAAA5DD4C9D19F, value);
        }

        public static void _0x55384438FC55AD8E(int value)
        {
            Invoker.Call<Void>(0x55384438FC55AD8E, value);
        }

        public static void _0x723C1CE13FBFDB67(int p0, int p1)
        {
            Invoker.Call<Void>(0x723C1CE13FBFDB67, p0, p1);
        }

        public static void _0x0D01D20616FC73FB(int p0, int p1)
        {
            Invoker.Call<Void>(0x0D01D20616FC73FB, p0, p1);
        }

        public static void _LEADERBOARDS_DEATHS(int statName, float value)
        {
            Invoker.Call<Void>(0x428EAF89E24F6C36, statName, value);
        }

        public static void _0x047CBED6F6F8B63C()
        {
            Invoker.Call<Void>(0x047CBED6F6F8B63C);
        }

        public static bool _0xC980E62E33DF1D5C(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xC980E62E33DF1D5C, p0_ptr, p1_ptr);
        }

        public static void _0x6F361B8889A792A3()
        {
            Invoker.Call<Void>(0x6F361B8889A792A3);
        }

        public static void _0xC847B43F369AC0B5()
        {
            Invoker.Call<Void>(0xC847B43F369AC0B5);
        }

        public static bool _0xA5C80D8E768A9E66(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xA5C80D8E768A9E66, p0_ptr);
        }

        public static int _0x9A62EC95AE10E011()
        {
            return Invoker.Call<int>(0x9A62EC95AE10E011);
        }

        public static int _0x4C89FE2BDEB3F169()
        {
            return Invoker.Call<int>(0x4C89FE2BDEB3F169);
        }

        public static int _0xC6E0E2616A7576BB()
        {
            return Invoker.Call<int>(0xC6E0E2616A7576BB);
        }

        public static int _0x5BD5F255321C4AAF(int p0)
        {
            return Invoker.Call<int>(0x5BD5F255321C4AAF, p0);
        }

        public static int _0xDEAAF77EB3687E97(int p0, ulong p1_ptr)
        {
            return Invoker.Call<int>(0xDEAAF77EB3687E97, p0, p1_ptr);
        }

        public static int _0xC70DDCE56D0D3A99()
        {
            return Invoker.Call<int>(0xC70DDCE56D0D3A99);
        }

        public static int _0x886913BBEACA68C1(ulong p0_ptr)
        {
            return Invoker.Call<int>(0x886913BBEACA68C1, p0_ptr);
        }

        public static int _0x4FEF53183C3C6414()
        {
            return Invoker.Call<int>(0x4FEF53183C3C6414);
        }

        public static int _0x567384DFA67029E6()
        {
            return Invoker.Call<int>(0x567384DFA67029E6);
        }

        public static bool _0x3270F67EED31FBC1(int p0, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x3270F67EED31FBC1, p0, p1_ptr, p2_ptr);
        }

        public static int _0xCE5AA445ABA8DEE0(ulong p0_ptr)
        {
            return Invoker.Call<int>(0xCE5AA445ABA8DEE0, p0_ptr);
        }

        public static void _0x98E2BC1CA26287C3()
        {
            Invoker.Call<Void>(0x98E2BC1CA26287C3);
        }

        public static void _0x629526ABA383BCAA()
        {
            Invoker.Call<Void>(0x629526ABA383BCAA);
        }

        public static int _0xB3DA2606774A8E2D()
        {
            return Invoker.Call<int>(0xB3DA2606774A8E2D);
        }

        public static void _0xDAC073C7901F9E15(int p0)
        {
            Invoker.Call<Void>(0xDAC073C7901F9E15, p0);
        }

        public static void _0xF6792800AC95350D(int p0)
        {
            Invoker.Call<Void>(0xF6792800AC95350D, p0);
        }

    }

    public static class BRAIN
    {

        public static void ADD_SCRIPT_TO_RANDOM_PED(string name, int model, float p2, float p3)
        {
            Invoker.Call<Void>(0x4EE5367468A65CCC, name, model, p2, p3);
        }

        public static void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, int _objectName, int p2, float p3, int p4, int p5)
        {
            Invoker.Call<Void>(0x0BE84C318BA6EC22, scriptName, _objectName, p2, p3, p4, p5);
        }

        public static bool IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(int _object)
        {
            return Invoker.Call<bool>(0xCCBA154209823057, _object);
        }

        public static void REGISTER_WORLD_POINT_SCRIPT_BRAIN(ulong p0_ptr, float p1, int p2)
        {
            Invoker.Call<Void>(0x3CDC7136613284BD, p0_ptr, p1, p2);
        }

        public static bool IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE()
        {
            return Invoker.Call<bool>(0xC5042CC6F5E3D450);
        }

        public static void ENABLE_SCRIPT_BRAIN_SET(int brainSet)
        {
            Invoker.Call<Void>(0x67AA4D73F0CFA86B, brainSet);
        }

        public static void DISABLE_SCRIPT_BRAIN_SET(int brainSet)
        {
            Invoker.Call<Void>(0x14D8518E9760F08F, brainSet);
        }

        public static void _0x0B40ED49D7D6FF84()
        {
            Invoker.Call<Void>(0x0B40ED49D7D6FF84);
        }

        public static void _0x4D953DF78EBF8158()
        {
            Invoker.Call<Void>(0x4D953DF78EBF8158);
        }

        public static void _0x6D6840CEE8845831(string action)
        {
            Invoker.Call<Void>(0x6D6840CEE8845831, action);
        }

        public static void _0x6E91B04E08773030(string action)
        {
            Invoker.Call<Void>(0x6E91B04E08773030, action);
        }

    }

    public static class MOBILE
    {

        public static void CREATE_MOBILE_PHONE(int p3)
        {
            Invoker.Call<Void>(0xA4E8E696C532FBC7, p3);
        }

        public static void DESTROY_MOBILE_PHONE()
        {
            Invoker.Call<Void>(0x3BC861DF703E5097);
        }

        public static void SET_MOBILE_PHONE_SCALE(float scale)
        {
            Invoker.Call<Void>(0xCBDD322A73D6D932, scale);
        }

        public static void SET_MOBILE_PHONE_ROTATION(float rotX, float rotY, float rotZ, int p3)
        {
            Invoker.Call<Void>(0xBB779C0CA917E865, rotX, rotY, rotZ, p3);
        }

        public static void GET_MOBILE_PHONE_ROTATION(ulong rotation_ptr, int p1)
        {
            Invoker.Call<Void>(0x1CEFB61F193070AE, rotation_ptr, p1);
        }

        public static void SET_MOBILE_PHONE_POSITION(float posX, float posY, float posZ)
        {
            Invoker.Call<Void>(0x693A5C6D6734085B, posX, posY, posZ);
        }

        public static void GET_MOBILE_PHONE_POSITION(ulong position_ptr)
        {
            Invoker.Call<Void>(0x584FDFDA48805B86, position_ptr);
        }

        public static void SCRIPT_IS_MOVING_MOBILE_PHONE_OFFSCREEN(bool toggle)
        {
            Invoker.Call<Void>(0xF511F759238A5122, toggle);
        }

        public static bool CAN_PHONE_BE_SEEN_ON_SCREEN()
        {
            return Invoker.Call<bool>(0xC4E2813898C97A4B);
        }

        public static void _MOVE_FINGER(int direction)
        {
            Invoker.Call<Void>(0x95C9E72F3D7DEC9B, direction);
        }

        public static void _SET_PHONE_LEAN(bool Toggle)
        {
            Invoker.Call<Void>(0x44E44169EF70138E, Toggle);
        }

        public static void CELL_CAM_ACTIVATE(bool p0, bool p1)
        {
            Invoker.Call<Void>(0xFDE8F069C542D126, p0, p1);
        }

        public static void _DISABLE_PHONE_THIS_FRAME(bool toggle)
        {
            Invoker.Call<Void>(0x015C49A93E3E086E, toggle);
        }

        public static void _0xA2CCBE62CD4C91A4(ulong toggle_ptr)
        {
            Invoker.Call<Void>(0xA2CCBE62CD4C91A4, toggle_ptr);
        }

        public static void _0x1B0B4AEED5B9B41C(float p0)
        {
            Invoker.Call<Void>(0x1B0B4AEED5B9B41C, p0);
        }

        public static void _0x53F4892D18EC90A4(float p0)
        {
            Invoker.Call<Void>(0x53F4892D18EC90A4, p0);
        }

        public static void _0x3117D84EFA60F77B(float p0)
        {
            Invoker.Call<Void>(0x3117D84EFA60F77B, p0);
        }

        public static void _0x15E69E2802C24B8D(float p0)
        {
            Invoker.Call<Void>(0x15E69E2802C24B8D, p0);
        }

        public static void _0xAC2890471901861C(float p0)
        {
            Invoker.Call<Void>(0xAC2890471901861C, p0);
        }

        public static void _0xD6ADE981781FCA09(float p0)
        {
            Invoker.Call<Void>(0xD6ADE981781FCA09, p0);
        }

        public static void _0xF1E22DC13F5EEBAD(float p0)
        {
            Invoker.Call<Void>(0xF1E22DC13F5EEBAD, p0);
        }

        public static void _0x466DA42C89865553(float p0)
        {
            Invoker.Call<Void>(0x466DA42C89865553, p0);
        }

        public static bool CELL_CAM_IS_CHAR_VISIBLE_NO_FACE_CHECK(int entity)
        {
            return Invoker.Call<bool>(0x439E9BC95B7E7FBE, entity);
        }

        public static void GET_MOBILE_PHONE_RENDER_ID(ulong renderId_ptr)
        {
            Invoker.Call<Void>(0xB4A53E05F68B6FA1, renderId_ptr);
        }

        public static bool _NETWORK_SHOP_DOES_ITEM_EXIST(string name)
        {
            return Invoker.Call<bool>(0xBD4D7EAF8A30F637, name);
        }

        public static bool _NETWORK_SHOP_DOES_ITEM_EXIST_HASH(int hash)
        {
            return Invoker.Call<bool>(0x247F0F73A182EA0B, hash);
        }

    }

    public static class APP
    {

        public static int APP_DATA_VALID()
        {
            return Invoker.Call<int>(0x846AA8E7D55EE5B6);
        }

        public static ulong APP_GET_INT(int property)
        {
            return Invoker.Call<ulong>(0xD3A58A12C77D9D4B, property);
        }

        public static float APP_GET_FLOAT(string property)
        {
            return Invoker.Call<float>(0x1514FB24C02C2322, property);
        }

        public static string APP_GET_STRING(string property)
        {
            return Invoker.Call<string>(0x749B023950D2311C, property);
        }

        public static void APP_SET_INT(string property, int value)
        {
            Invoker.Call<Void>(0x607E8E3D3E4F9611, property, value);
        }

        public static void APP_SET_FLOAT(string property, float value)
        {
            Invoker.Call<Void>(0x25D7687C68E0DAA4, property, value);
        }

        public static void APP_SET_STRING(string property, string value)
        {
            Invoker.Call<Void>(0x3FF2FCEC4B7721B4, property, value);
        }

        public static void APP_SET_APP(string appName)
        {
            Invoker.Call<Void>(0xCFD0406ADAF90D2B, appName);
        }

        public static void APP_SET_BLOCK(string b_lockName)
        {
            Invoker.Call<Void>(0x262AB456A3D21F93, b_lockName);
        }

        public static void APP_CLEAR_BLOCK()
        {
            Invoker.Call<Void>(0x5FE1DF3342DB7DBA);
        }

        public static void APP_CLOSE_APP()
        {
            Invoker.Call<Void>(0xE41C65E07A5F05FC);
        }

        public static void APP_CLOSE_BLOCK()
        {
            Invoker.Call<Void>(0xE8E3FCF72EAC0EF8);
        }

        public static bool APP_HAS_LINKED_SOCIAL_CLUB_ACCOUNT()
        {
            return Invoker.Call<bool>(0x71EEE69745088DA0);
        }

        public static bool APP_HAS_SYNCED_DATA(string appName)
        {
            return Invoker.Call<bool>(0xCA52279A7271517F, appName);
        }

        public static void APP_SAVE_DATA()
        {
            Invoker.Call<Void>(0x95C5D356CDA6E85F);
        }

        public static int APP_GET_DELETED_FILE_STATUS()
        {
            return Invoker.Call<int>(0xC9853A2BE3DED1A6);
        }

        public static bool APP_DELETE_APP_DATA(string appName)
        {
            return Invoker.Call<bool>(0x44151AEA95C8A003, appName);
        }

    }

    public static class TIME
    {

        public static void SET_CLOCK_TIME(int hour, int minute, int second)
        {
            Invoker.Call<Void>(0x47C3B5848C3E45D8, hour, minute, second);
        }

        public static void PAUSE_CLOCK(bool toggle)
        {
            Invoker.Call<Void>(0x4055E40BD2DBEC1D, toggle);
        }

        public static void ADVANCE_CLOCK_TIME_TO(int hour, int minute, int second)
        {
            Invoker.Call<Void>(0xC8CA9670B9D83B3B, hour, minute, second);
        }

        public static void ADD_TO_CLOCK_TIME(int hours, int minutes, int seconds)
        {
            Invoker.Call<Void>(0xD716F30D8C8980E2, hours, minutes, seconds);
        }

        public static int GET_CLOCK_HOURS()
        {
            return Invoker.Call<int>(0x25223CA6B4D20B7F);
        }

        public static int GET_CLOCK_MINUTES()
        {
            return Invoker.Call<int>(0x13D2B8ADD79640F2);
        }

        public static int GET_CLOCK_SECONDS()
        {
            return Invoker.Call<int>(0x494E97C2EF27C470);
        }

        public static void SET_CLOCK_DATE(int day, int month, int year)
        {
            Invoker.Call<Void>(0xB096419DF0D06CE7, day, month, year);
        }

        public static int GET_CLOCK_DAY_OF_WEEK()
        {
            return Invoker.Call<int>(0xD972E4BD7AEB235F);
        }

        public static int GET_CLOCK_DAY_OF_MONTH()
        {
            return Invoker.Call<int>(0x3D10BC92A4DB1D35);
        }

        public static int GET_CLOCK_MONTH()
        {
            return Invoker.Call<int>(0xBBC72712E80257A1);
        }

        public static int GET_CLOCK_YEAR()
        {
            return Invoker.Call<int>(0x961777E64BDAF717);
        }

        public static int GET_MILLISECONDS_PER_GAME_MINUTE()
        {
            return Invoker.Call<int>(0x2F8B4D1C595B11DB);
        }

        public static void GET_POSIX_TIME(ulong year_ptr, ulong month_ptr, ulong day_ptr, ulong hour_ptr, ulong minute_ptr, ulong second_ptr)
        {
            Invoker.Call<Void>(0xDA488F299A5B164E, year_ptr, month_ptr, day_ptr, hour_ptr, minute_ptr, second_ptr);
        }

        public static void _GET_UTC_TIME(ulong year_ptr, ulong month_ptr, ulong day_ptr, ulong hour_ptr, ulong minute_ptr, ulong second_ptr)
        {
            Invoker.Call<Void>(0x8117E09A19EEF4D3, year_ptr, month_ptr, day_ptr, hour_ptr, minute_ptr, second_ptr);
        }

        public static void GET_LOCAL_TIME(ulong year_ptr, ulong month_ptr, ulong day_ptr, ulong hour_ptr, ulong minute_ptr, ulong second_ptr)
        {
            Invoker.Call<Void>(0x50C7A99057A69748, year_ptr, month_ptr, day_ptr, hour_ptr, minute_ptr, second_ptr);
        }

    }

    public static class PATHFIND
    {

        public static void SET_ROADS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool unknown1, bool unknown2)
        {
            Invoker.Call<Void>(0xBF1A602B5BA52FEE, x1, y1, z1, x2, y2, z2, unknown1, unknown2);
        }

        public static void SET_ROADS_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float angle, bool unknown1, bool unknown2, bool unknown3)
        {
            Invoker.Call<Void>(0x1A5AA1208AF5DB59, x1, y1, z1, x2, y2, z2, angle, unknown1, unknown2, unknown3);
        }

        public static void SET_PED_PATHS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, bool unknown)
        {
            Invoker.Call<Void>(0x34F060F4BF92E018, x1, y1, z1, x2, y2, z2, unknown);
        }

        public static bool GET_SAFE_COORD_FOR_PED(float x, float y, float z, bool onGround, ulong _outPosition_ptr, int flags)
        {
            return Invoker.Call<bool>(0xB61C8E878A4199CA, x, y, z, onGround, _outPosition_ptr, flags);
        }

        public static bool GET_CLOSEST_VEHICLE_NODE(float x, float y, float z, ulong _outPosition_ptr, int nodeType, float p5, float p6)
        {
            return Invoker.Call<bool>(0x240A18690AE96513, x, y, z, _outPosition_ptr, nodeType, p5, p6);
        }

        public static bool GET_CLOSEST_MAJOR_VEHICLE_NODE(float x, float y, float z, ulong _outPosition_ptr, float unknown1, int unknown2)
        {
            return Invoker.Call<bool>(0x2EABE3B06F58C1BE, x, y, z, _outPosition_ptr, unknown1, unknown2);
        }

        public static bool GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, ulong _outPosition_ptr, ulong _outHeading_ptr, int nodeType, float p6, int p7)
        {
            return Invoker.Call<bool>(0xFF071FB798B803B0, x, y, z, _outPosition_ptr, _outHeading_ptr, nodeType, p6, p7);
        }

        public static bool GET_NTH_CLOSEST_VEHICLE_NODE(float x, float y, float z, int nthClosest, ulong _outPosition_ptr, int unknown1, int unknown2, int unknown3)
        {
            return Invoker.Call<bool>(0xE50E52416CCF948B, x, y, z, nthClosest, _outPosition_ptr, unknown1, unknown2, unknown3);
        }

        public static int GET_NTH_CLOSEST_VEHICLE_NODE_ID(float x, float y, float z, int nth, int nodetype, float p5, float p6)
        {
            return Invoker.Call<int>(0x22D7275A79FE8215, x, y, z, nth, nodetype, p5, p6);
        }

        public static bool GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, int nthClosest, ulong _outPosition_ptr, ulong heading_ptr, ulong unknown1_ptr, int unknown2, float unknown3, float unknown4)
        {
            return Invoker.Call<bool>(0x80CA6A8B6C094CC4, x, y, z, nthClosest, _outPosition_ptr, heading_ptr, unknown1_ptr, unknown2, unknown3, unknown4);
        }

        public static int GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING(float x, float y, float z, int nthClosest, ulong _outPosition_ptr, float _outHeading, int p6, float p7, float p8)
        {
            return Invoker.Call<int>(0x6448050E9C2A7207, x, y, z, nthClosest, _outPosition_ptr, _outHeading, p6, p7, p8);
        }

        public static bool GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION(float x, float y, float z, float desiredX, float desiredY, float desiredZ, int nthClosest, ulong _outPosition_ptr, ulong _outHeading_ptr, int nodetype, int p10, int p11)
        {
            return Invoker.Call<bool>(0x45905BE8654AE067, x, y, z, desiredX, desiredY, desiredZ, nthClosest, _outPosition_ptr, _outHeading_ptr, nodetype, p10, p11);
        }

        public static bool GET_VEHICLE_NODE_PROPERTIES(float x, float y, float z, ulong density_ptr, ulong flags_ptr)
        {
            return Invoker.Call<bool>(0x0568566ACBB5DEDC, x, y, z, density_ptr, flags_ptr);
        }

        public static bool IS_VEHICLE_NODE_ID_VALID(int vehicleNodeId)
        {
            return Invoker.Call<bool>(0x1EAF30FCFBF5AF74, vehicleNodeId);
        }

        public static void GET_VEHICLE_NODE_POSITION(int nodeId, ulong _outPosition_ptr)
        {
            Invoker.Call<Void>(0x703123E5E7D429C2, nodeId, _outPosition_ptr);
        }

        public static bool _GET_SUPPORTS_GPS_ROUTE_FLAG(int nodeID)
        {
            return Invoker.Call<bool>(0xA2AE5C478B96E3B6, nodeID);
        }

        public static bool _GET_IS_SLOW_ROAD_FLAG(int nodeID)
        {
            return Invoker.Call<bool>(0x4F5070AA58F69279, nodeID);
        }

        public static int GET_CLOSEST_ROAD(float x, float y, float z, float p3, int p4, ulong p5_ptr, ulong p6_ptr, ulong p7_ptr, ulong p8_ptr, ulong p9_ptr, bool p10)
        {
            return Invoker.Call<int>(0x132F52BBA570FE92, x, y, z, p3, p4, p5_ptr, p6_ptr, p7_ptr, p8_ptr, p9_ptr, p10);
        }

        public static bool LOAD_ALL_PATH_NODES(bool keepInMemory)
        {
            return Invoker.Call<bool>(0x80E4A6EDDB0BE8D9, keepInMemory);
        }

        public static void _0x228E5C6AD4D74BFD(bool p0)
        {
            Invoker.Call<Void>(0x228E5C6AD4D74BFD, p0);
        }

        public static bool _0xF7B79A50B905A30D(float p0, float p1, float p2, float p3)
        {
            return Invoker.Call<bool>(0xF7B79A50B905A30D, p0, p1, p2, p3);
        }

        public static bool _0x07FB139B592FA687(float p0, float p1, float p2, float p3)
        {
            return Invoker.Call<bool>(0x07FB139B592FA687, p0, p1, p2, p3);
        }

        public static void SET_ROADS_BACK_TO_ORIGINAL(float p0, float p1, float p2, float p3, float p4, float p5)
        {
            Invoker.Call<Void>(0x1EE7063B80FFC77C, p0, p1, p2, p3, p4, p5);
        }

        public static void SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float p6)
        {
            Invoker.Call<Void>(0x0027501B9F3B407E, x1, y1, z1, x2, y2, z2, p6);
        }

        public static void _0x0B919E1FB47CC4E0(float p0)
        {
            Invoker.Call<Void>(0x0B919E1FB47CC4E0, p0);
        }

        public static void _0xAA76052DDA9BFC3E(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Invoker.Call<Void>(0xAA76052DDA9BFC3E, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void SET_PED_PATHS_BACK_TO_ORIGINAL(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0xE04B48F2CC926253, p0, p1, p2, p3, p4, p5);
        }

        public static bool GET_RANDOM_VEHICLE_NODE(float x, float y, float z, float radius, bool p4, bool p5, bool p6, ulong _outPosition_ptr, ulong nodeId_ptr)
        {
            return Invoker.Call<bool>(0x93E0DB8440B73A7D, x, y, z, radius, p4, p5, p6, _outPosition_ptr, nodeId_ptr);
        }

        public static void GET_STREET_NAME_AT_COORD(float x, float y, float z, ulong streetName_ptr, ulong crossingRoad_ptr)
        {
            Invoker.Call<Void>(0x2EB41072B4C1E4C0, x, y, z, streetName_ptr, crossingRoad_ptr);
        }

        public static int GENERATE_DIRECTIONS_TO_COORD(float x, float y, float z, bool p3, ulong direction_ptr, ulong vehicle_ptr, ulong distToNxJunction_ptr)
        {
            return Invoker.Call<int>(0xF90125F1F79ECDF8, x, y, z, p3, direction_ptr, vehicle_ptr, distToNxJunction_ptr);
        }

        public static void SET_IGNORE_NO_GPS_FLAG(bool ignore)
        {
            Invoker.Call<Void>(0x72751156E7678833, ignore);
        }

        public static int _0x1FC289A0C3FF470F(bool p0)
        {
            return Invoker.Call<int>(0x1FC289A0C3FF470F, p0);
        }

        public static void SET_GPS_DISABLED_ZONE(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            Invoker.Call<Void>(0xDC20483CD3DD5201, p0, p1, p2, p3, p4, p5);
        }

        public static int _0xBBB45C3CF5C8AA85()
        {
            return Invoker.Call<int>(0xBBB45C3CF5C8AA85);
        }

        public static int _0x869DAACBBE9FA006()
        {
            return Invoker.Call<int>(0x869DAACBBE9FA006);
        }

        public static int _0x16F46FB18C8009E4(int p0, int p1, int p2, int p3, int p4)
        {
            return Invoker.Call<int>(0x16F46FB18C8009E4, p0, p1, p2, p3, p4);
        }

        public static bool IS_POINT_ON_ROAD(float x, float y, float z, int vehicle)
        {
            return Invoker.Call<bool>(0x125BF4ABFC536B09, x, y, z, vehicle);
        }

        public static int _0xD3A6A0EF48823A8C()
        {
            return Invoker.Call<int>(0xD3A6A0EF48823A8C);
        }

        public static void _0xD0BC1C6FB18EE154(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Invoker.Call<Void>(0xD0BC1C6FB18EE154, p0, p1, p2, p3, p4, p5, p6);
        }

        public static void _0x2801D0012266DF07(int p0)
        {
            Invoker.Call<Void>(0x2801D0012266DF07, p0);
        }

        public static void ADD_NAVMESH_REQUIRED_REGION(float x, float y, float radius)
        {
            Invoker.Call<Void>(0x387EAD7EE42F6685, x, y, radius);
        }

        public static void REMOVE_NAVMESH_REQUIRED_REGIONS()
        {
            Invoker.Call<Void>(0x916F0A3CDEC3445E);
        }

        public static void DISABLE_NAVMESH_IN_AREA(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Invoker.Call<Void>(0x4C8872D8CDBE1B8B, p0, p1, p2, p3, p4, p5, p6);
        }

        public static bool ARE_ALL_NAVMESH_REGIONS_LOADED()
        {
            return Invoker.Call<bool>(0x8415D95B194A3AEA);
        }

        public static bool IS_NAVMESH_LOADED_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<bool>(0xF813C7E63F9062A5, x1, y1, z1, x2, y2, z2);
        }

        public static int _0x01708E8DD3FF8C65(float p0, float p1, float p2, float p3, float p4, float p5)
        {
            return Invoker.Call<int>(0x01708E8DD3FF8C65, p0, p1, p2, p3, p4, p5);
        }

        public static int ADD_NAVMESH_BLOCKING_OBJECT(float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, int p8)
        {
            return Invoker.Call<int>(0xFCD5C8E06E502F5A, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void UPDATE_NAVMESH_BLOCKING_OBJECT(int p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, int p8)
        {
            Invoker.Call<Void>(0x109E99373F290687, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void REMOVE_NAVMESH_BLOCKING_OBJECT(int p0)
        {
            Invoker.Call<Void>(0x46399A7895957C0E, p0);
        }

        public static bool DOES_NAVMESH_BLOCKING_OBJECT_EXIST(int p0)
        {
            return Invoker.Call<bool>(0x0EAEB0DB4B132399, p0);
        }

        public static float _0x29C24BFBED8AB8FB(float p0, float p1)
        {
            return Invoker.Call<float>(0x29C24BFBED8AB8FB, p0, p1);
        }

        public static float _0x8ABE8608576D9CE3(float p0, float p1, float p2, float p3)
        {
            return Invoker.Call<float>(0x8ABE8608576D9CE3, p0, p1, p2, p3);
        }

        public static float _0x336511A34F2E5185(float left, float right)
        {
            return Invoker.Call<float>(0x336511A34F2E5185, left, right);
        }

        public static float _0x3599D741C9AC6310(float p0, float p1, float p2, float p3)
        {
            return Invoker.Call<float>(0x3599D741C9AC6310, p0, p1, p2, p3);
        }

        public static float CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<float>(0xADD95C7005C4A197, x1, y1, z1, x2, y2, z2);
        }

    }

    public static class CONTROLS
    {

        public static bool IS_CONTROL_ENABLED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0x1CEA6BFDF248E5D9, inputGroup, control);
        }

        public static bool IS_CONTROL_PRESSED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0xF3A21BCD95725A4A, inputGroup, control);
        }

        public static bool IS_CONTROL_RELEASED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0x648EE3E7F38877DD, inputGroup, control);
        }

        public static bool IS_CONTROL_JUST_PRESSED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0x580417101DDB492F, inputGroup, control);
        }

        public static bool IS_CONTROL_JUST_RELEASED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0x50F940259D3841E6, inputGroup, control);
        }

        public static int GET_CONTROL_VALUE(int inputGroup, int control)
        {
            return Invoker.Call<int>(0xD95E79E8686D2C27, inputGroup, control);
        }

        public static float GET_CONTROL_NORMAL(int inputGroup, int control)
        {
            return Invoker.Call<float>(0xEC3C9B8D5327B563, inputGroup, control);
        }

        public static void _0x5B73C77D9EB66E24(bool p0)
        {
            Invoker.Call<Void>(0x5B73C77D9EB66E24, p0);
        }

        public static float _0x5B84D09CEC5209C5(int inputGroup, int control)
        {
            return Invoker.Call<float>(0x5B84D09CEC5209C5, inputGroup, control);
        }

        public static bool _SET_CONTROL_NORMAL(int inputGroup, int control, float amount)
        {
            return Invoker.Call<bool>(0xE8A25867FBA3B05E, inputGroup, control, amount);
        }

        public static bool IS_DISABLED_CONTROL_PRESSED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0xE2587F8CBBD87B1D, inputGroup, control);
        }

        public static bool IS_DISABLED_CONTROL_JUST_PRESSED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0x91AEF906BCA88877, inputGroup, control);
        }

        public static bool IS_DISABLED_CONTROL_JUST_RELEASED(int inputGroup, int control)
        {
            return Invoker.Call<bool>(0x305C8DCD79DA8B0F, inputGroup, control);
        }

        public static float GET_DISABLED_CONTROL_NORMAL(int inputGroup, int control)
        {
            return Invoker.Call<float>(0x11E65974A982637C, inputGroup, control);
        }

        public static float _0x4F8A26A890FD62FB(int inputGroup, int control)
        {
            return Invoker.Call<float>(0x4F8A26A890FD62FB, inputGroup, control);
        }

        public static int _0xD7D22F5592AED8BA(int p0)
        {
            return Invoker.Call<int>(0xD7D22F5592AED8BA, p0);
        }

        public static bool _IS_INPUT_DISABLED(int inputGroup)
        {
            return Invoker.Call<bool>(0xA571D46727E2B718, inputGroup);
        }

        public static bool _IS_INPUT_JUST_DISABLED(int inputGroup)
        {
            return Invoker.Call<bool>(0x13337B38DB572509, inputGroup);
        }

        public static bool _SET_CURSOR_LOCATION(float x, float y)
        {
            return Invoker.Call<bool>(0xFC695459D4D0E219, x, y);
        }

        public static bool _0x23F09EADC01449D6(bool p0)
        {
            return Invoker.Call<bool>(0x23F09EADC01449D6, p0);
        }

        public static bool _0x6CD79468A1E595C6(int inputGroup)
        {
            return Invoker.Call<bool>(0x6CD79468A1E595C6, inputGroup);
        }

        public static string GET_CONTROL_INSTRUCTIONAL_BUTTON(int inputGroup, int control, int p2)
        {
            return Invoker.Call<string>(0x0499D7B09FC9B407, inputGroup, control, p2);
        }

        public static string _0x80C2FD58D720C801(int inputGroup, int control, bool p2)
        {
            return Invoker.Call<string>(0x80C2FD58D720C801, inputGroup, control, p2);
        }

        public static void _0x8290252FFF36ACB5(int p0, int red, int green, int blue)
        {
            Invoker.Call<Void>(0x8290252FFF36ACB5, p0, red, green, blue);
        }

        public static void _0xCB0360EFEFB2580D(int p0)
        {
            Invoker.Call<Void>(0xCB0360EFEFB2580D, p0);
        }

        public static void SET_PAD_SHAKE(int p0, int duration, int frequency)
        {
            Invoker.Call<Void>(0x48B3886C1358D0D5, p0, duration, frequency);
        }

        public static void _0x14D29BB12D47F68C(int p0, int p1, int p2, int p3, int p4)
        {
            Invoker.Call<Void>(0x14D29BB12D47F68C, p0, p1, p2, p3, p4);
        }

        public static void STOP_PAD_SHAKE(int p0)
        {
            Invoker.Call<Void>(0x38C16A305E8CDC8D, p0);
        }

        public static void _0xF239400E16C23E08(int p0, int p1)
        {
            Invoker.Call<Void>(0xF239400E16C23E08, p0, p1);
        }

        public static void _0xA0CEFCEA390AAB9B(int p0)
        {
            Invoker.Call<Void>(0xA0CEFCEA390AAB9B, p0);
        }

        public static bool IS_LOOK_INVERTED()
        {
            return Invoker.Call<bool>(0x77B612531280010D);
        }

        public static bool _0xE1615EC03B3BB4FD()
        {
            return Invoker.Call<bool>(0xE1615EC03B3BB4FD);
        }

        public static int GET_LOCAL_PLAYER_AIM_STATE()
        {
            return Invoker.Call<int>(0xBB41AFBBBC0A0287);
        }

        public static int _0x59B9A7AF4C95133C()
        {
            return Invoker.Call<int>(0x59B9A7AF4C95133C);
        }

        public static bool _0x0F70731BACCFBB96()
        {
            return Invoker.Call<bool>(0x0F70731BACCFBB96);
        }

        public static bool _0xFC859E2374407556()
        {
            return Invoker.Call<bool>(0xFC859E2374407556);
        }

        public static void SET_PLAYERPAD_SHAKES_WHEN_CONTROLLER_DISABLED(bool toggle)
        {
            Invoker.Call<Void>(0x798FDEB5B1575088, toggle);
        }

        public static void SET_INPUT_EXCLUSIVE(int inputGroup, int control)
        {
            Invoker.Call<Void>(0xEDE476E5EE29EDB1, inputGroup, control);
        }

        public static void DISABLE_CONTROL_ACTION(int inputGroup, int control, bool disable)
        {
            Invoker.Call<Void>(0xFE99B66D079CF6BC, inputGroup, control, disable);
        }

        public static void ENABLE_CONTROL_ACTION(int inputGroup, int control, bool enable)
        {
            Invoker.Call<Void>(0x351220255D64C155, inputGroup, control, enable);
        }

        public static void DISABLE_ALL_CONTROL_ACTIONS(int inputGroup)
        {
            Invoker.Call<Void>(0x5F4B6931816E599B, inputGroup);
        }

        public static void ENABLE_ALL_CONTROL_ACTIONS(int inputGroup)
        {
            Invoker.Call<Void>(0xA5FFE9B05F199DE7, inputGroup);
        }

        public static bool _0x3D42B92563939375(string p0)
        {
            return Invoker.Call<bool>(0x3D42B92563939375, p0);
        }

        public static bool _0x4683149ED1DDE7A1(string p0)
        {
            return Invoker.Call<bool>(0x4683149ED1DDE7A1, p0);
        }

        public static void _0x643ED62D5EA3BEBD()
        {
            Invoker.Call<Void>(0x643ED62D5EA3BEBD);
        }

        public static void _DISABLE_INPUT_GROUP(int inputGroup)
        {
            Invoker.Call<Void>(0x7F4724035FDCA1DD, inputGroup);
        }

    }

    public static class DATAFILE
    {

        public static void _0xAD6875BBC0FC899C(int x)
        {
            Invoker.Call<Void>(0xAD6875BBC0FC899C, x);
        }

        public static void _0x6CC86E78358D5119()
        {
            Invoker.Call<Void>(0x6CC86E78358D5119);
        }

        public static bool _0xFCCAE5B92A830878(int p0)
        {
            return Invoker.Call<bool>(0xFCCAE5B92A830878, p0);
        }

        public static bool _0x15FF52B809DB2353(int p0)
        {
            return Invoker.Call<bool>(0x15FF52B809DB2353, p0);
        }

        public static bool _0xF8CC1EBE0B62E29F(int p0)
        {
            return Invoker.Call<bool>(0xF8CC1EBE0B62E29F, p0);
        }

        public static bool _0x22DA66936E0FFF37(int p0)
        {
            return Invoker.Call<bool>(0x22DA66936E0FFF37, p0);
        }

        public static bool _0x8F5EA1C01D65A100(int p0)
        {
            return Invoker.Call<bool>(0x8F5EA1C01D65A100, p0);
        }

        public static bool _0xC84527E235FCA219(string p0, bool p1, string p2, ulong p3_ptr, ulong p4_ptr, string type, bool p6)
        {
            return Invoker.Call<bool>(0xC84527E235FCA219, p0, p1, p2, p3_ptr, p4_ptr, type, p6);
        }

        public static bool _0xA5EFC3E847D60507(string p0, string p1, string p2, string p3, bool p4)
        {
            return Invoker.Call<bool>(0xA5EFC3E847D60507, p0, p1, p2, p3, p4);
        }

        public static bool _0x648E7A5434AF7969(string p0, ulong p1_ptr, bool p2, ulong p3_ptr, ulong p4_ptr, ulong p5_ptr, string type)
        {
            return Invoker.Call<bool>(0x648E7A5434AF7969, p0, p1_ptr, p2, p3_ptr, p4_ptr, p5_ptr, type);
        }

        public static bool _0x4645DE9980999E93(string p0, string p1, string p2, string p3, string type)
        {
            return Invoker.Call<bool>(0x4645DE9980999E93, p0, p1, p2, p3, type);
        }

        public static bool _0x692D808C34A82143(string p0, float p1, string type)
        {
            return Invoker.Call<bool>(0x692D808C34A82143, p0, p1, type);
        }

        public static bool _0xA69AC4ADE82B57A4(int p0)
        {
            return Invoker.Call<bool>(0xA69AC4ADE82B57A4, p0);
        }

        public static bool _0x9CB0BFA7A9342C3D(int p0, bool p1)
        {
            return Invoker.Call<bool>(0x9CB0BFA7A9342C3D, p0, p1);
        }

        public static bool _0x52818819057F2B40(int p0)
        {
            return Invoker.Call<bool>(0x52818819057F2B40, p0);
        }

        public static bool _0x01095C95CD46B624(int p0)
        {
            return Invoker.Call<bool>(0x01095C95CD46B624, p0);
        }

        public static bool _LOAD_UGC_FILE(string filename)
        {
            return Invoker.Call<bool>(0xC5238C011AF405E4, filename);
        }

        public static void DATAFILE_CREATE()
        {
            Invoker.Call<Void>(0xD27058A1CA2B13EE);
        }

        public static void DATAFILE_DELETE()
        {
            Invoker.Call<Void>(0x9AB9C1CFC8862DFB);
        }

        public static void _0x2ED61456317B8178()
        {
            Invoker.Call<Void>(0x2ED61456317B8178);
        }

        public static void _0xC55854C7D7274882()
        {
            Invoker.Call<Void>(0xC55854C7D7274882);
        }

        public static string DATAFILE_GET_FILE_DICT()
        {
            return Invoker.Call<string>(0x906B778CA1DC72B6);
        }

        public static bool _0x83BCCE3224735F05(string filename)
        {
            return Invoker.Call<bool>(0x83BCCE3224735F05, filename);
        }

        public static bool _0x4DFDD9EB705F8140(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x4DFDD9EB705F8140, p0_ptr);
        }

        public static bool DATAFILE_IS_SAVE_PENDING()
        {
            return Invoker.Call<bool>(0xBEDB96A7584AA8CF);
        }

        public static void _OBJECT_VALUE_ADD_BOOLEAN(ulong _objectData_ptr, string key, bool value)
        {
            Invoker.Call<Void>(0x35124302A556A325, _objectData_ptr, key, value);
        }

        public static void _OBJECT_VALUE_ADD_INTEGER(ulong _objectData_ptr, string key, int value)
        {
            Invoker.Call<Void>(0xE7E035450A7948D5, _objectData_ptr, key, value);
        }

        public static void _OBJECT_VALUE_ADD_FLOAT(ulong _objectData_ptr, string key, float value)
        {
            Invoker.Call<Void>(0xC27E1CC2D795105E, _objectData_ptr, key, value);
        }

        public static void _OBJECT_VALUE_ADD_STRING(ulong _objectData_ptr, string key, string value)
        {
            Invoker.Call<Void>(0x8FF3847DADD8E30C, _objectData_ptr, key, value);
        }

        public static void _OBJECT_VALUE_ADD_VECTOR3(ulong _objectData_ptr, string key, float valueX, float valueY, float valueZ)
        {
            Invoker.Call<Void>(0x4CD49B76338C7DEE, _objectData_ptr, key, valueX, valueY, valueZ);
        }

        public static ulong _OBJECT_VALUE_ADD_OBJECT(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<ulong>(0xA358F56F10732EE1, _objectData_ptr, key);
        }

        public static ulong _OBJECT_VALUE_ADD_ARRAY(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<ulong>(0x5B11728527CA6E5F, _objectData_ptr, key);
        }

        public static bool _OBJECT_VALUE_GET_BOOLEAN(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<bool>(0x1186940ED72FFEEC, _objectData_ptr, key);
        }

        public static int _OBJECT_VALUE_GET_INTEGER(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<int>(0x78F06F6B1FB5A80C, _objectData_ptr, key);
        }

        public static float _OBJECT_VALUE_GET_FLOAT(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<float>(0x06610343E73B9727, _objectData_ptr, key);
        }

        public static string _OBJECT_VALUE_GET_STRING(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<string>(0x3D2FD9E763B24472, _objectData_ptr, key);
        }

        public static Vector3 _OBJECT_VALUE_GET_VECTOR3(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<Vector3>(0x46CD3CB66E0825CC, _objectData_ptr, key);
        }

        public static ulong _OBJECT_VALUE_GET_OBJECT(ulong sCloudFile_ptr, string key)
        {
            return Invoker.Call<ulong>(0xB6B9DDC412FCEEE2, sCloudFile_ptr, key);
        }

        public static ulong _OBJECT_VALUE_GET_ARRAY(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<ulong>(0x7A983AA9DA2659ED, _objectData_ptr, key);
        }

        public static int _OBJECT_VALUE_GET_TYPE(ulong _objectData_ptr, string key)
        {
            return Invoker.Call<int>(0x031C55ED33227371, _objectData_ptr, key);
        }

        public static void _ARRAY_VALUE_ADD_BOOLEAN(ulong arrayData_ptr, bool value)
        {
            Invoker.Call<Void>(0xF8B0F5A43E928C76, arrayData_ptr, value);
        }

        public static void _ARRAY_VALUE_ADD_INTEGER(ulong arrayData_ptr, int value)
        {
            Invoker.Call<Void>(0xCABDB751D86FE93B, arrayData_ptr, value);
        }

        public static void _ARRAY_VALUE_ADD_FLOAT(ulong arrayData_ptr, float value)
        {
            Invoker.Call<Void>(0x57A995FD75D37F56, arrayData_ptr, value);
        }

        public static void _ARRAY_VALUE_ADD_STRING(ulong arrayData_ptr, string value)
        {
            Invoker.Call<Void>(0x2F0661C155AEEEAA, arrayData_ptr, value);
        }

        public static void _ARRAY_VALUE_ADD_VECTOR3(ulong arrayData_ptr, float valueX, float valueY, float valueZ)
        {
            Invoker.Call<Void>(0x407F8D034F70F0C2, arrayData_ptr, valueX, valueY, valueZ);
        }

        public static ulong _ARRAY_VALUE_ADD_OBJECT(ulong arrayData_ptr)
        {
            return Invoker.Call<ulong>(0x6889498B3E19C797, arrayData_ptr);
        }

        public static bool _ARRAY_VALUE_GET_BOOLEAN(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<bool>(0x50C1B2874E50C114, arrayData_ptr, arrayIndex);
        }

        public static int _ARRAY_VALUE_GET_INTEGER(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<int>(0x3E5AE19425CD74BE, arrayData_ptr, arrayIndex);
        }

        public static float _ARRAY_VALUE_GET_FLOAT(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<float>(0xC0C527B525D7CFB5, arrayData_ptr, arrayIndex);
        }

        public static string _ARRAY_VALUE_GET_STRING(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<string>(0xD3F2FFEB8D836F52, arrayData_ptr, arrayIndex);
        }

        public static Vector3 _ARRAY_VALUE_GET_VECTOR3(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<Vector3>(0x8D2064E5B64A628A, arrayData_ptr, arrayIndex);
        }

        public static ulong _ARRAY_VALUE_GET_OBJECT(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<ulong>(0x8B5FADCC4E3A145F, arrayData_ptr, arrayIndex);
        }

        public static int _ARRAY_VALUE_GET_SIZE(ulong arrayData_ptr)
        {
            return Invoker.Call<int>(0x065DB281590CEA2D, arrayData_ptr);
        }

        public static int _ARRAY_VALUE_GET_TYPE(ulong arrayData_ptr, int arrayIndex)
        {
            return Invoker.Call<int>(0x3A0014ADB172A3C5, arrayData_ptr, arrayIndex);
        }

    }

    public static class FIRE
    {

        public static int START_SCRIPT_FIRE(float X, float Y, float Z, int maxChildren, bool isGasFire)
        {
            return Invoker.Call<int>(0x6B83617E04503888, X, Y, Z, maxChildren, isGasFire);
        }

        public static void REMOVE_SCRIPT_FIRE(int fireHandle)
        {
            Invoker.Call<Void>(0x7FF548385680673F, fireHandle);
        }

        public static int START_ENTITY_FIRE(int entity)
        {
            return Invoker.Call<int>(0xF6A9D9708F6F23DF, entity);
        }

        public static void STOP_ENTITY_FIRE(int entity)
        {
            Invoker.Call<Void>(0x7F0DD2EBBB651AFF, entity);
        }

        public static bool IS_ENTITY_ON_FIRE(int entity)
        {
            return Invoker.Call<bool>(0x28D3FED7190D3A0B, entity);
        }

        public static int GET_NUMBER_OF_FIRES_IN_RANGE(float x, float y, float z, float radius)
        {
            return Invoker.Call<int>(0x50CAD495A460B305, x, y, z, radius);
        }

        public static void STOP_FIRE_IN_RANGE(float x, float y, float z, float radius)
        {
            Invoker.Call<Void>(0x056A8A219B8E829F, x, y, z, radius);
        }

        public static bool GET_CLOSEST_FIRE_POS(ulong _outPosition_ptr, float x, float y, float z)
        {
            return Invoker.Call<bool>(0x352A9F6BCF90081F, _outPosition_ptr, x, y, z);
        }

        public static void ADD_EXPLOSION(float x, float y, float z, int explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
        {
            Invoker.Call<Void>(0xE3AD2BDBAEE269AC, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake);
        }

        public static void ADD_OWNED_EXPLOSION(int ped, float x, float y, float z, int explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
        {
            Invoker.Call<Void>(0x172AA1B624FA1013, ped, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake);
        }

        public static void ADD_EXPLOSION_WITH_USER_VFX(float x, float y, float z, int explosionType, int explosionFx, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
        {
            Invoker.Call<Void>(0x36DD3FE58B5E5212, x, y, z, explosionType, explosionFx, damageScale, isAudible, isInvisible, cameraShake);
        }

        public static bool IS_EXPLOSION_IN_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<bool>(0x2E2EBA0EE7CED0E0, explosionType, x1, y1, z1, x2, y2, z2);
        }

        public static int _0x6070104B699B2EF4(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            return Invoker.Call<int>(0x6070104B699B2EF4, p0, p1, p2, p3, p4, p5, p6);
        }

        public static bool IS_EXPLOSION_IN_SPHERE(int explosionType, float x, float y, float z, float radius)
        {
            return Invoker.Call<bool>(0xAB0F816885B0E483, explosionType, x, y, z, radius);
        }

        public static bool IS_EXPLOSION_IN_ANGLED_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float angle)
        {
            return Invoker.Call<bool>(0xA079A6C51525DC4B, explosionType, x1, y1, z1, x2, y2, z2, angle);
        }

        public static int _GET_PED_INSIDE_EXPLOSION_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float radius)
        {
            return Invoker.Call<int>(0x14BA4BA137AF6CEC, explosionType, x1, y1, z1, x2, y2, z2, radius);
        }

    }

    public static class DECISIONEVENT
    {

        public static void SET_DECISION_MAKER(int ped, int name)
        {
            Invoker.Call<Void>(0xB604A2942ADED0EE, ped, name);
        }

        public static void CLEAR_DECISION_MAKER_EVENT_RESPONSE(int name, int type)
        {
            Invoker.Call<Void>(0x4FC9381A7AEE8968, name, type);
        }

        public static void BLOCK_DECISION_MAKER_EVENT(int name, int type)
        {
            Invoker.Call<Void>(0xE42FCDFD0E4196F7, name, type);
        }

        public static void UNBLOCK_DECISION_MAKER_EVENT(int name, int type)
        {
            Invoker.Call<Void>(0xD7CD9CF34F2C99E8, name, type);
        }

        public static int ADD_SHOCKING_EVENT_AT_POSITION(int type, float x, float y, float z, float duration)
        {
            return Invoker.Call<int>(0xD9F8455409B525E9, type, x, y, z, duration);
        }

        public static int ADD_SHOCKING_EVENT_FOR_ENTITY(int type, int entity, float duration)
        {
            return Invoker.Call<int>(0x7FD8F3BE76F89422, type, entity, duration);
        }

        public static bool IS_SHOCKING_EVENT_IN_SPHERE(int type, float x, float y, float z, float radius)
        {
            return Invoker.Call<bool>(0x1374ABB7C15BAB92, type, x, y, z, radius);
        }

        public static bool REMOVE_SHOCKING_EVENT(int _event)
        {
            return Invoker.Call<bool>(0x2CDA538C44C6CCE5, _event);
        }

        public static void REMOVE_ALL_SHOCKING_EVENTS(bool p0)
        {
            Invoker.Call<Void>(0xEAABE8FDFA21274C, p0);
        }

        public static void REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS()
        {
            Invoker.Call<Void>(0x340F1415B68AEADE);
        }

        public static void SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME()
        {
            Invoker.Call<Void>(0x2F9A292AD0A3BD89);
        }

        public static void SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME(int type)
        {
            Invoker.Call<Void>(0x3FD2EC8BF1F1CF30, type);
        }

        public static void SUPPRESS_AGITATION_EVENTS_NEXT_FRAME()
        {
            Invoker.Call<Void>(0x5F3B7749C112D552);
        }

    }

    public static class ZONE
    {

        public static int GET_ZONE_AT_COORDS(float x, float y, float z)
        {
            return Invoker.Call<int>(0x27040C25DE6CB2F4, x, y, z);
        }

        public static int GET_ZONE_FROM_NAME_ID(string zoneName)
        {
            return Invoker.Call<int>(0x98CD1D2934B76CC1, zoneName);
        }

        public static int GET_ZONE_POPSCHEDULE(int zoneId)
        {
            return Invoker.Call<int>(0x4334BC40AA0CB4BB, zoneId);
        }

        public static string GET_NAME_OF_ZONE(float x, float y, float z)
        {
            return Invoker.Call<string>(0xCD90657D4C30E1CA, x, y, z);
        }

        public static void SET_ZONE_ENABLED(int zoneId, bool toggle)
        {
            Invoker.Call<Void>(0xBA5ECEEA120E5611, zoneId, toggle);
        }

        public static int GET_ZONE_SCUMMINESS(int zoneId)
        {
            return Invoker.Call<int>(0x5F7B268D15BA0739, zoneId);
        }

        public static void OVERRIDE_POPSCHEDULE_VEHICLE_MODEL(int scheduleId, int vehicleHash)
        {
            Invoker.Call<Void>(0x5F7D596BAC2E7777, scheduleId, vehicleHash);
        }

        public static void CLEAR_POPSCHEDULE_OVERRIDE_VEHICLE_MODEL(int scheduleId)
        {
            Invoker.Call<Void>(0x5C0DE367AA0D911C, scheduleId);
        }

        public static int GET_HASH_OF_MAP_AREA_AT_COORDS(float x, float y, float z)
        {
            return Invoker.Call<int>(0x7EE64D51E8498728, x, y, z);
        }

    }

    public static class ROPE
    {

        public static int ADD_ROPE(float x, float y, float z, float rotX, float rotY, float rotZ, float length, int ropeType, float maxLength, float minLength, float p10, bool p11, bool p12, bool rigid, float p14, bool breakWhenShot, ulong unkPtr_ptr)
        {
            return Invoker.Call<int>(0xE832D760399EB220, x, y, z, rotX, rotY, rotZ, length, ropeType, maxLength, minLength, p10, p11, p12, rigid, p14, breakWhenShot, unkPtr_ptr);
        }

        public static void DELETE_ROPE(ulong rope_ptr)
        {
            Invoker.Call<Void>(0x52B4829281364649, rope_ptr);
        }

        public static int DELETE_CHILD_ROPE(int rope)
        {
            return Invoker.Call<int>(0xAA5D6B1888E4DB20, rope);
        }

        public static bool DOES_ROPE_EXIST(ulong rope_ptr)
        {
            return Invoker.Call<bool>(0xFD5448BE3111ED96, rope_ptr);
        }

        public static void ROPE_DRAW_SHADOW_ENABLED(ulong rope_ptr, bool toggle)
        {
            Invoker.Call<Void>(0xF159A63806BB5BA8, rope_ptr, toggle);
        }

        public static int LOAD_ROPE_DATA(int rope, string rope_preset)
        {
            return Invoker.Call<int>(0xCBB203C04D1ABD27, rope, rope_preset);
        }

        public static void PIN_ROPE_VERTEX(int rope, int vertex, float x, float y, float z)
        {
            Invoker.Call<Void>(0x2B320CF14146B69A, rope, vertex, x, y, z);
        }

        public static int UNPIN_ROPE_VERTEX(int rope, int vertex)
        {
            return Invoker.Call<int>(0x4B5AE2EEE4A8F180, rope, vertex);
        }

        public static int GET_ROPE_VERTEX_COUNT(int rope)
        {
            return Invoker.Call<int>(0x3655F544CD30F0B5, rope);
        }

        public static void ATTACH_ENTITIES_TO_ROPE(int rope, int ent1, int ent2, float ent1_x, float ent1_y, float ent1_z, float ent2_x, float ent2_y, float ent2_z, float length, bool p10, bool p11, string boneName1, string boneName2)
        {
            Invoker.Call<Void>(0x3D95EC8B6D940AC3, rope, ent1, ent2, ent1_x, ent1_y, ent1_z, ent2_x, ent2_y, ent2_z, length, p10, p11, boneName1, boneName2);
        }

        public static void ATTACH_ROPE_TO_ENTITY(int rope, int entity, float x, float y, float z, bool p5)
        {
            Invoker.Call<Void>(0x4B490A6832559A65, rope, entity, x, y, z, p5);
        }

        public static void DETACH_ROPE_FROM_ENTITY(int rope, int entity)
        {
            Invoker.Call<Void>(0xBCF3026912A8647D, rope, entity);
        }

        public static void ROPE_SET_UPDATE_PINVERTS(int rope)
        {
            Invoker.Call<Void>(0xC8D667EE52114ABA, rope);
        }

        public static void _0xDC57A637A20006ED(int p0, int p1)
        {
            Invoker.Call<Void>(0xDC57A637A20006ED, p0, p1);
        }

        public static void _0x36CCB9BE67B970FD(int p0, bool p1)
        {
            Invoker.Call<Void>(0x36CCB9BE67B970FD, p0, p1);
        }

        public static bool _0x84DE3B5FB3E666F0(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x84DE3B5FB3E666F0, p0_ptr);
        }

        public static int GET_ROPE_LAST_VERTEX_COORD(int rope)
        {
            return Invoker.Call<int>(0x21BB0FBD3E217C2D, rope);
        }

        public static int GET_ROPE_VERTEX_COORD(int rope, int vertex)
        {
            return Invoker.Call<int>(0xEA61CA8E80F09E4D, rope, vertex);
        }

        public static void START_ROPE_WINDING(int rope)
        {
            Invoker.Call<Void>(0x1461C72C889E343E, rope);
        }

        public static void STOP_ROPE_WINDING(int rope)
        {
            Invoker.Call<Void>(0xCB2D4AB84A19AA7C, rope);
        }

        public static void START_ROPE_UNWINDING_FRONT(int rope)
        {
            Invoker.Call<Void>(0x538D1179EC1AA9A9, rope);
        }

        public static void STOP_ROPE_UNWINDING_FRONT(int rope)
        {
            Invoker.Call<Void>(0xFFF3A50779EFBBB3, rope);
        }

        public static void ROPE_CONVERT_TO_SIMPLE(int rope)
        {
            Invoker.Call<Void>(0x5389D48EFA2F079A, rope);
        }

        public static int ROPE_LOAD_TEXTURES()
        {
            return Invoker.Call<int>(0x9B9039DBF2D258C1);
        }

        public static bool ROPE_ARE_TEXTURES_LOADED()
        {
            return Invoker.Call<bool>(0xF2D0E6A75CC05597);
        }

        public static int ROPE_UNLOAD_TEXTURES()
        {
            return Invoker.Call<int>(0x6CE36C35C1AC8163);
        }

        public static bool _0x271C9D3ACA5D6409(int rope)
        {
            return Invoker.Call<bool>(0x271C9D3ACA5D6409, rope);
        }

        public static void _0xBC0CE682D4D05650(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13)
        {
            Invoker.Call<Void>(0xBC0CE682D4D05650, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }

        public static void _0xB1B6216CA2E7B55E(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xB1B6216CA2E7B55E, p0, p1, p2);
        }

        public static void _0xB743F735C03D7810(int p0, int p1)
        {
            Invoker.Call<Void>(0xB743F735C03D7810, p0, p1);
        }

        public static float _GET_ROPE_LENGTH(int rope)
        {
            return Invoker.Call<float>(0x73040398DFF9A4A6, rope);
        }

        public static int ROPE_FORCE_LENGTH(int rope, float length)
        {
            return Invoker.Call<int>(0xD009F759A723DB1B, rope, length);
        }

        public static void ROPE_RESET_LENGTH(int rope, float length)
        {
            Invoker.Call<Void>(0xC16DE94D9BEA14A0, rope, length);
        }

        public static void APPLY_IMPULSE_TO_CLOTH(float posX, float posY, float posZ, float vecX, float vecY, float vecZ, float impulse)
        {
            Invoker.Call<Void>(0xE37F721824571784, posX, posY, posZ, vecX, vecY, vecZ, impulse);
        }

        public static void SET_DAMPING(int rope, int vertex, float value)
        {
            Invoker.Call<Void>(0xEEA3B200A6FEB65B, rope, vertex, value);
        }

        public static void ACTIVATE_PHYSICS(int entity)
        {
            Invoker.Call<Void>(0x710311ADF0E20730, entity);
        }

        public static void SET_CGOFFSET(int rope, float x, float y, float z)
        {
            Invoker.Call<Void>(0xD8FA3908D7B86904, rope, x, y, z);
        }

        public static Vector3 GET_CGOFFSET(int rope)
        {
            return Invoker.Call<Vector3>(0x8214A4B5A7A33612, rope);
        }

        public static void SET_CG_AT_BOUNDCENTER(int rope)
        {
            Invoker.Call<Void>(0xBE520D9761FF811F, rope);
        }

        public static void BREAK_ENTITY_GLASS(int p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, int p9, bool p10)
        {
            Invoker.Call<Void>(0x2E648D16F6E308F3, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }

        public static int SET_DISABLE_BREAKING(int rope, bool enabled)
        {
            return Invoker.Call<int>(0x5CEC1A84620E7D5B, rope, enabled);
        }

        public static void _0xCC6E963682533882(int p0)
        {
            Invoker.Call<Void>(0xCC6E963682533882, p0);
        }

        public static void SET_DISABLE_FRAG_DAMAGE(int _object, bool toggle)
        {
            Invoker.Call<Void>(0x01BA3AED21C16CFB, _object, toggle);
        }

    }

    public static class WATER
    {

        public static bool GET_WATER_HEIGHT(float x, float y, float z, ulong height_ptr)
        {
            return Invoker.Call<bool>(0xF6829842C06AE524, x, y, z, height_ptr);
        }

        public static bool GET_WATER_HEIGHT_NO_WAVES(float x, float y, float z, ulong height_ptr)
        {
            return Invoker.Call<bool>(0x8EE6B53CE13A9794, x, y, z, height_ptr);
        }

        public static bool TEST_PROBE_AGAINST_WATER(float x1, float y1, float z1, float x2, float y2, float z2, ulong result_ptr)
        {
            return Invoker.Call<bool>(0xFFA5D878809819DB, x1, y1, z1, x2, y2, z2, result_ptr);
        }

        public static bool TEST_PROBE_AGAINST_ALL_WATER(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7)
        {
            return Invoker.Call<bool>(0x8974647ED222EA5F, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static bool TEST_VERTICAL_PROBE_AGAINST_ALL_WATER(float x, float y, float z, int p3, ulong height_ptr)
        {
            return Invoker.Call<bool>(0x2B3451FA1E3142E2, x, y, z, p3, height_ptr);
        }

        public static void MODIFY_WATER(float x, float y, float radius, float height)
        {
            Invoker.Call<Void>(0xC443FD757C3BA637, x, y, radius, height);
        }

        public static int _ADD_CURRENT_RISE(float xLow, float yLow, float xHigh, float yHigh, float height)
        {
            return Invoker.Call<int>(0xFDBF4CDBC07E1706, xLow, yLow, xHigh, yHigh, height);
        }

        public static void _REMOVE_CURRENT_RISE(int p0)
        {
            Invoker.Call<Void>(0xB1252E3E59A82AAF, p0);
        }

        public static void _SET_CURRENT_INTENSITY(float intensity)
        {
            Invoker.Call<Void>(0xB96B00E976BE977F, intensity);
        }

        public static float _GET_CURRENT_INTENSITY()
        {
            return Invoker.Call<float>(0x2B2A2CC86778B619);
        }

        public static void _RESET_CURRENT_INTENSITY()
        {
            Invoker.Call<Void>(0x5E5E99285AE812DB);
        }

    }

    public static class WORLDPROBE
    {

        public static int START_SHAPE_TEST_LOS_PROBE(float x1, float y1, float z1, float x2, float y2, float z2, int flags, int ent, int p8)
        {
            return Invoker.Call<int>(0x7EE9F5D83DD4F90E, x1, y1, z1, x2, y2, z2, flags, ent, p8);
        }

        public static int _START_SHAPE_TEST_RAY(float x1, float y1, float z1, float x2, float y2, float z2, int flags, int entity, int p8)
        {
            return Invoker.Call<int>(0x377906D8A31E5586, x1, y1, z1, x2, y2, z2, flags, entity, p8);
        }

        public static int START_SHAPE_TEST_BOUNDING_BOX(int entity, int flags1, int flags2)
        {
            return Invoker.Call<int>(0x052837721A854EC7, entity, flags1, flags2);
        }

        public static int START_SHAPE_TEST_BOX(float x, float y, float z, float x1, float y2, float z2, float rotX, float rotY, float rotZ, int p9, int p10, int entity, int p12)
        {
            return Invoker.Call<int>(0xFE466162C4401D18, x, y, z, x1, y2, z2, rotX, rotY, rotZ, p9, p10, entity, p12);
        }

        public static int START_SHAPE_TEST_BOUND(int entity, int flags1, int flags2)
        {
            return Invoker.Call<int>(0x37181417CE7C8900, entity, flags1, flags2);
        }

        public static int START_SHAPE_TEST_CAPSULE(float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, int entity, int p9)
        {
            return Invoker.Call<int>(0x28579D1B8F8AAC80, x1, y1, z1, x2, y2, z2, radius, flags, entity, p9);
        }

        public static int _START_SHAPE_TEST_CAPSULE_2(float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, int entity, int p9)
        {
            return Invoker.Call<int>(0xE6AC6C45FBE83004, x1, y1, z1, x2, y2, z2, radius, flags, entity, p9);
        }

        public static int _START_SHAPE_TEST_SURROUNDING_COORDS(ulong pVec1_ptr, ulong pVec2_ptr, int flag, int entity, int flag2)
        {
            return Invoker.Call<int>(0xFF6BE494C7987F34, pVec1_ptr, pVec2_ptr, flag, entity, flag2);
        }

        public static int GET_SHAPE_TEST_RESULT(int rayHandle, ulong hit_ptr, ulong endCoords_ptr, ulong surfaceNormal_ptr, ulong entityHit_ptr)
        {
            return Invoker.Call<int>(0x3D87450E15D98694, rayHandle, hit_ptr, endCoords_ptr, surfaceNormal_ptr, entityHit_ptr);
        }

        public static int _GET_SHAPE_TEST_RESULT_EX(int rayHandle, ulong hit_ptr, ulong endCoords_ptr, ulong surfaceNormal_ptr, ulong materialHash_ptr, ulong entityHit_ptr)
        {
            return Invoker.Call<int>(0x65287525D951F6BE, rayHandle, hit_ptr, endCoords_ptr, surfaceNormal_ptr, materialHash_ptr, entityHit_ptr);
        }

        public static void _SHAPE_TEST_RESULT_ENTITY(int entityHit)
        {
            Invoker.Call<Void>(0x2B3334BCA57CD799, entityHit);
        }

    }

    public static class NETWORK
    {

        public static bool NETWORK_IS_SIGNED_IN()
        {
            return Invoker.Call<bool>(0x054354A99211EB96);
        }

        public static bool NETWORK_IS_SIGNED_ONLINE()
        {
            return Invoker.Call<bool>(0x1077788E268557C2);
        }

        public static bool _0xBD545D44CCE70597()
        {
            return Invoker.Call<bool>(0xBD545D44CCE70597);
        }

        public static int _0xEBCAB9E5048434F4()
        {
            return Invoker.Call<int>(0xEBCAB9E5048434F4);
        }

        public static int _0x74FB3E29E6D10FA9()
        {
            return Invoker.Call<int>(0x74FB3E29E6D10FA9);
        }

        public static int _0x7808619F31FF22DB()
        {
            return Invoker.Call<int>(0x7808619F31FF22DB);
        }

        public static int _0xA0FA4EC6A05DA44E()
        {
            return Invoker.Call<int>(0xA0FA4EC6A05DA44E);
        }

        public static bool _NETWORK_ARE_ROS_AVAILABLE()
        {
            return Invoker.Call<bool>(0x85443FF4C328F53B);
        }

        public static bool _NETWORK_IS_PSN_AVAILABLE()
        {
            return Invoker.Call<bool>(0x8D11E61A4ABF49CC);
        }

        public static bool NETWORK_IS_CLOUD_AVAILABLE()
        {
            return Invoker.Call<bool>(0x9A4CF4F48AD77302);
        }

        public static bool _0x67A5589628E0CFF6()
        {
            return Invoker.Call<bool>(0x67A5589628E0CFF6);
        }

        public static int _0xBA9775570DB788CF()
        {
            return Invoker.Call<int>(0xBA9775570DB788CF);
        }

        public static bool NETWORK_IS_HOST()
        {
            return Invoker.Call<bool>(0x8DB296B814EDDA07);
        }

        public static int _0xA306F470D1660581()
        {
            return Invoker.Call<int>(0xA306F470D1660581);
        }

        public static bool _0x4237E822315D8BA9()
        {
            return Invoker.Call<bool>(0x4237E822315D8BA9);
        }

        public static bool NETWORK_HAVE_ONLINE_PRIVILEGES()
        {
            return Invoker.Call<bool>(0x25CB5A9F37BFD063);
        }

        public static bool _0x1353F87E89946207()
        {
            return Invoker.Call<bool>(0x1353F87E89946207);
        }

        public static bool _0x72D918C99BCACC54(int p0)
        {
            return Invoker.Call<bool>(0x72D918C99BCACC54, p0);
        }

        public static bool _0xAEEF48CDF5B6CE7C(int p0, int p1)
        {
            return Invoker.Call<bool>(0xAEEF48CDF5B6CE7C, p0, p1);
        }

        public static bool _0x78321BEA235FD8CD(int p0, bool p1)
        {
            return Invoker.Call<bool>(0x78321BEA235FD8CD, p0, p1);
        }

        public static bool _0x595F028698072DD9(int p0, int p1, bool p2)
        {
            return Invoker.Call<bool>(0x595F028698072DD9, p0, p1, p2);
        }

        public static bool _0x83F28CE49FBBFFBA(int p0, int p1, bool p2)
        {
            return Invoker.Call<bool>(0x83F28CE49FBBFFBA, p0, p1, p2);
        }

        public static ulong _0x76BF03FADBF154F5()
        {
            return Invoker.Call<ulong>(0x76BF03FADBF154F5);
        }

        public static int _0x9614B71F8ADB982B()
        {
            return Invoker.Call<int>(0x9614B71F8ADB982B);
        }

        public static int _0x5EA784D197556507()
        {
            return Invoker.Call<int>(0x5EA784D197556507);
        }

        public static int _0xA8ACB6459542A8C8()
        {
            return Invoker.Call<int>(0xA8ACB6459542A8C8);
        }

        public static void _0x83FE8D7229593017()
        {
            Invoker.Call<Void>(0x83FE8D7229593017);
        }

        public static bool NETWORK_CAN_BAIL()
        {
            return Invoker.Call<bool>(0x580CE4438479CC61);
        }

        public static void NETWORK_BAIL()
        {
            Invoker.Call<Void>(0x95914459A87EBA28);
        }

        public static void _0x283B6062A2C01E9B()
        {
            Invoker.Call<Void>(0x283B6062A2C01E9B);
        }

        public static bool NETWORK_CAN_ACCESS_MULTIPLAYER(ulong loadingState_ptr)
        {
            return Invoker.Call<bool>(0xAF50DA1A3F8B1BA4, loadingState_ptr);
        }

        public static int NETWORK_IS_MULTIPLAYER_DISABLED()
        {
            return Invoker.Call<int>(0x9747292807126EDA);
        }

        public static bool NETWORK_CAN_ENTER_MULTIPLAYER()
        {
            return Invoker.Call<bool>(0x7E782A910C362C25);
        }

        public static int NETWORK_SESSION_ENTER(int p0, int p1, int p2, int maxPlayers, int p4, int p5)
        {
            return Invoker.Call<int>(0x330ED4D05491934F, p0, p1, p2, maxPlayers, p4, p5);
        }

        public static bool NETWORK_SESSION_FRIEND_MATCHMAKING(int p0, int p1, int maxPlayers, bool p3)
        {
            return Invoker.Call<bool>(0x2CFC76E0D087C994, p0, p1, maxPlayers, p3);
        }

        public static bool NETWORK_SESSION_CREW_MATCHMAKING(int p0, int p1, int p2, int maxPlayers, bool p4)
        {
            return Invoker.Call<bool>(0x94BC51E9449D917F, p0, p1, p2, maxPlayers, p4);
        }

        public static bool NETWORK_SESSION_ACTIVITY_QUICKMATCH(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<bool>(0xBE3E347A87ACEB82, p0, p1, p2, p3);
        }

        public static bool NETWORK_SESSION_HOST(int p0, int maxPlayers, bool p2)
        {
            return Invoker.Call<bool>(0x6F3D4ED9BEE4E61D, p0, maxPlayers, p2);
        }

        public static bool NETWORK_SESSION_HOST_CLOSED(int p0, int maxPlayers)
        {
            return Invoker.Call<bool>(0xED34C0C02C098BB7, p0, maxPlayers);
        }

        public static bool NETWORK_SESSION_HOST_FRIENDS_ONLY(int p0, int maxPlayers)
        {
            return Invoker.Call<bool>(0xB9CFD27A5D578D83, p0, maxPlayers);
        }

        public static bool NETWORK_SESSION_IS_CLOSED_FRIENDS()
        {
            return Invoker.Call<bool>(0xFBCFA2EA2E206890);
        }

        public static bool NETWORK_SESSION_IS_CLOSED_CREW()
        {
            return Invoker.Call<bool>(0x74732C6CA90DA2B4);
        }

        public static bool NETWORK_SESSION_IS_SOLO()
        {
            return Invoker.Call<bool>(0xF3929C2379B60CCE);
        }

        public static bool NETWORK_SESSION_IS_PRIVATE()
        {
            return Invoker.Call<bool>(0xCEF70AA5B3F89BA1);
        }

        public static bool NETWORK_SESSION_END(bool p0, bool p1)
        {
            return Invoker.Call<bool>(0xA02E59562D711006, p0, p1);
        }

        public static void NETWORK_SESSION_KICK_PLAYER(int player)
        {
            Invoker.Call<Void>(0xFA8904DC5F304220, player);
        }

        public static bool _NETWORK_SESSION_IS_PLAYER_VOTED_TO_KICK(int player)
        {
            return Invoker.Call<bool>(0xD6D09A6F32F49EF1, player);
        }

        public static int _0x59DF79317F85A7E0()
        {
            return Invoker.Call<int>(0x59DF79317F85A7E0);
        }

        public static int _0xFFE1E5B792D92B34()
        {
            return Invoker.Call<int>(0xFFE1E5B792D92B34);
        }

        public static void _NETWORK_SCTV_SLOTS(int p0)
        {
            Invoker.Call<Void>(0x49EC8030F5015F8B, p0);
        }

        public static void _NETWORK_SESSION_SET_MAX_PLAYERS(int playerType, int playerCount)
        {
            Invoker.Call<Void>(0x8B6A4DD0AF9CE215, playerType, playerCount);
        }

        public static int _NETWORK_SESSION_GET_UNK(int p0)
        {
            return Invoker.Call<int>(0x56CE820830EF040B, p0);
        }

        public static void _0xCAE55F48D3D7875C(int p0)
        {
            Invoker.Call<Void>(0xCAE55F48D3D7875C, p0);
        }

        public static void _0xF49ABC20D8552257(int p0)
        {
            Invoker.Call<Void>(0xF49ABC20D8552257, p0);
        }

        public static void _0x4811BBAC21C5FCD5(int p0)
        {
            Invoker.Call<Void>(0x4811BBAC21C5FCD5, p0);
        }

        public static void _0x5539C3EBF104A53A(bool p0)
        {
            Invoker.Call<Void>(0x5539C3EBF104A53A, p0);
        }

        public static void _0x702BC4D605522539(int p0)
        {
            Invoker.Call<Void>(0x702BC4D605522539, p0);
        }

        public static void _0x3F52E880AAF6C8CA(bool p0)
        {
            Invoker.Call<Void>(0x3F52E880AAF6C8CA, p0);
        }

        public static void _0xF1EEA2DDA9FFA69D(int p0)
        {
            Invoker.Call<Void>(0xF1EEA2DDA9FFA69D, p0);
        }

        public static void _0x1153FA02A659051C()
        {
            Invoker.Call<Void>(0x1153FA02A659051C);
        }

        public static void _NETWORK_SESSION_HOSTED(bool p0)
        {
            Invoker.Call<Void>(0xC19F6C8E7865A6FF, p0);
        }

        public static void NETWORK_ADD_FOLLOWERS(ulong p0_ptr, int p1)
        {
            Invoker.Call<Void>(0x236406F60CF216D6, p0_ptr, p1);
        }

        public static void NETWORK_CLEAR_FOLLOWERS()
        {
            Invoker.Call<Void>(0x058F43EC59A8631A);
        }

        public static void _NETWORK_GET_SERVER_TIME(ulong hours_ptr, ulong minutes_ptr, ulong seconds_ptr)
        {
            Invoker.Call<Void>(0x6D03BFBD643B2A02, hours_ptr, minutes_ptr, seconds_ptr);
        }

        public static void _0x600F8CB31C7AAB6E(int p0)
        {
            Invoker.Call<Void>(0x600F8CB31C7AAB6E, p0);
        }

        public static bool NETWORK_X_AFFECTS_GAMERS(int p0)
        {
            return Invoker.Call<bool>(0xE532D6811B3A4D2A, p0);
        }

        public static bool NETWORK_FIND_MATCHED_GAMERS(int p0, float p1, float p2, float p3)
        {
            return Invoker.Call<bool>(0xF7B2CFDE5C9F700D, p0, p1, p2, p3);
        }

        public static bool NETWORK_IS_FINDING_GAMERS()
        {
            return Invoker.Call<bool>(0xDDDF64C91BFCF0AA);
        }

        public static int _0xF9B83B77929D8863()
        {
            return Invoker.Call<int>(0xF9B83B77929D8863);
        }

        public static int NETWORK_GET_NUM_FOUND_GAMERS()
        {
            return Invoker.Call<int>(0xA1B043EE79A916FB);
        }

        public static bool NETWORK_GET_FOUND_GAMER(ulong p0_ptr, int p1)
        {
            return Invoker.Call<bool>(0x9DCFF2AFB68B3476, p0_ptr, p1);
        }

        public static void NETWORK_CLEAR_FOUND_GAMERS()
        {
            Invoker.Call<Void>(0x6D14CCEE1B40381A);
        }

        public static bool _0x85A0EF54A500882C(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x85A0EF54A500882C, p0_ptr);
        }

        public static int _0x2CC848A861D01493()
        {
            return Invoker.Call<int>(0x2CC848A861D01493);
        }

        public static int _0x94A8394D150B013A()
        {
            return Invoker.Call<int>(0x94A8394D150B013A);
        }

        public static int _0x5AE17C6B0134B7F1()
        {
            return Invoker.Call<int>(0x5AE17C6B0134B7F1);
        }

        public static bool _0x02A8BEC6FD9AF660(ulong p0_ptr, int p1)
        {
            return Invoker.Call<bool>(0x02A8BEC6FD9AF660, p0_ptr, p1);
        }

        public static void _0x86E0660E4F5C956D()
        {
            Invoker.Call<Void>(0x86E0660E4F5C956D);
        }

        public static void NETWORK_IS_PLAYER_ANIMATION_DRAWING_SYNCHRONIZED()
        {
            Invoker.Call<Void>(0xC6F8AB8A4189CF3A);
        }

        public static void NETWORK_SESSION_CANCEL_INVITE()
        {
            Invoker.Call<Void>(0x2FBF47B1B36D36F9);
        }

        public static void NETWORK_SESSION_FORCE_CANCEL_INVITE()
        {
            Invoker.Call<Void>(0xA29177F7703B5644);
        }

        public static bool NETWORK_HAS_PENDING_INVITE()
        {
            return Invoker.Call<bool>(0xAC8C7B9B88C4A668);
        }

        public static int _0xC42DD763159F3461()
        {
            return Invoker.Call<int>(0xC42DD763159F3461);
        }

        public static int _0x62A0296C1BB1CEB3()
        {
            return Invoker.Call<int>(0x62A0296C1BB1CEB3);
        }

        public static bool NETWORK_SESSION_WAS_INVITED()
        {
            return Invoker.Call<bool>(0x23DFB504655D0CE4);
        }

        public static void NETWORK_SESSION_GET_INVITER(ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0xE57397B4A3429DD0, networkHandle_ptr);
        }

        public static int _0xD313DE83394AF134()
        {
            return Invoker.Call<int>(0xD313DE83394AF134);
        }

        public static int _0xBDB6F89C729CF388()
        {
            return Invoker.Call<int>(0xBDB6F89C729CF388);
        }

        public static void NETWORK_SUPPRESS_INVITE(bool toggle)
        {
            Invoker.Call<Void>(0xA0682D67EF1FBA3D, toggle);
        }

        public static void NETWORK_BLOCK_INVITES(bool toggle)
        {
            Invoker.Call<Void>(0x34F9E9049454A7A0, toggle);
        }

        public static void _0xCFEB8AF24FC1D0BB(bool p0)
        {
            Invoker.Call<Void>(0xCFEB8AF24FC1D0BB, p0);
        }

        public static void _0xF814FEC6A19FD6E0()
        {
            Invoker.Call<Void>(0xF814FEC6A19FD6E0);
        }

        public static void _NETWORK_BLOCK_KICKED_PLAYERS(bool p0)
        {
            Invoker.Call<Void>(0x6B07B9CE4D390375, p0);
        }

        public static void _0x7AC752103856FB20(bool p0)
        {
            Invoker.Call<Void>(0x7AC752103856FB20, p0);
        }

        public static int _0x74698374C45701D2()
        {
            return Invoker.Call<int>(0x74698374C45701D2);
        }

        public static void _0x140E6A44870A11CE()
        {
            Invoker.Call<Void>(0x140E6A44870A11CE);
        }

        public static void NETWORK_SESSION_HOST_SINGLE_PLAYER(int p0)
        {
            Invoker.Call<Void>(0xC74C33FCA52856D5, p0);
        }

        public static void NETWORK_SESSION_LEAVE_SINGLE_PLAYER()
        {
            Invoker.Call<Void>(0x3442775428FD2DAA);
        }

        public static bool NETWORK_IS_GAME_IN_PROGRESS()
        {
            return Invoker.Call<bool>(0x10FAB35428CCC9D7);
        }

        public static bool NETWORK_IS_SESSION_ACTIVE()
        {
            return Invoker.Call<bool>(0xD83C2B94E7508980);
        }

        public static bool NETWORK_IS_IN_SESSION()
        {
            return Invoker.Call<bool>(0xCA97246103B63917);
        }

        public static bool NETWORK_IS_SESSION_STARTED()
        {
            return Invoker.Call<bool>(0x9DE624D2FC4B603F);
        }

        public static bool NETWORK_IS_SESSION_BUSY()
        {
            return Invoker.Call<bool>(0xF4435D66A8E2905E);
        }

        public static bool NETWORK_CAN_SESSION_END()
        {
            return Invoker.Call<bool>(0x4EEBC3694E49C572);
        }

        public static void NETWORK_SESSION_MARK_VISIBLE(bool p0)
        {
            Invoker.Call<Void>(0x271CC6AB59EBF9A5, p0);
        }

        public static bool NETWORK_SESSION_IS_VISIBLE()
        {
            return Invoker.Call<bool>(0xBA416D68C631496A);
        }

        public static void NETWORK_SESSION_BLOCK_JOIN_REQUESTS(bool p0)
        {
            Invoker.Call<Void>(0xA73667484D7037C3, p0);
        }

        public static void NETWORK_SESSION_CHANGE_SLOTS(int p0, bool p1)
        {
            Invoker.Call<Void>(0xB4AB419E0D86ACAE, p0, p1);
        }

        public static int _0x53AFD64C6758F2F9()
        {
            return Invoker.Call<int>(0x53AFD64C6758F2F9);
        }

        public static void NETWORK_SESSION_VOICE_HOST()
        {
            Invoker.Call<Void>(0x9C1556705F864230);
        }

        public static void NETWORK_SESSION_VOICE_LEAVE()
        {
            Invoker.Call<Void>(0x6793E42BE02B575D);
        }

        public static void _NETWORK_VOICE_CONNECT_TO_PLAYER(ulong globalPtr_ptr)
        {
            Invoker.Call<Void>(0xABD5E88B8A2D3DB2, globalPtr_ptr);
        }

        public static void NETWORK_SET_KEEP_FOCUSPOINT(bool p0, int p1)
        {
            Invoker.Call<Void>(0x7F8413B7FC2AA6B9, p0, p1);
        }

        public static void _0x5B8ED3DB018927B1(int p0)
        {
            Invoker.Call<Void>(0x5B8ED3DB018927B1, p0);
        }

        public static bool _0x855BC38818F6F684()
        {
            return Invoker.Call<bool>(0x855BC38818F6F684);
        }

        public static int _0xB5D3453C98456528()
        {
            return Invoker.Call<int>(0xB5D3453C98456528);
        }

        public static bool _0xEF0912DDF7C4CB4B()
        {
            return Invoker.Call<bool>(0xEF0912DDF7C4CB4B);
        }

        public static bool NETWORK_SEND_TEXT_MESSAGE(string message, ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x3A214F2EC889B100, message, networkHandle_ptr);
        }

        public static void NETWORK_SET_ACTIVITY_SPECTATOR(bool toggle)
        {
            Invoker.Call<Void>(0x75138790B4359A74, toggle);
        }

        public static int NETWORK_IS_ACTIVITY_SPECTATOR()
        {
            return Invoker.Call<int>(0x12103B9E0C9F92FB);
        }

        public static void NETWORK_SET_ACTIVITY_SPECTATOR_MAX(int maxSpectators)
        {
            Invoker.Call<Void>(0x9D277B76D1D12222, maxSpectators);
        }

        public static int NETWORK_GET_ACTIVITY_PLAYER_NUM(bool p0)
        {
            return Invoker.Call<int>(0x73E2B500410DA5A2, p0);
        }

        public static bool NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x2763BBAA72A7BCB9, networkHandle_ptr);
        }

        public static int NETWORK_HOST_TRANSITION(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            return Invoker.Call<int>(0xA60BB5CE242BB254, p0, p1, p2, p3, p4, p5);
        }

        public static bool NETWORK_DO_TRANSITION_QUICKMATCH(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<bool>(0x71FB0EBCD4915D56, p0, p1, p2, p3);
        }

        public static bool NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<bool>(0xA091A5E44F0072E5, p0, p1, p2, p3);
        }

        public static bool NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP(int p0, int p1, int p2, int p3, ulong p4_ptr, int p5)
        {
            return Invoker.Call<bool>(0x9C4AB58491FDC98A, p0, p1, p2, p3, p4_ptr, p5);
        }

        public static int NETWORK_JOIN_GROUP_ACTIVITY()
        {
            return Invoker.Call<int>(0xA06509A691D12BE4);
        }

        public static void _0xB13E88E655E5A3BC()
        {
            Invoker.Call<Void>(0xB13E88E655E5A3BC);
        }

        public static int _0x6512765E3BE78C50()
        {
            return Invoker.Call<int>(0x6512765E3BE78C50);
        }

        public static int _0x0DBD5D7E3C5BEC3B()
        {
            return Invoker.Call<int>(0x0DBD5D7E3C5BEC3B);
        }

        public static bool _0x5DC577201723960A()
        {
            return Invoker.Call<bool>(0x5DC577201723960A);
        }

        public static bool _0x5A6AA44FF8E931E6()
        {
            return Invoker.Call<bool>(0x5A6AA44FF8E931E6);
        }

        public static void _0x261E97AD7BCF3D40(bool p0)
        {
            Invoker.Call<Void>(0x261E97AD7BCF3D40, p0);
        }

        public static void _0x39917E1B4CB0F911(bool p0)
        {
            Invoker.Call<Void>(0x39917E1B4CB0F911, p0);
        }

        public static void NETWORK_SET_TRANSITION_CREATOR_HANDLE(ulong p0_ptr)
        {
            Invoker.Call<Void>(0xEF26739BCD9907D5, p0_ptr);
        }

        public static void NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE()
        {
            Invoker.Call<Void>(0xFB3272229A82C759);
        }

        public static bool NETWORK_INVITE_GAMERS_TO_TRANSITION(ulong p0_ptr, int p1)
        {
            return Invoker.Call<bool>(0x4A595C32F77DFF76, p0_ptr, p1);
        }

        public static void NETWORK_SET_GAMER_INVITED_TO_TRANSITION(ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0xCA2C8073411ECDB6, networkHandle_ptr);
        }

        public static int NETWORK_LEAVE_TRANSITION()
        {
            return Invoker.Call<int>(0xD23A1A815D21DB19);
        }

        public static int NETWORK_LAUNCH_TRANSITION()
        {
            return Invoker.Call<int>(0x2DCF46CB1A4F0884);
        }

        public static void _0xA2E9C1AB8A92E8CD(bool p0)
        {
            Invoker.Call<Void>(0xA2E9C1AB8A92E8CD, p0);
        }

        public static void NETWORK_BAIL_TRANSITION()
        {
            Invoker.Call<Void>(0xEAA572036990CD1B);
        }

        public static bool NETWORK_DO_TRANSITION_TO_GAME(bool p0, int maxPlayers)
        {
            return Invoker.Call<bool>(0x3E9BB38102A589B0, p0, maxPlayers);
        }

        public static bool NETWORK_DO_TRANSITION_TO_NEW_GAME(bool p0, int maxPlayers, bool p2)
        {
            return Invoker.Call<bool>(0x4665F51EFED00034, p0, maxPlayers, p2);
        }

        public static bool NETWORK_DO_TRANSITION_TO_FREEMODE(ulong p0_ptr, int p1, bool p2, int players, bool p4)
        {
            return Invoker.Call<bool>(0x3AAD8B2FCA1E289F, p0_ptr, p1, p2, players, p4);
        }

        public static bool NETWORK_DO_TRANSITION_TO_NEW_FREEMODE(ulong p0_ptr, ulong p1_ptr, int players, bool p3, bool p4, bool p5)
        {
            return Invoker.Call<bool>(0x9E80A5BA8109F974, p0_ptr, p1_ptr, players, p3, p4, p5);
        }

        public static int NETWORK_IS_TRANSITION_TO_GAME()
        {
            return Invoker.Call<int>(0x9D7696D8F4FA6CB7);
        }

        public static int NETWORK_GET_TRANSITION_MEMBERS(ulong p0_ptr, int p1)
        {
            return Invoker.Call<int>(0x73B000F7FBC55829, p0_ptr, p1);
        }

        public static void NETWORK_APPLY_TRANSITION_PARAMETER(int p0, int p1)
        {
            Invoker.Call<Void>(0x521638ADA1BA0D18, p0, p1);
        }

        public static void _0xEBEFC2E77084F599(int p0, string p1, bool p2)
        {
            Invoker.Call<Void>(0xEBEFC2E77084F599, p0, p1, p2);
        }

        public static bool NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION(ulong networkHandle_ptr, string p1, int p2, int p3, bool p4)
        {
            return Invoker.Call<bool>(0x31D1D2B858D25E6B, networkHandle_ptr, p1, p2, p3, p4);
        }

        public static bool NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x5728BB6D63E3FF1D, p0_ptr);
        }

        public static int NETWORK_IS_TRANSITION_HOST()
        {
            return Invoker.Call<int>(0x0B824797C9BF2159);
        }

        public static bool NETWORK_IS_TRANSITION_HOST_FROM_HANDLE(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x6B5C83BA3EFE6A10, networkHandle_ptr);
        }

        public static bool NETWORK_GET_TRANSITION_HOST(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x65042B9774C4435E, networkHandle_ptr);
        }

        public static bool NETWORK_IS_IN_TRANSITION()
        {
            return Invoker.Call<bool>(0x68049AEFF83D8F0A);
        }

        public static bool NETWORK_IS_TRANSITION_STARTED()
        {
            return Invoker.Call<bool>(0x53FA83401D9C07FE);
        }

        public static int NETWORK_IS_TRANSITION_BUSY()
        {
            return Invoker.Call<int>(0x520F3282A53D26B7);
        }

        public static int NETWORK_IS_TRANSITION_MATCHMAKING()
        {
            return Invoker.Call<int>(0x292564C735375EDF);
        }

        public static int _0xC571D0E77D8BBC29()
        {
            return Invoker.Call<int>(0xC571D0E77D8BBC29);
        }

        public static void NETWORK_OPEN_TRANSITION_MATCHMAKING()
        {
            Invoker.Call<Void>(0x2B3A8F7CA3A38FDE);
        }

        public static void NETWORK_CLOSE_TRANSITION_MATCHMAKING()
        {
            Invoker.Call<Void>(0x43F4DBA69710E01E);
        }

        public static int _0x37A4494483B9F5C9()
        {
            return Invoker.Call<int>(0x37A4494483B9F5C9);
        }

        public static void _0x0C978FDA19692C2C(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x0C978FDA19692C2C, p0, p1);
        }

        public static int _0xD0A484CB2F829FBE()
        {
            return Invoker.Call<int>(0xD0A484CB2F829FBE);
        }

        public static void NETWORK_SET_TRANSITION_ACTIVITY_ID(int p0)
        {
            Invoker.Call<Void>(0x30DE938B516F0AD2, p0);
        }

        public static void NETWORK_CHANGE_TRANSITION_SLOTS(int p0, int p1)
        {
            Invoker.Call<Void>(0xEEEDA5E6D7080987, p0, p1);
        }

        public static void _0x973D76AA760A6CB6(bool p0)
        {
            Invoker.Call<Void>(0x973D76AA760A6CB6, p0);
        }

        public static bool NETWORK_HAS_PLAYER_STARTED_TRANSITION(int player)
        {
            return Invoker.Call<bool>(0x9AC9CCBFA8C29795, player);
        }

        public static bool NETWORK_ARE_TRANSITION_DETAILS_VALID(int p0)
        {
            return Invoker.Call<bool>(0x2615AA2A695930C1, p0);
        }

        public static bool NETWORK_JOIN_TRANSITION(int player)
        {
            return Invoker.Call<bool>(0x9D060B08CD63321A, player);
        }

        public static bool NETWORK_HAS_INVITED_GAMER_TO_TRANSITION(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x7284A47B3540E6CF, p0_ptr);
        }

        public static bool _0x3F9990BF5F22759C(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x3F9990BF5F22759C, p0_ptr);
        }

        public static bool NETWORK_IS_ACTIVITY_SESSION()
        {
            return Invoker.Call<bool>(0x05095437424397FA);
        }

        public static void _NETWORK_BLOCK_INVITES_2(bool p0)
        {
            Invoker.Call<Void>(0x4A9FDE3A5A6D0437, p0);
        }

        public static bool _NETWORK_SEND_PRESENCE_INVITE(ulong networkHandle_ptr, ulong p1_ptr, int p2, int p3)
        {
            return Invoker.Call<bool>(0xC3C7A6AFDB244624, networkHandle_ptr, p1_ptr, p2, p3);
        }

        public static bool _NETWORK_SEND_PRESENCE_TRANSITION_INVITE(ulong p0_ptr, ulong p1_ptr, int p2, int p3)
        {
            return Invoker.Call<bool>(0xC116FF9B4D488291, p0_ptr, p1_ptr, p2, p3);
        }

        public static bool _0x1171A97A3D3981B6(ulong p0_ptr, ulong p1_ptr, int p2, int p3)
        {
            return Invoker.Call<bool>(0x1171A97A3D3981B6, p0_ptr, p1_ptr, p2, p3);
        }

        public static int _0x742B58F723233ED9(int p0)
        {
            return Invoker.Call<int>(0x742B58F723233ED9, p0);
        }

        public static int NETWORK_GET_NUM_PRESENCE_INVITES()
        {
            return Invoker.Call<int>(0xCEFA968912D0F78D);
        }

        public static bool NETWORK_ACCEPT_PRESENCE_INVITE(int p0)
        {
            return Invoker.Call<bool>(0xFA91550DF9318B22, p0);
        }

        public static bool NETWORK_REMOVE_PRESENCE_INVITE(int p0)
        {
            return Invoker.Call<bool>(0xF0210268DB0974B1, p0);
        }

        public static int NETWORK_GET_PRESENCE_INVITE_ID(int p0)
        {
            return Invoker.Call<int>(0xDFF09646E12EC386, p0);
        }

        public static int NETWORK_GET_PRESENCE_INVITE_INVITER(int p0)
        {
            return Invoker.Call<int>(0x4962CC4AA2F345B7, p0);
        }

        public static bool NETWORK_GET_PRESENCE_INVITE_HANDLE(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x38D5B0FEBB086F75, p0, p1_ptr);
        }

        public static int NETWORK_GET_PRESENCE_INVITE_SESSION_ID(int p0)
        {
            return Invoker.Call<int>(0x26E1CD96B0903D60, p0);
        }

        public static int _0x24409FC4C55CB22D(int p0)
        {
            return Invoker.Call<int>(0x24409FC4C55CB22D, p0);
        }

        public static int _0xD39B3FFF8FFDD5BF(int p0)
        {
            return Invoker.Call<int>(0xD39B3FFF8FFDD5BF, p0);
        }

        public static int _0x728C4CC7920CD102(int p0)
        {
            return Invoker.Call<int>(0x728C4CC7920CD102, p0);
        }

        public static bool _0x3DBF2DF0AEB7D289(int p0)
        {
            return Invoker.Call<bool>(0x3DBF2DF0AEB7D289, p0);
        }

        public static bool _0x8806CEBFABD3CE05(int p0)
        {
            return Invoker.Call<bool>(0x8806CEBFABD3CE05, p0);
        }

        public static bool NETWORK_HAS_FOLLOW_INVITE()
        {
            return Invoker.Call<bool>(0x76D9B976C4C09FDE);
        }

        public static int NETWORK_ACTION_FOLLOW_INVITE()
        {
            return Invoker.Call<int>(0xC88156EBB786F8D5);
        }

        public static int NETWORK_CLEAR_FOLLOW_INVITE()
        {
            return Invoker.Call<int>(0x439BFDE3CD0610F6);
        }

        public static void _0xEBF8284D8CADEB53()
        {
            Invoker.Call<Void>(0xEBF8284D8CADEB53);
        }

        public static void NETWORK_REMOVE_TRANSITION_INVITE(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x7524B431B2E6F7EE, p0_ptr);
        }

        public static void NETWORK_REMOVE_ALL_TRANSITION_INVITE()
        {
            Invoker.Call<Void>(0x726E0375C7A26368);
        }

        public static void _0xF083835B70BA9BFE()
        {
            Invoker.Call<Void>(0xF083835B70BA9BFE);
        }

        public static bool NETWORK_INVITE_GAMERS(ulong p0_ptr, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0x9D80CD1D0E6327DE, p0_ptr, p1, p2_ptr, p3_ptr);
        }

        public static bool NETWORK_HAS_INVITED_GAMER(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x4D86CD31E8976ECE, p0_ptr);
        }

        public static bool NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x74881E6BCAE2327C, p0_ptr);
        }

        public static bool NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x7206F674F2A3B1BB, p0_ptr);
        }

        public static void _0x66F010A4B031A331(ulong p0_ptr)
        {
            Invoker.Call<Void>(0x66F010A4B031A331, p0_ptr);
        }

        public static bool _0x44B37CDCAE765AAE(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x44B37CDCAE765AAE, p0, p1_ptr);
        }

        public static void _0x0D77A82DC2D0DA59(ulong p0_ptr, ulong p1_ptr)
        {
            Invoker.Call<Void>(0x0D77A82DC2D0DA59, p0_ptr, p1_ptr);
        }

        public static bool FILLOUT_PM_PLAYER_LIST(ulong networkHandle_ptr, int p1, int p2)
        {
            return Invoker.Call<bool>(0xCBBD7C4991B64809, networkHandle_ptr, p1, p2);
        }

        public static bool FILLOUT_PM_PLAYER_LIST_WITH_NAMES(ulong p0_ptr, ulong p1_ptr, int p2, int p3)
        {
            return Invoker.Call<bool>(0x716B6DB9D1886106, p0_ptr, p1_ptr, p2, p3);
        }

        public static bool USING_NETWORK_WEAPONTYPE(int p0)
        {
            return Invoker.Call<bool>(0xE26CCFF8094D8C74, p0);
        }

        public static bool _NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x796A87B3B68D1F3D, p0_ptr);
        }

        public static int _0x2FC5650B0271CB57()
        {
            return Invoker.Call<int>(0x2FC5650B0271CB57);
        }

        public static int _0x01ABCE5E7CBDA196()
        {
            return Invoker.Call<int>(0x01ABCE5E7CBDA196);
        }

        public static int _0x120364DE2845DAF8(ulong p0_ptr, int p1)
        {
            return Invoker.Call<int>(0x120364DE2845DAF8, p0_ptr, p1);
        }

        public static int _0xFD8B834A8BA05048()
        {
            return Invoker.Call<int>(0xFD8B834A8BA05048);
        }

        public static bool NETWORK_IS_CHATTING_IN_PLATFORM_PARTY(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x8DE9945BCC9AEC52, networkHandle_ptr);
        }

        public static bool NETWORK_IS_IN_PARTY()
        {
            return Invoker.Call<bool>(0x966C2BC2A7FE3F30);
        }

        public static bool NETWORK_IS_PARTY_MEMBER(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x676ED266AADD31E0, networkHandle_ptr);
        }

        public static int _0x2BF66D2E7414F686()
        {
            return Invoker.Call<int>(0x2BF66D2E7414F686);
        }

        public static int _0x14922ED3E38761F0()
        {
            return Invoker.Call<int>(0x14922ED3E38761F0);
        }

        public static void _0xFA2888E3833C8E96()
        {
            Invoker.Call<Void>(0xFA2888E3833C8E96);
        }

        public static void _0x25D990F8E0E3F13C()
        {
            Invoker.Call<Void>(0x25D990F8E0E3F13C);
        }

        public static void _0x77FADDCBE3499DF7(int p0)
        {
            Invoker.Call<Void>(0x77FADDCBE3499DF7, p0);
        }

        public static void _0xF1B84178F8674195(int p0)
        {
            Invoker.Call<Void>(0xF1B84178F8674195, p0);
        }

        public static int NETWORK_GET_RANDOM_INT()
        {
            return Invoker.Call<int>(0x599E4FA1F87EB5FF);
        }

        public static int _NETWORK_GET_RANDOM_INT_IN_RANGE(int rangeStart, int rangeEnd)
        {
            return Invoker.Call<int>(0xE30CF56F1EFA5F43, rangeStart, rangeEnd);
        }

        public static bool NETWORK_PLAYER_IS_CHEATER()
        {
            return Invoker.Call<bool>(0x655B91F1495A9090);
        }

        public static bool _NETWORK_PLAYER_IS_UNK()
        {
            return Invoker.Call<bool>(0x172F75B6EE2233BA);
        }

        public static bool NETWORK_PLAYER_IS_BADSPORT()
        {
            return Invoker.Call<bool>(0x19D8DA0E5A68045A);
        }

        public static bool _NETWORK_IS_PLAYER_IN_SCRIPT(int player, int p1, int scriptHash)
        {
            return Invoker.Call<bool>(0x46FB3ED415C7641C, player, p1, scriptHash);
        }

        public static bool BAD_SPORT_PLAYER_LEFT_DETECTED(ulong networkHandle_ptr, int _event, int amountReceived)
        {
            return Invoker.Call<bool>(0xEC5E3AF5289DCA81, networkHandle_ptr, _event, amountReceived);
        }

        public static void _0xE66C690248F11150(int p0, int p1)
        {
            Invoker.Call<Void>(0xE66C690248F11150, p0, p1);
        }

        public static void NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(int lobbySize, bool p1, int playerId)
        {
            Invoker.Call<Void>(0x1CA59E306ECB80A5, lobbySize, p1, playerId);
        }

        public static bool _NETWORK_IS_THIS_SCRIPT_MARKED(int p0, bool p1, int p2)
        {
            return Invoker.Call<bool>(0xD1110739EEADB592, p0, p1, p2);
        }

        public static bool NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT()
        {
            return Invoker.Call<bool>(0x2910669969E9535E);
        }

        public static int _NETWORK_GET_NUM_PARTICIPANTS_HOST()
        {
            return Invoker.Call<int>(0xA6C90FBC38E395EE);
        }

        public static int NETWORK_GET_NUM_PARTICIPANTS()
        {
            return Invoker.Call<int>(0x18D0456E86604654);
        }

        public static int NETWORK_GET_SCRIPT_STATUS()
        {
            return Invoker.Call<int>(0x57D158647A6BFABF);
        }

        public static void NETWORK_REGISTER_HOST_BROADCAST_VARIABLES(ulong vars_ptr, int sizeofVars)
        {
            Invoker.Call<Void>(0x3E9B2F01C50DF595, vars_ptr, sizeofVars);
        }

        public static void NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES(ulong vars_ptr, int numVars)
        {
            Invoker.Call<Void>(0x3364AA97340CA215, vars_ptr, numVars);
        }

        public static void _0x64F62AFB081E260D()
        {
            Invoker.Call<Void>(0x64F62AFB081E260D);
        }

        public static bool _0x5D10B3795F3FC886()
        {
            return Invoker.Call<bool>(0x5D10B3795F3FC886);
        }

        public static int NETWORK_GET_PLAYER_INDEX(int player)
        {
            return Invoker.Call<int>(0x24FB80D107371267, player);
        }

        public static int NETWORK_GET_PARTICIPANT_INDEX(int index)
        {
            return Invoker.Call<int>(0x1B84DF6AF2A46938, index);
        }

        public static int NETWORK_GET_PLAYER_INDEX_FROM_PED(int ped)
        {
            return Invoker.Call<int>(0x6C0E2E0125610278, ped);
        }

        public static int NETWORK_GET_NUM_CONNECTED_PLAYERS()
        {
            return Invoker.Call<int>(0xA4A79DD2D9600654);
        }

        public static bool NETWORK_IS_PLAYER_CONNECTED(int player)
        {
            return Invoker.Call<bool>(0x93DC1BE4E1ABE9D1, player);
        }

        public static int _0xCF61D4B4702EE9EB()
        {
            return Invoker.Call<int>(0xCF61D4B4702EE9EB);
        }

        public static bool NETWORK_IS_PARTICIPANT_ACTIVE(int p0)
        {
            return Invoker.Call<bool>(0x6FF8FF40B6357D45, p0);
        }

        public static bool NETWORK_IS_PLAYER_ACTIVE(int player)
        {
            return Invoker.Call<bool>(0xB8DFD30D6973E135, player);
        }

        public static bool NETWORK_IS_PLAYER_A_PARTICIPANT(int p0)
        {
            return Invoker.Call<bool>(0x3CA58F6CB7CBD784, p0);
        }

        public static bool NETWORK_IS_HOST_OF_THIS_SCRIPT()
        {
            return Invoker.Call<bool>(0x83CD99A1E6061AB5);
        }

        public static int NETWORK_GET_HOST_OF_THIS_SCRIPT()
        {
            return Invoker.Call<int>(0xC7B4D79B01FA7A5C);
        }

        public static int NETWORK_GET_HOST_OF_SCRIPT(string scriptName, int p1, int p2)
        {
            return Invoker.Call<int>(0x1D6A14F1F9A736FC, scriptName, p1, p2);
        }

        public static void NETWORK_SET_MISSION_FINISHED()
        {
            Invoker.Call<Void>(0x3B3D11CD9FFCDFC9);
        }

        public static bool NETWORK_IS_SCRIPT_ACTIVE(string scriptName, int player, bool p2, int p3)
        {
            return Invoker.Call<bool>(0x9D40DF90FAD26098, scriptName, player, p2, p3);
        }

        public static int NETWORK_GET_NUM_SCRIPT_PARTICIPANTS(ulong p0_ptr, int p1, int p2)
        {
            return Invoker.Call<int>(0x3658E8CD94FC121A, p0_ptr, p1, p2);
        }

        public static int _0x638A3A81733086DB()
        {
            return Invoker.Call<int>(0x638A3A81733086DB);
        }

        public static bool _0x1AD5B71586B94820(int p0, ulong p1_ptr, int p2)
        {
            return Invoker.Call<bool>(0x1AD5B71586B94820, p0, p1_ptr, p2);
        }

        public static void _0x2302C0264EA58D31()
        {
            Invoker.Call<Void>(0x2302C0264EA58D31);
        }

        public static void _0x741A3D8380319A81()
        {
            Invoker.Call<Void>(0x741A3D8380319A81);
        }

        public static int PARTICIPANT_ID()
        {
            return Invoker.Call<int>(0x90986E8876CE0A83);
        }

        public static int PARTICIPANT_ID_TO_INT()
        {
            return Invoker.Call<int>(0x57A3BDDAD8E5AA0A);
        }

        public static int NETWORK_GET_DESTROYER_OF_NETWORK_ID(int netId, ulong weaponHash_ptr)
        {
            return Invoker.Call<int>(0x7A1ADEEF01740A24, netId, weaponHash_ptr);
        }

        public static bool _NETWORK_GET_DESROYER_OF_ENTITY(int p0, int p1, ulong weaponHash_ptr)
        {
            return Invoker.Call<bool>(0x4CACA84440FA26F6, p0, p1, weaponHash_ptr);
        }

        public static int NETWORK_GET_ENTITY_KILLER_OF_PLAYER(int player, ulong weaponHash_ptr)
        {
            return Invoker.Call<int>(0x42B2DAA6B596F5F8, player, weaponHash_ptr);
        }

        public static void NETWORK_RESURRECT_LOCAL_PLAYER(float x, float y, float z, float heading, bool unk, bool changetime)
        {
            Invoker.Call<Void>(0xEA23C49EAA83ACFB, x, y, z, heading, unk, changetime);
        }

        public static void NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME(int time)
        {
            Invoker.Call<Void>(0x2D95C7E2D7E07307, time);
        }

        public static bool NETWORK_IS_LOCAL_PLAYER_INVINCIBLE()
        {
            return Invoker.Call<bool>(0x8A8694B48715B000);
        }

        public static void NETWORK_DISABLE_INVINCIBLE_FLASHING(int player, bool p1)
        {
            Invoker.Call<Void>(0x9DD368BF06983221, player, p1);
        }

        public static void _0x524FF0AEFF9C3973(int p0)
        {
            Invoker.Call<Void>(0x524FF0AEFF9C3973, p0);
        }

        public static bool _0xB07D3185E11657A5(int p0)
        {
            return Invoker.Call<bool>(0xB07D3185E11657A5, p0);
        }

        public static int NETWORK_GET_NETWORK_ID_FROM_ENTITY(int entity)
        {
            return Invoker.Call<int>(0xA11700682F3AD45C, entity);
        }

        public static int NETWORK_GET_ENTITY_FROM_NETWORK_ID(int netId)
        {
            return Invoker.Call<int>(0xCE4E5D9B0A4FF560, netId);
        }

        public static bool NETWORK_GET_ENTITY_IS_NETWORKED(int entity)
        {
            return Invoker.Call<bool>(0xC7827959479DCC78, entity);
        }

        public static bool NETWORK_GET_ENTITY_IS_LOCAL(int entity)
        {
            return Invoker.Call<bool>(0x0991549DE4D64762, entity);
        }

        public static void NETWORK_REGISTER_ENTITY_AS_NETWORKED(int entity)
        {
            Invoker.Call<Void>(0x06FAACD625D80CAA, entity);
        }

        public static void NETWORK_UNREGISTER_NETWORKED_ENTITY(int entity)
        {
            Invoker.Call<Void>(0x7368E683BB9038D6, entity);
        }

        public static bool NETWORK_DOES_NETWORK_ID_EXIST(int netID)
        {
            return Invoker.Call<bool>(0x38CE16C96BD11344, netID);
        }

        public static bool NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID(int entity)
        {
            return Invoker.Call<bool>(0x18A47D074708FD68, entity);
        }

        public static bool NETWORK_REQUEST_CONTROL_OF_NETWORK_ID(int netId)
        {
            return Invoker.Call<bool>(0xA670B3662FAFFBD0, netId);
        }

        public static bool NETWORK_HAS_CONTROL_OF_NETWORK_ID(int netId)
        {
            return Invoker.Call<bool>(0x4D36070FE0215186, netId);
        }

        public static bool NETWORK_REQUEST_CONTROL_OF_ENTITY(int entity)
        {
            return Invoker.Call<bool>(0xB69317BF5E782347, entity);
        }

        public static bool NETWORK_REQUEST_CONTROL_OF_DOOR(int doorID)
        {
            return Invoker.Call<bool>(0x870DDFD5A4A796E4, doorID);
        }

        public static bool NETWORK_HAS_CONTROL_OF_ENTITY(int entity)
        {
            return Invoker.Call<bool>(0x01BF60A500E28887, entity);
        }

        public static bool NETWORK_HAS_CONTROL_OF_PICKUP(int pickup)
        {
            return Invoker.Call<bool>(0x5BC9495F0B3B6FA6, pickup);
        }

        public static bool NETWORK_HAS_CONTROL_OF_DOOR(int doorHash)
        {
            return Invoker.Call<bool>(0xCB3C68ADB06195DF, doorHash);
        }

        public static bool _NETWORK_HAS_CONTROL_OF_PAVEMENT_STATS(int doorHash)
        {
            return Invoker.Call<bool>(0xC01E93FAC20C3346, doorHash);
        }

        public static int VEH_TO_NET(int vehicle)
        {
            return Invoker.Call<int>(0xB4C94523F023419C, vehicle);
        }

        public static int PED_TO_NET(int ped)
        {
            return Invoker.Call<int>(0x0EDEC3C276198689, ped);
        }

        public static int OBJ_TO_NET(int _object)
        {
            return Invoker.Call<int>(0x99BFDC94A603E541, _object);
        }

        public static int NET_TO_VEH(int netHandle)
        {
            return Invoker.Call<int>(0x367B936610BA360C, netHandle);
        }

        public static int NET_TO_PED(int netHandle)
        {
            return Invoker.Call<int>(0xBDCD95FC216A8B3E, netHandle);
        }

        public static int NET_TO_OBJ(int netHandle)
        {
            return Invoker.Call<int>(0xD8515F5FEA14CB3F, netHandle);
        }

        public static int NET_TO_ENT(int netHandle)
        {
            return Invoker.Call<int>(0xBFFEAB45A9A9094A, netHandle);
        }

        public static void NETWORK_GET_LOCAL_HANDLE(ulong networkHandle_ptr, int bufferSize)
        {
            Invoker.Call<Void>(0xE86051786B66CD8E, networkHandle_ptr, bufferSize);
        }

        public static void NETWORK_HANDLE_FROM_USER_ID(string userId, ulong networkHandle_ptr, int bufferSize)
        {
            Invoker.Call<Void>(0xDCD51DD8F87AEC5C, userId, networkHandle_ptr, bufferSize);
        }

        public static void NETWORK_HANDLE_FROM_MEMBER_ID(string memberId, ulong networkHandle_ptr, int bufferSize)
        {
            Invoker.Call<Void>(0xA0FD21BED61E5C4C, memberId, networkHandle_ptr, bufferSize);
        }

        public static void NETWORK_HANDLE_FROM_PLAYER(int player, ulong networkHandle_ptr, int bufferSize)
        {
            Invoker.Call<Void>(0x388EB2B86C73B6B3, player, networkHandle_ptr, bufferSize);
        }

        public static int _NETWORK_HASH_FROM_PLAYER_HANDLE(int player)
        {
            return Invoker.Call<int>(0xBC1D768F2F5D6C05, player);
        }

        public static int _NETWORK_HASH_FROM_GAMER_HANDLE(ulong networkHandle_ptr)
        {
            return Invoker.Call<int>(0x58575AC3CF2CA8EC, networkHandle_ptr);
        }

        public static void NETWORK_HANDLE_FROM_FRIEND(int friendIndex, ulong networkHandle_ptr, int bufferSize)
        {
            Invoker.Call<Void>(0xD45CB817D7E177D2, friendIndex, networkHandle_ptr, bufferSize);
        }

        public static bool NETWORK_GAMERTAG_FROM_HANDLE_START(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x9F0C0A981D73FA56, networkHandle_ptr);
        }

        public static bool NETWORK_GAMERTAG_FROM_HANDLE_PENDING()
        {
            return Invoker.Call<bool>(0xB071E27958EF4CF0);
        }

        public static bool NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED()
        {
            return Invoker.Call<bool>(0xFD00798DBA7523DD);
        }

        public static string NETWORK_GET_GAMERTAG_FROM_HANDLE(ulong networkHandle_ptr)
        {
            return Invoker.Call<string>(0x426141162EBE5CDB, networkHandle_ptr);
        }

        public static int _0xD66C9E72B3CC4982(ulong p0_ptr, int p1)
        {
            return Invoker.Call<int>(0xD66C9E72B3CC4982, p0_ptr, p1);
        }

        public static int _0x58CC181719256197(int p0, int p1, int p2)
        {
            return Invoker.Call<int>(0x58CC181719256197, p0, p1, p2);
        }

        public static bool NETWORK_ARE_HANDLES_THE_SAME(ulong netHandle1_ptr, ulong netHandle2_ptr)
        {
            return Invoker.Call<bool>(0x57DBA049E110F217, netHandle1_ptr, netHandle2_ptr);
        }

        public static bool NETWORK_IS_HANDLE_VALID(ulong networkHandle_ptr, int bufferSize)
        {
            return Invoker.Call<bool>(0x6F79B93B0A8E4133, networkHandle_ptr, bufferSize);
        }

        public static int NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(ulong networkHandle_ptr)
        {
            return Invoker.Call<int>(0xCE5F689CF5A0A49D, networkHandle_ptr);
        }

        public static string NETWORK_MEMBER_ID_FROM_GAMER_HANDLE(ulong networkHandle_ptr)
        {
            return Invoker.Call<string>(0xC82630132081BB6F, networkHandle_ptr);
        }

        public static bool NETWORK_IS_GAMER_IN_MY_SESSION(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x0F10B05DDF8D16E9, networkHandle_ptr);
        }

        public static void NETWORK_SHOW_PROFILE_UI(ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0x859ED1CEA343FCA8, networkHandle_ptr);
        }

        public static string NETWORK_PLAYER_GET_NAME(int player)
        {
            return Invoker.Call<string>(0x7718D2E2060837D2, player);
        }

        public static string NETWORK_PLAYER_GET_USERID(int player, string userID)
        {
            return Invoker.Call<string>(0x4927FC39CD0869A0, player, userID);
        }

        public static bool NETWORK_PLAYER_IS_ROCKSTAR_DEV(int player)
        {
            return Invoker.Call<bool>(0x544ABDDA3B409B6D, player);
        }

        public static bool _NETWORK_PLAYER_SOMETHING(int player)
        {
            return Invoker.Call<bool>(0x565E430DB3B05BEC, player);
        }

        public static bool NETWORK_IS_INACTIVE_PROFILE(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x7E58745504313A2E, p0_ptr);
        }

        public static int NETWORK_GET_MAX_FRIENDS()
        {
            return Invoker.Call<int>(0xAFEBB0D5D8F687D2);
        }

        public static int NETWORK_GET_FRIEND_COUNT()
        {
            return Invoker.Call<int>(0x203F1CFD823B27A4);
        }

        public static string NETWORK_GET_FRIEND_NAME(int friendIndex)
        {
            return Invoker.Call<string>(0xE11EBBB2A783FE8B, friendIndex);
        }

        public static string _NETWORK_GET_FRIEND_NAME_FROM_INDEX(int friendIndex)
        {
            return Invoker.Call<string>(0x4164F227D052E293, friendIndex);
        }

        public static bool NETWORK_IS_FRIEND_ONLINE(string name)
        {
            return Invoker.Call<bool>(0x425A44533437B64D, name);
        }

        public static bool _NETWORK_IS_FRIEND_ONLINE_2(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x87EB7A3FFCB314DB, networkHandle_ptr);
        }

        public static bool NETWORK_IS_FRIEND_IN_SAME_TITLE(string friendName)
        {
            return Invoker.Call<bool>(0x2EA9A3BEDF3F17B8, friendName);
        }

        public static bool NETWORK_IS_FRIEND_IN_MULTIPLAYER(string friendName)
        {
            return Invoker.Call<bool>(0x57005C18827F3A28, friendName);
        }

        public static bool NETWORK_IS_FRIEND(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0x1A24A179F9B31654, networkHandle_ptr);
        }

        public static bool NETWORK_IS_PENDING_FRIEND(int p0)
        {
            return Invoker.Call<bool>(0x0BE73DA6984A6E33, p0);
        }

        public static bool NETWORK_IS_ADDING_FRIEND()
        {
            return Invoker.Call<bool>(0x6EA101606F6E4D81);
        }

        public static bool NETWORK_ADD_FRIEND(ulong networkHandle_ptr, string message)
        {
            return Invoker.Call<bool>(0x8E02D73914064223, networkHandle_ptr, message);
        }

        public static bool NETWORK_IS_FRIEND_INDEX_ONLINE(int friendIndex)
        {
            return Invoker.Call<bool>(0xBAD8F2A42B844821, friendIndex);
        }

        public static void _0x1B857666604B1A74(bool p0)
        {
            Invoker.Call<Void>(0x1B857666604B1A74, p0);
        }

        public static bool _0x82377B65E943F72D(int p0)
        {
            return Invoker.Call<bool>(0x82377B65E943F72D, p0);
        }

        public static bool NETWORK_CAN_SET_WAYPOINT()
        {
            return Invoker.Call<bool>(0xC927EC229934AF60);
        }

        public static int _0xB309EBEA797E001F(int p0)
        {
            return Invoker.Call<int>(0xB309EBEA797E001F, p0);
        }

        public static int _0x26F07DD83A5F7F98()
        {
            return Invoker.Call<int>(0x26F07DD83A5F7F98);
        }

        public static bool NETWORK_HAS_HEADSET()
        {
            return Invoker.Call<bool>(0xE870F9F1F7B4F1FA);
        }

        public static void _0x7D395EA61622E116(bool p0)
        {
            Invoker.Call<Void>(0x7D395EA61622E116, p0);
        }

        public static int _0xC0D2AF00BCC234CA()
        {
            return Invoker.Call<int>(0xC0D2AF00BCC234CA);
        }

        public static bool NETWORK_GAMER_HAS_HEADSET(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xF2FD55CB574BCC55, p0_ptr);
        }

        public static bool NETWORK_IS_GAMER_TALKING(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x71C33B22606CD88A, p0_ptr);
        }

        public static bool NETWORK_CAN_COMMUNICATE_WITH_GAMER(ulong player_ptr)
        {
            return Invoker.Call<bool>(0xA150A4F065806B1F, player_ptr);
        }

        public static bool NETWORK_IS_GAMER_MUTED_BY_ME(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xCE60DE011B6C7978, p0_ptr);
        }

        public static bool NETWORK_AM_I_MUTED_BY_GAMER(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xDF02A2C93F1F26DA, p0_ptr);
        }

        public static bool NETWORK_IS_GAMER_BLOCKED_BY_ME(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xE944C4F5AF1B5883, p0_ptr);
        }

        public static bool NETWORK_AM_I_BLOCKED_BY_GAMER(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x15337C7C268A27B2, p0_ptr);
        }

        public static bool _0xB57A49545BA53CE7(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xB57A49545BA53CE7, p0_ptr);
        }

        public static bool _0xCCA4318E1AB03F1F(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xCCA4318E1AB03F1F, p0_ptr);
        }

        public static bool _0x07DD29D5E22763F1(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x07DD29D5E22763F1, p0_ptr);
        }

        public static bool _0x135F9B7B7ADD2185(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x135F9B7B7ADD2185, p0_ptr);
        }

        public static bool NETWORK_IS_PLAYER_TALKING(int player)
        {
            return Invoker.Call<bool>(0x031E11F3D447647E, player);
        }

        public static bool NETWORK_PLAYER_HAS_HEADSET(int player)
        {
            return Invoker.Call<bool>(0x3FB99A8B08D18FD6, player);
        }

        public static bool NETWORK_IS_PLAYER_MUTED_BY_ME(int player)
        {
            return Invoker.Call<bool>(0x8C71288AE68EDE39, player);
        }

        public static bool NETWORK_AM_I_MUTED_BY_PLAYER(int player)
        {
            return Invoker.Call<bool>(0x9D6981DFC91A8604, player);
        }

        public static bool NETWORK_IS_PLAYER_BLOCKED_BY_ME(int player)
        {
            return Invoker.Call<bool>(0x57AF1F8E27483721, player);
        }

        public static bool NETWORK_AM_I_BLOCKED_BY_PLAYER(int player)
        {
            return Invoker.Call<bool>(0x87F395D957D4353D, player);
        }

        public static float NETWORK_GET_PLAYER_LOUDNESS(int p0)
        {
            return Invoker.Call<float>(0x21A1684A25C2867F, p0);
        }

        public static void NETWORK_SET_TALKER_PROXIMITY(float p0)
        {
            Invoker.Call<Void>(0xCBF12D65F95AD686, p0);
        }

        public static int NETWORK_GET_TALKER_PROXIMITY()
        {
            return Invoker.Call<int>(0x84F0F13120B4E098);
        }

        public static void NETWORK_SET_VOICE_ACTIVE(bool toggle)
        {
            Invoker.Call<Void>(0xBABEC9E69A91C57B, toggle);
        }

        public static void _0xCFEB46DCD7D8D5EB(bool p0)
        {
            Invoker.Call<Void>(0xCFEB46DCD7D8D5EB, p0);
        }

        public static void NETWORK_OVERRIDE_TRANSITION_CHAT(bool p0)
        {
            Invoker.Call<Void>(0xAF66059A131AA269, p0);
        }

        public static void NETWORK_SET_TEAM_ONLY_CHAT(bool toggle)
        {
            Invoker.Call<Void>(0xD5B4883AC32F24C3, toggle);
        }

        public static void _0x6F697A66CE78674E(int team, bool toggle)
        {
            Invoker.Call<Void>(0x6F697A66CE78674E, team, toggle);
        }

        public static void NETWORK_SET_OVERRIDE_SPECTATOR_MODE(bool toggle)
        {
            Invoker.Call<Void>(0x70DA3BF8DACD3210, toggle);
        }

        public static void _0x3C5C1E2C2FF814B1(bool p0)
        {
            Invoker.Call<Void>(0x3C5C1E2C2FF814B1, p0);
        }

        public static void _0x9D7AFCBF21C51712(bool p0)
        {
            Invoker.Call<Void>(0x9D7AFCBF21C51712, p0);
        }

        public static void _0xF46A1E03E8755980(bool p0)
        {
            Invoker.Call<Void>(0xF46A1E03E8755980, p0);
        }

        public static void _0x6A5D89D7769A40D8(bool p0)
        {
            Invoker.Call<Void>(0x6A5D89D7769A40D8, p0);
        }

        public static void NETWORK_OVERRIDE_CHAT_RESTRICTIONS(int player, bool toggle)
        {
            Invoker.Call<Void>(0x3039AE5AD2C9C0C4, player, toggle);
        }

        public static void _NETWORK_OVERRIDE_SEND_RESTRICTIONS(int player, bool toggle)
        {
            Invoker.Call<Void>(0x97DD4C5944CC2E6A, player, toggle);
        }

        public static void _NETWORK_CHAT_MUTE(bool p0)
        {
            Invoker.Call<Void>(0x57B192B4D4AD23D5, p0);
        }

        public static void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS(int player, bool toggle)
        {
            Invoker.Call<Void>(0xDDF73E2B1FEC5AB4, player, toggle);
        }

        public static void _0x0FF2862B61A58AF9(bool p0)
        {
            Invoker.Call<Void>(0x0FF2862B61A58AF9, p0);
        }

        public static void NETWORK_SET_VOICE_CHANNEL(int p0)
        {
            Invoker.Call<Void>(0xEF6212C2EFEF1A23, p0);
        }

        public static void NETWORK_CLEAR_VOICE_CHANNEL()
        {
            Invoker.Call<Void>(0xE036A705F989E049);
        }

        public static bool IS_NETWORK_VEHICLE_BEEN_DAMAGED_BY_ANY_OBJECT(float x, float y, float z)
        {
            return Invoker.Call<bool>(0xDBD2056652689917, x, y, z);
        }

        public static void _0xF03755696450470C()
        {
            Invoker.Call<Void>(0xF03755696450470C);
        }

        public static void _0x5E3AA4CA2B6FB0EE(int p0)
        {
            Invoker.Call<Void>(0x5E3AA4CA2B6FB0EE, p0);
        }

        public static void _0xCA575C391FEA25CC(int p0)
        {
            Invoker.Call<Void>(0xCA575C391FEA25CC, p0);
        }

        public static void _0xADB57E5B663CCA8B(int p0, ulong p1_ptr, ulong p2_ptr)
        {
            Invoker.Call<Void>(0xADB57E5B663CCA8B, p0, p1_ptr, p2_ptr);
        }

        public static bool _NETWORK_IS_TEXT_CHAT_ACTIVE()
        {
            return Invoker.Call<bool>(0x5FCF4D7069B09026);
        }

        public static void SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME()
        {
            Invoker.Call<Void>(0x593850C16A36B692);
        }

        public static void NETWORK_SET_FRIENDLY_FIRE_OPTION(bool toggle)
        {
            Invoker.Call<Void>(0xF808475FA571D823, toggle);
        }

        public static void NETWORK_SET_RICH_PRESENCE(int p0, int p1, int p2, int p3)
        {
            Invoker.Call<Void>(0x1DCCACDCFC569362, p0, p1, p2, p3);
        }

        public static void _NETWORK_SET_RICH_PRESENCE_2(int p0, string gxtLabel)
        {
            Invoker.Call<Void>(0x3E200C2BCF4164EB, p0, gxtLabel);
        }

        public static int NETWORK_GET_TIMEOUT_TIME()
        {
            return Invoker.Call<int>(0x5ED0356A0CE3A34F);
        }

        public static void _NETWORK_RESPAWN_COORDS(int player, float x, float y, float z, bool p4, bool p5)
        {
            Invoker.Call<Void>(0x9769F811D1785B03, player, x, y, z, p4, p5);
        }

        public static void _NETWORK_RESPAWN_PLAYER(int player, bool p1)
        {
            Invoker.Call<Void>(0xBF22E0F32968E967, player, p1);
        }

        public static void _0x715135F4B82AC90D(int entity)
        {
            Invoker.Call<Void>(0x715135F4B82AC90D, entity);
        }

        public static bool _NETWORK_PLAYER_IS_IN_CLAN()
        {
            return Invoker.Call<bool>(0x579CCED0265D4896);
        }

        public static bool NETWORK_CLAN_PLAYER_IS_ACTIVE(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0xB124B57F571D8F18, networkHandle_ptr);
        }

        public static bool NETWORK_CLAN_PLAYER_GET_DESC(ulong clanDesc_ptr, int bufferSize, ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0xEEE6EACBE8874FBA, clanDesc_ptr, bufferSize, networkHandle_ptr);
        }

        public static bool _0x7543BB439F63792B(ulong clanDesc_ptr, int bufferSize)
        {
            return Invoker.Call<bool>(0x7543BB439F63792B, clanDesc_ptr, bufferSize);
        }

        public static void _0xF45352426FF3A4F0(ulong clanDesc_ptr, int bufferSize, ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0xF45352426FF3A4F0, clanDesc_ptr, bufferSize, networkHandle_ptr);
        }

        public static int _GET_NUM_MEMBERSHIP_DESC()
        {
            return Invoker.Call<int>(0x1F471B79ACC90BEF);
        }

        public static bool NETWORK_CLAN_GET_MEMBERSHIP_DESC(ulong memberDesc_ptr, int p1)
        {
            return Invoker.Call<bool>(0x48DE78AF2C8885B8, memberDesc_ptr, p1);
        }

        public static bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP(ulong networkHandle_ptr)
        {
            return Invoker.Call<bool>(0xA989044E70010ABE, networkHandle_ptr);
        }

        public static bool NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x5B9E023DC6EBEDC0, p0_ptr);
        }

        public static bool _NETWORK_IS_CLAN_MEMBERSHIP_FINISHED_DOWNLOADING()
        {
            return Invoker.Call<bool>(0xB3F64A6A91432477);
        }

        public static bool NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xBB6E6FEE99D866B2, p0_ptr);
        }

        public static int NETWORK_CLAN_GET_MEMBERSHIP_COUNT(ulong p0_ptr)
        {
            return Invoker.Call<int>(0xAAB11F6C4ADBC2C1, p0_ptr);
        }

        public static bool NETWORK_CLAN_GET_MEMBERSHIP_VALID(ulong p0_ptr, int p1)
        {
            return Invoker.Call<bool>(0x48A59CF88D43DF0E, p0_ptr, p1);
        }

        public static bool NETWORK_CLAN_GET_MEMBERSHIP(ulong p0_ptr, ulong clanMembership_ptr, int p2)
        {
            return Invoker.Call<bool>(0xC8BC2011F67B3411, p0_ptr, clanMembership_ptr, p2);
        }

        public static bool NETWORK_CLAN_JOIN(int clanDesc)
        {
            return Invoker.Call<bool>(0x9FAAA4F4FC71F87F, clanDesc);
        }

        public static bool _NETWORK_CLAN_ANIMATION(string animDict, string animName)
        {
            return Invoker.Call<bool>(0x729E3401F0430686, animDict, animName);
        }

        public static bool _0x2B51EDBEFC301339(int p0, string p1)
        {
            return Invoker.Call<bool>(0x2B51EDBEFC301339, p0, p1);
        }

        public static int _0xC32EA7A2F6CA7557()
        {
            return Invoker.Call<int>(0xC32EA7A2F6CA7557);
        }

        public static bool _NETWORK_GET_PLAYER_CREW_EMBLEM_TXD_NAME(ulong player_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x5835D9CD92E83184, player_ptr, p1_ptr);
        }

        public static bool _0x13518FF1C6B28938(int p0)
        {
            return Invoker.Call<bool>(0x13518FF1C6B28938, p0);
        }

        public static bool _0xA134777FF7F33331(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xA134777FF7F33331, p0, p1_ptr);
        }

        public static void _0x113E6E3E50E286B0(int p0)
        {
            Invoker.Call<Void>(0x113E6E3E50E286B0, p0);
        }

        public static int NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR()
        {
            return Invoker.Call<int>(0x9AA46BADAD0E27ED);
        }

        public static void NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL()
        {
            Invoker.Call<Void>(0x042E4B70B93E6054);
        }

        public static bool NETWORK_GET_PRIMARY_CLAN_DATA_START(ulong p0_ptr, int p1)
        {
            return Invoker.Call<bool>(0xCE86D8191B762107, p0_ptr, p1);
        }

        public static int NETWORK_GET_PRIMARY_CLAN_DATA_PENDING()
        {
            return Invoker.Call<int>(0xB5074DB804E28CE7);
        }

        public static int NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS()
        {
            return Invoker.Call<int>(0x5B4F04F19376A0BA);
        }

        public static bool NETWORK_GET_PRIMARY_CLAN_DATA_NEW(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xC080FF658B2E41DA, p0_ptr, p1_ptr);
        }

        public static void SET_NETWORK_ID_CAN_MIGRATE(int netId, bool toggle)
        {
            Invoker.Call<Void>(0x299EEB23175895FC, netId, toggle);
        }

        public static void SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(int netId, bool toggle)
        {
            Invoker.Call<Void>(0xE05E81A888FA63C8, netId, toggle);
        }

        public static void _SET_NETWORK_ID_SYNC_TO_PLAYER(int netId, int player, bool toggle)
        {
            Invoker.Call<Void>(0xA8A024587329F36A, netId, player, toggle);
        }

        public static void NETWORK_SET_ENTITY_CAN_BLEND(int entity, bool toggle)
        {
            Invoker.Call<Void>(0xD830567D88A1E873, entity, toggle);
        }

        public static void _NETWORK_SET_ENTITY_INVISIBLE_TO_NETWORK(int entity, bool toggle)
        {
            Invoker.Call<Void>(0xF1CA12B18AEF5298, entity, toggle);
        }

        public static void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE(int netId, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xA6928482543022B4, netId, p1, p2);
        }

        public static void _0xAAA553E7DD28A457(bool p0)
        {
            Invoker.Call<Void>(0xAAA553E7DD28A457, p0);
        }

        public static void _0x3FA36981311FA4FF(int netId, bool state)
        {
            Invoker.Call<Void>(0x3FA36981311FA4FF, netId, state);
        }

        public static bool _NETWORK_CAN_NETWORK_ID_BE_SEEN(int netId)
        {
            return Invoker.Call<bool>(0xA1607996431332DF, netId);
        }

        public static void SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE(bool p0, bool p1)
        {
            Invoker.Call<Void>(0xD1065D68947E7B6E, p0, p1);
        }

        public static void SET_LOCAL_PLAYER_INVISIBLE_LOCALLY(bool p0)
        {
            Invoker.Call<Void>(0xE5F773C1A1D9D168, p0);
        }

        public static void SET_LOCAL_PLAYER_VISIBLE_LOCALLY(bool p0)
        {
            Invoker.Call<Void>(0x7619364C82D3BF14, p0);
        }

        public static void SET_PLAYER_INVISIBLE_LOCALLY(int player, bool toggle)
        {
            Invoker.Call<Void>(0x12B37D54667DB0B8, player, toggle);
        }

        public static void SET_PLAYER_VISIBLE_LOCALLY(int player, bool toggle)
        {
            Invoker.Call<Void>(0xFAA10F1FAFB11AF2, player, toggle);
        }

        public static void FADE_OUT_LOCAL_PLAYER(bool p0)
        {
            Invoker.Call<Void>(0x416DBD4CD6ED8DD2, p0);
        }

        public static void NETWORK_FADE_OUT_ENTITY(int entity, bool normal, bool slow)
        {
            Invoker.Call<Void>(0xDE564951F95E09ED, entity, normal, slow);
        }

        public static void NETWORK_FADE_IN_ENTITY(int entity, bool state)
        {
            Invoker.Call<Void>(0x1F4ED342ACEFE62D, entity, state);
        }

        public static bool _0x631DC5DFF4B110E3(int p0)
        {
            return Invoker.Call<bool>(0x631DC5DFF4B110E3, p0);
        }

        public static bool _0x422F32CC7E56ABAD(int p0)
        {
            return Invoker.Call<bool>(0x422F32CC7E56ABAD, p0);
        }

        public static bool IS_PLAYER_IN_CUTSCENE(int player)
        {
            return Invoker.Call<bool>(0xE73092F4157CD126, player);
        }

        public static void SET_ENTITY_VISIBLE_IN_CUTSCENE(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xE0031D3C8F36AB82, p0, p1, p2);
        }

        public static void SET_ENTITY_LOCALLY_INVISIBLE(int entity)
        {
            Invoker.Call<Void>(0xE135A9FF3F5D05D8, entity);
        }

        public static void SET_ENTITY_LOCALLY_VISIBLE(int entity)
        {
            Invoker.Call<Void>(0x241E289B5C059EDC, entity);
        }

        public static bool IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID(int netID)
        {
            return Invoker.Call<bool>(0x6E192E33AD436366, netID);
        }

        public static void ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID(int netID, bool p1)
        {
            Invoker.Call<Void>(0xD45B1FFCCD52FF19, netID, p1);
        }

        public static bool IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE(float p0, float p1, float p2, float p3)
        {
            return Invoker.Call<bool>(0xD82CF8E64C8729D8, p0, p1, p2, p3);
        }

        public static bool IS_SPHERE_VISIBLE_TO_PLAYER(int p0, float p1, float p2, float p3, float p4)
        {
            return Invoker.Call<bool>(0xDC3A310219E5DA62, p0, p1, p2, p3, p4);
        }

        public static void RESERVE_NETWORK_MISSION_OBJECTS(int amount)
        {
            Invoker.Call<Void>(0x4E5C93BD0C32FBF8, amount);
        }

        public static void RESERVE_NETWORK_MISSION_PEDS(int amount)
        {
            Invoker.Call<Void>(0xB60FEBA45333D36F, amount);
        }

        public static void RESERVE_NETWORK_MISSION_VEHICLES(int amount)
        {
            Invoker.Call<Void>(0x76B02E21ED27A469, amount);
        }

        public static bool CAN_REGISTER_MISSION_OBJECTS(int amount)
        {
            return Invoker.Call<bool>(0x800DD4721A8B008B, amount);
        }

        public static bool CAN_REGISTER_MISSION_PEDS(int amount)
        {
            return Invoker.Call<bool>(0xBCBF4FEF9FA5D781, amount);
        }

        public static bool CAN_REGISTER_MISSION_VEHICLES(int amount)
        {
            return Invoker.Call<bool>(0x7277F1F2E085EE74, amount);
        }

        public static bool CAN_REGISTER_MISSION_ENTITIES(int ped_amt, int vehicle_amt, int _object_amt, int pickup_amt)
        {
            return Invoker.Call<bool>(0x69778E7564BADE6D, ped_amt, vehicle_amt, _object_amt, pickup_amt);
        }

        public static int GET_NUM_RESERVED_MISSION_OBJECTS(bool p0)
        {
            return Invoker.Call<int>(0xAA81B5F10BC43AC2, p0);
        }

        public static int GET_NUM_RESERVED_MISSION_PEDS(bool p0)
        {
            return Invoker.Call<int>(0x1F13D5AE5CB17E17, p0);
        }

        public static int GET_NUM_RESERVED_MISSION_VEHICLES(bool p0)
        {
            return Invoker.Call<int>(0xCF3A965906452031, p0);
        }

        public static int _0x12B6281B6C6706C0(bool p0)
        {
            return Invoker.Call<int>(0x12B6281B6C6706C0, p0);
        }

        public static int _0xCB215C4B56A7FAE7(bool p0)
        {
            return Invoker.Call<int>(0xCB215C4B56A7FAE7, p0);
        }

        public static int _0x0CD9AB83489430EA(bool p0)
        {
            return Invoker.Call<int>(0x0CD9AB83489430EA, p0);
        }

        public static int _0xC7BE335216B5EC7C()
        {
            return Invoker.Call<int>(0xC7BE335216B5EC7C);
        }

        public static int _0x0C1F7D49C39D2289()
        {
            return Invoker.Call<int>(0x0C1F7D49C39D2289);
        }

        public static int _0x0AFCE529F69B21FF()
        {
            return Invoker.Call<int>(0x0AFCE529F69B21FF);
        }

        public static int _0xA72835064DD63E4C()
        {
            return Invoker.Call<int>(0xA72835064DD63E4C);
        }

        public static int GET_NETWORK_TIME()
        {
            return Invoker.Call<int>(0x7A5487FE9FAA6B48);
        }

        public static int _0x89023FBBF9200E9F()
        {
            return Invoker.Call<int>(0x89023FBBF9200E9F);
        }

        public static bool HAS_NETWORK_TIME_STARTED()
        {
            return Invoker.Call<bool>(0x46718ACEEDEAFC84);
        }

        public static int GET_TIME_OFFSET(int timeA, int timeB)
        {
            return Invoker.Call<int>(0x017008CCDAD48503, timeA, timeB);
        }

        public static bool IS_TIME_LESS_THAN(int timeA, int timeB)
        {
            return Invoker.Call<bool>(0xCB2CF5148012C8D0, timeA, timeB);
        }

        public static bool IS_TIME_MORE_THAN(int timeA, int timeB)
        {
            return Invoker.Call<bool>(0xDE350F8651E4346C, timeA, timeB);
        }

        public static bool IS_TIME_EQUAL_TO(int timeA, int timeB)
        {
            return Invoker.Call<bool>(0xF5BC95857BD6D512, timeA, timeB);
        }

        public static int GET_TIME_DIFFERENCE(int timeA, int timeB)
        {
            return Invoker.Call<int>(0xA2C6FC031D46FFF0, timeA, timeB);
        }

        public static string GET_TIME_AS_STRING(int time)
        {
            return Invoker.Call<string>(0x9E23B1777A927DAD, time);
        }

        public static int _GET_POSIX_TIME()
        {
            return Invoker.Call<int>(0x9A73240B49945C76);
        }

        public static void _GET_DATE_AND_TIME_FROM_UNIX_EPOCH(int unixEpoch, ulong timeStructure_ptr)
        {
            Invoker.Call<Void>(0xAC97AF97FA68E5D5, unixEpoch, timeStructure_ptr);
        }

        public static void NETWORK_SET_IN_SPECTATOR_MODE(bool toggle, int playerPed)
        {
            Invoker.Call<Void>(0x423DE3854BB50894, toggle, playerPed);
        }

        public static void _0x419594E137637120(bool p0, int p1, bool p2)
        {
            Invoker.Call<Void>(0x419594E137637120, p0, p1, p2);
        }

        public static void _0xFC18DB55AE19E046(bool p0)
        {
            Invoker.Call<Void>(0xFC18DB55AE19E046, p0);
        }

        public static void _0x5C707A667DF8B9FA(bool p0, int p1)
        {
            Invoker.Call<Void>(0x5C707A667DF8B9FA, p0, p1);
        }

        public static bool NETWORK_IS_IN_SPECTATOR_MODE()
        {
            return Invoker.Call<bool>(0x048746E388762E11);
        }

        public static void NETWORK_SET_IN_MP_CUTSCENE(bool p0, bool p1)
        {
            Invoker.Call<Void>(0x9CA5DE655269FEC4, p0, p1);
        }

        public static bool NETWORK_IS_IN_MP_CUTSCENE()
        {
            return Invoker.Call<bool>(0x6CC27C9FA2040220);
        }

        public static bool NETWORK_IS_PLAYER_IN_MP_CUTSCENE(int player)
        {
            return Invoker.Call<bool>(0x63F9EE203C3619F2, player);
        }

        public static void SET_NETWORK_VEHICLE_RESPOT_TIMER(int netId, int time)
        {
            Invoker.Call<Void>(0xEC51713AB6EC36E8, netId, time);
        }

        public static void _SET_NETWORK_OBJECT_NON_CONTACT(int _object, bool toggle)
        {
            Invoker.Call<Void>(0x6274C4712850841E, _object, toggle);
        }

        public static void USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR(bool toggle)
        {
            Invoker.Call<Void>(0x5FFE9B4144F9712F, toggle);
        }

        public static bool _0x21D04D7BC538C146(int p0)
        {
            return Invoker.Call<bool>(0x21D04D7BC538C146, p0);
        }

        public static void _0x77758139EC9B66C7(bool p0)
        {
            Invoker.Call<Void>(0x77758139EC9B66C7, p0);
        }

        public static int NETWORK_CREATE_SYNCHRONISED_SCENE(float x, float y, float z, float xRot, float yRot, float zRot, int p6, int p7, int p8, float p9)
        {
            return Invoker.Call<int>(0x7CD6BC4C2BBDD526, x, y, z, xRot, yRot, zRot, p6, p7, p8, p9);
        }

        public static void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE(int ped, int netScene, string animDict, string animnName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, int p9)
        {
            Invoker.Call<Void>(0x742A637471BCECD9, ped, netScene, animDict, animnName, speed, speedMultiplier, duration, flag, playbackRate, p9);
        }

        public static void NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE(int entity, int netScene, string animDict, string animName, float speed, float speedMulitiplier, int flag)
        {
            Invoker.Call<Void>(0xF2404D68CBC855FA, entity, netScene, animDict, animName, speed, speedMulitiplier, flag);
        }

        public static void _NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA(int netScene, string animDict, string animName)
        {
            Invoker.Call<Void>(0xCF8BD3B0BD6D42D7, netScene, animDict, animName);
        }

        public static void NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY(int netScene, int entity, int bone)
        {
            Invoker.Call<Void>(0x478DCBD2A98B705A, netScene, entity, bone);
        }

        public static void NETWORK_START_SYNCHRONISED_SCENE(int netScene)
        {
            Invoker.Call<Void>(0x9A1B3FCDB36C8697, netScene);
        }

        public static void NETWORK_STOP_SYNCHRONISED_SCENE(int netScene)
        {
            Invoker.Call<Void>(0xC254481A4574CB2F, netScene);
        }

        public static int _NETWORK_CONVERT_SYNCHRONISED_SCENE_TO_SYNCHRONIZED_SCENE(int netScene)
        {
            return Invoker.Call<int>(0x02C40BF885C567B6, netScene);
        }

        public static void _0xC9B43A33D09CADA7(int p0)
        {
            Invoker.Call<Void>(0xC9B43A33D09CADA7, p0);
        }

        public static int _0xFB1F9381E80FA13F(int p0, ulong p1_ptr)
        {
            return Invoker.Call<int>(0xFB1F9381E80FA13F, p0, p1_ptr);
        }

        public static bool _0x5A6FFA2433E2F14C(int player, float p1, float p2, float p3, float p4, float p5, float p6, float p7, int flags)
        {
            return Invoker.Call<bool>(0x5A6FFA2433E2F14C, player, p1, p2, p3, p4, p5, p6, p7, flags);
        }

        public static bool _0x4BA92A18502BCA61(int player, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, int flags)
        {
            return Invoker.Call<bool>(0x4BA92A18502BCA61, player, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, flags);
        }

        public static int _0x3C891A251567DFCE(ulong p0_ptr)
        {
            return Invoker.Call<int>(0x3C891A251567DFCE, p0_ptr);
        }

        public static void _0xFB8F2A6F3DF08CBE()
        {
            Invoker.Call<Void>(0xFB8F2A6F3DF08CBE);
        }

        public static void NETWORK_GET_RESPAWN_RESULT(int randomInt, ulong coordinates_ptr, ulong heading_ptr)
        {
            Invoker.Call<Void>(0x371EA43692861CF1, randomInt, coordinates_ptr, heading_ptr);
        }

        public static int _0x6C34F1208B8923FD(int p0)
        {
            return Invoker.Call<int>(0x6C34F1208B8923FD, p0);
        }

        public static void _0x17E0198B3882C2CB()
        {
            Invoker.Call<Void>(0x17E0198B3882C2CB);
        }

        public static void _0xFB680D403909DC70(int p0, int p1)
        {
            Invoker.Call<Void>(0xFB680D403909DC70, p0, p1);
        }

        public static void NETWORK_END_TUTORIAL_SESSION()
        {
            Invoker.Call<Void>(0xD0AFAFF5A51D72F7);
        }

        public static int NETWORK_IS_IN_TUTORIAL_SESSION()
        {
            return Invoker.Call<int>(0xADA24309FE08DACF);
        }

        public static int _0xB37E4E6A2388CA7B()
        {
            return Invoker.Call<int>(0xB37E4E6A2388CA7B);
        }

        public static int _0x35F0B98A8387274D()
        {
            return Invoker.Call<int>(0x35F0B98A8387274D);
        }

        public static int _0x3B39236746714134(int p0)
        {
            return Invoker.Call<int>(0x3B39236746714134, p0);
        }

        public static bool _NETWORK_IS_PLAYER_EQUAL_TO_INDEX(int player, int index)
        {
            return Invoker.Call<bool>(0x9DE986FC9A87C474, player, index);
        }

        public static void _0xBBDF066252829606(int p0, bool p1)
        {
            Invoker.Call<Void>(0xBBDF066252829606, p0, p1);
        }

        public static bool _0x919B3C98ED8292F9(int p0)
        {
            return Invoker.Call<bool>(0x919B3C98ED8292F9, p0);
        }

        public static void NETWORK_OVERRIDE_CLOCK_TIME(int Hours, int Minutes, int Seconds)
        {
            Invoker.Call<Void>(0xE679E3E06E363892, Hours, Minutes, Seconds);
        }

        public static void NETWORK_CLEAR_CLOCK_TIME_OVERRIDE()
        {
            Invoker.Call<Void>(0xD972DF67326F966E);
        }

        public static bool NETWORK_IS_CLOCK_TIME_OVERRIDDEN()
        {
            return Invoker.Call<bool>(0xD7C95D322FF57522);
        }

        public static int NETWORK_ADD_ENTITY_AREA(float p0, float p1, float p2, float p3, float p4, float p5)
        {
            return Invoker.Call<int>(0x494C8FB299290269, p0, p1, p2, p3, p4, p5);
        }

        public static int _NETWORK_ADD_ENTITY_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6)
        {
            return Invoker.Call<int>(0x376C6375BA60293A, p0, p1, p2, p3, p4, p5, p6);
        }

        public static int _0x25B99872D588A101(float p0, float p1, float p2, float p3, float p4, float p5)
        {
            return Invoker.Call<int>(0x25B99872D588A101, p0, p1, p2, p3, p4, p5);
        }

        public static bool NETWORK_REMOVE_ENTITY_AREA(int p0)
        {
            return Invoker.Call<bool>(0x93CF869BAA0C4874, p0);
        }

        public static bool _0xE64A3CA08DFA37A9(int p0)
        {
            return Invoker.Call<bool>(0xE64A3CA08DFA37A9, p0);
        }

        public static bool _0x4DF7CFFF471A7FB1(int p0)
        {
            return Invoker.Call<bool>(0x4DF7CFFF471A7FB1, p0);
        }

        public static bool _0x4A2D4E8BF4265B0F(int p0)
        {
            return Invoker.Call<bool>(0x4A2D4E8BF4265B0F, p0);
        }

        public static void _NETWORK_SET_NETWORK_ID_DYNAMIC(int netID, bool toggle)
        {
            Invoker.Call<Void>(0x2B1813ABA29016C5, netID, toggle);
        }

        public static bool _NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS()
        {
            return Invoker.Call<bool>(0x924426BFFD82E915);
        }

        public static bool _HAS_BG_SCRIPT_BEEN_DOWNLOADED()
        {
            return Invoker.Call<bool>(0x8132C0EB8B2B3293);
        }

        public static void NETWORK_REQUEST_CLOUD_TUNABLES()
        {
            Invoker.Call<Void>(0x42FB3B532D526E6C);
        }

        public static bool _HAS_TUNABLES_BEEN_DOWNLOADED()
        {
            return Invoker.Call<bool>(0x0467C11ED88B7D28);
        }

        public static int _0x10BD227A753B0D84()
        {
            return Invoker.Call<int>(0x10BD227A753B0D84);
        }

        public static bool NETWORK_DOES_TUNABLE_EXIST(string tunableContext, string tunableName)
        {
            return Invoker.Call<bool>(0x85E5F8B9B898B20A, tunableContext, tunableName);
        }

        public static bool NETWORK_ACCESS_TUNABLE_INT(string tunableContext, string tunableName, ulong value_ptr)
        {
            return Invoker.Call<bool>(0x8BE1146DFD5D4468, tunableContext, tunableName, value_ptr);
        }

        public static bool NETWORK_ACCESS_TUNABLE_FLOAT(string tunableContext, string tunableName, ulong value_ptr)
        {
            return Invoker.Call<bool>(0xE5608CA7BC163A5F, tunableContext, tunableName, value_ptr);
        }

        public static bool NETWORK_ACCESS_TUNABLE_BOOL(string tunableContext, string tunableName)
        {
            return Invoker.Call<bool>(0xAA6A47A573ABB75A, tunableContext, tunableName);
        }

        public static bool _NETWORK_DOES_TUNABLE_EXIST_HASH(int tunableContext, int tunableName)
        {
            return Invoker.Call<bool>(0xE4E53E1419D81127, tunableContext, tunableName);
        }

        public static bool _NETWORK_ACCESS_TUNABLE_INT_HASH(int tunableContext, int tunableName, ulong value_ptr)
        {
            return Invoker.Call<bool>(0x40FCE03E50E8DBE8, tunableContext, tunableName, value_ptr);
        }

        public static bool _NETWORK_ACCESS_TUNABLE_FLOAT_HASH(int tunableContext, int tunableName, ulong value_ptr)
        {
            return Invoker.Call<bool>(0x972BC203BBC4C4D5, tunableContext, tunableName, value_ptr);
        }

        public static bool _NETWORK_ACCESS_TUNABLE_BOOL_HASH(int tunableContext, int tunableName)
        {
            return Invoker.Call<bool>(0xEA16B69D93D71A45, tunableContext, tunableName);
        }

        public static bool _NETWORK_ACCESS_TUNABLE_BOOL_HASH_FAIL_VAL(int tunableContext, int tunableName, bool defaultValue)
        {
            return Invoker.Call<bool>(0xC7420099936CE286, tunableContext, tunableName, defaultValue);
        }

        public static int _GET_TUNABLES_CONTENT_MODIFIER_ID(int contentHash)
        {
            return Invoker.Call<int>(0x187382F8A3E0A6C3, contentHash);
        }

        public static int _0x7DB53B37A2F211A0()
        {
            return Invoker.Call<int>(0x7DB53B37A2F211A0);
        }

        public static void NETWORK_RESET_BODY_TRACKER()
        {
            Invoker.Call<Void>(0x72433699B4E6DD64);
        }

        public static int _0xD38C4A6D047C019D()
        {
            return Invoker.Call<int>(0xD38C4A6D047C019D);
        }

        public static bool _0x2E0BF682CC778D49(int p0)
        {
            return Invoker.Call<bool>(0x2E0BF682CC778D49, p0);
        }

        public static bool _0x0EDE326D47CD0F3E(int ped, int player)
        {
            return Invoker.Call<bool>(0x0EDE326D47CD0F3E, ped, player);
        }

        public static int NETWORK_EXPLODE_VEHICLE(int vehicle, bool isAudible, bool isInvisible, bool p3)
        {
            return Invoker.Call<int>(0x301A42153C9AD707, vehicle, isAudible, isInvisible, p3);
        }

        public static void _0xCD71A4ECAB22709E(int entity)
        {
            Invoker.Call<Void>(0xCD71A4ECAB22709E, entity);
        }

        public static void _0xA7E30DE9272B6D49(int ped, float x, float y, float z, float p4)
        {
            Invoker.Call<Void>(0xA7E30DE9272B6D49, ped, x, y, z, p4);
        }

        public static void _0x407091CF6037118E(int netID)
        {
            Invoker.Call<Void>(0x407091CF6037118E, netID);
        }

        public static void NETWORK_SET_PROPERTY_ID(int p0)
        {
            Invoker.Call<Void>(0x1775961C2FBBCB5C, p0);
        }

        public static void NETWORK_CLEAR_PROPERTY_ID()
        {
            Invoker.Call<Void>(0xC2B82527CA77053E);
        }

        public static void _0x367EF5E2F439B4C6(int p0)
        {
            Invoker.Call<Void>(0x367EF5E2F439B4C6, p0);
        }

        public static void _0x94538037EE44F5CF(bool p0)
        {
            Invoker.Call<Void>(0x94538037EE44F5CF, p0);
        }

        public static void _0xBD0BE0BFC927EAC1()
        {
            Invoker.Call<Void>(0xBD0BE0BFC927EAC1);
        }

        public static bool _0x237D5336A9A54108(int p0)
        {
            return Invoker.Call<bool>(0x237D5336A9A54108, p0);
        }

        public static bool _NETWORK_COPY_PED_BLEND_DATA(int ped, int player)
        {
            return Invoker.Call<bool>(0x99B72C7ABDE5C910, ped, player);
        }

        public static int _0xF2EAC213D5EA0623()
        {
            return Invoker.Call<int>(0xF2EAC213D5EA0623);
        }

        public static int _0xEA14EEF5B7CD2C30()
        {
            return Invoker.Call<int>(0xEA14EEF5B7CD2C30);
        }

        public static void _0xB606E6CC59664972(int p0)
        {
            Invoker.Call<Void>(0xB606E6CC59664972, p0);
        }

        public static int _0x1D4DC17C38FEAFF0()
        {
            return Invoker.Call<int>(0x1D4DC17C38FEAFF0);
        }

        public static int _0x662635855957C411(int p0)
        {
            return Invoker.Call<int>(0x662635855957C411, p0);
        }

        public static int _0xB4271092CA7EDF48(int p0)
        {
            return Invoker.Call<int>(0xB4271092CA7EDF48, p0);
        }

        public static int _0xCA94551B50B4932C(int p0)
        {
            return Invoker.Call<int>(0xCA94551B50B4932C, p0);
        }

        public static int _0x2A7776C709904AB0(int p0)
        {
            return Invoker.Call<int>(0x2A7776C709904AB0, p0);
        }

        public static int _0x6F44CBF56D79FAC0(int p0, int p1)
        {
            return Invoker.Call<int>(0x6F44CBF56D79FAC0, p0, p1);
        }

        public static void _0x58C21165F6545892(string p0, string p1)
        {
            Invoker.Call<Void>(0x58C21165F6545892, p0, p1);
        }

        public static int _0x2EAC52B4019E2782()
        {
            return Invoker.Call<int>(0x2EAC52B4019E2782);
        }

        public static void SET_STORE_ENABLED(bool toggle)
        {
            Invoker.Call<Void>(0x9641A9FF718E9C5E, toggle);
        }

        public static bool _0xA2F952104FC6DD4B(int p0)
        {
            return Invoker.Call<bool>(0xA2F952104FC6DD4B, p0);
        }

        public static void _0x72D0706CD6CCDB58()
        {
            Invoker.Call<Void>(0x72D0706CD6CCDB58);
        }

        public static int _0x722F5D28B61C5EA8(int p0)
        {
            return Invoker.Call<int>(0x722F5D28B61C5EA8, p0);
        }

        public static int _0x883D79C4071E18B3()
        {
            return Invoker.Call<int>(0x883D79C4071E18B3);
        }

        public static void _0x265635150FB0D82E()
        {
            Invoker.Call<Void>(0x265635150FB0D82E);
        }

        public static void _0x444C4525ECE0A4B9()
        {
            Invoker.Call<Void>(0x444C4525ECE0A4B9);
        }

        public static int _0x59328EB08C5CEB2B()
        {
            return Invoker.Call<int>(0x59328EB08C5CEB2B);
        }

        public static void _0xFAE628F1E9ADB239(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0xFAE628F1E9ADB239, p0, p1, p2);
        }

        public static int _0xC64DED7EF0D2FE37(ulong p0_ptr)
        {
            return Invoker.Call<int>(0xC64DED7EF0D2FE37, p0_ptr);
        }

        public static bool _0x4C61B39930D045DA(int p0)
        {
            return Invoker.Call<bool>(0x4C61B39930D045DA, p0);
        }

        public static bool _0x3A3D5568AF297CD5(int p0)
        {
            return Invoker.Call<bool>(0x3A3D5568AF297CD5, p0);
        }

        public static void _DOWNLOAD_CHECK()
        {
            Invoker.Call<Void>(0x4F18196C8D38768D);
        }

        public static int _0xC7ABAC5DE675EE3B()
        {
            return Invoker.Call<int>(0xC7ABAC5DE675EE3B);
        }

        public static int NETWORK_ENABLE_MOTION_DRUGGED()
        {
            return Invoker.Call<int>(0x0B0CC10720653F3B);
        }

        public static int _0x8B0C2964BA471961()
        {
            return Invoker.Call<int>(0x8B0C2964BA471961);
        }

        public static int _0x88B588B41FF7868E()
        {
            return Invoker.Call<int>(0x88B588B41FF7868E);
        }

        public static int _0x67FC09BC554A75E5()
        {
            return Invoker.Call<int>(0x67FC09BC554A75E5);
        }

        public static void _0x966DD84FB6A46017()
        {
            Invoker.Call<Void>(0x966DD84FB6A46017);
        }

        public static bool _0x152D90E4C1B4738A(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x152D90E4C1B4738A, p0_ptr, p1_ptr);
        }

        public static int _0x9FEDF86898F100E9()
        {
            return Invoker.Call<int>(0x9FEDF86898F100E9);
        }

        public static int _0x5E24341A7F92A74B()
        {
            return Invoker.Call<int>(0x5E24341A7F92A74B);
        }

        public static int _0x24E4E51FC16305F9()
        {
            return Invoker.Call<int>(0x24E4E51FC16305F9);
        }

        public static int _0xFBC5E768C7A77A6A()
        {
            return Invoker.Call<int>(0xFBC5E768C7A77A6A);
        }

        public static int _0xC55A0B40FFB1ED23()
        {
            return Invoker.Call<int>(0xC55A0B40FFB1ED23);
        }

        public static void _0x17440AA15D1D3739()
        {
            Invoker.Call<Void>(0x17440AA15D1D3739);
        }

        public static bool _0x9BF438815F5D96EA(int p0, int p1, ulong p2_ptr, int p3, int p4, int p5)
        {
            return Invoker.Call<bool>(0x9BF438815F5D96EA, p0, p1, p2_ptr, p3, p4, p5);
        }

        public static bool _0x692D58DF40657E8C(int p0, int p1, int p2, ulong p3_ptr, int p4, bool p5)
        {
            return Invoker.Call<bool>(0x692D58DF40657E8C, p0, p1, p2, p3_ptr, p4, p5);
        }

        public static bool _0x158EC424F35EC469(string p0, bool p1, string contentType)
        {
            return Invoker.Call<bool>(0x158EC424F35EC469, p0, p1, contentType);
        }

        public static bool _0xC7397A83F7A2A462(ulong p0_ptr, int p1, bool p2, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0xC7397A83F7A2A462, p0_ptr, p1, p2, p3_ptr);
        }

        public static bool _0x6D4CB481FAC835E8(int p0, int p1, ulong p2_ptr, int p3)
        {
            return Invoker.Call<bool>(0x6D4CB481FAC835E8, p0, p1, p2_ptr, p3);
        }

        public static bool _0xD5A4B59980401588(int p0, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0xD5A4B59980401588, p0, p1, p2_ptr, p3_ptr);
        }

        public static bool _0x3195F8DD0D531052(int p0, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0x3195F8DD0D531052, p0, p1, p2_ptr, p3_ptr);
        }

        public static bool _0xF9E1CCAE8BA4C281(int p0, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0xF9E1CCAE8BA4C281, p0, p1, p2_ptr, p3_ptr);
        }

        public static bool _0x9F6E2821885CAEE2(int p0, int p1, int p2, ulong p3_ptr, ulong p4_ptr)
        {
            return Invoker.Call<bool>(0x9F6E2821885CAEE2, p0, p1, p2, p3_ptr, p4_ptr);
        }

        public static bool _0x678BB03C1A3BD51E(int p0, int p1, int p2, ulong p3_ptr, ulong p4_ptr)
        {
            return Invoker.Call<bool>(0x678BB03C1A3BD51E, p0, p1, p2, p3_ptr, p4_ptr);
        }

        public static bool SET_BALANCE_ADD_MACHINE(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x815E5E3073DA1D67, p0_ptr, p1_ptr);
        }

        public static bool SET_BALANCE_ADD_MACHINES(ulong p0_ptr, int p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xB8322EEB38BE7C26, p0_ptr, p1, p2_ptr);
        }

        public static bool _0xA7862BC5ED1DFD7E(int p0, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0xA7862BC5ED1DFD7E, p0, p1, p2_ptr, p3_ptr);
        }

        public static bool NETWORK_GET_BACKGROUND_LOADING_RECIPIENTS(int p0, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0x97A770BEEF227E2B, p0, p1, p2_ptr, p3_ptr);
        }

        public static bool _0x5324A0E3E4CE3570(int p0, int p1, ulong p2_ptr, ulong p3_ptr)
        {
            return Invoker.Call<bool>(0x5324A0E3E4CE3570, p0, p1, p2_ptr, p3_ptr);
        }

        public static void _0xE9B99B6853181409()
        {
            Invoker.Call<Void>(0xE9B99B6853181409);
        }

        public static int _0xD53ACDBEF24A46E8()
        {
            return Invoker.Call<int>(0xD53ACDBEF24A46E8);
        }

        public static int _0x02ADA21EA2F6918F()
        {
            return Invoker.Call<int>(0x02ADA21EA2F6918F);
        }

        public static int _0x941E5306BCD7C2C7()
        {
            return Invoker.Call<int>(0x941E5306BCD7C2C7);
        }

        public static int _0xC87E740D9F3872CC()
        {
            return Invoker.Call<int>(0xC87E740D9F3872CC);
        }

        public static int _0xEDF7F927136C224B()
        {
            return Invoker.Call<int>(0xEDF7F927136C224B);
        }

        public static int _0xE0A6138401BCB837()
        {
            return Invoker.Call<int>(0xE0A6138401BCB837);
        }

        public static int _0x769951E2455E2EB5()
        {
            return Invoker.Call<int>(0x769951E2455E2EB5);
        }

        public static int _0x3A17A27D75C74887()
        {
            return Invoker.Call<int>(0x3A17A27D75C74887);
        }

        public static void _0xBA96394A0EECFA65()
        {
            Invoker.Call<Void>(0xBA96394A0EECFA65);
        }

        public static string GET_PLAYER_ADVANCED_MODIFIER_PRIVILEGES(int p0)
        {
            return Invoker.Call<string>(0xCD67AD041A394C9C, p0);
        }

        public static bool _0x584770794D758C18(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x584770794D758C18, p0, p1_ptr);
        }

        public static bool _0x8C8D2739BA44AF0F(int p0)
        {
            return Invoker.Call<bool>(0x8C8D2739BA44AF0F, p0);
        }

        public static int _0x703F12425ECA8BF5(int p0)
        {
            return Invoker.Call<int>(0x703F12425ECA8BF5, p0);
        }

        public static bool _0xAEAB987727C5A8A4(int p0)
        {
            return Invoker.Call<bool>(0xAEAB987727C5A8A4, p0);
        }

        public static int _GET_CONTENT_CATEGORY(int p0)
        {
            return Invoker.Call<int>(0xA7BAB11E7C9C6C5A, p0);
        }

        public static string _GET_CONTENT_ID(int p0)
        {
            return Invoker.Call<string>(0x55AA95F481D694D2, p0);
        }

        public static string _GET_ROOT_CONTENT_ID(int p0)
        {
            return Invoker.Call<string>(0xC0173D6BFF4E0348, p0);
        }

        public static int _0xBF09786A7FCAB582(int p0)
        {
            return Invoker.Call<int>(0xBF09786A7FCAB582, p0);
        }

        public static int _GET_CONTENT_DESCRIPTION_HASH(int p0)
        {
            return Invoker.Call<int>(0x7CF0448787B23758, p0);
        }

        public static int _0xBAF6BABF9E7CCC13(int p0, ulong p1_ptr)
        {
            return Invoker.Call<int>(0xBAF6BABF9E7CCC13, p0, p1_ptr);
        }

        public static void _0xCFD115B373C0DF63(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0xCFD115B373C0DF63, p0, p1_ptr);
        }

        public static int _GET_CONTENT_FILE_VERSION(int p0, int p1)
        {
            return Invoker.Call<int>(0x37025B27D9B658B1, p0, p1);
        }

        public static bool _0x1D610EB0FEA716D9(int p0)
        {
            return Invoker.Call<bool>(0x1D610EB0FEA716D9, p0);
        }

        public static bool _0x7FCC39C46C3C03BD(int p0)
        {
            return Invoker.Call<bool>(0x7FCC39C46C3C03BD, p0);
        }

        public static int _0x32DD916F3F7C9672(int p0)
        {
            return Invoker.Call<int>(0x32DD916F3F7C9672, p0);
        }

        public static bool _0x3054F114121C21EA(int p0)
        {
            return Invoker.Call<bool>(0x3054F114121C21EA, p0);
        }

        public static bool _0xA9240A96C74CCA13(int p0)
        {
            return Invoker.Call<bool>(0xA9240A96C74CCA13, p0);
        }

        public static int _0x1ACCFBA3D8DAB2EE(int p0, int p1)
        {
            return Invoker.Call<int>(0x1ACCFBA3D8DAB2EE, p0, p1);
        }

        public static int _0x759299C5BB31D2A9(int p0, int p1)
        {
            return Invoker.Call<int>(0x759299C5BB31D2A9, p0, p1);
        }

        public static int _0x87E5C46C187FE0AE(int p0, int p1)
        {
            return Invoker.Call<int>(0x87E5C46C187FE0AE, p0, p1);
        }

        public static int _0x4E548C0D7AE39FF9(int p0, int p1)
        {
            return Invoker.Call<int>(0x4E548C0D7AE39FF9, p0, p1);
        }

        public static bool _0x70EA8DA57840F9BE(int p0)
        {
            return Invoker.Call<bool>(0x70EA8DA57840F9BE, p0);
        }

        public static bool _0x993CBE59D350D225(int p0)
        {
            return Invoker.Call<bool>(0x993CBE59D350D225, p0);
        }

        public static int _0x171DF6A0C07FB3DC(int p0, int p1)
        {
            return Invoker.Call<int>(0x171DF6A0C07FB3DC, p0, p1);
        }

        public static int _0x7FD2990AF016795E(ulong p0_ptr, ulong p1_ptr, int p2, int p3, int p4)
        {
            return Invoker.Call<int>(0x7FD2990AF016795E, p0_ptr, p1_ptr, p2, p3, p4);
        }

        public static int _0x5E0165278F6339EE(int p0)
        {
            return Invoker.Call<int>(0x5E0165278F6339EE, p0);
        }

        public static bool _0x2D5DC831176D0114(int p0)
        {
            return Invoker.Call<bool>(0x2D5DC831176D0114, p0);
        }

        public static bool _0xEBFA8D50ADDC54C4(int p0)
        {
            return Invoker.Call<bool>(0xEBFA8D50ADDC54C4, p0);
        }

        public static bool _0x162C23CA83ED0A62(int p0)
        {
            return Invoker.Call<bool>(0x162C23CA83ED0A62, p0);
        }

        public static int _0x40F7E66472DF3E5C(int p0, int p1)
        {
            return Invoker.Call<int>(0x40F7E66472DF3E5C, p0, p1);
        }

        public static bool _0x5A34CD9C3C5BEC44(int p0)
        {
            return Invoker.Call<bool>(0x5A34CD9C3C5BEC44, p0);
        }

        public static void _0x68103E2247887242()
        {
            Invoker.Call<Void>(0x68103E2247887242);
        }

        public static bool _0x1DE0F5F50D723CAA(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x1DE0F5F50D723CAA, p0_ptr, p1_ptr, p2_ptr);
        }

        public static bool _0x274A1519DFC1094F(ulong p0_ptr, bool p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x274A1519DFC1094F, p0_ptr, p1, p2_ptr);
        }

        public static bool _0xD05D1A6C74DA3498(ulong p0_ptr, bool p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xD05D1A6C74DA3498, p0_ptr, p1, p2_ptr);
        }

        public static int _0x45E816772E93A9DB()
        {
            return Invoker.Call<int>(0x45E816772E93A9DB);
        }

        public static int _0x299EF3C576773506()
        {
            return Invoker.Call<int>(0x299EF3C576773506);
        }

        public static int _0x793FF272D5B365F4()
        {
            return Invoker.Call<int>(0x793FF272D5B365F4);
        }

        public static int _0x5A0A3D1A186A5508()
        {
            return Invoker.Call<int>(0x5A0A3D1A186A5508);
        }

        public static void _0xA1E5E0204A6FCC70()
        {
            Invoker.Call<Void>(0xA1E5E0204A6FCC70);
        }

        public static bool _0xB746D20B17F2A229(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xB746D20B17F2A229, p0_ptr, p1_ptr);
        }

        public static int _0x63B406D7884BFA95()
        {
            return Invoker.Call<int>(0x63B406D7884BFA95);
        }

        public static int _0x4D02279C83BE69FE()
        {
            return Invoker.Call<int>(0x4D02279C83BE69FE);
        }

        public static int _0x597F8DBA9B206FC7()
        {
            return Invoker.Call<int>(0x597F8DBA9B206FC7);
        }

        public static bool _0x5CAE833B0EE0C500(int p0)
        {
            return Invoker.Call<bool>(0x5CAE833B0EE0C500, p0);
        }

        public static void _0x61A885D3F7CFEE9A()
        {
            Invoker.Call<Void>(0x61A885D3F7CFEE9A);
        }

        public static void _0xF98DDE0A8ED09323(bool p0)
        {
            Invoker.Call<Void>(0xF98DDE0A8ED09323, p0);
        }

        public static void _0xFD75DABC0957BF33(bool p0)
        {
            Invoker.Call<Void>(0xFD75DABC0957BF33, p0);
        }

        public static bool _0xF53E48461B71EECB(int p0)
        {
            return Invoker.Call<bool>(0xF53E48461B71EECB, p0);
        }

        public static bool _FACEBOOK_SET_HEIST_COMPLETE(string heistName, int cashEarned, int xpEarned)
        {
            return Invoker.Call<bool>(0x098AB65B9ED9A9EC, heistName, cashEarned, xpEarned);
        }

        public static bool _FACEBOOK_SET_CREATE_CHARACTER_COMPLETE()
        {
            return Invoker.Call<bool>(0xDC48473142545431);
        }

        public static bool _FACEBOOK_SET_MILESTONE_COMPLETE(int milestoneId)
        {
            return Invoker.Call<bool>(0x0AE1F1653B554AB9, milestoneId);
        }

        public static bool _FACEBOOK_IS_SENDING_DATA()
        {
            return Invoker.Call<bool>(0x62B9FEC9A11F10EF);
        }

        public static bool _FACEBOOK_DO_UNK_CHECK()
        {
            return Invoker.Call<bool>(0xA75E2B6733DA5142);
        }

        public static bool _FACEBOOK_IS_AVAILABLE()
        {
            return Invoker.Call<bool>(0x43865688AE10F0D7);
        }

        public static int TEXTURE_DOWNLOAD_REQUEST(ulong PlayerHandle_ptr, string FilePath, string Name, bool p3)
        {
            return Invoker.Call<int>(0x16160DA74A8E74A2, PlayerHandle_ptr, FilePath, Name, p3);
        }

        public static int _0x0B203B4AFDE53A4F(ulong p0_ptr, ulong p1_ptr, bool p2)
        {
            return Invoker.Call<int>(0x0B203B4AFDE53A4F, p0_ptr, p1_ptr, p2);
        }

        public static int _0x308F96458B7087CC(ulong p0_ptr, int p1, int p2, int p3, ulong p4_ptr, bool p5)
        {
            return Invoker.Call<int>(0x308F96458B7087CC, p0_ptr, p1, p2, p3, p4_ptr, p5);
        }

        public static void TEXTURE_DOWNLOAD_RELEASE(int p0)
        {
            Invoker.Call<Void>(0x487EB90B98E9FB19, p0);
        }

        public static bool TEXTURE_DOWNLOAD_HAS_FAILED(int p0)
        {
            return Invoker.Call<bool>(0x5776ED562C134687, p0);
        }

        public static string TEXTURE_DOWNLOAD_GET_NAME(int p0)
        {
            return Invoker.Call<string>(0x3448505B6E35262D, p0);
        }

        public static int _0x8BD6C6DEA20E82C6(int p0)
        {
            return Invoker.Call<int>(0x8BD6C6DEA20E82C6, p0);
        }

        public static int _0x60EDD13EB3AC1FF3()
        {
            return Invoker.Call<int>(0x60EDD13EB3AC1FF3);
        }

        public static bool NETWORK_IS_CABLE_CONNECTED()
        {
            return Invoker.Call<bool>(0xEFFB25453D8600F9);
        }

        public static int _0x66B59CFFD78467AF()
        {
            return Invoker.Call<int>(0x66B59CFFD78467AF);
        }

        public static int _0x606E4D3E3CCCF3EB()
        {
            return Invoker.Call<int>(0x606E4D3E3CCCF3EB);
        }

        public static bool _IS_ROCKSTAR_BANNED()
        {
            return Invoker.Call<bool>(0x8020A73847E0CA7D);
        }

        public static bool _IS_SOCIALCLUB_BANNED()
        {
            return Invoker.Call<bool>(0xA0AD7E2AF5349F61);
        }

        public static bool _CAN_PLAY_ONLINE()
        {
            return Invoker.Call<bool>(0x5F91D5D0B36AA310);
        }

        public static bool _0x422D396F80A96547()
        {
            return Invoker.Call<bool>(0x422D396F80A96547);
        }

        public static bool _0xA699957E60D80214(int p0)
        {
            return Invoker.Call<bool>(0xA699957E60D80214, p0);
        }

        public static bool _0xC22912B1D85F26B1(int p0, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xC22912B1D85F26B1, p0, p1_ptr, p2_ptr);
        }

        public static int _0x593570C289A77688()
        {
            return Invoker.Call<int>(0x593570C289A77688);
        }

        public static int _0x91B87C55093DE351()
        {
            return Invoker.Call<int>(0x91B87C55093DE351);
        }

        public static int _0x36391F397731595D(int p0)
        {
            return Invoker.Call<int>(0x36391F397731595D, p0);
        }

        public static int _0xDEB2B99A1AF1A2A6(int p0)
        {
            return Invoker.Call<int>(0xDEB2B99A1AF1A2A6, p0);
        }

        public static void _0x9465E683B12D3F6B()
        {
            Invoker.Call<Void>(0x9465E683B12D3F6B);
        }

        public static void _NETWORK_UPDATE_PLAYER_SCARS()
        {
            Invoker.Call<Void>(0xB7C7F6AD6424304B);
        }

        public static void _0xC505036A35AFD01B(bool p0)
        {
            Invoker.Call<Void>(0xC505036A35AFD01B, p0);
        }

        public static void _0x267C78C60E806B9A(int p0, bool p1)
        {
            Invoker.Call<Void>(0x267C78C60E806B9A, p0, p1);
        }

        public static void _0x6BFF5F84102DF80A(int p0)
        {
            Invoker.Call<Void>(0x6BFF5F84102DF80A, p0);
        }

        public static void _0x5C497525F803486B()
        {
            Invoker.Call<Void>(0x5C497525F803486B);
        }

        public static int _0x6FB7BB3607D27FA2()
        {
            return Invoker.Call<int>(0x6FB7BB3607D27FA2);
        }

        public static void _0x45A83257ED02D9BC()
        {
            Invoker.Call<Void>(0x45A83257ED02D9BC);
        }

    }

    public static class NETWORKCASH
    {

        public static void NETWORK_INITIALIZE_CASH(int p0, int p1)
        {
            Invoker.Call<Void>(0x3DA5ECD1A56CBA6D, p0, p1);
        }

        public static void NETWORK_DELETE_CHARACTER(int characterIndex, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x05A50AF38947EB8D, characterIndex, p1, p2);
        }

        public static void NETWORK_CLEAR_CHARACTER_WALLET(int p0)
        {
            Invoker.Call<Void>(0xA921DED15FDF28F5, p0);
        }

        public static void NETWORK_GIVE_PLAYER_JOBSHARE_CASH(int amount, ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0xFB18DF9CB95E0105, amount, networkHandle_ptr);
        }

        public static void NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH(int value, ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0x56A3B51944C50598, value, networkHandle_ptr);
        }

        public static int _0x1C2473301B1C66BA()
        {
            return Invoker.Call<int>(0x1C2473301B1C66BA);
        }

        public static void NETWORK_REFUND_CASH(int index, string context, string reason, bool unk)
        {
            Invoker.Call<Void>(0xF9C812CD7C46E817, index, context, reason, unk);
        }

        public static bool NETWORK_MONEY_CAN_BET(int p0, bool p1, bool p2)
        {
            return Invoker.Call<bool>(0x81404F3DC124FE5B, p0, p1, p2);
        }

        public static bool NETWORK_CAN_BET(int p0)
        {
            return Invoker.Call<bool>(0x3A54E33660DED67F, p0);
        }

        public static int NETWORK_EARN_FROM_PICKUP(int amount)
        {
            return Invoker.Call<int>(0xED1517D3AF17C698, amount);
        }

        public static void _NETWORK_EARN_FROM_GANG_PICKUP(int amount)
        {
            Invoker.Call<Void>(0xA03D4ACE0A3284CE, amount);
        }

        public static void _NETWORK_EARN_FROM_ARMOUR_TRUCK(int amount)
        {
            Invoker.Call<Void>(0xF514621E8EA463D0, amount);
        }

        public static void NETWORK_EARN_FROM_CRATE_DROP(int amount)
        {
            Invoker.Call<Void>(0xB1CC1B9EC3007A2A, amount);
        }

        public static void NETWORK_EARN_FROM_BETTING(int amount, string p1)
        {
            Invoker.Call<Void>(0x827A5BA1A44ACA6D, amount, p1);
        }

        public static void NETWORK_EARN_FROM_JOB(int amount, string p1)
        {
            Invoker.Call<Void>(0xB2CC4836834E8A98, amount, p1);
        }

        public static void NETWORK_EARN_FROM_MISSION_H(int amount, string heistHash)
        {
            Invoker.Call<Void>(0x61326EE6DF15B0CA, amount, heistHash);
        }

        public static void NETWORK_EARN_FROM_CHALLENGE_WIN(int p0, ulong p1_ptr, bool p2)
        {
            Invoker.Call<Void>(0x2B171E6B2F64D8DF, p0, p1_ptr, p2);
        }

        public static void NETWORK_EARN_FROM_BOUNTY(int amount, ulong networkHandle_ptr, ulong p2_ptr, int p3)
        {
            Invoker.Call<Void>(0x131BB5DA15453ACF, amount, networkHandle_ptr, p2_ptr, p3);
        }

        public static void NETWORK_EARN_FROM_IMPORT_EXPORT(int p0, int p1)
        {
            Invoker.Call<Void>(0xF92A014A634442D6, p0, p1);
        }

        public static void NETWORK_EARN_FROM_HOLDUPS(int amount)
        {
            Invoker.Call<Void>(0x45B8154E077D9E4D, amount);
        }

        public static void NETWORK_EARN_FROM_PROPERTY(int amount, int propertyName)
        {
            Invoker.Call<Void>(0x849648349D77F5C5, amount, propertyName);
        }

        public static void NETWORK_EARN_FROM_AI_TARGET_KILL(int p0, int p1)
        {
            Invoker.Call<Void>(0x515B4A22E4D3C6D7, p0, p1);
        }

        public static void NETWORK_EARN_FROM_NOT_BADSPORT(int amount)
        {
            Invoker.Call<Void>(0x4337511FA8221D36, amount);
        }

        public static void NETWORK_EARN_FROM_ROCKSTAR(int amount)
        {
            Invoker.Call<Void>(0x02CE1D6AC0FC73EA, amount);
        }

        public static void NETWORK_EARN_FROM_VEHICLE(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7)
        {
            Invoker.Call<Void>(0xB539BD8A4C1EECF8, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        public static void NETWORK_EARN_FROM_PERSONAL_VEHICLE(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
        {
            Invoker.Call<Void>(0x3F4D00167E41E0AD, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public static void _NETWORK_EARN_FROM_DAILY_OBJECTIVE(int p0, string p1, int p2)
        {
            Invoker.Call<Void>(0x6EA318C91C1A8786, p0, p1, p2);
        }

        public static void _NETWORK_EARN_FROM_AMBIENT_JOB(int p0, string p1, ulong p2_ptr)
        {
            Invoker.Call<Void>(0xFB6DB092FBAE29E6, p0, p1, p2_ptr);
        }

        public static void _NETWORK_EARN_FROM_JOB_BONUS(int p0, ulong p1_ptr, ulong p2_ptr)
        {
            Invoker.Call<Void>(0x6816FB4416760775, p0, p1_ptr, p2_ptr);
        }

        public static bool NETWORK_CAN_SPEND_MONEY(int p0, bool p1, bool p2, bool p3, int p4)
        {
            return Invoker.Call<bool>(0xAB3CAA6B422164DA, p0, p1, p2, p3, p4);
        }

        public static bool _0x7303E27CC6532080(int p0, bool p1, bool p2, bool p3, ulong p4_ptr, int p5)
        {
            return Invoker.Call<bool>(0x7303E27CC6532080, p0, p1, p2, p3, p4_ptr, p5);
        }

        public static void NETWORK_BUY_ITEM(int player, int item, int p2, int p3, bool p4, string item_name, int p6, int p7, int p8, bool p9)
        {
            Invoker.Call<Void>(0xF0077C797F66A355, player, item, p2, p3, p4, item_name, p6, p7, p8, p9);
        }

        public static void NETWORK_SPENT_TAXI(int amount, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x17C3A7D31EAE39F9, amount, p1, p2);
        }

        public static void NETWORK_PAY_EMPLOYEE_WAGE(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x5FD5ED82CBBE9989, p0, p1, p2);
        }

        public static void NETWORK_PAY_UTILITY_BILL(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xAFE08B35EC0C9EAE, p0, p1, p2);
        }

        public static void NETWORK_PAY_MATCH_ENTRY_FEE(int value, ulong p1_ptr, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x9346E14F2AF74D46, value, p1_ptr, p2, p3);
        }

        public static void NETWORK_SPENT_BETTING(int p0, int p1, ulong p2_ptr, bool p3, bool p4)
        {
            Invoker.Call<Void>(0x1C436FD11FFA692F, p0, p1, p2_ptr, p3, p4);
        }

        public static void NETWORK_SPENT_IN_STRIPCLUB(int p0, bool p1, int p2, bool p3)
        {
            Invoker.Call<Void>(0xEE99784E4467689C, p0, p1, p2, p3);
        }

        public static void NETWORK_BUY_HEALTHCARE(int cost, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xD9B067E55253E3DD, cost, p1, p2);
        }

        public static void NETWORK_BUY_AIRSTRIKE(int cost, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x763B4BD305338F19, cost, p1, p2);
        }

        public static void NETWORK_BUY_HELI_STRIKE(int cost, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x81AA4610E3FD3A69, cost, p1, p2);
        }

        public static void NETWORK_SPENT_AMMO_DROP(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xB162DC95C0A3317B, p0, p1, p2);
        }

        public static void NETWORK_BUY_BOUNTY(int amount, int victim, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x7B718E197453F2D9, amount, victim, p2, p3);
        }

        public static void NETWORK_BUY_PROPERTY(float propertyCost, int propertyName, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x650A08A280870AF6, propertyCost, propertyName, p2, p3);
        }

        public static void NETWORK_SPENT_HELI_PICKUP(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x7BF1D73DB2ECA492, p0, p1, p2);
        }

        public static void NETWORK_SPENT_BOAT_PICKUP(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x524EE43A37232C00, p0, p1, p2);
        }

        public static void NETWORK_SPENT_BULL_SHARK(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xA6DD8458CE24012C, p0, p1, p2);
        }

        public static void NETWORK_SPENT_CASH_DROP(int amount, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x289016EC778D60E0, amount, p1, p2);
        }

        public static void NETWORK_SPENT_HIRE_MUGGER(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xE404BFB981665BF0, p0, p1, p2);
        }

        public static void NETWORK_SPENT_ROBBED_BY_MUGGER(int amount, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x995A65F15F581359, amount, p1, p2);
        }

        public static void NETWORK_SPENT_HIRE_MERCENARY(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xE7B80E2BF9D80BD6, p0, p1, p2);
        }

        public static void NETWORK_SPENT_BUY_WANTEDLEVEL(int p0, ulong p1_ptr, bool p2, bool p3)
        {
            Invoker.Call<Void>(0xE1B13771A843C4F6, p0, p1_ptr, p2, p3);
        }

        public static void NETWORK_SPENT_BUY_OFFTHERADAR(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xA628A745E2275C5D, p0, p1, p2);
        }

        public static void NETWORK_SPENT_BUY_REVEAL_PLAYERS(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x6E176F1B18BC0637, p0, p1, p2);
        }

        public static void NETWORK_SPENT_CARWASH(int p0, int p1, int p2, bool p3, bool p4)
        {
            Invoker.Call<Void>(0xEC03C719DB2F4306, p0, p1, p2, p3, p4);
        }

        public static void NETWORK_SPENT_CINEMA(int p0, int p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x6B38ECB05A63A685, p0, p1, p2, p3);
        }

        public static void NETWORK_SPENT_TELESCOPE(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x7FE61782AD94CC09, p0, p1, p2);
        }

        public static void NETWORK_SPENT_HOLDUPS(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xD9B86B9872039763, p0, p1, p2);
        }

        public static void NETWORK_SPENT_BUY_PASSIVE_MODE(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x6D3A430D1A809179, p0, p1, p2);
        }

        public static void NETWORK_SPENT_PROSTITUTES(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xB21B89501CFAC79E, p0, p1, p2);
        }

        public static void NETWORK_SPENT_ARREST_BAIL(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x812F5488B1B2A299, p0, p1, p2);
        }

        public static void NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM(int amount, int vehicleModel, ulong networkHandle_ptr, bool notBankrupt, bool hasTheMoney)
        {
            Invoker.Call<Void>(0x9FF28D88C766E3E8, amount, vehicleModel, networkHandle_ptr, notBankrupt, hasTheMoney);
        }

        public static void NETWORK_SPENT_CALL_PLAYER(int p0, ulong p1_ptr, bool p2, bool p3)
        {
            Invoker.Call<Void>(0xACDE7185B374177C, p0, p1_ptr, p2, p3);
        }

        public static void NETWORK_SPENT_BOUNTY(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x29B260B84947DFCC, p0, p1, p2);
        }

        public static void NETWORK_SPENT_FROM_ROCKSTAR(int bank, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x6A445B64ED7ABEB5, bank, p1, p2);
        }

        public static string PROCESS_CASH_GIFT(ulong p0_ptr, ulong p1_ptr, string p2)
        {
            return Invoker.Call<string>(0x20194D48EAEC9A41, p0_ptr, p1_ptr, p2);
        }

        public static void NETWORK_SPENT_PLAYER_HEALTHCARE(int p0, int p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x7C99101F7FCE2EE5, p0, p1, p2, p3);
        }

        public static void NETWORK_SPENT_NO_COPS(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0xD5BB406F4E04019F, p0, p1, p2);
        }

        public static void NETWORK_SPENT_REQUEST_JOB(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x8204DA7934DF3155, p0, p1, p2);
        }

        public static void _NETWORK_SPENT_REQUEST_HEIST(int p0, bool p1, bool p2)
        {
            Invoker.Call<Void>(0x9D26502BB97BFE62, p0, p1, p2);
        }

        public static void NETWORK_BUY_FAIRGROUND_RIDE(int amountSpent, int p1, bool p2, bool p3)
        {
            Invoker.Call<Void>(0x8A7B3952DD64D2B5, amountSpent, p1, p2, p3);
        }

        public static bool _0x7C4FCCD2E4DEB394()
        {
            return Invoker.Call<bool>(0x7C4FCCD2E4DEB394);
        }

        public static int NETWORK_GET_VC_BANK_BALANCE()
        {
            return Invoker.Call<int>(0x76EF28DA05EA395A);
        }

        public static int NETWORK_GET_VC_WALLET_BALANCE(int character)
        {
            return Invoker.Call<int>(0xA40F9C2623F6A8B5, character);
        }

        public static int NETWORK_GET_VC_BALANCE()
        {
            return Invoker.Call<int>(0x5CBAD97E059E1B94);
        }

        public static string _NETWORK_GET_BANK_BALANCE_STRING()
        {
            return Invoker.Call<string>(0xA6FA3979BED01B81);
        }

        public static bool _0xDC18531D7019A535(int p0, int p1)
        {
            return Invoker.Call<bool>(0xDC18531D7019A535, p0, p1);
        }

        public static bool NETWORK_CAN_RECEIVE_PLAYER_CASH(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<bool>(0x5D17BE59D2123284, p0, p1, p2, p3);
        }

        public static int _0xF70EFA14FE091429(int p0)
        {
            return Invoker.Call<int>(0xF70EFA14FE091429, p0);
        }

        public static bool _0xE260E0BB9CD995AC(int p0)
        {
            return Invoker.Call<bool>(0xE260E0BB9CD995AC, p0);
        }

        public static bool _0xE154B48B68EF72BC(int p0)
        {
            return Invoker.Call<bool>(0xE154B48B68EF72BC, p0);
        }

        public static ulong _0x6FCF8DDEA146C45B(int p0)
        {
            return Invoker.Call<ulong>(0x6FCF8DDEA146C45B, p0);
        }

    }

    public static class DLC1
    {

        public static int _GET_NUM_DECORATIONS(int character)
        {
            return Invoker.Call<int>(0x278F76C3B0A8F109, character);
        }

        public static bool _0xFF56381874F82086(int p0, int p1, ulong _outComponent_ptr)
        {
            return Invoker.Call<bool>(0xFF56381874F82086, p0, p1, _outComponent_ptr);
        }

        public static void INIT_SHOP_PED_COMPONENT(ulong _outComponent_ptr)
        {
            Invoker.Call<Void>(0x1E8C308FD312C036, _outComponent_ptr);
        }

        public static void INIT_SHOP_PED_PROP(ulong _outProp_ptr)
        {
            Invoker.Call<Void>(0xEB0A2B758F7B850F, _outProp_ptr);
        }

        public static int _0x50F457823CE6EB5F(int p0, int p1, int p2, int p3)
        {
            return Invoker.Call<int>(0x50F457823CE6EB5F, p0, p1, p2, p3);
        }

        public static int _GET_NUM_PROPS_FROM_OUTFIT(int character, int p1, int p2, bool p3, int p4, int componentId)
        {
            return Invoker.Call<int>(0x9BDF59818B1E38C1, character, p1, p2, p3, p4, componentId);
        }

        public static void GET_SHOP_PED_QUERY_COMPONENT(int componentId, ulong _outComponent_ptr)
        {
            Invoker.Call<Void>(0x249E310B2D920699, componentId, _outComponent_ptr);
        }

        public static void GET_SHOP_PED_COMPONENT(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0x74C0E2A57EC66760, p0, p1_ptr);
        }

        public static void GET_SHOP_PED_QUERY_PROP(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0xDE44A00999B2837D, p0, p1_ptr);
        }

        public static void _0x5D5CAFF661DDF6FC(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0x5D5CAFF661DDF6FC, p0, p1_ptr);
        }

        public static int GET_HASH_NAME_FOR_COMPONENT(int entity, int componentId, int drawableVariant, int textureVariant)
        {
            return Invoker.Call<int>(0x0368B3A838070348, entity, componentId, drawableVariant, textureVariant);
        }

        public static int GET_HASH_NAME_FOR_PROP(int entity, int componentId, int propIndex, int propTextureIndex)
        {
            return Invoker.Call<int>(0x5D6160275CAEC8DD, entity, componentId, propIndex, propTextureIndex);
        }

        public static int _0xC17AD0E5752BECDA(int componentHash)
        {
            return Invoker.Call<int>(0xC17AD0E5752BECDA, componentHash);
        }

        public static void GET_VARIANT_COMPONENT(int componentHash, int componentId, ulong p2_ptr, ulong p3_ptr, ulong p4_ptr)
        {
            Invoker.Call<Void>(0x6E11F282F11863B6, componentHash, componentId, p2_ptr, p3_ptr, p4_ptr);
        }

        public static int _GET_NUM_FORCED_COMPONENTS(int componentHash)
        {
            return Invoker.Call<int>(0xC6B9DB42C04DD8C3, componentHash);
        }

        public static int _0x017568A8182D98A6(int p0)
        {
            return Invoker.Call<int>(0x017568A8182D98A6, p0);
        }

        public static void GET_FORCED_COMPONENT(int componentHash, int componentId, ulong p2_ptr, ulong p3_ptr, ulong p4_ptr)
        {
            Invoker.Call<Void>(0x6C93ED8C2F74859B, componentHash, componentId, p2_ptr, p3_ptr, p4_ptr);
        }

        public static void _0xE1CA84EBF72E691D(int p0, int p1, ulong p2_ptr, ulong p3_ptr, ulong p4_ptr)
        {
            Invoker.Call<Void>(0xE1CA84EBF72E691D, p0, p1, p2_ptr, p3_ptr, p4_ptr);
        }

        public static bool _0x341DE7ED1D2A1BFD(int componentHash, int drawableSlotHash, int componentId)
        {
            return Invoker.Call<bool>(0x341DE7ED1D2A1BFD, componentHash, drawableSlotHash, componentId);
        }

        public static int _0xF3FBE2D50A6A8C28(int character, bool p1)
        {
            return Invoker.Call<int>(0xF3FBE2D50A6A8C28, character, p1);
        }

        public static void GET_SHOP_PED_QUERY_OUTFIT(int p0, ulong _outfit_ptr)
        {
            Invoker.Call<Void>(0x6D793F03A631FE56, p0, _outfit_ptr);
        }

        public static void GET_SHOP_PED_OUTFIT(int p0, ulong p1_ptr)
        {
            Invoker.Call<Void>(0xB7952076E444979D, p0, p1_ptr);
        }

        public static int GET_SHOP_PED_OUTFIT_LOCATE(int p0)
        {
            return Invoker.Call<int>(0x073CA26B079F956E, p0);
        }

        public static bool _0xA9F9C2E0FDE11CBB(int p0, int p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xA9F9C2E0FDE11CBB, p0, p1, p2_ptr);
        }

        public static bool _GET_PROP_FROM_OUTFIT(int _outfit, int slot, ulong item_ptr)
        {
            return Invoker.Call<bool>(0x19F2A026EDF0013F, _outfit, slot, item_ptr);
        }

        public static int GET_NUM_DLC_VEHICLES()
        {
            return Invoker.Call<int>(0xA7A866D21CD2329B);
        }

        public static int GET_DLC_VEHICLE_MODEL(int dlcVehicleIndex)
        {
            return Invoker.Call<int>(0xECC01B7C5763333C, dlcVehicleIndex);
        }

        public static bool GET_DLC_VEHICLE_DATA(int dlcVehicleIndex, ulong _outData_ptr)
        {
            return Invoker.Call<bool>(0x33468EDC08E371F6, dlcVehicleIndex, _outData_ptr);
        }

        public static int GET_DLC_VEHICLE_FLAGS(int dlcVehicleIndex)
        {
            return Invoker.Call<int>(0x5549EE11FA22FCF2, dlcVehicleIndex);
        }

        public static int GET_NUM_DLC_WEAPONS()
        {
            return Invoker.Call<int>(0xEE47635F352DA367);
        }

        public static bool GET_DLC_WEAPON_DATA(int dlcWeaponIndex, ulong _outData_ptr)
        {
            return Invoker.Call<bool>(0x79923CD21BECE14E, dlcWeaponIndex, _outData_ptr);
        }

        public static int GET_NUM_DLC_WEAPON_COMPONENTS(int dlcWeaponIndex)
        {
            return Invoker.Call<int>(0x405425358A7D61FE, dlcWeaponIndex);
        }

        public static bool GET_DLC_WEAPON_COMPONENT_DATA(int dlcWeaponIndex, int dlcWeapCompIndex, ulong ComponentDataPtr_ptr)
        {
            return Invoker.Call<bool>(0x6CF598A2957C2BF8, dlcWeaponIndex, dlcWeapCompIndex, ComponentDataPtr_ptr);
        }

        public static bool _IS_DLC_DATA_EMPTY(ulong dlcData_ptr)
        {
            return Invoker.Call<bool>(0xD4D7B033C3AA243C, dlcData_ptr);
        }

        public static bool IS_DLC_VEHICLE_MOD(int modData)
        {
            return Invoker.Call<bool>(0x0564B9FF9631B82C, modData);
        }

        public static int _0xC098810437312FFF(int modData)
        {
            return Invoker.Call<int>(0xC098810437312FFF, modData);
        }

    }

    public static class DLC2
    {

        public static bool IS_DLC_PRESENT(int dlcHash)
        {
            return Invoker.Call<bool>(0x812595A0644CE1DE, dlcHash);
        }

        public static bool _0xF2E07819EF1A5289()
        {
            return Invoker.Call<bool>(0xF2E07819EF1A5289);
        }

        public static int _0x9489659372A81585()
        {
            return Invoker.Call<int>(0x9489659372A81585);
        }

        public static int _0xA213B11DFF526300()
        {
            return Invoker.Call<int>(0xA213B11DFF526300);
        }

        public static bool _0x8D30F648014A92B5()
        {
            return Invoker.Call<bool>(0x8D30F648014A92B5);
        }

        public static bool GET_IS_LOADING_SCREEN_ACTIVE()
        {
            return Invoker.Call<bool>(0x10D0A8F259E93EC9);
        }

        public static bool _NULLIFY(ulong variable_ptr, int unused)
        {
            return Invoker.Call<bool>(0x46E2B844905BC5F0, variable_ptr, unused);
        }

        public static void _0xD7C10C4A637992C9()
        {
            Invoker.Call<Void>(0xD7C10C4A637992C9);
        }

        public static void _LOAD_MP_DLC_MAPS()
        {
            Invoker.Call<Void>(0x0888C3502DBBEEF5);
        }

    }

    public static class SYSTEM
    {

        public static void WAIT(ulong ms_ptr)
        {
            Invoker.Call<Void>(0x4EDE34FBADD967A6, ms_ptr);
        }

        public static int START_NEW_SCRIPT(string scriptName, int stackSize)
        {
            return Invoker.Call<int>(0xE81651AD79516E48, scriptName, stackSize);
        }

        public static int START_NEW_SCRIPT_WITH_ARGS(string scriptName, ulong args_ptr, int argCount, int stackSize)
        {
            return Invoker.Call<int>(0xB8BA7F44DF1575E1, scriptName, args_ptr, argCount, stackSize);
        }

        public static int START_NEW_SCRIPT_WITH_NAME_HASH(int scriptHash, int stackSize)
        {
            return Invoker.Call<int>(0xEB1C67C3A5333A92, scriptHash, stackSize);
        }

        public static int START_NEW_SCRIPT_WITH_NAME_HASH_AND_ARGS(int scriptHash, ulong args_ptr, int argCount, int stackSize)
        {
            return Invoker.Call<int>(0xC4BB298BD441BE78, scriptHash, args_ptr, argCount, stackSize);
        }

        public static int TIMERA()
        {
            return Invoker.Call<int>(0x83666F9FB8FEBD4B);
        }

        public static int TIMERB()
        {
            return Invoker.Call<int>(0xC9D9444186B5A374);
        }

        public static void SETTIMERA(int value)
        {
            Invoker.Call<Void>(0xC1B1E9A034A63A62, value);
        }

        public static void SETTIMERB(int value)
        {
            Invoker.Call<Void>(0x5AE11BC36633DE4E, value);
        }

        public static float TIMESTEP()
        {
            return Invoker.Call<float>(0x0000000050597EE2);
        }

        public static float SIN(float value)
        {
            return Invoker.Call<float>(0x0BADBFA3B172435F, value);
        }

        public static float COS(float value)
        {
            return Invoker.Call<float>(0xD0FFB162F40A139C, value);
        }

        public static float SQRT(float value)
        {
            return Invoker.Call<float>(0x71D93B57D07F9804, value);
        }

        public static float POW(float _base, float exponent)
        {
            return Invoker.Call<float>(0xE3621CC40F31FE2E, _base, exponent);
        }

        public static float VMAG(float x, float y, float z)
        {
            return Invoker.Call<float>(0x652D2EEEF1D3E62C, x, y, z);
        }

        public static float VMAG2(float x, float y, float z)
        {
            return Invoker.Call<float>(0xA8CEACB4F35AE058, x, y, z);
        }

        public static float VDIST(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<float>(0x2A488C176D52CCA5, x1, y1, z1, x2, y2, z2);
        }

        public static float VDIST2(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return Invoker.Call<float>(0xB7A628320EFF8E47, x1, y1, z1, x2, y2, z2);
        }

        public static int SHIFT_LEFT(int value, int bitShift)
        {
            return Invoker.Call<int>(0xEDD95A39E5544DE8, value, bitShift);
        }

        public static int SHIFT_RIGHT(int value, int bitShift)
        {
            return Invoker.Call<int>(0x97EF1E5BCE9DC075, value, bitShift);
        }

        public static int FLOOR(float value)
        {
            return Invoker.Call<int>(0xF34EE736CF047844, value);
        }

        public static int CEIL(float value)
        {
            return Invoker.Call<int>(0x11E019C8F43ACC8A, value);
        }

        public static int ROUND(float value)
        {
            return Invoker.Call<int>(0xF2DB717A73826179, value);
        }

        public static float TO_FLOAT(int value)
        {
            return Invoker.Call<float>(0xBBDA792448DB5A89, value);
        }

    }

    public static class DECORATOR
    {

        public static bool DECOR_SET_TIME(int entity, string propertyName, int timestamp)
        {
            return Invoker.Call<bool>(0x95AED7B8E39ECAA4, entity, propertyName, timestamp);
        }

        public static bool DECOR_SET_BOOL(int entity, string propertyName, bool value)
        {
            return Invoker.Call<bool>(0x6B1E8E2ED1335B71, entity, propertyName, value);
        }

        public static bool _DECOR_SET_FLOAT(int entity, string propertyName, float value)
        {
            return Invoker.Call<bool>(0x211AB1DD8D0F363A, entity, propertyName, value);
        }

        public static bool DECOR_SET_INT(int entity, string propertyName, int value)
        {
            return Invoker.Call<bool>(0x0CE3AA5E1CA19E10, entity, propertyName, value);
        }

        public static bool DECOR_GET_BOOL(int entity, string propertyName)
        {
            return Invoker.Call<bool>(0xDACE671663F2F5DB, entity, propertyName);
        }

        public static float _DECOR_GET_FLOAT(int entity, string propertyName)
        {
            return Invoker.Call<float>(0x6524A2F114706F43, entity, propertyName);
        }

        public static int DECOR_GET_INT(int entity, string propertyName)
        {
            return Invoker.Call<int>(0xA06C969B02A97298, entity, propertyName);
        }

        public static bool DECOR_EXIST_ON(int entity, string propertyName)
        {
            return Invoker.Call<bool>(0x05661B80A8C9165F, entity, propertyName);
        }

        public static bool DECOR_REMOVE(int entity, string propertyName)
        {
            return Invoker.Call<bool>(0x00EE9F297C738720, entity, propertyName);
        }

        public static void DECOR_REGISTER(string propertyName, int type)
        {
            Invoker.Call<Void>(0x9FD90732F56403CE, propertyName, type);
        }

        public static bool DECOR_IS_REGISTERED_AS_TYPE(string propertyName, int type)
        {
            return Invoker.Call<bool>(0x4F14F9F870D6FBC8, propertyName, type);
        }

        public static void DECOR_REGISTER_LOCK()
        {
            Invoker.Call<Void>(0xA9D14EEA259F9248);
        }

        public static bool _0x241FCA5B1AA14F75()
        {
            return Invoker.Call<bool>(0x241FCA5B1AA14F75);
        }

    }

    public static class SOCIALCLUB
    {

        public static int _GET_TOTAL_SC_INBOX_IDS()
        {
            return Invoker.Call<int>(0x03A93FF1A2CA0864);
        }

        public static int _SC_INBOX_MESSAGE_INIT(int p0)
        {
            return Invoker.Call<int>(0xBB8EA16ECBC976C4, p0);
        }

        public static bool _IS_SC_INBOX_VALID(int p0)
        {
            return Invoker.Call<bool>(0x93028F1DB42BFD08, p0);
        }

        public static bool _SC_INBOX_MESSAGE_POP(int p0)
        {
            return Invoker.Call<bool>(0x2C015348CF19CA1D, p0);
        }

        public static bool SC_INBOX_MESSAGE_GET_DATA_INT(int p0, string context, ulong _out_ptr)
        {
            return Invoker.Call<bool>(0xA00EFE4082C4056E, p0, context, _out_ptr);
        }

        public static bool _SC_INBOX_MESSAGE_GET_DATA_BOOL(int p0, string p1)
        {
            return Invoker.Call<bool>(0xFFE5C16F402D851D, p0, p1);
        }

        public static bool SC_INBOX_MESSAGE_GET_DATA_STRING(int p0, string context, string _out)
        {
            return Invoker.Call<bool>(0x7572EF42FC6A9B6D, p0, context, _out);
        }

        public static bool _SC_INBOX_MESSAGE_PUSH(int p0)
        {
            return Invoker.Call<bool>(0x9A2C8064B6C1E41A, p0);
        }

        public static string _SC_INBOX_MESSAGE_GET_STRING(int p0)
        {
            return Invoker.Call<string>(0xF3E31D16CBDCB304, p0);
        }

        public static void _0xDA024BDBD600F44A(ulong networkHandle_ptr)
        {
            Invoker.Call<Void>(0xDA024BDBD600F44A, networkHandle_ptr);
        }

        public static void _0xA68D3D229F4F3B06(string p0)
        {
            Invoker.Call<Void>(0xA68D3D229F4F3B06, p0);
        }

        public static bool SC_INBOX_MESSAGE_GET_UGCDATA(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x69D82604A1A5A254, p0, p1_ptr);
        }

        public static bool _0x6AFD2CD753FEEF83(string playerName)
        {
            return Invoker.Call<bool>(0x6AFD2CD753FEEF83, playerName);
        }

        public static bool _0x87E0052F08BD64E6(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x87E0052F08BD64E6, p0, p1_ptr);
        }

        public static void _SC_INBOX_GET_EMAILS(int offset, int limit)
        {
            Invoker.Call<Void>(0x040ADDCBAFA1018A, offset, limit);
        }

        public static int _0x16DA8172459434AA()
        {
            return Invoker.Call<int>(0x16DA8172459434AA);
        }

        public static bool _0x4737980E8A283806(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x4737980E8A283806, p0, p1_ptr);
        }

        public static void _0x44ACA259D67651DB(ulong p0_ptr, int p1)
        {
            Invoker.Call<Void>(0x44ACA259D67651DB, p0_ptr, p1);
        }

        public static void SC_EMAIL_MESSAGE_PUSH_GAMER_TO_RECIP_LIST(ulong player_ptr)
        {
            Invoker.Call<Void>(0x2330C12A7A605D16, player_ptr);
        }

        public static void SC_EMAIL_MESSAGE_CLEAR_RECIP_LIST()
        {
            Invoker.Call<Void>(0x55DF6DB45179236E);
        }

        public static void _0x116FB94DC4B79F17(string p0)
        {
            Invoker.Call<Void>(0x116FB94DC4B79F17, p0);
        }

        public static void _0xBFA0A56A817C6C7D(bool p0)
        {
            Invoker.Call<Void>(0xBFA0A56A817C6C7D, p0);
        }

        public static int _0xBC1CC91205EC8D6E()
        {
            return Invoker.Call<int>(0xBC1CC91205EC8D6E);
        }

        public static int _0xDF649C4E9AFDD788()
        {
            return Invoker.Call<int>(0xDF649C4E9AFDD788);
        }

        public static bool _0x1F1E9682483697C7(int p0, int p1)
        {
            return Invoker.Call<bool>(0x1F1E9682483697C7, p0, p1);
        }

        public static bool _0x287F1F75D2803595(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x287F1F75D2803595, p0, p1_ptr);
        }

        public static bool _0x487912FD248EFDDF(int p0, float p1)
        {
            return Invoker.Call<bool>(0x487912FD248EFDDF, p0, p1);
        }

        public static bool _0x8416FE4E4629D7D7(string p0)
        {
            return Invoker.Call<bool>(0x8416FE4E4629D7D7, p0);
        }

        public static bool _SC_START_CHECK_STRING_TASK(string _string, ulong taskHandle_ptr)
        {
            return Invoker.Call<bool>(0x75632C5ECD7ED843, _string, taskHandle_ptr);
        }

        public static bool _SC_HAS_CHECK_STRING_TASK_COMPLETED(int taskHandle)
        {
            return Invoker.Call<bool>(0x1753344C770358AE, taskHandle);
        }

        public static int _SC_GET_CHECK_STRING_STATUS(int taskHandle)
        {
            return Invoker.Call<int>(0x82E4A58BABC15AE7, taskHandle);
        }

        public static int _0x85535ACF97FC0969(int p0)
        {
            return Invoker.Call<int>(0x85535ACF97FC0969, p0);
        }

        public static int _0x930DE22F07B1CCE3(int p0)
        {
            return Invoker.Call<int>(0x930DE22F07B1CCE3, p0);
        }

        public static bool _0xF6BAAAF762E1BF40(string p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xF6BAAAF762E1BF40, p0, p1_ptr);
        }

        public static bool _0xF22CA0FD74B80E7A(int p0)
        {
            return Invoker.Call<bool>(0xF22CA0FD74B80E7A, p0);
        }

        public static int _0x9237E334F6E43156(int p0)
        {
            return Invoker.Call<int>(0x9237E334F6E43156, p0);
        }

        public static int _0x700569DBA175A77C(int p0)
        {
            return Invoker.Call<int>(0x700569DBA175A77C, p0);
        }

        public static int _0x1D4446A62D35B0D0(int p0, int p1)
        {
            return Invoker.Call<int>(0x1D4446A62D35B0D0, p0, p1);
        }

        public static int _0x2E89990DDFF670C3(int p0, int p1)
        {
            return Invoker.Call<int>(0x2E89990DDFF670C3, p0, p1);
        }

        public static bool _0xD0EE05FE193646EA(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0xD0EE05FE193646EA, p0_ptr, p1_ptr, p2_ptr);
        }

        public static bool _0x1989C6E6F67E76A8(ulong p0_ptr, ulong p1_ptr, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x1989C6E6F67E76A8, p0_ptr, p1_ptr, p2_ptr);
        }

        public static int _0x07C61676E5BB52CD(int p0)
        {
            return Invoker.Call<int>(0x07C61676E5BB52CD, p0);
        }

        public static int _0x8147FFF6A718E1AD(int p0)
        {
            return Invoker.Call<int>(0x8147FFF6A718E1AD, p0);
        }

        public static bool _0x0F73393BAC7E6730(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x0F73393BAC7E6730, p0_ptr, p1_ptr);
        }

        public static int _0xD302E99EDF0449CF(int p0)
        {
            return Invoker.Call<int>(0xD302E99EDF0449CF, p0);
        }

        public static int _0x5C4EBFFA98BDB41C(int p0)
        {
            return Invoker.Call<int>(0x5C4EBFFA98BDB41C, p0);
        }

        public static int _0xFF8F3A92B75ED67A()
        {
            return Invoker.Call<int>(0xFF8F3A92B75ED67A);
        }

        public static int _0x4A7D6E727F941747(ulong p0_ptr)
        {
            return Invoker.Call<int>(0x4A7D6E727F941747, p0_ptr);
        }

        public static bool _0x8CC469AB4D349B7C(int p0, string p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x8CC469AB4D349B7C, p0, p1, p2_ptr);
        }

        public static bool _0x699E4A5C8C893A18(int p0, string p1, ulong p2_ptr)
        {
            return Invoker.Call<bool>(0x699E4A5C8C893A18, p0, p1, p2_ptr);
        }

        public static bool _0x19853B5B17D77BCA(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x19853B5B17D77BCA, p0, p1_ptr);
        }

        public static bool _0x6BFB12CE158E3DD4(int p0)
        {
            return Invoker.Call<bool>(0x6BFB12CE158E3DD4, p0);
        }

        public static bool _0xFE4C1D0D3B9CC17E(int p0, int p1)
        {
            return Invoker.Call<bool>(0xFE4C1D0D3B9CC17E, p0, p1);
        }

        public static int _0xD8122C407663B995()
        {
            return Invoker.Call<int>(0xD8122C407663B995);
        }

        public static bool _0x3001BEF2FECA3680()
        {
            return Invoker.Call<bool>(0x3001BEF2FECA3680);
        }

        public static bool _0x92DA6E70EF249BD1(string p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x92DA6E70EF249BD1, p0, p1_ptr);
        }

        public static void _0x675721C9F644D161()
        {
            Invoker.Call<Void>(0x675721C9F644D161);
        }

        public static int _SC_GET_NICKNAME()
        {
            return Invoker.Call<int>(0x198D161F458ECC7F);
        }

        public static bool _0x225798743970412B(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x225798743970412B, p0_ptr);
        }

        public static bool _0x418DC16FAE452C1C(int p0)
        {
            return Invoker.Call<bool>(0x418DC16FAE452C1C, p0);
        }

    }

    public static class UNK
    {

        public static int _0xF2CA003F167E21D2()
        {
            return Invoker.Call<int>(0xF2CA003F167E21D2);
        }

        public static bool _0xEF7D17BC6C85264C()
        {
            return Invoker.Call<bool>(0xEF7D17BC6C85264C);
        }

        public static void _0xB0C56BD3D808D863(bool p0)
        {
            Invoker.Call<Void>(0xB0C56BD3D808D863, p0);
        }

        public static int _0x8AA464D4E0F6ACCD()
        {
            return Invoker.Call<int>(0x8AA464D4E0F6ACCD);
        }

        public static void _IS_IN_LOADING_SCREEN(bool p0)
        {
            Invoker.Call<Void>(0xFC309E94546FCDB5, p0);
        }

        public static bool _IS_UI_LOADING_MULTIPLAYER()
        {
            return Invoker.Call<bool>(0xC6DC823253FBB366);
        }

        public static void _0xC7E7181C09F33B69(bool p0)
        {
            Invoker.Call<Void>(0xC7E7181C09F33B69, p0);
        }

        public static void _0xFA1E0E893D915215(bool p0)
        {
            Invoker.Call<Void>(0xFA1E0E893D915215, p0);
        }

        public static int _GET_CURRENT_LANGUAGE_ID()
        {
            return Invoker.Call<int>(0x2BDD44CC428A7EAE);
        }

        public static int _GET_USER_LANGUAGE_ID()
        {
            return Invoker.Call<int>(0xA8AE43AEC1A61314);
        }

    }

    public static class UNK1
    {

        public static void _0x48621C9FCA3EBD28(bool p0)
        {
            Invoker.Call<Void>(0x48621C9FCA3EBD28, p0);
        }

        public static void _0x81CBAE94390F9F89()
        {
            Invoker.Call<Void>(0x81CBAE94390F9F89);
        }

        public static void _0x13B350B8AD0EEE10()
        {
            Invoker.Call<Void>(0x13B350B8AD0EEE10);
        }

        public static void _0x293220DA1B46CEBC(float p0, float p1, bool p2)
        {
            Invoker.Call<Void>(0x293220DA1B46CEBC, p0, p1, p2);
        }

        public static void _0x208784099002BC30(string missionNameLabel, int p1)
        {
            Invoker.Call<Void>(0x208784099002BC30, missionNameLabel, p1);
        }

        public static void _0xEB2D525B57F42B40()
        {
            Invoker.Call<Void>(0xEB2D525B57F42B40);
        }

        public static void _0xF854439EFBB3B583()
        {
            Invoker.Call<Void>(0xF854439EFBB3B583);
        }

        public static void _0xAF66DCEE6609B148()
        {
            Invoker.Call<Void>(0xAF66DCEE6609B148);
        }

        public static void _0x66972397E0757E7A(int p0, int p1, int p2)
        {
            Invoker.Call<Void>(0x66972397E0757E7A, p0, p1, p2);
        }

        public static void _START_RECORDING(int mode)
        {
            Invoker.Call<Void>(0xC3AC2FFF9612AC81, mode);
        }

        public static void _STOP_RECORDING_AND_SAVE_CLIP()
        {
            Invoker.Call<Void>(0x071A5197D6AFC8B3);
        }

        public static void _STOP_RECORDING_AND_DISCARD_CLIP()
        {
            Invoker.Call<Void>(0x88BB3507ED41A240);
        }

        public static bool _0x644546EC5287471B()
        {
            return Invoker.Call<bool>(0x644546EC5287471B);
        }

        public static bool _IS_RECORDING()
        {
            return Invoker.Call<bool>(0x1897CA71995A90B4);
        }

        public static int _0xDF4B952F7D381B95()
        {
            return Invoker.Call<int>(0xDF4B952F7D381B95);
        }

        public static int _0x4282E08174868BE3()
        {
            return Invoker.Call<int>(0x4282E08174868BE3);
        }

        public static bool _0x33D47E85B476ABCD(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x33D47E85B476ABCD, p0_ptr);
        }

    }

    public static class UNK2
    {

        public static void _0x7E2BD3EF6C205F09(string p0, bool p1)
        {
            Invoker.Call<Void>(0x7E2BD3EF6C205F09, p0, p1);
        }

        public static bool _IS_INTERIOR_RENDERING_DISABLED()
        {
            return Invoker.Call<bool>(0x95AB8B5C992C7B58);
        }

        public static void _0x5AD3932DAEB1E5D3()
        {
            Invoker.Call<Void>(0x5AD3932DAEB1E5D3);
        }

        public static void _0xE058175F8EAFE79A(bool p0)
        {
            Invoker.Call<Void>(0xE058175F8EAFE79A, p0);
        }

        public static void _RESET_EDITOR_VALUES()
        {
            Invoker.Call<Void>(0x3353D13F09307691);
        }

        public static void _ACTIVATE_ROCKSTAR_EDITOR()
        {
            Invoker.Call<Void>(0x49DA8145672B2725);
        }

    }

    public static class UNK3
    {

        public static int _NETWORK_SHOP_GET_PRICE(int itemHash, int hash2, bool p2)
        {
            return Invoker.Call<int>(0xC27009422FCCA88D, itemHash, hash2, p2);
        }

        public static int _0x3C4487461E9B0DCB()
        {
            return Invoker.Call<int>(0x3C4487461E9B0DCB);
        }

        public static int _0x2B949A1E6AEC8F6A()
        {
            return Invoker.Call<int>(0x2B949A1E6AEC8F6A);
        }

        public static int _0x85F6C9ABA1DE2BCF()
        {
            return Invoker.Call<int>(0x85F6C9ABA1DE2BCF);
        }

        public static int _0x357B152EF96C30B6()
        {
            return Invoker.Call<int>(0x357B152EF96C30B6);
        }

        public static bool _0xCF38DAFBB49EDE5E(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xCF38DAFBB49EDE5E, p0_ptr);
        }

        public static int _0xE3E5A7C64CA2C6ED()
        {
            return Invoker.Call<int>(0xE3E5A7C64CA2C6ED);
        }

        public static bool _0x0395CB47B022E62C(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x0395CB47B022E62C, p0_ptr);
        }

        public static bool _NETWORK_SHOP_START_SESSION(int p0)
        {
            return Invoker.Call<bool>(0xA135AC892A58FC07, p0);
        }

        public static bool _0x72EB7BA9B69BF6AB()
        {
            return Invoker.Call<bool>(0x72EB7BA9B69BF6AB);
        }

        public static bool _0x170910093218C8B9(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0x170910093218C8B9, p0_ptr);
        }

        public static bool _0xC13C38E47EA5DF31(ulong p0_ptr)
        {
            return Invoker.Call<bool>(0xC13C38E47EA5DF31, p0_ptr);
        }

        public static bool _NETWORK_SHOP_GET_TRANSACTIONS_ENABLED_FOR_CHARACTER(int mpChar)
        {
            return Invoker.Call<bool>(0xB24F0944DA203D9E, mpChar);
        }

        public static int _0x74A0FD0688F1EE45(int p0)
        {
            return Invoker.Call<int>(0x74A0FD0688F1EE45, p0);
        }

        public static bool _NETWORK_SHOP_SESSION_APPLY_RECEIVED_DATA(int p0)
        {
            return Invoker.Call<bool>(0x2F41D51BA3BCD1F1, p0);
        }

        public static bool _NETWORK_SHOP_GET_TRANSACTIONS_DISABLED()
        {
            return Invoker.Call<bool>(0x810E8431C0614BF9);
        }

        public static bool _0x35A1B3E1D1315CFA(bool p0, bool p1)
        {
            return Invoker.Call<bool>(0x35A1B3E1D1315CFA, p0, p1);
        }

        public static bool _0x897433D292B44130(ulong p0_ptr, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0x897433D292B44130, p0_ptr, p1_ptr);
        }

        public static bool _NETWORK_SHOP_BASKET_START(ulong p0_ptr, int p1, int p2, int p3)
        {
            return Invoker.Call<bool>(0x279F08B1A4B29B7E, p0_ptr, p1, p2, p3);
        }

        public static bool _NETWORK_SHOP_BASKET_END()
        {
            return Invoker.Call<bool>(0xA65568121DF2EA26);
        }

        public static bool _NETWORK_SHOP_BASKET_ADD_ITEM(ulong p0_ptr, int p1)
        {
            return Invoker.Call<bool>(0xF30980718C8ED876, p0_ptr, p1);
        }

        public static int _NETWORK_SHOP_BASKET_IS_FULL()
        {
            return Invoker.Call<int>(0x27F76CC6C55AD30E);
        }

        public static bool _NETWORK_SHOP_BASKET_APPLY_SERVER_DATA(int p0, ulong p1_ptr)
        {
            return Invoker.Call<bool>(0xE1A0450ED46A7812, p0, p1_ptr);
        }

        public static bool _NETWORK_SHOP_CHECKOUT_START(int transactionID)
        {
            return Invoker.Call<bool>(0x39BE7CEA8D9CC8E6, transactionID);
        }

        public static bool _NETWORK_SHOP_BEGIN_SERVICE(ulong transactionID_ptr, int p1, int transactionHash, int amount, int p4, int mode)
        {
            return Invoker.Call<bool>(0x3C5FD37B5499582E, transactionID_ptr, p1, transactionHash, amount, p4, mode);
        }

        public static bool _NETWORK_SHOP_TERMINATE_SERVICE(int transactionID)
        {
            return Invoker.Call<bool>(0xE2A99A9B524BEFFF, transactionID);
        }

        public static bool _0x51F1A8E48C3D2F6D(int p0, bool p1, int p2)
        {
            return Invoker.Call<bool>(0x51F1A8E48C3D2F6D, p0, p1, p2);
        }

        public static int _0x0A6D923DFFC9BD89()
        {
            return Invoker.Call<int>(0x0A6D923DFFC9BD89);
        }

        public static int _NETWORK_SHOP_DELETE_SET_TELEMETRY_NONCE_SEED()
        {
            return Invoker.Call<int>(0x112CEF1615A1139F);
        }

        public static bool _NETWORK_TRANSFER_BANK_TO_WALLET(int charStatInt, int amount)
        {
            return Invoker.Call<bool>(0xD47A2C1BA117471D, charStatInt, amount);
        }

        public static bool _NETWORK_TRANSFER_WALLET_TO_BANK(int charStatInt, int amount)
        {
            return Invoker.Call<bool>(0xC2F7FE5309181C7D, charStatInt, amount);
        }

        public static int _0x23789E777D14CE44()
        {
            return Invoker.Call<int>(0x23789E777D14CE44);
        }

        public static int _0x350AA5EBC03D3BD2()
        {
            return Invoker.Call<int>(0x350AA5EBC03D3BD2);
        }

        public static bool _NETWORK_SHOP_CASH_TRANSFER_SET_TELEMETRY_NONCE_SEED()
        {
            return Invoker.Call<bool>(0x498C1E05CE5F7877);
        }

        public static bool _NETWORK_SHOP_SET_TELEMETRY_NONCE_SEED(int p0)
        {
            return Invoker.Call<bool>(0x9507D4271988E1AE, p0);
        }

        public static string _GET_ONLINE_VERSION()
        {
            return Invoker.Call<string>(0xFCA9373EF340AC0A);
        }
    }
}