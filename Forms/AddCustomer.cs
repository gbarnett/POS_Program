using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
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
        private List<String> States = CustomerTransactions.States.ToList();
        public AddCustomer()
        {
            InitializeComponent();
            StateComboBox.DataSource = States;
        }
        public AddCustomer(Customer customer)
        {
            InitializeComponent();
            StateComboBox.DataSource = States;
            this.NameTextBox.Text = customer.Name;
            this.PhoneTextBox.Text = customer.Phone;
            this.AddressTextBox.Text = customer.Address;
            this.CityTextBox.Text = customer.City;
            this.StateComboBox.Text = customer.State;
            this.ZipTextBox.Text = customer.Zip;
            EditMode = true;
            CustomerID = customer.ID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ID = CustomerID;
            try
            {
                if (!String.IsNullOrEmpty(NameTextBox.Text))
                {
                    customer.Name = NameTextBox.Text;
                }
                else { MessageBox.Show("Name cannot be empty"); return; }

                if (!String.IsNullOrEmpty(PhoneTextBox.Text))
                {
                    customer.Phone = PhoneTextBox.Text;
                }
                else { MessageBox.Show("Phone cannot be empty"); return; }

                if (!String.IsNullOrEmpty(AddressTextBox.Text))
                {
                    customer.Address = AddressTextBox.Text;
                }
                else { MessageBox.Show("Address cannot be empty"); return; }

                if (!String.IsNullOrEmpty(CityTextBox.Text))
                {
                    customer.City = CityTextBox.Text;
                }
                else { MessageBox.Show("City cannot be empty"); return; }

                if (!String.IsNullOrEmpty(StateComboBox.Text))
                {
                    customer.State = StateComboBox.Text;
                }
                else { MessageBox.Show("State cannot be empty"); return; }

                if (!String.IsNullOrEmpty(ZipTextBox.Text))
                {
                    customer.Zip = ZipTextBox.Text;
                }
                else { MessageBox.Show("Zip cannot be empty"); return; }

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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
