using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static bool Checkout(int a)
        {
            if (a/2 < 6)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введіть число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Checkout(a));
            Console.ReadKey();
        }
    }
}
