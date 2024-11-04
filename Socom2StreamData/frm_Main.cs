using System.Reflection;
using System.Data;
using MemoryIO.Pcsx2;
namespace Socom2StreamData
{
    public partial class frm_Main : Form
    {
        private const string PCSX2PROCESSNAME = "pcsx2";
        //MemorySharp m = null;
        Pcsx2MemoryIO m = null;
        static frm_Stats_GUI statsGUI;
        static frm_Players_Team frm_sealPlayers;
        static frm_Players_Team frm_terroristPlayers;
        string mapID = "";
        List<PlayerDataModel> playerDataList = new List<PlayerDataModel>();

        public frm_Main()
        {
            InitializeComponent();

            m = new Pcsx2MemoryIO();
        }

        private void tmr_Update_Tick(object sender, EventArgs e)
        {

            List<PlayerDataModel> playerData = new List<PlayerDataModel>();
            try
            {

                if (m.Pcsx2Running)
                {
                    //IntPtr playerPtr = IntPtr.Add(baseAddress, GameHelper.PLAYER_POINTER_ADDRESS);
                    if ((m.ReadArray<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4) != null) && (!m.ReadArray<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4).SequenceEqual(new byte[] { 0, 0, 0, 0 })))
                    {
                        if (m.Read<byte>(GameHelper.GAME_ENDED_ADDRESS) == 0)
                        {
                            // This is the data part of the PLAYER_POINTER_ADDRESS 
                            int playerDataLocationAddress = m.Read<int>(GameHelper.PLAYER_POINTER_ADDRESS);
                            int playerTeamAddress = playerDataLocationAddress + GameHelper.PLAYER_TEAMID_OFFSET;
                            string playerTeam = GameHelper.GetTeamName(m.ReadArray<byte>(playerTeamAddress, 4).byteArrayHexToHexString(false));

                            //Deal with the game stats
                            int sealsRoundsWon = m.Read<byte>(GameHelper.SEAL_WIN_COUNTER_ADDRESS);
                            int terroristRoundsWon = m.Read<byte>(GameHelper.TERRORIST_WIN_COUNTER_ADDRESS);
                            int sealsAlive = m.Read<byte>(GameHelper.CURRENT_SEALS_ALIVE_COUNT_ADDRESS);
                            int terroristsAlive = m.Read<byte>(GameHelper.CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS);
                            string roundTime = m.ReadArray<byte>(GameHelper.CURRENT_ROUND_TIMER_ADDRESS, 5).GetNullTerminatedString();
                            mapID = m.ReadArray<byte>(GameHelper.CURRENT_MAP_ADDRESS, 4).GetNullTerminatedString();

                            //Gather all the player Data
                            playerData = processPlayers();
                            List<PlayerDataModel> sealPlayersData = playerData.Where(item => item.Team == "SEALS").ToList();
                            List<PlayerDataModel> terroristPlayersData = playerData.Where(item => item.Team == "TERRORISTS").ToList();
                            statsGUI.sealWins = sealsRoundsWon.ToString();
                            statsGUI.terroristWins = terroristRoundsWon.ToString();
                            statsGUI.sealsAlive = sealsAlive.ToString();
                            statsGUI.terroristAlive = terroristsAlive.ToString();
                            statsGUI.roundTime = roundTime;
                            statsGUI.playerData = playerData;

                            //Set the instances of our Team Forms
                            frm_sealPlayers.PlayerTeam = playerTeam;
                            frm_sealPlayers.playerData = sealPlayersData;
                            frm_sealPlayers.MemObject = m;
                            frm_sealPlayers.Text = "frm_Seals";

                            frm_terroristPlayers.PlayerTeam = playerTeam;
                            frm_terroristPlayers.playerData = terroristPlayersData;
                            frm_terroristPlayers.MemObject = m;
                            frm_terroristPlayers.Text = "frm_terrorists";

                            playerDataList = playerData;
                        }
                        return;
                    }
                    if (mapID != "" && mapID != null)
                    {

                        m.Write<byte>(GameHelper.GAME_ENDED_ADDRESS,0x00);
                        statsGUI.sealWins = 0.ToString();
                        statsGUI.terroristWins = 0.ToString();
                        statsGUI.sealsAlive = 0.ToString();
                        statsGUI.terroristAlive = 0.ToString();
                        statsGUI.roundTime = "00:00";
                        statsGUI.playerData = null;
                        frm_terroristPlayers.playerData = null;
                        frm_sealPlayers.playerData = null;
                        mapID = "";
                    }
                }
            }
            catch (Exception)
            {
                // something bad happened and we should just close out
                Application.Exit();
            }

        }
        private List<PlayerDataModel> processPlayers()
        {
            List<PlayerDataModel> playerData = new List<PlayerDataModel>();

            int entityObjectPointer = m.Read<int>(GameHelper.ENTITY_OBJECT_LIST_POINTER);
            do
            {
                int playerPointerAddress = m.Read<int>(entityObjectPointer + GameHelper.ENTITY_INDEX_PLAYER_POINTER_OFFSET);
                int playerNamePointerAddress = m.Read<int>(playerPointerAddress + GameHelper.PLAYER_NAME_OFFSET);
                string teamID = GameHelper.GetTeamName(m.Read<int>(playerPointerAddress + GameHelper.PLAYER_TEAMID_OFFSET).ToString("X8"));
                PlayerDataModel PD = new PlayerDataModel();
                if (teamID == "SEALS" || teamID == "TERRORISTS")
                {
                    try
                    {

                        PD.PlayerName = m.ReadArray<byte>(playerNamePointerAddress, 20).GetNullTerminatedString();
                        PD.PointerAddress = playerPointerAddress;
                        PD.Team = teamID;
                        PD.PlayerHealth = m.ReadArray<byte>(playerPointerAddress + GameHelper.PLAYER_HEALTH_OFFSET, 4).byteHexFloatToDecimal();
                        PD.HasMPBomb = m.Read<byte>((playerPointerAddress + GameHelper.PLAYER_HASMPBOMB_OFFSET));
                        int livingStatus = m.Read<byte>((playerPointerAddress + GameHelper.PLAYER_ALIVE_OFFSET));

                        int playerPrimaryWeaponPointer =m.Read<int>(playerPointerAddress + GameHelper.PLAYTER_PRIMARY_WEAPON_POINTER_OFFSET) + 4;
                        int primaryWeaponNamePointer = m.Read<int>(playerPrimaryWeaponPointer);
                        int secondaryWeaponPointer = m.Read<int>((playerPointerAddress + GameHelper.PLAYER_SECONDARY_WEAPON_POINTER_OFFSET)) + 4;
                        int secondaryWeaponNamePointer = m.Read<int>(secondaryWeaponPointer);
                        int eqSlot1Pointer = m.Read<int>((playerPointerAddress + GameHelper.PLAYER_EQUIP1_POINTER_OFFSET)) + 4;
                        int eqSlot1NamePointer = m.Read<int>(eqSlot1Pointer);
                        int eqSlot2Pointer = m.Read<int>((playerPointerAddress + GameHelper.PLAYER_EQUIP2_POINTER_OFFSET)) + 4;
                        int eqSlot2NamePointer = m.Read<int>(eqSlot2Pointer);
                        int eqSlot3Pointer = m.Read<int>((playerPointerAddress + GameHelper.PLAYER_EQUIP3_POINTER_OFFSET)) + 4;
                        int eqSlot3NamePointer = m.Read<int>(eqSlot3Pointer);
                        int eqExtraPointer = m.Read<int>((playerPointerAddress + GameHelper.PLAYER_EXTRA_POINTER_OFFSET)) + 4;
                        PD.PrimaryWeapon = m.ReadArray<byte>(primaryWeaponNamePointer, 12).GetNullTerminatedString();
                        PD.SecondaryWeapon = m.ReadArray<byte>(secondaryWeaponNamePointer, 12).GetNullTerminatedString();
                        PD.EquipmentSlot1 = m.ReadArray<byte>(eqSlot1NamePointer, 12).GetNullTerminatedString();
                        PD.EquipmentSlot2 = m.ReadArray<byte>(eqSlot2NamePointer, 12).GetNullTerminatedString();
                        PD.EquipmentSlot3 = m.ReadArray<byte>(eqSlot3NamePointer, 12).GetNullTerminatedString();
                        PD.WeaponIndex = m.Read<int>((playerPointerAddress + GameHelper.PLAYER_CURRENT_WEAPON_INDEX));
                        //if (eqExtraPointer != (IntPtr)0x20000004)
                        //{
                        //    IntPtr eqExtraNamePointer = (IntPtr)m.Read<int>(eqExtraPointer, false) + 0x20000000;
                        //    PD.ExtraEquipmentSlot = m.Read<byte>(eqExtraNamePointer, 12, false).GetNullTerminatedString();
                        //}
                        if (livingStatus == 1)
                        {
                            PD.LivingStatus = "ALIVE";
                        }
                        else
                        {
                            PD.LivingStatus = "DEAD";
                        }

                    }
                    catch (Exception ex)
                    {

                        Console.Write(ex.ToString());
                    }
                    finally
                    {
                        playerData.Add(PD);
                    }

                }
                entityObjectPointer = m.Read<int>(entityObjectPointer); // Get the next pointer in the list
            } while (entityObjectPointer != 0x442CEC);
            return playerData;
        }
        private void tmr_CheckPCSX2_Tick(object sender, EventArgs e)
        {
            if(m.Pcsx2Running && !m.IsAttached)
            {
                m.Update();
            }

            if (m.IsAttached)
            {
                lbl_PCSX2.Text = "PCSX2 Detected";
                pnl_Options.Enabled = true;
                lbl_PCSX2.ForeColor = Color.FromArgb(20, 192, 90);
                return;
            }

            lbl_PCSX2.Text = "Waiting for PCSX2...";
            pnl_Options.Enabled = false;
            lbl_PCSX2.ForeColor = Color.FromArgb(120, 120, 120);
        }
        private void chk_HUD_CheckedChanged(object sender, EventArgs e)
        {
            if (m.Pcsx2Running)
            {
               
                if (chk_HUD.Checked)
                {            
                    m.Write<byte>(GameHelper.HUD_BOOL_ADDRESS, 0x01);
                    return;
                }
                m.Write<byte>(GameHelper.HUD_BOOL_ADDRESS,0x00);
            }
        }

        private void fmr_Main_Load(object sender, EventArgs e)
        {
            lbl_ProgramVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // load GUI
            statsGUI = new frm_Stats_GUI();

            statsGUI.StartPosition = FormStartPosition.Manual;
            //Set the starting location of the Stats form
            statsGUI.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 100);
            statsGUI.Show();

            // load players GUI
            frm_sealPlayers = new frm_Players_Team("SEALS");
            frm_sealPlayers.Show();

            frm_terroristPlayers = new frm_Players_Team("TERRORISTS");
            frm_terroristPlayers.Show();
        }

        private void chk_ShowSealHealthBars_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowSealHealthBars.Checked)
            {
                frm_sealPlayers.Visible = true;
                return;
            }
            frm_sealPlayers.Visible = false;
        }

        private void chk_ShowTerroristHealthBars_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowTerroristHealthBars.Checked)
            {
                frm_terroristPlayers.Visible = true;
                return;
            }
            frm_terroristPlayers.Visible = false;
        }

        private void chk_ScoreBoardAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            toggleTopWindow(statsGUI, chk_ScoreBoardAlwaysOnTop.Checked);

        }
        private void chk_SealPlayersAlwaysTopWindow_CheckedChanged(object sender, EventArgs e)
        {
            toggleTopWindow(frm_sealPlayers, chk_SealPlayersAlwaysTopWindow.Checked);
        }
        private void chk_TerroristPlayersAlwaysTopWindow_CheckedChanged(object sender, EventArgs e)
        {
            toggleTopWindow(frm_terroristPlayers, chk_TerroristPlayersAlwaysTopWindow.Checked);
        }
        private void toggleTopWindow(Form formToToggle, bool isTopWindow)
        {

            if (isTopWindow)
            {
                formToToggle.TopMost = true;
                return;
            }
            formToToggle.TopMost = false;
        }
    }
}
