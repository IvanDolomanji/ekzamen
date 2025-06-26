using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class ColorPrinter : Printer
    {
        public override void Print(string value)
        {
            ColorPrinter specificPrinter = this as ColorPrinter;
            if (specificPrinter != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(value);
                Console.ResetColor();
            }
        }
    }
}
