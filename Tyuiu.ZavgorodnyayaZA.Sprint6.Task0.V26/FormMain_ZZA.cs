using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZavgorodnyayaZA.Sprint6.Task0.V26.Lib;
namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task0.V26
{
    public partial class FormMain_ZZA : Form
    {
        public FormMain_ZZA()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int x = Convert.ToInt32(textBoxVarX_ZZA.Text);
                double res = ds.Calculate(x);

                textBoxRes_ZZA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVopros_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСПб-23-1 Завгородняя Жанна Алексеевна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}