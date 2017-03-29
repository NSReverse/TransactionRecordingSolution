using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace TransactionRecording
{
    public partial class NewEntryForm : Form
    {
        private EntriesForm entriesForm;

        public NewEntryForm(EntriesForm _entriesForm)
        {
            InitializeComponent();

            entriesForm = _entriesForm;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string url = "http://reverseeffectapps.x10.mx/api/transactions/transaction_test.php?method=";

            foreach (TransactionEntry currentEntry in ApplicationDelegate.getTransactionList())
            {
                if (currentEntry.getID() == (int)UInt64.Parse(idTextBox.Text))
                {
                    MessageBox.Show("ID already exists. Cannot create new record.", "Unable to create new Entry.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }

            string id = idTextBox.Text;
            string department = departmentTextBox.Text;
            string brand = brandTextBox.Text;
            string description = descriptionTextBox.Text;
            string quantity = quantityTextBox.Text;
            string price = priceTextBox.Text;
            string date = dateTextBox.Text;

            url += "insert&id=" + id + "&department=" + department + "&brand=" + brand + "&description=" +
                    description + "&quantity=" + quantity + "&price=" + price + "&date=" + date;

            url = Uri.EscapeUriString(url);
            string result = new WebClient().DownloadString(url);

            Log.d(result);

            if (result.Contains("Insert Success."))
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
            transactionList.Add(entry);

            entriesForm.reloadDataSource();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
