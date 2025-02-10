using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Program.Classes;
using POS_Program.DatabaseTransactions;
namespace POS_Program
{
    public partial class AddCustomer : Form
    {
        private bool EditMode;
        private int CustomerID;
        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer(Customer customer)
        {
            InitializeComponent();
            this.NameTextBox.Text = customer.Name;
            this.PhoneTextBox.Text = customer.Phone;
            this.AddressTextBox.Text = customer.Address;
            this.CityTextBox.Text = customer.City;
            this.StateTextBox.Text = customer.State;
            this.ZipTextBox.Text = customer.Zip;
            EditMode = true;
            CustomerID = customer.ID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.ID = CustomerID;
            customer.Name = NameTextBox.Text;
            customer.Phone = PhoneTextBox.Text;
            customer.Address = AddressTextBox.Text;
            customer.City = CityTextBox.Text;
            customer.State = StateTextBox.Text;
            customer.Zip = ZipTextBox.Text;

            if (!EditMode)
            {
                CustomerTransactions.AddCustomer(customer);
                this.Close();
            }
            else
            {
                CustomerTransactions.EditCustomer(customer);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
