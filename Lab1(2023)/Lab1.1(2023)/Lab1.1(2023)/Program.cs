using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1_2023_
{
    internal class Program
    {
        public delegate int arithmetic(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше, потiм друге число");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Сума");
            arithmetic arithmetic = (x, y) => x + y;
            Console.WriteLine(arithmetic(A, B));
            Console.WriteLine("Рiзниця");
            arithmetic += (x, y) => x - y;
            Console.WriteLine(arithmetic(A, B));
            Console.WriteLine("Множення");
            arithmetic += (x, y) => x * y;
            Console.WriteLine(arithmetic(A, B));
            arithmetic += (x, y) =>
            {
                int c = 0;
                try
                {
                    c = x / y;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                return c;
            };
            Console.WriteLine(arithmetic(A, B));
        }
    }
}
