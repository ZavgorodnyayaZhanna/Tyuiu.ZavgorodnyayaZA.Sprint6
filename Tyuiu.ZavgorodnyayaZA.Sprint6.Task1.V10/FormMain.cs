using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task1.V10.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task1.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_SKE_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_ZZA.Text);
                int end = Convert.ToInt32(textBoxEnd_ZZA.Text);

                string strLine;

                int len = ds.GetMassFunction(start, end).Length;

                double[] res = new double[len];
                res = ds.GetMassFunction(start, end);

                textBoxOutPut_ZZA.Text = "";
                textBoxOutPut_ZZA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutPut_ZZA.AppendText("+    x     +   f(x)   +" + Environment.NewLine);
                textBoxOutPut_ZZA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", start, res[i]);
                    textBoxOutPut_ZZA.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxOutPut_ZZA.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск1 выполнил студент группы ИСПб-23-1 Завгородняя Жанна Алексеевна", "Сообщение");
        }
    }
}