using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя значение x
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            // Создаем экземпляр класса MyClass
            MyClass myClass = new MyClass();

            // Вызываем методы и выводим результаты
            Console.WriteLine("\nРезультаты вычислений:");
            Console.WriteLine($"Число PI: {myClass.GetPi()}");
            Console.WriteLine($"Случайное число типа int: {myClass.GetRandomInt()}");
            Console.WriteLine($"x в квадрате: {myClass.Square(x)}");
            Console.WriteLine($"Корень квадратный из x: {myClass.SquareRoot(x)}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }

    // Интерфейс с методами
    interface ICalculator
    {
        double GetPi();
        int GetRandomInt();
        double Square(double x);
        double SquareRoot(double x);
    }
}
