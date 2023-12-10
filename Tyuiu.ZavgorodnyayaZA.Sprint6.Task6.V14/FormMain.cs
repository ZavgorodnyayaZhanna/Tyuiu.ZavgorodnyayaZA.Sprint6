using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14.Lib;
using System.IO;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14
{
    public partial class FormMain_ZZA : Form
    {
        public FormMain_ZZA()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService dataService = new DataService();
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            textBoxResult_ZZA.Text = dataService.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZZA.ShowDialog();
            openFilePath = openFileDialogTask_ZZA.FileName;
            textBoxInput_ZZA.Text = File.ReadAllText(openFilePath);
            groupBoxResult_ZZA.Text = groupBoxResult_ZZA.Text + " " + openFileDialogTask_ZZA.FileName;
            buttonDone_ZZA.Enabled = true;
        }
    }
}
