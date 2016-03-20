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
            this.checkBoxThreePointTrack = new System.Windows.Forms.CheckBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.checkBoxGrayImage = new System.Windows.Forms.CheckBox();
            this.checkBoxTwoPixelImage = new System.Windows.Forms.CheckBox();
            this.labelPictureWidth = new System.Windows.Forms.Label();
            this.textBoxPictureWidth = new System.Windows.Forms.TextBox();
            this.labelPictureHeight = new System.Windows.Forms.Label();
            this.textBoxPictureHeight = new System.Windows.Forms.TextBox();
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.groupBoxPicConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxWaveImage = new System.Windows.Forms.CheckBox();
            this.checkBoxIsWave = new System.Windows.Forms.CheckBox();
            this.buttonStopShowImgTemp = new System.Windows.Forms.Button();
            this.labelAutoShowImageSpeed = new System.Windows.Forms.Label();
            this.buttonAutoShowImage = new System.Windows.Forms.Button();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.checkBoxAutoSaveImage = new System.Windows.Forms.CheckBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonPictureDerectory = new System.Windows.Forms.Button();
            this.timerFreshPort = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialogImage = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogImageLoad = new System.Windows.Forms.OpenFileDialog();
            this.timerAutoShowImage = new System.Windows.Forms.Timer(this.components);
            this.Myserialport = new System.IO.Ports.SerialPort(this.components);
            this.toolTipPicColumnRow = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemCommuniMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSerialPort = new System.Windows.Forms.ToolStripMenuItem();
            this.WifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.界面颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oringeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitesmokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.picturegridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.版本号v12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCommunicationAgreement = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRefreshNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxSyetemTime = new System.Windows.Forms.CheckBox();
            this.labelLocalIP = new System.Windows.Forms.Label();
            this.checkBoxHexShow = new System.Windows.Forms.CheckBox();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoClearReceivingBox = new System.Windows.Forms.CheckBox();
            this.checkBoxSendEndEnter = new System.Windows.Forms.CheckBox();
            this.groupBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.groupBoxWifiSettings = new System.Windows.Forms.GroupBox();
            this.textBoxMaxClientNum = new System.Windows.Forms.TextBox();
            this.labelMaxClientNum = new System.Windows.Forms.Label();
            this.textBoxLocalPortNum = new System.Windows.Forms.TextBox();
            this.labelLocalPortNum = new System.Windows.Forms.Label();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.textBoxServerPortNum = new System.Windows.Forms.TextBox();
            this.labelServerPortNum = new System.Windows.Forms.Label();
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.buttonWifiStart = new System.Windows.Forms.Button();
            this.buttonWifiStop = new System.Windows.Forms.Button();
            this.groupBoxInitialization.SuspendLayout();
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
            this.groupBoxConfiguration.SuspendLayout();
            this.groupBoxWifiSettings.SuspendLayout();
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
            this.groupBoxInitialization.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInitialization.Name = "groupBoxInitialization";
            this.groupBoxInitialization.Size = new System.Drawing.Size(182, 178);
            this.groupBoxInitialization.TabIndex = 0;
            this.groupBoxInitialization.TabStop = false;
            this.groupBoxInitialization.Text = "初始化";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(84, 145);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(84, 27);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(84, 112);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(84, 27);
            this.comboBoxParity.TabIndex = 8;
            // 
            // comboBoxByteSize
            // 
            this.comboBoxByteSize.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxByteSize.FormattingEnabled = true;
            this.comboBoxByteSize.Location = new System.Drawing.Point(84, 79);
            this.comboBoxByteSize.Name = "comboBoxByteSize";
            this.comboBoxByteSize.Size = new System.Drawing.Size(84, 27);
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
            this.labelStopBits.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStopBits.Location = new System.Drawing.Point(12, 148);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(66, 19);
            this.labelStopBits.TabIndex = 4;
            this.labelStopBits.Text = "停止位";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelParity.Location = new System.Drawing.Point(12, 115);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(66, 19);
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
            this.groupBoxImageShow.Controls.Add(this.checkBoxThreePointTrack);
            this.groupBoxImageShow.Controls.Add(this.pictureBoxShow);
            this.groupBoxImageShow.Controls.Add(this.checkBoxGrayImage);
            this.groupBoxImageShow.Controls.Add(this.checkBoxTwoPixelImage);
            this.groupBoxImageShow.Controls.Add(this.labelPictureWidth);
            this.groupBoxImageShow.Controls.Add(this.textBoxPictureWidth);
            this.groupBoxImageShow.Controls.Add(this.labelPictureHeight);
            this.groupBoxImageShow.Controls.Add(this.textBoxPictureHeight);
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
            this.pictureBoxShow1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShow1.Location = new System.Drawing.Point(5, 13);
            this.pictureBoxShow1.Name = "pictureBoxShow1";
            this.pictureBoxShow1.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxShow1.TabIndex = 1;
            this.pictureBoxShow1.TabStop = false;
            this.pictureBoxShow1.Visible = false;
            this.pictureBoxShow1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShow1_MouseMove);
            // 
            // checkBoxThreePointTrack
            // 
            this.checkBoxThreePointTrack.AutoSize = true;
            this.checkBoxThreePointTrack.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxThreePointTrack.Location = new System.Drawing.Point(315, 499);
            this.checkBoxThreePointTrack.Name = "checkBoxThreePointTrack";
            this.checkBoxThreePointTrack.Size = new System.Drawing.Size(91, 20);
            this.checkBoxThreePointTrack.TabIndex = 19;
            this.checkBoxThreePointTrack.Text = "三点赛道";
            this.checkBoxThreePointTrack.UseVisualStyleBackColor = true;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxShow.Location = new System.Drawing.Point(6, 13);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxShow.TabIndex = 0;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxShow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShow_MouseDoubleClick);
            this.pictureBoxShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShow_MouseMove);
            // 
            // checkBoxGrayImage
            // 
            this.checkBoxGrayImage.AutoSize = true;
            this.checkBoxGrayImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxGrayImage.Location = new System.Drawing.Point(66, 499);
            this.checkBoxGrayImage.Name = "checkBoxGrayImage";
            this.checkBoxGrayImage.Size = new System.Drawing.Size(91, 20);
            this.checkBoxGrayImage.TabIndex = 0;
            this.checkBoxGrayImage.Text = "灰度图像";
            this.checkBoxGrayImage.UseVisualStyleBackColor = true;
            this.checkBoxGrayImage.CheckedChanged += new System.EventHandler(this.checkBoxGrayImage_CheckedChanged);
            // 
            // checkBoxTwoPixelImage
            // 
            this.checkBoxTwoPixelImage.AutoSize = true;
            this.checkBoxTwoPixelImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxTwoPixelImage.Location = new System.Drawing.Point(185, 499);
            this.checkBoxTwoPixelImage.Name = "checkBoxTwoPixelImage";
            this.checkBoxTwoPixelImage.Size = new System.Drawing.Size(107, 20);
            this.checkBoxTwoPixelImage.TabIndex = 9;
            this.checkBoxTwoPixelImage.Text = "鹰眼二值化";
            this.checkBoxTwoPixelImage.UseVisualStyleBackColor = true;
            this.checkBoxTwoPixelImage.CheckedChanged += new System.EventHandler(this.checkBoxTwoPixelImage_CheckedChanged);
            // 
            // labelPictureWidth
            // 
            this.labelPictureWidth.AutoSize = true;
            this.labelPictureWidth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPictureWidth.Location = new System.Drawing.Point(421, 500);
            this.labelPictureWidth.Name = "labelPictureWidth";
            this.labelPictureWidth.Size = new System.Drawing.Size(40, 16);
            this.labelPictureWidth.TabIndex = 2;
            this.labelPictureWidth.Text = "宽度";
            // 
            // textBoxPictureWidth
            // 
            this.textBoxPictureWidth.Location = new System.Drawing.Point(465, 496);
            this.textBoxPictureWidth.Name = "textBoxPictureWidth";
            this.textBoxPictureWidth.Size = new System.Drawing.Size(29, 23);
            this.textBoxPictureWidth.TabIndex = 3;
            this.textBoxPictureWidth.TextChanged += new System.EventHandler(this.textBoxPictureWidth_TextChanged);
            // 
            // labelPictureHeight
            // 
            this.labelPictureHeight.AutoSize = true;
            this.labelPictureHeight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPictureHeight.Location = new System.Drawing.Point(500, 500);
            this.labelPictureHeight.Name = "labelPictureHeight";
            this.labelPictureHeight.Size = new System.Drawing.Size(40, 16);
            this.labelPictureHeight.TabIndex = 5;
            this.labelPictureHeight.Text = "高度";
            this.labelPictureHeight.Click += new System.EventHandler(this.labelPictureHeight_Click);
            // 
            // textBoxPictureHeight
            // 
            this.textBoxPictureHeight.Location = new System.Drawing.Point(546, 496);
            this.textBoxPictureHeight.Name = "textBoxPictureHeight";
            this.textBoxPictureHeight.Size = new System.Drawing.Size(29, 23);
            this.textBoxPictureHeight.TabIndex = 6;
            this.textBoxPictureHeight.TextChanged += new System.EventHandler(this.textBoxPictureHeight_TextChanged);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // groupBoxPicConfig
            // 
            this.groupBoxPicConfig.Controls.Add(this.checkBoxWaveImage);
            this.groupBoxPicConfig.Controls.Add(this.checkBoxIsWave);
            this.groupBoxPicConfig.Controls.Add(this.buttonStopShowImgTemp);
            this.groupBoxPicConfig.Controls.Add(this.labelAutoShowImageSpeed);
            this.groupBoxPicConfig.Controls.Add(this.buttonAutoShowImage);
            this.groupBoxPicConfig.Controls.Add(this.buttonLoadImage);
            this.groupBoxPicConfig.Controls.Add(this.checkBoxAutoSaveImage);
            this.groupBoxPicConfig.Controls.Add(this.buttonSaveImage);
            this.groupBoxPicConfig.Controls.Add(this.buttonPictureDerectory);
            this.groupBoxPicConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxPicConfig.Location = new System.Drawing.Point(0, 553);
            this.groupBoxPicConfig.Name = "groupBoxPicConfig";
            this.groupBoxPicConfig.Size = new System.Drawing.Size(1186, 43);
            this.groupBoxPicConfig.TabIndex = 10;
            this.groupBoxPicConfig.TabStop = false;
            this.groupBoxPicConfig.Text = "图像配置";
            // 
            // checkBoxWaveImage
            // 
            this.checkBoxWaveImage.AutoSize = true;
            this.checkBoxWaveImage.Enabled = false;
            this.checkBoxWaveImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxWaveImage.Location = new System.Drawing.Point(946, 15);
            this.checkBoxWaveImage.Name = "checkBoxWaveImage";
            this.checkBoxWaveImage.Size = new System.Drawing.Size(163, 20);
            this.checkBoxWaveImage.TabIndex = 20;
            this.checkBoxWaveImage.Text = "速度曲线+三点赛道";
            this.checkBoxWaveImage.UseVisualStyleBackColor = true;
            this.checkBoxWaveImage.CheckedChanged += new System.EventHandler(this.checkBoxWaveImage_CheckedChanged);
            // 
            // checkBoxIsWave
            // 
            this.checkBoxIsWave.AutoSize = true;
            this.checkBoxIsWave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxIsWave.Location = new System.Drawing.Point(849, 15);
            this.checkBoxIsWave.Name = "checkBoxIsWave";
            this.checkBoxIsWave.Size = new System.Drawing.Size(75, 20);
            this.checkBoxIsWave.TabIndex = 19;
            this.checkBoxIsWave.Text = "波形图";
            this.checkBoxIsWave.UseVisualStyleBackColor = true;
            this.checkBoxIsWave.CheckedChanged += new System.EventHandler(this.checkBoxIsWave_CheckedChanged);
            // 
            // buttonStopShowImgTemp
            // 
            this.buttonStopShowImgTemp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStopShowImgTemp.Location = new System.Drawing.Point(550, 14);
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
            this.labelAutoShowImageSpeed.Location = new System.Drawing.Point(657, 15);
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
            this.buttonAutoShowImage.Location = new System.Drawing.Point(443, 14);
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
            this.buttonLoadImage.Location = new System.Drawing.Point(337, 14);
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
            this.checkBoxAutoSaveImage.Location = new System.Drawing.Point(240, 16);
            this.checkBoxAutoSaveImage.Name = "checkBoxAutoSaveImage";
            this.checkBoxAutoSaveImage.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAutoSaveImage.TabIndex = 14;
            this.checkBoxAutoSaveImage.Text = "自动保存";
            this.checkBoxAutoSaveImage.UseVisualStyleBackColor = true;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveImage.Location = new System.Drawing.Point(135, 14);
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
            this.buttonPictureDerectory.Location = new System.Drawing.Point(29, 14);
            this.buttonPictureDerectory.Name = "buttonPictureDerectory";
            this.buttonPictureDerectory.Size = new System.Drawing.Size(91, 23);
            this.buttonPictureDerectory.TabIndex = 12;
            this.buttonPictureDerectory.Text = "保存路径";
            this.buttonPictureDerectory.UseVisualStyleBackColor = true;
            this.buttonPictureDerectory.Click += new System.EventHandler(this.buttonPictureDerectory_Click);
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
            // Myserialport
            // 
            this.Myserialport.BaudRate = 115200;
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
            this.toolStripStatusLabelMessage,
            this.toolStripStatusLabelTime,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.AutoSize = false;
            this.toolStripStatusLabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(610, 17);
            this.toolStripStatusLabelMessage.Text = "欢迎使用";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripStatusLabelTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripProgressBar1.Maximum = 1000;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCommuniMethods,
            this.界面颜色ToolStripMenuItem,
            this.ToolStripMenuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemCommuniMethods
            // 
            this.ToolStripMenuItemCommuniMethods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSerialPort,
            this.WifiToolStripMenuItem});
            this.ToolStripMenuItemCommuniMethods.Name = "ToolStripMenuItemCommuniMethods";
            this.ToolStripMenuItemCommuniMethods.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemCommuniMethods.Text = "通信方式";
            // 
            // ToolStripMenuItemSerialPort
            // 
            this.ToolStripMenuItemSerialPort.Name = "ToolStripMenuItemSerialPort";
            this.ToolStripMenuItemSerialPort.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemSerialPort.Text = "串口通信";
            this.ToolStripMenuItemSerialPort.Click += new System.EventHandler(this.ToolStripMenuItemSerialPort_Click);
            // 
            // WifiToolStripMenuItem
            // 
            this.WifiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPClientToolStripMenuItem,
            this.tCPServerToolStripMenuItem,
            this.uDPClientToolStripMenuItem});
            this.WifiToolStripMenuItem.Name = "WifiToolStripMenuItem";
            this.WifiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.WifiToolStripMenuItem.Text = "WIFI通信";
            // 
            // tCPClientToolStripMenuItem
            // 
            this.tCPClientToolStripMenuItem.Name = "tCPClientToolStripMenuItem";
            this.tCPClientToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.tCPClientToolStripMenuItem.Text = "TCP Client";
            this.tCPClientToolStripMenuItem.Click += new System.EventHandler(this.tCPClientToolStripMenuItem_Click);
            // 
            // tCPServerToolStripMenuItem
            // 
            this.tCPServerToolStripMenuItem.Name = "tCPServerToolStripMenuItem";
            this.tCPServerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.tCPServerToolStripMenuItem.Text = "TCP Server";
            this.tCPServerToolStripMenuItem.Click += new System.EventHandler(this.tCPServerToolStripMenuItem_Click);
            // 
            // uDPClientToolStripMenuItem
            // 
            this.uDPClientToolStripMenuItem.Enabled = false;
            this.uDPClientToolStripMenuItem.Name = "uDPClientToolStripMenuItem";
            this.uDPClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uDPClientToolStripMenuItem.Text = "UDP Client";
            this.uDPClientToolStripMenuItem.Click += new System.EventHandler(this.uDPClientToolStripMenuItem_Click);
            // 
            // 界面颜色ToolStripMenuItem
            // 
            this.界面颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.oringeToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.goldToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.whitesmokeToolStripMenuItem,
            this.toolStripSeparator1,
            this.picturegridToolStripMenuItem});
            this.界面颜色ToolStripMenuItem.Name = "界面颜色ToolStripMenuItem";
            this.界面颜色ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.界面颜色ToolStripMenuItem.Text = "界面换肤";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // oringeToolStripMenuItem
            // 
            this.oringeToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.oringeToolStripMenuItem.Name = "oringeToolStripMenuItem";
            this.oringeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.oringeToolStripMenuItem.Text = "Orange";
            this.oringeToolStripMenuItem.Click += new System.EventHandler(this.oringeToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // goldToolStripMenuItem
            // 
            this.goldToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.goldToolStripMenuItem.Name = "goldToolStripMenuItem";
            this.goldToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.goldToolStripMenuItem.Text = "Gold";
            this.goldToolStripMenuItem.Click += new System.EventHandler(this.goldenToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.BackColor = System.Drawing.Color.LightPink;
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // whitesmokeToolStripMenuItem
            // 
            this.whitesmokeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.whitesmokeToolStripMenuItem.Name = "whitesmokeToolStripMenuItem";
            this.whitesmokeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.whitesmokeToolStripMenuItem.Text = "WhiteSmoke";
            this.whitesmokeToolStripMenuItem.Click += new System.EventHandler(this.whitesmokeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // picturegridToolStripMenuItem
            // 
            this.picturegridToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturegridToolStripMenuItem.Image = global::SerialPortDebug.Properties.Resources.方格;
            this.picturegridToolStripMenuItem.Name = "picturegridToolStripMenuItem";
            this.picturegridToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.picturegridToolStripMenuItem.Text = "图像栅格显示";
            this.picturegridToolStripMenuItem.Click += new System.EventHandler(this.picturegridToolStripMenuItem_Click);
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
            this.版本号v12ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.版本号v12ToolStripMenuItem.Text = "版本号：v1.3";
            // 
            // ToolStripMenuItemCommunicationAgreement
            // 
            this.ToolStripMenuItemCommunicationAgreement.Name = "ToolStripMenuItemCommunicationAgreement";
            this.ToolStripMenuItemCommunicationAgreement.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemCommunicationAgreement.Text = "通信协议";
            this.ToolStripMenuItemCommunicationAgreement.Click += new System.EventHandler(this.ToolStripMenuItemCommunicationAgreement_Click);
            // 
            // ToolStripMenuItemRefreshNotes
            // 
            this.ToolStripMenuItemRefreshNotes.Name = "ToolStripMenuItemRefreshNotes";
            this.ToolStripMenuItemRefreshNotes.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemRefreshNotes.Text = "更新说明";
            this.ToolStripMenuItemRefreshNotes.Click += new System.EventHandler(this.更新说明ToolStripMenuItem_Click);
            // 
            // checkBoxSyetemTime
            // 
            this.checkBoxSyetemTime.AutoSize = true;
            this.checkBoxSyetemTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxSyetemTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxSyetemTime.Location = new System.Drawing.Point(1095, 607);
            this.checkBoxSyetemTime.Name = "checkBoxSyetemTime";
            this.checkBoxSyetemTime.Size = new System.Drawing.Size(91, 20);
            this.checkBoxSyetemTime.TabIndex = 14;
            this.checkBoxSyetemTime.Text = "显示时间";
            this.checkBoxSyetemTime.UseVisualStyleBackColor = false;
            this.checkBoxSyetemTime.CheckedChanged += new System.EventHandler(this.checkBoxSyetemTime_CheckedChanged);
            // 
            // labelLocalIP
            // 
            this.labelLocalIP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLocalIP.Location = new System.Drawing.Point(5, 22);
            this.labelLocalIP.Name = "labelLocalIP";
            this.labelLocalIP.Size = new System.Drawing.Size(59, 25);
            this.labelLocalIP.TabIndex = 10;
            this.labelLocalIP.Text = "本机ip";
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
            // groupBoxWifiSettings
            // 
            this.groupBoxWifiSettings.Controls.Add(this.groupBoxInitialization);
            this.groupBoxWifiSettings.Controls.Add(this.textBoxMaxClientNum);
            this.groupBoxWifiSettings.Controls.Add(this.labelMaxClientNum);
            this.groupBoxWifiSettings.Controls.Add(this.textBoxLocalPortNum);
            this.groupBoxWifiSettings.Controls.Add(this.labelLocalPortNum);
            this.groupBoxWifiSettings.Controls.Add(this.textBoxLocalIP);
            this.groupBoxWifiSettings.Controls.Add(this.textBoxServerPortNum);
            this.groupBoxWifiSettings.Controls.Add(this.labelServerPortNum);
            this.groupBoxWifiSettings.Controls.Add(this.textBoxServerIP);
            this.groupBoxWifiSettings.Controls.Add(this.labelServerIP);
            this.groupBoxWifiSettings.Controls.Add(this.labelLocalIP);
            this.groupBoxWifiSettings.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxWifiSettings.Location = new System.Drawing.Point(0, 28);
            this.groupBoxWifiSettings.Name = "groupBoxWifiSettings";
            this.groupBoxWifiSettings.Size = new System.Drawing.Size(182, 178);
            this.groupBoxWifiSettings.TabIndex = 15;
            this.groupBoxWifiSettings.TabStop = false;
            this.groupBoxWifiSettings.Text = "初始化";
            // 
            // textBoxMaxClientNum
            // 
            this.textBoxMaxClientNum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMaxClientNum.Location = new System.Drawing.Point(99, 81);
            this.textBoxMaxClientNum.Name = "textBoxMaxClientNum";
            this.textBoxMaxClientNum.Size = new System.Drawing.Size(76, 29);
            this.textBoxMaxClientNum.TabIndex = 21;
            this.textBoxMaxClientNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaxClientNum
            // 
            this.labelMaxClientNum.AutoSize = true;
            this.labelMaxClientNum.Location = new System.Drawing.Point(6, 84);
            this.labelMaxClientNum.Name = "labelMaxClientNum";
            this.labelMaxClientNum.Size = new System.Drawing.Size(88, 16);
            this.labelMaxClientNum.TabIndex = 20;
            this.labelMaxClientNum.Text = "最大连接数";
            // 
            // textBoxLocalPortNum
            // 
            this.textBoxLocalPortNum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLocalPortNum.Location = new System.Drawing.Point(100, 49);
            this.textBoxLocalPortNum.Name = "textBoxLocalPortNum";
            this.textBoxLocalPortNum.Size = new System.Drawing.Size(75, 29);
            this.textBoxLocalPortNum.TabIndex = 19;
            this.textBoxLocalPortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLocalPortNum
            // 
            this.labelLocalPortNum.AutoSize = true;
            this.labelLocalPortNum.Location = new System.Drawing.Point(5, 54);
            this.labelLocalPortNum.Name = "labelLocalPortNum";
            this.labelLocalPortNum.Size = new System.Drawing.Size(88, 16);
            this.labelLocalPortNum.TabIndex = 18;
            this.labelLocalPortNum.Text = "本机端口号";
            this.labelLocalPortNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Location = new System.Drawing.Point(58, 17);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(118, 26);
            this.textBoxLocalIP.TabIndex = 17;
            this.textBoxLocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxServerPortNum
            // 
            this.textBoxServerPortNum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxServerPortNum.Location = new System.Drawing.Point(100, 146);
            this.textBoxServerPortNum.Name = "textBoxServerPortNum";
            this.textBoxServerPortNum.Size = new System.Drawing.Size(76, 29);
            this.textBoxServerPortNum.TabIndex = 16;
            this.textBoxServerPortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelServerPortNum
            // 
            this.labelServerPortNum.AutoSize = true;
            this.labelServerPortNum.Location = new System.Drawing.Point(8, 149);
            this.labelServerPortNum.Name = "labelServerPortNum";
            this.labelServerPortNum.Size = new System.Drawing.Size(88, 16);
            this.labelServerPortNum.TabIndex = 15;
            this.labelServerPortNum.Text = "服务器端口";
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxServerIP.Location = new System.Drawing.Point(75, 114);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(100, 23);
            this.textBoxServerIP.TabIndex = 14;
            this.textBoxServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(5, 117);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(72, 16);
            this.labelServerIP.TabIndex = 13;
            this.labelServerIP.Text = "服务器ip";
            this.labelServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonWifiStart
            // 
            this.buttonWifiStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonWifiStart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWifiStart.Location = new System.Drawing.Point(11, 510);
            this.buttonWifiStart.Name = "buttonWifiStart";
            this.buttonWifiStart.Size = new System.Drawing.Size(73, 37);
            this.buttonWifiStart.TabIndex = 16;
            this.buttonWifiStart.Text = "WIFI";
            this.buttonWifiStart.UseVisualStyleBackColor = false;
            this.buttonWifiStart.Visible = false;
            this.buttonWifiStart.Click += new System.EventHandler(this.buttonWifiStart_Click);
            // 
            // buttonWifiStop
            // 
            this.buttonWifiStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonWifiStop.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWifiStop.Location = new System.Drawing.Point(101, 510);
            this.buttonWifiStop.Name = "buttonWifiStop";
            this.buttonWifiStop.Size = new System.Drawing.Size(75, 37);
            this.buttonWifiStop.TabIndex = 17;
            this.buttonWifiStop.Text = "停止";
            this.buttonWifiStop.UseVisualStyleBackColor = false;
            this.buttonWifiStop.Visible = false;
            this.buttonWifiStop.Click += new System.EventHandler(this.buttonWifiStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1187, 629);
            this.Controls.Add(this.buttonWifiStop);
            this.Controls.Add(this.buttonWifiStart);
            this.Controls.Add(this.checkBoxSyetemTime);
            this.Controls.Add(this.groupBoxWifiSettings);
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
            this.groupBoxReceivingArea.ResumeLayout(false);
            this.groupBoxReceivingArea.PerformLayout();
            this.groupBoxSendingArea.ResumeLayout(false);
            this.groupBoxSendingArea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxImageShow.ResumeLayout(false);
            this.groupBoxImageShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.groupBoxPicConfig.ResumeLayout(false);
            this.groupBoxPicConfig.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxConfiguration.ResumeLayout(false);
            this.groupBoxConfiguration.PerformLayout();
            this.groupBoxWifiSettings.ResumeLayout(false);
            this.groupBoxWifiSettings.PerformLayout();
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
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelAutoShowImageSpeed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImage;
        private System.Windows.Forms.ListBox listBoxImageList;
        private System.Windows.Forms.OpenFileDialog openFileDialogImageLoad;
        private System.Windows.Forms.Timer timerAutoShowImage;
        private System.IO.Ports.SerialPort Myserialport;
        private System.Windows.Forms.Button buttonStopShowImgTemp;
        private System.Windows.Forms.ToolTip toolTipPicColumnRow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem 版本号v12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRefreshNotes;
        private System.Windows.Forms.CheckBox checkBoxThreePointTrack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCommunicationAgreement;
        private System.Windows.Forms.ToolStripMenuItem 界面颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oringeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitesmokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturegridToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxIsWave;
        private System.Windows.Forms.CheckBox checkBoxWaveImage;
        public System.Windows.Forms.PictureBox pictureBoxShow;
        public System.Windows.Forms.PictureBox pictureBoxShow1;
        public System.Windows.Forms.CheckBox checkBoxAutoSaveImage;
        private System.Windows.Forms.Button buttonAutoShowImage;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.CheckBox checkBoxSyetemTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCommuniMethods;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSerialPort;
        private System.Windows.Forms.ToolStripMenuItem WifiToolStripMenuItem;
        private System.Windows.Forms.Label labelLocalIP;
        private System.Windows.Forms.CheckBox checkBoxHexShow;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.CheckBox checkBoxAutoClearReceivingBox;
        private System.Windows.Forms.CheckBox checkBoxSendEndEnter;
        private System.Windows.Forms.GroupBox groupBoxConfiguration;
        private System.Windows.Forms.GroupBox groupBoxWifiSettings;
        private System.Windows.Forms.ToolStripMenuItem tCPClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPServerToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.TextBox textBoxServerPortNum;
        private System.Windows.Forms.Label labelServerPortNum;
        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.TextBox textBoxMaxClientNum;
        private System.Windows.Forms.Label labelMaxClientNum;
        private System.Windows.Forms.TextBox textBoxLocalPortNum;
        private System.Windows.Forms.Label labelLocalPortNum;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxByteSize;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonWifiStart;
        private System.Windows.Forms.Button buttonWifiStop;
        private System.Windows.Forms.ToolStripMenuItem uDPClientToolStripMenuItem;
    }
}

