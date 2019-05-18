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
    public partial class HealthBar : UserControl
    {

        private int _playerHealth = 100;
        private bool _healthSet = false;

        public int playerHealth
        {
            get { return _playerHealth; }
            set
            {
                _playerHealth = value;
                pnl_HealthBar.Width = value;
                pnl_HealthBar.Refresh();
            }
        }

        public bool healthSet
        {
            get { return _healthSet; }
            set { _healthSet = value; }
        }

        public HealthBar()
        {
            InitializeComponent();
        }
    }
}
