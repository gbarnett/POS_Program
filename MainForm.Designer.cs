﻿namespace POS_Program
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
            SuspendLayout();
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersButton.Location = new Point(12, 12);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(116, 72);
            CustomersButton.TabIndex = 0;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsButton.Location = new Point(12, 208);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(116, 72);
            ProductsButton.TabIndex = 2;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // EmployeeButton
            // 
            EmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeButton.Location = new Point(12, 110);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(116, 72);
            EmployeeButton.TabIndex = 1;
            EmployeeButton.Text = "Employees";
            EmployeeButton.UseVisualStyleBackColor = true;
            EmployeeButton.Click += EmployeeButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersButton.Location = new Point(12, 306);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(116, 72);
            OrdersButton.TabIndex = 3;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(OrdersButton);
            Controls.Add(EmployeeButton);
            Controls.Add(ProductsButton);
            Controls.Add(CustomersButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button CustomersButton;
        private Button ProductsButton;
        private Button EmployeeButton;
        private Button OrdersButton;
    }
}