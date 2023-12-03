
namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task2.V20
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_ZZA = new System.Windows.Forms.GroupBox();
            this.labelYS2_ZZA = new System.Windows.Forms.Label();
            this.labelYS1_ZZA = new System.Windows.Forms.Label();
            this.groupBoxInputData_ZZA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_ZZA = new System.Windows.Forms.TextBox();
            this.labelEnd_ZZA = new System.Windows.Forms.Label();
            this.textBoxStartStep_ZZA = new System.Windows.Forms.TextBox();
            this.labelStart_ZZA = new System.Windows.Forms.Label();
            this.buttonHelp_ZZA = new System.Windows.Forms.Button();
            this.buttonDone_ZZA = new System.Windows.Forms.Button();
            this.groupBoxOutputData_ZZA = new System.Windows.Forms.GroupBox();
            this.chartFunction_ZZA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_ZZA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRES_ZZA = new System.Windows.Forms.Label();
            this.groupBoxTask_ZZA.SuspendLayout();
            this.groupBoxInputData_ZZA.SuspendLayout();
            this.groupBoxOutputData_ZZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZZA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZZA
            // 
            this.groupBoxTask_ZZA.Controls.Add(this.labelYS2_ZZA);
            this.groupBoxTask_ZZA.Controls.Add(this.labelYS1_ZZA);
            this.groupBoxTask_ZZA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZZA.Name = "groupBoxTask_ZZA";
            this.groupBoxTask_ZZA.Size = new System.Drawing.Size(546, 343);
            this.groupBoxTask_ZZA.TabIndex = 0;
            this.groupBoxTask_ZZA.TabStop = false;
            this.groupBoxTask_ZZA.Text = "Условие";
            // 
            // labelYS2_ZZA
            // 
            this.labelYS2_ZZA.AutoSize = true;
            this.labelYS2_ZZA.Location = new System.Drawing.Point(7, 37);
            this.labelYS2_ZZA.Name = "labelYS2_ZZA";
            this.labelYS2_ZZA.Size = new System.Drawing.Size(335, 13);
            this.labelYS2_ZZA.TabIndex = 1;
            this.labelYS2_ZZA.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // labelYS1_ZZA
            // 
            this.labelYS1_ZZA.AutoSize = true;
            this.labelYS1_ZZA.Location = new System.Drawing.Point(7, 20);
            this.labelYS1_ZZA.Name = "labelYS1_ZZA";
            this.labelYS1_ZZA.Size = new System.Drawing.Size(405, 13);
            this.labelYS1_ZZA.TabIndex = 0;
            this.labelYS1_ZZA.Text = "Протобулировать функцию (sin(x)/x+1,2 ) -sin(x) * 2 - 2x на заданном диапазоне.";
            // 
            // groupBoxInputData_ZZA
            // 
            this.groupBoxInputData_ZZA.Controls.Add(this.textBoxStopStep_ZZA);
            this.groupBoxInputData_ZZA.Controls.Add(this.labelEnd_ZZA);
            this.groupBoxInputData_ZZA.Controls.Add(this.textBoxStartStep_ZZA);
            this.groupBoxInputData_ZZA.Controls.Add(this.labelStart_ZZA);
            this.groupBoxInputData_ZZA.Location = new System.Drawing.Point(13, 362);
            this.groupBoxInputData_ZZA.Name = "groupBoxInputData_ZZA";
            this.groupBoxInputData_ZZA.Size = new System.Drawing.Size(274, 76);
            this.groupBoxInputData_ZZA.TabIndex = 1;
            this.groupBoxInputData_ZZA.TabStop = false;
            this.groupBoxInputData_ZZA.Text = "Ввод данных";
            // 
            // textBoxStopStep_ZZA
            // 
            this.textBoxStopStep_ZZA.Location = new System.Drawing.Point(136, 37);
            this.textBoxStopStep_ZZA.Name = "textBoxStopStep_ZZA";
            this.textBoxStopStep_ZZA.Size = new System.Drawing.Size(124, 20);
            this.textBoxStopStep_ZZA.TabIndex = 3;
            this.textBoxStopStep_ZZA.Text = "5";
            // 
            // labelEnd_ZZA
            // 
            this.labelEnd_ZZA.AutoSize = true;
            this.labelEnd_ZZA.Location = new System.Drawing.Point(133, 21);
            this.labelEnd_ZZA.Name = "labelEnd_ZZA";
            this.labelEnd_ZZA.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_ZZA.TabIndex = 2;
            this.labelEnd_ZZA.Text = "Конец шага:";
            // 
            // textBoxStartStep_ZZA
            // 
            this.textBoxStartStep_ZZA.Location = new System.Drawing.Point(6, 37);
            this.textBoxStartStep_ZZA.Name = "textBoxStartStep_ZZA";
            this.textBoxStartStep_ZZA.Size = new System.Drawing.Size(124, 20);
            this.textBoxStartStep_ZZA.TabIndex = 1;
            this.textBoxStartStep_ZZA.Text = "-5";
            // 
            // labelStart_ZZA
            // 
            this.labelStart_ZZA.AutoSize = true;
            this.labelStart_ZZA.Location = new System.Drawing.Point(7, 21);
            this.labelStart_ZZA.Name = "labelStart_ZZA";
            this.labelStart_ZZA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZZA.TabIndex = 0;
            this.labelStart_ZZA.Text = "Старт шага:";
            // 
            // buttonHelp_ZZA
            // 
            this.buttonHelp_ZZA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_ZZA.Location = new System.Drawing.Point(294, 363);
            this.buttonHelp_ZZA.Name = "buttonHelp_ZZA";
            this.buttonHelp_ZZA.Size = new System.Drawing.Size(99, 75);
            this.buttonHelp_ZZA.TabIndex = 2;
            this.buttonHelp_ZZA.Text = "Справка";
            this.buttonHelp_ZZA.UseVisualStyleBackColor = false;
            this.buttonHelp_ZZA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonDone_ZZA
            // 
            this.buttonDone_ZZA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ZZA.Location = new System.Drawing.Point(400, 363);
            this.buttonDone_ZZA.Name = "buttonDone_ZZA";
            this.buttonDone_ZZA.Size = new System.Drawing.Size(159, 75);
            this.buttonDone_ZZA.TabIndex = 3;
            this.buttonDone_ZZA.Text = "Выполнить";
            this.buttonDone_ZZA.UseVisualStyleBackColor = false;
            this.buttonDone_ZZA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            this.buttonDone_ZZA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MKA_MouseDown);
            this.buttonDone_ZZA.MouseEnter += new System.EventHandler(this.buttonDone_MKA_MouseEnter);
            this.buttonDone_ZZA.MouseLeave += new System.EventHandler(this.buttonDone_MKA_MouseLeave);
            // 
            // groupBoxOutputData_ZZA
            // 
            this.groupBoxOutputData_ZZA.Controls.Add(this.chartFunction_ZZA);
            this.groupBoxOutputData_ZZA.Controls.Add(this.dataGridViewFunction_ZZA);
            this.groupBoxOutputData_ZZA.Controls.Add(this.labelRES_ZZA);
            this.groupBoxOutputData_ZZA.Location = new System.Drawing.Point(566, 13);
            this.groupBoxOutputData_ZZA.Name = "groupBoxOutputData_ZZA";
            this.groupBoxOutputData_ZZA.Size = new System.Drawing.Size(704, 425);
            this.groupBoxOutputData_ZZA.TabIndex = 4;
            this.groupBoxOutputData_ZZA.TabStop = false;
            this.groupBoxOutputData_ZZA.Text = "Вывод данных";
            // 
            // chartFunction_ZZA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_ZZA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_ZZA.Legends.Add(legend2);
            this.chartFunction_ZZA.Location = new System.Drawing.Point(240, 35);
            this.chartFunction_ZZA.Name = "chartFunction_ZZA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_ZZA.Series.Add(series2);
            this.chartFunction_ZZA.Size = new System.Drawing.Size(458, 371);
            this.chartFunction_ZZA.TabIndex = 2;
            this.chartFunction_ZZA.Text = "chart1";
            // 
            // dataGridViewFunction_ZZA
            // 
            this.dataGridViewFunction_ZZA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_ZZA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_ZZA.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewFunction_ZZA.Name = "dataGridViewFunction_ZZA";
            this.dataGridViewFunction_ZZA.ReadOnly = true;
            this.dataGridViewFunction_ZZA.RowHeadersVisible = false;
            this.dataGridViewFunction_ZZA.Size = new System.Drawing.Size(193, 384);
            this.dataGridViewFunction_ZZA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // labelRES_ZZA
            // 
            this.labelRES_ZZA.AutoSize = true;
            this.labelRES_ZZA.Location = new System.Drawing.Point(7, 19);
            this.labelRES_ZZA.Name = "labelRES_ZZA";
            this.labelRES_ZZA.Size = new System.Drawing.Size(62, 13);
            this.labelRES_ZZA.TabIndex = 0;
            this.labelRES_ZZA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 450);
            this.Controls.Add(this.groupBoxOutputData_ZZA);
            this.Controls.Add(this.buttonDone_ZZA);
            this.Controls.Add(this.buttonHelp_ZZA);
            this.Controls.Add(this.groupBoxInputData_ZZA);
            this.Controls.Add(this.groupBoxTask_ZZA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 20 |  Завгородняя Ж. А.";
            this.groupBoxTask_ZZA.ResumeLayout(false);
            this.groupBoxTask_ZZA.PerformLayout();
            this.groupBoxInputData_ZZA.ResumeLayout(false);
            this.groupBoxInputData_ZZA.PerformLayout();
            this.groupBoxOutputData_ZZA.ResumeLayout(false);
            this.groupBoxOutputData_ZZA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZZA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZZA;
        private System.Windows.Forms.Label labelYS2_ZZA;
        private System.Windows.Forms.Label labelYS1_ZZA;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZZA;
        private System.Windows.Forms.Label labelStart_ZZA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZZA;
        private System.Windows.Forms.Label labelEnd_ZZA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZZA;
        private System.Windows.Forms.Button buttonHelp_ZZA;
        private System.Windows.Forms.Button buttonDone_ZZA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZZA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZZA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_ZZA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Label labelRES_ZZA;
    }
}