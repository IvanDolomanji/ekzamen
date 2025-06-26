using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса DerivedClass
            DerivedClass dClass = new DerivedClass();

            // Вызываем все методы
            dClass.Method1();
            dClass.Method2();
            dClass.Method3();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }

    // Интерфейс IInterface1
    interface IInterface1
    {
        void Method1();
    }

    // Интерфейс IInterface2, наследующий IInterface1
    interface IInterface2 : IInterface1
    {
        void Method2();
    }

    // Интерфейс IInterface3, наследующий IInterface2
    interface IInterface3 : IInterface2
    {
        void Method3();
    }
}
