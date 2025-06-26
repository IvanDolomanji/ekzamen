using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные о ноутбуке
            Console.WriteLine("Введите модель ноутбука:");
            string model = Console.ReadLine();

            Console.WriteLine("Введите производителя ноутбука:");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Введите цену ноутбука:");
            double price = double.Parse(Console.ReadLine());

            // Создаем экземпляр структуры Notebook
            Notebook notebook = new Notebook(model, manufacturer, price);

            // Выводим информацию о ноутбуке
            Console.WriteLine("\nИнформация о ноутбуке:");
            notebook.DisplayInfo();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }

    // Структура для представления ноутбука
    struct Notebook
    {
        private string model;
        private string manufacturer;
        private double price;

        // Конструктор для инициализации полей
        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        // Метод для вывода содержимого полей на экран
        public void DisplayInfo()
        {
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Цена: {price:F2} BYN");
        }
    }
}

