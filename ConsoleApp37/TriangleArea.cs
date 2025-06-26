using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    static class TriangleArea
    {
        public static double S(double a, double b, double c)
        {
            // Проверка существования треугольника (теорема о неравенстве треугольника)
            if (a + b <= c || b + c <= a || a + c <= b)
                throw new ArgumentException("Треугольник с такими сторонами не существует!");

            // Формула Герона
            double p = (a + b + c) / 2; // Полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    // Делегат, соответствующий методу S
    delegate double TriangleAreaDelegate(double a, double b, double c);
}
