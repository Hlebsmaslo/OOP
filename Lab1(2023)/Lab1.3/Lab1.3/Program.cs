using System;
using System.Linq;
using System.Text;

namespace Lab1._3
{
    internal class Program
    {
        public delegate int A(int a, int b, int c);
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть 3 числа");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            A delegation = (a, b, c) => (a + b + c) / 3;
            Console.WriteLine(delegation(x, y, z));
        }
    }
}
