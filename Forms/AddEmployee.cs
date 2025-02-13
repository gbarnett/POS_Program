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
    public partial class AddEmployee : Form
    {
        private bool EditMode;
        private int EmployeeID;
        public AddEmployee()
        {
            InitializeComponent();
            StateComboBox.DataSource = CustomerTransactions.States;
        }

        public AddEmployee(Employee employee)
        {
            InitializeComponent();
            StateComboBox.DataSource = CustomerTransactions.States;
            EditMode = true;
            EmployeeID = employee.ID;
            NameTextBox.Text = employee.Name;
            PhoneTextBox.Text = employee.Phone;
            AddressTextBox.Text = employee.Address;
            CityTextBox.Text = employee.City;
            StateComboBox.Text = employee.State;
            ZipTextBox.Text = employee.Zip;
            PositionTextBox.Text = employee.Position;
            SalaryTextBox.Text = employee.Salary.ToString();
            UsernameTextBox.Text = employee.Username;
            PasswordTextBox.Text = employee.GetPassword();
            if (employee.isAdmin == 1)
            {
                IsAdminCheckBox.Checked = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            try
            {
                if(!String.IsNullOrEmpty(NameTextBox.Text))
                {
                    employee.Name = NameTextBox.Text;
                } else { MessageBox.Show("Name cannot be empty"); return; }

                if (!String.IsNullOrEmpty(PhoneTextBox.Text))
                {
                    employee.Phone = PhoneTextBox.Text;
                }
                else { MessageBox.Show("Phone number cannot be empty"); return; }

                if (!String.IsNullOrEmpty(AddressTextBox.Text))
                {
                    employee.Address = AddressTextBox.Text;
                }
                else { MessageBox.Show("Address cannot be empty"); return; }

                if (!String.IsNullOrEmpty(CityTextBox.Text))
                {
                    employee.City = CityTextBox.Text;
                }
                else { MessageBox.Show("City cannot be empty"); return; }

                if (!String.IsNullOrEmpty(StateComboBox.Text))
                {
                    employee.State = StateComboBox.Text;
                }
                else { MessageBox.Show("State cannot be empty"); return; }

                if (!String.IsNullOrEmpty(ZipTextBox.Text))
                {
                    employee.Zip = ZipTextBox.Text;
                }
                else { MessageBox.Show("Zip cannot be empty"); return; }

                if (!String.IsNullOrEmpty(PositionTextBox.Text))
                {
                    employee.Position = PositionTextBox.Text;
                }
                else { MessageBox.Show("Position cannot be empty"); return; }

                if (!String.IsNullOrEmpty(SalaryTextBox.Text))
                {
                    employee.Salary = Convert.ToDecimal(SalaryTextBox.Text);
                }
                else { MessageBox.Show("Salary cannot be empty"); return; }

                if (!String.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    employee.Username = UsernameTextBox.Text;
                }
                else { MessageBox.Show("Username cannot be empty"); return; }

                if (!String.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    employee.SetPassword(PasswordTextBox.Text);
                }
                else { MessageBox.Show("Password cannot be empty"); return; }

                if (IsAdminCheckBox.Checked)
                {
                    employee.isAdmin = 1;
                }
                else
                {
                    employee.isAdmin = 0;
                }

                if (!EditMode)
                {
                    EmployeeTransactions.AddEmployee(employee);
                }
                else
                {
                    employee.ID = EmployeeID;
                    EmployeeTransactions.EditEmployee(employee);
                }
                this.Close();
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
