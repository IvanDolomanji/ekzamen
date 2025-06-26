using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class LaserPrinter : Printer
    {
        public override void Print(string value)
        {
            LaserPrinter specificPrinter = this as LaserPrinter;
            if (specificPrinter != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(value);
                Console.ResetColor();
            }
        }
    }
}
