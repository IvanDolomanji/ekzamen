using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Title
    {
        private string title;

        // Конструктор для инициализации названия
        public Title(string title)
        {
            this.title = title;
        }

        // Метод для отображения названия в синем цвете
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Название: {title}");
            Console.ResetColor();
        }

        // Метод для получения названия
        public string GetTitle()
        {
            return title;
        }
    }
}
