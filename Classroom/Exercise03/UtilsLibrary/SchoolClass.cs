using System;
using System.Collections.Generic;

namespace UtilsLibrary
{
    public class SchoolClass
    {
        private IList<string> studentNames;

        private int year;

        public int Year
        {
            get => year;
            set
            {
                if (value < 1900)
                {
                    throw new ArgumentOutOfRangeException("Year cannot be lower then 1900.");
                }
                year = value;
            }
        }

        public delegate void OperationDelagate(string studentName);


        public SchoolClass(int year)
        {
            this.Year = year;
            studentNames = new List<string>();
        }

        public static implicit operator SchoolClass(int year)
        {
            return new SchoolClass(year);
        }
        
        public static explicit operator SchoolClass(string year)
        {
            return new SchoolClass(int.Parse(year));
        }
        
        public void ProcessOperation(OperationDelagate operation)
        {
            foreach (var studentName in studentNames)
            {
                operation(studentName);
            }
        }
    }
}