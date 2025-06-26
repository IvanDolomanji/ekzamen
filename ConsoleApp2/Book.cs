using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        // Метод для установки названия
        public void SetTitle(Title title)
        {
            this.title = title;
        }

        // Метод для установки автора
        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        // Метод для установки содержания
        public void SetContent(Content content)
        {
            this.content = content;
        }

        // Метод для отображения всей информации о книге
        public void Show()
        {
            title?.Show();
            author?.Show();
            content?.Show();
        }
    }
}
