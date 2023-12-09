using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            for (int x = startValue, count = 0; x <= stopValue; x++, count++)
            {
                y = 3 * x + 1.2 != 0 ? Math.Round((2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2, 2) : 0;
                valueArray[count] = y;

            }
            return valueArray;
        }
    }
}
