using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public static class GameHelper
    {
        public const string GAME_ENDED_ADDRESS = "20694C44";  //May need to reset this to 0 after it ends, it seems to persist till the next game and doesn't reset when the player loads i
        public const string CURRENT_MAP_ADDRESS = "20436540"; // Text String of MapID, if not in a game then it is set to NONE
        public const string PLAYER_POINTER_ADDRESS = "20440C38";
        public const string CAMERA_POINTER_ADDRESS = "20415FF0";
        public const string SEAL_WIN_COUNTER_ADDRESS = "20695388";
        public const string TERRORIST_WIN_COUNTER_ADDRESS = "2069539C";
        public const string TOTAL_ROUNDS_ADDRESS = "20694C6C";
        public const string CURRENT_SEALS_ALIVE_COUNT_ADDRESS = "20694CA8";
        public const string CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS = "20694CBC";
        public const string ROOM_NAME_ADDRESS = "20E40DDE";
        public const string CUSTOM_MAP_ADDRESS = "200F71B0";


        public const string CURRENT_FPS_ADDRESS = "203E1400";
        public const string LOBBYSET_FPS_ADDRESS = "203E13F8";
        public const string HUD_BOOL_ADDRESS = "203DC3E0";
        public const string SOCOM_PATCH_ADDRESS = "203E17E0";
        public const string R0005_PATCHED_ROOM_BOOL_ADDRESS = "200F71B0";
        public const string CURRENT_ROUND_TIMER_ADDRESS = "20408F10";
        public const string IS_SPECTATOR_ADDRESS = "206954A0";

        //For dealing with our who is alive lists
        public const string ENTITY_OBJECT_LIST_POINTER = "204362E4";
        public const int ENTITY_ALIVE_OFFSET = 3962; // A value of 3 = dead
        public const int ENTITY_TEAM_ID_OFFSET = 200;
        public const int ENTITY_HEALTH_OFFSET = 4164;

        //public const int ENTITY_X_COORD = 28;
        //public const int ENTITY_Y_COORD = 36;
        //public const int ENTITY_Z_COORD = 740;
        //public const int ENTITY_IS_FIRING = 121376;
        public const int ENTITY_HAS_MPBOMB = 2172;
        

        //https://discordapp.com/developers/applications/657060473849643018/rich-presence/assets
        //https://github.com/Lachee/discord-rpc-csharp
        public static List<MapDataModel> mapInfo = new List<MapDataModel>
        {
            { new MapDataModel("MP1","Blizzard","blizzard","MP26","Blizzard Day","blizzard_day")},
            { new MapDataModel("MP2","Frost Fire","frostfire","MP27","Frostfire Day","frostfire_day")},
            { new MapDataModel("MP5","Abandoned","abandoned","MP21","Abandoned Day","abandoned_day")},
            { new MapDataModel("MP73","Sand Storm","sandstorm","MP89","Sandstorm Day","sandstorm_day")},
            { new MapDataModel("MP7","Night Stalker","nightstalker","MP29","Nightstalker Day","nightstalker_day")},
            { new MapDataModel("MP6","Desert Glory","desertglory","MP28","Desert Glory Night","desertglory_night")},
            { new MapDataModel("M51","Seeding Chaos","seedingchaos","","","")},
            { new MapDataModel("M52","Terminal Transaction","terminaltransaction","","","")},
            { new MapDataModel("M53","Upland Assault","default","","","")},
            { new MapDataModel("M61","Urban Sweep","default","","","")},
            { new MapDataModel("M62","Strangle Hold","default","","","")},
            { new MapDataModel("M63","Hydro Electric","default","","","")},
            { new MapDataModel("M71","Guardian Angels","default","","","")},
            { new MapDataModel("M72","Protect and Serve","default","","","")},
            { new MapDataModel("M73","Against the Tide","default","","","")},
            { new MapDataModel("M81","Lockdown","default","","","")},
            { new MapDataModel("M82","Guided Tour","default","","","")},
            { new MapDataModel("M63","Doomsday Delivery","default","","","")},
            { new MapDataModel("NONE","","default","","","")},
            { new MapDataModel("MP10","Blood Lake","bloodlake","MP32","Blood Lake Night","bloodlake_night")},
            { new MapDataModel("MP11","Death Trap","deathtrap","MP33","Death Trap Night","deathtrap_night")},
            { new MapDataModel("MP12","The Ruins","theruins","MP34","The Ruins Night","theruins_night")},
            { new MapDataModel("MP62","Enowapi","enowapi","","","")},
            { new MapDataModel("MP8","Rat's Nest","ratsnest","MP30","Rat's Nest Day","ratsnest_day")},
            { new MapDataModel("MP53","Fox Hunt","foxhunt","","","")},
            { new MapDataModel("MP51","Vigilance","vigilance","","","")},
            { new MapDataModel("MP9","Bitter Jungle","bitterjungle","MP31","Bitter Jungle Night","bitterjungle_night")},
            { new MapDataModel("MP52","The Mixer","themixer","MP25","The Mixer Night","themixer_night")},
            { new MapDataModel("MP71","Fishhook","fishhook","MP23","Fish Hook Night","fishhook_night")},
            { new MapDataModel("MP72","Crossroads","crossroads","MP24","Crossroads Night","crossroads_night")},
            { new MapDataModel("MP64","Shadow Falls","shadowfalls","MP80","Shadowfalls Day","shadowfalls_day")},
            { new MapDataModel("MP61","Sujo","sujo","","","")},
            { new MapDataModel("MP81","Chain Reaction","chainreaction","","","")},
            { new MapDataModel("MP82","Guidanace","guidance","","","")},
            { new MapDataModel("MP83","Requim","requiem","","","")}
        };


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

            }else if(value == "48000000") //Not 100% if this coveres all breach points, but this was found on fishhook
            {
                return "BREACH POINT";
            }
            else
            {
                return "N/A";
            }
        }
    }
}
