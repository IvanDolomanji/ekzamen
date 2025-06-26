using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные о сотруднике
            Console.WriteLine("Введите фамилию сотрудника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите имя сотрудника:");
            string firstName = Console.ReadLine();

            // Запрашиваем должность сотрудника
            Console.WriteLine("Введите должность сотрудника (1 - Junior, 2 - Middle, 3 - Senior):");
            string positionInput = Console.ReadLine();

            // Запрашиваем стаж сотрудника
            Console.WriteLine("Введите стаж сотрудника (в годах):");
            double experience = double.Parse(Console.ReadLine());

            // Создаем экземпляр класса Employee
            Employee employee = new Employee(lastName, firstName);

            // Вычисляем оклад и налоговый сбор
            (double salary, double tax) = employee.CalculateSalaryAndTax(positionInput, experience);

            // Выводим информацию о сотруднике
            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine($"Фамилия: {employee.LastName}");
            Console.WriteLine($"Имя: {employee.FirstName}");
            Console.WriteLine($"Должность: {employee.GetPositionName(positionInput)}");
            Console.WriteLine($"Оклад: {salary:F2} BYN");
            Console.WriteLine($"Налоговый сбор (13%): {tax:F2} BYN");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
