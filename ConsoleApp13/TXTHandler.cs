using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT-документ открыт");
        }

        public override void Create()
        {
            Console.WriteLine("TXT-документ создан");
        }

        public override void Chenge()
        {
            Console.WriteLine("TXT-документ изменен");
        }

        public override void Save()
        {
            Console.WriteLine("TXT-документ сохранен в формате TXT");
        }
    }
}
