namespace VkUp.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_ReadMessage = new System.Windows.Forms.CheckBox();
            this.checkBox_AllTarget = new System.Windows.Forms.CheckBox();
            this.checkBox_ExcludeRepetFlooder = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_TypeDelay = new System.Windows.Forms.ComboBox();
            this.numeric_DelayFlooderMax = new System.Windows.Forms.NumericUpDown();
            this.numeric_DelayFlooderMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_SaveChangesFlooder = new System.Windows.Forms.Button();
            this.checkBox_setActivity = new System.Windows.Forms.CheckBox();
            this.checkBox_EnabledFlooder = new System.Windows.Forms.CheckBox();
            this.dataGrid_flooder = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_SendVoiseMessage = new System.Windows.Forms.CheckBox();
            this.checkBox_RandomEditMessage = new System.Windows.Forms.CheckBox();
            this.checkBox_RandomReplyMessage = new System.Windows.Forms.CheckBox();
            this.checkBox_ExcludeRepetAutoans = new System.Windows.Forms.CheckBox();
            this.checkBox_ReplyMessage = new System.Windows.Forms.CheckBox();
            this.numeric_autoansDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SaveChangesAutoans = new System.Windows.Forms.Button();
            this.checkBox_AutoansSetActivity = new System.Windows.Forms.CheckBox();
            this.checkBox_EnabledAutoans = new System.Windows.Forms.CheckBox();
            this.dataGrid_Autoans = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton_CaptAnticaptcha = new System.Windows.Forms.RadioButton();
            this.radioButton_CaptRucaptcha = new System.Windows.Forms.RadioButton();
            this.radioButton_CaptManual = new System.Windows.Forms.RadioButton();
            this.checkBox_OnOffLogger = new System.Windows.Forms.CheckBox();
            this.ManualCaptBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CaptAns = new System.Windows.Forms.Button();
            this.CaptPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_GetBalanceCaptcha = new System.Windows.Forms.Button();
            this.ApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.button_saveCaptcha = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.check_Box_EnabledStopWatch = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericWatch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_FromId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_IdBound = new System.Windows.Forms.TextBox();
            this.button_SaveChangesWatch = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button_GetIdUser = new System.Windows.Forms.Button();
            this.textBox_Domains = new System.Windows.Forms.TextBox();
            this.button_getConversations = new System.Windows.Forms.Button();
            this.comboBox_conversationsList = new System.Windows.Forms.ComboBox();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            this.TimerCaptcha = new System.Windows.Forms.Timer(this.components);
            this.comboBox_accountsList = new System.Windows.Forms.ComboBox();
            this.button_StartStopBot = new System.Windows.Forms.Button();
            this.TimerCountDown = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DelayFlooderMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DelayFlooderMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_flooder)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_autoansDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Autoans)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptPic)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(676, 319);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox_ReadMessage);
            this.tabPage1.Controls.Add(this.checkBox_AllTarget);
            this.tabPage1.Controls.Add(this.checkBox_ExcludeRepetFlooder);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox_TypeDelay);
            this.tabPage1.Controls.Add(this.numeric_DelayFlooderMax);
            this.tabPage1.Controls.Add(this.numeric_DelayFlooderMin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button_SaveChangesFlooder);
            this.tabPage1.Controls.Add(this.checkBox_setActivity);
            this.tabPage1.Controls.Add(this.checkBox_EnabledFlooder);
            this.tabPage1.Controls.Add(this.dataGrid_flooder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Флудер";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_ReadMessage
            // 
            this.checkBox_ReadMessage.AutoSize = true;
            this.checkBox_ReadMessage.Location = new System.Drawing.Point(402, 222);
            this.checkBox_ReadMessage.Name = "checkBox_ReadMessage";
            this.checkBox_ReadMessage.Size = new System.Drawing.Size(122, 17);
            this.checkBox_ReadMessage.TabIndex = 17;
            this.checkBox_ReadMessage.Text = "Читать сообщения";
            this.checkBox_ReadMessage.UseVisualStyleBackColor = true;
            // 
            // checkBox_AllTarget
            // 
            this.checkBox_AllTarget.AutoSize = true;
            this.checkBox_AllTarget.Location = new System.Drawing.Point(317, 222);
            this.checkBox_AllTarget.Name = "checkBox_AllTarget";
            this.checkBox_AllTarget.Size = new System.Drawing.Size(87, 17);
            this.checkBox_AllTarget.TabIndex = 16;
            this.checkBox_AllTarget.Text = "Во все цели";
            this.checkBox_AllTarget.UseVisualStyleBackColor = true;
            // 
            // checkBox_ExcludeRepetFlooder
            // 
            this.checkBox_ExcludeRepetFlooder.AutoSize = true;
            this.checkBox_ExcludeRepetFlooder.Location = new System.Drawing.Point(191, 222);
            this.checkBox_ExcludeRepetFlooder.Name = "checkBox_ExcludeRepetFlooder";
            this.checkBox_ExcludeRepetFlooder.Size = new System.Drawing.Size(128, 17);
            this.checkBox_ExcludeRepetFlooder.TabIndex = 15;
            this.checkBox_ExcludeRepetFlooder.Text = "Исключить повторы";
            this.checkBox_ExcludeRepetFlooder.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Тип задержки";
            // 
            // comboBox_TypeDelay
            // 
            this.comboBox_TypeDelay.FormattingEnabled = true;
            this.comboBox_TypeDelay.Items.AddRange(new object[] {
            "Обычная",
            "Рандомная"});
            this.comboBox_TypeDelay.Location = new System.Drawing.Point(202, 266);
            this.comboBox_TypeDelay.Name = "comboBox_TypeDelay";
            this.comboBox_TypeDelay.Size = new System.Drawing.Size(98, 21);
            this.comboBox_TypeDelay.TabIndex = 11;
            this.comboBox_TypeDelay.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypeDelay_SelectedIndexChanged);
            // 
            // numeric_DelayFlooderMax
            // 
            this.numeric_DelayFlooderMax.Enabled = false;
            this.numeric_DelayFlooderMax.Location = new System.Drawing.Point(109, 266);
            this.numeric_DelayFlooderMax.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.numeric_DelayFlooderMax.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numeric_DelayFlooderMax.Name = "numeric_DelayFlooderMax";
            this.numeric_DelayFlooderMax.Size = new System.Drawing.Size(87, 20);
            this.numeric_DelayFlooderMax.TabIndex = 10;
            this.numeric_DelayFlooderMax.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // numeric_DelayFlooderMin
            // 
            this.numeric_DelayFlooderMin.Location = new System.Drawing.Point(8, 266);
            this.numeric_DelayFlooderMin.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.numeric_DelayFlooderMin.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numeric_DelayFlooderMin.Name = "numeric_DelayFlooderMin";
            this.numeric_DelayFlooderMin.Size = new System.Drawing.Size(95, 20);
            this.numeric_DelayFlooderMin.TabIndex = 4;
            this.numeric_DelayFlooderMin.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Задержка между сообщениями (мс)";
            // 
            // button_SaveChangesFlooder
            // 
            this.button_SaveChangesFlooder.Location = new System.Drawing.Point(306, 264);
            this.button_SaveChangesFlooder.Name = "button_SaveChangesFlooder";
            this.button_SaveChangesFlooder.Size = new System.Drawing.Size(112, 23);
            this.button_SaveChangesFlooder.TabIndex = 6;
            this.button_SaveChangesFlooder.Text = "Сохранить";
            this.button_SaveChangesFlooder.UseVisualStyleBackColor = true;
            this.button_SaveChangesFlooder.Click += new System.EventHandler(this.button_SaveChangesFlooder_Click);
            // 
            // checkBox_setActivity
            // 
            this.checkBox_setActivity.AutoSize = true;
            this.checkBox_setActivity.Location = new System.Drawing.Point(78, 222);
            this.checkBox_setActivity.Name = "checkBox_setActivity";
            this.checkBox_setActivity.Size = new System.Drawing.Size(116, 17);
            this.checkBox_setActivity.TabIndex = 9;
            this.checkBox_setActivity.Text = "Имитация набора";
            this.checkBox_setActivity.UseVisualStyleBackColor = true;
            // 
            // checkBox_EnabledFlooder
            // 
            this.checkBox_EnabledFlooder.AutoSize = true;
            this.checkBox_EnabledFlooder.Location = new System.Drawing.Point(6, 222);
            this.checkBox_EnabledFlooder.Name = "checkBox_EnabledFlooder";
            this.checkBox_EnabledFlooder.Size = new System.Drawing.Size(75, 17);
            this.checkBox_EnabledFlooder.TabIndex = 7;
            this.checkBox_EnabledFlooder.Text = "Включить";
            this.checkBox_EnabledFlooder.UseVisualStyleBackColor = true;
            // 
            // dataGrid_flooder
            // 
            this.dataGrid_flooder.AllowUserToResizeColumns = false;
            this.dataGrid_flooder.AllowUserToResizeRows = false;
            this.dataGrid_flooder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_flooder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGrid_flooder.Location = new System.Drawing.Point(6, 6);
            this.dataGrid_flooder.Name = "dataGrid_flooder";
            this.dataGrid_flooder.RowHeadersVisible = false;
            this.dataGrid_flooder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_flooder.Size = new System.Drawing.Size(645, 210);
            this.dataGrid_flooder.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_SendVoiseMessage);
            this.tabPage2.Controls.Add(this.checkBox_RandomEditMessage);
            this.tabPage2.Controls.Add(this.checkBox_RandomReplyMessage);
            this.tabPage2.Controls.Add(this.checkBox_ExcludeRepetAutoans);
            this.tabPage2.Controls.Add(this.checkBox_ReplyMessage);
            this.tabPage2.Controls.Add(this.numeric_autoansDelay);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button_SaveChangesAutoans);
            this.tabPage2.Controls.Add(this.checkBox_AutoansSetActivity);
            this.tabPage2.Controls.Add(this.checkBox_EnabledAutoans);
            this.tabPage2.Controls.Add(this.dataGrid_Autoans);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автоответчик";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_SendVoiseMessage
            // 
            this.checkBox_SendVoiseMessage.AutoSize = true;
            this.checkBox_SendVoiseMessage.Location = new System.Drawing.Point(376, 242);
            this.checkBox_SendVoiseMessage.Name = "checkBox_SendVoiseMessage";
            this.checkBox_SendVoiseMessage.Size = new System.Drawing.Size(204, 17);
            this.checkBox_SendVoiseMessage.TabIndex = 19;
            this.checkBox_SendVoiseMessage.Text = "Отправлять голосовые сообщения";
            this.checkBox_SendVoiseMessage.UseVisualStyleBackColor = true;
            // 
            // checkBox_RandomEditMessage
            // 
            this.checkBox_RandomEditMessage.AutoSize = true;
            this.checkBox_RandomEditMessage.Location = new System.Drawing.Point(196, 242);
            this.checkBox_RandomEditMessage.Name = "checkBox_RandomEditMessage";
            this.checkBox_RandomEditMessage.Size = new System.Drawing.Size(179, 17);
            this.checkBox_RandomEditMessage.TabIndex = 18;
            this.checkBox_RandomEditMessage.Text = "Рандомно редактировать смс";
            this.checkBox_RandomEditMessage.UseVisualStyleBackColor = true;
            // 
            // checkBox_RandomReplyMessage
            // 
            this.checkBox_RandomReplyMessage.AutoSize = true;
            this.checkBox_RandomReplyMessage.Location = new System.Drawing.Point(471, 222);
            this.checkBox_RandomReplyMessage.Name = "checkBox_RandomReplyMessage";
            this.checkBox_RandomReplyMessage.Size = new System.Drawing.Size(152, 17);
            this.checkBox_RandomReplyMessage.TabIndex = 17;
            this.checkBox_RandomReplyMessage.Text = "Рандом пересылать смс";
            this.checkBox_RandomReplyMessage.UseVisualStyleBackColor = true;
            this.checkBox_RandomReplyMessage.CheckedChanged += new System.EventHandler(this.checkBox_RandomReplyMessage_CheckedChanged);
            // 
            // checkBox_ExcludeRepetAutoans
            // 
            this.checkBox_ExcludeRepetAutoans.AutoSize = true;
            this.checkBox_ExcludeRepetAutoans.Location = new System.Drawing.Point(346, 223);
            this.checkBox_ExcludeRepetAutoans.Name = "checkBox_ExcludeRepetAutoans";
            this.checkBox_ExcludeRepetAutoans.Size = new System.Drawing.Size(128, 17);
            this.checkBox_ExcludeRepetAutoans.TabIndex = 16;
            this.checkBox_ExcludeRepetAutoans.Text = "Исключить повторы";
            this.checkBox_ExcludeRepetAutoans.UseVisualStyleBackColor = true;
            // 
            // checkBox_ReplyMessage
            // 
            this.checkBox_ReplyMessage.AutoSize = true;
            this.checkBox_ReplyMessage.Location = new System.Drawing.Point(196, 224);
            this.checkBox_ReplyMessage.Name = "checkBox_ReplyMessage";
            this.checkBox_ReplyMessage.Size = new System.Drawing.Size(149, 17);
            this.checkBox_ReplyMessage.TabIndex = 15;
            this.checkBox_ReplyMessage.Text = "Пересылать сообщения";
            this.checkBox_ReplyMessage.UseVisualStyleBackColor = true;
            // 
            // numeric_autoansDelay
            // 
            this.numeric_autoansDelay.Location = new System.Drawing.Point(9, 262);
            this.numeric_autoansDelay.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.numeric_autoansDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numeric_autoansDelay.Name = "numeric_autoansDelay";
            this.numeric_autoansDelay.Size = new System.Drawing.Size(194, 20);
            this.numeric_autoansDelay.TabIndex = 10;
            this.numeric_autoansDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Задержка между сообщениями (мс)";
            // 
            // button_SaveChangesAutoans
            // 
            this.button_SaveChangesAutoans.Location = new System.Drawing.Point(209, 262);
            this.button_SaveChangesAutoans.Name = "button_SaveChangesAutoans";
            this.button_SaveChangesAutoans.Size = new System.Drawing.Size(138, 23);
            this.button_SaveChangesAutoans.TabIndex = 12;
            this.button_SaveChangesAutoans.Text = "Сохранить";
            this.button_SaveChangesAutoans.UseVisualStyleBackColor = true;
            this.button_SaveChangesAutoans.Click += new System.EventHandler(this.button_SaveChangesAutoans_Click);
            // 
            // checkBox_AutoansSetActivity
            // 
            this.checkBox_AutoansSetActivity.AutoSize = true;
            this.checkBox_AutoansSetActivity.Location = new System.Drawing.Point(80, 225);
            this.checkBox_AutoansSetActivity.Name = "checkBox_AutoansSetActivity";
            this.checkBox_AutoansSetActivity.Size = new System.Drawing.Size(116, 17);
            this.checkBox_AutoansSetActivity.TabIndex = 14;
            this.checkBox_AutoansSetActivity.Text = "Имитация набора";
            this.checkBox_AutoansSetActivity.UseVisualStyleBackColor = true;
            // 
            // checkBox_EnabledAutoans
            // 
            this.checkBox_EnabledAutoans.AutoSize = true;
            this.checkBox_EnabledAutoans.Location = new System.Drawing.Point(6, 225);
            this.checkBox_EnabledAutoans.Name = "checkBox_EnabledAutoans";
            this.checkBox_EnabledAutoans.Size = new System.Drawing.Size(75, 17);
            this.checkBox_EnabledAutoans.TabIndex = 13;
            this.checkBox_EnabledAutoans.Text = "Включить";
            this.checkBox_EnabledAutoans.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Autoans
            // 
            this.dataGrid_Autoans.AllowUserToResizeColumns = false;
            this.dataGrid_Autoans.AllowUserToResizeRows = false;
            this.dataGrid_Autoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Autoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn1,
            this.Column5,
            this.Column7});
            this.dataGrid_Autoans.Location = new System.Drawing.Point(6, 6);
            this.dataGrid_Autoans.Name = "dataGrid_Autoans";
            this.dataGrid_Autoans.RowHeadersVisible = false;
            this.dataGrid_Autoans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_Autoans.Size = new System.Drawing.Size(625, 210);
            this.dataGrid_Autoans.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 102;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ссылка на цель (лс/чат)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 155;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Кому отвечать (id, цифры)";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn1.Width = 157;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Контент";
            this.Column5.Items.AddRange(new object[] {
            "Текст",
            "Видео",
            "Фото",
            "Текст+фото",
            "Текст+видео",
            "Текст+стикер",
            "Текст+фото+стикер",
            "Текст+видео+стикер",
            "Рандом"});
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Фразы";
            this.Column7.Name = "Column7";
            this.Column7.Width = 107;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButton_CaptAnticaptcha);
            this.tabPage3.Controls.Add(this.radioButton_CaptRucaptcha);
            this.tabPage3.Controls.Add(this.radioButton_CaptManual);
            this.tabPage3.Controls.Add(this.checkBox_OnOffLogger);
            this.tabPage3.Controls.Add(this.ManualCaptBox);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.CaptAns);
            this.tabPage3.Controls.Add(this.CaptPic);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button_GetBalanceCaptcha);
            this.tabPage3.Controls.Add(this.ApiKeyTextBox);
            this.tabPage3.Controls.Add(this.button_saveCaptcha);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Антикапча & Лог";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton_CaptAnticaptcha
            // 
            this.radioButton_CaptAnticaptcha.AutoSize = true;
            this.radioButton_CaptAnticaptcha.Location = new System.Drawing.Point(338, 17);
            this.radioButton_CaptAnticaptcha.Name = "radioButton_CaptAnticaptcha";
            this.radioButton_CaptAnticaptcha.Size = new System.Drawing.Size(147, 17);
            this.radioButton_CaptAnticaptcha.TabIndex = 18;
            this.radioButton_CaptAnticaptcha.TabStop = true;
            this.radioButton_CaptAnticaptcha.Text = "AntiCaptcha (ex anti-gate)";
            this.radioButton_CaptAnticaptcha.UseVisualStyleBackColor = true;
            this.radioButton_CaptAnticaptcha.Click += new System.EventHandler(this.radioButton_CaptManual_CheckedChanged);
            // 
            // radioButton_CaptRucaptcha
            // 
            this.radioButton_CaptRucaptcha.AutoSize = true;
            this.radioButton_CaptRucaptcha.Location = new System.Drawing.Point(253, 17);
            this.radioButton_CaptRucaptcha.Name = "radioButton_CaptRucaptcha";
            this.radioButton_CaptRucaptcha.Size = new System.Drawing.Size(79, 17);
            this.radioButton_CaptRucaptcha.TabIndex = 17;
            this.radioButton_CaptRucaptcha.TabStop = true;
            this.radioButton_CaptRucaptcha.Text = "RuCaptcha";
            this.radioButton_CaptRucaptcha.UseVisualStyleBackColor = true;
            this.radioButton_CaptRucaptcha.Click += new System.EventHandler(this.radioButton_CaptManual_CheckedChanged);
            // 
            // radioButton_CaptManual
            // 
            this.radioButton_CaptManual.AutoSize = true;
            this.radioButton_CaptManual.Location = new System.Drawing.Point(180, 17);
            this.radioButton_CaptManual.Name = "radioButton_CaptManual";
            this.radioButton_CaptManual.Size = new System.Drawing.Size(67, 17);
            this.radioButton_CaptManual.TabIndex = 16;
            this.radioButton_CaptManual.TabStop = true;
            this.radioButton_CaptManual.Text = "Вручную";
            this.radioButton_CaptManual.UseVisualStyleBackColor = true;
            this.radioButton_CaptManual.CheckedChanged += new System.EventHandler(this.radioButton_CaptManual_CheckedChanged);
            // 
            // checkBox_OnOffLogger
            // 
            this.checkBox_OnOffLogger.AutoSize = true;
            this.checkBox_OnOffLogger.Location = new System.Drawing.Point(6, 265);
            this.checkBox_OnOffLogger.Name = "checkBox_OnOffLogger";
            this.checkBox_OnOffLogger.Size = new System.Drawing.Size(149, 17);
            this.checkBox_OnOffLogger.TabIndex = 13;
            this.checkBox_OnOffLogger.Text = "Отключить логирование";
            this.checkBox_OnOffLogger.UseVisualStyleBackColor = true;
            this.checkBox_OnOffLogger.CheckedChanged += new System.EventHandler(this.checkBox_OnOffLogger_CheckedChanged);
            // 
            // ManualCaptBox
            // 
            this.ManualCaptBox.Location = new System.Drawing.Point(321, 54);
            this.ManualCaptBox.Name = "ManualCaptBox";
            this.ManualCaptBox.Size = new System.Drawing.Size(120, 20);
            this.ManualCaptBox.TabIndex = 12;
            this.ManualCaptBox.Visible = false;
            this.ManualCaptBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManualCaptBox_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(625, 128);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // CaptAns
            // 
            this.CaptAns.Location = new System.Drawing.Point(321, 80);
            this.CaptAns.Name = "CaptAns";
            this.CaptAns.Size = new System.Drawing.Size(120, 23);
            this.CaptAns.TabIndex = 11;
            this.CaptAns.Text = "Ответить/Enter";
            this.CaptAns.UseVisualStyleBackColor = true;
            this.CaptAns.Visible = false;
            this.CaptAns.Click += new System.EventHandler(this.CaptAns_Click);
            // 
            // CaptPic
            // 
            this.CaptPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptPic.Location = new System.Drawing.Point(185, 53);
            this.CaptPic.Name = "CaptPic";
            this.CaptPic.Size = new System.Drawing.Size(130, 50);
            this.CaptPic.TabIndex = 10;
            this.CaptPic.TabStop = false;
            this.CaptPic.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "API key";
            // 
            // button_GetBalanceCaptcha
            // 
            this.button_GetBalanceCaptcha.Location = new System.Drawing.Point(433, 89);
            this.button_GetBalanceCaptcha.Name = "button_GetBalanceCaptcha";
            this.button_GetBalanceCaptcha.Size = new System.Drawing.Size(120, 23);
            this.button_GetBalanceCaptcha.TabIndex = 8;
            this.button_GetBalanceCaptcha.Text = "Запросить баланс";
            this.button_GetBalanceCaptcha.UseVisualStyleBackColor = true;
            this.button_GetBalanceCaptcha.Click += new System.EventHandler(this.button_GetBalanceCaptcha_Click);
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.Location = new System.Drawing.Point(103, 63);
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.Size = new System.Drawing.Size(450, 20);
            this.ApiKeyTextBox.TabIndex = 0;
            // 
            // button_saveCaptcha
            // 
            this.button_saveCaptcha.Location = new System.Drawing.Point(103, 89);
            this.button_saveCaptcha.Name = "button_saveCaptcha";
            this.button_saveCaptcha.Size = new System.Drawing.Size(324, 23);
            this.button_saveCaptcha.TabIndex = 2;
            this.button_saveCaptcha.Text = "Сохранить";
            this.button_saveCaptcha.UseVisualStyleBackColor = true;
            this.button_saveCaptcha.Click += new System.EventHandler(this.button_saveCaptcha_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.check_Box_EnabledStopWatch);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.numericWatch);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.textBox_FromId);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.textbox_IdBound);
            this.tabPage5.Controls.Add(this.button_SaveChangesWatch);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(668, 293);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Счетчик игнора";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // check_Box_EnabledStopWatch
            // 
            this.check_Box_EnabledStopWatch.AutoSize = true;
            this.check_Box_EnabledStopWatch.Location = new System.Drawing.Point(457, 157);
            this.check_Box_EnabledStopWatch.Name = "check_Box_EnabledStopWatch";
            this.check_Box_EnabledStopWatch.Size = new System.Drawing.Size(82, 17);
            this.check_Box_EnabledStopWatch.TabIndex = 10;
            this.check_Box_EnabledStopWatch.Text = "Включено?";
            this.check_Box_EnabledStopWatch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Допустимое время";
            // 
            // numericWatch
            // 
            this.numericWatch.Location = new System.Drawing.Point(157, 153);
            this.numericWatch.Name = "numericWatch";
            this.numericWatch.Size = new System.Drawing.Size(296, 20);
            this.numericWatch.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Кому уведомлять (ID)";
            // 
            // textBox_FromId
            // 
            this.textBox_FromId.Location = new System.Drawing.Point(350, 107);
            this.textBox_FromId.Name = "textBox_FromId";
            this.textBox_FromId.Size = new System.Drawing.Size(116, 20);
            this.textBox_FromId.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID жертвы (через запятую)";
            // 
            // textbox_IdBound
            // 
            this.textbox_IdBound.Location = new System.Drawing.Point(157, 107);
            this.textbox_IdBound.Name = "textbox_IdBound";
            this.textbox_IdBound.Size = new System.Drawing.Size(187, 20);
            this.textbox_IdBound.TabIndex = 1;
            // 
            // button_SaveChangesWatch
            // 
            this.button_SaveChangesWatch.Location = new System.Drawing.Point(157, 178);
            this.button_SaveChangesWatch.Name = "button_SaveChangesWatch";
            this.button_SaveChangesWatch.Size = new System.Drawing.Size(296, 26);
            this.button_SaveChangesWatch.TabIndex = 0;
            this.button_SaveChangesWatch.Text = "Сохранить";
            this.button_SaveChangesWatch.UseVisualStyleBackColor = true;
            this.button_SaveChangesWatch.Click += new System.EventHandler(this.button_SaveChangesWatch_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(668, 293);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Справка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button_GetIdUser);
            this.tabPage6.Controls.Add(this.textBox_Domains);
            this.tabPage6.Controls.Add(this.button_getConversations);
            this.tabPage6.Controls.Add(this.comboBox_conversationsList);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(668, 293);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Дополнительно";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button_GetIdUser
            // 
            this.button_GetIdUser.Location = new System.Drawing.Point(204, 164);
            this.button_GetIdUser.Name = "button_GetIdUser";
            this.button_GetIdUser.Size = new System.Drawing.Size(280, 23);
            this.button_GetIdUser.TabIndex = 3;
            this.button_GetIdUser.Text = "Получить ID пользователя";
            this.button_GetIdUser.UseVisualStyleBackColor = true;
            this.button_GetIdUser.Click += new System.EventHandler(this.button_GetIdUser_Click);
            // 
            // textBox_Domains
            // 
            this.textBox_Domains.Location = new System.Drawing.Point(204, 138);
            this.textBox_Domains.Name = "textBox_Domains";
            this.textBox_Domains.Size = new System.Drawing.Size(280, 20);
            this.textBox_Domains.TabIndex = 2;
            // 
            // button_getConversations
            // 
            this.button_getConversations.Location = new System.Drawing.Point(204, 109);
            this.button_getConversations.Name = "button_getConversations";
            this.button_getConversations.Size = new System.Drawing.Size(280, 23);
            this.button_getConversations.TabIndex = 1;
            this.button_getConversations.Text = "Получить последние 100 чатов";
            this.button_getConversations.UseVisualStyleBackColor = true;
            this.button_getConversations.Click += new System.EventHandler(this.button_getConversations_Click);
            // 
            // comboBox_conversationsList
            // 
            this.comboBox_conversationsList.FormattingEnabled = true;
            this.comboBox_conversationsList.Location = new System.Drawing.Point(204, 82);
            this.comboBox_conversationsList.Name = "comboBox_conversationsList";
            this.comboBox_conversationsList.Size = new System.Drawing.Size(280, 21);
            this.comboBox_conversationsList.TabIndex = 0;
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Enabled = true;
            this.TimerUpdate.Interval = 1000;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // TimerCaptcha
            // 
            this.TimerCaptcha.Enabled = true;
            this.TimerCaptcha.Interval = 1000;
            this.TimerCaptcha.Tick += new System.EventHandler(this.TimerCaptcha_Tick);
            // 
            // comboBox_accountsList
            // 
            this.comboBox_accountsList.FormattingEnabled = true;
            this.comboBox_accountsList.Location = new System.Drawing.Point(12, 337);
            this.comboBox_accountsList.Name = "comboBox_accountsList";
            this.comboBox_accountsList.Size = new System.Drawing.Size(672, 21);
            this.comboBox_accountsList.TabIndex = 6;
            this.comboBox_accountsList.Text = "Загрузка...";
            this.comboBox_accountsList.SelectedIndexChanged += new System.EventHandler(this.comboBox_accountsList_SelectedIndexChanged);
            // 
            // button_StartStopBot
            // 
            this.button_StartStopBot.Location = new System.Drawing.Point(12, 364);
            this.button_StartStopBot.Name = "button_StartStopBot";
            this.button_StartStopBot.Size = new System.Drawing.Size(197, 23);
            this.button_StartStopBot.TabIndex = 14;
            this.button_StartStopBot.Text = "Старт";
            this.button_StartStopBot.UseVisualStyleBackColor = true;
            this.button_StartStopBot.Click += new System.EventHandler(this.button_StartStopBot_Click);
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.Interval = 1000;
            this.TimerCountDown.Tick += new System.EventHandler(this.TimerCountDown_Tick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Обращение";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ссылка на цель (лс/чат)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 155;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Расположение обращения";
            this.Column3.Items.AddRange(new object[] {
            "Начало",
            "Конец"});
            this.Column3.Name = "Column3";
            this.Column3.Width = 152;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Содержимое";
            this.Column4.Items.AddRange(new object[] {
            "Текст",
            "Видео",
            "Фото",
            "Текст+фото",
            "Текст+видео",
            "Текст+стикер",
            "Текст+фото+стикер",
            "Текст+видео+стикер",
            "Запись",
            "Рандом"});
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 115;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Фразы";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "След. Отправка через: 0 мс.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.button_StartStopBot);
            this.Controls.Add(this.comboBox_accountsList);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VkUp";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DelayFlooderMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DelayFlooderMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_flooder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_autoansDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Autoans)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptPic)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_TypeDelay;
        private System.Windows.Forms.NumericUpDown numeric_DelayFlooderMax;
        private System.Windows.Forms.NumericUpDown numeric_DelayFlooderMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_SaveChangesFlooder;
        private System.Windows.Forms.CheckBox checkBox_setActivity;
        private System.Windows.Forms.CheckBox checkBox_EnabledFlooder;
        private System.Windows.Forms.DataGridView dataGrid_flooder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_ReplyMessage;
        private System.Windows.Forms.NumericUpDown numeric_autoansDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SaveChangesAutoans;
        private System.Windows.Forms.CheckBox checkBox_AutoansSetActivity;
        private System.Windows.Forms.CheckBox checkBox_EnabledAutoans;
        private System.Windows.Forms.DataGridView dataGrid_Autoans;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButton_CaptAnticaptcha;
        private System.Windows.Forms.RadioButton radioButton_CaptRucaptcha;
        private System.Windows.Forms.RadioButton radioButton_CaptManual;
        private System.Windows.Forms.CheckBox checkBox_OnOffLogger;
        private System.Windows.Forms.TextBox ManualCaptBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CaptAns;
        private System.Windows.Forms.PictureBox CaptPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_GetBalanceCaptcha;
        private System.Windows.Forms.TextBox ApiKeyTextBox;
        private System.Windows.Forms.Button button_saveCaptcha;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox check_Box_EnabledStopWatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numericWatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_FromId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_IdBound;
        private System.Windows.Forms.Button button_SaveChangesWatch;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Timer TimerUpdate;
        private System.Windows.Forms.Timer TimerCaptcha;
        private System.Windows.Forms.ComboBox comboBox_accountsList;
        private System.Windows.Forms.Button button_StartStopBot;
        private System.Windows.Forms.CheckBox checkBox_ReadMessage;
        private System.Windows.Forms.CheckBox checkBox_AllTarget;
        private System.Windows.Forms.CheckBox checkBox_ExcludeRepetFlooder;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button_getConversations;
        private System.Windows.Forms.ComboBox comboBox_conversationsList;
        private System.Windows.Forms.Timer TimerCountDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.Button button_GetIdUser;
        private System.Windows.Forms.TextBox textBox_Domains;
        private System.Windows.Forms.CheckBox checkBox_ExcludeRepetAutoans;
        private System.Windows.Forms.CheckBox checkBox_RandomEditMessage;
        private System.Windows.Forms.CheckBox checkBox_RandomReplyMessage;
        private System.Windows.Forms.CheckBox checkBox_SendVoiseMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.Label label1;
    }
}