using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
namespace Socom2StreamData
{
    public partial class frm_Main : Form
    {
        private const string PCSX2PROCESSNAME = "pcsx2";
        bool pcsx2Running;
        MemorySharp m = null;

        static frm_Stats_GUI statsGUI;
        static frm_Players_Team frm_sealPlayers;
        static frm_Players_Team frm_terroristPlayers;
        string mapID = "";
        List<PlayerDataModel> playerDataList= new List<PlayerDataModel>();
        
        public frm_Main()
        {
            InitializeComponent();

        }

        private void tmr_Update_Tick(object sender, EventArgs e)
        {
            
            List<PlayerDataModel> playerData = new List<PlayerDataModel>();
            try
            {
                if (pcsx2Running)
                {
                    m = new MemorySharp(Process.GetProcessesByName(PCSX2PROCESSNAME).First());
                    if ((m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4, false) != null) && (!m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4, false).SequenceEqual(new byte[] { 0, 0, 0, 0 })))
                    {
                        if (m.Read<byte>(GameHelper.GAME_ENDED_ADDRESS, false) == 0)
                        {
                            // This is the data part of the PLAYER_POINTER_ADDRESS 
                            IntPtr playerDataLocationAddress = (IntPtr)(m.Read<int>(GameHelper.PLAYER_POINTER_ADDRESS, false) + 0x20000000);
                            IntPtr playerTeamAddress = IntPtr.Add(playerDataLocationAddress, GameHelper.PLAYER_TEAMID_OFFSET);
                            string playerTeam = GameHelper.GetTeamName(m.Read<byte>(playerTeamAddress, 4, false).byteArrayHexToHexString(false));

                            //Deal with the game stats
                            int sealsRoundsWon = m.Read<byte>(GameHelper.SEAL_WIN_COUNTER_ADDRESS, false);
                            int terroristRoundsWon = m.Read<byte>(GameHelper.TERRORIST_WIN_COUNTER_ADDRESS, false);
                            int sealsAlive = m.Read<byte>(GameHelper.CURRENT_SEALS_ALIVE_COUNT_ADDRESS, false);
                            int terroristsAlive = m.Read<byte>(GameHelper.CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS, false);
                            string roundTime = m.Read<byte>(GameHelper.CURRENT_ROUND_TIMER_ADDRESS, 5, false).GetNullTerminatedString();
                            mapID = m.Read<byte>(GameHelper.CURRENT_MAP_ADDRESS, 4, false).GetNullTerminatedString();

                            //Gather all the player Data
                            playerData = processPlayers();
                            List<PlayerDataModel> sealPlayersData = playerData.Where(item => item._Team == "SEALS").ToList();
                            List<PlayerDataModel> terroristPlayersData = playerData.Where(item => item._Team == "TERRORISTS").ToList();
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

                        m.Write(GameHelper.GAME_ENDED_ADDRESS, new byte[] { 0 }, false);
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

            IntPtr entityObjectPointer =(IntPtr)(m.Read<int>(GameHelper.ENTITY_OBJECT_LIST_POINTER, false) + 0x20000000);
            do
            {
                IntPtr playerPointerAddress = (IntPtr)m.Read<int>(IntPtr.Add(entityObjectPointer, GameHelper.ENTITY_INDEX_PLAYER_POINTER_OFFSET), false) + 0x20000000;
                IntPtr playerNamePointerAddress = (IntPtr)m.Read<int>(IntPtr.Add(playerPointerAddress, GameHelper.PLAYER_NAME_OFFSET), false) + 0x20000000;
                string teamID = GameHelper.GetTeamName(m.Read<int>(IntPtr.Add(playerPointerAddress, GameHelper.PLAYER_TEAMID_OFFSET), false).ToString("X8"));
               
                if (teamID == "SEALS" || teamID == "TERRORISTS")
                {
                    PlayerDataModel PD = new PlayerDataModel();
                    PD._PlayerName = m.Read<byte>(playerNamePointerAddress,20,false).GetNullTerminatedString();
                    PD._pointerAddress = playerPointerAddress;
                    PD._Team = teamID;
                    PD._PlayerHealth = m.Read<byte>(playerPointerAddress + GameHelper.PLAYER_HEALTH_OFFSET, 4, false).byteHexFloatToDecimal();
                    PD._hasMPBomb = m.Read<byte>(playerPointerAddress + GameHelper.PLAYER_HASMPBOMB_OFFSET, false);
                    int livingStatus = m.Read<byte>(playerPointerAddress + GameHelper.PLAYER_ALIVE_OFFSET,false);
                    if (livingStatus == 1)
                    {
                        PD._LivingStatus = "ALIVE";
                    }
                    else
                    {
                        PD._LivingStatus = "DEAD";
                    }
                    playerData.Add(PD);
                }
                entityObjectPointer = (IntPtr)m.Read<int>(entityObjectPointer, false) + 0x20000000; // Get the next pointer in the list
            } while (entityObjectPointer != (IntPtr)0x20442CEC);
            return playerData;
        }
        private void tmr_CheckPCSX2_Tick(object sender, EventArgs e)
        {
            Process[] pcsx2 = Process.GetProcessesByName(PCSX2PROCESSNAME);
            if (pcsx2.Length > 0)
            {
                lbl_PCSX2.Text = "PCSX2 Detected";
                pnl_Options.Enabled = true;
                lbl_PCSX2.ForeColor = Color.FromArgb(20, 192, 90);
                pcsx2Running = true;
                return;
            }
            lbl_PCSX2.Text = "Waiting for PCSX2...";
            pnl_Options.Enabled = false;
            lbl_PCSX2.ForeColor = Color.FromArgb(120, 120, 120);
            pcsx2Running = false;
        }

        private void chk_FPS_CheckedChanged(object sender, EventArgs e)
        {
            if (pcsx2Running)
            {
                if (chk_HUD.Checked)
                {
                    m.Write(GameHelper.CURRENT_FPS_ADDRESS, new byte[] { 0x3C },false);
                    m.Write(GameHelper.LOBBYSET_FPS_ADDRESS, new byte[] { 0x3C },false);
                    return;
                }
                m.Write(GameHelper.CURRENT_FPS_ADDRESS, new byte[] { 0x1E }, false);
                m.Write(GameHelper.LOBBYSET_FPS_ADDRESS, new byte[] { 0x1E }, false);
            }

        }

        private void chk_HUD_CheckedChanged(object sender, EventArgs e)
        {
            if (pcsx2Running)
            {
                if (chk_HUD.Checked)
                {
                    m.Write<byte>(GameHelper.HUD_BOOL_ADDRESS, new byte[] { 0x01 },false);
                    return;
                }
                m.Write<byte>(GameHelper.HUD_BOOL_ADDRESS, new byte[] { 0x00 },false);
            }
        }

        private void fmr_Main_Load(object sender, EventArgs e)
        {
            lbl_ProgramVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // load GUI
            statsGUI = new frm_Stats_GUI();

            statsGUI.StartPosition = FormStartPosition.Manual;
            //Set the starting location of the Stats form
            statsGUI.Location = new Point(this.Location.X, this.Location.Y - 100);
            statsGUI.Show();

            // load players GUI
            frm_sealPlayers = new frm_Players_Team("SEALS");
            frm_sealPlayers.Show();

            frm_terroristPlayers = new frm_Players_Team("TERRORISTS");
            frm_terroristPlayers.Show();
        }

        private void chk_ShowSealHealthBars_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_ShowSealHealthBars.Checked)
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
        private void toggleTopWindow(Form formToToggle,bool isTopWindow)
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
