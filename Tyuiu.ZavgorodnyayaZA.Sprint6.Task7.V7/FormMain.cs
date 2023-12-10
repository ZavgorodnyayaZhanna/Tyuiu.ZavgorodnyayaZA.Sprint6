using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZavgorodnyayaZA.Sprint6.Task7.V7.Lib;
using System.IO;

namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task7.V7
{
    public partial class FormMain_ZZA : Form
    {
        public FormMain_ZZA()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int columns;

        DataService dataService = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = dataService.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_ZZA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_ZZA.Enabled = true;
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            FormAbout_ZZA formAbout = new FormAbout_ZZA();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZZA.ShowDialog();
            openFilePath = openFileDialogTask_ZZA.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_ZZA.ColumnCount = columns;
            dataGridViewInMatrix_ZZA.RowCount = rows;
            dataGridViewOutMatrix_ZZA.ColumnCount = columns;
            dataGridViewOutMatrix_ZZA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_ZZA.Columns[i].Width = 25;
                dataGridViewOutMatrix_ZZA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_ZZA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = dataService.GetMatrix(openFilePath);
            buttonDone_ZZA.Enabled = true;
        }

        private void buttonSave_SSV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ZZA.FileName = "OutPutFileTask7V18.csv";
            saveFileDialogMatrix_ZZA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ZZA.ShowDialog();

            string path = saveFileDialogMatrix_ZZA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_ZZA.RowCount;
            int columns = dataGridViewOutMatrix_ZZA.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutMatrix_ZZA.Rows[i].Cells[j].Value + " ";
                    }
                    else
                    {
                        str += dataGridViewOutMatrix_ZZA.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonOpenFile_SSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZZA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZZA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZZA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZZA.ToolTipTitle = "Справка";
        }
    }
}