using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Socom2StreamData
{
    public partial class frm_Players_Terrorists : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private string _playerTeam;

        public frm_Players_Terrorists()
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
                    foreach (var item in value)
                    {
                        var labels = pnl_Terr_Players.Controls
                        .OfType<Label>()
                        .Where(label => label.Name.Contains("lbl_Terr_") && label.Text == "")
                        .OrderBy(label => label.Name);

                        GeneralFunctionsHelper.setLabel(labels.First(), item._PlayerName, item._LivingStatus);

                        var healthBars = pnl_Terr_Players.Controls.OfType<Controls.HealthBar>()
                       .Where(hb => hb.Name.Contains("hb_Terr_") && hb.healthSet == false)
                       .OrderBy(hb => hb.Name);
                        var healthBar = healthBars.First();
                        healthBar.Visible = true;

                        if (_playerTeam == "SEALS")
                        {
                            healthBar.healthBarColor = Color.FromArgb(91, 86, 18);
                            healthBar.playerHealth = 100;
                            healthBar.healthSet = true;

                            if (item._LivingStatus == "DEAD")
                            {
                                healthBar.healthBarColor = Color.FromArgb(75, 75, 75);
                            }
                        }
                        else
                        {
                            healthBar.healthBarColor = Color.FromArgb(25, 140, 25);
                            healthBar.playerHealth = decimal.ToInt32(item._PlayerHealth);
                            healthBar.healthSet = true;
                        }
                    }
                }

            }
        }

        public void resetPlayers()
        {

            foreach (var label in pnl_Terr_Players.Controls.OfType<Label>())
            {
                label.Text = "";
                label.ForeColor = Color.FromArgb(175, 175, 175);
                label.BackColor = Color.Transparent;
            }

            foreach (var healthBar in pnl_Terr_Players.Controls.OfType<Controls.HealthBar>())
            {
                healthBar.healthSet = false;
                healthBar.playerHealth = 0;
                healthBar.Visible = false;
            }
        }

        private void pnl_Terrorists_MouseEnter(object sender, EventArgs e)
        {
            pnl_Terrorists.BackColor = Color.FromArgb(56, 37, 37);
        }

        private void pnl_Terrorists_MouseLeave(object sender, EventArgs e)
        {
            pnl_Terrorists.BackColor = Color.FromArgb(70, 42, 42);
        }

        private void pnl_Terrorists_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_Terrorist_MouseEnter(object sender, EventArgs e)
        {
            pnl_Terrorists.BackColor = Color.FromArgb(56, 37, 37);
        }

        private void lbl_Terrorist_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_Terrorist_MouseLeave(object sender, EventArgs e)
        {
            pnl_Terrorists.BackColor = Color.FromArgb(70, 42, 42);
        }
    }
}
