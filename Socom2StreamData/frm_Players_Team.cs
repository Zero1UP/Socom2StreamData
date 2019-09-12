using Memory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Socom2StreamData
{
    public partial class frm_Players_Team : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private string _playerTeam;
        private string _Team;
        private Mem _m;
        public frm_Players_Team(string team)
        {
            InitializeComponent();

            _Team = team;
            if(_Team =="SEALS")
            {
                pnl_Team.BackColor = Color.FromArgb(38, 57, 59);
                lbl_Team.Text = "Seals";

            }else if(_Team=="TERRORISTS")
            {
                pnl_Team.BackColor = Color.FromArgb(70, 42, 42);
                lbl_Team.Text = "Terrorists";
            }
        }

        public string PlayerTeam
        {
            set { _playerTeam = value; }
        }

        public Mem MemObject
        {
            set { _m = value; }
        }

        public List<PlayerDataModel> playerData
        {
            set
            {
                resetPlayers();

                if (value != null)
                {
                    foreach (var item in value)
                    {
                        //Get all labels and assign player Data to them
                        var labels = pnl_Team_Players.Controls
                        .OfType<Label>()
                        .Where(label => label.Name.Contains("lbl_Player_") && label.Text == "")
                        .OrderBy(label => label.Name);

                        GeneralFunctionsHelper.setLabel(labels.First(), item._PlayerName, item._LivingStatus, item._pointerAddress);

                        var healthBars = pnl_Team_Players.Controls.OfType<Controls.HealthBar>()
                       .Where(hb => hb.Name.Contains("hb_Player_") && hb.healthSet == false)
                       .OrderBy(hb => hb.Name);
                        //Gets the first health bar that hasn't been set
                        var healthBar = healthBars.First();
                        healthBar.Visible = true;

                        //If the the teams match then we want to show only thier health bars

                        if(_playerTeam == _Team || _playerTeam == "SPECTATOR")
                        {
                            healthBar.healthBarColor = Color.FromArgb(25, 140, 25);
                            healthBar.playerHealth = decimal.ToInt32(item._PlayerHealth);
                            healthBar.healthSet = true;
                        }
                        else
                        {
                            healthBar.healthBarColor = Color.FromArgb(91, 86, 18);
                            healthBar.playerHealth = 100;
                            healthBar.healthSet = true;

                            if (item._LivingStatus == "DEAD")
                            {
                                healthBar.healthBarColor = Color.FromArgb(75, 75, 75);
                            }
                        }

                    }
                }

            }
        }

        public void resetPlayers()
        {

            foreach (var label in pnl_Team_Players.Controls.OfType<Label>())
            {
                label.Text = "";
                label.ForeColor = Color.FromArgb(175, 175, 175);
                label.BackColor = Color.Transparent;
                label.Tag = "";
            }

            foreach (var healthBar in pnl_Team_Players.Controls.OfType<Controls.HealthBar>())
            {
                healthBar.healthSet = false;
                healthBar.playerHealth = 0;
                healthBar.Visible = false;
            }
        }

        private void pnl_Team_MouseEnter(object sender, EventArgs e)
        {
            if (_Team == "SEALS")
            {
                pnl_Team.BackColor = Color.FromArgb(40, 52, 52);
            }
            else if (_Team == "TERRORISTS")
            {
                pnl_Team.BackColor = Color.FromArgb(56, 37, 37);
            }

        }

        private void pnl_Team_MouseLeave(object sender, EventArgs e)
        {
            if (_Team == "SEALS")
            {
                pnl_Team.BackColor = Color.FromArgb(38, 57, 59);
            }
            else if (_Team == "TERRORISTS")
            {
                pnl_Team.BackColor = Color.FromArgb(70, 42, 42);
            }
          
        }

        private void pnl_Team_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_Team_MouseEnter(object sender, EventArgs e)
        {

            if (_Team == "SEALS")
            {
                pnl_Team.BackColor = Color.FromArgb(40, 52, 52);
            }
            else if (_Team == "TERRORISTS")
            {
                pnl_Team.BackColor = Color.FromArgb(56, 37, 37);
            }
           
        }

        private void lbl_Team_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_Team__MouseLeave(object sender, EventArgs e)
        {
            if(_Team == "SEALS")
            {
                pnl_Team.BackColor = Color.FromArgb(38, 57, 59);
            }
            else if(_Team =="TERRORISTS")
            {
                pnl_Team.BackColor = Color.FromArgb(70, 42, 42);
            }
           
        }

        private void playerNameClick(object sender, EventArgs e)
        {
            if(_playerTeam == "SPECTATOR" && _playerTeam != null)
            {
                Label playerNameLabel = sender as Label;
                //Get the player's pointer address
                string playerPointerAddress = playerNameLabel.Tag.ToString();
                string cameraPointerAddress = ByteConverstionHelper.byteArrayHexToAddressString(_m.readBytes(GameHelper.CAMERA_POINTER_ADDRESS, 4));

                _m.writeMemory((int.Parse(cameraPointerAddress, System.Globalization.NumberStyles.HexNumber) + 188).ToString("X4"), "bytes", ByteConverstionHelper.formatBytesToLittleEndian(int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber), 8));
                _m.writeMemory((int.Parse(cameraPointerAddress, System.Globalization.NumberStyles.HexNumber) + 192).ToString("X4"), "bytes", ByteConverstionHelper.formatBytesToLittleEndian(int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber), 8));
            }

        }
    }
}
