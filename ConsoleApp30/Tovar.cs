using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Tovar
    {
        protected string name;
        protected double price;

        public Tovar(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual void Calc()
        {
            Console.WriteLine($"Товар: {name}, Цена: {price:F2} руб., Стоимость: {price:F2} руб.");
        }
    }
}
