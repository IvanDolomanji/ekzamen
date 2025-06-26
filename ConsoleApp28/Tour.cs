using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Tour
    {
    public double TourCalc()
    {
        // Минское море, бесплатно
        return 0.0;
    }

    public double TourCalc(string country)
    {
        // 1 день, 50 руб
        return 50.0;
    }

    public double TourCalc(string country, int days)
    {
        // Стоимость = 50 * количество дней
        return 50.0 * days;
    }
}
}
