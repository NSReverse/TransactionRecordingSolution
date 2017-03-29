using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json;

namespace TransactionRecording
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateComponents(true);
        }

        private void viewEntriesButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EntriesForm>().Count() < 1 && Application.OpenForms.OfType<ViewDepartmentsForm>().Count() == 0)
            {
                EntriesForm form = new EntriesForm(this);
                form.Visible = true;
                form.SetDesktopLocation(this.Left + this.Width + 10, this.Top);
                form.Activate();
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            UpdateComponents(true);
        }

        public void UpdateComponents(bool isHardUpdate)
        {
            if (isHardUpdate)
            {
                List<TransactionEntry> transactionList = new List<TransactionEntry>();
                List<string> departmentList = new List<string>();
                List<string> dateList = new List<string>();

                String url = "http://reverseeffectapps.x10.mx/api/transactions/transaction_test.php?" +
                    "method=list" + "&" +
                    "table=transaction_test";

                string result = new WebClient().DownloadString(url);

                try
                {
                    JArray array = JArray.Parse(result);

                    foreach (JObject currentObject in array.Children<JObject>())
                    {
                        bool hasDepartment = false;
                        bool hasDate = false;
                        TransactionEntry entry = new TransactionEntry();

                        foreach (JProperty currentProperty in currentObject.Properties())
                        {
                            String propertyName = currentProperty.Name;

                            if (propertyName.Equals("id") || propertyName.Equals("ID"))
                            {
                                entry.setID((int)Int32.Parse((string)currentProperty.Value));
                            }
                            else if (propertyName.Equals("department") || propertyName.Equals("DEPARTMENT"))
                            {
                                entry.setDepartment((string)currentProperty.Value);

                                foreach (String currentDepartment in departmentList)
                                {
                                    if (currentDepartment.Equals(entry.getDepartment()))
                                    {
                                        hasDepartment = true;
                                    }
                                }
                            }
                            else if (propertyName.Equals("brand") || propertyName.Equals("BRAND"))
                            {
                                entry.setBrand((string)currentProperty.Value);
                            }
                            else if (propertyName.Equals("description") || propertyName.Equals("DESCRIPTION"))
                            {
                                entry.setDescription((string)currentProperty.Value);
                            }
                            else if (propertyName.Equals("quantity") || propertyName.Equals("QUANTITY"))
                            {
                                entry.setQuantity((string)currentProperty.Value);
                            }
                            else if (propertyName.Equals("price") || propertyName.Equals("PRICE"))
                            {
                                entry.setPrice((string)currentProperty.Value);
                            }
                            else
                            {
                                entry.setDate((string)currentProperty.Value);

                                foreach (String currentDate in dateList)
                                {
                                    if (currentDate.Equals(entry.getDate()))
                                    {
                                        hasDate = true;
                                    }
                                }
                            }
                        }

                        transactionList.Add(entry);

                        if (!hasDepartment)
                        {
                            departmentList.Add(entry.getDepartment());
                        }

                        if (!hasDate)
                        {
                            dateList.Add(entry.getDate());
                        }
                    }

                    ApplicationDelegate.setDepartmentList(departmentList);
                    ApplicationDelegate.setTransactionList(transactionList);
                    ApplicationDelegate.setDateList(dateList);
                    entriesTextBox.Text = "" + transactionList.Count;
                    departmentsTextBox.Text = "" + departmentList.Count;
                }
                catch (JsonReaderException ex)
                {
                    MessageBox.Show(ex.Message + "\n\nMessage from Server: " + result, "Failed to Retrieve Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    ApplicationDelegate.setDepartmentList(new List<string>());
                    ApplicationDelegate.setTransactionList(new List<TransactionEntry>());
                    ApplicationDelegate.setDateList(new List<string>());
                    entriesTextBox.Text = "" + ApplicationDelegate.getTransactionList().Count;
                    departmentsTextBox.Text = "" + ApplicationDelegate.getDepartmentList().Count;
                }
            }
            else
            {
                entriesTextBox.Text = "" + ApplicationDelegate.getTransactionList().Count;
                departmentsTextBox.Text = "" + ApplicationDelegate.getDepartmentList().Count;
            }
        }

        private void viewDepartmentsButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EntriesForm>().Count() == 0 && Application.OpenForms.OfType<ViewDepartmentsForm>().Count() < 1)
            {
                ViewDepartmentsForm form = new ViewDepartmentsForm();
                form.Visible = true;
                form.SetDesktopLocation(this.Left + this.Width + 10, this.Top);
                form.Activate();
            }
        }

        private void generateReportsButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EntriesForm>().Count() == 0 && 
                Application.OpenForms.OfType<ViewDepartmentsForm>().Count() == 0 &&
                Application.OpenForms.OfType<ReportOptionsForm>().Count() == 0)
            {
                ReportOptionsForm form = new ReportOptionsForm();
                form.Visible = true;
                form.SetDesktopLocation(this.Left + this.Width + 10, this.Top);
                form.Activate();
            }
        }
    }
}
