using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOUR
{
    internal class number : ab
    {
        private readonly int cod;
        public number(int code)
        {
            this.cod = code;
        }

        private Version ver = new Version();
        public void Nu(int a, int b)
        {
            if (cod > 0)
            {
                if (cod % 3 == 0)
                {
                    ver.AllowPro();
                    Console.WriteLine(a + b);
                    ver.AllowPro();
                    Console.WriteLine(a - b);
                    ver.AllowPro();
                    Console.WriteLine(a * b);
                    ver.AllowPro();
                    Console.WriteLine(a / b);
                    ver.AllowPro();
                }
                if (cod % 3 == 1)
                {
                    ver.AllowTrial();
                    Console.WriteLine(a + b);
                    ver.AllowTrial();
                    Console.WriteLine(a - b);
                    ver.AllowTrial();
                    Console.WriteLine(a * b);
                    ver.AllowTrial();
                    Console.WriteLine(a / b);
                    ver.AllowTrial();
                }
                if (cod % 3 == 2)
                {
                    ver.AllowCommon();
                    Console.WriteLine(a + b);
                    ver.AllowCommon();
                    Console.WriteLine(a - b);
                    ver.AllowCommon();
                }
                if (cod > 3)
                {
                    Console.WriteLine("Неправильна цифра");
                }
            }
        }
    }
}
