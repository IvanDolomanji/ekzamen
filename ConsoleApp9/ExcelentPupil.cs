using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine("Изучает материал на отлично!");
        }

        public override void Read()
        {
            Console.WriteLine("Читает книги с большим интересом!");
        }

        public override void Write()
        {
            Console.WriteLine("Пишет без ошибок!");
        }

        public override void Relax()
        {
            Console.WriteLine("Отдыхает активно, занимаясь спортом!");
        }
    }
}
