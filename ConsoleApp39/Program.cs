using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список компьютеров
            List<Computer> computers = new List<Computer>();

            while (true)
            {
                // Запрашиваем данные о новом компьютере
                Console.WriteLine("\nВведите данные для нового компьютера (или 'выход' для завершения):");
                Console.WriteLine("Модель:");
                string model = Console.ReadLine();
                if (model.ToLower() == "выход") break;

                int ram;
                do
                {
                    Console.WriteLine("Объем ОЗУ (от 2 до 32 Гб):");
                    ram = int.Parse(Console.ReadLine());
                    if (ram < 2 || ram > 32)
                        Console.WriteLine("Объем ОЗУ должен быть от 2 до 32 Гб!");
                } while (ram < 2 || ram > 32);

                int hdd;
                do
                {
                    Console.WriteLine("Объем жесткого диска (от 200 до 2000 Гб):");
                    hdd = int.Parse(Console.ReadLine());
                    if (hdd < 200 || hdd > 2000)
                        Console.WriteLine("Объем жесткого диска должен быть от 200 до 2000 Гб!");
                } while (hdd < 200 || hdd > 2000);

                // Добавляем компьютер в список (стоимость вычисляется внутри конструктора)
                computers.Add(new Computer(model, ram, hdd));

                // Выводим информацию о текущем списке
                Console.WriteLine("\nТекущий список компьютеров:");
                double totalCost = 0;
                foreach (var computer in computers)
                {
                    double cost = computer.CalculateCost();
                    totalCost += cost;
                    computer.Display();
                    Console.WriteLine($"Стоимость: {cost:F2} руб.");
                }
                Console.WriteLine($"Общая стоимость всех моделей: {totalCost:F2} руб.");

                // Проверяем, хочет ли пользователь продолжить
                Console.WriteLine("\nДобавить еще компьютер? (да/нет):");
                if (Console.ReadLine().ToLower() != "да") break;
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
