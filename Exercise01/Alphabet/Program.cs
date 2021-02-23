using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var charater in Enumerable.Range(97,26))
            {
                Console.WriteLine((char) charater);
            }
        }
    }
}