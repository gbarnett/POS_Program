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
    public partial class AddProduct : Form
    {
        private bool EditMode;
        private int ProductID;
        public AddProduct()
        {
            InitializeComponent();
        }

        public AddProduct(Product product)
        {
            InitializeComponent();
            ProductID = product.ID;
            NameTextBox.Text = product.Name;
            PriceTextBox.Text = product.Price.ToString();
            DescriptionTextBox.Text = product.Description;
            EditMode = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID = ProductID;
            product.Name = NameTextBox.Text;
            product.Price = Convert.ToDecimal(PriceTextBox.Text);
            product.Description = DescriptionTextBox.Text;
            if (!EditMode)
            {
                ProductTransactions.AddProduct(product);
            }
            else
            {
                ProductTransactions.EditProduct(product);
            }
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
