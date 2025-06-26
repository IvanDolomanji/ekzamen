using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список заказов
            List<Zakaz> orders = new List<Zakaz>();

            while (true)
            {
                // Запрашиваем данные для нового заказа
                Console.WriteLine("\nВведите данные для заказа (или 'Q' для завершения):");
                Console.WriteLine("Фамилия (или 'Q' для выхода):");
                string fam = Console.ReadLine();
                if (fam.ToUpper() == "Q") break;

                int size;
                do
                {
                    Console.WriteLine("Количество мест в номере (положительное число):");
                    if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                        Console.WriteLine("Ошибка: введите положительное число!");
                } while (size <= 0);

                Console.WriteLine("Комфортность (например, 'стандарт', 'люкс'):");
                string comfort = Console.ReadLine();

                // Создаем заказ с использованием конструктора
                Zakaz order = new Zakaz(fam, size, comfort);
                orders.Add(order);

                // Выводим информацию о текущем заказе
                Console.WriteLine("\nТекущий заказ:");
                order.Show();

                // Проверяем, хочет ли пользователь продолжить
                Console.WriteLine("Добавить еще заказ? (да/нет, или 'Q' для завершения):");
                string continueInput = Console.ReadLine();
                if (continueInput.ToUpper() == "Q" || continueInput.ToLower() != "да") break;
            }

            // Выводим все заказы
            Console.WriteLine("\nСписок всех заказов:");
            foreach (var order in orders)
            {
                order.Show();
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
