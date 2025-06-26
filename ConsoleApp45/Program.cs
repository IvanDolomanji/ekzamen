using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание треугольника
            Console.WriteLine("Введите данные для треугольника:");
            Console.WriteLine("Сторона a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона c:");
            double c = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a, b, c);

            // Создание круга
            Console.WriteLine("\nВведите данные для круга:");
            Console.WriteLine("Радиус:");
            double radius = double.Parse(Console.ReadLine());
            Disk disk = new Disk(radius);

            // Вывод информации о фигурах
            DisplayShapeInfo(triangle);
            DisplayShapeInfo(disk);

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }

        static void DisplayShapeInfo(IShape shape)
        {
            Console.WriteLine($"\nФигура: {shape.GetType().Name}");
            Console.WriteLine($"Параметры: {shape.GetParameters()}");
            Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
            Console.WriteLine($"Площадь: {shape.Area():F2}");
        }
    }

    // Интерфейс IShape
    interface IShape
    {
        double Perimeter();
        double Area();
        string GetParameters();
    }
}
