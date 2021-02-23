using System;

namespace PersonalIdentificationNumber
{
    class Program
    {
        static bool isMale(string idNumber)
        {
            if (idNumber.Length < 10 )
            {
                throw new FormatException();
            }

            var month = int.Parse(idNumber.Substring(2, 2));
            return month <= 50;
        }

        static bool isWoman(string idNumber)
        {
            return !isMale(idNumber);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(isMale("8551261158"));
        }
    }
}