﻿namespace SerialPortDebug
{
    partial class FormWave
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
            this.pictureBoxWave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWave
            // 
            this.pictureBoxWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBoxWave.Location = new System.Drawing.Point(2, 3);
            this.pictureBoxWave.Name = "pictureBoxWave";
            this.pictureBoxWave.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxWave.TabIndex = 0;
            this.pictureBoxWave.TabStop = false;
            // 
            // FormWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(644, 486);
            this.Controls.Add(this.pictureBoxWave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormWave";
            this.Text = "FormWave";
            this.Load += new System.EventHandler(this.FormWave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWave;
    }
}