using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC-документ открыт");
        }

        public override void Create()
        {
            Console.WriteLine("DOC-документ создан");
        }

        public override void Chenge()
        {
            Console.WriteLine("DOC-документ изменен");
        }

        public override void Save()
        {
            Console.WriteLine("DOC-документ сохранен в формате DOC");
        }
    }
}
