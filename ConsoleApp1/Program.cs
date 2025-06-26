using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя длины сторон
            Console.WriteLine("Введите длину первой стороны:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Создаем новый экземпляр класса Rectangle с введенными данными
            Rectangle rectangle = new Rectangle(side1, side2);

            // Выводим площадь и периметр
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.ReadLine();
        }
    }
}

   
    

