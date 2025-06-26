using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо!");
            return a / b;
        }
    }
}
