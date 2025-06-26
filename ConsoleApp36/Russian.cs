using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Russian : Person
    {
        public Russian(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine($"Привет, меня зовут {Name}!");
        }
    }
}
