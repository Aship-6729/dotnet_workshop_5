using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Printer
    {
        // Method Overloading since the method_name is same but frequency or the datatype of a parameter is differ.

        // static method can be called directly by class-name.
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }


        // non-static method needs an object to be called.
        public void Print(int number)
        {
            Console.WriteLine(number);
        }
        public void Print(string message, int count)
        {
            Console.WriteLine($"{message} and {count}");
        }   
    }
}
