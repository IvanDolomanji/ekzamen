using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Posuda : Tovar
    {
        private double weight;
        private string color;

        public Posuda(string name, double price, double weight, string color) : base(name, price)
        {
            this.weight = weight;
            this.color = color;
        }

        public override double CalcSum()
        {
            return price * weight;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Масса (кг): {weight}");
            Console.WriteLine($"Цвет: {color}");
            Console.WriteLine();
        }
    }
}
