using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            int rows = 0;
            string resLine0 = "", resLine1 = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resLine0 += line + " ";
                    resLine1 += line + ";";
                    rows++;
                }
            }
            string[] getColumns = resLine0.Split(' ');
            string[] strNums = resLine1.Split(';');
            int columns = getColumns[getColumns.Length - 1] == "" ? getColumns.Length - 1 : getColumns.Length;
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != 8) { matrix[i, j] = int.Parse(strNums[i * columns + j]); }
                    else { matrix[i, j] = 11; }
                }
            }

            return matrix;
        }
    }
}
