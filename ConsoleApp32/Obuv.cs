using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Obuv : Tovar
    {
        private int quantity;
        private int size;

        public Obuv(string name, double price, int quantity, int size) : base(name, price)
        {
            this.quantity = quantity;
            this.size = size;
        }

        public override double CalcSum()
        {
            return price * quantity;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Количество пар: {quantity}");
            Console.WriteLine($"Размер (EU): {size}");
            Console.WriteLine();
        }
    }
}
