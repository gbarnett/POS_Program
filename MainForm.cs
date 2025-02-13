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
using POS_Program.Forms;

namespace POS_Program
{
    public partial class MainForm : Form
    {
        Employee CurrentEmployee;
        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.CurrentEmployee = employee;

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(CurrentEmployee);
            productsForm.Show();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm(CurrentEmployee);
            employeesForm.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(CurrentEmployee);
            ordersForm.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            SalesReports salesReports = new SalesReports();
            salesReports.Show();
        }
    }
}
