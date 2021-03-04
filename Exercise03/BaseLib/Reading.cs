using System;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Class for reading from standard input.
        /// </summary>
        public class Reading
        {
            /// <summary>
            /// Print message and parse to int from standard input.
            /// </summary>
            /// <param name="message"></param>
            /// <returns></returns>
            public static int ReadInt(string message)
            {
                Console.Write(message + ": ");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number))
                {
                    return number;
                }

                throw new ArgumentException("Bad number format");
            }

            /// <summary>
            /// Print message and parse to double from standard input.
            /// </summary>
            /// <param name="message"></param>
            /// <returns></returns>
            public static double ReadDouble(string message)
            {
                Console.Write(message + ": ");
                var userInput = Console.ReadLine();

                if (double.TryParse(userInput, out double number))
                {
                    return number;
                }

                throw new ArgumentException("Bad number format");
            }

            /// <summary>
            /// Print message and read char from standard input.
            /// </summary>
            /// <param name="message"></param>
            /// <returns></returns>
            public static char ReadChar(string message)
            {
                Console.Write(message + ": ");
                return (char) Console.Read();
            }

            /// <summary>
            /// Print message and read string from standard input.
            /// </summary>
            /// <param name="message"></param>
            /// <returns></returns>
            public static string ReadString(string message)
            {
                Console.Write(message + ": ");
                return Console.ReadLine();
            }
        }
    }
}