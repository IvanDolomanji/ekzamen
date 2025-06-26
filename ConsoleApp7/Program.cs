using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные для счета
            Console.WriteLine("Введите номер счета:");
            int account = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя клиента:");
            string customer = Console.ReadLine();

            Console.WriteLine("Введите имя поставщика:");
            string provider = Console.ReadLine();

            Console.WriteLine("Введите название товара:");
            string article = Console.ReadLine();

            Console.WriteLine("Введите количество товара:");
            int quantity = int.Parse(Console.ReadLine());

            // Создаем экземпляр класса Invoice
            Invoice invoice = new Invoice(account, customer, provider);
            invoice.SetArticleAndQuantity(article, quantity);

            // Запрашиваем, нужно ли учитывать НДС
            Console.WriteLine("Учитывать НДС? (1 - Да, 2 - Нет):");
            string vatChoice = Console.ReadLine();

            // Вычисляем стоимость
            double cost = vatChoice == "1" ? invoice.CalculateCostWithVat() : invoice.CalculateCostWithoutVat();

            // Выводим информацию о счете
            Console.WriteLine("\nИнформация о счете:");
            Console.WriteLine($"Номер счета: {invoice.Account}");
            Console.WriteLine($"Клиент: {invoice.Customer}");
            Console.WriteLine($"Поставщик: {invoice.Provider}");
            Console.WriteLine($"Товар: {invoice.GetArticle()}");
            Console.WriteLine($"Количество: {invoice.GetQuantity()}");
            Console.WriteLine($"Стоимость {(vatChoice == "1" ? "с НДС" : "без НДС")}: {cost:F2} BYN");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
