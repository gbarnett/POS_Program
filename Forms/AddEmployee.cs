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
        }

        public AddEmployee(Employee employee)
        {
            InitializeComponent();
            EditMode = true;
            EmployeeID = employee.ID;
            NameTextBox.Text = employee.Name;
            PhoneTextBox.Text = employee.Phone;
            AddressTextBox.Text = employee.Address;
            CityTextBox.Text = employee.City;
            StateTextBox.Text = employee.State;
            ZipTextBox.Text = employee.Zip;
            PositionTextBox.Text = employee.Position;
            SalaryTextBox.Text = employee.Salary.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = NameTextBox.Text;
            employee.Phone = PhoneTextBox.Text;
            employee.Address = AddressTextBox.Text;
            employee.City = CityTextBox.Text;
            employee.State = StateTextBox.Text;
            employee.Zip = ZipTextBox.Text;
            employee.Position = PositionTextBox.Text;
            employee.Salary = Convert.ToDecimal(SalaryTextBox.Text);

            if (!EditMode)
            {
                EmployeeTransactions.AddEmployee(employee);
            }
            else
            {
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
