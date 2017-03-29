using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionRecording
{
    public partial class ReportForm : Form
    {
        private String currentDepartment;

        public ReportForm(String _currentDepartment)
        {
            InitializeComponent();
            currentDepartment = _currentDepartment;

            reportListView.View = View.Details;
            reportListView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Date", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Price", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Department", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Brand", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Description", -2, HorizontalAlignment.Left);

            ReloadData();
        }

        private void ReloadData()
        {
            List<TransactionEntry> entries = ApplicationDelegate.getTransactionList();

            foreach (TransactionEntry currentEntry in entries)
            {
                if (currentDepartment == null)
                {
                    ListViewItem item = new ListViewItem(currentEntry.getID().ToString());
                    item.SubItems.Add(currentEntry.getDate());
                    item.SubItems.Add(currentEntry.getQuantity());
                    item.SubItems.Add(currentEntry.getPrice());
                    item.SubItems.Add(currentEntry.getDepartment());
                    item.SubItems.Add(currentEntry.getBrand());
                    item.SubItems.Add(currentEntry.getDescription());

                    reportListView.Items.Add(item);
                }
                else
                {
                    if (currentEntry.getDepartment().Equals(currentDepartment))
                    {
                        ListViewItem item = new ListViewItem(currentEntry.getID().ToString());
                        item.SubItems.Add(currentEntry.getDate());
                        item.SubItems.Add(currentEntry.getQuantity());
                        item.SubItems.Add(currentEntry.getPrice());
                        item.SubItems.Add(currentEntry.getDepartment());
                        item.SubItems.Add(currentEntry.getBrand());
                        item.SubItems.Add(currentEntry.getDescription());

                        reportListView.Items.Add(item);
                    }
                }
            }
        }
    }
}
