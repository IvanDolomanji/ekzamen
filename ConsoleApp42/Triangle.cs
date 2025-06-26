using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Triangle<T> where T : struct
    {
        private T a;
        private T b;
        private T c;

        public Triangle(T a, T b, T c)
        {
            // Логика проверки существования треугольника (теорема о неравенстве треугольника)
            dynamic da = Convert.ToDouble(a);
            dynamic db = Convert.ToDouble(b);
            dynamic dc = Convert.ToDouble(c);
            if (da + db <= dc || db + dc <= da || da + dc <= db)
                throw new ArgumentException("Треугольник с такими сторонами не существует!");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public T A
        {
            get { return a; }
            set
            {
                dynamic da = Convert.ToDouble(value);
                dynamic db = Convert.ToDouble(b);
                dynamic dc = Convert.ToDouble(c);
                if (da + db <= dc || db + dc <= da || da + dc <= db)
                    throw new ArgumentException("Невозможно задать сторону a: треугольник не существует!");
                a = value;
            }
        }

        public T B
        {
            get { return b; }
            set
            {
                dynamic da = Convert.ToDouble(a);
                dynamic db = Convert.ToDouble(value);
                dynamic dc = Convert.ToDouble(c);
                if (da + db <= dc || db + dc <= da || da + dc <= db)
                    throw new ArgumentException("Невозможно задать сторону b: треугольник не существует!");
                b = value;
            }
        }

        public T C
        {
            get { return c; }
            set
            {
                dynamic da = Convert.ToDouble(a);
                dynamic db = Convert.ToDouble(b);
                dynamic dc = Convert.ToDouble(value);
                if (da + db <= dc || db + dc <= da || da + dc <= db)
                    throw new ArgumentException("Невозможно задать сторону c: треугольник не существует!");
                c = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        }

        public double CalculateArea()
        {
            // Формула Герона
            dynamic da = Convert.ToDouble(a);
            dynamic db = Convert.ToDouble(b);
            dynamic dc = Convert.ToDouble(c);
            dynamic p = (da + db + dc) / 2;
            return Math.Sqrt(Convert.ToDouble(p * (p - da) * (p - db) * (p - dc)));
        }
    }
}
