using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2023_
{
    public class Program
    {
        static void Main(string[] args)
        {
            var st = File.ReadAllLines("students.csv")
                .Skip(1)
                .Select(line => {
                    var A = line.Split(',');
                    return new StudentsList
                    {
                        Name = A[0],
                        Grade = int.Parse(A[1])
                    };
                })
                .ToList();
            var a = st.Where(st1 => st1.Grade >= 70);
            foreach (var st1 in a)
            {
                Console.WriteLine($"{st1.Name} - {st1.Grade}");
            }

        }
    }
}