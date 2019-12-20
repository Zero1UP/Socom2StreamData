using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public class MapDataModel
    {
        public string _mapID;
        public string _mapName;
        public string _discordKey;
        public string _altMapID;
        public string _altMapName;
        public string _altDiscordKey;

        public MapDataModel(string mapID,string mapName,string discordID,string altMapID,string altMapName,string altDiscordKey)
        {
            _mapID = mapID;
            _mapName = mapName;
            _discordKey = discordID;
            _altMapID = altMapID;
            _altMapName = altMapName;
            _altDiscordKey = altDiscordKey;
        }
    }
}
