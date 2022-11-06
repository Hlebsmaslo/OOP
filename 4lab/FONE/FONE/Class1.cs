using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FONE
{
    internal class Class1<C>
    {
        public void metod(C f, C s)
        {
            Debug.WriteLine(f);
            Debug.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Перший параметр: {f.GetType()}. Його значення :");
            Console.WriteLine(f);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Другий параметр: {s.GetType()}. Його значення :{s}");
        }
    }
}
