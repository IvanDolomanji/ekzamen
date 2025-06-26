using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Запрашиваем исходное число
                Console.WriteLine("\nВведите исходное число (или 'выход' для завершения):");
                string input = Console.ReadLine();
                if (input.ToLower() == "выход") break;

                if (!double.TryParse(input, out double number))
                {
                    Console.WriteLine("Ошибка: введите корректное число!");
                    continue;
                }

                // Запрашиваем параметры для преобразований
                Console.WriteLine("Введите величину для прибавления (Add):");
                double addValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите коэффициент для умножения (Multiply):");
                double multiplyFactor = double.Parse(Console.ReadLine());

                // Создаем экземпляры преобразований
                ICalculation add = new Add(addValue);
                ICalculation multiply = new Multiply(multiplyFactor);

                // Выполняем последовательное преобразование
                double result = Calculate(number, add, multiply);
                Console.WriteLine($"Результат: {number} -> прибавление {addValue} -> умножение на {multiplyFactor} = {result:F2}");

                // Проверяем, хочет ли пользователь продолжить
                Console.WriteLine("\nПродолжить? (да/нет):");
                if (Console.ReadLine().ToLower() != "да") break;
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }

        static double Calculate(double number, ICalculation first, ICalculation second)
        {
            double result = first.Perform(number);
            return second.Perform(result);
        }
    }

    // Интерфейс ICalculation
    interface ICalculation
    {
        double Perform(double number);
    }
}
