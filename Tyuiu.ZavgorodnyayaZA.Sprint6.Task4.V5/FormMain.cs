using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task4.V5.Lib;
using System.IO;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task4.V5
{
    public partial class FormMain_ZZA : Form
    {
        public FormMain_ZZA()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ZZA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ZZA.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = dataService.GetMassFunction(startStep, stopStep);

                this.chartFunction_ZZA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZZA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_ZZA.Text = "";

                chartFunction_ZZA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chartFunction_ZZA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_ZZA.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SSV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V5.txt";
                File.WriteAllText(path, textBoxResult_ZZA.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Файл {path} сохранён успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    //System.Diagnostics.Process.Start( path );
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСПб-23-1 Завгородняя Жанна Алексеевна", "Сообщение");
        }
    }
}
