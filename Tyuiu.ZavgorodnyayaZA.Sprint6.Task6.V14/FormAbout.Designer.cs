﻿namespace Tyuiu.ZavgorodnyayaZA.Sprint6.Task6.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_SSV = new System.Windows.Forms.Label();
            this.buttonOK_SSV = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SSV = new System.Windows.Forms.PictureBox();
            this.labelInfo_ZZA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SSV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_SSV
            // 
            this.labelInfo_SSV.AutoSize = true;
            this.labelInfo_SSV.Location = new System.Drawing.Point(136, 9);
            this.labelInfo_SSV.Name = "labelInfo_SSV";
            this.labelInfo_SSV.Size = new System.Drawing.Size(0, 13);
            this.labelInfo_SSV.TabIndex = 0;
            // 
            // buttonOK_SSV
            // 
            this.buttonOK_SSV.Location = new System.Drawing.Point(397, 176);
            this.buttonOK_SSV.Name = "buttonOK_SSV";
            this.buttonOK_SSV.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SSV.TabIndex = 1;
            this.buttonOK_SSV.Text = "Ок";
            this.buttonOK_SSV.UseVisualStyleBackColor = true;
            this.buttonOK_SSV.Click += new System.EventHandler(this.buttonOK_SSV_Click);
            // 
            // pictureBoxAvatar_SSV
            // 
            this.pictureBoxAvatar_SSV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SSV.Image")));
            this.pictureBoxAvatar_SSV.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxAvatar_SSV.Name = "pictureBoxAvatar_SSV";
            this.pictureBoxAvatar_SSV.Size = new System.Drawing.Size(143, 190);
            this.pictureBoxAvatar_SSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_SSV.TabIndex = 2;
            this.pictureBoxAvatar_SSV.TabStop = false;
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
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.labelInfo_ZZA);
            this.Controls.Add(this.pictureBoxAvatar_SSV);
            this.Controls.Add(this.buttonOK_SSV);
            this.Controls.Add(this.labelInfo_SSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_SSV;
        private System.Windows.Forms.Button buttonOK_SSV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SSV;
        private System.Windows.Forms.Label labelInfo_ZZA;
    }
}