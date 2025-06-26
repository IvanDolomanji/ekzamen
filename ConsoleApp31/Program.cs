using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            while (true)
            {
                try
                {
                    // Запрашиваем у пользователя значения
                    Console.WriteLine("\nВведите первое число:");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    double b = double.Parse(Console.ReadLine());

                    // Выбираем операцию
                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1. Сложение (Add)");
                    Console.WriteLine("2. Вычитание (Sub)");
                    Console.WriteLine("3. Умножение (Mul)");
                    Console.WriteLine("4. Деление (Div)");
                    Console.WriteLine("5. Выход");
                    Console.Write("Ваш выбор (1-5): ");
                    string choice = Console.ReadLine();

                    double result = 0;
                    switch (choice)
                    {
                        case "1":
                            result = calc.Add(a, b);
                            Console.WriteLine($"Результат сложения: {result:F2}");
                            break;
                        case "2":
                            result = calc.Sub(a, b);
                            Console.WriteLine($"Результат вычитания: {result:F2}");
                            break;
                        case "3":
                            result = calc.Mul(a, b);
                            Console.WriteLine($"Результат умножения: {result:F2}");
                            break;
                        case "4":
                            result = calc.Div(a, b);
                            Console.WriteLine($"Результат деления: {result:F2}");
                            break;
                        case "5":
                            Console.WriteLine("Программа завершена.");
                            return;
                        default:
                            Console.WriteLine("Неверный выбор операции.");
                            continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите корректное число!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }

                Console.WriteLine("\nПродолжить? (да/нет):");
                if (Console.ReadLine().ToLower() != "да") break;
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
