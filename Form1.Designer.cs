
namespace Lab2SharpForms
{
    partial class Form1
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PassportIDTextBox = new System.Windows.Forms.TextBox();
            this.accountSumNumerical = new System.Windows.Forms.NumericUpDown();
            this.SMSTrueRadio = new System.Windows.Forms.RadioButton();
            this.SMSFalseRadio = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.onlineBanking = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.operationSum = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.operationTypeList = new System.Windows.Forms.ComboBox();
            this.commitOperationButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.accountIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SMSGroupBox = new System.Windows.Forms.GroupBox();
            this.onlineBankingBox = new System.Windows.Forms.GroupBox();
            this.onlineBankingTrue = new System.Windows.Forms.RadioButton();
            this.onlineBankingFalse = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.operationSumValueLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.registrationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthDatePciker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBank = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMSNotifications = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OnlineBankingColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchFilterDropdownList = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.advancedSearchButton = new System.Windows.Forms.Button();
            this.sortDropdownList = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastActionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.objectCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.accountSumNumerical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationSum)).BeginInit();
            this.SMSGroupBox.SuspendLayout();
            this.onlineBankingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBank)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(130, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(183, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // PassportIDTextBox
            // 
            this.PassportIDTextBox.Location = new System.Drawing.Point(130, 64);
            this.PassportIDTextBox.Name = "PassportIDTextBox";
            this.PassportIDTextBox.Size = new System.Drawing.Size(183, 20);
            this.PassportIDTextBox.TabIndex = 0;
            // 
            // accountSumNumerical
            // 
            this.accountSumNumerical.Location = new System.Drawing.Point(480, 67);
            this.accountSumNumerical.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.accountSumNumerical.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.accountSumNumerical.Name = "accountSumNumerical";
            this.accountSumNumerical.Size = new System.Drawing.Size(183, 20);
            this.accountSumNumerical.TabIndex = 1;
            // 
            // SMSTrueRadio
            // 
            this.SMSTrueRadio.AutoSize = true;
            this.SMSTrueRadio.Location = new System.Drawing.Point(6, 11);
            this.SMSTrueRadio.Name = "SMSTrueRadio";
            this.SMSTrueRadio.Size = new System.Drawing.Size(40, 17);
            this.SMSTrueRadio.TabIndex = 2;
            this.SMSTrueRadio.TabStop = true;
            this.SMSTrueRadio.Text = "Да";
            this.SMSTrueRadio.UseVisualStyleBackColor = true;
            // 
            // SMSFalseRadio
            // 
            this.SMSFalseRadio.AutoSize = true;
            this.SMSFalseRadio.Location = new System.Drawing.Point(109, 11);
            this.SMSFalseRadio.Name = "SMSFalseRadio";
            this.SMSFalseRadio.Size = new System.Drawing.Size(44, 17);
            this.SMSFalseRadio.TabIndex = 2;
            this.SMSFalseRadio.TabStop = true;
            this.SMSFalseRadio.Text = "Нет";
            this.SMSFalseRadio.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер счета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сумма счёта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SMS-уведомления";
            // 
            // onlineBanking
            // 
            this.onlineBanking.AutoSize = true;
            this.onlineBanking.Enabled = false;
            this.onlineBanking.Location = new System.Drawing.Point(371, 152);
            this.onlineBanking.Name = "onlineBanking";
            this.onlineBanking.Size = new System.Drawing.Size(90, 13);
            this.onlineBanking.TabIndex = 4;
            this.onlineBanking.Text = "Онлайн-Банкинг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Дата создания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Сумма операции";
            // 
            // operationSum
            // 
            this.operationSum.Location = new System.Drawing.Point(851, 86);
            this.operationSum.Maximum = 5000;
            this.operationSum.Name = "operationSum";
            this.operationSum.Size = new System.Drawing.Size(243, 45);
            this.operationSum.TabIndex = 6;
            this.operationSum.Scroll += new System.EventHandler(this.operationSum_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Тип операции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения";
            // 
            // operationTypeList
            // 
            this.operationTypeList.FormattingEnabled = true;
            this.operationTypeList.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.operationTypeList.Location = new System.Drawing.Point(851, 29);
            this.operationTypeList.Name = "operationTypeList";
            this.operationTypeList.Size = new System.Drawing.Size(243, 21);
            this.operationTypeList.TabIndex = 7;
            // 
            // commitOperationButton
            // 
            this.commitOperationButton.Location = new System.Drawing.Point(759, 167);
            this.commitOperationButton.Name = "commitOperationButton";
            this.commitOperationButton.Size = new System.Drawing.Size(126, 39);
            this.commitOperationButton.TabIndex = 9;
            this.commitOperationButton.Text = "Выполнить операцию";
            this.commitOperationButton.UseVisualStyleBackColor = true;
            this.commitOperationButton.Click += new System.EventHandler(this.commitOperationButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1072, 335);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 39);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1153, 335);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(78, 39);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(480, 29);
            this.accountIdTextBox.Mask = "00000";
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(183, 20);
            this.accountIdTextBox.TabIndex = 10;
            // 
            // SMSGroupBox
            // 
            this.SMSGroupBox.Controls.Add(this.SMSTrueRadio);
            this.SMSGroupBox.Controls.Add(this.SMSFalseRadio);
            this.SMSGroupBox.Location = new System.Drawing.Point(480, 93);
            this.SMSGroupBox.Name = "SMSGroupBox";
            this.SMSGroupBox.Size = new System.Drawing.Size(183, 38);
            this.SMSGroupBox.TabIndex = 11;
            this.SMSGroupBox.TabStop = false;
            // 
            // onlineBankingBox
            // 
            this.onlineBankingBox.Controls.Add(this.onlineBankingTrue);
            this.onlineBankingBox.Controls.Add(this.onlineBankingFalse);
            this.onlineBankingBox.Location = new System.Drawing.Point(480, 141);
            this.onlineBankingBox.Name = "onlineBankingBox";
            this.onlineBankingBox.Size = new System.Drawing.Size(183, 38);
            this.onlineBankingBox.TabIndex = 11;
            this.onlineBankingBox.TabStop = false;
            // 
            // onlineBankingTrue
            // 
            this.onlineBankingTrue.AutoSize = true;
            this.onlineBankingTrue.Location = new System.Drawing.Point(6, 15);
            this.onlineBankingTrue.Name = "onlineBankingTrue";
            this.onlineBankingTrue.Size = new System.Drawing.Size(40, 17);
            this.onlineBankingTrue.TabIndex = 2;
            this.onlineBankingTrue.TabStop = true;
            this.onlineBankingTrue.Text = "Да";
            this.onlineBankingTrue.UseVisualStyleBackColor = true;
            // 
            // onlineBankingFalse
            // 
            this.onlineBankingFalse.AutoSize = true;
            this.onlineBankingFalse.Location = new System.Drawing.Point(109, 15);
            this.onlineBankingFalse.Name = "onlineBankingFalse";
            this.onlineBankingFalse.Size = new System.Drawing.Size(44, 17);
            this.onlineBankingFalse.TabIndex = 2;
            this.onlineBankingFalse.TabStop = true;
            this.onlineBankingFalse.Text = "Нет";
            this.onlineBankingFalse.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1081, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "5000";
            // 
            // operationSumValueLabel
            // 
            this.operationSumValueLabel.AutoSize = true;
            this.operationSumValueLabel.Location = new System.Drawing.Point(956, 134);
            this.operationSumValueLabel.Name = "operationSumValueLabel";
            this.operationSumValueLabel.Size = new System.Drawing.Size(0, 13);
            this.operationSumValueLabel.TabIndex = 12;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(1072, 292);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.fileNameTextBox.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 631);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1002, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Имя файла";
            // 
            // registrationDatePicker
            // 
            this.registrationDatePicker.Location = new System.Drawing.Point(480, 195);
            this.registrationDatePicker.Name = "registrationDatePicker";
            this.registrationDatePicker.Size = new System.Drawing.Size(200, 20);
            this.registrationDatePicker.TabIndex = 13;
            // 
            // birthDatePciker
            // 
            this.birthDatePciker.Location = new System.Drawing.Point(130, 106);
            this.birthDatePciker.Name = "birthDatePciker";
            this.birthDatePciker.Size = new System.Drawing.Size(200, 20);
            this.birthDatePciker.TabIndex = 13;
            // 
            // dataGridViewBank
            // 
            this.dataGridViewBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.PassportID,
            this.BirthDate,
            this.AccountId,
            this.AccountBalance,
            this.SMSNotifications,
            this.OnlineBankingColumn,
            this.AccountDate,
            this.DeleteRowButton});
            this.dataGridViewBank.Location = new System.Drawing.Point(12, 398);
            this.dataGridViewBank.Name = "dataGridViewBank";
            this.dataGridViewBank.Size = new System.Drawing.Size(1043, 200);
            this.dataGridViewBank.TabIndex = 14;
            this.dataGridViewBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBank_CellClick);
            this.dataGridViewBank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewBank.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewBank_RowStateChanged);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PassportID
            // 
            this.PassportID.HeaderText = "Номер паспорта";
            this.PassportID.Name = "PassportID";
            this.PassportID.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.FillWeight = 150F;
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 150;
            // 
            // AccountId
            // 
            this.AccountId.HeaderText = "Номер счёта";
            this.AccountId.Name = "AccountId";
            this.AccountId.ReadOnly = true;
            // 
            // AccountBalance
            // 
            this.AccountBalance.HeaderText = "Сумма счёта";
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.ReadOnly = true;
            // 
            // SMSNotifications
            // 
            this.SMSNotifications.HeaderText = "SMS-уведомления";
            this.SMSNotifications.Name = "SMSNotifications";
            this.SMSNotifications.ReadOnly = true;
            // 
            // OnlineBankingColumn
            // 
            this.OnlineBankingColumn.HeaderText = "Онлайн-Банкинг";
            this.OnlineBankingColumn.Name = "OnlineBankingColumn";
            // 
            // AccountDate
            // 
            this.AccountDate.FillWeight = 150F;
            this.AccountDate.HeaderText = "Дата создания";
            this.AccountDate.Name = "AccountDate";
            this.AccountDate.ReadOnly = true;
            this.AccountDate.Width = 150;
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.HeaderText = "Удалить строку";
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.ReadOnly = true;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(24, 335);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(126, 39);
            this.AddRowButton.TabIndex = 15;
            this.AddRowButton.Text = "Добавить строку";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(1072, 398);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(157, 200);
            this.resultRichTextBox.TabIndex = 16;
            this.resultRichTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Поиск";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(540, 342);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(245, 20);
            this.searchTextBox.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(795, 335);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 39);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchFilterDropdownList
            // 
            this.searchFilterDropdownList.FormattingEnabled = true;
            this.searchFilterDropdownList.Items.AddRange(new object[] {
            "ФИО",
            "Баланс",
            "Номер счёта"});
            this.searchFilterDropdownList.Location = new System.Drawing.Point(305, 342);
            this.searchFilterDropdownList.Name = "searchFilterDropdownList";
            this.searchFilterDropdownList.Size = new System.Drawing.Size(184, 21);
            this.searchFilterDropdownList.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(203, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Фильтр поиска";
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.Location = new System.Drawing.Point(889, 335);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(88, 39);
            this.advancedSearchButton.TabIndex = 22;
            this.advancedSearchButton.Text = "Расширенный поиск";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            this.advancedSearchButton.Click += new System.EventHandler(this.advancedSearchButton_Click);
            // 
            // sortDropdownList
            // 
            this.sortDropdownList.FormattingEnabled = true;
            this.sortDropdownList.Items.AddRange(new object[] {
            "ФИО",
            "Дата создания счёта"});
            this.sortDropdownList.Location = new System.Drawing.Point(305, 297);
            this.sortDropdownList.Name = "sortDropdownList";
            this.sortDropdownList.Size = new System.Drawing.Size(184, 21);
            this.sortDropdownList.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Фильтр сортировки";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(511, 287);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(88, 39);
            this.sortButton.TabIndex = 25;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.timeStatusLabel,
            this.toolStripStatusLabel2,
            this.lastActionStatusLabel,
            this.toolStripStatusLabel4,
            this.objectCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1258, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel1.Text = "Текущее время:";
            // 
            // timeStatusLabel
            // 
            this.timeStatusLabel.Name = "timeStatusLabel";
            this.timeStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel2.Text = "Последнее действие:";
            // 
            // lastActionStatusLabel
            // 
            this.lastActionStatusLabel.Name = "lastActionStatusLabel";
            this.lastActionStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel4.Text = "Количество объектов:";
            // 
            // objectCountStatusLabel
            // 
            this.objectCountStatusLabel.Name = "objectCountStatusLabel";
            this.objectCountStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.objectCountStatusLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 610);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortDropdownList);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.advancedSearchButton);
            this.Controls.Add(this.searchFilterDropdownList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.dataGridViewBank);
            this.Controls.Add(this.birthDatePciker);
            this.Controls.Add(this.registrationDatePicker);
            this.Controls.Add(this.operationSumValueLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.onlineBankingBox);
            this.Controls.Add(this.SMSGroupBox);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.commitOperationButton);
            this.Controls.Add(this.operationTypeList);
            this.Controls.Add(this.operationSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.onlineBanking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.accountSumNumerical);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.PassportIDTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountSumNumerical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationSum)).EndInit();
            this.SMSGroupBox.ResumeLayout(false);
            this.SMSGroupBox.PerformLayout();
            this.onlineBankingBox.ResumeLayout(false);
            this.onlineBankingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBank)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PassportIDTextBox;
        private System.Windows.Forms.NumericUpDown accountSumNumerical;
        private System.Windows.Forms.RadioButton SMSTrueRadio;
        private System.Windows.Forms.RadioButton SMSFalseRadio;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label onlineBanking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar operationSum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox operationTypeList;
        private System.Windows.Forms.Button commitOperationButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.MaskedTextBox accountIdTextBox;
        private System.Windows.Forms.GroupBox SMSGroupBox;
        private System.Windows.Forms.GroupBox onlineBankingBox;
        private System.Windows.Forms.RadioButton onlineBankingTrue;
        private System.Windows.Forms.RadioButton onlineBankingFalse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label operationSumValueLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker registrationDatePicker;
        private System.Windows.Forms.DateTimePicker birthDatePciker;
        private System.Windows.Forms.DataGridView dataGridViewBank;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SMSNotifications;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnlineBankingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRowButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchFilterDropdownList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button advancedSearchButton;
        private System.Windows.Forms.ComboBox sortDropdownList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel timeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lastActionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel objectCountStatusLabel;
    }
}

