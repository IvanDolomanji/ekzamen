using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Product
    {
        private string name;
        private string manufacturer;
        private double price;
        private int shelfLife;
        private int quantity;

        public Product(string name, string manufacturer, double price, int shelfLife, int quantity)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.shelfLife = shelfLife;
            this.quantity = quantity;
        }

        public string Name => name;
        public string Manufacturer => manufacturer;
        public double Price => price;
        public int ShelfLife => shelfLife;
        public int Quantity => quantity;

        public void Display()
        {
            Console.WriteLine($"Наименование: {name}");
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Цена: {price:F2} руб.");
            Console.WriteLine($"Срок хранения: {shelfLife} дней");
            Console.WriteLine($"Количество: {quantity}");
            Console.WriteLine();
        }
    }
}
