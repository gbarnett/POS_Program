namespace POS_Program
{
    partial class CustomersForm
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
            panel1 = new Panel();
            CustomerDataGridView = new DataGridView();
            AddCustomerButton = new Button();
            DeleteCustomerButton = new Button();
            EditCustomerButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CustomerDataGridView);
            panel1.Location = new Point(135, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 394);
            panel1.TabIndex = 0;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.AllowUserToAddRows = false;
            CustomerDataGridView.AllowUserToDeleteRows = false;
            CustomerDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(0, 0);
            CustomerDataGridView.MultiSelect = false;
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.Size = new Size(653, 394);
            CustomerDataGridView.TabIndex = 0;
            CustomerDataGridView.DataBindingComplete += CustomerDataGridView_DataBindingComplete;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddCustomerButton.Location = new Point(12, 12);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(117, 61);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeleteCustomerButton.Location = new Point(12, 345);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(117, 61);
            DeleteCustomerButton.TabIndex = 2;
            DeleteCustomerButton.Text = "Delete";
            DeleteCustomerButton.UseVisualStyleBackColor = true;
            DeleteCustomerButton.Click += DeleteCustomerButton_Click;
            // 
            // EditCustomerButton
            // 
            EditCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditCustomerButton.Location = new Point(12, 171);
            EditCustomerButton.Name = "EditCustomerButton";
            EditCustomerButton.Size = new Size(117, 61);
            EditCustomerButton.TabIndex = 3;
            EditCustomerButton.Text = "Edit";
            EditCustomerButton.UseVisualStyleBackColor = true;
            EditCustomerButton.Click += EditCustomerButton_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(EditCustomerButton);
            Controls.Add(DeleteCustomerButton);
            Controls.Add(AddCustomerButton);
            Controls.Add(panel1);
            Name = "CustomersForm";
            Text = "Customers";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView CustomerDataGridView;
        private Button AddCustomerButton;
        private Button DeleteCustomerButton;
        private Button EditCustomerButton;
    }
}