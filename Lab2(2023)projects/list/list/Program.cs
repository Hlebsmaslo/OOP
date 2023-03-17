using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pr = get();
            var A = pr.GroupBy(pr1 => pr1.Category);
            foreach (var a in A)
            {
                Console.WriteLine($"{a.Key} -");
                foreach (var pr1 in a)
                {
                    Console.WriteLine($" - {pr1.Name} - {pr1.Price}");
                }
            }
        }
        static List<Product> get()
        {
            return new List<Product> {
            new Product { Name = "Milk", Category = "Food", Price = 37.99 },
            new Product { Name = "Bread", Category = "Food", Price = 27.99 },
            new Product { Name = "Chocolate", Category = "Food", Price = 33.99 },
            new Product { Name = "Washing powder", Category = "Household chemicals", Price = 30.99 },
            new Product { Name = "Dishwashing liquid", Category = "Household chemicals", Price = 87.99 }};
        }
    }
}
