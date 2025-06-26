using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class MyClass : ICalculator
    {
        public double GetPi()
        {
            return Math.PI;
        }

        public int GetRandomInt()
        {
            Random random = new Random();
            return random.Next();
        }

        public double Square(double x)
        {
            return x * x;
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
