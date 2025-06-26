using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class PersonalComputer : ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Компьютер включен.");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Компьютер выключен.");
        }
    }
}
