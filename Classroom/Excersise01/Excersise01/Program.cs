using System;
using System.Diagnostics;

namespace Excersise01
{

    
    
    class Program
    {


        public class A
        {
            
        }

        public class B : A
        {
            
        }
        
        public int Type { get; set; }     
        
        static void foo(int i)
        {
            Console.WriteLine(i);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] ar = {1, 3, 5};

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] += 3;
            }

            int? someInteger = 3;
            foo(someInteger.Value);

            var a = new A();
            var b = new B();

            A bRef = b;
            


        }
    }
}