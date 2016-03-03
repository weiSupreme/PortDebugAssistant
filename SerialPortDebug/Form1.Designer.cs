namespace SerialPortDebug
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxInitialization = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxByteSize = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelByteSize = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.groupBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.checkBoxSendEndEnter = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoClearReceivingBox = new System.Windows.Forms.CheckBox();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxHexShow = new System.Windows.Forms.CheckBox();
            this.groupBoxReceivingArea = new System.Windows.Forms.GroupBox();
            this.listBoxImageList = new System.Windows.Forms.ListBox();
            this.textBoxReceivingArea = new System.Windows.Forms.TextBox();
            this.groupBoxSendingArea = new System.Windows.Forms.GroupBox();
            this.textBoxSendingArea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeMs = new System.Windows.Forms.TextBox();
            this.labelMs = new System.Windows.Forms.Label();
            this.buttonAutoSend = new System.Windows.Forms.Button();
            this.labelSendZifu = new System.Windows.Forms.Label();
            this.labelReceiveZifu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClearSending = new System.Windows.Forms.Button();
            this.buttonClearReceiving = new System.Windows.Forms.Button();
            this.buttonOpenCom = new System.Windows.Forms.Button();
            this.groupBoxImageShow = new System.Windows.Forms.GroupBox();
            this.pictureBoxShow1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.groupBoxPicConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxThreePointTrack = new System.Windows.Forms.CheckBox();
            this.buttonStopShowImgTemp = new System.Windows.Forms.Button();
            this.labelAutoShowImageSpeed = new System.Windows.Forms.Label();
            this.buttonAutoShowImage = new System.Windows.Forms.Button();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.checkBoxAutoSaveImage = new System.Windows.Forms.CheckBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonPictureDerectory = new System.Windows.Forms.Button();
            this.checkBoxTwoPixelImage = new System.Windows.Forms.CheckBox();
            this.textBoxPictureHeight = new System.Windows.Forms.TextBox();
            this.labelPictureHeight = new System.Windows.Forms.Label();
            this.textBoxPictureWidth = new System.Windows.Forms.TextBox();
            this.labelPictureWidth = new System.Windows.Forms.Label();
            this.checkBoxGrayImage = new System.Windows.Forms.CheckBox();
            this.timerFreshPort = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialogImage = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogImageLoad = new System.Windows.Forms.OpenFileDialog();
            this.timerAutoShowImage = new System.Windows.Forms.Timer(this.components);
            this.Com_Using = new System.IO.Ports.SerialPort(this.components);
            this.toolTipPicColumnRow = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.版本号v12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRefreshNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCommunicationAgreement = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxInitialization.SuspendLayout();
            this.groupBoxConfiguration.SuspendLayout();
            this.groupBoxReceivingArea.SuspendLayout();
            this.groupBoxSendingArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxImageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.groupBoxPicConfig.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInitialization
            // 
            this.groupBoxInitialization.Controls.Add(this.comboBoxStopBits);
            this.groupBoxInitialization.Controls.Add(this.comboBoxParity);
            this.groupBoxInitialization.Controls.Add(this.comboBoxByteSize);
            this.groupBoxInitialization.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxInitialization.Controls.Add(this.comboBoxCom);
            this.groupBoxInitialization.Controls.Add(this.labelStopBits);
            this.groupBoxInitialization.Controls.Add(this.labelParity);
            this.groupBoxInitialization.Controls.Add(this.labelByteSize);
            this.groupBoxInitialization.Controls.Add(this.labelBaudRate);
            this.groupBoxInitialization.Controls.Add(this.labelCom);
            this.groupBoxInitialization.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxInitialization.Location = new System.Drawing.Point(1, 28);
            this.groupBoxInitialization.Name = "groupBoxInitialization";
            this.groupBoxInitialization.Size = new System.Drawing.Size(182, 178);
            this.groupBoxInitialization.TabIndex = 0;
            this.groupBoxInitialization.TabStop = false;
            this.groupBoxInitialization.Text = "初始化";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(84, 145);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(84, 24);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(84, 112);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(84, 24);
            this.comboBoxParity.TabIndex = 8;
            // 
            // comboBoxByteSize
            // 
            this.comboBoxByteSize.FormattingEnabled = true;
            this.comboBoxByteSize.Location = new System.Drawing.Point(84, 79);
            this.comboBoxByteSize.Name = "comboBoxByteSize";
            this.comboBoxByteSize.Size = new System.Drawing.Size(84, 24);
            this.comboBoxByteSize.TabIndex = 7;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(84, 46);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(84, 27);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(84, 13);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(85, 27);
            this.comboBoxCom.TabIndex = 5;
            this.comboBoxCom.SelectedIndexChanged += new System.EventHandler(this.comboBoxCom_SelectedIndexChanged);
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(12, 148);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(56, 16);
            this.labelStopBits.TabIndex = 4;
            this.labelStopBits.Text = "停止位";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(12, 115);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(56, 16);
            this.labelParity.TabIndex = 3;
            this.labelParity.Text = "校验位";
            // 
            // labelByteSize
            // 
            this.labelByteSize.AutoSize = true;
            this.labelByteSize.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelByteSize.Location = new System.Drawing.Point(12, 82);
            this.labelByteSize.Name = "labelByteSize";
            this.labelByteSize.Size = new System.Drawing.Size(66, 19);
            this.labelByteSize.TabIndex = 2;
            this.labelByteSize.Text = "数据位";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBaudRate.Location = new System.Drawing.Point(12, 49);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(66, 19);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "波特率";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCom.Location = new System.Drawing.Point(12, 16);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(66, 19);
            this.labelCom.TabIndex = 0;
            this.labelCom.Text = "端口号";
            // 
            // groupBoxConfiguration
            // 
            this.groupBoxConfiguration.Controls.Add(this.checkBoxSendEndEnter);
            this.groupBoxConfiguration.Controls.Add(this.checkBoxAutoClearReceivingBox);
            this.groupBoxConfiguration.Controls.Add(this.checkBoxHexSend);
            this.groupBoxConfiguration.Controls.Add(this.checkBoxHexShow);
            this.groupBoxConfiguration.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxConfiguration.Location = new System.Drawing.Point(0, 212);
            this.groupBoxConfiguration.Name = "groupBoxConfiguration";
            this.groupBoxConfiguration.Size = new System.Drawing.Size(182, 142);
            this.groupBoxConfiguration.TabIndex = 1;
            this.groupBoxConfiguration.TabStop = false;
            this.groupBoxConfiguration.Text = "配置";
            // 
            // checkBoxSendEndEnter
            // 
            this.checkBoxSendEndEnter.AutoSize = true;
            this.checkBoxSendEndEnter.Location = new System.Drawing.Point(16, 115);
            this.checkBoxSendEndEnter.Name = "checkBoxSendEndEnter";
            this.checkBoxSendEndEnter.Size = new System.Drawing.Size(123, 20);
            this.checkBoxSendEndEnter.TabIndex = 3;
            this.checkBoxSendEndEnter.Text = "发送末行回车";
            this.checkBoxSendEndEnter.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoClearReceivingBox
            // 
            this.checkBoxAutoClearReceivingBox.AutoSize = true;
            this.checkBoxAutoClearReceivingBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAutoClearReceivingBox.Location = new System.Drawing.Point(16, 86);
            this.checkBoxAutoClearReceivingBox.Name = "checkBoxAutoClearReceivingBox";
            this.checkBoxAutoClearReceivingBox.Size = new System.Drawing.Size(123, 20);
            this.checkBoxAutoClearReceivingBox.TabIndex = 2;
            this.checkBoxAutoClearReceivingBox.Text = "自动清空接收";
            this.checkBoxAutoClearReceivingBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Location = new System.Drawing.Point(16, 57);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(123, 20);
            this.checkBoxHexSend.TabIndex = 1;
            this.checkBoxHexSend.Text = "十六进制发送";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexShow
            // 
            this.checkBoxHexShow.AutoSize = true;
            this.checkBoxHexShow.Location = new System.Drawing.Point(16, 28);
            this.checkBoxHexShow.Name = "checkBoxHexShow";
            this.checkBoxHexShow.Size = new System.Drawing.Size(123, 20);
            this.checkBoxHexShow.TabIndex = 0;
            this.checkBoxHexShow.Text = "十六进制显示";
            this.checkBoxHexShow.UseVisualStyleBackColor = true;
            this.checkBoxHexShow.CheckedChanged += new System.EventHandler(this.checkBoxHexShow_CheckedChanged);
            // 
            // groupBoxReceivingArea
            // 
            this.groupBoxReceivingArea.Controls.Add(this.listBoxImageList);
            this.groupBoxReceivingArea.Controls.Add(this.textBoxReceivingArea);
            this.groupBoxReceivingArea.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxReceivingArea.Location = new System.Drawing.Point(188, 28);
            this.groupBoxReceivingArea.Name = "groupBoxReceivingArea";
            this.groupBoxReceivingArea.Size = new System.Drawing.Size(340, 388);
            this.groupBoxReceivingArea.TabIndex = 2;
            this.groupBoxReceivingArea.TabStop = false;
            this.groupBoxReceivingArea.Text = "接收区";
            // 
            // listBoxImageList
            // 
            this.listBoxImageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxImageList.Enabled = false;
            this.listBoxImageList.FormattingEnabled = true;
            this.listBoxImageList.ItemHeight = 16;
            this.listBoxImageList.Location = new System.Drawing.Point(205, 42);
            this.listBoxImageList.Name = "listBoxImageList";
            this.listBoxImageList.Size = new System.Drawing.Size(88, 224);
            this.listBoxImageList.TabIndex = 1;
            this.listBoxImageList.Visible = false;
            this.listBoxImageList.SelectedIndexChanged += new System.EventHandler(this.listBoxImageList_SelectedIndexChanged);
            this.listBoxImageList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxImageList_MouseDoubleClick);
            // 
            // textBoxReceivingArea
            // 
            this.textBoxReceivingArea.BackColor = System.Drawing.Color.White;
            this.textBoxReceivingArea.Location = new System.Drawing.Point(6, 17);
            this.textBoxReceivingArea.Multiline = true;
            this.textBoxReceivingArea.Name = "textBoxReceivingArea";
            this.textBoxReceivingArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceivingArea.Size = new System.Drawing.Size(328, 364);
            this.textBoxReceivingArea.TabIndex = 0;
            this.textBoxReceivingArea.TextChanged += new System.EventHandler(this.textBoxReceivingArea_TextChanged);
            this.textBoxReceivingArea.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReceivingArea_MouseDoubleClick);
            // 
            // groupBoxSendingArea
            // 
            this.groupBoxSendingArea.Controls.Add(this.textBoxSendingArea);
            this.groupBoxSendingArea.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSendingArea.Location = new System.Drawing.Point(188, 416);
            this.groupBoxSendingArea.Name = "groupBoxSendingArea";
            this.groupBoxSendingArea.Size = new System.Drawing.Size(340, 137);
            this.groupBoxSendingArea.TabIndex = 3;
            this.groupBoxSendingArea.TabStop = false;
            this.groupBoxSendingArea.Text = "发送区";
            // 
            // textBoxSendingArea
            // 
            this.textBoxSendingArea.Location = new System.Drawing.Point(6, 16);
            this.textBoxSendingArea.Multiline = true;
            this.textBoxSendingArea.Name = "textBoxSendingArea";
            this.textBoxSendingArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSendingArea.Size = new System.Drawing.Size(328, 115);
            this.textBoxSendingArea.TabIndex = 0;
            this.textBoxSendingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSendingArea_MouseClick);
            this.textBoxSendingArea.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSendingArea_MouseDoubleClick);
            this.textBoxSendingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxSendingArea_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTimeMs);
            this.groupBox1.Controls.Add(this.labelMs);
            this.groupBox1.Controls.Add(this.buttonAutoSend);
            this.groupBox1.Controls.Add(this.labelSendZifu);
            this.groupBox1.Controls.Add(this.labelReceiveZifu);
            this.groupBox1.Location = new System.Drawing.Point(0, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTimeMs
            // 
            this.textBoxTimeMs.Location = new System.Drawing.Point(4, 108);
            this.textBoxTimeMs.Name = "textBoxTimeMs";
            this.textBoxTimeMs.Size = new System.Drawing.Size(60, 21);
            this.textBoxTimeMs.TabIndex = 4;
            // 
            // labelMs
            // 
            this.labelMs.AutoSize = true;
            this.labelMs.Location = new System.Drawing.Point(70, 111);
            this.labelMs.Name = "labelMs";
            this.labelMs.Size = new System.Drawing.Size(17, 12);
            this.labelMs.TabIndex = 3;
            this.labelMs.Text = "Ms";
            this.labelMs.Click += new System.EventHandler(this.labelMs_Click);
            // 
            // buttonAutoSend
            // 
            this.buttonAutoSend.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAutoSend.Location = new System.Drawing.Point(4, 81);
            this.buttonAutoSend.Name = "buttonAutoSend";
            this.buttonAutoSend.Size = new System.Drawing.Size(83, 23);
            this.buttonAutoSend.TabIndex = 2;
            this.buttonAutoSend.Text = "自动发送";
            this.buttonAutoSend.UseVisualStyleBackColor = true;
            this.buttonAutoSend.Click += new System.EventHandler(this.buttonAutoSend_Click);
            // 
            // labelSendZifu
            // 
            this.labelSendZifu.AutoSize = true;
            this.labelSendZifu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSendZifu.Location = new System.Drawing.Point(6, 52);
            this.labelSendZifu.Name = "labelSendZifu";
            this.labelSendZifu.Size = new System.Drawing.Size(72, 16);
            this.labelSendZifu.TabIndex = 1;
            this.labelSendZifu.Text = "发送字符";
            // 
            // labelReceiveZifu
            // 
            this.labelReceiveZifu.AutoSize = true;
            this.labelReceiveZifu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReceiveZifu.Location = new System.Drawing.Point(6, 23);
            this.labelReceiveZifu.Name = "labelReceiveZifu";
            this.labelReceiveZifu.Size = new System.Drawing.Size(72, 16);
            this.labelReceiveZifu.TabIndex = 0;
            this.labelReceiveZifu.Text = "接收字符";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.buttonClearSending);
            this.groupBox2.Controls.Add(this.buttonClearReceiving);
            this.groupBox2.Location = new System.Drawing.Point(93, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(6, 100);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(76, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClearSending
            // 
            this.buttonClearSending.Location = new System.Drawing.Point(7, 62);
            this.buttonClearSending.Name = "buttonClearSending";
            this.buttonClearSending.Size = new System.Drawing.Size(76, 23);
            this.buttonClearSending.TabIndex = 1;
            this.buttonClearSending.Text = "清空发送";
            this.buttonClearSending.UseVisualStyleBackColor = true;
            this.buttonClearSending.Click += new System.EventHandler(this.buttonClearSending_Click);
            // 
            // buttonClearReceiving
            // 
            this.buttonClearReceiving.Location = new System.Drawing.Point(6, 26);
            this.buttonClearReceiving.Name = "buttonClearReceiving";
            this.buttonClearReceiving.Size = new System.Drawing.Size(76, 23);
            this.buttonClearReceiving.TabIndex = 0;
            this.buttonClearReceiving.Text = "清空接收";
            this.buttonClearReceiving.UseVisualStyleBackColor = true;
            this.buttonClearReceiving.Click += new System.EventHandler(this.buttonClearReceiving_Click);
            // 
            // buttonOpenCom
            // 
            this.buttonOpenCom.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenCom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenCom.Location = new System.Drawing.Point(29, 510);
            this.buttonOpenCom.Name = "buttonOpenCom";
            this.buttonOpenCom.Size = new System.Drawing.Size(126, 37);
            this.buttonOpenCom.TabIndex = 2;
            this.buttonOpenCom.Text = "打开串口";
            this.buttonOpenCom.UseVisualStyleBackColor = false;
            this.buttonOpenCom.Click += new System.EventHandler(this.buttonOpenCom_Click);
            // 
            // groupBoxImageShow
            // 
            this.groupBoxImageShow.Controls.Add(this.pictureBoxShow1);
            this.groupBoxImageShow.Controls.Add(this.pictureBoxShow);
            this.groupBoxImageShow.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxImageShow.Location = new System.Drawing.Point(534, 28);
            this.groupBoxImageShow.Name = "groupBoxImageShow";
            this.groupBoxImageShow.Size = new System.Drawing.Size(652, 525);
            this.groupBoxImageShow.TabIndex = 8;
            this.groupBoxImageShow.TabStop = false;
            this.groupBoxImageShow.Text = "图像显示区";
            // 
            // pictureBoxShow1
            // 
            this.pictureBoxShow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBoxShow1.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxShow1.Name = "pictureBoxShow1";
            this.pictureBoxShow1.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxShow1.TabIndex = 1;
            this.pictureBoxShow1.TabStop = false;
            this.pictureBoxShow1.Visible = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxShow.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxShow.TabIndex = 0;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxShow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShow_MouseDoubleClick);
            this.pictureBoxShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShow_MouseMove);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // groupBoxPicConfig
            // 
            this.groupBoxPicConfig.Controls.Add(this.checkBoxThreePointTrack);
            this.groupBoxPicConfig.Controls.Add(this.buttonStopShowImgTemp);
            this.groupBoxPicConfig.Controls.Add(this.labelAutoShowImageSpeed);
            this.groupBoxPicConfig.Controls.Add(this.buttonAutoShowImage);
            this.groupBoxPicConfig.Controls.Add(this.buttonLoadImage);
            this.groupBoxPicConfig.Controls.Add(this.checkBoxAutoSaveImage);
            this.groupBoxPicConfig.Controls.Add(this.buttonSaveImage);
            this.groupBoxPicConfig.Controls.Add(this.buttonPictureDerectory);
            this.groupBoxPicConfig.Controls.Add(this.checkBoxTwoPixelImage);
            this.groupBoxPicConfig.Controls.Add(this.textBoxPictureHeight);
            this.groupBoxPicConfig.Controls.Add(this.labelPictureHeight);
            this.groupBoxPicConfig.Controls.Add(this.textBoxPictureWidth);
            this.groupBoxPicConfig.Controls.Add(this.labelPictureWidth);
            this.groupBoxPicConfig.Controls.Add(this.checkBoxGrayImage);
            this.groupBoxPicConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxPicConfig.Location = new System.Drawing.Point(0, 553);
            this.groupBoxPicConfig.Name = "groupBoxPicConfig";
            this.groupBoxPicConfig.Size = new System.Drawing.Size(1186, 43);
            this.groupBoxPicConfig.TabIndex = 10;
            this.groupBoxPicConfig.TabStop = false;
            this.groupBoxPicConfig.Text = "图像配置";
            // 
            // checkBoxThreePointTrack
            // 
            this.checkBoxThreePointTrack.AutoSize = true;
            this.checkBoxThreePointTrack.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxThreePointTrack.Location = new System.Drawing.Point(194, 16);
            this.checkBoxThreePointTrack.Name = "checkBoxThreePointTrack";
            this.checkBoxThreePointTrack.Size = new System.Drawing.Size(91, 20);
            this.checkBoxThreePointTrack.TabIndex = 19;
            this.checkBoxThreePointTrack.Text = "三点赛道";
            this.checkBoxThreePointTrack.UseVisualStyleBackColor = true;
            // 
            // buttonStopShowImgTemp
            // 
            this.buttonStopShowImgTemp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStopShowImgTemp.Location = new System.Drawing.Point(923, 14);
            this.buttonStopShowImgTemp.Name = "buttonStopShowImgTemp";
            this.buttonStopShowImgTemp.Size = new System.Drawing.Size(82, 23);
            this.buttonStopShowImgTemp.TabIndex = 18;
            this.buttonStopShowImgTemp.Text = "暂停播放";
            this.buttonStopShowImgTemp.UseVisualStyleBackColor = true;
            this.buttonStopShowImgTemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAutoShowImageSpeed
            // 
            this.labelAutoShowImageSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAutoShowImageSpeed.Enabled = false;
            this.labelAutoShowImageSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAutoShowImageSpeed.Location = new System.Drawing.Point(1011, 15);
            this.labelAutoShowImageSpeed.Name = "labelAutoShowImageSpeed";
            this.labelAutoShowImageSpeed.Size = new System.Drawing.Size(169, 22);
            this.labelAutoShowImageSpeed.TabIndex = 17;
            this.labelAutoShowImageSpeed.Text = "快<---请单击--->慢";
            this.labelAutoShowImageSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAutoShowImageSpeed.Click += new System.EventHandler(this.labelAutoShowImageSpeed_Click);
            this.labelAutoShowImageSpeed.MouseEnter += new System.EventHandler(this.labelAutoShowImageSpeed_MouseEnter);
            this.labelAutoShowImageSpeed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAutoShowImageSpeed_MouseMove);
            // 
            // buttonAutoShowImage
            // 
            this.buttonAutoShowImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAutoShowImage.Location = new System.Drawing.Point(832, 13);
            this.buttonAutoShowImage.Name = "buttonAutoShowImage";
            this.buttonAutoShowImage.Size = new System.Drawing.Size(85, 23);
            this.buttonAutoShowImage.TabIndex = 16;
            this.buttonAutoShowImage.Text = "自动播放";
            this.buttonAutoShowImage.UseVisualStyleBackColor = true;
            this.buttonAutoShowImage.Click += new System.EventHandler(this.buttonAutoShowImage_Click);
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLoadImage.Location = new System.Drawing.Point(739, 13);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(87, 23);
            this.buttonLoadImage.TabIndex = 15;
            this.buttonLoadImage.Text = "打开图像";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // checkBoxAutoSaveImage
            // 
            this.checkBoxAutoSaveImage.AutoSize = true;
            this.checkBoxAutoSaveImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAutoSaveImage.Location = new System.Drawing.Point(633, 15);
            this.checkBoxAutoSaveImage.Name = "checkBoxAutoSaveImage";
            this.checkBoxAutoSaveImage.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAutoSaveImage.TabIndex = 14;
            this.checkBoxAutoSaveImage.Text = "自动保存";
            this.checkBoxAutoSaveImage.UseVisualStyleBackColor = true;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveImage.Location = new System.Drawing.Point(539, 13);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(88, 23);
            this.buttonSaveImage.TabIndex = 13;
            this.buttonSaveImage.Text = "保存图像";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonPictureDerectory
            // 
            this.buttonPictureDerectory.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPictureDerectory.Location = new System.Drawing.Point(442, 13);
            this.buttonPictureDerectory.Name = "buttonPictureDerectory";
            this.buttonPictureDerectory.Size = new System.Drawing.Size(91, 23);
            this.buttonPictureDerectory.TabIndex = 12;
            this.buttonPictureDerectory.Text = "保存路径";
            this.buttonPictureDerectory.UseVisualStyleBackColor = true;
            this.buttonPictureDerectory.Click += new System.EventHandler(this.buttonPictureDerectory_Click);
            // 
            // checkBoxTwoPixelImage
            // 
            this.checkBoxTwoPixelImage.AutoSize = true;
            this.checkBoxTwoPixelImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxTwoPixelImage.Location = new System.Drawing.Point(93, 17);
            this.checkBoxTwoPixelImage.Name = "checkBoxTwoPixelImage";
            this.checkBoxTwoPixelImage.Size = new System.Drawing.Size(107, 20);
            this.checkBoxTwoPixelImage.TabIndex = 9;
            this.checkBoxTwoPixelImage.Text = "鹰眼二值化";
            this.checkBoxTwoPixelImage.UseVisualStyleBackColor = true;
            this.checkBoxTwoPixelImage.CheckedChanged += new System.EventHandler(this.checkBoxTwoPixelImage_CheckedChanged);
            // 
            // textBoxPictureHeight
            // 
            this.textBoxPictureHeight.Location = new System.Drawing.Point(393, 14);
            this.textBoxPictureHeight.Name = "textBoxPictureHeight";
            this.textBoxPictureHeight.Size = new System.Drawing.Size(29, 23);
            this.textBoxPictureHeight.TabIndex = 6;
            // 
            // labelPictureHeight
            // 
            this.labelPictureHeight.AutoSize = true;
            this.labelPictureHeight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPictureHeight.Location = new System.Drawing.Point(361, 17);
            this.labelPictureHeight.Name = "labelPictureHeight";
            this.labelPictureHeight.Size = new System.Drawing.Size(40, 16);
            this.labelPictureHeight.TabIndex = 5;
            this.labelPictureHeight.Text = "高度";
            this.labelPictureHeight.Click += new System.EventHandler(this.labelPictureHeight_Click);
            // 
            // textBoxPictureWidth
            // 
            this.textBoxPictureWidth.Location = new System.Drawing.Point(326, 14);
            this.textBoxPictureWidth.Name = "textBoxPictureWidth";
            this.textBoxPictureWidth.Size = new System.Drawing.Size(29, 23);
            this.textBoxPictureWidth.TabIndex = 3;
            // 
            // labelPictureWidth
            // 
            this.labelPictureWidth.AutoSize = true;
            this.labelPictureWidth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPictureWidth.Location = new System.Drawing.Point(291, 17);
            this.labelPictureWidth.Name = "labelPictureWidth";
            this.labelPictureWidth.Size = new System.Drawing.Size(40, 16);
            this.labelPictureWidth.TabIndex = 2;
            this.labelPictureWidth.Text = "宽度";
            // 
            // checkBoxGrayImage
            // 
            this.checkBoxGrayImage.AutoSize = true;
            this.checkBoxGrayImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxGrayImage.Location = new System.Drawing.Point(3, 17);
            this.checkBoxGrayImage.Name = "checkBoxGrayImage";
            this.checkBoxGrayImage.Size = new System.Drawing.Size(91, 20);
            this.checkBoxGrayImage.TabIndex = 0;
            this.checkBoxGrayImage.Text = "灰度图像";
            this.checkBoxGrayImage.UseVisualStyleBackColor = true;
            this.checkBoxGrayImage.CheckedChanged += new System.EventHandler(this.checkBoxGrayImage_CheckedChanged);
            // 
            // timerFreshPort
            // 
            this.timerFreshPort.Interval = 200;
            this.timerFreshPort.Tick += new System.EventHandler(this.timerFreshPort_Tick);
            // 
            // openFileDialogImageLoad
            // 
            this.openFileDialogImageLoad.FileName = "openFileDialog1";
            // 
            // timerAutoShowImage
            // 
            this.timerAutoShowImage.Interval = 500;
            this.timerAutoShowImage.Tick += new System.EventHandler(this.timerAutoShowImage_Tick);
            // 
            // Com_Using
            // 
            this.Com_Using.BaudRate = 115200;
            // 
            // toolTipPicColumnRow
            // 
            this.toolTipPicColumnRow.AutomaticDelay = 5000;
            this.toolTipPicColumnRow.BackColor = System.Drawing.Color.Transparent;
            this.toolTipPicColumnRow.UseAnimation = false;
            this.toolTipPicColumnRow.UseFading = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(331, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本号v12ToolStripMenuItem,
            this.ToolStripMenuItemCommunicationAgreement,
            this.ToolStripMenuItemRefreshNotes});
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(53, 21);
            this.ToolStripMenuItemAbout.Text = "关于...";
            // 
            // 版本号v12ToolStripMenuItem
            // 
            this.版本号v12ToolStripMenuItem.Name = "版本号v12ToolStripMenuItem";
            this.版本号v12ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本号v12ToolStripMenuItem.Text = "版本号：v1.2";
            // 
            // ToolStripMenuItemRefreshNotes
            // 
            this.ToolStripMenuItemRefreshNotes.Name = "ToolStripMenuItemRefreshNotes";
            this.ToolStripMenuItemRefreshNotes.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemRefreshNotes.Text = "更新说明";
            this.ToolStripMenuItemRefreshNotes.Click += new System.EventHandler(this.更新说明ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemCommunicationAgreement
            // 
            this.ToolStripMenuItemCommunicationAgreement.Name = "ToolStripMenuItemCommunicationAgreement";
            this.ToolStripMenuItemCommunicationAgreement.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCommunicationAgreement.Text = "通信协议";
            this.ToolStripMenuItemCommunicationAgreement.Click += new System.EventHandler(this.ToolStripMenuItemCommunicationAgreement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1187, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonOpenCom);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxPicConfig);
            this.Controls.Add(this.groupBoxImageShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSendingArea);
            this.Controls.Add(this.groupBoxReceivingArea);
            this.Controls.Add(this.groupBoxConfiguration);
            this.Controls.Add(this.groupBoxInitialization);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "东北大学摄像头组智能车调试助手（作者：朱为）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInitialization.ResumeLayout(false);
            this.groupBoxInitialization.PerformLayout();
            this.groupBoxConfiguration.ResumeLayout(false);
            this.groupBoxConfiguration.PerformLayout();
            this.groupBoxReceivingArea.ResumeLayout(false);
            this.groupBoxReceivingArea.PerformLayout();
            this.groupBoxSendingArea.ResumeLayout(false);
            this.groupBoxSendingArea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxImageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.groupBoxPicConfig.ResumeLayout(false);
            this.groupBoxPicConfig.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInitialization;
        private System.Windows.Forms.Label labelByteSize;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxByteSize;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.GroupBox groupBoxConfiguration;
        private System.Windows.Forms.CheckBox checkBoxSendEndEnter;
        private System.Windows.Forms.CheckBox checkBoxAutoClearReceivingBox;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.CheckBox checkBoxHexShow;
        private System.Windows.Forms.GroupBox groupBoxReceivingArea;
        private System.Windows.Forms.GroupBox groupBoxSendingArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSendZifu;
        private System.Windows.Forms.Label labelReceiveZifu;
        private System.Windows.Forms.Button buttonAutoSend;
        private System.Windows.Forms.TextBox textBoxTimeMs;
        private System.Windows.Forms.Label labelMs;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonOpenCom;
        private System.Windows.Forms.Button buttonClearSending;
        private System.Windows.Forms.Button buttonClearReceiving;
        private System.Windows.Forms.GroupBox groupBoxImageShow;
        private System.Windows.Forms.TextBox textBoxReceivingArea;
        private System.Windows.Forms.TextBox textBoxSendingArea;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.GroupBox groupBoxPicConfig;
        private System.Windows.Forms.CheckBox checkBoxGrayImage;
        private System.Windows.Forms.TextBox textBoxPictureHeight;
        private System.Windows.Forms.Label labelPictureHeight;
        private System.Windows.Forms.TextBox textBoxPictureWidth;
        private System.Windows.Forms.Label labelPictureWidth;
        private System.Windows.Forms.CheckBox checkBoxTwoPixelImage;
        private System.Windows.Forms.Timer timerFreshPort;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonPictureDerectory;
        private System.Windows.Forms.CheckBox checkBoxAutoSaveImage;
        private System.Windows.Forms.Button buttonAutoShowImage;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelAutoShowImageSpeed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImage;
        private System.Windows.Forms.ListBox listBoxImageList;
        private System.Windows.Forms.OpenFileDialog openFileDialogImageLoad;
        private System.Windows.Forms.Timer timerAutoShowImage;
        private System.IO.Ports.SerialPort Com_Using;
        private System.Windows.Forms.Button buttonStopShowImgTemp;
        private System.Windows.Forms.ToolTip toolTipPicColumnRow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem 版本号v12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRefreshNotes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox checkBoxThreePointTrack;
        private System.Windows.Forms.PictureBox pictureBoxShow1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCommunicationAgreement;
    }
}

