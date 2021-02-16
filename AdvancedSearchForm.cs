using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2SharpForms
{
    public partial class AdvancedSearchForm : Form
    {
        public Form1 parentForm;
        int cellIndex;
        List<int> searchResult;
        public DataGridView dataGridView;

        public AdvancedSearchForm()
        {
            InitializeComponent();

            searchFilterDropdownList1.SelectedIndex = 0;
            searchFilterDropdownList2.SelectedIndex = 0;
            searchRegexDropdownList1.SelectedIndex = 0;
            searchRegexDropdownList2.SelectedIndex = 0;
            andRadio2.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                panel2.Visible = true;

            }
            else
                panel2.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var list1 = AdvancedSearch(searchRegexDropdownList1, searchFilterDropdownList1, searchTextBox1.Text);
            
            if (checkBox2.Checked)
            {
                var list2 = AdvancedSearch(searchRegexDropdownList2, searchFilterDropdownList2, searchTextBox2.Text);
                if (andRadio2.Checked)
                {
                    searchResult = list1.Intersect(list2).ToList();
                }
                else
                {
                    searchResult = list1.Union(list2).ToList();
                }
            }
            
            parentForm.advancedSearchButton_Result(searchResult);
            
        }

        List<int> AdvancedSearch (ComboBox dropdownListRegex, ComboBox dropdownListFilter, string str)
        {
            var result = new List<int>();
            Regex regex = new Regex("");
            switch (dropdownListRegex.Text)  
            {
                case "Подстрока":
                    regex = new Regex($@"\w*{str}\w*");
                    break;
                case "Количество совпадений":
                    regex = new Regex($@"\w*{str}\w*");
                    break;
                case "Индекс вхождения":
                    regex = new Regex($@"\w*{str}\w*");
                    break;
            }

            switch(dropdownListFilter.Text)
            {
                
                case "ФИО":
                    cellIndex = 0;
                    break;
                case "Номер счёта":
                    cellIndex = 3;
                    break;
                case "Баланс":
                    cellIndex = 4;
                    break;
            }

            string regexInput = "";
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                object objVal = row.Cells[cellIndex].Value;
                if (cellIndex == 0)
                {

                    string typedVal = objVal as string;
                    regexInput +=  typedVal + " ";
                }
                else
                {
                    int? typedVal = objVal as int?;
                    regexInput += typedVal.ToString() + " ";
                }
                
            }

            MatchCollection matches = regex.Matches(regexInput);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                object objVal = row.Cells[cellIndex].Value;
                string stringVal = "";
                if (cellIndex == 0)
                {

                     stringVal = objVal as string;
                }
                else
                {
                    int? typedVal = objVal as int?;
                     stringVal = typedVal.ToString();
                }

                foreach (Match match in matches)
                {
                    if (match.Value == stringVal)
                        result.Add(row.Index);
                }
                
            }
            return result;
        }

        private void searchRegexDropdownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchRegexDropdownList1.Text == "Подстрока") searchRegexValue1.ReadOnly = true;
            else searchRegexValue1.ReadOnly = false;
        }

        private void searchRegexDropdownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchRegexDropdownList2.Text == "Подстрока") searchRegexValue2.ReadOnly = true;
            else searchRegexValue2.ReadOnly = false;
        }


    }
}
