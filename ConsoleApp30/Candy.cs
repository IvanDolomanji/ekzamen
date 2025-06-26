using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Candy : Tovar
    {
        private double ves;

        public Candy(string name, double price, double ves) : base(name, price)
        {
            this.ves = ves;
        }

        public override void Calc()
        {
            double cost = price * ves;
            Console.WriteLine($"Конфеты: {name}, Цена: {price:F2} руб./кг, Вес: {ves:F2} кг, Стоимость: {cost:F2} руб.");
        }
    }
}
