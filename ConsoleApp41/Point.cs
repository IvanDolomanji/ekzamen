using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Point<T> where T : struct
    {
        private T x;
        private T y;

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Display()
        {
            Console.WriteLine($"Координаты точки: ({x}, {y})");
        }
    }
}
