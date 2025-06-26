using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    abstract class Person
    {
        public string Name { get; protected set; }

        protected Person(string name)
        {
            Name = name;
        }

        public abstract void SayHello();
    }
}
