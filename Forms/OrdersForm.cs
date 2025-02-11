using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Math.EC;
using POS_Program.Classes;
using POS_Program.DatabaseTransactions;

namespace POS_Program.Forms
{
    public partial class OrdersForm : Form
    {
        Employee currentEmployee;
        public OrdersForm(Employee employee)
        {
            InitializeComponent();
            LoadOrders();
            this.currentEmployee = employee;

            if (employee.isAdmin != 1)
            {
                DeleteOrderButton.Enabled = false;
            }
        }

        public void LoadOrders()
        {
            OrderDataGridView.DataSource = OrderTransactions.GetAllOrders();
            OrderDataGridView.Columns["CustomerID"].Visible = false;
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            CustomerSelectForm customerSelect = new CustomerSelectForm(currentEmployee);
            this.Close();
            customerSelect.Show();
        }

        public void NewOrderForm_Closed(object sender, FormClosedEventArgs e)
        {
            LoadOrders();
        }

        private void OrderDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            OrderDataGridView.Columns["ID"].Width = 50;
            OrderDataGridView.Columns["Date"].Width = 150;
            //OrderDataGridView.Columns["Total"].DefaultCellStyle.Format = "F2";
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                var order = OrderDataGridView.CurrentRow.DataBoundItem as Order;
                OrderView orderView = new OrderView(order);
                orderView.Show();
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                var order = OrderDataGridView.CurrentRow.DataBoundItem as Order;
                OrderTransactions.DeleteOrder(order);
                LoadOrders();
            }
        }
    }
}
