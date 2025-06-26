using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов с различными конструкторами
            Kupura kupura1 = new Kupura(); // Конструктор по умолчанию
            Kupura kupura2 = new Kupura("100 рублей", 100.0, 5); // Конструктор с параметрами
            Kupura kupura3 = new Kupura("500 рублей", 500.0); // Конструктор с одним параметром

            // Установка значений через свойства
            Console.WriteLine("Введите данные для первой купюры:");
            Console.WriteLine("Название:");
            kupura1.Name = Console.ReadLine();
            Console.WriteLine("Номинал:");
            kupura1.Nominal = double.Parse(Console.ReadLine());
            Console.WriteLine("Количество:");
            kupura1.Quantity = int.Parse(Console.ReadLine());

            // Вывод информации о купюрах
            Console.WriteLine("\nИнформация о купюрах:");
            kupura1.Show();
            kupura2.Show();
            kupura3.Show();

            // Демонстрация методов
            Console.WriteLine("\nИзменение количества купюр для kupura1:");
            Console.WriteLine("Увеличить на (введите число):");
            int increase = int.Parse(Console.ReadLine());
            kupura1.ChangeQuantity(increase);
            kupura1.Show();

            Console.WriteLine("Уменьшить на (введите число):");
            int decrease = int.Parse(Console.ReadLine());
            kupura1.ChangeQuantity(-decrease);
            kupura1.Show();

            Console.WriteLine("\nПроверка достаточности суммы для покупки:");
            Console.WriteLine("Введите стоимость покупки для kupura2:");
            double purchaseCost = double.Parse(Console.ReadLine());
            if (kupura2.IsEnoughForPurchase(purchaseCost))
                Console.WriteLine($"Сумма {kupura2.Nominal * kupura2.Quantity:F2} руб. достаточна для покупки на {purchaseCost:F2} руб.");
            else
                Console.WriteLine($"Сумма {kupura2.Nominal * kupura2.Quantity:F2} руб. недостаточна для покупки на {purchaseCost:F2} руб.");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
