namespace Socom2StreamData.Models
{
    public static  class Collections
    {
        public static Dictionary<string, Bitmap> Weapons = new Dictionary<string, Bitmap>()
        {
            {"9mm Pistol",GetBitmap(Properties.Resources._9MM_Pistol) },
            {"9mm Sub",GetBitmap(Properties.Resources._9MM_Sub) },
            {"870",GetBitmap(Properties.Resources._12_Gauge_Pump) },
            {"MGL FRAG TUR",GetBitmap(Properties.Resources._30MM_MGL) },
            {"552",GetBitmap(Properties.Resources._552) },
            {"552SD",GetBitmap(Properties.Resources._552SD) },
            {"AK-47",GetBitmap(Properties.Resources.AK_47) },
            {"AK-105",GetBitmap(Properties.Resources.AK_105) },
            {"AKS-74",GetBitmap(Properties.Resources.AKS_74) },
            {"AN-M8",GetBitmap(Properties.Resources.AN_M8) },
            {"LAW",GetBitmap(Properties.Resources.AT_4) },
            {"C4",GetBitmap(Properties.Resources.C4) },
            {"Claymore",GetBitmap(Properties.Resources.Claymore) },
            {"DE .50",GetBitmap(Properties.Resources.DE__50) },
            {"Designator",GetBitmap(Properties.Resources.Designator) },
            {"Detonator",GetBitmap(Properties.Resources.Detonator) },
            {"F57",GetBitmap(Properties.Resources.F57) },
            {"F90",GetBitmap(Properties.Resources.F90) },
            {"HE",GetBitmap(Properties.Resources.HE) },
            {"HK5",GetBitmap(Properties.Resources.HK5) },
            {"MP5K",GetBitmap(Properties.Resources.HK5K) },
            {"HK5SD",GetBitmap(Properties.Resources.HK5SD) },
            {"SA-80 A2",GetBitmap(Properties.Resources.IW_80_A2) },
            {"LMG TURRET",GetBitmap(Properties.Resources.LMG) },
            {"JACKHAMMER",GetBitmap(Properties.Resources.M3_12_Gauge) },
            {"M4A1",GetBitmap(Properties.Resources.M4A1) },
            {"M4A1 SD",GetBitmap(Properties.Resources.M4A1SD) },
            {"M4A1-M203",GetBitmap(Properties.Resources.M4A1_M203) },
            {"M9",GetBitmap(Properties.Resources.M9) },
            {"P228",GetBitmap(Properties.Resources.M11) },
            {"M14",GetBitmap(Properties.Resources.M14) },
            {"M16A2",GetBitmap(Properties.Resources.M16A2) },
            {"M16A2-M203",GetBitmap(Properties.Resources.M16A2_M203) },
            {"M40A1",GetBitmap(Properties.Resources.M40A1) },
            {"M60E3",GetBitmap(Properties.Resources.M60E3) },
            {"M63A",GetBitmap(Properties.Resources.M63A) },
            {"M67",GetBitmap(Properties.Resources.M67) },
            {"M79",GetBitmap(Properties.Resources.M79) },
            {"M82A1A",GetBitmap(Properties.Resources.M82A1A) },
            {"M87ELR",GetBitmap(Properties.Resources.M87ELR) },
            {"Mark 23",GetBitmap(Properties.Resources.Mark_23) },
            {"Mark 23SD",GetBitmap(Properties.Resources.Mark_23SD) },
            {"Mark141",GetBitmap(Properties.Resources.Mark141) },
            {"MGL",GetBitmap(Properties.Resources.MGL) },
            {"Model 18",GetBitmap(Properties.Resources.Model_18) },
            {"MPBOMB",GetBitmap(Properties.Resources.MPBomb) },
            {"F2000",GetBitmap(Properties.Resources.OICW) },
            {"PMN Mine",GetBitmap(Properties.Resources.PMN_Mine) },
            {"KBP OTs-14 G",GetBitmap(Properties.Resources.RA_14) },
            {"PKM TURRET",  GetBitmap(Properties.Resources.RMG) },
            {"RPG LAUNCHER",GetBitmap(Properties.Resources.RPG_7) },
            {"Dragunov",GetBitmap(Properties.Resources.SASR) },
            {"SR-1 Gyurza",GetBitmap(Properties.Resources.SP_10) },
            {"226",GetBitmap(Properties.Resources.SP_10) },
            {"SR-25",GetBitmap(Properties.Resources.SR_25) },
            {"SR-25 SD",GetBitmap(Properties.Resources.SR_25) },
            {"Steyr Aug",GetBitmap(Properties.Resources.STG_77) },
            {"Spas 12",GetBitmap(Properties.Resources.TA_12_Gauge) },
            {".PKM",GetBitmap(Properties.Resources.M63A) },
            {"BLUE CHEM LI",GetBitmap(Properties.Resources.AN_M8) },
            {"RED SMOKE GR",GetBitmap(Properties.Resources.AN_M8) },

        };

        public static Bitmap GetBitmap(byte[] imageData)
        {
            using var ms = new MemoryStream(imageData);
            return new Bitmap(ms);
        }
    }
}
