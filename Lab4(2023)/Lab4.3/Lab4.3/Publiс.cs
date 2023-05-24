using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4._3
{
    public class Publiс
    {
        private EventBus eventBus;

        public void publisher(EventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        public void SendEvent()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    eventBus.Send("EvenEvent", this, EventArgs.Empty);
                }
                else
                {
                    eventBus.Send("OddEvent", this, EventArgs.Empty);
                }
                Thread.Sleep(2000);
            }
        }
    }
}
