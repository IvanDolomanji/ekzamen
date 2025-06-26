using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Computer
    {
        private string model;
        private int ram;
        private int hdd;

        // Конструктор с проверками
        public Computer(string model, int ram, int hdd)
        {
            Model = model;
            Ram = ram;
            Hdd = hdd;
        }

        // Свойства с инкапсуляцией и ограничениями
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value >= 2 && value <= 32)
                    ram = value;
                else
                    throw new ArgumentException("Объем ОЗУ должен быть от 2 до 32 Гб!");
            }
        }

        public int Hdd
        {
            get { return hdd; }
            set
            {
                if (value >= 200 && value <= 2000)
                    hdd = value;
                else
                    throw new ArgumentException("Объем жесткого диска должен быть от 200 до 2000 Гб!");
            }
        }

        // Метод для расчета стоимости (примерная формула: базовая цена + доплата за ОЗУ и HDD)
        public double CalculateCost()
        {
            const double basePrice = 20000.0; // Базовая цена
            double ramCost = Ram * 1000.0;    // 1000 руб. за каждый Гб ОЗУ
            double hddCost = (Hdd / 100.0) * 500.0; // 500 руб. за каждые 100 Гб HDD
            return basePrice + ramCost + hddCost;
        }

        // Метод для вывода информации
        public void Display()
        {
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Объем ОЗУ: {ram} Гб");
            Console.WriteLine($"Объем жесткого диска: {hdd} Гб");
        }
    }
}
