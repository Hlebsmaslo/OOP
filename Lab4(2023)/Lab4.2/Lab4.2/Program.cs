using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 eBus = new Class1(1000);
            PrS s1 = new PrS(1);
            PrS s2 = new PrS(2);
            PrS s3 = new PrS(3);
            PrS s4 = new PrS(4);
            eBus.Register("EvEv", 1, new EventHandler(s1.HandleEvent));
            eBus.Register("EvEv", 2, new EventHandler(s2.HandleEvent));
            eBus.Register("OdEv", 3, new EventHandler(s3.HandleEvent));
            eBus.Register("OdEv", 4, new EventHandler(s4.HandleEvent));
            Class2 publ = new Class2(eBus);
            publ.SendEvent();
        }
    }
}
