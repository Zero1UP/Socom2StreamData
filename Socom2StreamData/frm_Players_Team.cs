using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Binarysharp.MemoryManagement;
using Socom2StreamData.Controls;
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
                
                List<Label> playerNamesList = pnl_Team_Players.Controls.OfType<Label>().OrderBy(p => p.Name).ToList();
                List<HealthBar> playerHealthBarsList = pnl_Team_Players.Controls.OfType<HealthBar>().OrderBy(p => p.Name).ToList();
                List<PictureBox> playerWeaponsList = pnl_Team_Players.Controls.OfType<PictureBox>().OrderBy(p => p.Name).ToList();

                if (value != null)
                {
                    List<Label> skipPlayerNames = playerNamesList.Skip(value.Count).ToList();
                    List<HealthBar> skipPlayerHealthBars = playerHealthBarsList.Skip(value.Count).ToList();
                    List<PictureBox> skipPlayerWeapons = playerWeaponsList.Skip(value.Count).ToList();

                    SetIgnoredControls(skipPlayerNames,skipPlayerHealthBars, skipPlayerWeapons);

                    int index = 0;
                    foreach (var item in value)
                    {
                        GeneralFunctionsHelper.setLabel(playerNamesList[index], item.PlayerName, item.LivingStatus, item.PointerAddress);
                        playerNamesList[index].Visible = true;
                        playerHealthBarsList[index].Visible = true;

                        playerWeaponsList[index].Tag = item.PlayerName;
                        if (item.HasMPBomb == 1)
                        {
                            playerWeaponsList[index].Image = Properties.Resources.MPBomb;
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
                                playerWeaponsList[index].Image = Collections.Weapons[currentWeapon];
                                playerWeaponsList[index].Visible = true;
                            }
                            catch (Exception ex)
                            {

                                Console.Write(currentWeapon);
                            }
                        }

                        //If the the teams match then we want to show only thier health bars
                       
                        if (_playerTeam == _Team || _playerTeam == "SPECTATOR")
                        {
                            playerHealthBarsList[index].healthBarColor = Color.FromArgb(25, 140, 25);
                            playerHealthBarsList[index].playerHealth = decimal.ToInt32(item.PlayerHealth);
                            playerHealthBarsList[index].healthSet = true;
                        }
                        else
                        {
                            playerHealthBarsList[index].healthBarColor = Color.FromArgb(91, 86, 18);
                            playerHealthBarsList[index].playerHealth = 100;
                            playerHealthBarsList[index].healthSet = true;

                            if (item.LivingStatus == "DEAD")
                            {
                                playerHealthBarsList[index].healthBarColor = Color.FromArgb(75, 75, 75);
                            }
                        }
                        index++;

                    }
                }

            }
        }

        public void SetIgnoredControls(List<Label> playerNames, List<HealthBar> playerHealthbars,List<PictureBox> playerWeapon)
        {
            foreach (var item in playerNames)
            {
                item.Visible = false;
            }
            foreach (var item in playerHealthbars)
            {
                item.Visible = false;
            }
            foreach (var item in playerWeapon)
            {
                item.Visible = false;
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
