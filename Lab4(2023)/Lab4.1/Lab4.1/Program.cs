using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            EventHandler h1 = (send, e) =>
            {
                Console.WriteLine($"Обробник 1 запущено {DateTime.Now}");
            };
            EventHandler h2 = (send, e) =>
            {
                Console.WriteLine($"Обробник 2 запущено {DateTime.Now}");
            };
            class1.RegisterEventHandler("event1", h1);
            class1.RegisterEventHandler("event1", h2);
            for (int i = 0; i < 10; i++)
            {
                class1.TriggerEvent("event1", EventArgs.Empty, 1000);
                Thread.Sleep(1000);
            }
            class1.UnregisterEventHandler("event1", h2);

            for (int i = 0; i < 10; i++)
            {
                class1.TriggerEvent("event1", EventArgs.Empty, 1000);
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
