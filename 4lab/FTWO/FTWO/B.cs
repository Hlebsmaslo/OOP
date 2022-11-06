using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTWO
{
    internal abstract class B
    {
        private string n;
        public string Name
        {
            get { return n; }
            set { n = value; }
        }
        public virtual void MyName(string name)
        {
            n = name;
            Console.WriteLine(name);
        }
        public virtual int Sum(int a, int b)
        {
            return a + b;
        }
        public abstract double Math(int a, int b);
    }
}
