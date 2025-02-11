namespace POS_Program.Forms
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrderDataGridView = new DataGridView();
            NewOrderButton = new Button();
            ViewOrderButton = new Button();
            DeleteOrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDataGridView.BorderStyle = BorderStyle.Fixed3D;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Location = new Point(154, 16);
            OrderDataGridView.Margin = new Padding(3, 4, 3, 4);
            OrderDataGridView.MultiSelect = false;
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.ReadOnly = true;
            OrderDataGridView.RowHeadersVisible = false;
            OrderDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            OrderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderDataGridView.Size = new Size(746, 525);
            OrderDataGridView.TabIndex = 3;
            OrderDataGridView.DataBindingComplete += OrderDataGridView_DataBindingComplete;
            // 
            // NewOrderButton
            // 
            NewOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NewOrderButton.Location = new Point(14, 16);
            NewOrderButton.Margin = new Padding(3, 4, 3, 4);
            NewOrderButton.Name = "NewOrderButton";
            NewOrderButton.Size = new Size(134, 67);
            NewOrderButton.TabIndex = 0;
            NewOrderButton.Text = "New Order";
            NewOrderButton.UseVisualStyleBackColor = true;
            NewOrderButton.Click += NewOrderButton_Click;
            // 
            // ViewOrderButton
            // 
            ViewOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ViewOrderButton.Location = new Point(14, 235);
            ViewOrderButton.Margin = new Padding(3, 4, 3, 4);
            ViewOrderButton.Name = "ViewOrderButton";
            ViewOrderButton.Size = new Size(134, 67);
            ViewOrderButton.TabIndex = 1;
            ViewOrderButton.Text = "View Order";
            ViewOrderButton.UseVisualStyleBackColor = true;
            ViewOrderButton.Click += ViewOrderButton_Click;
            // 
            // DeleteOrderButton
            // 
            DeleteOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeleteOrderButton.Location = new Point(14, 475);
            DeleteOrderButton.Margin = new Padding(3, 4, 3, 4);
            DeleteOrderButton.Name = "DeleteOrderButton";
            DeleteOrderButton.Size = new Size(134, 67);
            DeleteOrderButton.TabIndex = 2;
            DeleteOrderButton.Text = "Delete Order";
            DeleteOrderButton.UseVisualStyleBackColor = true;
            DeleteOrderButton.Click += DeleteOrderButton_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(914, 559);
            Controls.Add(DeleteOrderButton);
            Controls.Add(ViewOrderButton);
            Controls.Add(NewOrderButton);
            Controls.Add(OrderDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdersForm";
            Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrderDataGridView;
        private Button NewOrderButton;
        private Button ViewOrderButton;
        private Button DeleteOrderButton;
    }
}