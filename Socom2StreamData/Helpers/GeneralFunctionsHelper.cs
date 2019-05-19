using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socom2StreamData
{
    public static class GeneralFunctionsHelper
    {
        public static void setLabel(Label label, string playerName, string livingStatus)
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
    }
}
