using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            ConsoleColor consoleColor = (ConsoleColor)color;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }

    // Перечисление цветов
    enum Color
    {
        Black = 0,
        Blue = 1,
        Green = 2,
        Yellow = 3,
        Red = 4,
        Magenta = 5,
        Cyan = 6,
        White = 7
    }
}
