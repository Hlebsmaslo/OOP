using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4._2
{
    public class Class2
    {
        private Class1 evBus;

        public Class2(Class1 eventBus)
        {
            this.evBus = eventBus;
        }
        public void SendEvent()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    evBus.Send("EvEv", this, EventArgs.Empty);
                }
                else
                {
                    evBus.Send("OdEv", this, EventArgs.Empty);
                }
                Thread.Sleep(2000);
            }
        }
    }
    public class PrS
    {
        public int Priority { get; set; }

        public PrS(int priority)
        {
            Priority = priority;
        }
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Прioрiтет {Priority}.");
        }
    }
}
