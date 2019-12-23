using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0, i = 0, a = 0, n1 = 0, b = 0;
            string aa;


            Console.WriteLine("Перше завдання:");
            Console.WriteLine("Введіть елемент");
            aa = Console.ReadLine();
            a = Convert.ToInt32(aa);
            b = a;
            do
            {
                b = b / 10;
                n++;
            } while (b > 0);
            int[] Arr = new int[n];
            do
            {
                Arr[i] = a % 10;
                a = a / 10;
                i++;
            } while (a > 0);
            for (i = 0; i < n; i++)
            {
                Console.Write(Arr[i] + " ");

            }
            Console.WriteLine();

            Console.WriteLine("Друге завдання:");
            string s;
            Console.WriteLine("Введіть строку:");
            s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine("Перевернута строка:");
            Console.WriteLine(s);

            Console.WriteLine("Третє завдання:");
            Console.WriteLine("Введите строку с , :");
            string Frac = Console.ReadLine();
            i = 0;
            char[] FracReverse = Frac.ToCharArray();
            n1 = FracReverse.GetLength(n1);
            char[] FracReverseFitst = new char[n1];
            char[] FracReverseSecond = new char[n1];
            do
            {
                FracReverseFitst[i] = FracReverse[i];
                i++;

            } while (FracReverse[i] != ',' && FracReverse[i] != '\0');
            b = 0;
            for (i = i + 1; i < n1; i++)
            {
                FracReverseSecond[b] = FracReverse[i];
                b++;
            }
            Array.Reverse(FracReverseFitst);
            Array.Reverse(FracReverseSecond);
            string Frac2;
            Frac = new string(FracReverseFitst);
            Frac2 = new string(FracReverseSecond);
            Frac2.TrimStart();
            Console.WriteLine("Ваша строка :");
            Console.WriteLine();
        }
    }
}
