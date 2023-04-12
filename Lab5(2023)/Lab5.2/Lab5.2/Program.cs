using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread Light1 = new Thread(() => Class.TrafficLight(1));
            Thread Light2 = new Thread(() => Class.TrafficLight(2));
            Thread Light3 = new Thread(() => Class.TrafficLight(3));
            Thread Light4 = new Thread(() => Class.TrafficLight(4));
            Light1.Start();
            Light2.Start();
            Light3.Start();
            Light4.Start();
            Light1.Join();
            Light2.Join();
            Light3.Join();
            Light4.Join();
            Console.ReadLine();
        }
    }
}
