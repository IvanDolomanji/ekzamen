using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Point
    {
        private double x;
        private double y;

        // Статические поля для подсчета точек в четвертях
        public static int Q1Count = 0; // 1-я четверть (x > 0, y > 0)
        public static int Q2Count = 0; // 2-я четверть (x < 0, y > 0)
        public static int Q3Count = 0; // 3-я четверть (x < 0, y < 0)
        public static int Q4Count = 0; // 4-я четверть (x > 0, y < 0)
        public static int TotalCount = 0; // Общее количество точек

        // Конструктор с параметрами
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;

            // Определяем четверть и увеличиваем соответствующий счетчик
            TotalCount++;
            if (x > 0 && y > 0) Q1Count++;
            else if (x < 0 && y > 0) Q2Count++;
            else if (x < 0 && y < 0) Q3Count++;
            else if (x > 0 && y < 0) Q4Count++;
        }

        // Метод для вывода координат
        public void Display()
        {
            Console.WriteLine($"({x}, {y})");
        }

        // Статический метод для вывода статистики
        public static void ShowStatistics()
        {
            Console.WriteLine($"Точек в 1-й четверти: {Q1Count}");
            Console.WriteLine($"Точек во 2-й четверти: {Q2Count}");
            Console.WriteLine($"Точек в 3-й четверти: {Q3Count}");
            Console.WriteLine($"Точек в 4-й четверти: {Q4Count}");
            Console.WriteLine($"Общее количество точек: {TotalCount}");
            Console.WriteLine();
        }
    }
}
