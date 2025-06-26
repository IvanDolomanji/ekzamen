using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Playing ...");
        }

        public void Pause()
        {
            Console.WriteLine("Paused ...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped ...");
        }

        public void Record()
        {
            Console.WriteLine("Recording ...");
        }
    }
}
