using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Figura
    {
        public void ShowArea(double side)
        {
            double area = side * side;
            Console.WriteLine($"Фигура: Квадрат");
            Console.WriteLine($"Площадь: {area:F2} единиц²");
        }

        public void ShowArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"Фигура: Прямоугольник");
            Console.WriteLine($"Площадь: {area:F2} единиц²");
        }

        public void ShowArea(double a, double b, double h)
        {
            double area = (a + b) * h / 2;
            Console.WriteLine($"Фигура: Трапеция");
            Console.WriteLine($"Площадь: {area:F2} единиц²");
        }
    }
}
