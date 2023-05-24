using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    public class PriorityS
    {
        public int Priority { get; set; }

        public PriorityS(int priority)
        {
            Priority = priority;
        }
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Priority {Priority} subscriber handling event");
        }
    }
}
