
namespace Lab2SharpForms
{
    partial class AdvancedSearchForm
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
            this.searchFilterDropdownList1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchTextBox1 = new System.Windows.Forms.TextBox();
            this.searchRegexDropdownList1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchRegexValue1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrRadio2 = new System.Windows.Forms.RadioButton();
            this.andRadio2 = new System.Windows.Forms.RadioButton();
            this.searchRegexDropdownList2 = new System.Windows.Forms.ComboBox();
            this.searchTextBox2 = new System.Windows.Forms.TextBox();
            this.searchFilterDropdownList2 = new System.Windows.Forms.ComboBox();
            this.searchRegexValue2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchFilterDropdownList1
            // 
            this.searchFilterDropdownList1.FormattingEnabled = true;
            this.searchFilterDropdownList1.Items.AddRange(new object[] {
            "ФИО",
            "Баланс",
            "Номер счёта"});
            this.searchFilterDropdownList1.Location = new System.Drawing.Point(10, 11);
            this.searchFilterDropdownList1.Name = "searchFilterDropdownList1";
            this.searchFilterDropdownList1.Size = new System.Drawing.Size(184, 21);
            this.searchFilterDropdownList1.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Фильтр поиска";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Поиск";
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.Location = new System.Drawing.Point(216, 12);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(182, 20);
            this.searchTextBox1.TabIndex = 22;
            // 
            // searchRegexDropdownList1
            // 
            this.searchRegexDropdownList1.FormattingEnabled = true;
            this.searchRegexDropdownList1.Items.AddRange(new object[] {
            "Подстрока",
            "Количество совпадений",
            "Индекс вхождения"});
            this.searchRegexDropdownList1.Location = new System.Drawing.Point(418, 12);
            this.searchRegexDropdownList1.Name = "searchRegexDropdownList1";
            this.searchRegexDropdownList1.Size = new System.Drawing.Size(184, 21);
            this.searchRegexDropdownList1.TabIndex = 26;
            this.searchRegexDropdownList1.SelectedIndexChanged += new System.EventHandler(this.searchRegexDropdownList1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Регулярное выражение";
            // 
            // searchRegexValue1
            // 
            this.searchRegexValue1.Location = new System.Drawing.Point(618, 13);
            this.searchRegexValue1.Name = "searchRegexValue1";
            this.searchRegexValue1.ReadOnly = true;
            this.searchRegexValue1.Size = new System.Drawing.Size(111, 20);
            this.searchRegexValue1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Значение";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchRegexDropdownList1);
            this.panel1.Controls.Add(this.searchTextBox1);
            this.panel1.Controls.Add(this.searchFilterDropdownList1);
            this.panel1.Controls.Add(this.searchRegexValue1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 43);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrRadio2);
            this.panel2.Controls.Add(this.andRadio2);
            this.panel2.Controls.Add(this.searchRegexDropdownList2);
            this.panel2.Controls.Add(this.searchTextBox2);
            this.panel2.Controls.Add(this.searchFilterDropdownList2);
            this.panel2.Controls.Add(this.searchRegexValue2);
            this.panel2.Location = new System.Drawing.Point(64, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 43);
            this.panel2.TabIndex = 35;
            this.panel2.Visible = false;
            // 
            // OrRadio2
            // 
            this.OrRadio2.AutoSize = true;
            this.OrRadio2.Location = new System.Drawing.Point(789, 14);
            this.OrRadio2.Name = "OrRadio2";
            this.OrRadio2.Size = new System.Drawing.Size(49, 17);
            this.OrRadio2.TabIndex = 29;
            this.OrRadio2.TabStop = true;
            this.OrRadio2.Text = "ИЛИ";
            this.OrRadio2.UseVisualStyleBackColor = true;
            // 
            // andRadio2
            // 
            this.andRadio2.AutoSize = true;
            this.andRadio2.Location = new System.Drawing.Point(750, 14);
            this.andRadio2.Name = "andRadio2";
            this.andRadio2.Size = new System.Drawing.Size(33, 17);
            this.andRadio2.TabIndex = 29;
            this.andRadio2.TabStop = true;
            this.andRadio2.Text = "И";
            this.andRadio2.UseVisualStyleBackColor = true;
            // 
            // searchRegexDropdownList2
            // 
            this.searchRegexDropdownList2.FormattingEnabled = true;
            this.searchRegexDropdownList2.Items.AddRange(new object[] {
            "Подстрока",
            "Количество совпадений",
            "Индекс вхождения"});
            this.searchRegexDropdownList2.Location = new System.Drawing.Point(418, 12);
            this.searchRegexDropdownList2.Name = "searchRegexDropdownList2";
            this.searchRegexDropdownList2.Size = new System.Drawing.Size(184, 21);
            this.searchRegexDropdownList2.TabIndex = 26;
            this.searchRegexDropdownList2.SelectedIndexChanged += new System.EventHandler(this.searchRegexDropdownList2_SelectedIndexChanged);
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.Location = new System.Drawing.Point(216, 12);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.Size = new System.Drawing.Size(182, 20);
            this.searchTextBox2.TabIndex = 22;
            // 
            // searchFilterDropdownList2
            // 
            this.searchFilterDropdownList2.FormattingEnabled = true;
            this.searchFilterDropdownList2.Items.AddRange(new object[] {
            "ФИО",
            "Баланс",
            "Номер счёта"});
            this.searchFilterDropdownList2.Location = new System.Drawing.Point(10, 11);
            this.searchFilterDropdownList2.Name = "searchFilterDropdownList2";
            this.searchFilterDropdownList2.Size = new System.Drawing.Size(184, 21);
            this.searchFilterDropdownList2.TabIndex = 25;
            // 
            // searchRegexValue2
            // 
            this.searchRegexValue2.Location = new System.Drawing.Point(618, 13);
            this.searchRegexValue2.Name = "searchRegexValue2";
            this.searchRegexValue2.ReadOnly = true;
            this.searchRegexValue2.Size = new System.Drawing.Size(111, 20);
            this.searchRegexValue2.TabIndex = 28;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Location = new System.Drawing.Point(12, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 176);
            this.panel3.TabIndex = 38;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(780, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 43);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // AdvancedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Name = "AdvancedSearchForm";
            this.Text = "AdvancedSearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchFilterDropdownList1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchTextBox1;
        private System.Windows.Forms.ComboBox searchRegexDropdownList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchRegexValue1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton OrRadio2;
        private System.Windows.Forms.RadioButton andRadio2;
        private System.Windows.Forms.ComboBox searchRegexDropdownList2;
        private System.Windows.Forms.TextBox searchTextBox2;
        private System.Windows.Forms.ComboBox searchFilterDropdownList2;
        private System.Windows.Forms.TextBox searchRegexValue2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button searchButton;
    }
}