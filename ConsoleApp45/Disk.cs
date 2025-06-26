using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Disk : IShape
    {
        private double radius;

        public Disk(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным!");
            this.radius = radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public string GetParameters()
        {
            return $"радиус = {radius}";
        }
    }
}
