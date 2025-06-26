using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список товаров
            List<Tovar> items = new List<Tovar>();

            while (true)
            {
                // Запрашиваем тип товара
                Console.WriteLine("\nВыберите тип товара для добавления:");
                Console.WriteLine("1. Обувь");
                Console.WriteLine("2. Одежда");
                Console.WriteLine("3. Посуда");
                Console.WriteLine("4. Выход");
                Console.Write("Ваш выбор (1-4): ");
                string choice = Console.ReadLine();

                if (choice == "4") break;

                Console.WriteLine("Введите название товара:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара:");
                double price = double.Parse(Console.ReadLine());

                Tovar item = null;
                switch (choice)
                {
                    case "1": // Обувь
                        Console.WriteLine("Введите количество пар:");
                        int obuvQuantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер (в EU):");
                        int obuvSize = int.Parse(Console.ReadLine());
                        item = new Obuv(name, price, obuvQuantity, obuvSize);
                        break;
                    case "2": // Одежда
                        Console.WriteLine("Введите количество единиц:");
                        int odejdaQuantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите цвет:");
                        string odejdaColor = Console.ReadLine();
                        item = new Odejda(name, price, odejdaQuantity, odejdaColor);
                        break;
                    case "3": // Посуда
                        Console.WriteLine("Введите массу (в кг):");
                        double posudaWeight = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите цвет:");
                        string posudaColor = Console.ReadLine();
                        item = new Posuda(name, price, posudaWeight, posudaColor);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        continue;
                }

                items.Add(item);
                Console.WriteLine("\nТекущий список товаров:");
                foreach (var t in items)
                {
                    t.Print();
                }

                Console.WriteLine("\nДобавить еще товар? (да/нет):");
                if (Console.ReadLine().ToLower() != "да") break;
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
