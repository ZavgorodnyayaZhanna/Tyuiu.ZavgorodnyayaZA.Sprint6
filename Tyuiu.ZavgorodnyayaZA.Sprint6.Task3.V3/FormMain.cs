using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task3.V3.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task3.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();
        int[,] mtrx = new int[5, 5] { { -18,  21,  10,  -2,  12 },
                                      { -18, -10,  33, -20,  32 },
                                      { 14, -15, -14,  12, -18 },
                                      { -19,  5,  -3,  28, -17 },
                                      { -14,  -9,  23, -13,  11} };
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            int[,] res = dataService.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.GetUpperBound(1) + 1;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб-23-1 Завгородняя Жанна Алексеевна", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
