using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные о книге
            Console.WriteLine("Введите название книги:");
            string titleInput = Console.ReadLine();

            Console.WriteLine("Введите автора книги:");
            string authorInput = Console.ReadLine();

            Console.WriteLine("Введите содержание книги:");
            string contentInput = Console.ReadLine();

            // Создаем экземпляры классов с введенными данными
            Title bookTitle = new Title(titleInput);
            Author bookAuthor = new Author(authorInput);
            Content bookContent = new Content(contentInput);

            // Создаем экземпляр класса Book и добавляем в него данные
            Book book = new Book();
            book.SetTitle(bookTitle);
            book.SetAuthor(bookAuthor);
            book.SetContent(bookContent);

            // Выводим информацию о книге
            Console.WriteLine("\nИнформация о книге:");
            book.Show();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.ReadLine();
        }
    }
}
