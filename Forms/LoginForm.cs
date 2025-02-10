using POS_Program.DatabaseTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Program.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseConnection conn = new DatabaseConnection();
            conn.CheckTables();
            DatabaseConnection.CheckAdminAccount();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var employee = DatabaseConnection.VerifyLogin(UsernameTextBox.Text, PasswordTextBox.Text);
            if (employee != null)
            {
                MainForm main = new MainForm(employee);
                main.FormClosed += MainForm_FormClosed;
                main.Show();
                this.Hide();
            }
        }

        public void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            UsernameTextBox.Text = null;
            PasswordTextBox.Text = null;
        }
    }
}
