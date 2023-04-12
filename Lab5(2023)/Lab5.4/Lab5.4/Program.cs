using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] MA = { { 1, 2 }, { 5, 6 } };
            int[,] MB = { { 3, 4 }, { 7, 8 } };
            int[,] result = new int[MA.GetLength(0), MB.GetLength(1)];
            Thread a1 = new Thread(() => Class1.MultiplyMatrices(MA, MB, result, 0, MA.GetLength(0) / 2));
            Thread a2 = new Thread(() => Class1.MultiplyMatrices(MA, MB, result, MA.GetLength(0) / 2, MA.GetLength(0)));
            a1.Start();
            a2.Start();
            a1.Join();
            a2.Join();

            Console.WriteLine("Матриця:");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
