using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Ukrainian : Person
    {
        public Ukrainian(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine($"Привіт, мене звати {Name}!");
        }
    }
}
