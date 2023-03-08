using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;


namespace A
{
    internal class Program
    {
        public delegate int a();

        public static int b(a[] array)
        {
            int x = 1;
            foreach (a del in array)
            {
                x = x * del();
            }
            x /= array.Length;
            Console.WriteLine(x);
            return x;
        }
        public int c()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 5);
            Console.WriteLine(x);
            return x;
        }
        static void Main(string[] args)
        {
            Program task = new Program();
            a del = task.c;
            a del2 = task.c;
            a[] dels = new a[2];
            dels[0] = del;
            dels[1] = del2;
            b(dels);
        }
    }
}
