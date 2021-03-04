using System;
using System.Collections.Generic;

namespace Delegat
{
    public class Studenti
    {
        private List<Student> studenti;
        
        public Studenti()
        {
            studenti = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            studenti.Add(student);
        }

        
        
        public void PrintAll()
        {
            foreach (var student in studenti)
            {
                Console.WriteLine(student);
            }
        }

        public void Sort(Comparison<Student> comparison)
        {
            studenti.Sort(comparison);
        }

    }
}