using System;
using System.ComponentModel.Design;
using System.Linq;
using Fei.BaseLib;

namespace ArrayProject
{
    class Program
    {

         private static readonly string menu = @"1. Zadaní prvků pole z klávesnice
2. Výpis pole na obrazovku
3. Utřídění pole vzestupně
4. Hledání minimálního prvku
5. Hledání prvního výskytu zadaného čísla
6. Hledání posledního výskytu zadaného čísla
7. Konec programu";
        
        public static int[] numberArray { get; set; }

        static void PrintMenu()
        {
            Console.WriteLine(menu);
        }

        static void Main(string[] args)
        {
            var endTheProgram = false;
            while (!endTheProgram)
            {
                PrintMenu();
                var userInput = Reading.ReadInt("Vyberte přikaz");
                switch (userInput)
                {
                    case 1:
                        LoadArray();
                        break;
                    case 2:
                        PrintArray();
                        break;
                    case 3:
                        SortArrayAscending();
                        break;
                    case 4:
                        FindMinInArray();
                        break;
                    case 5:
                        FindFirstAppearenceOfNumber();
                        break;
                    case 6:
                        FindLastApperanceOfNumber();
                        break;
                    case 7:
                        endTheProgram = true;
                        Console.WriteLine("Program je ukončen");
                        break;
                    default:
                        Console.WriteLine("Vybraný přikaz neexistuje.");
                        break;
                }
            }
        }

        private static void FindLastApperanceOfNumber()
        {
            var numberToByFind = Reading.ReadInt("Číslo které chcete najít");
            var index = Array.LastIndexOf(numberArray, numberToByFind);
            if (index == -1)
            {
                Console.WriteLine("Číslo nebylo nalezeno.");
            }
            else
            {
                Console.WriteLine("Číslo bylo nalezeno na: " + index);
            }
        }

        private static void FindFirstAppearenceOfNumber()
        {
            var numberToByFind = Reading.ReadInt("Číslo které chcete najít");
            var index = Array.IndexOf(numberArray, numberToByFind);
            if (index == -1)
            {
                Console.WriteLine("Číslo nebylo nalezeno.");
            }
            else
            {
                Console.WriteLine("Číslo bylo nalezeno na: " + index);
            }
        }

        private static void FindMinInArray()
        {
            Console.WriteLine(numberArray.Min());
        }

        private static void SortArrayAscending()
        {
            Array.Sort(numberArray);
        }

        private static void PrintArray()
        {
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }
        }

        private static void LoadArray()
        {
            var arraySize = Reading.ReadInt("Zadejte velikost pole");
            numberArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                var number = Reading.ReadInt($"Zadejte {i} položku pole");
                numberArray[i] = number;
            }

            Console.WriteLine("Pole bylo načteno.");
        }
    }
}