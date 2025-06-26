using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
            {
                throw new ArgumentException("Количество учеников должно быть от 2 до 4.");
            }
            this.pupils = new Pupil[4]; // Всегда создаем массив на 4 места
            Array.Copy(pupils, this.pupils, pupils.Length);
            // Заполняем оставшиеся места хорошистами по умолчанию, если менее 4
            for (int i = pupils.Length; i < 4; i++)
            {
                this.pupils[i] = new GoodPupil("Иванов" + i);
            }
        }

        public Pupil[] Pupils
        {
            get { return pupils; }
        }
    }
}
