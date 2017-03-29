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
    public partial class ViewDepartmentsForm : Form
    {
        public ViewDepartmentsForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            departmentsListBox.Items.Clear();

            List<string> departmentsList = ApplicationDelegate.getDepartmentList();

            foreach (String currentDepartment in departmentsList)
            {
                departmentsListBox.Items.Add(currentDepartment);
            }
        }
    }
}
