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
            int a;
            int[] count = new int[2];

            List<double> numbers = new List<double>() { };


            Console.WriteLine("Введіть розмір");


            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                do
                {

                    int.TryParse(Console.ReadLine(), out a);

                } while (a != 0 && a != 1);

                numbers.Add(a);
                count[a]++;
            }

            double[] arr = numbers.ToArray();

            foreach (int i in arr) 
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\nКількість 0 та 1");

            foreach (int i in count) 
            {
                Console.Write("{0} ", i);
            }

        }
    }
}
