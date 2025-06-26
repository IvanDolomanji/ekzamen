using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour tour = new Tour();

            while (true)
            {
                // Запрашиваем у пользователя выбор варианта тура
                Console.WriteLine("\nВыберите вариант тура:");
                Console.WriteLine("1. Минское море (без параметров, бесплатно)");
                Console.WriteLine("2. Тур в страну (1 день, 50 руб)");
                Console.WriteLine("3. Тур в страну на заданное количество дней");
                Console.WriteLine("4. Выход");
                Console.Write("Ваш выбор (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        double cost1 = tour.TourCalc();
                        Console.WriteLine($"Стоимость тура: {cost1:F2} руб.");
                        break;
                    case "2":
                        Console.WriteLine("Введите название страны:");
                        string country = Console.ReadLine();
                        double cost2 = tour.TourCalc(country);
                        Console.WriteLine($"Стоимость тура в {country} (1 день): {cost2:F2} руб.");
                        break;
                    case "3":
                        Console.WriteLine("Введите название страны:");
                        string countryMulti = Console.ReadLine();
                        Console.WriteLine("Введите количество дней:");
                        int days = int.Parse(Console.ReadLine());
                        double cost3 = tour.TourCalc(countryMulti, days);
                        Console.WriteLine($"Стоимость тура в {countryMulti} ({days} дней): {cost3:F2} руб.");
                        break;
                    case "4":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
