using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class BadPupil : Pupil
    {
        public BadPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine("Изучает материал плохо!");
        }

        public override void Read()
        {
            Console.WriteLine("Читает неохотно!");
        }

        public override void Write()
        {
            Console.WriteLine("Пишет с множеством ошибок!");
        }

        public override void Relax()
        {
            Console.WriteLine("Отдыхает весь день, играя в игры!");
        }
    }
}
