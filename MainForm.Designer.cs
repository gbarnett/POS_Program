namespace POS_Program
{
    partial class MainForm
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
            CustomersButton = new Button();
            ProductsButton = new Button();
            EmployeeButton = new Button();
            OrdersButton = new Button();
            ReportsButton = new Button();
            SuspendLayout();
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersButton.Location = new Point(14, 32);
            CustomersButton.Margin = new Padding(3, 4, 3, 4);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(133, 80);
            CustomersButton.TabIndex = 0;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsButton.Location = new Point(14, 256);
            ProductsButton.Margin = new Padding(3, 4, 3, 4);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(133, 80);
            ProductsButton.TabIndex = 2;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // EmployeeButton
            // 
            EmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeButton.Location = new Point(14, 144);
            EmployeeButton.Margin = new Padding(3, 4, 3, 4);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(133, 80);
            EmployeeButton.TabIndex = 1;
            EmployeeButton.Text = "Employees";
            EmployeeButton.UseVisualStyleBackColor = true;
            EmployeeButton.Click += EmployeeButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersButton.Location = new Point(14, 368);
            OrdersButton.Margin = new Padding(3, 4, 3, 4);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(133, 80);
            OrdersButton.TabIndex = 3;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportsButton.Location = new Point(16, 480);
            ReportsButton.Margin = new Padding(3, 4, 3, 4);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(133, 80);
            ReportsButton.TabIndex = 4;
            ReportsButton.Text = "Reports";
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(914, 600);
            Controls.Add(ReportsButton);
            Controls.Add(OrdersButton);
            Controls.Add(EmployeeButton);
            Controls.Add(ProductsButton);
            Controls.Add(CustomersButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button CustomersButton;
        private Button ProductsButton;
        private Button EmployeeButton;
        private Button OrdersButton;
        private Button ReportsButton;
    }
}