using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            Console.WriteLine("Введiть число вiд 1 до 3");
            code = Convert.ToInt32(Console.ReadLine());
            number application = new number(code);
            Console.WriteLine($"Ви обрали - {code}");
            application.Nu(10, 20);
        }
    }
}
