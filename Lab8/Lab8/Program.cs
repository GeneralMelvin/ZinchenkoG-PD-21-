using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            Console.WriteLine("Виберіть машину:");
            int choice;
            do
            {
                Console.WriteLine();
                if (myGarage.myCars.Count == 0)
                {
                    Console.WriteLine("Введіть 0, аби залишити гараж");
                    Console.WriteLine("Введіть 1, аби поставити нову машину в гараж");
                }
                else
                {
                    Console.WriteLine("Введіть 0, аби залишити гараж");
                    Console.WriteLine("Введіть 1, аби поставити нову машину в гараж");
                    Console.WriteLine("Введіть 2, аби побачити усі машини");
                    Console.WriteLine("Введіть 3, аби прибрати машину з гаражу");
                    Console.WriteLine("Введіть 4, аби вибрати машину за критеріями");

                }
                Console.Write("Введіть запит:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Введіть корректний запит: ");
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Гараз зачинено.");
                        return;
                    case 1:
                        Console.WriteLine("Машину поставлено");
                        myGarage.Addition();
                        Console.WriteLine(myGarage.myCars.Count);
                        break;
                    case 2:
                        myGarage.AllCars();
                        break;
                    case 3:
                        myGarage.DeleteCar();
                        break;
                    case 4:
                        Console.WriteLine("За якою характеристикою шукаємо");
                        char characteristic;
                        Console.WriteLine("n - Ім'я");
                        Console.WriteLine("c - Колір");
                        Console.WriteLine("s - Швидкість");
                        Console.WriteLine("y - Рік випуску");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myGarage.CharacteristicSearch(characteristic);
                        break;

                    default:
                        Console.WriteLine("Помилка! Введіть щось з наведеного");
                        break;
                }
            } while (choice != 0);
        }
    }
}
