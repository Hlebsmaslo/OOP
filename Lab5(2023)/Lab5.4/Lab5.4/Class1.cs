using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5._4
{
    public class Class1
    {
        static Semaphore sem = new Semaphore(1, 1);
        static object lk = new object();

        public static void MultiplyMatrices(int[,] MA, int[,] MB, int[,] result, int ind, int end)
        {
            for (int i = ind; i < end; i++)
            {
                for (int j = 0; j < MB.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < MA.GetLength(1); k++)
                    {
                        sum += MA[i, k] * MB[k, j];
                    }

                    lock (lk)
                    {
                        sem.WaitOne();
                        result[i, j] = sum;
                        sem.Release();
                    }
                }
            }
        }
    }
}
