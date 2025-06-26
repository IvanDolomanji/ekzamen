using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int year)
            : base(x, y, price, speed, year)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Координаты: ({x}, {y})");
            Console.WriteLine($"Цена: {price} BYN");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Год выпуска: {year}");
        }
    }

}
