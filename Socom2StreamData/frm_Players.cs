using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Socom2StreamData
{
    public partial class frm_Players : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private string _playerTeam;


        public frm_Players()
        {
            InitializeComponent();
        }

        public string PlayerTeam
        {
            set { _playerTeam = value; }
        }

        public List<PlayerDataHelper> playerData
        {
            set
            {
                resetPlayers();

                if (value != null)
                {

                    //Only want to show players their own team's health
                    if(_playerTeam =="SEALS")
                    {
                        pnl_Seals.Visible = true;
                        pnl_Terrorists.Visible = false;
                    }else if(_playerTeam =="TERRORISTS")
                    {
                        pnl_Terrorists.Visible = true;
                        pnl_Seals.Visible = false;
                    }
                    else
                    {
                        pnl_Seals.Visible = true;
                        pnl_Terrorists.Visible = true;
                    }

                    foreach (var item in value)
                    {

                        if (item._Team == "SEALS")
                        {

                            var labels = pnl_Seal_Players.Controls
                           .OfType<Label>()
                           .Where(label => label.Name.Contains("lbl_Seal_") && label.Text == "")
                           .OrderBy(label => label.Name); ;  
                            setLabel(labels.First(), item._PlayerName, item._LivingStatus);



                            var healthBars = pnl_Seal_Players.Controls.OfType<Controls.HealthBar>()
                            .Where(hb => hb.Name.Contains("hb_Seal_") && hb.healthSet == false)
                            .OrderBy(hb => hb.Name);

                            var healthBar = healthBars.First();
                            healthBar.playerHealth = decimal.ToInt32(item._PlayerHealth);
                            healthBar.healthSet = true;
                        }
                        else if (item._Team == "TERRORISTS")
                        {
                            var labels = pnl_Terr_Players.Controls
                           .OfType<Label>()
                           .Where(label => label.Name.Contains("lbl_Terr_") && label.Text == "")
                           .OrderBy(label => label.Name);
                            setLabel(labels.First(), item._PlayerName, item._LivingStatus);

                            var healthBars = pnl_Terr_Players.Controls.OfType<Controls.HealthBar>()
                           .Where(hb => hb.Name.Contains("hb_Terr_") && hb.healthSet == false)
                           .OrderBy(hb => hb.Name);
                           var healthBar = healthBars.First();

                            healthBar.playerHealth = decimal.ToInt32(item._PlayerHealth);
                            healthBar.healthSet = true;
                          
                        }

                    }
                }

            }
        }
        public void resetPlayers()
        {

            foreach(var label in pnl_Seal_Players.Controls.OfType<Label>())
            {
                label.Text = "";
                label.ForeColor = Color.FromArgb(175, 175, 175);
                label.BackColor = Color.Transparent;
            }
            foreach (var label in pnl_Terr_Players.Controls.OfType<Label>())
            {
                label.Text = "";
                label.ForeColor = Color.FromArgb(175, 175, 175);
                label.BackColor = Color.Transparent;
            }

            foreach(var healthBar in pnl_Seal_Players.Controls.OfType<Controls.HealthBar>())
            {
                healthBar.healthSet = false;
                healthBar.playerHealth = 0;
            }

            foreach (var healthBar in pnl_Terr_Players.Controls.OfType<Controls.HealthBar>())
            {
                healthBar.healthSet = false;
                healthBar.playerHealth = 0;
            }
        }

        public void setLabel(Label label, string playerName, string livingStatus)
        {
            label.Text = playerName;
            if (livingStatus == "DEAD")
            {
                label.ForeColor = Color.FromArgb(175, 175, 175);
            }
            else
            {
                label.ForeColor = Color.FromArgb(215, 215, 215);
            }
        }

        private void pnl_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnl_Main_MouseLeave(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pnl_Background_MouseEnter(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(25, 25, 25);
        }
    }
}
