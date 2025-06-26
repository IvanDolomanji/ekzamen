using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя текст для печати
            Console.WriteLine("Введите текст для печати (цвета будут различаться для разных принтеров):");
            string text = Console.ReadLine();

            // Создаем экземпляры разных принтеров
            Printer colorPrinter = new ColorPrinter();
            Printer laserPrinter = new LaserPrinter();
            Printer inkjetPrinter = new InkjetPrinter();

            // Выводим текст с использованием разных принтеров
            Console.WriteLine("\nПечать текста разными принтерами:");
            colorPrinter.Print(text);
            laserPrinter.Print(text);
            inkjetPrinter.Print(text);

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
