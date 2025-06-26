using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем обобщенный список цветов
            List<string> colors = new List<string>();

            // 1) Добавляем элементы строчными буквами
            Console.WriteLine("Введите количество цветов для добавления:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите цвет {i + 1} (строчными буквами):");
                string color = Console.ReadLine().ToLower();
                colors.Add(color);
            }
            Console.WriteLine("\n1) Элементы добавлены в список:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 2) Выводим содержимое коллекции
            Console.WriteLine("\n2) Содержимое коллекции:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 3) Преобразуем все буквы в прописные
            for (int i = 0; i < colors.Count; i++)
            {
                colors[i] = colors[i].ToUpper();
            }
            Console.WriteLine("\n3) Элементы преобразованы в прописные буквы:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 4) Выводим содержимое коллекции после преобразования
            Console.WriteLine("\n4) Содержимое коллекции после преобразования:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 5) Определяем текущее количество элементов
            Console.WriteLine($"\n5) Текущее количество элементов в коллекции: {colors.Count}");

            // 6) Добавляем новый элемент в конец списка
            Console.WriteLine("\n6) Введите новый цвет для добавления в конец списка:");
            string newColorEnd = Console.ReadLine().ToUpper();
            colors.Add(newColorEnd);
            Console.WriteLine("Новый элемент добавлен в конец списка:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 7) Выводим содержимое коллекции после добавления в конец
            Console.WriteLine("\n7) Содержимое коллекции после добавления в конец:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 8) Добавляем новый элемент в начало списка
            Console.WriteLine("\n8) Введите новый цвет для добавления в начало списка:");
            string newColorStart = Console.ReadLine().ToUpper();
            colors.Insert(0, newColorStart);
            Console.WriteLine("Новый элемент добавлен в начало списка:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 9) Выводим содержимое коллекции после добавления в начало
            Console.WriteLine("\n9) Содержимое коллекции после добавления в начало:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 10) Удаляем третий элемент коллекции
            if (colors.Count >= 3)
            {
                colors.RemoveAt(2);
                Console.WriteLine("\n10) Третий элемент удален из коллекции:");
                foreach (var color in colors)
                {
                    Console.WriteLine(color);
                }
            }
            else
            {
                Console.WriteLine("\n10) Недостаточно элементов для удаления третьего.");
            }

            // 11) Выводим содержимое коллекции после удаления
            Console.WriteLine("\n11) Содержимое коллекции после удаления:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // 12) Располагаем элементы в обратном порядке
            colors.Reverse();
            Console.WriteLine("\n12) Элементы расположены в обратном порядке:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
