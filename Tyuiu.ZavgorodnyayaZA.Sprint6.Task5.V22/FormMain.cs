using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task5.V22
{
    public partial class FormMain_ZZA : Form
    {
        public FormMain_ZZA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"D:\Project's C#\Tyuiu.ZavgorodnyayaZA.Sprint6\Tyuiu.ZavgorodnyayaZA.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";


        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_ZZA.ColumnCount = 2;
            dataGridViewOutPut_ZZA.Columns[0].Width = 20;
            dataGridViewOutPut_ZZA.Columns[1].Width = 50;

            this.chartDiag_ZZA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_ZZA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_ZZA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_ZZA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_ZZA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_SAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСПб-23-1 Завгородняя Жанна Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_SAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
