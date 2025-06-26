using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив объектов Product
            Console.WriteLine("Введите количество товаров:");
            int n = int.Parse(Console.ReadLine());
            Product[] products = new Product[n];

            // Заполняем массив данными
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВведите данные для товара {i + 1}:");
                Console.WriteLine("Наименование:");
                string name = Console.ReadLine();
                Console.WriteLine("Производитель:");
                string manufacturer = Console.ReadLine();
                Console.WriteLine("Цена:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Срок хранения (в днях):");
                int shelfLife = int.Parse(Console.ReadLine());
                Console.WriteLine("Количество:");
                int quantity = int.Parse(Console.ReadLine());

                products[i] = new Product(name, manufacturer, price, shelfLife, quantity);
            }

            // Выводим исходный список товаров
            Console.WriteLine("\nИсходный список товаров:");
            foreach (var product in products)
            {
                product.Display();
            }

            // а) Список товаров для заданного наименования
            Console.WriteLine("\nВведите наименование для поиска:");
            string searchName = Console.ReadLine();
            var nameMatch = Array.FindAll(products, p => p.Name.ToLower() == searchName.ToLower());
            Console.WriteLine($"\nТовары с наименованием '{searchName}':");
            if (nameMatch.Length > 0)
            {
                foreach (var product in nameMatch)
                {
                    product.Display();
                }
            }
            else
            {
                Console.WriteLine("Товары не найдены.");
            }

            // б) Список товаров для заданного наименования, цена которых не превышает указанной
            Console.WriteLine("\nВведите наименование для поиска:");
            string priceName = Console.ReadLine();
            Console.WriteLine("Введите максимальную цену:");
            double maxPrice = double.Parse(Console.ReadLine());
            var priceMatch = Array.FindAll(products, p => p.Name.ToLower() == priceName.ToLower() && p.Price <= maxPrice);
            Console.WriteLine($"\nТовары с наименованием '{priceName}' и ценой до {maxPrice:F2} руб.:");
            if (priceMatch.Length > 0)
            {
                foreach (var product in priceMatch)
                {
                    product.Display();
                }
            }
            else
            {
                Console.WriteLine("Товары не найдены.");
            }

            // в) Список товаров, срок хранения которых больше заданного
            Console.WriteLine("\nВведите минимальный срок хранения (в днях):");
            int minShelfLife = int.Parse(Console.ReadLine());
            var shelfLifeMatch = Array.FindAll(products, p => p.ShelfLife > minShelfLife);
            Console.WriteLine($"\nТовары со сроком хранения больше {minShelfLife} дней:");
            if (shelfLifeMatch.Length > 0)
            {
                foreach (var product in shelfLifeMatch)
                {
                    product.Display();
                }
            }
            else
            {
                Console.WriteLine("Товары не найдены.");
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
