using System;

namespace ConsoleApp12
{
    class Program
    {
        static int Checker(int R)
        {
            if (R <= 0)
            {
                do
                {
                    Console.WriteLine("Опір не може бути від'ємним! Введіть існуючі дані");
                    R = Convert.ToInt32(Console.ReadLine());
                } while (R < 0);
            }
            return R;
        }
        static double ParalelResistCounter(int R1, int R2)
        {
            double R;
            R = (double)(R1 * R2) / (R1 + R2);

            return R;
        }
        static void Main(string[] args)
        {
            int R1, R2;
            double R;
            Console.WriteLine("Введіть опір першого резистора");
            R1 = Convert.ToInt32(Console.ReadLine());
            R1 = Checker(R1);
            Console.WriteLine("Введіть опір другого резистора");
            R2 = Convert.ToInt32(Console.ReadLine());
            R2 = Checker(R2);
            R = ParalelResistCounter(R1, R2);
            Console.WriteLine("Опір двох паралельно поєднаних резисторів дорівнює {0} Ом", R);
            Console.ReadKey();
        }
    }
}
