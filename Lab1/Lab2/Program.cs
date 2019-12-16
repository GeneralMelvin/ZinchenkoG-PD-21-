using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Checkout(int nk, int nn)
        {
            if (nn >= nk)
            {
                Console.WriteLine("Помилка! nk не має бути меншим за nn");
                return 1;
            } else if (0 > nn)
            {
                Console.WriteLine("Помилка! nn не має бути меншим за 0");
                return 1;
            }
            return 0;
        }
        static void Sum(int nn, int nk)
        {
            double sum = 0;
            for(int i = 0; i <= nk; i++)
            {
                sum = sum + (Math.Pow(nn, 2) - 1) / (Math.Pow(-1, nn + 1) * Math.Pow(nn, 2) + 7);
            }
            Console.WriteLine("Сума ряду дорівнює {0}", sum);
        }
        static void Main(string[] args)
        {
            int nk, nn, c;
            do
            {
                Console.WriteLine("Введіть nk");
                nk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть nn. ВАЖЛИВО: nn має бути меньшим за nk, але більшим за 0");
                nn = Convert.ToInt32(Console.ReadLine());
                c = Checkout(nk, nn);
            } while (c == 1);
            Sum(nn, nk);
            Console.ReadKey();
        }
    }
}
