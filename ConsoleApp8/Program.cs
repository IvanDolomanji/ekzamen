using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine());

            // Создаем экземпляр класса User
            User user = new User(login, firstName, lastName, age);

            // Выводим информацию о пользователе
            Console.WriteLine("\nИнформация о пользователе:");
            Console.WriteLine($"Логин: {user.Login}");
            Console.WriteLine($"Имя: {user.FirstName}");
            Console.WriteLine($"Фамилия: {user.LastName}");
            Console.WriteLine($"Возраст: {user.Age}");
            Console.WriteLine($"Дата заполнения анкеты: {user.RegistrationDate:dd.MM.yyyy HH:mm:ss}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
