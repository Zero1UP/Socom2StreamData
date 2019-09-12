using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using System.Data;
using System.IO;

namespace Socom2StreamData
{
    public partial class frm_Main : Form
    {
        private const string PCSX2PROCESSNAME = "pcsx2dis";
        bool pcsx2Running;
        Mem m = new Mem();
        static frm_Stats_GUI statsGUI;
        static frm_Players_Team sealPlayersGUI;
        static frm_Players_Team terroristPlayersGUI;
        //static frm_PlayerMap playerMap;
        //string mapID = "";
        // List<PlayerDataModel> playerDataList= new List<PlayerDataModel>();

        public frm_Main()
        {
            InitializeComponent();

        }

        private void tmr_Update_Tick(object sender, EventArgs e)
        {
            
            List<PlayerDataModel> playerData = new List<PlayerDataModel>();
            if (pcsx2Running)
            {
                m.OpenProcess(PCSX2PROCESSNAME +".exe");

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

                    //Check if the game has ended
                    // 1 = Still going, 0 = ended
                    if (m.readByte(GameHelper.GAME_ENDED_ADDRESS) == 0)
                    {
                        //HUD Bool check
                        if (m.readByte(GameHelper.HUD_BOOL_ADDRESS) == 0)
                        {
                            chk_HUD.Checked = false;
                        }
                        else
                        {
                            chk_HUD.Checked = true;
                        }

                        // Get the user's current Team ID 
                        string usersPlayerLocationAddress = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes(GameHelper.PLAYER_POINTER_ADDRESS, 4));
                        string usersTeam = GameHelper.GetTeamName(ByteConverstionHelper.byteArrayHexToHexString(m.readBytes((int.Parse(usersPlayerLocationAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TEAM_ID_OFFSET).ToString("X4"), 4)));


                        //Deal with the game stats
                        int sealsRoundsWon = m.readByte(GameHelper.SEAL_WIN_COUNTER_ADDRESS);
                        int terroristRoundsWon = m.readByte(GameHelper.TERRORIST_WIN_COUNTER_ADDRESS);
                        int sealsAlive = m.readByte(GameHelper.CURRENT_SEALS_ALIVE_COUNT_ADDRESS);
                        int terroristsAlive = m.readByte(GameHelper.CURRENT_TERRORISTS_ALIVE_COUNT_ADDRESS);
                        string roundTime = ByteConverstionHelper.convertBytesToString(m.readBytes(GameHelper.CURRENT_ROUND_TIMER_ADDRESS, 5));
                        //mapID = ByteConverstionHelper.convertBytesToString(m.readBytes(GameHelper.CURRENT_MAP_ADDRESS, 4));

                        //Gather all the player Data
                        playerData = processPlayers();

                        //Break oout Seals and Terrorists to their own lists
                        List<PlayerDataModel> sealPlayersData = playerData.Where(item => item._Team == "SEALS").ToList();
                        List<PlayerDataModel> terroristPlayersData = playerData.Where(item => item._Team == "TERRORISTS").ToList();

                        //Send game specific data to the scoreboard
                        statsGUI.sealWins = sealsRoundsWon.ToString();
                        statsGUI.terroristWins = terroristRoundsWon.ToString();
                        statsGUI.sealsAlive = sealsAlive.ToString();
                        statsGUI.terroristAlive = terroristsAlive.ToString();
                        statsGUI.roundTime = roundTime;
                        statsGUI.playerData = playerData;

                        //Set the instances of our Team Forms

                        sealPlayersGUI.PlayerTeam = usersTeam;
                       
                        sealPlayersGUI.playerData = sealPlayersData;
                        sealPlayersGUI.PlayerTeam = usersTeam;
                        sealPlayersGUI.MemObject = m;
                        terroristPlayersGUI.PlayerTeam = usersTeam;
                        terroristPlayersGUI.playerData = terroristPlayersData;
                        terroristPlayersGUI.MemObject = m;
                        //playerMap.playerData = sealPlayersData;
                        //playerDataList = playerData;
                    }
                
                }
                else
                {

                    //if(mapID != "" && mapID != null)
                    //{
                        //At this point we should be out of game and able to write to the CSV
                        //writeToCSV(playerDataList, mapID);

                        m.writeBytes(GameHelper.GAME_ENDED_ADDRESS, new byte[] { 0 });
                        statsGUI.sealWins = 0.ToString();
                        statsGUI.terroristWins = 0.ToString();
                        statsGUI.sealsAlive = 0.ToString();
                        statsGUI.terroristAlive = 0.ToString();
                        statsGUI.roundTime = "00:00";
                        statsGUI.playerData = null;
                        terroristPlayersGUI.playerData = null;
                        sealPlayersGUI.playerData = null;
                        //playerMap.playerData = null;
                        //mapID = "";
                   // }


                }

            }
            else
            {
                m.closeProcess();
            }

        }

        private List<PlayerDataModel> processPlayers()
        {
            List<PlayerDataModel> playerData = new List<PlayerDataModel>();
            //Make sure we are in a game.
            if (m.readBytes(GameHelper.PLAYER_POINTER_ADDRESS, 4) != new byte[] { 0x00, 0x00, 0x00, 0x00 })
            {

                string objectPtr = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes(GameHelper.ENTITY_OBJECT_LIST_POINTER, 4));
                do
                {
                    string playerPointerAddress = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes((int.Parse(objectPtr, System.Globalization.NumberStyles.HexNumber) + 8).ToString("X4"), 4));
                    string playerNamePointerAddress = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + 20).ToString("X4"), 4));
                    string teamID = ByteConverstionHelper.byteArrayHexToHexString(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TEAM_ID_OFFSET).ToString("X4"), 4));
                    string teamName = GameHelper.GetTeamName(teamID);
                    

                    if (teamName == "SEALS" || teamName == "TERRORISTS")
                    {
                        PlayerDataModel PD = new PlayerDataModel();
                        PD._pointerAddress = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes((int.Parse(objectPtr, System.Globalization.NumberStyles.HexNumber) + 8).ToString("X4"), 4),false); ;
                        PD._Team = teamName;
                        PD._PlayerHealth = ByteConverstionHelper.byteHexFloatToDecimal(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_HEALTH_OFFSET).ToString("X4"), 4));
                        PD._xCoord = ByteConverstionHelper.byteHexFloatToDecimal(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_X_COORD).ToString("X4"), 4),false);
                        PD._yCoord = ByteConverstionHelper.byteHexFloatToDecimal(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_Y_COORD).ToString("X4"), 4),false);
                        PD._zCoord = ByteConverstionHelper.byteHexFloatToDecimal(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_Z_COORD).ToString("X4"), 4),false);
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

                        //Stat collection for tracking a game
                        //PD._kills = ByteConverstionHelper.byteArrayToInt16(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TOTAL_KILL_OFFSET).ToString("X4"), 2));
                        // PD._deaths = ByteConverstionHelper.byteArrayToInt16(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TOTAL_DEATHS_OFFSET).ToString("X4"), 2));
                        // short totalPoints = (short)(ByteConverstionHelper.byteArrayToInt16(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TOTAL_POINTS).ToString("X4"), 2)));
                        //PD._totalPoints = totalPoints;
                        //PD._suicides = ByteConverstionHelper.byteArrayToInt16(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TOTAL_SUICIDES_OFFSET).ToString("X4"), 2));
                        //PD._grenadesThrown = ByteConverstionHelper.byteArrayToInt16(m.readBytes((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_TOTAL_GRENADES_THROWN_OFFSET).ToString("X4"), 2));
                        playerData.Add(PD);

                    }

                    objectPtr = ByteConverstionHelper.byteArrayHexToAddressString(m.readBytes(objectPtr, 4)); // Get the next pointer in the list

                } while (objectPtr.ToUpper() != "204362E4");
            }

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
            sealPlayersGUI = new frm_Players_Team("SEALS");
            sealPlayersGUI.Show();

            terroristPlayersGUI = new frm_Players_Team("TERRORISTS");
            terroristPlayersGUI.Show();

            //playerMap = new frm_PlayerMap();
            //playerMap.Show();
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

        //private void writeToCSV(List<PlayerDataModel> players,string map)
        //{
        //    if(!System.IO.Directory.Exists(@"\Reports\"))
        //    {
        //        System.IO.Directory.CreateDirectory("Reports");
        //    }

        //    StringBuilder result = new StringBuilder();
        //    result.Append("PlayerName,Kills,Deaths,Points" + Environment.NewLine);

        //    foreach(var player in players)
        //    {
        //        result.Append(player._PlayerName + "," + player._kills + "," + player._deaths + "," + player._totalPoints + Environment.NewLine);
        //    }

        //    File.WriteAllText(@".\Reports\" + map + ".csv",result.ToString());
        //}

        //private void compileReports()
        //{
        //    string[] csvFiles = System.IO.Directory.GetFiles(@".\Reports\");
        //    DataTable DT = new DataTable();
        //    DataRow DR;

        //    DT.Columns.Add("PlayerName");
        //    DT.Columns.Add("Kills", Type.GetType("System.Int32"));
        //    DT.Columns.Add("Deaths", Type.GetType("System.Int32"));
        //    DT.Columns.Add("Points",Type.GetType("System.Int32"));

        //    foreach(string file in csvFiles)
        //    {
        //        string[] data = File.ReadAllText(file).Split(new string[] { "\r\n" }, StringSplitOptions.None);

        //        for(int i = 1; i < data.Length -1;i++)
        //        {
        //            string[] columns = data[i].Split(',');
        //            DR = DT.NewRow();
        //            DR["PlayerName"] = columns[0].ToString();
        //            DR["Kills"] = columns[1];
        //            DR["Deaths"] = columns[2];
        //            DR["Points"] = columns[3];

        //            DT.Rows.Add(DR);

        //        }

        //    }
        //    var totals = DT.AsEnumerable()
        //        .GroupBy(r => r.Field<string>("PlayerName"))
        //        .Select(g =>
        //        {
        //            var row = DT.NewRow();
        //            row["PlayerName"] = g.Key;
        //            row["Kills"] = g.Sum(r => r.Field<int>("Kills"));
        //            row["Deaths"] = g.Sum(r => r.Field<int>("Deaths"));
        //            row["Points"] = g.Sum(r => r.Field<Int32>("Points"));

        //            return row;
        //        }).CopyToDataTable();

        //}

    }
}
