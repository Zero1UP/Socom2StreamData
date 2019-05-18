using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom2StreamData
{
    public static class ByteConverstionHelper
    {
        public static string convertBytesToString(byte[] data)
        {
            if (data != null)
            {
                string result;

                data.Reverse();

                result = Encoding.Default.GetString(data);

                var cleanedString = result.Split(new string[] { "\0" }, StringSplitOptions.None);
                return cleanedString[0].Replace(',', ' ');
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Takes the passed in byte array and converts it to be used as the next lookup address. This is mainly used for when dealing
        /// with pointer values. ex: 200A0000
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string byteArrayHexToAddressString(byte[] data)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte b in data.Reverse())
            {
                result.AppendFormat("{0:x2}", b);
            }
            result[0] = '2';
            return result.ToString();
        }

        /// <summary>
        /// Reverses a byte array and returns it as a string.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string byteArrayHexToHexString(byte[] data, bool byteSpacing = false)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte b in data.Reverse())
            {
                if (byteSpacing == true)
                {
                    result.AppendFormat("{0:x2}" + " ", b);
                }
                else
                {
                    result.AppendFormat("{0:x2}", b);
                }

            }

            return result.ToString();
        }

        public static decimal byteHexFloatToDecimal(byte[] data)
        {
            string convertedBytesToString = byteArrayHexToHexString(data);
            Int32 convertedStringToInt = Int32.Parse(convertedBytesToString, System.Globalization.NumberStyles.AllowHexSpecifier);
            float f = BitConverter.ToSingle(BitConverter.GetBytes(convertedStringToInt), 0);
            return Convert.ToDecimal(f) * 100;
        }
    }
}
