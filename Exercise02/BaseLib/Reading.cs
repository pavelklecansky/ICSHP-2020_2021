using System;

namespace Fei
{
    namespace BaseLib
    {
        public class Reading
        {
            public static int ReadInt(string message)
            {
                Console.Write(message + ": ");
                var userInput = Console.ReadLine();

                return int.TryParse(userInput, out int number) ? number : 0;
            }

            public static double ReadDouble(string message)
            {
                Console.Write(message + ": ");
                var userInput = Console.ReadLine();

                return double.TryParse(userInput, out double number) ? number : 0;
            }

            public static char ReadChar(string message)
            {
                Console.Write(message + ": ");
                return (char) Console.Read();
            }

            public static string ReadString(string message)
            {
                Console.Write(message + ": ");
                return Console.ReadLine();
            }
        }
    }
}