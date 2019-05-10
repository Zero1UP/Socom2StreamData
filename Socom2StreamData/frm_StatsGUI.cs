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



    

    public partial class frmSTATS_GUI : Form
    {

        public string sealWins
        {
            set
            {
                lbl_S_rounds.Text = value;
            }
        }

        public string terroristWins
        {
            set
            {
                lbl_T_rounds.Text = value;
            }
        }
    

        public string sealsAlive
        {
            set
            {
                lbl_S_alive.Text = value;
            }
        }

        public string terroristAlive
        {
            set
            {
                lbl_T_alive.Text = value;
            }
        }

        public string roundTime
        {
            set
            {
                lbl_game_time.Text = value;
            }
        }

        public List<PlayerDataHelper> playerData
        {
            set
            {
                resetPlayers();
               
                foreach (var item in value)
                {
                   
                    if (item._Team == "SEALS")
                    {
                       
                        var labels = pnl_Background.Controls
                       .OfType<Label>()
                       .Where(label => label.Name.Contains("lbl_seal_") && label.Text == "")
                       .OrderBy(label => label.Name); ;
                        setLabel(labels.First(), item._PlayerName, item._LivingStatus);

                    }else if(item._Team =="TERRORISTS")
                    {
                        var labels = pnl_Background.Controls
                       .OfType<Label>()
                       .Where(label => label.Name.Contains("lbl_terr_") && label.Text == "")
                       .OrderBy(label=>label.Name);
                       setLabel(labels.First(), item._PlayerName, item._LivingStatus);
                    }
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public List<PlayerDataHelper> _pd = new List<PlayerDataHelper>();
        public frmSTATS_GUI()
        {
            InitializeComponent();


            // make GUI form transparent
            this.TransparencyKey = (BackColor);
            // move GUI above main form
            this.StartPosition = FormStartPosition.Manual;
            fmr_Main main_form = new fmr_Main();
            this.Location = new Point(main_form.Location.X+540, main_form.Location.Y+275);


            // initialize labels to be transparent on picturebox
            lbl_T_alive.Parent = pictureBox1;
            lbl_T_alive.Location = new Point(20, 20);//point
            lbl_T_alive.BackColor = Color.Transparent;

            lbl_S_alive.Parent = pictureBox1;
            lbl_S_alive.Location = new Point(172, 20);//point
            lbl_S_alive.BackColor = Color.Transparent;

            lbl_game_time.Parent = pictureBox1;
            lbl_game_time.Location = new Point(68, 0);//point
            lbl_game_time.BackColor = Color.Transparent;

            lbl_T_rounds.Parent = pictureBox1;
            lbl_T_rounds.Location = new Point(74, 37);//point
            lbl_T_rounds.BackColor = Color.Transparent;

            lbl_S_rounds.Parent = pictureBox1;
            lbl_S_rounds.Location = new Point(120, 37);//point
            lbl_S_rounds.BackColor = Color.Transparent;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            GUI_background_enable();
            
        }

        private void GUI_background_enable()
        {
            pnl_Background.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            GUI_background_enable();
        }


        private void lbl_terr_p1_MouseMove(object sender, MouseEventArgs e)
        {
            GUI_background_enable();
        }

        public void resetPlayers()
        {
            lbl_seal_p1.Text = "";
            lbl_seal_p2.Text = "";
            lbl_seal_p3.Text = "";
            lbl_seal_p4.Text = "";
            lbl_seal_p5.Text = "";
            lbl_seal_p6.Text = "";
            lbl_seal_p7.Text = "";
            lbl_seal_p8.Text = "";
            lbl_terr_p1.Text = "";
            lbl_terr_p2.Text = "";
            lbl_terr_p3.Text = "";
            lbl_terr_p4.Text = "";
            lbl_terr_p5.Text = "";
            lbl_terr_p6.Text = "";
            lbl_terr_p7.Text = "";
            lbl_terr_p8.Text = "";

            lbl_seal_p1.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p2.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p3.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p4.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p5.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p6.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p7.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_seal_p8.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p1.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p2.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p3.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p4.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p5.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p6.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p7.ForeColor = Color.FromArgb(175, 175, 175);
            lbl_terr_p8.ForeColor = Color.FromArgb(175, 175, 175);

            lbl_seal_p1.BackColor = Color.Transparent;
            lbl_seal_p2.BackColor = Color.Transparent;
            lbl_seal_p3.BackColor = Color.Transparent;
            lbl_seal_p4.BackColor = Color.Transparent;
            lbl_seal_p5.BackColor = Color.Transparent;
            lbl_seal_p6.BackColor = Color.Transparent;
            lbl_seal_p7.BackColor = Color.Transparent;
            lbl_seal_p8.BackColor = Color.Transparent;

            lbl_terr_p1.BackColor = Color.Transparent;
            lbl_terr_p2.BackColor = Color.Transparent;
            lbl_terr_p3.BackColor = Color.Transparent;
            lbl_terr_p4.BackColor = Color.Transparent;
            lbl_terr_p5.BackColor = Color.Transparent;
            lbl_terr_p6.BackColor = Color.Transparent;
            lbl_terr_p7.BackColor = Color.Transparent;
            lbl_terr_p8.BackColor = Color.Transparent;
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
