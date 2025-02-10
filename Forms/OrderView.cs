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
    public partial class OrderView : Form
    {
        private Order CurrentOrder;
        public OrderView(Order order)
        {
            InitializeComponent();
            this.CurrentOrder = order;
            LoadOrderItems();
        }

        public void LoadOrderItems()
        {
            OrderItemsDataGridView.DataSource = OrderTransactions.GetOrderItems(CurrentOrder);
            CustomerNameLabel.Text = CurrentOrder.Name;
            PriceLabel.Text = $"${CurrentOrder.Total}";
        }

        private void OrderItemsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            OrderItemsDataGridView.Columns["ID"].Width = 50;
        }
    }
}
