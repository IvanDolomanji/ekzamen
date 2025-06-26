using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    abstract class Vehicle
    {
        protected double x;
        protected double y;
        protected double price;
        protected double speed;
        protected int year;

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public abstract void DisplayInfo();
    }
}
