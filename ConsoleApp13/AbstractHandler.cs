using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class AbstractHandler
    {
        public virtual void Open()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void Create()
        {
            Console.WriteLine("Документ создан");
        }

        public virtual void Chenge()
        {
            Console.WriteLine("Документ изменен");
        }

        public virtual void Save()
        {
            Console.WriteLine("Документ сохранен");
        }
    }
}
