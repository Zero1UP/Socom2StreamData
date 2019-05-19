using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace Socom2StreamData
{
    public partial class frm_Main : Form
    {

        bool pcsx2Running;
        Mem m = new Mem();
        static frm_Stats_GUI statsGUI;
        static frm_Players_Seals sealPlayersGUI;
        static frm_Players_Terrorists terroristPlayersGUI;

        public frm_Main()
        {
            InitializeComponent();

        }

        private void tmr_Update_Tick(object sender, EventArgs e)
        {

            if (pcsx2Running)
            {
                m.OpenProcess("pcsx2.exe");

                //Get the current patch version
                lbl_Version.Text = ByteConverstionHelper.convertBytesToString(m.readBytes(GameHelper.SOCOM_PATCH_ADDRESS, 20));

                //Check to make sure that the user is even in a game to begin with
                if ((m.readBytes(GameHelper.PLAYER_POINTER_ADDRESS, 4) != null) &&(!m.readBytes(GameHelper.PLAYER_POINTER_ADDRESS, 4).SequenceEqual(new byte[] {0,0,0,0})))
                {
                    //Check if the player is a spectator. The FPS Checkbox is only available to them
                    if (m.readByte(GameHelper.IS_SPECTATOR_ADDRESS) == 0 && m.readByte(GameHelper.R0005_PATCHED_ROOM_BOOL_ADDRESS) == 0)
                    {
                        m.writeBytes(GameHelper.CURRENT_FPS_ADDRESS, new byte[] { 0x1E });
                        m.writeBytes(GameHelper.LOBBYSET_FPS_ADDRESS, new byte[] { 0x1E });
                        chk_FPS.Checked = false;
                        chk_FPS.Enabled = false;
                    }
                    else
                    {
                        chk_FPS.Enabled = true;
                    }

                    // Get the user's current Team ID 
                    string usersPlayerLocationAddress =  ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes(GameHelper.PLAYER_POINTER_ADDRESS, 4));
                    string usersTeam = GameHelper.GetTeamName(ByteConverstionHelper.byteArrayHexToHexString(m.readBytes((int.Parse(usersPlayerLocationAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TEAM_ID_OFFSET).ToString("X4"), 4)));

                    //HUD Bool check
                    if (m.readByte(GameHelper.HUD_BOOL_ADDRESS) == 0)
                    {
                        chk_HUD.Checked = false;
                    }
                    else
                    {
                        chk_HUD.Checked = true;
                    }

                    //Deal with the game stats
                    int sealsRoundsWon = m.readByte(GameHelper.SEAL_WIN_COUNTER_ADDRESS);
                    int terroristRoundsWon = m.readByte(GameHelper.TERRORIST_WIN_COUNTER_ADDRESS);
                    int sealsAlive = m.readByte(GameHelper.CURRENT_SEALS_ALIVE_COUNT_ADDRESS);
                    int terroristsAlive = m.readByte(GameHelper.CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS);
                    string roundTime = ByteConverstionHelper.convertBytesToString(m.readBytes(GameHelper.CURRENT_ROUND_TIMER_ADDRESS, 5));

                    List<PlayerDataHelper> playerData = processPlayers();
                    List<PlayerDataHelper> sealPlayersData = playerData.Where(item => item._Team == "SEALS").ToList();
                    List<PlayerDataHelper> terroristPlayersData = playerData.Where(item => item._Team == "TERRORISTS").ToList();


                    statsGUI.sealWins = sealsRoundsWon.ToString();
                    statsGUI.terroristWins = terroristRoundsWon.ToString();
                    statsGUI.sealsAlive = sealsAlive.ToString();
                    statsGUI.terroristAlive = terroristsAlive.ToString();
                    statsGUI.roundTime = roundTime;
                    statsGUI.playerData = playerData;

                    sealPlayersGUI.PlayerTeam = usersTeam;
                    sealPlayersGUI.playerData = sealPlayersData;
                    terroristPlayersGUI.PlayerTeam = usersTeam;
                    terroristPlayersGUI.playerData = terroristPlayersData;
                }
                else
                {
                    statsGUI.sealWins = 0.ToString();
                    statsGUI.terroristWins = 0.ToString();
                    statsGUI.sealsAlive = 0.ToString();
                    statsGUI.terroristAlive = 0.ToString();
                    statsGUI.roundTime = "00:00";
                    statsGUI.playerData = null;
                    terroristPlayersGUI.playerData = null;
                    sealPlayersGUI.playerData = null;

                }

            }
            else
            {
                m.closeProcess();
            }

        }

        private List<PlayerDataHelper> processPlayers()
        {
            List<PlayerDataHelper> playerData = new List<PlayerDataHelper>();
            //Make sure we are in a game.
            if (m.readBytes(GameHelper.PLAYER_POINTER_ADDRESS, 4) != new byte[] { 0x00, 0x00, 0x00, 0x00 })
            {

                string objectPtr = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes(GameHelper.ENTITY_OBJECT_LIST_POINTER, 4));
                do
                {
                    PlayerDataHelper PD = new PlayerDataHelper();

                    string playerPointerAddress = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes((int.Parse(objectPtr, System.Globalization.NumberStyles.HexNumber) + 8).ToString("X4"), 4));
                    string playerNamePointerAddress = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + 20).ToString("X4"), 4));
                    PD._PlayerName = ByteConverstionHelper.convertBytesToString(m.readBytes(playerNamePointerAddress, 20));

                    int livingStatus = m.readByte((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_ALIVE_OFFSET).ToString("X4"));

                    if (livingStatus == 1)
                    {
                        PD._LivingStatus = "ALIVE";
                    }
                    else
                    {
                        PD._LivingStatus = "DEAD";
                    }

                    string teamID = ByteConverstionHelper.byteArrayHexToHexString(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TEAM_ID_OFFSET).ToString("X4"), 4));
                    PD._Team = GameHelper.GetTeamName(teamID);

                    if (PD._Team == "SEALS" || PD._Team == "TERRORISTS")
                    {
                        PD._PlayerHealth = ByteConverstionHelper.byteHexFloatToDecimal(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_HEALTH_OFFSET).ToString("X4"), 4));
                    }

                    playerData.Add(PD);
                    objectPtr = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes(objectPtr, 4)); // Get the next pointer in the list

                } while (objectPtr.ToUpper() != "204362E4");
            }

            return playerData;

        }


        private void tmr_CheckPCSX2_Tick(object sender, EventArgs e)
        {

            Process[] pcsx2 = Process.GetProcessesByName("pcsx2");

            if (pcsx2.Length > 0)
            {
                lbl_PCSX2.Text = "PCSX2 Detected";
                pnl_Options.Enabled = true;
                lbl_PCSX2.ForeColor = Color.FromArgb(20, 192, 90);
                pcsx2Running = true;
            }
            else
            {
                lbl_PCSX2.Text = "Waiting for PCSX2...";
                pnl_Options.Enabled = false;
                lbl_PCSX2.ForeColor = Color.FromArgb(120, 120, 120);
                lbl_Version.Text = "...";
                pcsx2Running = false;
            }
        }

        private void chk_FPS_CheckedChanged(object sender, EventArgs e)
        {
            if (pcsx2Running)
            {
                if (chk_HUD.Checked)
                {
                    m.writeBytes(GameHelper.CURRENT_FPS_ADDRESS, new byte[] { 0x3C });
                    m.writeBytes(GameHelper.LOBBYSET_FPS_ADDRESS, new byte[] { 0x3C });
                }
                else
                {
                    m.writeBytes(GameHelper.CURRENT_FPS_ADDRESS, new byte[] { 0x1E });
                    m.writeBytes(GameHelper.LOBBYSET_FPS_ADDRESS, new byte[] { 0x1E });
                }

            }

        }

        private void chk_HUD_CheckedChanged(object sender, EventArgs e)
        {
            if (pcsx2Running)
            {
                if (chk_HUD.Checked)
                {
                    m.writeBytes(GameHelper.HUD_BOOL_ADDRESS, new byte[] { 0x01 });
                }
                else
                {
                    m.writeBytes(GameHelper.HUD_BOOL_ADDRESS, new byte[] { 0x00 });
                }
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
            sealPlayersGUI = new frm_Players_Seals();
            sealPlayersGUI.Show();

            terroristPlayersGUI = new frm_Players_Terrorists();
            terroristPlayersGUI.Show();


        }

        private void chk_ShowSealHealthBars_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_ShowSealHealthBars.Checked)
            {
                sealPlayersGUI.Visible = true;
            }
            else
            {
                sealPlayersGUI.Visible = false;
            }
        }


        private void chk_ShowTerroristHealthBars_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowTerroristHealthBars.Checked)
            {
                terroristPlayersGUI.Visible = true;
            }
            else
            {
                terroristPlayersGUI.Visible = false;
            }
        }
    }
}
