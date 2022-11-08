using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> li = new MyList<int>();
            li.Add(1234);
            foreach (int a in li)
                Console.WriteLine(a);
            int[] array = Class1.GetArray(li);
            foreach (int a in array)
                Console.WriteLine(a);
        }
    }
}
