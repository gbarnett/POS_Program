using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Program.Classes;
using POS_Program.DatabaseTransactions;

namespace POS_Program.Forms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            EmployeeDataGridView.DataSource = EmployeeTransactions.GetAllEmployees();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.FormClosed += AddEmployee_FormClosed;
            addEmployee.Show();
        }

        public void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadEmployees();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedRows != null)
            {
                var employee = EmployeeDataGridView.CurrentRow.DataBoundItem as Employee;
                EmployeeTransactions.DeleteEmployee(employee);
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("No Employee Selected");
            }
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedRows != null)
            {
                var employee = EmployeeDataGridView.CurrentRow.DataBoundItem as Employee;
                AddEmployee editEmployee = new AddEmployee(employee);
                editEmployee.Show();
            }
            else
            {
                MessageBox.Show("No Emplopee Selected");
            }
        }

        private void EmployeeDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EmployeeDataGridView.Columns["ID"].Width = 50;
        }
    }
}
