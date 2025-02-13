using POS_Program.Classes;
using POS_Program.DatabaseTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Program.Forms
{
    public partial class SalesReports : Form
    {
        /*
         * Will require to change the database table however,
        add ability to track sales by employee.
        Add a drop down combobox for selecting employee
         */

        List<Order> orders = new List<Order>();
        public SalesReports()
        {
            InitializeComponent();
        }

        private void GetDailyOrders()
        {
            orders.Clear();
            orders = SalesReportTransactions.DailyOrders();
            OrderDataGridView.DataSource = orders;
            TotalLabel.Text = $"Total : ${getTotal(orders)}";

        }
        private void GetMonthlyOrders()
        {
            orders.Clear();
            orders = SalesReportTransactions.MonthlyOrders();
            OrderDataGridView.DataSource = orders;
            TotalLabel.Text = $"Total : ${getTotal(orders)}";
        }

        private void GetYearlyOrders()
        {
            orders.Clear();
            orders = SalesReportTransactions.YearlyOrders();
            OrderDataGridView.DataSource = orders;
            TotalLabel.Text = $"Total : ${getTotal(orders)}";
        }

        public decimal getTotal(List<Order> orders)
        {
            decimal total = 0;
            foreach (var order in orders)
            {
                total += order.Total;
            }
            return total;
        }

        private void DailyButton_Click(object sender, EventArgs e)
        {
            GetDailyOrders();
        }

        private void MonthlyButton_Click(object sender, EventArgs e)
        {
            GetMonthlyOrders();
        }

        private void YearlyButton_Click(object sender, EventArgs e)
        {
            GetYearlyOrders();
        }
    }
}
