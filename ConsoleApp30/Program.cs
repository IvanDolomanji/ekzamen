using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
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
                Console.WriteLine("1. Книга");
                Console.WriteLine("2. Ручка");
                Console.WriteLine("3. Конфеты");
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
                    case "1": // Книга
                        Console.WriteLine("Введите количество книг:");
                        int bookQuantity = int.Parse(Console.ReadLine());
                        item = new Book(name, price, bookQuantity);
                        break;
                    case "2": // Ручка
                        Console.WriteLine("Введите количество ручек:");
                        int penQuantity = int.Parse(Console.ReadLine());
                        item = new Pen(name, price, penQuantity);
                        break;
                    case "3": // Конфеты
                        Console.WriteLine("Введите вес конфет (в кг):");
                        double candyWeight = double.Parse(Console.ReadLine());
                        item = new Candy(name, price, candyWeight);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        continue;
                }

                items.Add(item);
                Console.WriteLine("\nТекущий список товаров:");
                foreach (var t in items)
                {
                    t.Calc();
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
