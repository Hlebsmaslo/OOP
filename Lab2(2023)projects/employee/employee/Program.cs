using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var em = get();
            var a = em.OrderBy(em1 => em1.Salary);
            foreach (var em1 in a)
            {
                Console.WriteLine($"{em1.Name} ; {em1.Salary}");
            }
        }
        static List<Employee> get()
        {
            return new List<Employee> {
            new Employee { Name = "Employee1", Salary = 10000 },
            new Employee { Name = "Employee2", Salary = 20000 },
            new Employee { Name = "Employee3", Salary = 30000 },
            new Employee { Name = "Employee4", Salary = 40000 },
            new Employee { Name = "Employee5", Salary = 50000 }};
             }
    }
}
