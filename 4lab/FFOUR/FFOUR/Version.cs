using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOUR
{
    internal class Version
    {
        public void AllowTrial()
        {
            Console.WriteLine("Пробна версiя");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версiя");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версiя");
        }
    }
}
