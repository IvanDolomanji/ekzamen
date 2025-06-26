using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список товаров
            List<Tovar> order = new List<Tovar>();

            while (true)
            {
                // Запрашиваем данные о новом товаре
                Console.WriteLine("\nВведите данные для нового товара (или 'выход' для завершения):");
                Console.WriteLine("Название товара:");
                string name = Console.ReadLine();
                if (name.ToLower() == "выход") break;

                double price;
                do
                {
                    Console.WriteLine("Цена (от 1 до 20):");
                    price = double.Parse(Console.ReadLine());
                    if (price < 1 || price > 20)
                        Console.WriteLine("Цена должна быть от 1 до 20!");
                } while (price < 1 || price > 20);

                int quantity;
                do
                {
                    Console.WriteLine("Количество (от 0 до 10):");
                    quantity = int.Parse(Console.ReadLine());
                    if (quantity < 0 || quantity > 10)
                        Console.WriteLine("Количество должно быть от 0 до 10!");
                } while (quantity < 0 || quantity > 10);

                // Добавляем товар в заказ
                order.Add(new Tovar(name, price, quantity));

                // Выводим информацию о текущем заказе
                Console.WriteLine("\nТекущий заказ:");
                double totalCost = 0;
                foreach (var item in order)
                {
                    double itemCost = item.CalculateItemCost();
                    totalCost += itemCost;
                    Console.WriteLine($"Товар: {item.Name}, Цена: {item.Price:F2} руб., Количество: {item.Quantity}, Стоимость: {itemCost:F2} руб.");
                }
                Console.WriteLine($"Общая стоимость заказа: {totalCost:F2} руб.");

                // Проверяем, хочет ли пользователь продолжить
                Console.WriteLine("\nДобавить еще товар? (да/нет):");
                if (Console.ReadLine().ToLower() != "да") break;
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
