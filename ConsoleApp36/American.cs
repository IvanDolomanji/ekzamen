using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class American : Person
    {
        public American(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine($"Hi, my name is {Name}!");
        }
    }
}
