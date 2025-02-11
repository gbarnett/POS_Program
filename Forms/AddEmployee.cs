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
            employee.Name = NameTextBox.Text;
            employee.Phone = PhoneTextBox.Text;
            employee.Address = AddressTextBox.Text;
            employee.City = CityTextBox.Text;
            employee.State = StateComboBox.Text;
            employee.Zip = ZipTextBox.Text;
            employee.Position = PositionTextBox.Text;
            employee.Salary = Convert.ToDecimal(SalaryTextBox.Text);
            employee.Username = UsernameTextBox.Text;
            employee.SetPassword(PasswordTextBox.Text);
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
                if (PasswordTextBox.Text == null)
                {

                }
                EmployeeTransactions.EditEmployee(employee);
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
