namespace SerialPortDebug
{
    partial class FormSafety
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
            this.labelMachineCodes = new System.Windows.Forms.Label();
            this.labelRegistrationCodes = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRegistrationCancel = new System.Windows.Forms.Button();
            this.textBoxMachineCodes = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationCodes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMachineCodes
            // 
            this.labelMachineCodes.AutoSize = true;
            this.labelMachineCodes.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMachineCodes.Location = new System.Drawing.Point(30, 38);
            this.labelMachineCodes.Name = "labelMachineCodes";
            this.labelMachineCodes.Size = new System.Drawing.Size(66, 19);
            this.labelMachineCodes.TabIndex = 0;
            this.labelMachineCodes.Text = "机器码";
            // 
            // labelRegistrationCodes
            // 
            this.labelRegistrationCodes.AutoSize = true;
            this.labelRegistrationCodes.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRegistrationCodes.Location = new System.Drawing.Point(30, 78);
            this.labelRegistrationCodes.Name = "labelRegistrationCodes";
            this.labelRegistrationCodes.Size = new System.Drawing.Size(66, 19);
            this.labelRegistrationCodes.TabIndex = 1;
            this.labelRegistrationCodes.Text = "注册码";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRegister.Location = new System.Drawing.Point(34, 120);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(108, 30);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "注册";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonRegistrationCancel
            // 
            this.buttonRegistrationCancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRegistrationCancel.Location = new System.Drawing.Point(157, 120);
            this.buttonRegistrationCancel.Name = "buttonRegistrationCancel";
            this.buttonRegistrationCancel.Size = new System.Drawing.Size(113, 30);
            this.buttonRegistrationCancel.TabIndex = 3;
            this.buttonRegistrationCancel.Text = "取消";
            this.buttonRegistrationCancel.UseVisualStyleBackColor = true;
            this.buttonRegistrationCancel.Click += new System.EventHandler(this.buttonRegistrationCancel_Click);
            // 
            // textBoxMachineCodes
            // 
            this.textBoxMachineCodes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMachineCodes.Location = new System.Drawing.Point(111, 37);
            this.textBoxMachineCodes.Multiline = true;
            this.textBoxMachineCodes.Name = "textBoxMachineCodes";
            this.textBoxMachineCodes.Size = new System.Drawing.Size(159, 21);
            this.textBoxMachineCodes.TabIndex = 4;
            // 
            // textBoxRegistrationCodes
            // 
            this.textBoxRegistrationCodes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRegistrationCodes.Location = new System.Drawing.Point(111, 76);
            this.textBoxRegistrationCodes.Multiline = true;
            this.textBoxRegistrationCodes.Name = "textBoxRegistrationCodes";
            this.textBoxRegistrationCodes.Size = new System.Drawing.Size(159, 21);
            this.textBoxRegistrationCodes.TabIndex = 5;
            // 
            // FormSafety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(306, 172);
            this.Controls.Add(this.textBoxRegistrationCodes);
            this.Controls.Add(this.textBoxMachineCodes);
            this.Controls.Add(this.buttonRegistrationCancel);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegistrationCodes);
            this.Controls.Add(this.labelMachineCodes);
            this.MaximizeBox = false;
            this.Name = "FormSafety";
            this.Text = "首次使用，请注册";
            this.Load += new System.EventHandler(this.FormSafety_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMachineCodes;
        private System.Windows.Forms.Label labelRegistrationCodes;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonRegistrationCancel;
        private System.Windows.Forms.TextBox textBoxMachineCodes;
        private System.Windows.Forms.TextBox textBoxRegistrationCodes;
    }
}