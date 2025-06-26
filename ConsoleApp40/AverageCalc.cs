using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    static class AverageCalc
    {
        public static double Average(int m, int n)
        {
            if (m > n)
                throw new ArgumentException("m не может быть больше n!");

            int sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }
    }

    // Делегат, соответствующий методу Average
    delegate double AverageDelegate(int m, int n);
}
