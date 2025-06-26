using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание отрезков с разными типами
            Console.WriteLine("Создание отрезка с типом int:");
            Console.WriteLine("Введите x1:");
            int x1Int = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y1Int = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            int x2Int = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y2Int = int.Parse(Console.ReadLine());
            Segment<int> segmentInt = new Segment<int>(x1Int, y1Int, x2Int, y2Int);
            segmentInt.DisplayInfo();
            Console.WriteLine($"Длина отрезка: {segmentInt.CalculateLength():F2}");

            Console.WriteLine("\nСоздание отрезка с типом long:");
            Console.WriteLine("Введите x1:");
            long x1Long = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            long y1Long = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            long x2Long = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            long y2Long = long.Parse(Console.ReadLine());
            Segment<long> segmentLong = new Segment<long>(x1Long, y1Long, x2Long, y2Long);
            segmentLong.DisplayInfo();
            Console.WriteLine($"Длина отрезка: {segmentLong.CalculateLength():F2}");

            Console.WriteLine("\nСоздание отрезка с типом double:");
            Console.WriteLine("Введите x1:");
            double x1Double = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double y1Double = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            double x2Double = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double y2Double = double.Parse(Console.ReadLine());
            Segment<double> segmentDouble = new Segment<double>(x1Double, y1Double, x2Double, y2Double);
            segmentDouble.DisplayInfo();
            Console.WriteLine($"Длина отрезка: {segmentDouble.CalculateLength():F2}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
