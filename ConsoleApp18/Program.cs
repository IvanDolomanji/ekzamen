using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura figura = new Figura();

            while (true)
            {
                // Запрашиваем у пользователя количество параметров
                Console.WriteLine("\nВыберите фигуру (введите количество сторон):");
                Console.WriteLine("1. Квадрат (1 параметр)");
                Console.WriteLine("2. Прямоугольник (2 параметра)");
                Console.WriteLine("3. Трапеция (3 параметра)");
                Console.WriteLine("4. Выход");
                Console.Write("Ваш выбор (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите длину стороны квадрата:");
                        double side = double.Parse(Console.ReadLine());
                        figura.ShowArea(side);
                        break;
                    case "2":
                        Console.WriteLine("Введите длину первой стороны прямоугольника:");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите длину второй стороны прямоугольника:");
                        double height = double.Parse(Console.ReadLine());
                        figura.ShowArea(width, height);
                        break;
                    case "3":
                        Console.WriteLine("Введите длину первой параллельной стороны трапеции:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите длину второй параллельной стороны трапеции:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите высоту трапеции:");
                        double h = double.Parse(Console.ReadLine());
                        figura.ShowArea(a, b, h);
                        break;
                    case "4":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
