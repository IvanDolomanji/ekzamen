using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            while (true)
            {
                // Запрашиваем у пользователя действие
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Проиграть");
                Console.WriteLine("2. Пауза");
                Console.WriteLine("3. Остановить");
                Console.WriteLine("4. Начать запись");
                Console.WriteLine("5. Пауза записи");
                Console.WriteLine("6. Остановить запись");
                Console.WriteLine("7. Выход");
                Console.Write("Ваш выбор (1-7): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.Play();
                        break;
                    case "2":
                        player.Pause();
                        break;
                    case "3":
                        player.Stop();
                        break;
                    case "4":
                        player.Record();
                        break;
                    case "5":
                        player.Pause();
                        break;
                    case "6":
                        player.Stop();
                        break;
                    case "7":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }

    // Интерфейс для проигрывания
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    // Интерфейс для записи
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
