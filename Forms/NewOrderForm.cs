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
        Customer CurrentCustomer;
        Employee CurrentEmployee;
        public NewOrderForm(Customer customer, Employee employee)
        {
            InitializeComponent();
            LoadProducts();
            this.CurrentCustomer = customer;
            this.CurrentEmployee = employee;
        }

        public void LoadProducts()
        {
            ProductsDataGridView.DataSource = ProductTransactions.GetAllProducts();
            ProductsDataGridView.Columns["ID"].Visible = false;
            //ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            else
            {
                MessageBox.Show("No product selected");
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

            Order order = new Order();
            order.Date = DateTime.Now;
            order.CustomerID = CurrentCustomer.ID;
            order.Name = CurrentCustomer.Name;
            order.Total = TotalPrice;
            OrderTransactions.CreateNewOrder(order, CurrentEmployee.ID);

            int orderID = OrderTransactions.GetLatestOrderID();

            foreach (var item in Products)
            {
                OrderTransactions.AddOrderItem(item, orderID);
            }
            MessageBox.Show("Checkout complete");
            this.Close();
            OrdersForm ordersForm = new OrdersForm(CurrentEmployee);
            ordersForm.Show();
        }
    }
}
