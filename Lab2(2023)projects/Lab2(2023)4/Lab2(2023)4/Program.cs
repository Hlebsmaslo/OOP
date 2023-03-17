using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2023_4
{
    public class Program
    {
        delegate int a(string str);
        static void Main(string[] args)
        {
            string[] b = { "a", "an", "the" };
            a A = s => s.Length;
            foreach (string B in b)
            {
                int c = A(B);
                Console.WriteLine($"{B}: {c}");
            }
        }
    }
}
