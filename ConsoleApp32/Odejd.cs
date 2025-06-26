using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Odejda : Tovar
    {
        private int quantity;
        private string color;

        public Odejda(string name, double price, int quantity, string color) : base(name, price)
        {
            this.quantity = quantity;
            this.color = color;
        }

        public override double CalcSum()
        {
            return price * quantity;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Количество единиц: {quantity}");
            Console.WriteLine($"Цвет: {color}");
            Console.WriteLine();
        }
    }
}
