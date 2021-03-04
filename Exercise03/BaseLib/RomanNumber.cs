using System.Collections.Generic;
using System.Text;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Helper class for working with roman numbers
        /// </summary>
        internal class RomanNumber
        {
            private static readonly Dictionary<int, string> NumberRomanSymbols = new();
            private static readonly Dictionary<char, int> RomanNumberSymbols = new();

            static RomanNumber()
            {
                RomanNumberSymbols.Add('I', 1);
                RomanNumberSymbols.Add('V', 5);
                RomanNumberSymbols.Add('X', 10);
                RomanNumberSymbols.Add('L', 50);
                RomanNumberSymbols.Add('C', 100);
                RomanNumberSymbols.Add('D', 500);
                RomanNumberSymbols.Add('M', 1000);
                
                NumberRomanSymbols.Add(1000, "M");
                NumberRomanSymbols.Add(900, "CM");
                NumberRomanSymbols.Add(500, "D");
                NumberRomanSymbols.Add(400, "CD");
                NumberRomanSymbols.Add(100, "C");
                NumberRomanSymbols.Add(90, "XC");
                NumberRomanSymbols.Add(50, "L");
                NumberRomanSymbols.Add(40, "XL");
                NumberRomanSymbols.Add(10, "X");
                NumberRomanSymbols.Add(9, "IX");
                NumberRomanSymbols.Add(5, "V");
                NumberRomanSymbols.Add(4, "IV");
                NumberRomanSymbols.Add(1, "I");
            }

            /// <summary>
            /// Convert decimal number to roman
            /// </summary>
            /// <param name="decimalNumber"></param>
            /// <returns></returns>
            public static string ToRoman(int decimalNumber)
            {
                var roman = new StringBuilder();
                foreach (var (key, value) in NumberRomanSymbols)
                {
                    while (decimalNumber >= key)
                    {
                        roman.Append(value);
                        decimalNumber -= key;
                    }
                }

                return roman.ToString();
            }

            /// <summary>
            /// Convert roman number to decimal
            /// </summary>
            /// <param name="decimalNumber"></param>
            /// <returns></returns>
            public static int FromRoman(string roman)
            {
                var total = 0;

                var previousRoman = '\0';

                foreach (var symbol in roman)
                {
                    var currentRoman = symbol;

                    var previous = previousRoman != '\0' ? RomanNumberSymbols[previousRoman] : '\0';
                    var current = RomanNumberSymbols[currentRoman];

                    if (previous != 0 && current > previous)
                    {
                        total = total - (2 * previous) + current;
                    }
                    else
                    {
                        total += current;
                    }

                    previousRoman = currentRoman;
                }
                
                
                return total;
            }
        }
    }
}