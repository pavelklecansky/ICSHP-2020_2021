using System;

namespace GuessingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(0, 100);

            var isFind = false;
            while (!isFind)
            {
                Console.WriteLine("Guess a number between 0 and 100");
                var userGuess = int.Parse(Console.ReadLine());
                switch (userGuess)
                {
                    case var _ when userGuess < randomNumber:
                        Console.WriteLine("More");
                        break;
                    case var _ when userGuess > randomNumber:
                        Console.WriteLine("Less");
                        break;
                    case var _ when userGuess == randomNumber:
                        Console.WriteLine("Find");
                        isFind = true;
                        break;
                }
            }
        }
    }
}