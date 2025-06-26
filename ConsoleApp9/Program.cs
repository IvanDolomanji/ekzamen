using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя фамилии для учеников
            Console.WriteLine("Введите фамилию для первого ученика (отличник):");
            string excellentLastName = Console.ReadLine();

            Console.WriteLine("Введите фамилию для второго ученика (хорошист):");
            string goodLastName = Console.ReadLine();

            Console.WriteLine("Введите фамилию для третьего ученика (двоечник):");
            string badLastName = Console.ReadLine();

            // Создаем экземпляры учеников
            ExcelentPupil excellentPupil = new ExcelentPupil(excellentLastName);
            GoodPupil goodPupil = new GoodPupil(goodLastName);
            BadPupil badPupil = new BadPupil(badLastName);

            // Создаем экземпляр класса ClassRoom (добавляем четвертого ученика как хорошиста по умолчанию)
            ClassRoom classRoom;
            try
            {
                classRoom = new ClassRoom(excellentPupil, goodPupil, badPupil, new GoodPupil("Иванов"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return;
            }

            // Выводим информацию о действиях учеников
            Console.WriteLine("Ученики изучают занятия!");
            foreach (var pupil in classRoom.Pupils)
            {
                Console.WriteLine($"{pupil.LastName}: ");
                pupil.Study();
            }

            Console.WriteLine("Ученики читают!");
            foreach (var pupil in classRoom.Pupils)
            {
                Console.WriteLine($"{pupil.LastName}: ");
                pupil.Read();
            }

            Console.WriteLine("Ученики пишут!");
            foreach (var pupil in classRoom.Pupils)
            {
                Console.WriteLine($"{pupil.LastName}: ");
                pupil.Write();
            }

            Console.WriteLine("Ученики отдыхают, смотря телевизор!");
            foreach (var pupil in classRoom.Pupils)
            {
                Console.WriteLine($"{pupil.LastName}: ");
                pupil.Relax();
            }

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
