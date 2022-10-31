using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class Printer2 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
        }
    }
}
