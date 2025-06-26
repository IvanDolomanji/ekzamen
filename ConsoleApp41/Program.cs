using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание точек с разными типами
            Console.WriteLine("Создание точки с типом int:");
            Console.WriteLine("Введите координату x:");
            int xInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            int yInt = int.Parse(Console.ReadLine());
            Point<int> pointInt = new Point<int>(xInt, yInt);
            pointInt.Display();

            Console.WriteLine("\nСоздание точки с типом uint:");
            Console.WriteLine("Введите координату x:");
            uint xUInt = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            uint yUInt = uint.Parse(Console.ReadLine());
            Point<uint> pointUInt = new Point<uint>(xUInt, yUInt);
            pointUInt.Display();

            Console.WriteLine("\nСоздание точки с типом double:");
            Console.WriteLine("Введите координату x:");
            double xDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            double yDouble = double.Parse(Console.ReadLine());
            Point<double> pointDouble = new Point<double>(xDouble, yDouble);
            pointDouble.Display();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
