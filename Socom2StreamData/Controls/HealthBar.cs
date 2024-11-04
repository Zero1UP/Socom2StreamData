namespace Socom2StreamData.Controls
{
    public partial class HealthBar : UserControl
    {

        private int _playerHealth = 100;
        private bool _healthSet = false;
        private Color _healthBarColor;
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
            set { _healthSet = value;

            }
        }

        public Color healthBarColor
        {
         
            set
            {
                _healthBarColor = value;
                pnl_HealthBar.BackColor = value;
            }
        }

        public HealthBar()
        {
            InitializeComponent();
        }
    }
}
