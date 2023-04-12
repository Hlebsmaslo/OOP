using System;
using System.Threading;

namespace Lab5._3
{
    public class Class1
    {
        private static readonly object lk = new object();
        public static void QuickSort(int[] ar, int l, int r)
        {
            if (l < r)
            {
                int a = Partition(ar, l, r);
                Thread lt = new Thread(() => QuickSort(ar, l, a - 1));
                Thread rt = new Thread(() => QuickSort(ar, a + 1, r));
                lt.Start();
                rt.Start();
                lt.Join();
                rt.Join();
            }
        }
        public static int Partition(int[] ar, int l, int r)
        {
            int a = ar[r];
            int i = l - 1;
            for (int j = l; j < r; j++)
            {
                if (ar[j] < a)
                {
                    i++;
                    Swap(ar, i, j);
                }
            }
            Swap(ar, i + 1, r);
            return i + 1;
        }
        public static void Swap(int[] ar, int i, int j)
        {
            lock (lk)
            {
                int t = ar[i];
                ar[i] = ar[j];
                ar[j] = t;
            }
        }
        public static int[] GenerateRandomArray(int s)
        {
            Random rand = new Random();
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = rand.Next(1, 101);
            }
            return arr;
        }

    }
}
