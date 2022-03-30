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
        public static string byteArrayHexToAddressString(byte[] data, bool replaceFirstDigit =true)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte b in data.Reverse())
            {
                result.AppendFormat("{0:x2}", b);
            }
            if(replaceFirstDigit)
            {
                result[0] = '2';
            }
            
            return result.ToString();
        }

        /// <summary>
        /// Reverses a byte array and returns it as a string.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string byteArrayHexToHexString(this byte[] data, bool byteSpacing = false)
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
        public static string GetNullTerminatedString(this byte[] data)
        {
            var inx = Array.FindIndex(data, 0, (x) => x == 0);//search for 0

            return inx >= 0 ? Encoding.UTF8.GetString(data, 0, inx) : Encoding.UTF8.GetString(data);
        }
        public static decimal byteHexFloatToDecimal(this byte[] data, bool isPercentage =true)
        {
            string convertedBytesToString = byteArrayHexToHexString(data);
            Int32 convertedStringToInt = Int32.Parse(convertedBytesToString, System.Globalization.NumberStyles.AllowHexSpecifier);
            float f = BitConverter.ToSingle(BitConverter.GetBytes(convertedStringToInt), 0);

            if(isPercentage)
            {
                return Convert.ToDecimal(f) * 100;
            }
            else
            {
                return Convert.ToDecimal(f);
            }
            
        }

        /// <summary>
        /// Reverses a byte array and then converts it to Int16.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Int16 byteArrayToInt16(byte[] data)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte b in data.Reverse())
            {
                result.AppendFormat("{0:x2}", b);
            }
            return Convert.ToInt16("0x" + result.ToString(), 16);
        }
        /// <summary>
        /// Formats the passed in int to little endian.
        /// </summary>
        public static string formatBytesToLittleEndian(int value, int length)
        {

            //This doesn't handle a pointer that originally started with a 0 / 00. Needs fixed
            string result = "";
            string hexValue = value.ToString("X");


            if (hexValue.Length < length)
            {
                int diff = length - hexValue.ToString().Length;
                for (int i = 0; i < diff; i++)
                {
                    hexValue = "0" + hexValue;
                }
            }

            //hexValue += value.ToString("X");
            int hexFormattingLength = hexValue.Length % 2;


            if (hexFormattingLength != 0)
            {
                hexFormattingLength = hexFormattingLength + hexValue.Length;
                hexValue = value.ToString("X" + hexFormattingLength);
            }


            List<string> hexBytes = new List<string>();

            if (hexValue.Length != 2)
            {
                for (int i = 0; i < hexValue.Length; i += 2)
                {
                    hexBytes.Add(hexValue.Substring(i, Math.Min(2, hexValue.Length - 1)));
                }

            }
            else
            {
                hexBytes.Add(hexValue);
            }

            hexBytes.Reverse();

            foreach (var item in hexBytes)
            {
                result += "0x" + item + " ";
            }

            return result.Trim(); // not dicking around with the trailing space
        }


    }
}
