using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class TVSet : ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Телевизор включен.");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Телевизор выключен.");
        }
    }
}
