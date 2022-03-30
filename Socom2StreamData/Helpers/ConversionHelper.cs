using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public static class ConversionHelper
    {
        public static int HexToInt(string value)
        {
            return int.Parse(value, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
