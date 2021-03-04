using System;
using Fei.BaseLib;

namespace Delegat
{
    class Program
    {
        public static Studenti Studenti { get; set; }

        private static string menu = @"1) Načtení studentů z klávesnice
2) Výpis studentů na obrazovku
3) Seřazení studentů podle čísla
4) Seřazení studentů podle jména
5) Seřazení studentů podle fakulty
0) Konec programu";

        private static void PrintMenu()
        {
            Console.WriteLine(menu);
        }

        static void Main(string[] args)
        {
            Studenti = new Studenti();
            Studenti.AddStudent(new Student("Pavel",12,Fakulta.Fei));
            Studenti.AddStudent(new Student("Dan",15,Fakulta.Fes));
            Studenti.AddStudent(new Student("Ana",10,Fakulta.Fcht));
            Studenti.AddStudent(new Student("Homza",17,Fakulta.Ff));
            Studenti.AddStudent(new Student("XXaver",80,Fakulta.Ff));
            Studenti.AddStudent(new Student("Zarder",10,Fakulta.Fei));
            while (true)
            {
                PrintMenu();
                var userInput = Reading.ReadInt("Select command");
                switch (userInput)
                {
                    case 1:
                        LoadStudents();
                        break;
                    case 2:
                        PrintStudents();
                        break;
                    case 3:
                        SortByNumber();
                        break;
                    case 4:
                        SortByName();
                        break;
                    case 5:
                        SortByFaculty();
                        break;

                    case 0:
                        Console.WriteLine("Program is terminated");
                        return;
                    default:
                        Console.WriteLine("Selected command doesn't exists.");
                        break;
                }
            }
        }

        private static void SortByFaculty()
        {
            Studenti.Sort((student, student1) => student.Fakulta.CompareTo(student1.Fakulta));
        }

        private static void SortByName()
        {
            Studenti.Sort((student, student1) => String.Compare(student.Jmeno, student1.Jmeno, StringComparison.Ordinal));
        }

        private static void SortByNumber()
        {
            Studenti.Sort((student, student1) => student.Cislo.CompareTo(student1.Cislo));
        }

        private static void PrintStudents()
        {
            Studenti.PrintAll();
        }

        private static void LoadStudents()
        {
            var numberOfStudents = Reading.ReadInt("How many student will you be adding?");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("--- New Student ---");
                var number = Reading.ReadInt($"Enter student number");
                var name = Reading.ReadString($"Enter student name");
                Fakulta.TryParse(Reading.ReadString($"Enter student faculty(Fes,Ff,Fei,Fcht)"), out Fakulta faculty);
                Student student = new Student(name, number, faculty);
                Studenti.AddStudent(student);
                
            }

            Console.WriteLine("All students were loaded.");
        }
    }
}