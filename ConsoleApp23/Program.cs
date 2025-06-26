using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Запрашиваем у пользователя строку
                Console.WriteLine("Введите строку для вывода (или 'выход' для завершения):");
                string stroka = Console.ReadLine();
                if (stroka.ToLower() == "выход")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                // Выводим доступные цвета
                Console.WriteLine("\nВыберите цвет (введите номер):");
                foreach (int i in Enum.GetValues(typeof(Color)))
                {
                    Console.WriteLine($"{i}. {Enum.GetName(typeof(Color), i)}");
                }

                int colorChoice;
                while (!int.TryParse(Console.ReadLine(), out colorChoice) || !Enum.IsDefined(typeof(Color), colorChoice))
                {
                    Console.WriteLine("Неверный номер цвета. Попробуйте снова.");
                }

                // Вызываем метод для вывода строки с выбранным цветом
                Printer.Print(stroka, colorChoice);

                // Проверяем, хочет ли пользователь продолжить
                Console.WriteLine("\nХотите продолжить? (да/нет):");
                if (Console.ReadLine().ToLower() != "да")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
