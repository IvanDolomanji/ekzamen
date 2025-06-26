using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine("Изучает материал хорошо!");
        }

        public override void Read()
        {
            Console.WriteLine("Читает книги с интересом!");
        }

        public override void Write()
        {
            Console.WriteLine("Пишет с минимальными ошибками!");
        }

        public override void Relax()
        {
            Console.WriteLine("Отдыхает спокойно, смотря телевизор!");
        }
    }
}
