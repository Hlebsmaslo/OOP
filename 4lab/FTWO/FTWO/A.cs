using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTWO
{
    internal class A
    {
        public A(B class1)
        {
            Console.WriteLine($"Клас А");
            Console.WriteLine("Клас B");
            Console.WriteLine($" {class1}");
        }
        public A(B class1, B class2)
        {
            Console.WriteLine($"Клас А");
            Console.WriteLine("Клас B");
            Console.WriteLine($" {class1}");
            Console.WriteLine($" {class2}");
        }
        public A(B class1, B class2, B class3)
        {
            Console.WriteLine($"Клас А");
            Console.WriteLine("Клас B");
            Console.WriteLine($" {class1}");
            Console.WriteLine($" {class2}");
            Console.WriteLine($" {class3}");
        }

    }
}
