namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task3.V3
{
    partial class FormMain
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
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxdData_ZZA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonDone_ZZA = new System.Windows.Forms.Button();
            this.buttonHelp_ZZA = new System.Windows.Forms.Button();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Location = new System.Drawing.Point(423, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(166, 185);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 16);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.Location = new System.Drawing.Point(9, 32);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.Size = new System.Drawing.Size(151, 147);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBoxdData_ZZA);
            this.groupBoxData.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(405, 209);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Условие";
            // 
            // textBoxdData_ZZA
            // 
            this.textBoxdData_ZZA.Location = new System.Drawing.Point(7, 20);
            this.textBoxdData_ZZA.Multiline = true;
            this.textBoxdData_ZZA.Name = "textBoxdData_ZZA";
            this.textBoxdData_ZZA.ReadOnly = true;
            this.textBoxdData_ZZA.Size = new System.Drawing.Size(235, 183);
            this.textBoxdData_ZZA.TabIndex = 1;
            this.textBoxdData_ZZA.Text = "Дана матрица 5 на 5\r\n-18  21  10  -2  12\r\n -18 -10  33 -20  32\r\n  14 -15 -14  12 " +
    "-18\r\n -19   5  -3  28 -17\r\n -14  -9  23 -13  11\r\nВыполнить сортировку по возраст" +
    "анию во втором столбце";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(248, 10);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(150, 193);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // buttonDone_ZZA
            // 
            this.buttonDone_ZZA.Location = new System.Drawing.Point(518, 203);
            this.buttonDone_ZZA.Name = "buttonDone_ZZA";
            this.buttonDone_ZZA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_ZZA.TabIndex = 16;
            this.buttonDone_ZZA.Text = "Выполнить";
            this.buttonDone_ZZA.UseVisualStyleBackColor = true;
            this.buttonDone_ZZA.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // buttonHelp_ZZA
            // 
            this.buttonHelp_ZZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ZZA.Location = new System.Drawing.Point(423, 203);
            this.buttonHelp_ZZA.Name = "buttonHelp_ZZA";
            this.buttonHelp_ZZA.Size = new System.Drawing.Size(23, 23);
            this.buttonHelp_ZZA.TabIndex = 2;
            this.buttonHelp_ZZA.Text = "?";
            this.buttonHelp_ZZA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZZA.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 233);
            this.Controls.Add(this.buttonHelp_ZZA);
            this.Controls.Add(this.buttonDone_ZZA);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 3 |  Завгородняя Ж. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxdData_ZZA;
        private System.Windows.Forms.Button buttonDone_ZZA;
        private System.Windows.Forms.Button buttonHelp_ZZA;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

