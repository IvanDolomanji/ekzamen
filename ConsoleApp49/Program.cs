using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список точек
            List<Point> points = new List<Point>();

            while (true)
            {
                // Запрашиваем координаты новой точки
                Console.WriteLine("\nВведите координаты точки (или 'Q' для завершения):");
                Console.WriteLine("x (или 'Q' для выхода):");
                string xInput = Console.ReadLine();
                if (xInput.ToUpper() == "Q") break;

                Console.WriteLine("y:");
                string yInput = Console.ReadLine();
                if (yInput.ToUpper() == "Q") break;

                double x = double.Parse(xInput);
                double y = double.Parse(yInput);
                points.Add(new Point(x, y));

                // Выводим координаты текущей точки
                Console.WriteLine("Координаты точки:");
                points[points.Count - 1].Display();

                // Показываем статистику
                Point.ShowStatistics();

                // Проверяем, хочет ли пользователь продолжить
                Console.WriteLine("Добавить еще точку? (да/нет, или 'Q' для завершения):");
                string continueInput = Console.ReadLine();
                if (continueInput.ToUpper() == "Q" || continueInput.ToLower() != "да") break;
            }

            // Выводим итоговую статистику
            Console.WriteLine("\nИтоговая статистика по всем точкам:");
            Point.ShowStatistics();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
