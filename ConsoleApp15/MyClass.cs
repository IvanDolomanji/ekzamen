using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class MyClass : InterfaceC
    {
        public void ShowInterfaceA()
        {
            Console.WriteLine("Exploring interfaces, example 2...");
        }

        public void ShowInterfaceB()
        {
            Console.WriteLine("Concept of multiple inheritance through interface...");
        }

        public void ShowInterfaceC()
        {
            Console.WriteLine("ShowInterfaceA() is completed.");
            Console.WriteLine("ShowInterfaceB() is completed.");
        }
    }
}
