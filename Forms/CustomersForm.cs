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

namespace POS_Program
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();

            addCustomerForm.FormClosed += AddCustomer_FormClosed;

            addCustomerForm.Show();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerDataGridView.CurrentRow != null)
                {
                    var customer = (Customer)CustomerDataGridView.CurrentRow.DataBoundItem as Customer;
                    CustomerTransactions.DeleteCustomer(customer);
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("No customer selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void LoadCustomers()
        {
            CustomerDataGridView.DataSource = null;
            CustomerDataGridView.DataSource = CustomerTransactions.GetAllCustomers();
        }

        public void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomers();
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.CurrentRow != null)
            {
                var customer = CustomerDataGridView.CurrentRow.DataBoundItem as Customer;
                AddCustomer editCustomer = new AddCustomer(customer);
                editCustomer.FormClosed += AddCustomer_FormClosed;
                editCustomer.Show();
            }
        }

        private void CustomerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerDataGridView.Columns["ID"].Width = 50;
        }
    }
}
