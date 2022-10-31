using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("1234");
            Printer2 Printer2 = new Printer2();
            Printer2.Print("5678");
        }
    }
}
