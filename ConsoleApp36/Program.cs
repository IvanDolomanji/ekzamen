using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список людей разных национальностей
            List<Person> people = new List<Person>();

            // Заполняем данными для 3 человек
            Console.WriteLine("Введите данные для 3 человек:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nЧеловек {i + 1}:");
                Console.WriteLine("Имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Выберите национальность (1 - Русский, 2 - Украинец, 3 - Американец):");
                int nationalityChoice = int.Parse(Console.ReadLine());

                Person person = null;
                switch (nationalityChoice)
                {
                    case 1:
                        person = new Russian(name);
                        break;
                    case 2:
                        person = new Ukrainian(name);
                        break;
                    case 3:
                        person = new American(name);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, установлен русский по умолчанию.");
                        person = new Russian(name);
                        break;
                }

                people.Add(person);
            }

            // Выводим приветствия от каждого человека
            Console.WriteLine("\nПриветствия от людей:");
            foreach (var person in people)
            {
                person.SayHello();
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
