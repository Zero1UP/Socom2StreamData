using System;

namespace Socom2StreamData
{
    public static class GameHelper
    {
        //R0004 Offset B620

        //Updated
        public static IntPtr PLAYER_POINTER_ADDRESS = new IntPtr(0x20435618);
        public static IntPtr GAME_ENDED_ADDRESS = new IntPtr(0x20694C44);//May need to reset this to 0 after it ends, it seems to persist till the next game and doesn't reset when the player loads in
        public static IntPtr SEAL_WIN_COUNTER_ADDRESS = new IntPtr(0x20695388);
        public static IntPtr TERRORIST_WIN_COUNTER_ADDRESS = new IntPtr(0x2069539C);
        public static IntPtr TOTAL_ROUNDS_ADDRESS = new IntPtr(0x20694C6C);
        public static IntPtr CURRENT_SEALS_ALIVE_COUNT_ADDRESS = new IntPtr(0x20694CA8);
        public static IntPtr CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS = new IntPtr(0x20694CBC);
        public static IntPtr IS_SPECTATOR_ADDRESS = new IntPtr(0x206954A0);
        public static IntPtr HUD_BOOL_ADDRESS = new IntPtr(0x20407560);
        public static IntPtr CURRENT_ROUND_TIMER_ADDRESS = new IntPtr(0x204358D0);
        public static IntPtr LOBBYSET_FPS_ADDRESS = new IntPtr(0x2040c638);
        public static IntPtr CURRENT_FPS_ADDRESS = new IntPtr(0x2040c640);
        public static IntPtr CURRENT_MAP_ADDRESS = new IntPtr(0x204417C0); //Text String of MapID, if not in a game then it is set to NONE


        //Player Object Data
        public static int PLAYER_NAME_OFFSET = 0x14;
        public static int PLAYER_TEAMID_OFFSET = 0xC8;
        public static int PLAYER_HASMPBOMB_OFFSET = 0x87C;
        public static int PLAYER_ALIVE_OFFSET = 0xF7A;
        public static int PLAYER_HEALTH_OFFSET =0x1044;


        public static IntPtr CAMERA_POINTER_ADDRESS = new IntPtr(0x204429B0); // not updated
        //Add BC to the data to get the new address
        //0044D648

        //public static IntPtr R0005_PATCHED_ROOM_BOOL_ADDRESS = new IntPtr(0x200F71B0);

        //For dealing with our who is alive lists
        public static IntPtr ENTITY_OBJECT_LIST_POINTER = new IntPtr(0x20442CEC);
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
