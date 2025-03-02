﻿namespace POS_Program.Forms
{
    partial class OrderView
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
            OrderItemsDataGridView = new DataGridView();
            CustomerNameLabel = new Label();
            PriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderItemsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderItemsDataGridView
            // 
            OrderItemsDataGridView.AllowUserToAddRows = false;
            OrderItemsDataGridView.AllowUserToDeleteRows = false;
            OrderItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderItemsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            OrderItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderItemsDataGridView.Location = new Point(12, 70);
            OrderItemsDataGridView.MultiSelect = false;
            OrderItemsDataGridView.Name = "OrderItemsDataGridView";
            OrderItemsDataGridView.ReadOnly = true;
            OrderItemsDataGridView.RowHeadersVisible = false;
            OrderItemsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            OrderItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderItemsDataGridView.Size = new Size(442, 368);
            OrderItemsDataGridView.TabIndex = 11;
            OrderItemsDataGridView.DataBindingComplete += OrderItemsDataGridView_DataBindingComplete;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CustomerNameLabel.Location = new Point(178, 9);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(83, 21);
            CustomerNameLabel.TabIndex = 12;
            CustomerNameLabel.Text = "Customer";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PriceLabel.Location = new Point(196, 46);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(60, 21);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "Price : ";
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(466, 450);
            Controls.Add(PriceLabel);
            Controls.Add(CustomerNameLabel);
            Controls.Add(OrderItemsDataGridView);
            Name = "OrderView";
            Text = "View Order";
            ((System.ComponentModel.ISupportInitialize)OrderItemsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderItemsDataGridView;
        private Label CustomerNameLabel;
        private Label PriceLabel;
    }
}