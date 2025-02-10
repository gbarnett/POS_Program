namespace POS_Program.Forms
{
    partial class NewOrderForm
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
            ProductsDataGridView = new DataGridView();
            CartDataGridView = new DataGridView();
            AddProductButton = new Button();
            RemoveProductButton = new Button();
            CheckOutButton = new Button();
            TotalLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            CustomerDataGridView = new DataGridView();
            label3 = new Label();
            CustomerSelectButton = new Button();
            CustomerNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(204, 34);
            ProductsDataGridView.MultiSelect = false;
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(325, 356);
            ProductsDataGridView.TabIndex = 2;
            // 
            // CartDataGridView
            // 
            CartDataGridView.AllowUserToAddRows = false;
            CartDataGridView.AllowUserToDeleteRows = false;
            CartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CartDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartDataGridView.Location = new Point(655, 34);
            CartDataGridView.MultiSelect = false;
            CartDataGridView.Name = "CartDataGridView";
            CartDataGridView.ReadOnly = true;
            CartDataGridView.RowHeadersVisible = false;
            CartDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CartDataGridView.Size = new Size(325, 356);
            CartDataGridView.TabIndex = 3;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(535, 111);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(114, 51);
            AddProductButton.TabIndex = 4;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // RemoveProductButton
            // 
            RemoveProductButton.Location = new Point(535, 287);
            RemoveProductButton.Name = "RemoveProductButton";
            RemoveProductButton.Size = new Size(114, 51);
            RemoveProductButton.TabIndex = 5;
            RemoveProductButton.Text = "Remove";
            RemoveProductButton.UseVisualStyleBackColor = true;
            RemoveProductButton.Click += RemoveProductButton_Click;
            // 
            // CheckOutButton
            // 
            CheckOutButton.Location = new Point(866, 396);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(114, 51);
            CheckOutButton.TabIndex = 6;
            CheckOutButton.Text = "Checkout";
            CheckOutButton.UseVisualStyleBackColor = true;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(560, 420);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(71, 21);
            TotalLabel.TabIndex = 7;
            TotalLabel.Text = "Total : $0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 10);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 8;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(800, 10);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 9;
            label2.Text = "Cart";
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.AllowUserToAddRows = false;
            CustomerDataGridView.AllowUserToDeleteRows = false;
            CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(5, 34);
            CustomerDataGridView.MultiSelect = false;
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.Size = new Size(193, 356);
            CustomerDataGridView.TabIndex = 10;
            CustomerDataGridView.DataBindingComplete += CustomerDataGridView_DataBindingComplete;
            CustomerDataGridView.SelectionChanged += CustomerDataGridView_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 10);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 11;
            label3.Text = "Customer";
            // 
            // CustomerSelectButton
            // 
            CustomerSelectButton.Location = new Point(14, 396);
            CustomerSelectButton.Name = "CustomerSelectButton";
            CustomerSelectButton.Size = new Size(114, 51);
            CustomerSelectButton.TabIndex = 12;
            CustomerSelectButton.Text = "Select";
            CustomerSelectButton.UseVisualStyleBackColor = true;
            CustomerSelectButton.Click += CustomerSelectButton_Click;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerNameLabel.Location = new Point(332, 420);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(78, 21);
            CustomerNameLabel.TabIndex = 13;
            CustomerNameLabel.Text = "Customer";
            CustomerNameLabel.Visible = false;
            // 
            // NewOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(992, 450);
            Controls.Add(CustomerNameLabel);
            Controls.Add(CustomerSelectButton);
            Controls.Add(label3);
            Controls.Add(CustomerDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TotalLabel);
            Controls.Add(CheckOutButton);
            Controls.Add(RemoveProductButton);
            Controls.Add(AddProductButton);
            Controls.Add(CartDataGridView);
            Controls.Add(ProductsDataGridView);
            Name = "NewOrderForm";
            Text = "New Order";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private DataGridView CartDataGridView;
        private Button AddProductButton;
        private Button RemoveProductButton;
        private Button CheckOutButton;
        private Label TotalLabel;
        private Label label1;
        private Label label2;
        private DataGridView CustomerDataGridView;
        private Label label3;
        private Button CustomerSelectButton;
        private Label CustomerNameLabel;
    }
}