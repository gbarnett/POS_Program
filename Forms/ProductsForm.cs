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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        public void LoadProducts()
        {
            ProductsDataGridView.DataSource = ProductTransactions.GetAllProducts();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.FormClosed += AddProduct_FormClosed;
            addProduct.Show();
        }

        public void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadProducts();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.CurrentRow != null)
            {
                Product product = ProductsDataGridView.CurrentRow.DataBoundItem as Product;
                AddProduct editProduct = new AddProduct(product);
                editProduct.FormClosed += AddProduct_FormClosed;
                editProduct.Show();

            }
        }

        private void ProductsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductsDataGridView.Columns["ID"].Width = 50;
        }
    }
}
