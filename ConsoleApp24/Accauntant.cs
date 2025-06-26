using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            // Получаем требуемое количество часов для данной должности
            int requiredHours = (int)worker;
            return hours > requiredHours;
        }
    }
}
