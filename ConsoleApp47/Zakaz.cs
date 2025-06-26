using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Zakaz
    {
        private string fam;
        private int size;
        private string comfort;

        // Конструктор 1: с фамилией, количеством мест и комфортностью
        public Zakaz(string fam, int size, string comfort)
        {
            this.fam = fam;
            this.size = size;
            this.comfort = comfort;
        }

        // Конструктор 2: с фамилией и количеством мест (комфорт по умолчанию "стандарт")
        public Zakaz(string fam, int size)
            : this(fam, size, "стандарт")
        {
        }

        // Конструктор 3: с фамилией (количество мест 1, комфорт "стандарт")
        public Zakaz(string fam)
            : this(fam, 1)
        {
        }

        // Конструктор 4: без параметров (фамилия "Неизвестно", количество 1, комфорт "стандарт")
        public Zakaz()
            : this("Неизвестно")
        {
        }

        // Метод для отображения информации о заказе
        public void Show()
        {
            Console.WriteLine($"Фамилия: {fam}");
            Console.WriteLine($"Количество мест: {size}");
            Console.WriteLine($"Комфортность: {comfort}");
            Console.WriteLine();
        }
    }
}
