namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14
{
    partial class FormAbout_ZZA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_ZZA));
            this.labelText_ZZA = new System.Windows.Forms.Label();
            this.buttonOK_ZZA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_ZZA = new System.Windows.Forms.PictureBox();
            this.labelInfo_ZZA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZZA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText_ZZA
            // 
            this.labelText_ZZA.AutoSize = true;
            this.labelText_ZZA.Location = new System.Drawing.Point(136, 9);
            this.labelText_ZZA.Name = "labelText_ZZA";
            this.labelText_ZZA.Size = new System.Drawing.Size(0, 13);
            this.labelText_ZZA.TabIndex = 0;
            // 
            // buttonOK_ZZA
            // 
            this.buttonOK_ZZA.Location = new System.Drawing.Point(397, 176);
            this.buttonOK_ZZA.Name = "buttonOK_ZZA";
            this.buttonOK_ZZA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_ZZA.TabIndex = 1;
            this.buttonOK_ZZA.Text = "Ок";
            this.buttonOK_ZZA.UseVisualStyleBackColor = true;
            this.buttonOK_ZZA.Click += new System.EventHandler(this.buttonOK_SSV_Click);
            // 
            // pictureBoxAvatar_ZZA
            // 
            this.pictureBoxAvatar_ZZA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_ZZA.Image")));
            this.pictureBoxAvatar_ZZA.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxAvatar_ZZA.Name = "pictureBoxAvatar_ZZA";
            this.pictureBoxAvatar_ZZA.Size = new System.Drawing.Size(143, 190);
            this.pictureBoxAvatar_ZZA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_ZZA.TabIndex = 2;
            this.pictureBoxAvatar_ZZA.TabStop = false;
            // 
            // labelInfo_ZZA
            // 
            this.labelInfo_ZZA.AutoSize = true;
            this.labelInfo_ZZA.Location = new System.Drawing.Point(175, 39);
            this.labelInfo_ZZA.Name = "labelInfo_ZZA";
            this.labelInfo_ZZA.Size = new System.Drawing.Size(297, 117);
            this.labelInfo_ZZA.TabIndex = 3;
            this.labelInfo_ZZA.Text = resources.GetString("labelInfo_ZZA.Text");
            // 
            // FormAbout_ZZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.labelInfo_ZZA);
            this.Controls.Add(this.pictureBoxAvatar_ZZA);
            this.Controls.Add(this.buttonOK_ZZA);
            this.Controls.Add(this.labelText_ZZA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_ZZA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZZA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText_ZZA;
        private System.Windows.Forms.Button buttonOK_ZZA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_ZZA;
        private System.Windows.Forms.Label labelInfo_ZZA;
    }
}