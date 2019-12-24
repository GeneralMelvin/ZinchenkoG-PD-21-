using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void ReverseNumber()
        {
            int n = 0, i = 0, b;
            Console.WriteLine("Введіть елемент");
            int.TryParse(Console.ReadLine(), out int a);
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
        }
        static void ReverseString()
        {
            string s;
            Console.WriteLine("Введіть строку:");
            s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine("Перевернута строка:");
            Console.WriteLine(s);
            Console.WriteLine();
        }

        static void ReverseFrac()
        {
            int i, n1 = 0, b; 
            Console.WriteLine("Введите дробове число з рівною кількістю знаків до і після коми");
            double.TryParse(Console.ReadLine(), out double c);
            string Frac = c.ToString();
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
            Console.WriteLine("Ваша строка : {0},{1}", Frac, Frac2);
            Console.WriteLine();
        }

        static void ReverseStringFrac()
        {
            int i, n1 = 0, b;
            Console.WriteLine("Четверте завдання:");
            Console.WriteLine("Введите строку с , :");
            string FracS = Console.ReadLine();
            i = 0;
            char[] FracSReverse = FracS.ToCharArray();
            n1 = FracSReverse.GetLength(n1);
            char[] FracSReverseFitst = new char[n1];
            char[] FracSReverseSecond = new char[n1];
            do
            {
                FracSReverseFitst[i] = FracSReverse[i];
                i++;

            } while (FracSReverse[i] != ',' && FracSReverse[i] != '\0');
            b = 0;
            for (i = i + 1; i < n1; i++)
            {
                FracSReverseSecond[b] = FracSReverse[i];
                b++;
            }
            Array.Reverse(FracSReverseFitst);
            Array.Reverse(FracSReverseSecond);
            string FracS2;
            FracS = new string(FracSReverseFitst);
            FracS2 = new string(FracSReverseSecond);
            Console.WriteLine("Ваша строка : {0},{1}", FracS, FracS2);
            Console.WriteLine();
        }
        
        static void ArrayReverser()
        {
            Console.WriteLine("Введіть розмір массиву");
            int.TryParse(Console.ReadLine(), out int n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i+1);
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            int[] ArrRev = new int[n];
            int n1 = n - 1;
            for (int i = 0; i < n; i++)
            {
                ArrRev[i] = arr[n1];
                n1 -= 1;
            }
            Console.Write("Ваш розвернутий массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ", ArrRev[i]);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int flag;
            do
            {
                Console.WriteLine("Виберніть завдання для виконання:");
                Console.WriteLine("1. Перетворення числа на зворотнє");
                Console.WriteLine("2. Перетворення строки на зворотню");
                Console.WriteLine("3. Перетворення цілої і дробової частини числового дробу на зворотні");
                Console.WriteLine("4. Перетворення цілої і дробової частини символьного дробу на зворотні");
                Console.WriteLine("5. перетворення массиву на зворотній");
                Console.WriteLine("0. Завершити роботу");
                int.TryParse(Console.ReadLine(), out flag);
                switch (flag)
                {
                    case 1:
                        ReverseNumber();
                        break;
                    case 2:
                        ReverseString();
                        break;
                    case 3:
                        ReverseFrac();
                        break;
                    case 4:
                        ReverseStringFrac();
                        break;
                    case 5:
                        ArrayReverser();
                        break;
                    case 0:
                        break;
                }
            } while (flag != 0);
        }
    }
}
