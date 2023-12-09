namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task4.V5
{
    partial class FormMain_ZZA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxResult_ZZA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZZA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ZZA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZZA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_ZZA = new System.Windows.Forms.GroupBox();
            this.labelStop_ZZA = new System.Windows.Forms.Label();
            this.labelStart_ZZA = new System.Windows.Forms.Label();
            this.textBoxStopStep_ZZA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_ZZA = new System.Windows.Forms.TextBox();
            this.buttonDone_ZZA = new System.Windows.Forms.Button();
            this.buttonSave_ZZA = new System.Windows.Forms.Button();
            this.buttonHelp_ZZA = new System.Windows.Forms.Button();
            this.chartFunction_ZZA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_ZZA = new System.Windows.Forms.Panel();
            this.panelUp_ZZA = new System.Windows.Forms.Panel();
            this.panelFill_ZZA = new System.Windows.Forms.Panel();
            this.groupBoxResult_ZZA.SuspendLayout();
            this.groupBoxTask_ZZA.SuspendLayout();
            this.groupBoxInput_ZZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZZA)).BeginInit();
            this.panelLeft_ZZA.SuspendLayout();
            this.panelUp_ZZA.SuspendLayout();
            this.panelFill_ZZA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult_ZZA
            // 
            this.groupBoxResult_ZZA.Controls.Add(this.textBoxResult_ZZA);
            this.groupBoxResult_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_ZZA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_ZZA.Name = "groupBoxResult_ZZA";
            this.groupBoxResult_ZZA.Size = new System.Drawing.Size(270, 462);
            this.groupBoxResult_ZZA.TabIndex = 0;
            this.groupBoxResult_ZZA.TabStop = false;
            this.groupBoxResult_ZZA.Text = "Вывод:";
            // 
            // textBoxResult_ZZA
            // 
            this.textBoxResult_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ZZA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_ZZA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxResult_ZZA.Multiline = true;
            this.textBoxResult_ZZA.Name = "textBoxResult_ZZA";
            this.textBoxResult_ZZA.ReadOnly = true;
            this.textBoxResult_ZZA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZZA.Size = new System.Drawing.Size(264, 443);
            this.textBoxResult_ZZA.TabIndex = 0;
            // 
            // groupBoxTask_ZZA
            // 
            this.groupBoxTask_ZZA.Controls.Add(this.textBoxTask_ZZA);
            this.groupBoxTask_ZZA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_ZZA.Name = "groupBoxTask_ZZA";
            this.groupBoxTask_ZZA.Size = new System.Drawing.Size(436, 62);
            this.groupBoxTask_ZZA.TabIndex = 1;
            this.groupBoxTask_ZZA.TabStop = false;
            this.groupBoxTask_ZZA.Text = "Условие:";
            // 
            // textBoxTask_ZZA
            // 
            this.textBoxTask_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZZA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZZA.Multiline = true;
            this.textBoxTask_ZZA.Name = "textBoxTask_ZZA";
            this.textBoxTask_ZZA.ReadOnly = true;
            this.textBoxTask_ZZA.Size = new System.Drawing.Size(430, 43);
            this.textBoxTask_ZZA.TabIndex = 0;
            this.textBoxTask_ZZA.Text = "Протабулировать функцию f(x) а заданном диапозоне от -5 до 5.\r\nРезультат вывести " +
    "в textBox. Построить график функции и сохранить в файл\r\nOutPutTask4V5.txt по наж" +
    "атию кнопки.\r\n\r\n";
            // 
            // groupBoxInput_ZZA
            // 
            this.groupBoxInput_ZZA.Controls.Add(this.labelStop_ZZA);
            this.groupBoxInput_ZZA.Controls.Add(this.labelStart_ZZA);
            this.groupBoxInput_ZZA.Controls.Add(this.textBoxStopStep_ZZA);
            this.groupBoxInput_ZZA.Controls.Add(this.textBoxStartStep_ZZA);
            this.groupBoxInput_ZZA.Location = new System.Drawing.Point(445, 3);
            this.groupBoxInput_ZZA.Name = "groupBoxInput_ZZA";
            this.groupBoxInput_ZZA.Size = new System.Drawing.Size(258, 62);
            this.groupBoxInput_ZZA.TabIndex = 1;
            this.groupBoxInput_ZZA.TabStop = false;
            this.groupBoxInput_ZZA.Text = "Ввод данных:";
            // 
            // labelStop_ZZA
            // 
            this.labelStop_ZZA.AutoSize = true;
            this.labelStop_ZZA.Location = new System.Drawing.Point(126, 12);
            this.labelStop_ZZA.Name = "labelStop_ZZA";
            this.labelStop_ZZA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZZA.TabIndex = 1;
            this.labelStop_ZZA.Text = "Конец шага:";
            // 
            // labelStart_ZZA
            // 
            this.labelStart_ZZA.AutoSize = true;
            this.labelStart_ZZA.Location = new System.Drawing.Point(6, 13);
            this.labelStart_ZZA.Name = "labelStart_ZZA";
            this.labelStart_ZZA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZZA.TabIndex = 1;
            this.labelStart_ZZA.Text = "Старт шага:";
            // 
            // textBoxStopStep_ZZA
            // 
            this.textBoxStopStep_ZZA.Location = new System.Drawing.Point(129, 28);
            this.textBoxStopStep_ZZA.Name = "textBoxStopStep_ZZA";
            this.textBoxStopStep_ZZA.Size = new System.Drawing.Size(123, 20);
            this.textBoxStopStep_ZZA.TabIndex = 0;
            this.textBoxStopStep_ZZA.Text = "5";
            // 
            // textBoxStartStep_ZZA
            // 
            this.textBoxStartStep_ZZA.Location = new System.Drawing.Point(6, 29);
            this.textBoxStartStep_ZZA.Name = "textBoxStartStep_ZZA";
            this.textBoxStartStep_ZZA.Size = new System.Drawing.Size(117, 20);
            this.textBoxStartStep_ZZA.TabIndex = 0;
            this.textBoxStartStep_ZZA.Text = "-5";
            // 
            // buttonDone_ZZA
            // 
            this.buttonDone_ZZA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ZZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_ZZA.Location = new System.Drawing.Point(709, 3);
            this.buttonDone_ZZA.Name = "buttonDone_ZZA";
            this.buttonDone_ZZA.Size = new System.Drawing.Size(75, 61);
            this.buttonDone_ZZA.TabIndex = 2;
            this.buttonDone_ZZA.Text = "Выполнить";
            this.buttonDone_ZZA.UseVisualStyleBackColor = false;
            this.buttonDone_ZZA.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // buttonSave_ZZA
            // 
            this.buttonSave_ZZA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_ZZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_ZZA.Location = new System.Drawing.Point(786, 3);
            this.buttonSave_ZZA.Name = "buttonSave_ZZA";
            this.buttonSave_ZZA.Size = new System.Drawing.Size(75, 61);
            this.buttonSave_ZZA.TabIndex = 3;
            this.buttonSave_ZZA.Text = "Сохранить";
            this.buttonSave_ZZA.UseVisualStyleBackColor = false;
            this.buttonSave_ZZA.Click += new System.EventHandler(this.buttonSave_SSV_Click);
            // 
            // buttonHelp_ZZA
            // 
            this.buttonHelp_ZZA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZZA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_ZZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_ZZA.Location = new System.Drawing.Point(882, 15);
            this.buttonHelp_ZZA.Name = "buttonHelp_ZZA";
            this.buttonHelp_ZZA.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp_ZZA.TabIndex = 4;
            this.buttonHelp_ZZA.Text = "Справка";
            this.buttonHelp_ZZA.UseVisualStyleBackColor = false;
            this.buttonHelp_ZZA.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // chartFunction_ZZA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_ZZA.ChartAreas.Add(chartArea3);
            this.chartFunction_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartFunction_ZZA.Legends.Add(legend3);
            this.chartFunction_ZZA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ZZA.Name = "chartFunction_ZZA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_ZZA.Series.Add(series3);
            this.chartFunction_ZZA.Size = new System.Drawing.Size(669, 467);
            this.chartFunction_ZZA.TabIndex = 5;
            this.chartFunction_ZZA.Text = "chartFunction_SSV";
            title3.Name = "Title1";
            title3.Text = "График функции f(x)";
            this.chartFunction_ZZA.Titles.Add(title3);
            // 
            // panelLeft_ZZA
            // 
            this.panelLeft_ZZA.Controls.Add(this.groupBoxResult_ZZA);
            this.panelLeft_ZZA.Location = new System.Drawing.Point(12, 86);
            this.panelLeft_ZZA.Name = "panelLeft_ZZA";
            this.panelLeft_ZZA.Size = new System.Drawing.Size(270, 462);
            this.panelLeft_ZZA.TabIndex = 1;
            // 
            // panelUp_ZZA
            // 
            this.panelUp_ZZA.Controls.Add(this.groupBoxTask_ZZA);
            this.panelUp_ZZA.Controls.Add(this.groupBoxInput_ZZA);
            this.panelUp_ZZA.Controls.Add(this.buttonDone_ZZA);
            this.panelUp_ZZA.Controls.Add(this.buttonSave_ZZA);
            this.panelUp_ZZA.Location = new System.Drawing.Point(12, 12);
            this.panelUp_ZZA.Name = "panelUp_ZZA";
            this.panelUp_ZZA.Size = new System.Drawing.Size(864, 68);
            this.panelUp_ZZA.TabIndex = 6;
            // 
            // panelFill_ZZA
            // 
            this.panelFill_ZZA.Controls.Add(this.chartFunction_ZZA);
            this.panelFill_ZZA.Location = new System.Drawing.Point(288, 86);
            this.panelFill_ZZA.Name = "panelFill_ZZA";
            this.panelFill_ZZA.Size = new System.Drawing.Size(669, 467);
            this.panelFill_ZZA.TabIndex = 7;
            // 
            // FormMain_ZZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 560);
            this.Controls.Add(this.panelFill_ZZA);
            this.Controls.Add(this.panelUp_ZZA);
            this.Controls.Add(this.panelLeft_ZZA);
            this.Controls.Add(this.buttonHelp_ZZA);
            this.MinimumSize = new System.Drawing.Size(985, 450);
            this.Name = "FormMain_ZZA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 5 |  Завгородняя Ж. А.";
            this.groupBoxResult_ZZA.ResumeLayout(false);
            this.groupBoxResult_ZZA.PerformLayout();
            this.groupBoxTask_ZZA.ResumeLayout(false);
            this.groupBoxTask_ZZA.PerformLayout();
            this.groupBoxInput_ZZA.ResumeLayout(false);
            this.groupBoxInput_ZZA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZZA)).EndInit();
            this.panelLeft_ZZA.ResumeLayout(false);
            this.panelUp_ZZA.ResumeLayout(false);
            this.panelFill_ZZA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_ZZA;
        private System.Windows.Forms.TextBox textBoxResult_ZZA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZZA;
        private System.Windows.Forms.GroupBox groupBoxInput_ZZA;
        private System.Windows.Forms.Button buttonDone_ZZA;
        private System.Windows.Forms.Button buttonSave_ZZA;
        private System.Windows.Forms.Button buttonHelp_ZZA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZZA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZZA;
        private System.Windows.Forms.Label labelStop_ZZA;
        private System.Windows.Forms.Label labelStart_ZZA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZZA;
        private System.Windows.Forms.TextBox textBoxTask_ZZA;
        private System.Windows.Forms.Panel panelLeft_ZZA;
        private System.Windows.Forms.Panel panelUp_ZZA;
        private System.Windows.Forms.Panel panelFill_ZZA;
    }
}

