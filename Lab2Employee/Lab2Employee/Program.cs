using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Employee
{
    public class Employee
    {
        private readonly string name;
        private readonly string name2;
        public Employee(string name, string name2)
        {
            this.name = name;
            this.name2 = name2;
        }
        public void zar()
        {
            int pos, exp;
            double zar, tax;
            Console.WriteLine("Оберiть позицiю");
            pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оберiть досвiд(у роках)");
            exp = Convert.ToInt32(Console.ReadLine());
            if (pos == 1 && exp <= 3)
            {
                Console.WriteLine("Ви працiник низького рiвня");
                zar = 30000;
                tax = zar * 0.18;
                Console.WriteLine($"Ваша зарплатня: {zar}");
                Console.WriteLine($"Ваш податковий збiр: {tax}");
                System.Threading.Thread.Sleep(4000);
            }
            if (pos == 2 && exp >= 7)
            {
                Console.WriteLine("Ви працiвник високого рiвня ");
                zar = 40000;
                tax = zar * 0.18;
                Console.WriteLine($"Ваша зарплатня: {zar}");
                Console.WriteLine($"Ваш податковий збiр: {tax}");
                System.Threading.Thread.Sleep(4000);
            }
            if (pos == 1 && 7 > exp && 3 < exp)
            {
                Console.WriteLine("Ви працiвник середнього рiвня ");
                zar =35000;
                tax = zar * 0.18;
                Console.WriteLine($"Ваша зарплатня: {zar}");
                Console.WriteLine($"Ваш податковий збiр: {tax}");
                System.Threading.Thread.Sleep(4000);
            }
            if (pos == 2 && 7 > exp && 3 < exp)
            {
                Console.WriteLine("Ви працiвник середнього рiвня ");
                zar = 35500;
                tax = zar * 0.18;
                Console.WriteLine($"Ваша зарплатня: {zar}");
                Console.WriteLine($"Ваш податковий збiр: {tax}");
                System.Threading.Thread.Sleep(4000);
            }
            Console.WriteLine($"Ви {name} {name2}, ваша позицiя - {pos}.");
            System.Threading.Thread.Sleep(4000);
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee("Марiя", "Маєвська");
            employee.zar();
        }
    }
}
