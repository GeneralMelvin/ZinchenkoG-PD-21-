using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int Checkout(int i)
        {
            if (i <= 1)
            {
                Console.WriteLine("Розмір введено невірно. Розмір має бути більшим за 1");
                return 1;
            }
            return 0;
        }
        static void Fill(int []a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("[{0}] =", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Even(int[] a, int n)
        {
            Console.WriteLine("Парні числа: ");
            for (int i = 0; i < n; i++)
            {
                int b = a[i] % 2;
                if (b == 0)
                {
                    Console.WriteLine("{0} ", a[i]);
                }
            }
        }
        static void Odd(int[] a, int n)
        {
            Console.WriteLine("Непарні числа: ");
            for (int i = 0; i < n; i++)
            {
                int b = a[i] % 2;
                if (b != 0)
                {
                    Console.WriteLine("{0} ", a[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int flag, N;
            do
            {
                Console.WriteLine("Введіть розмір массиву");
                N = Convert.ToInt32(Console.ReadLine());
                flag = Checkout(N);
            } while (flag == 1);
            int[] a = new int [N];
            Fill(a, N);
            Even(a, N);
            Odd(a, N);
        }
    }
}
