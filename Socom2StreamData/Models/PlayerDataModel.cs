using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public class PlayerDataModel
    {
        public string PlayerName { get; set; }
        public string Team { get; set; }
        public string LivingStatus { get; set; }
        public decimal PlayerHealth { get; set; }
        public IntPtr PointerAddress { get; set; }
        public int HasMPBomb { get; set; }
        public int WeaponIndex { get; set; }
        public string PrimaryWeapon { get; set; }
        public string SecondaryWeapon { get; set; }
        public string EquipmentSlot1 { get; set; }
        public string EquipmentSlot2 { get; set; }
        public string EquipmentSlot3 { get; set; }
        public string ExtraEquipmentSlot { get; set; }
        public int ShotsFired { get; set; }
    }
}
