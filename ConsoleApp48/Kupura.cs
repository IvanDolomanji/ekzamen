using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Kupura
    {
        private string name;
        private double nominal;
        private int quantity;

        // Конструктор по умолчанию
        public Kupura()
        {
            this.name = "Неизвестно";
            this.nominal = 0.0;
            this.quantity = 0;
        }

        // Конструктор с одним параметром (название)
        public Kupura(string name)
            : this()
        {
            this.name = name;
        }

        // Конструктор с параметрами (название, номинал)
        public Kupura(string name, double nominal)
            : this(name)
        {
            this.nominal = nominal;
        }

        // Конструктор с полным набором параметров
        public Kupura(string name, double nominal, int quantity)
            : this(name, nominal)
        {
            this.quantity = quantity;
        }

        // Свойства с проверкой данных
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название не может быть пустым!");
                name = value;
            }
        }

        public double Nominal
        {
            get { return nominal; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номинал должен быть положительным!");
                nominal = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество не может быть отрицательным!");
                quantity = value;
            }
        }

        // Метод для вывода информации
        public void Show()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Номинал: {nominal:F2} руб.");
            Console.WriteLine($"Количество: {quantity}");
            Console.WriteLine();
        }

        // Метод для изменения количества купюр
        public void ChangeQuantity(int delta)
        {
            int newQuantity = quantity + delta;
            if (newQuantity < 0)
                throw new ArgumentException("Количество не может стать отрицательным!");
            quantity = newQuantity;
        }

        // Метод для проверки достаточности суммы
        public bool IsEnoughForPurchase(double cost)
        {
            if (cost < 0)
                throw new ArgumentException("Стоимость покупки не может быть отрицательной!");
            return (nominal * quantity) >= cost;
        }
    }
}
