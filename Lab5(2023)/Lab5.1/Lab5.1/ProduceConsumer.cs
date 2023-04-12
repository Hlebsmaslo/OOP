using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    public static class ProduceConsumer
    {
        static Queue<int> a = new Queue<int>();
        static object ob = new object();
        public static void Produce()
        {
            for (int i = 0; i < 10; i++)
            {
                int j = new Random().Next(100);
                lock (ob)
                {
                    a.Enqueue(j);
                    Console.WriteLine($"Виробник згенерував випадкове число: {j}.");
                }
                Thread.Sleep(1000);
            }
        }

        public static void Consume()
        {
            while (true)
            {
                int j;
                lock (ob)
                {
                    if (a.Count == 0)
                        continue;
                    j = a.Dequeue();
                }
                Console.WriteLine($"Число, яке отримав споживач: {j}.");
                Thread.Sleep(400);
            }
        }
    }
}