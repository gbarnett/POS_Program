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
    public partial class NewOrderForm : Form
    {
        BindingList<Product> Products = new BindingList<Product>();
        decimal TotalPrice;
        Customer customer;
        public NewOrderForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
        }

        public void LoadProducts()
        {
            ProductsDataGridView.DataSource = ProductTransactions.GetAllProducts();
            ProductsDataGridView.Columns["ID"].Visible = false;
            //ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadCustomers()
        {
            var customers = CustomerTransactions.GetAllCustomers();
            CustomerDataGridView.DataSource = customers;
            if (CustomerDataGridView.Columns.Count > 0)
            {
                CustomerDataGridView.Columns["Phone"].Visible = false;
                CustomerDataGridView.Columns["Address"].Visible = false;
                CustomerDataGridView.Columns["State"].Visible = false;
                CustomerDataGridView.Columns["City"].Visible = false;
                CustomerDataGridView.Columns["Zip"].Visible = false;
            }
        }

        public void ReloadCart()
        {
            CartDataGridView.DataSource = Products;
            CartDataGridView.Columns["ID"].Visible = false;
            TotalLabel.Text = $"Total : ${TotalPrice}";
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count > 0)
            {
                var product = ProductsDataGridView.CurrentRow.DataBoundItem as Product;
                Products.Add(product);
                TotalPrice += product.Price;
                ReloadCart();
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            if (CartDataGridView.SelectedRows.Count > 0)
            {
                var product = CartDataGridView.CurrentRow.DataBoundItem as Product;
                Products.Remove(product);
                TotalPrice -= product.Price;
                ReloadCart();
            }
            else
            {
                MessageBox.Show("No item selected");
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                Order order = new Order();
                order.Date = DateTime.Now;
                order.CustomerID = customer.ID;
                order.Name = customer.Name;
                order.Total = TotalPrice;
                OrderTransactions.CreateNewOrder(order);

                int orderID = OrderTransactions.GetLatestOrderID();

                foreach (var item in Products)
                {
                    OrderTransactions.AddOrderItem(item, orderID);
                }
                MessageBox.Show("Checkout complete");
                this.Close();
            }
            else
            {
                MessageBox.Show("No Customer selected");
            }
        }

        private void CustomerSelectButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                customer = CustomerDataGridView.CurrentRow.DataBoundItem as Customer;
                CustomerNameLabel.Text = customer.Name;
                CustomerNameLabel.Visible = true;
                CustomerDataGridView.DefaultCellStyle.SelectionBackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("No customer selected");
            }
        }

        private void CustomerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerDataGridView.Columns["ID"].Width = 50;
        }

        private void CustomerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            customer = null;
            CustomerDataGridView.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            CustomerNameLabel.Text = null;
            CustomerNameLabel.Visible = false;
        }
    }
}
