using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Tovar
    {
        private string name;
        private double price;
        private int quantity;

        // Конструктор с проверками
        public Tovar(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Свойства с инкапсуляцией и ограничениями
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 1 && value <= 20)
                    price = value;
                else
                    throw new ArgumentException("Цена должна быть от 1 до 20!");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0 && value <= 10)
                    quantity = value;
                else
                    throw new ArgumentException("Количество должно быть от 0 до 10!");
            }
        }

        // Метод для вычисления стоимости одного товара
        public double CalculateItemCost()
        {
            return Price * Quantity;
        }
    }
}
