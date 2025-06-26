using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем данные для трех треугольников
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nВведите данные для треугольника {i}:");
                Console.WriteLine("Сторона a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Сторона b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Сторона c:");
                double c = double.Parse(Console.ReadLine());

                // Создаем делегат для каждого треугольника
                TriangleAreaDelegate calcArea = TriangleArea.S;
                double area = calcArea(a, b, c);

                Console.WriteLine($"Площадь треугольника {i}: {area:F2} кв. единиц");
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
