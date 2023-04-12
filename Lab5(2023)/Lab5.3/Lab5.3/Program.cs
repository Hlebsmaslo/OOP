using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = Class1.GenerateRandomArray(10);
            Console.WriteLine("Невідсортований масив - " + string.Join(", ", ar));
            Console.WriteLine();
            Class1.QuickSort(ar, 0, ar.Length - 1);
            Console.WriteLine("Відсортований масив - " + string.Join(", ", ar));
            Console.ReadLine();
        }
    }
}
