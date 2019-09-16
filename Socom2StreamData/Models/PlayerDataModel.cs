using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public class PlayerDataModel
    {
        public string _PlayerName { get; set; }
        public string _Team { get; set; }
        public string _LivingStatus { get; set; }
        public decimal _PlayerHealth { get; set; }
        public int _roundsWon { get; set; }
        public int _roundsLost { get; set; }
        public int _kills { get; set; }
        public int _deaths { get; set; }
        public int _suicides { get; set; }
        public int _teamKills { get; set; }
        public short _totalPoints { get; set; }
        public decimal _xCoord { get; set; }
        public decimal _yCoord { get; set; }
        public decimal _zCoord { get; set; }
        public string _pointerAddress { get; set; }
        public int _hasMPBomb { get; set; }
    }
}
