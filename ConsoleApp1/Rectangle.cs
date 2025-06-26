using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        // Приватные поля для хранения длин сторон
        private double side1;
        private double side2;

        // Конструктор для инициализации сторон
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод для вычисления площади (side1 * side2)
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        // Метод для вычисления периметра (2 * (side1 + side2))
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        // Свойство для получения площади
        public double Area
        {
            get { return AreaCalculator(); }
        }

        // Свойство для получения периметра
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}

