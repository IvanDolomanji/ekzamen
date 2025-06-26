using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    abstract class Tovar
    {
        protected string name;
        protected double price;

        public Tovar(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract double CalcSum();

        public void Print()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Цена: {price:F2} руб.");
            Console.WriteLine($"Стоимость: {CalcSum():F2} руб.");
            Console.WriteLine();
        }
    }
}
