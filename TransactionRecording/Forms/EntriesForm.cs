using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TransactionRecording
{
    public partial class EntriesForm : Form
    {
        private Form1 mainForm;

        public EntriesForm(Form1 _mainForm)
        {
            InitializeComponent();
            LoadData();

            mainForm = _mainForm;
        }

        public void LoadData()
        {
            foreach (String department in ApplicationDelegate.getDepartmentList())
            {
                departmentComboBox.Items.Add(department);
            }

            foreach (String date in ApplicationDelegate.getDateList())
            {
                dateComboBox.Items.Add(date);
            }

            deleteButton.Enabled = false;
            saveButton.Enabled = false;
            idTextBox.Enabled = false;
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            entryListBox.ClearSelected();

            string chosenFilter = departmentComboBox.Text;
            // Log.d(chosenFilter);

            entryListBox.Items.Clear();

            foreach (TransactionEntry currentEntry in ApplicationDelegate.getTransactionList())
            {
                if (currentEntry.getDepartment().Equals(chosenFilter))
                {
                    entryListBox.Items.Add(currentEntry.getID());
                }
            }

            if (!saveButton.Enabled)
            {
                saveButton.Enabled = true;
            }

            if (!deleteButton.Enabled)
            {
                deleteButton.Enabled = true;
            }
        }

        private void entryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entryListBox.SelectedItem != null)
            {
                string selectedID = entryListBox.SelectedItem.ToString();
                Log.d(selectedID);

                TransactionEntry entry = null;

                foreach (TransactionEntry currentEntry in ApplicationDelegate.getTransactionList())
                {
                    if (currentEntry.getID() == (int)Int32.Parse(selectedID))
                    {
                        entry = currentEntry;
                        continue;
                    }

                    Log.d("Enumerating...");
                }

                if (entry != null)
                {
                    idTextBox.Text = "" + entry.getID();
                    dateTextBox.Text = entry.getDate();
                    quantityTextBox.Text = entry.getQuantity();
                    priceTextBox.Text = entry.getPrice();
                    departmentTextBox.Text = entry.getDepartment();
                    brandTextBox.Text = entry.getBrand();
                    descriptionTextBox.Text = entry.getDescription();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string url = "http://reverseeffectapps.x10.mx/api/transactions/transaction_test.php?method=";
            bool hasID = false;

            foreach (TransactionEntry currentEntry in ApplicationDelegate.getTransactionList())
            {
                if (currentEntry.getID() == (int)UInt64.Parse(idTextBox.Text))
                {
                    hasID = true;
                }
            }

            string id = idTextBox.Text;
            string department = departmentTextBox.Text;
            string brand = brandTextBox.Text;
            string description = descriptionTextBox.Text;
            string quantity = quantityTextBox.Text;
            string price = priceTextBox.Text;
            string date = dateTextBox.Text;

            if (hasID)
            {
                url += "update&id=" + id + "&department=" + department + "&brand=" + brand + "&description=" + 
                    description + "&quantity=" + quantity + "&price=" + price + "&date=" + date;
            }
            else
            {
                MessageBox.Show("Unable to find row in database to update data. Aborting operation.", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            url = Uri.EscapeUriString(url);
            string result = new WebClient().DownloadString(url);

            Log.d(result);

            if (result.Equals("Insert Success.") || result.Equals("Update success."))
            {
                MessageBox.Show("Operation is successful.", "Database Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation is unsuccessful.", "Database Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TransactionEntry entry = new TransactionEntry();
            entry.setID((int)UInt64.Parse(idTextBox.Text));
            entry.setDate(dateTextBox.Text);
            entry.setQuantity(quantityTextBox.Text);
            entry.setPrice(priceTextBox.Text);
            entry.setDepartment(departmentTextBox.Text);
            entry.setBrand(brandTextBox.Text);
            entry.setDescription(descriptionTextBox.Text);

            List<TransactionEntry> transactionList = ApplicationDelegate.getTransactionList();

            if (hasID)
            {
                for (int i = 0; i < transactionList.Count; i++)
                {
                    if (transactionList[i].getID() == (int)UInt64.Parse(idTextBox.Text))
                    {
                        transactionList[i] = entry;
                    }
                }
            }
            else
            {
                transactionList.Add(entry);
            }

            reloadDataSource();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string url = "http://reverseeffectapps.x10.mx/api/transactions/transaction_test.php?method=delete&id=" + id;

            url = Uri.EscapeUriString(url);
            string result = new WebClient().DownloadString(url);

            Log.d(result);

            if (result.Equals("Delete Success."))
            {
                MessageBox.Show("Operation is successful.", "Database Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation is unsuccessful.", "Database Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<TransactionEntry> transactionList = ApplicationDelegate.getTransactionList();

            for (int i = 0; i < transactionList.Count; i++)
            {
                if (transactionList[i].getID() == (int)UInt64.Parse(idTextBox.Text))
                {
                    transactionList.Remove(transactionList[i]);
                    continue;
                }
            }

            departmentComboBox.Items.Clear();
            dateComboBox.Items.Clear();
            entryListBox.Items.Clear();

            idTextBox.Text = "";
            dateTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";
            departmentTextBox.Text = "";
            brandTextBox.Text = "";
            descriptionTextBox.Text = "";

            LoadData();
            reloadDataSource();
        }

        private void newEntryButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<NewEntryForm>().Count() < 1)
            {
                NewEntryForm form = new NewEntryForm(this);
                form.Visible = true;
                form.SetDesktopLocation(this.Left + this.Width + 10, this.Top);
                form.Activate();
            }
        }

        public void reloadDataSource()
        {
            mainForm.UpdateComponents(false);

            departmentComboBox.Items.Clear();
            dateComboBox.Items.Clear();
            entryListBox.Items.Clear();

            idTextBox.Text = "";
            dateTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";
            departmentTextBox.Text = "";
            brandTextBox.Text = "";
            descriptionTextBox.Text = "";

            List<string> departmentsList = ApplicationDelegate.getDepartmentList();
            List<string> dateList = ApplicationDelegate.getDateList();

            foreach (String currentDepartment in departmentsList)
            {
                departmentComboBox.Items.Add(currentDepartment);
            }

            foreach (String currentDate in dateList)
            {
                dateComboBox.Items.Add(currentDate);
            }
        }
    }
}
