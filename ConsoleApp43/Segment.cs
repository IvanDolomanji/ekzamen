using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Segment<T> where T : struct
    {
        private T x1;
        private T y1;
        private T x2;
        private T y2;

        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public T Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public T X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public T Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Отрезок: ({x1}, {y1}) - ({x2}, {y2})");
        }

        public double CalculateLength()
        {
            // Формула длины отрезка: √((x2 - x1)² + (y2 - y1)²)
            dynamic dx = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            dynamic dy = Convert.ToDouble(y2) - Convert.ToDouble(y1);
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
