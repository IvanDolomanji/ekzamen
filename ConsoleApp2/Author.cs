using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Author
    {
        private string author;

        // Конструктор для инициализации автора
        public Author(string author)
        {
            this.author = author;
        }

        // Метод для отображения автора в зеленом цвете
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Автор: {author}");
            Console.ResetColor();
        }

        // Метод для получения автора
        public string GetAuthor()
        {
            return author;
        }
    }
}
