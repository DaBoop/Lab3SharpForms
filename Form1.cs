using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Lab2SharpForms
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        

        int selectedRowIndex = -1;
        List<Account> accountList = new List<Account>(); 
        History history = new History();
       

        public Form1()
        {
            SingletonSettings.GetInstance();
            //
            InitializeComponent();
            fileNameTextBox.Text = "bank.xml";
            searchFilterDropdownList.SelectedIndex = 0;
            sortDropdownList.SelectedIndex = 0;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;           
            timer.Start();

           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeStatusLabel.Text = DateTime.Now.ToString("f");
        }

        public void Serialize(string filename, Type type, object obj)
        {
            
            var serializer = new XmlSerializer(type);
            using (var stream = new StreamWriter(filename))
            {
                serializer.Serialize(stream,obj);
            }

        }

        public object Deserialize(string filename, Type type)
        {

            var serializer = new XmlSerializer(type);
            using (var stream = new StreamReader(filename))
            {
                return serializer.Deserialize(stream);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.TextLength == 0 || fileNameTextBox.Text.ToArray().Any(x => Path.GetInvalidFileNameChars().Contains(x)))
            {
                resultRichTextBox.Text = "Неправильное имя файла";

            }   
            else
            {
                try
                {
                    Serialize(fileNameTextBox.Text, typeof(List<Account>), accountList);
                }
                catch (Exception excep)
                {
                    resultRichTextBox.Text = "Неправильное имя файла\n" + excep.Message;
                }
                resultRichTextBox.Text = "Счет успешно сохранен!";
                
            }

            lastActionStatusLabel.Text = "SaveButton_Click";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            
            if (fileNameTextBox.TextLength == 0 || fileNameTextBox.Text.ToArray().Any(x => Path.GetInvalidFileNameChars().Contains(x)))
            {
                resultRichTextBox.Text = "Неправильное имя файла";

            }
            else
            {
                try
                {
                    dataGridViewBank.Rows.Clear();
                    accountList = (List<Account>)Deserialize(fileNameTextBox.Text, typeof(List<Account>));
                    foreach (Account entry in accountList)
                    {
                        dataGridViewBank.Rows.Add(
                        entry.AccountOwner.FullName,
                        entry.AccountOwner.PassportID,
                        entry.AccountOwner.BirthDate,
                        entry.ID,
                        entry.Balance,
                        entry.SMSNotification,
                        entry.OnlineBanking,
                        entry.StartDate
                        );
                    }
                    //resultRichTextBox.Text = "Счет успешно загружен:\n";
                    //    + $"===Владелец===\nФИО: {acc.AccountOwner.FullName}\nНомер паспорта: {acc.AccountOwner.PassportID}\nДата рождения: {acc.AccountOwner.BirthDate.ToString("d")}\n"
                    //    + $"===Счет====\nНомер счета: {acc.ID}\nБаланс: {acc.Balance}\nОнлайн-Банкинг: {acc.OnlineBanking}\nСМС-Уведомления: {acc.SMSNotification}\nДата Создания: {acc.StartDate.ToString("d")}\n";
                    selectedRowIndex = -1;
                }
                catch (Exception excep)
                {
                    resultRichTextBox.Text = "Неправильное имя файла\n" + excep.Message;
                }
            }
            lastActionStatusLabel.Text = "LoadButton_Click";
        }

        private void commitOperationButton_Click(object sender, EventArgs e)
        {
            //resultRichTextBox.Text = $"Операция \"{operationTypeList.Text}\" на сумму {operationSum.Value} успешно выполнена";
            if (selectedRowIndex == -1)
            {
                resultRichTextBox.Text = $"Выберите непустую строку и повторите операцию";
            }
            else
            { 
                if (operationTypeList.Text == "Withdraw")
                {
                    // Изменение значения в списке
                    accountList[selectedRowIndex].Balance -= operationSum.Value;
                    
                    // Изменение значения в таблице
                    object valueObj = dataGridViewBank.Rows[selectedRowIndex].Cells[4].Value;
                    int? valueInt = valueObj as int?;
                    valueInt -= operationSum.Value;
                    valueObj = valueInt as object;
                    dataGridViewBank.Rows[selectedRowIndex].Cells[4].Value = valueObj;
                }
                if (operationTypeList.Text == "Deposit")
                {
                    // Изменение значения в списке
                    accountList[selectedRowIndex].Balance += operationSum.Value;

                    // Изменение значения в таблице
                    object valueObj = dataGridViewBank.Rows[selectedRowIndex].Cells[4].Value;
                    int? valueInt = valueObj as int?;
                    valueInt += operationSum.Value;
                    valueObj = valueInt as object;
                    dataGridViewBank.Rows[selectedRowIndex].Cells[4].Value = valueObj;
                }

                accountList[selectedRowIndex].AccountHistory.list.Add(new OperationData(operationTypeList.Text, DateTime.Now, operationSum.Value));
                resultRichTextBox.Text = $"Операция \"{operationTypeList.Text}\" на сумму {operationSum.Value} успешно выполнена";
            }
            lastActionStatusLabel.Text = "CommitOperationButton_Click";
        }

        private void operationSum_Scroll(object sender, EventArgs e)
        {
            operationSumValueLabel.Text = operationSum.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 8)
            {
                try
                {
                    dataGridViewBank.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception excep) { }
                accountList.RemoveAt(e.RowIndex);
                selectedRowIndex = -1;
            }

            lastActionStatusLabel.Text = "DeleteRowButton_Click";
        }

        private void dataGridViewBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 8)
            {

                if (selectedRowIndex != -1)
                {
                    foreach (DataGridViewCell cell in dataGridViewBank.Rows[selectedRowIndex].Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
                selectedRowIndex = e.RowIndex;
                foreach (DataGridViewCell cell in dataGridViewBank.Rows[selectedRowIndex].Cells)
                {
                    cell.Style.BackColor = Color.Gray;
                }
            }

            lastActionStatusLabel.Text = "SelectRow";

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            //dataGridViewBank.Rows.Add();
            try
            {
                var own = new Owner(NameTextBox.Text, birthDatePciker.Value, PassportIDTextBox.Text);
                /*var acc = new Account(
                        Convert.ToInt32(accountIdTextBox.Text),
                        (int)accountSumNumerical.Value,
                        registrationDatePicker.Value,
                        onlineBankingBox.Enabled,
                        SMSGroupBox.Enabled,
                        own,
                        history); */
                Account acc;
                var director = new AccountBuildDirector();
                IAccountBuilder builder;
                
                switch (accountType.Text)
                {
                    case "Базовый": builder = new BasicBuilder(); break;
                    case "Упрощенный": builder = new ReducedBuilder(); break;
                    case "Расширенный": builder = new PremiumBuilder(); break;
                    default: builder = new PremiumBuilder(); break;

                }

                acc = director.BuildObject(builder, NameTextBox.Text, birthDatePciker.Value, PassportIDTextBox.Text, Convert.ToInt32(accountIdTextBox.Text), (int)accountSumNumerical.Value, registrationDatePicker.Value);

                if(BusinessCheck.Checked == true)
                {
                    var decorator = new BusinessAccount();
                    decorator.SetDecorator(acc);
                    acc = decorator;
                    
                }

                if (PremiumCheck.Checked == true)
                {
                    var decorator = new PremiumAccount();
                    decorator.SetDecorator(acc);
                    acc = decorator;

                }

                var results = new List<ValidationResult>();
                var context = new ValidationContext(own);
                if (!Validator.TryValidateObject(own, context, results, true))
                    {
                        foreach (ValidationResult entry in results)
                        {
                            resultRichTextBox.Text += entry.ErrorMessage + "\n";
                        }

                   
                    }
                else
                    { 
                        results = new List<ValidationResult>();
                        context = new ValidationContext(acc);
                    if (!Validator.TryValidateObject(acc, context, results, true))
                        {
                            foreach (ValidationResult entry in results)
                            {
                                resultRichTextBox.Text += entry.ErrorMessage + "\n";
                            }


                        }
                    else
                        {

                            accountList.Add(acc);

                            dataGridViewBank.Rows.Add(
                                        acc.AccountOwner.FullName,
                                        acc.AccountOwner.PassportID,
                                        acc.AccountOwner.BirthDate,
                                        acc.ID,
                                        acc.Balance,
                                        acc.SMSNotification,
                                        acc.OnlineBanking,
                                        acc.StartDate
                                        );
                        }
                    }

                if (acc is PremiumAccount)
                {
                    var premiumAcc = acc as PremiumAccount;
                    if (premiumAcc.HasPremiumFeatures)
                        MessageBox.Show("Поздравляем с приобритением премиум-подписки, вы великолепны!!111!");
                }


                if (acc is BusinessAccount)
                {
                    var business = acc as BusinessAccount;
                    if (business.HasBusinessDiscount)
                        MessageBox.Show("Поздравляем с получением скидки для бизнес-партнеров!!111!");
                }
            }
                catch(Exception excep)
                {
                    resultRichTextBox.Text = "Не все поля заполнены";
                }

            //var lastRowIndex = dataGridViewBank.Rows.GetLastRow(DataGridViewElementStates.None);

            lastActionStatusLabel.Text = "AddRowButton_Click";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBank.Rows)
            {
                switch (searchFilterDropdownList.Text)
                {
                    case "ФИО":
                       // object objValue = row.Cells[0];
                       // string strValue = objValue as string;

                        if (searchTextBox.Text == row.Cells[0].Value as string)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.Style.BackColor = Color.Red;
                            }

                            if (selectedRowIndex != -1)
                            {
                                foreach (DataGridViewCell cell in dataGridViewBank.Rows[selectedRowIndex].Cells)
                                {
                                    cell.Style.BackColor = Color.White;
                                }
                            }

                            selectedRowIndex = row.Index;

                        }
                       

                        break;
                    case "Номер счёта":
                        if (searchTextBox.Text == row.Cells[3].Value as string)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.Style.BackColor = Color.Red;
                            }

                            if (selectedRowIndex != -1)
                            {
                                foreach (DataGridViewCell cell in dataGridViewBank.Rows[selectedRowIndex].Cells)
                                {
                                    cell.Style.BackColor = Color.White;
                                }
                            }

                            selectedRowIndex = row.Index;



                        }
                        
                        break;
                    case "Баланс":
                        if (searchTextBox.Text == row.Cells[4].Value as string)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.Style.BackColor = Color.Red;
                            }

                            if (selectedRowIndex != -1)
                            {
                                foreach (DataGridViewCell cell in dataGridViewBank.Rows[selectedRowIndex].Cells)
                                {
                                    cell.Style.BackColor = Color.White;
                                }
                            }


                            selectedRowIndex = row.Index;

                           
                        }

                        break;

                }
            }
            lastActionStatusLabel.Text = "SearchButton_Click";
        }

        private void advancedSearchButton_Click(object sender, EventArgs e)
        {
            var advancedSearchForm = new AdvancedSearchForm();
            advancedSearchForm.dataGridView = dataGridViewBank;
            advancedSearchForm.parentForm = this;
            advancedSearchForm.Visible = true;

            lastActionStatusLabel.Text = "AdvancedSearchButton_Click";
        }

        public void advancedSearchButton_Result(List<int> indexes)
        {
            if (indexes!=null)
                { 
            foreach(DataGridViewRow row in dataGridViewBank.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
                if (indexes.Contains(row.Index))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }

                   
                       
                    
                }
            }
            }
            else
            {
                resultRichTextBox.Text = "Ничего не найдено";   
            }
            lastActionStatusLabel.Text = "AdvancedSearchButton_Result";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            
            switch (sortDropdownList.Text)
            {
                case "ФИО": accountList = accountList.OrderBy(x => x.AccountOwner.FullName).ToList(); break;
                case "Дата создания счёта": accountList = accountList.OrderBy(x => x.StartDate).ToList();  break;
            }
            dataGridViewBank.Rows.Clear();
            foreach (Account entry in accountList)
            {
                dataGridViewBank.Rows.Add(
                entry.AccountOwner.FullName,
                entry.AccountOwner.PassportID,
                entry.AccountOwner.BirthDate,
                entry.ID,
                entry.Balance,
                entry.SMSNotification,
                entry.OnlineBanking,
                entry.StartDate
                );
            }

            lastActionStatusLabel.Text = "SortButton_Click";
        }

        private void dataGridViewBank_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            objectCountStatusLabel.Text = dataGridViewBank.Rows.Count.ToString();     
        }

        private void sortToolStripButton_Click(object sender, EventArgs e)
        {
            accountList = accountList.OrderBy(x => x.AccountOwner.FullName).ToList();
            dataGridViewBank.Rows.Clear();
            foreach (Account entry in accountList)
            {
                dataGridViewBank.Rows.Add(
                entry.AccountOwner.FullName,
                entry.AccountOwner.PassportID,
                entry.AccountOwner.BirthDate,
                entry.ID,
                entry.Balance,
                entry.SMSNotification,
                entry.OnlineBanking,
                entry.StartDate
                );
            }

            lastActionStatusLabel.Text = "SortToolStripButton_Click";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void deleteRowToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewBank.Rows.RemoveAt(selectedRowIndex);
                accountList.RemoveAt(selectedRowIndex);
            }
            catch (Exception excep) { }
            
            selectedRowIndex = -1;
        

        lastActionStatusLabel.Text = "DeleteRowToolStripButton_Click";
        }

        private void advancedSearchToolStripButton_Click(object sender, EventArgs e)
        {
            advancedSearchButton_Click(null, null);
            lastActionStatusLabel.Text = "AdvancedSearchToolStripButton_Click";
        }

        private void closeStripButton_Click(object sender, EventArgs e)
        {
            toolStrip1.Hide();
        }

        private void toolStrip1_DragDrop(object sender, DragEventArgs e)
        {
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Top = e.Y;
            toolStrip1.Left = e.X;
        }

        private void rollBackOperationButton_Click(object sender, EventArgs e)
        {
            accountList[selectedRowIndex].RestoreState();

            try
            {
                dataGridViewBank.Rows.Clear();
                //accountList = (List<Account>)Deserialize(fileNameTextBox.Text, typeof(List<Account>));
                foreach (Account entry in accountList)
                {
                    dataGridViewBank.Rows.Add(
                    entry.AccountOwner.FullName,
                    entry.AccountOwner.PassportID,
                    entry.AccountOwner.BirthDate,
                    entry.ID,
                    entry.Balance,
                    entry.SMSNotification,
                    entry.OnlineBanking,
                    entry.StartDate
                    );
                }
                //resultRichTextBox.Text = "Счет успешно загружен:\n";
                //    + $"===Владелец===\nФИО: {acc.AccountOwner.FullName}\nНомер паспорта: {acc.AccountOwner.PassportID}\nДата рождения: {acc.AccountOwner.BirthDate.ToString("d")}\n"
                //    + $"===Счет====\nНомер счета: {acc.ID}\nБаланс: {acc.Balance}\nОнлайн-Банкинг: {acc.OnlineBanking}\nСМС-Уведомления: {acc.SMSNotification}\nДата Создания: {acc.StartDate.ToString("d")}\n";
                //selectedRowIndex = -1;
            }
            catch (Exception excep)
            {
                resultRichTextBox.Text = "" + excep.Message;
            }
        }
    }

   
}
