using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список устройств, реализующих ISwitchable
            List<ISwitchable> devices = new List<ISwitchable>
        {
            new TVSet(),
            new PersonalComputer()
        };

            while (true)
            {
                // Запрашиваем у пользователя действие
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Включить все устройства");
                Console.WriteLine("2. Выключить все устройства");
                Console.WriteLine("3. Выход");
                Console.Write("Ваш выбор (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach (var device in devices)
                        {
                            device.SwitchOn();
                        }
                        break;
                    case "2":
                        foreach (var device in devices)
                        {
                            device.SwitchOff();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }

    // Интерфейс для переключения
    interface ISwitchable
    {
        void SwitchOn();
        void SwitchOff();
    }
}
