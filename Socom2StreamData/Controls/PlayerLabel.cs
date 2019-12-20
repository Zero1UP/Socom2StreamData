using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socom2StreamData.Controls
{
    public partial class PlayerLabel : UserControl
    {
        public Color livingStatus
        {

            set
            {
                pnl_LivingStatus.BackColor = value;
               
            }
        }
        public string playerName
        {
            
            set { lbl_Name.Text = value; }
        }

        public Color playerNameColor
        {
            set { lbl_Name.ForeColor = value; }
        }
        public PlayerLabel()
        {
            InitializeComponent();
        }
    }
}
