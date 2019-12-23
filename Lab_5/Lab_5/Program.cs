using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static int Checkout(int a)
        {
            if (a <= 1)
            {
                do
                {
                    Console.WriteLine("Помилка! Розмір має бути більшим за 1. Введіть підходящі дані");
                    a = Convert.ToInt32(Console.ReadLine());
                } while (a <= 1);
            }
            return a;
        }
        static void Fill(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("[{0}][{1}] =", i + 1, j + 1);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void Exchange(int[,] a, int m, int n)
        {
            int max, min;
            for (int i = 0; i < m; i++)
            {
                max = a[i, i];
                min = a[i, i];
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
                for (int k = 0; k < n; k++)
                {
                    if (a[i,k] == min)
                    {
                        a[i, k] = max;
                        continue;
                    }
                    if (a[i, k] == max)
                    {
                        a[i, k] = min;
                        continue;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Введіть розмір матриці.");
            Console.WriteLine("m=");
            m = Convert.ToInt32(Console.ReadLine());
            Checkout(m);
            Console.WriteLine("Введіть розмір матриці.");
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());
            Checkout(n);
            int[,] Arr = new int[m, n];
            Fill(Arr, m, n);
            Exchange(Arr, m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
