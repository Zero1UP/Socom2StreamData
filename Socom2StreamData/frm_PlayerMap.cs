using Socom2StreamData.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socom2StreamData
{
    public partial class frm_PlayerMap : Form
    {
        public List<PlayerDataModel> playerData
        {
            set
            {
                if (value != null)
                {
                    reset();
                    foreach(var item in value)
                    {
                        PlayerLabel pLabel = new PlayerLabel();

                        if(item._PlayerHealth > 0)
                        {
                            pLabel.livingStatus = Color.Green;
                        }
                        else
                        {
                            pLabel.livingStatus = Color.Red;
                        }
                        pLabel.playerName = item._PlayerName;
                        pLabel.playerNameColor = Color.Black;
                        pLabel.Location = new Point(decimal.ToInt32(item._xCoord) /2, decimal.ToInt32(item._yCoord)/2);
                        panel1.Controls.Add(pLabel);
                    }
                }
            }
        }

        private void reset()
        {
            panel1.Controls.Clear();
        }
        public frm_PlayerMap()
        {
            InitializeComponent();
        }
    }
}
