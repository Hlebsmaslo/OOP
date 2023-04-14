using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    public class Class1
    {
        public string Name { get; set; }
        public Class1(string name)
        {
            Name = name;
        }
        public void Ex()
        {
            Console.WriteLine($"Виконання дiї {Name}.");
        }
    }
    public class ActionEventArgs : EventArgs
    {
        public Class1 Action { get; set; }

        public ActionEventArgs(Class1 action)
        {
            Action = action;
        }
    }
}
