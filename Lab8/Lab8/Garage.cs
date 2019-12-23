using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Car
    {
        public string Name { get; }
        public string Color { get; }
        public int Speed { get; }
        public int YearOfIssue { get; }

        public Car() { }
        public Car(string name, string color, int speed, int yearOfIssue)
        {
            Name = name;
            Color = color;
            Speed = speed;
            YearOfIssue = yearOfIssue;
        }
    }
    class Garage
    {
        public List<Car> myCars = new List<Car>();

        public void DeleteCar()
        {
            int position;
            Console.Write("Виберіть машину, яку необхідно прибрати: ");
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > myCars.Count)
            {
                Console.Write("Спробуйте інший номер: ");
            }
            myCars.RemoveAt(position - 1);
            Console.WriteLine("Машину під номером {0} було прибрано", position);
        }
        public void Addition()
        {
            string name;
            string color;
            int speed;
            int year;

            Console.Write("\nВведіть назву машини: ");
            name = Console.ReadLine();
            Console.Write("Введіть колір машини: ");
            color = Console.ReadLine();
            Console.Write("Введіть рік виходу машини: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year > 2020 || year < 1850)
            {
                Console.Write("Введіть корректний рік (1850< year < 2020: ");
            }
            Console.Write("Введіть швидкість машини: ");
            while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
            {
                Console.Write("Введіть коректне значення швидкості(Більше 0): ");
            }



            Car newCar = new Car(name, color, speed, year);

            myCars.Add(newCar);
        }

        public void InfoAboutCar(Car car)
        {
            Console.WriteLine("\nName  : {0}\nColor  : {1}\nSpeed  : {2}\nYear  : {3}", car.Name, car.Color, car.Speed, car.YearOfIssue);
        }

        public void AllCars()
        {
            Console.WriteLine("\n Усі машини, що в гаражі:");
            int i = 1;
            foreach (Car c in myCars)
            {
                InfoAboutCar(c);
                i++;
            }
        }

        public void CharacteristicSearch(char characteristic)
        {
            int i = 0;
            switch (characteristic)
            {
                case 'n':
                    Console.Write("За якою назвою ви бажаєте знайти: ");
                    string name = Console.ReadLine();

                    foreach (Car c in myCars)
                    {
                        if (c.Name == name)
                        {
                            InfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Помилка! Такої назви не знайдено");
                    { i = 0; }
                    break;
                case 'c':
                    Console.Write("За яким кольором ви бажаєте шукати: ");
                    string color = Console.ReadLine();
                    foreach (Car c in myCars)
                    {
                        if (c.Color == color)
                        {
                            InfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Помилка! Такого кольору не знайдено");
                    i = 0;
                    break;
                case 's':
                    Console.Write("Яка швидкість шуканої машини: ");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    foreach (Car c in myCars)
                    {
                        if (c.Speed == speed)
                        {
                            InfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Помилка! Машин з такою швидкістю не знайдено");
                    i = 0;
                    break;
                case 'y':
                    Console.Write("Якого року випуску: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    foreach (Car c in myCars)
                    {
                        if (c.YearOfIssue == year)
                        {
                            InfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Помилка! Машин цього року не знайдено");
                    i = 0;
                    break;
                default:
                    Console.WriteLine("Помилка! Даної опції не знайдено");
                    break;
            }

        }


    }
}