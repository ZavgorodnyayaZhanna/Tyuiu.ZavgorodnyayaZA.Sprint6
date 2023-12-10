namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task7.V7
{
    partial class FormMain_SSV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SSV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_SSV = new System.Windows.Forms.Button();
            this.buttonSave_SSV = new System.Windows.Forms.Button();
            this.buttonDone_SSV = new System.Windows.Forms.Button();
            this.buttonOpenFile_SSV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxTask_SSV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SSV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxInput_SSV = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxResult_SSV = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_SSV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SSV = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewInMatrix_SSV = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutMatrix_SSV = new System.Windows.Forms.DataGridView();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTask_SSV.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxInput_SSV.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxResult_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_SSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_SSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_SSV);
            this.panel1.Controls.Add(this.buttonSave_SSV);
            this.panel1.Controls.Add(this.buttonDone_SSV);
            this.panel1.Controls.Add(this.buttonOpenFile_SSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 64);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_SSV
            // 
            this.buttonHelp_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SSV.Image")));
            this.buttonHelp_SSV.Location = new System.Drawing.Point(806, 3);
            this.buttonHelp_SSV.Name = "buttonHelp_SSV";
            this.buttonHelp_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_SSV.TabIndex = 1;
            this.toolTip_SSV.SetToolTip(this.buttonHelp_SSV, "Сведения о программе");
            this.buttonHelp_SSV.UseVisualStyleBackColor = true;
            this.buttonHelp_SSV.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            this.buttonHelp_SSV.MouseEnter += new System.EventHandler(this.buttonHelp_SSV_MouseEnter);
            // 
            // buttonSave_SSV
            // 
            this.buttonSave_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SSV.Enabled = false;
            this.buttonSave_SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SSV.Image")));
            this.buttonSave_SSV.Location = new System.Drawing.Point(165, 3);
            this.buttonSave_SSV.Name = "buttonSave_SSV";
            this.buttonSave_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonSave_SSV.TabIndex = 1;
            this.toolTip_SSV.SetToolTip(this.buttonSave_SSV, "Сохранить файл");
            this.buttonSave_SSV.UseVisualStyleBackColor = true;
            this.buttonSave_SSV.Click += new System.EventHandler(this.buttonSave_SSV_Click);
            this.buttonSave_SSV.MouseEnter += new System.EventHandler(this.buttonSave_SSV_MouseEnter);
            // 
            // buttonDone_SSV
            // 
            this.buttonDone_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SSV.Enabled = false;
            this.buttonDone_SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SSV.Image")));
            this.buttonDone_SSV.Location = new System.Drawing.Point(84, 3);
            this.buttonDone_SSV.Name = "buttonDone_SSV";
            this.buttonDone_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_SSV.TabIndex = 1;
            this.toolTip_SSV.SetToolTip(this.buttonDone_SSV, "Заменяет все значение в 9 столбце на 11\r\n");
            this.buttonDone_SSV.UseVisualStyleBackColor = true;
            this.buttonDone_SSV.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            this.buttonDone_SSV.MouseEnter += new System.EventHandler(this.buttonDone_SSV_MouseEnter);
            // 
            // buttonOpenFile_SSV
            // 
            this.buttonOpenFile_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_SSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SSV.Image")));
            this.buttonOpenFile_SSV.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_SSV.Name = "buttonOpenFile_SSV";
            this.buttonOpenFile_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_SSV.TabIndex = 1;
            this.toolTip_SSV.SetToolTip(this.buttonOpenFile_SSV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SSV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SSV.Click += new System.EventHandler(this.buttonOpenFile_SSV_Click);
            this.buttonOpenFile_SSV.MouseEnter += new System.EventHandler(this.buttonOpenFile_SSV_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_SSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 85);
            this.panel2.TabIndex = 0;
            // 
            // groupBoxTask_SSV
            // 
            this.groupBoxTask_SSV.Controls.Add(this.textBoxTask_SSV);
            this.groupBoxTask_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SSV.Name = "groupBoxTask_SSV";
            this.groupBoxTask_SSV.Size = new System.Drawing.Size(884, 85);
            this.groupBoxTask_SSV.TabIndex = 0;
            this.groupBoxTask_SSV.TabStop = false;
            this.groupBoxTask_SSV.Text = "Условие:";
            // 
            // textBoxTask_SSV
            // 
            this.textBoxTask_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SSV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SSV.Multiline = true;
            this.textBoxTask_SSV.Name = "textBoxTask_SSV";
            this.textBoxTask_SSV.ReadOnly = true;
            this.textBoxTask_SSV.Size = new System.Drawing.Size(878, 66);
            this.textBoxTask_SSV.TabIndex = 0;
            this.textBoxTask_SSV.Text = resources.GetString("textBoxTask_SSV.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInput_SSV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 362);
            this.panel3.TabIndex = 0;
            // 
            // groupBoxInput_SSV
            // 
            this.groupBoxInput_SSV.Controls.Add(this.dataGridViewInMatrix_SSV);
            this.groupBoxInput_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_SSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_SSV.Name = "groupBoxInput_SSV";
            this.groupBoxInput_SSV.Size = new System.Drawing.Size(430, 362);
            this.groupBoxInput_SSV.TabIndex = 0;
            this.groupBoxInput_SSV.TabStop = false;
            this.groupBoxInput_SSV.Text = "Ввод:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxResult_SSV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(430, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 362);
            this.panel4.TabIndex = 0;
            // 
            // groupBoxResult_SSV
            // 
            this.groupBoxResult_SSV.Controls.Add(this.dataGridViewOutMatrix_SSV);
            this.groupBoxResult_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SSV.Name = "groupBoxResult_SSV";
            this.groupBoxResult_SSV.Size = new System.Drawing.Size(454, 362);
            this.groupBoxResult_SSV.TabIndex = 0;
            this.groupBoxResult_SSV.TabStop = false;
            this.groupBoxResult_SSV.Text = "Вывод:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(430, 149);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 362);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_SSV
            // 
            this.openFileDialogTask_SSV.FileName = "openFileDialog1";
            // 
            // toolTip_SSV
            // 
            this.toolTip_SSV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SSV.ToolTipTitle = "Подсказка";
            // 
            // dataGridViewInMatrix_SSV
            // 
            this.dataGridViewInMatrix_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_SSV.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_SSV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInMatrix_SSV.Name = "dataGridViewInMatrix_SSV";
            this.dataGridViewInMatrix_SSV.RowHeadersVisible = false;
            this.dataGridViewInMatrix_SSV.Size = new System.Drawing.Size(424, 343);
            this.dataGridViewInMatrix_SSV.TabIndex = 0;
            // 
            // dataGridViewOutMatrix_SSV
            // 
            this.dataGridViewOutMatrix_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_SSV.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_SSV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutMatrix_SSV.Name = "dataGridViewOutMatrix_SSV";
            this.dataGridViewOutMatrix_SSV.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_SSV.Size = new System.Drawing.Size(448, 343);
            this.dataGridViewOutMatrix_SSV.TabIndex = 0;
            // 
            // FormMain_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 18 | Сбродов С. В";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxTask_SSV.ResumeLayout(false);
            this.groupBoxTask_SSV.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxInput_SSV.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxResult_SSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_SSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_SSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_SSV;
        private System.Windows.Forms.TextBox textBoxTask_SSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInput_SSV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxResult_SSV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_SSV;
        private System.Windows.Forms.Button buttonDone_SSV;
        private System.Windows.Forms.Button buttonOpenFile_SSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SSV;
        private System.Windows.Forms.ToolTip toolTip_SSV;
        private System.Windows.Forms.Button buttonSave_SSV;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_SSV;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_SSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}

