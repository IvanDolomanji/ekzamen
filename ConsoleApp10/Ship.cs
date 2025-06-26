using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Координаты: ({x}, {y})");
            Console.WriteLine($"Цена: {price} BYN");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Год выпуска: {year}");
            Console.WriteLine($"Пассажиров: {passengers}");
            Console.WriteLine($"Порт приписки: {port}");
        }
    }
}
