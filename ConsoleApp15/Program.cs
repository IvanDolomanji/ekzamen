using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса MyClass
            MyClass myClassOb = new MyClass();

            // Вызываем методы для вывода информации
            myClassOb.ShowInterfaceA();
            myClassOb.ShowInterfaceB();
            myClassOb.ShowInterfaceC();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }

    // Интерфейс InterfaceA
    interface InterfaceA
    {
        void ShowInterfaceA();
    }

    // Интерфейс InterfaceB
    interface InterfaceB
    {
        void ShowInterfaceB();
    }

    // Интерфейс InterfaceC с множественным наследованием
    interface InterfaceC : InterfaceA, InterfaceB
    {
        void ShowInterfaceC();
    }
}
