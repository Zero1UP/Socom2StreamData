using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Binarysharp.MemoryManagement;
using Socom2StreamData.Models;

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
        private MemorySharp _m;
        public frm_Players_Team(string team)
        {
            InitializeComponent();

            _Team = team;
            if(_Team =="SEALS")
            {
                pnl_Team.BackColor = Color.FromArgb(38, 57, 59);
                lbl_Team.Text = "Seals";
                this.Text = team;

            }else if(_Team=="TERRORISTS")
            {
                pnl_Team.BackColor = Color.FromArgb(70, 42, 42);
                lbl_Team.Text = "Terrorists";
                this.Text = team;
            }
        }

        public string PlayerTeam
        {
            set { _playerTeam = value; }
        }

        public MemorySharp MemObject
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

                        GeneralFunctionsHelper.setLabel(labels.First(), item.PlayerName, item.LivingStatus, item.PointerAddress);

                        var healthBars = pnl_Team_Players.Controls.OfType<Controls.HealthBar>()
                       .Where(hb => hb.Name.Contains("hb_Player_") && hb.healthSet == false)
                       .OrderBy(hb => hb.Name);
                        //Gets the first health bar that hasn't been set
                        var healthBar = healthBars.First();
                        healthBar.Visible = true;


                        var pictureBoxes = pnl_Team_Players.Controls.OfType<PictureBox>()
                        .Where(pc => pc.Tag == "")
                        .OrderBy(hb => hb.Name);

                        var pictureBox = pictureBoxes.First();
                        pictureBox.Tag = item.PlayerName;
                        if (item.HasMPBomb == 1)
                        {
                            pictureBox.Image = Properties.Resources.mpBomb;
                        }
                        else
                        {
                            string currentWeapon = "";

                            try
                            {
                                switch (item.WeaponIndex)
                                {
                                    case 0:
                                        currentWeapon = item.PrimaryWeapon;
                                        break;
                                    case 1:
                                        currentWeapon = item.SecondaryWeapon;
                                        break;
                                    case 2:
                                        currentWeapon = item.EquipmentSlot1;
                                        break;
                                    case 3:
                                        currentWeapon = item.EquipmentSlot2;
                                        break;
                                    case 4:
                                        currentWeapon = item.EquipmentSlot3;
                                        break;
                                    case 5:
                                        currentWeapon = item.ExtraEquipmentSlot;
                                        break;
                                }
                                pictureBox.Image = Collections.Weapons[currentWeapon];
                                pictureBox.Visible = true;
                            }
                            catch (Exception ex)
                            {

                                Console.Write(currentWeapon);
                            }
                        }

                        //If the the teams match then we want to show only thier health bars
                        if (_playerTeam == _Team || _playerTeam == "SPECTATOR")
                        {
                            healthBar.healthBarColor = Color.FromArgb(25, 140, 25);
                            healthBar.playerHealth = decimal.ToInt32(item.PlayerHealth);
                            healthBar.healthSet = true;
                        }
                        else
                        {
                            healthBar.healthBarColor = Color.FromArgb(91, 86, 18);
                            healthBar.playerHealth = 100;
                            healthBar.healthSet = true;

                            if (item.LivingStatus == "DEAD")
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

            foreach (var pictureBox in pnl_Team_Players.Controls.OfType<PictureBox>())
            {
                pictureBox.Visible = false;
                pictureBox.Tag = "";
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
                IntPtr playerPointerAddress = (IntPtr)playerNameLabel.Tag - 0x20000000;
                IntPtr cameraPointerAddress = (IntPtr)_m.Read<int>(GameHelper.CAMERA_POINTER_ADDRESS,false) + 0x20000000;

                _m.Write(cameraPointerAddress + 0xBC, playerPointerAddress, false);
                _m.Write(cameraPointerAddress + 0xC0, playerPointerAddress, false);
            }

        }
    }
}
