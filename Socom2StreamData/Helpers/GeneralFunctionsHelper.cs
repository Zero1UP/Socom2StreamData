using System;
using System.Drawing;
using System.Windows.Forms;

namespace Socom2StreamData
{
    public static class GeneralFunctionsHelper
    {
        public static void setLabel(Label label, string playerName, string livingStatus,int labelName)
        {
            label.Text = playerName;
            label.Tag = labelName;
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
