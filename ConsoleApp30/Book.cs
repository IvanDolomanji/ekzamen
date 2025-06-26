using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Book : Tovar
    {
        private int kvo;

        public Book(string name, double price, int kvo) : base(name, price)
        {
            this.kvo = kvo;
        }

        public override void Calc()
        {
            double cost = price * kvo;
            Console.WriteLine($"Книга: {name}, Цена: {price:F2} руб., Количество: {kvo}, Стоимость: {cost:F2} руб.");
        }
    }
}
