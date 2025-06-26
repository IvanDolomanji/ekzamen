using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML-документ открыт");
        }

        public override void Create()
        {
            Console.WriteLine("XML-документ создан");
        }

        public override void Chenge()
        {
            Console.WriteLine("XML-документ изменен");
        }

        public override void Save()
        {
            Console.WriteLine("XML-документ сохранен в формате XML");
        }
    }
}
