using POS_Program.Classes;
using POS_Program.DatabaseTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace POS_Program.Forms
{
    public partial class CustomerSelectForm : Form
    {
        Employee CurrentEmployee;
        public CustomerSelectForm(Employee employee)
        {
            InitializeComponent();
            LoadCustomers();
            this.CurrentEmployee = employee;
        }

        private void LoadCustomers()
        {
            CustomerDataGridView.DataSource = CustomerTransactions.GetAllCustomers();
        }

        private void CustomerSelectButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                var customer = CustomerDataGridView.CurrentRow.DataBoundItem as Customer;
                this.Close();
                NewOrderForm newOrder = new NewOrderForm(customer, CurrentEmployee);
                newOrder.Show();
            }
        }

        private void CustomerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerDataGridView.Columns["ID"].Width = 50;
            CustomerDataGridView.Columns["Phone"].Visible = false;
            CustomerDataGridView.Columns["Address"].Visible = false;
            CustomerDataGridView.Columns["State"].Visible = false;
            CustomerDataGridView.Columns["City"].Visible = false;
            CustomerDataGridView.Columns["Zip"].Visible = false;
        }
    }
}
