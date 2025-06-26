using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class DateClass
    {
        private DateTime data;

        // Конструктор без параметров (устанавливает текущую дату)
        public DateClass()
        {
            data = DateTime.Now;
        }

        // Конструктор с тремя параметрами
        public DateClass(int year, int month, int day)
        {
            try
            {
                data = new DateTime(year, month, day);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentException("Некорректная дата! Проверьте год, месяц и день.");
            }
        }

        // Свойство для доступа к полю
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // Метод для вычисления предыдущего дня
        public DateTime GetPreviousDay()
        {
            return data.AddDays(-1);
        }

        // Метод для вычисления следующего дня
        public DateTime GetNextDay()
        {
            return data.AddDays(1);
        }
    }
}
