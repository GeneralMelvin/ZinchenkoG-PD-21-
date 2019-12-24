using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            List<double> numbers = new List<double>() { };


            Console.WriteLine("Введіть розмір");
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i+1);
                double.TryParse(Console.ReadLine(), out a);
                numbers.Add(a);
            }

            double[] arr = numbers.ToArray();

            Console.WriteLine("Введіть перевірочне число");

            double.TryParse(Console.ReadLine(), out double b);

            Console.Write("З перевірочним числом співпадають змінні з індексом: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == b)
                {
                    Console.Write("{0}, ", i + 1);
                }
            }
        }
    }
}
