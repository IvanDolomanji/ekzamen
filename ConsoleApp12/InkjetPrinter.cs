using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class InkjetPrinter : Printer
    {
        public override void Print(string value)
        {
            InkjetPrinter specificPrinter = this as InkjetPrinter;
            if (specificPrinter != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(value);
                Console.ResetColor();
            }
        }
    }
}
