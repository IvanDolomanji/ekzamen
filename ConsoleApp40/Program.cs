using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем данные для трех диапазонов
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nВведите данные для диапазона {i}:");
                Console.WriteLine("Начальное число m:");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Конечное число n:");
                int n = int.Parse(Console.ReadLine());

                // Проверяем, чтобы m не было больше n
                if (m > n)
                {
                    Console.WriteLine("Ошибка: m не может быть больше n!");
                    i--; // Повторяем ввод для этого диапазона
                    continue;
                }

                // Создаем делегат для каждого диапазона
                AverageDelegate calcAverage = AverageCalc.Average;
                double avg = calcAverage(m, n);

                Console.WriteLine($"Среднее арифметическое чисел от {m} до {n}: {avg:F2}");
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
