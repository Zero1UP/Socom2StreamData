using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Socom2StreamData
{
    public partial class frm_Stats_GUI : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public List<PlayerDataModel> _pd = new List<PlayerDataModel>();

        public string sealWins
        {
            set
            {
                lbl_S_Rounds.Text = value;
            }
        }

        public string terroristWins
        {
            set
            {
                lbl_T_Rounds.Text = value;
            }
        }
    

        public string sealsAlive
        {
            set
            {
                lbl_S_Alive.Text = value;
            }
        }

        public string terroristAlive
        {
            set
            {
                lbl_T_Alive.Text = value;
            }
        }

        public string roundTime
        {
            set
            {
                lbl_GameTime.Text = value;
            }
        }

        public List<PlayerDataModel> playerData
        {
            set
            {
                resetPlayers();
               
                if(value != null)
                {
                    foreach (var item in value)
                    {

                        if (item._Team == "SEALS")
                        {

                            var labels = pnl_Background.Controls
                           .OfType<Label>()
                           .Where(label => label.Name.Contains("lbl_Seal_") && label.Text == "")
                           .OrderBy(label => label.Name); ;
                            setLabel(labels.First(), item._PlayerName, item._LivingStatus);

                        }
                        else if (item._Team == "TERRORISTS")
                        {
                            var labels = pnl_Background.Controls
                           .OfType<Label>()
                           .Where(label => label.Name.Contains("lbl_Terr_") && label.Text == "")
                           .OrderBy(label => label.Name);
                            setLabel(labels.First(), item._PlayerName, item._LivingStatus);


                        }
                    }
                }

            }
        }



       
        public frm_Stats_GUI()
        {
            InitializeComponent();

            
            this.TransparencyKey = (BackColor); // make GUI form transparent, also removes the border

            // initialize labels to be transparent on picturebox
            lbl_T_Alive.Parent = pictureBox1;
            lbl_T_Alive.Location = new Point(20, 20);//point
            lbl_T_Alive.BackColor = Color.Transparent;

            lbl_S_Alive.Parent = pictureBox1;
            lbl_S_Alive.Location = new Point(172, 20);//point
            lbl_S_Alive.BackColor = Color.Transparent;

            lbl_GameTime.Parent = pictureBox1;
            lbl_GameTime.Location = new Point(68, 0);//point
            lbl_GameTime.BackColor = Color.Transparent;

            lbl_T_Rounds.Parent = pictureBox1;
            lbl_T_Rounds.Location = new Point(74, 37);//point
            lbl_T_Rounds.BackColor = Color.Transparent;

            lbl_S_Rounds.Parent = pictureBox1;
            lbl_S_Rounds.Location = new Point(120, 37);//point
            lbl_S_Rounds.BackColor = Color.Transparent;

        }

        private void pnl_Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnl_Background_MouseLeave(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pnl_Background_MouseEnter(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(25, 25, 25);

        }

        public void resetPlayers()
        {
            foreach (var label in pnl_Background.Controls.OfType<Label>())
            {
                label.Text = "";
                label.ForeColor = Color.FromArgb(175, 175, 175);
                label.BackColor = Color.Transparent;
            }
        }

        public void setLabel(Label label,string playerName,string livingStatus)
        {
            label.Text = playerName;
            if (livingStatus == "DEAD")
            {
                label.ForeColor = Color.FromArgb(175, 175, 175);
            }
            else
            {
                label.ForeColor = Color.FromArgb(215, 215, 215);
                label.BackColor = Color.FromArgb(25, 60, 35);
            }
        }
    }
}
