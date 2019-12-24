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
            int a, b;

            List<double> numbers = new List<double>() { };


            Console.WriteLine("Введіть розмір");


            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out a);            
                numbers.Add(a);
            }

            double[] arr = numbers.ToArray();
             
            Console.WriteLine("Введіть перевірочне число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("З перевірочним числом співпадають змінні з індексом: "); 
            foreach (int i in arr) 
            {
               if (arr[i] == b)
               { 
                  Console.Write("{0}, ", i+1);
               }
            }         
        }
    }
}
