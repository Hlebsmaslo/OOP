using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Робочий процес розпочато");
            var rp = new Class2();
            rp.actadd += aa;
            rp.compl += ac1;
            rp.workcompl += wc;
            rp.Run();
            Console.WriteLine("Робочий процес завершено");
        }

        private static void aa(object sender, ActionEventArgs a)
        {
            Console.WriteLine($"Подiя {a.Action.Name} додано до робочого процесу");
        }

        private static void ac1(object sender, ActionEventArgs a)
        {
            Console.WriteLine($"Подiя {a.Action.Name} виконана");
        }

        private static void wc(object sender, EventArgs a)
        {
            Console.WriteLine("Робочий процес закiнчено");
        }
    }
}
