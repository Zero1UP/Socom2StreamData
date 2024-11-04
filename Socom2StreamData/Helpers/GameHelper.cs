using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Socom2StreamData
{
    public static class GameHelper
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] SafeHandleZeroOrMinusOneIsInvalid hProcess,
            [Out, MarshalAs(UnmanagedType.Bool)] out bool wow64Process);
        //R0004 Offset B620

        //Updated
        public static int PLAYER_POINTER_ADDRESS = 0x435618;
        public static int GAME_ENDED_ADDRESS = 0x694C44;//May need to reset this to 0 after it ends, it seems to persist till the next game and doesn't reset when the player loads in
        public static int SEAL_WIN_COUNTER_ADDRESS = 0x695388;
        public static int TERRORIST_WIN_COUNTER_ADDRESS = 0x69539C;
        public static int TOTAL_ROUNDS_ADDRESS = 0x694C6C;
        public static int CURRENT_SEALS_ALIVE_COUNT_ADDRESS = 0x694CA8;
        public static int CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS = 0x694CBC;
        public static int IS_SPECTATOR_ADDRESS = 0x6954A0;
        public static int HUD_BOOL_ADDRESS = 0x407560;
        public static int CURRENT_ROUND_TIMER_ADDRESS =0x4358D0;
        public static int LOBBYSET_FPS_ADDRESS = 0x40c638;
        public static int CURRENT_FPS_ADDRESS = 0x40c640;
        public static int CURRENT_MAP_ADDRESS = 0x4417C0; //Text String of MapID, if not in a game then it is set to NONE


        //Player Object Data
        public static int PLAYER_NAME_OFFSET = 0x14;
        public static int PLAYER_TEAMID_OFFSET = 0xC8;
        public static int PLAYER_HASMPBOMB_OFFSET = 0x87C;
        public static int PLAYER_ALIVE_OFFSET = 0xF7A;
        public static int PLAYER_HEALTH_OFFSET =0x1044;
        public static int PLAYTER_PRIMARY_WEAPON_POINTER_OFFSET = 0x6C4;
        public static int PLAYER_SECONDARY_WEAPON_POINTER_OFFSET = 0x06C8;
        public static int PLAYER_EQUIP1_POINTER_OFFSET = 0x6CC;
        public static int PLAYER_EQUIP2_POINTER_OFFSET = 0x6D0;
        public static int PLAYER_EQUIP3_POINTER_OFFSET = 0x6D4;
        public static int PLAYER_EXTRA_POINTER_OFFSET = 0x6D8;
        public static int PLAYER_ROUNDS_SHOTS_FIRED_OFFSET = 0x594;
        public static int PLAYER_CURRENT_WEAPON_INDEX = 0xE04;

        public static int CAMERA_POINTER_ADDRESS = 0x4429B0; // not updated
        //Add BC to the data to get the new address
        //0044D648

        //For dealing with our who is alive lists
        public static int ENTITY_OBJECT_LIST_POINTER = 0x442CEC;
        public static int ENTITY_INDEX_PLAYER_POINTER_OFFSET = 0x08;

        public static string GetTeamName (string value)
        {
            switch (value)
            {
                case "40000001":
                    return "SEALS";
                case "80000100":
                    return "TERRORISTS";
                case "C0020000":
                    return "HOSTAGE";
                case "40020000":
                    return "VIP";
                case "00010000":
                    return "SPECTATOR";
                case "48000000": //Not 100% if this covers all breach points, but this was found on fishhook
                    return "BREACH POINT";
                default:
                    return "N/A";
            }
        }
    }
}
