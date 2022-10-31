using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
        }
    }
}