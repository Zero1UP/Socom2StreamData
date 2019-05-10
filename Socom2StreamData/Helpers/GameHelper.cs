using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public static class GameHelper
    {
        
        public const string PLAYER_POINTER_ADDRESS = "20440C38";
        public const string SEAL_WIN_COUNTER_ADDRESS = "20695388";
        public const string TERRORIST_WIN_COUNTER_ADDRESS = "2069539C";
        public const string TOTAL_ROUNDS_ADDRESS = "20694C6C";
        public const string CURRENT_SEALS_ALIVE_COUNT_ADDRESS = "20694CA8";
        public const string CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS = "20694CBC";

        public const string CURRENT_FPS_ADDRESS = "203E1400";
        public const string LOBBYSET_FPS_ADDRESS = "203E13F8";
        public const string HUD_BOOL_ADDRESS = "203DC3E0";
        public const string SOCOM_PATCH_ADDRESS = "203E17E0";
        public const string R0005_PATCHED_ROOM_BOOL_ADDRESS = "200F71B0";
        public const string CURRENT_ROUND_TIMER_ADDRESS = "20408F10";
        public const string IS_SPECTATOR_ADDRESS = "206954A0";

        //For dealing with our who is alive lists
        public const string ENTITY_OBJECT_LIST_POINTER = "204362E4";
        public const string ENTITY_ALIVE_OFFSET = "F7A"; // A value of 3 = dead
        public const string ENTITY_TEAM_ID_OFFSET = "CC";

        /*Team IDs
        Seals: 40000001 
        Terrorists: 80000100 
        Hostages: C0020000
        VIPS: 40020000 
        Specs:00010000 
        */

        public static string GetTeamName (string value)
        {
            if (value == "40000001")
            {
                return "SEALS";
            }
            else if (value == "80000100")
            {
                return "TERRORISTS";
            }
            else if (value == "C0020000")
            {
                return "HOSTAGE";
            }
            else if (value == "40020000")
            {
                return "VIP";
            }
            else if (value == "00010000")
            {
                return "SPECTATOR";
            }
            else
            {
                return "N/A";
            }
        }
    }
}
