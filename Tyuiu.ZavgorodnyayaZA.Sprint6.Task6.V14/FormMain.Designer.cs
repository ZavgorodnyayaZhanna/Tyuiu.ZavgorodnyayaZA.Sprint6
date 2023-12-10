namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_ZZA));
            this.panelUp_ZZA = new System.Windows.Forms.Panel();
            this.buttonHelp_ZZA = new System.Windows.Forms.Button();
            this.buttonDone_ZZA = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZZA = new System.Windows.Forms.Button();
            this.panelUp2_ZZA = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZZA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZZA = new System.Windows.Forms.TextBox();
            this.panelLeft_ZZA = new System.Windows.Forms.Panel();
            this.groupBoxInput_ZZA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_ZZA = new System.Windows.Forms.TextBox();
            this.panelFill_ZZA = new System.Windows.Forms.Panel();
            this.groupBoxResult_ZZA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZZA = new System.Windows.Forms.TextBox();
            this.splitter_ZZA = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_ZZA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_ZZA = new System.Windows.Forms.ToolTip(this.components);
            this.panelUp_ZZA.SuspendLayout();
            this.panelUp2_ZZA.SuspendLayout();
            this.groupBoxTask_ZZA.SuspendLayout();
            this.panelLeft_ZZA.SuspendLayout();
            this.groupBoxInput_ZZA.SuspendLayout();
            this.panelFill_ZZA.SuspendLayout();
            this.groupBoxResult_ZZA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp_ZZA
            // 
            this.panelUp_ZZA.Controls.Add(this.buttonHelp_ZZA);
            this.panelUp_ZZA.Controls.Add(this.buttonDone_ZZA);
            this.panelUp_ZZA.Controls.Add(this.buttonOpenFile_ZZA);
            this.panelUp_ZZA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ZZA.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ZZA.Name = "panelUp_ZZA";
            this.panelUp_ZZA.Size = new System.Drawing.Size(884, 64);
            this.panelUp_ZZA.TabIndex = 0;
            // 
            // buttonHelp_ZZA
            // 
            this.buttonHelp_ZZA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZZA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_ZZA.Image")));
            this.buttonHelp_ZZA.Location = new System.Drawing.Point(806, 3);
            this.buttonHelp_ZZA.Name = "buttonHelp_ZZA";
            this.buttonHelp_ZZA.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_ZZA.TabIndex = 1;
            this.toolTip_ZZA.SetToolTip(this.buttonHelp_ZZA, "Сведения о программе");
            this.buttonHelp_ZZA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZZA.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // buttonDone_ZZA
            // 
            this.buttonDone_ZZA.Enabled = false;
            this.buttonDone_ZZA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_ZZA.Image")));
            this.buttonDone_ZZA.Location = new System.Drawing.Point(84, 3);
            this.buttonDone_ZZA.Name = "buttonDone_ZZA";
            this.buttonDone_ZZA.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_ZZA.TabIndex = 1;
            this.toolTip_ZZA.SetToolTip(this.buttonDone_ZZA, "Выводит перове слово каждой строки\r\n");
            this.buttonDone_ZZA.UseVisualStyleBackColor = true;
            this.buttonDone_ZZA.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // buttonOpenFile_ZZA
            // 
            this.buttonOpenFile_ZZA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_ZZA.Image")));
            this.buttonOpenFile_ZZA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_ZZA.Name = "buttonOpenFile_ZZA";
            this.buttonOpenFile_ZZA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_ZZA.TabIndex = 1;
            this.toolTip_ZZA.SetToolTip(this.buttonOpenFile_ZZA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_ZZA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZZA.Click += new System.EventHandler(this.buttonOpenFile_SSV_Click);
            // 
            // panelUp2_ZZA
            // 
            this.panelUp2_ZZA.Controls.Add(this.groupBoxTask_ZZA);
            this.panelUp2_ZZA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp2_ZZA.Location = new System.Drawing.Point(0, 64);
            this.panelUp2_ZZA.Name = "panelUp2_ZZA";
            this.panelUp2_ZZA.Size = new System.Drawing.Size(884, 85);
            this.panelUp2_ZZA.TabIndex = 0;
            // 
            // groupBoxTask_ZZA
            // 
            this.groupBoxTask_ZZA.Controls.Add(this.textBoxTask_ZZA);
            this.groupBoxTask_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ZZA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ZZA.Name = "groupBoxTask_ZZA";
            this.groupBoxTask_ZZA.Size = new System.Drawing.Size(884, 85);
            this.groupBoxTask_ZZA.TabIndex = 0;
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
            this.textBoxTask_ZZA.Size = new System.Drawing.Size(878, 66);
            this.textBoxTask_ZZA.TabIndex = 0;
            this.textBoxTask_ZZA.Text = "Дан файл InPutFileTask6V14.txt, который может находится в любом месте на диске. З" +
    "агрузить файл в textBoxIn через openFileDialog. Вывести первое слово из каждой с" +
    "трочки в textBoxOut";
            // 
            // panelLeft_ZZA
            // 
            this.panelLeft_ZZA.Controls.Add(this.groupBoxInput_ZZA);
            this.panelLeft_ZZA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_ZZA.Location = new System.Drawing.Point(0, 149);
            this.panelLeft_ZZA.Name = "panelLeft_ZZA";
            this.panelLeft_ZZA.Size = new System.Drawing.Size(430, 362);
            this.panelLeft_ZZA.TabIndex = 0;
            // 
            // groupBoxInput_ZZA
            // 
            this.groupBoxInput_ZZA.Controls.Add(this.textBoxInput_ZZA);
            this.groupBoxInput_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_ZZA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_ZZA.Name = "groupBoxInput_ZZA";
            this.groupBoxInput_ZZA.Size = new System.Drawing.Size(430, 362);
            this.groupBoxInput_ZZA.TabIndex = 0;
            this.groupBoxInput_ZZA.TabStop = false;
            this.groupBoxInput_ZZA.Text = "Ввод:";
            // 
            // textBoxInput_ZZA
            // 
            this.textBoxInput_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_ZZA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_ZZA.Multiline = true;
            this.textBoxInput_ZZA.Name = "textBoxInput_ZZA";
            this.textBoxInput_ZZA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_ZZA.Size = new System.Drawing.Size(424, 343);
            this.textBoxInput_ZZA.TabIndex = 0;
            // 
            // panelFill_ZZA
            // 
            this.panelFill_ZZA.Controls.Add(this.groupBoxResult_ZZA);
            this.panelFill_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_ZZA.Location = new System.Drawing.Point(430, 149);
            this.panelFill_ZZA.Name = "panelFill_ZZA";
            this.panelFill_ZZA.Size = new System.Drawing.Size(454, 362);
            this.panelFill_ZZA.TabIndex = 0;
            // 
            // groupBoxResult_ZZA
            // 
            this.groupBoxResult_ZZA.Controls.Add(this.textBoxResult_ZZA);
            this.groupBoxResult_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_ZZA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_ZZA.Name = "groupBoxResult_ZZA";
            this.groupBoxResult_ZZA.Size = new System.Drawing.Size(454, 362);
            this.groupBoxResult_ZZA.TabIndex = 0;
            this.groupBoxResult_ZZA.TabStop = false;
            this.groupBoxResult_ZZA.Text = "Вывод:";
            // 
            // textBoxResult_ZZA
            // 
            this.textBoxResult_ZZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ZZA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_ZZA.Multiline = true;
            this.textBoxResult_ZZA.Name = "textBoxResult_ZZA";
            this.textBoxResult_ZZA.ReadOnly = true;
            this.textBoxResult_ZZA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZZA.Size = new System.Drawing.Size(448, 343);
            this.textBoxResult_ZZA.TabIndex = 0;
            // 
            // splitter_ZZA
            // 
            this.splitter_ZZA.Location = new System.Drawing.Point(430, 149);
            this.splitter_ZZA.Name = "splitter_ZZA";
            this.splitter_ZZA.Size = new System.Drawing.Size(3, 362);
            this.splitter_ZZA.TabIndex = 1;
            this.splitter_ZZA.TabStop = false;
            // 
            // openFileDialogTask_ZZA
            // 
            this.openFileDialogTask_ZZA.FileName = "openFileDialog1";
            // 
            // toolTip_ZZA
            // 
            this.toolTip_ZZA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_ZZA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_ZZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitter_ZZA);
            this.Controls.Add(this.panelFill_ZZA);
            this.Controls.Add(this.panelLeft_ZZA);
            this.Controls.Add(this.panelUp2_ZZA);
            this.Controls.Add(this.panelUp_ZZA);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain_ZZA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 |  Завгородняя Ж. А.";
            this.panelUp_ZZA.ResumeLayout(false);
            this.panelUp2_ZZA.ResumeLayout(false);
            this.groupBoxTask_ZZA.ResumeLayout(false);
            this.groupBoxTask_ZZA.PerformLayout();
            this.panelLeft_ZZA.ResumeLayout(false);
            this.groupBoxInput_ZZA.ResumeLayout(false);
            this.groupBoxInput_ZZA.PerformLayout();
            this.panelFill_ZZA.ResumeLayout(false);
            this.groupBoxResult_ZZA.ResumeLayout(false);
            this.groupBoxResult_ZZA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_ZZA;
        private System.Windows.Forms.Panel panelUp2_ZZA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZZA;
        private System.Windows.Forms.TextBox textBoxTask_ZZA;
        private System.Windows.Forms.Panel panelLeft_ZZA;
        private System.Windows.Forms.GroupBox groupBoxInput_ZZA;
        private System.Windows.Forms.TextBox textBoxInput_ZZA;
        private System.Windows.Forms.Panel panelFill_ZZA;
        private System.Windows.Forms.GroupBox groupBoxResult_ZZA;
        private System.Windows.Forms.TextBox textBoxResult_ZZA;
        private System.Windows.Forms.Splitter splitter_ZZA;
        private System.Windows.Forms.Button buttonHelp_ZZA;
        private System.Windows.Forms.Button buttonDone_ZZA;
        private System.Windows.Forms.Button buttonOpenFile_ZZA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZZA;
        private System.Windows.Forms.ToolTip toolTip_ZZA;
    }
}

