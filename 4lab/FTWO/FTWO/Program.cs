using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTWO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();
            A a = new A(class1, class2, class3);
            double y = class1.Math(1, 3);
            Console.WriteLine(y);
        }
    }
}
