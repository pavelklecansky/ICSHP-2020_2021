using System;
using System.Text;

namespace Sample01
{
    class Program
    {
        private const int DEFAULT_COUNT = 10;

        private static int GetCount(string[] args)
        {
            if (args.Length == 0) return DEFAULT_COUNT;
            return int.TryParse(args[0], out int count) ? count : DEFAULT_COUNT;
        }

        static void Main(string[] args)
        {
            // 1. Načetli počet opakování
            var count = GetCount(args);
            // 2. appendování string
            StringBuilder greetings = new StringBuilder("Hello everyone!\n");
            for (int i = 1; i <= count; i++)
            {
                greetings.Append("Hello user " + i + "\n");
            }

            // 3. Vypis do console
            Console.WriteLine(greetings);
        }
    }
}