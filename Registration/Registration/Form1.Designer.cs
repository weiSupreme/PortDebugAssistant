namespace Registration
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMachineCodes = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationCodes = new System.Windows.Forms.TextBox();
            this.buttonProduceRegisterCodes = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "机器码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "注册码";
            // 
            // textBoxMachineCodes
            // 
            this.textBoxMachineCodes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMachineCodes.Location = new System.Drawing.Point(148, 39);
            this.textBoxMachineCodes.Multiline = true;
            this.textBoxMachineCodes.Name = "textBoxMachineCodes";
            this.textBoxMachineCodes.Size = new System.Drawing.Size(149, 21);
            this.textBoxMachineCodes.TabIndex = 2;
            // 
            // textBoxRegistrationCodes
            // 
            this.textBoxRegistrationCodes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRegistrationCodes.Location = new System.Drawing.Point(148, 98);
            this.textBoxRegistrationCodes.Multiline = true;
            this.textBoxRegistrationCodes.Name = "textBoxRegistrationCodes";
            this.textBoxRegistrationCodes.Size = new System.Drawing.Size(149, 21);
            this.textBoxRegistrationCodes.TabIndex = 3;
            // 
            // buttonProduceRegisterCodes
            // 
            this.buttonProduceRegisterCodes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonProduceRegisterCodes.Location = new System.Drawing.Point(45, 160);
            this.buttonProduceRegisterCodes.Name = "buttonProduceRegisterCodes";
            this.buttonProduceRegisterCodes.Size = new System.Drawing.Size(102, 31);
            this.buttonProduceRegisterCodes.TabIndex = 4;
            this.buttonProduceRegisterCodes.Text = "生成注册码";
            this.buttonProduceRegisterCodes.UseVisualStyleBackColor = true;
            this.buttonProduceRegisterCodes.Click += new System.EventHandler(this.buttonProduceRegisterCodes_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.Location = new System.Drawing.Point(190, 160);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 31);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "退出";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(351, 211);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProduceRegisterCodes);
            this.Controls.Add(this.textBoxRegistrationCodes);
            this.Controls.Add(this.textBoxMachineCodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "注册机";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMachineCodes;
        private System.Windows.Forms.TextBox textBoxRegistrationCodes;
        private System.Windows.Forms.Button buttonProduceRegisterCodes;
        private System.Windows.Forms.Button buttonClose;
    }
}

