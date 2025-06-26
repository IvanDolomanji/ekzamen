using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || b + c <= a || a + c <= b)
                throw new ArgumentException("Треугольник с такими сторонами не существует!");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string GetParameters()
        {
            return $"a = {a}, b = {b}, c = {c}";
        }
    }
}
