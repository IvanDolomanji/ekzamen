using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class Pupil
    {
        protected string lastName;

        public Pupil(string lastName)
        {
            this.lastName = lastName;
        }

        public string LastName
        {
            get { return lastName; }
        }

        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
