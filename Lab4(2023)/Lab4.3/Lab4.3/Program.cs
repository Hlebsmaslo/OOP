using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            EventBus eventBus = new EventBus(5, 1000, 5000, 1.5);
            System.Security.Policy.Publisher publisher = new System.Security.Policy.Publisher(eventBus);

            PriorityS s1 = new PriorityS(1);
            PriorityS s2 = new PriorityS(2);
            PriorityS s3 = new PriorityS(3);

            eventBus.Register("OddEvent", s1.Priority, new Action<object, EventArgs>(s1.HandleEvent));
            eventBus.Register("EvenEvent", s2.Priority, new Action<object, EventArgs>(s2.HandleEvent));
            eventBus.Register("OddEvent", s3.Priority, new Action<object, EventArgs>(s3.HandleEvent));


            publisher.SendEvent();

            Console.ReadLine();
        }
    }
}
