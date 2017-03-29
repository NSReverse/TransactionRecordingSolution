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
    public partial class ReportOptionsForm : Form
    {
        public ReportOptionsForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            List<string> departmentList = ApplicationDelegate.getDepartmentList();

            foreach (String currentDepartment in departmentList)
            {
                departmentComboBox.Items.Add(currentDepartment);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ReportForm form = new ReportForm(departmentComboBox.SelectedItem.ToString());
                form.Visible = true;
                form.SetDesktopLocation(this.Left + this.Width + 10, this.Top);
                form.Activate();
            }
            catch (NullReferenceException ex)
            {
                ReportForm form = new ReportForm(null);
                form.Visible = true;
                form.SetDesktopLocation(this.Left + this.Width + 10, this.Top);
                form.Activate();
            }
        }
    }
}
