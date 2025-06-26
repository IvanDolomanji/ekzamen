using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем дату для создания объекта
            Console.WriteLine("Введите дату:");
            Console.WriteLine("Год (например, 2025):");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц (1-12):");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("День (1-31):");
            int day = int.Parse(Console.ReadLine());

            // Создаем объект с введенной датой
            DateClass date = new DateClass(year, month, day);

            // Выводим исходную дату
            Console.WriteLine("\nИсходная дата:");
            Console.WriteLine(date.Data.ToShortDateString());

            // Вычисляем и выводим предыдущий день
            DateTime previousDay = date.GetPreviousDay();
            Console.WriteLine("Предыдущий день:");
            Console.WriteLine(previousDay.ToShortDateString());

            // Вычисляем и выводим следующий день
            DateTime nextDay = date.GetNextDay();
            Console.WriteLine("Следующий день:");
            Console.WriteLine(nextDay.ToShortDateString());

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
