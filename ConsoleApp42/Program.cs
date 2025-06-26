using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание треугольников с разными типами
            Console.WriteLine("Создание треугольника с типом int:");
            Console.WriteLine("Введите сторону a:");
            int aInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b:");
            int bInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c:");
            int cInt = int.Parse(Console.ReadLine());
            Triangle<int> triangleInt = new Triangle<int>(aInt, bInt, cInt);
            triangleInt.DisplayInfo();
            Console.WriteLine($"Площадь: {triangleInt.CalculateArea():F2}");

            Console.WriteLine("\nСоздание треугольника с типом uint:");
            Console.WriteLine("Введите сторону a:");
            uint aUInt = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b:");
            uint bUInt = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c:");
            uint cUInt = uint.Parse(Console.ReadLine());
            Triangle<uint> triangleUInt = new Triangle<uint>(aUInt, bUInt, cUInt);
            triangleUInt.DisplayInfo();
            Console.WriteLine($"Площадь: {triangleUInt.CalculateArea():F2}");

            Console.WriteLine("\nСоздание треугольника с типом double:");
            Console.WriteLine("Введите сторону a:");
            double aDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b:");
            double bDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c:");
            double cDouble = double.Parse(Console.ReadLine());
            Triangle<double> triangleDouble = new Triangle<double>(aDouble, bDouble, cDouble);
            triangleDouble.DisplayInfo();
            Console.WriteLine($"Площадь: {triangleDouble.CalculateArea():F2}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
