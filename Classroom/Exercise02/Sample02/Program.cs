using System;
using UtilsLibrary;

namespace Sample02
{
    class Program
    {
        private static void WorkWithDataType()
        {
            int x = 3;
            int y = x;
            y += 2;
            x++;
            Console.WriteLine($"X: {x}; Y: {y}");
            var number1 = new ComplexNumber(){First = 1,Second = 2};
            var number2 = new ComplexNumber(1, 2);
            var number3 = new ComplexNumber(number2);
            number2.First += 3;
            number3.Second--;
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }

        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            WorkWithDataType();
            Console.WriteLine("Hello World!");
        }
    }
}