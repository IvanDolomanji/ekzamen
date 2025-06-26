using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Plane : Vehicle
    {
        private double altitude;
        private int passengers;

        public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Координаты: ({x}, {y})");
            Console.WriteLine($"Цена: {price} BYN");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Год выпуска: {year}");
            Console.WriteLine($"Высота: {altitude} м");
            Console.WriteLine($"Пассажиров: {passengers}");
        }
    }
}
