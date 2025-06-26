using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр самолета
            Console.WriteLine("Введите данные для самолета:");
            Console.WriteLine("Координата X:");
            double planeX = double.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y:");
            double planeY = double.Parse(Console.ReadLine());
            Console.WriteLine("Цена:");
            double planePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Скорость (км/ч):");
            double planeSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("Год выпуска:");
            int planeYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Высота (м):");
            double planeAltitude = double.Parse(Console.ReadLine());
            Console.WriteLine("Количество пассажиров:");
            int planePassengers = int.Parse(Console.ReadLine());
            Plane plane = new Plane(planeX, planeY, planePrice, planeSpeed, planeYear, planeAltitude, planePassengers);

            // Создаем экземпляр автомобиля
            Console.WriteLine("\nВведите данные для автомобиля:");
            Console.WriteLine("Координата X:");
            double carX = double.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y:");
            double carY = double.Parse(Console.ReadLine());
            Console.WriteLine("Цена:");
            double carPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Скорость (км/ч):");
            double carSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("Год выпуска:");
            int carYear = int.Parse(Console.ReadLine());
            Car car = new Car(carX, carY, carPrice, carSpeed, carYear);

            // Создаем экземпляр корабля
            Console.WriteLine("\nВведите данные для корабля:");
            Console.WriteLine("Координата X:");
            double shipX = double.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y:");
            double shipY = double.Parse(Console.ReadLine());
            Console.WriteLine("Цена:");
            double shipPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Скорость (км/ч):");
            double shipSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("Год выпуска:");
            int shipYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество пассажиров:");
            int shipPassengers = int.Parse(Console.ReadLine());
            Console.WriteLine("Порт приписки:");
            string shipPort = Console.ReadLine();
            Ship ship = new Ship(shipX, shipY, shipPrice, shipSpeed, shipYear, shipPassengers, shipPort);

            // Выводим информацию о каждом транспортном средстве
            Console.WriteLine("\nИнформация о транспортных средствах:");
            Console.WriteLine("Самолет:");
            plane.DisplayInfo();
            Console.WriteLine("Автомобиль:");
            car.DisplayInfo();
            Console.WriteLine("Корабль:");
            ship.DisplayInfo();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
