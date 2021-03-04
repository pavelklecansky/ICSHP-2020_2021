using System;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Class for converting numeral systems
        /// </summary>
        public class MathConvertor
        {
            /// <summary>
            /// Convert from Decimal (Base 10) to Binary (Base 2)
            /// </summary>
            /// <returns></returns>
            public static string DecimalToBinary(int decimalNumber)
            {
                return Convert.ToString(decimalNumber, 2);
            }

            /// <summary>
            /// Convert from Binary (Base 2) to Decimal (Base 10)
            /// </summary>
            /// <returns></returns>
            public static int BinaryToDecimal(string binaryString)
            {
                return Convert.ToInt32(binaryString, 2);
            }

            /// <summary>
            /// Convert from Decimal (Base 10) to Roman
            /// </summary>
            /// <returns></returns>
            public static string DecimalToRoman(int decimalNumber)
            {
                return RomanNumber.ToRoman(decimalNumber);
            }

            /// <summary>
            /// Convert from Decimal (Base 10) to Roman
            /// </summary>
            /// <returns></returns>
            public static int RomanToDecimal(string roman)
            {
                return RomanNumber.FromRoman(roman);
            }
        }
    }
}