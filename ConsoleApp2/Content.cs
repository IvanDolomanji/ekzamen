using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Content
    {
        private string content;

        // Конструктор для инициализации содержания
        public Content(string content)
        {
            this.content = content;
        }

        // Метод для отображения содержания в желтом цвете
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Содержание: {content}");
            Console.ResetColor();
        }

        // Метод для получения содержания
        public string GetContent()
        {
            return content;
        }
    }
}
