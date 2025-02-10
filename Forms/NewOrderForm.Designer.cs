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
            CustomerNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(14, 45);
            ProductsDataGridView.Margin = new Padding(3, 4, 3, 4);
            ProductsDataGridView.MultiSelect = false;
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(371, 475);
            ProductsDataGridView.TabIndex = 2;
            // 
            // CartDataGridView
            // 
            CartDataGridView.AllowUserToAddRows = false;
            CartDataGridView.AllowUserToDeleteRows = false;
            CartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CartDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartDataGridView.Location = new Point(530, 45);
            CartDataGridView.Margin = new Padding(3, 4, 3, 4);
            CartDataGridView.MultiSelect = false;
            CartDataGridView.Name = "CartDataGridView";
            CartDataGridView.ReadOnly = true;
            CartDataGridView.RowHeadersVisible = false;
            CartDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CartDataGridView.Size = new Size(371, 475);
            CartDataGridView.TabIndex = 3;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(392, 148);
            AddProductButton.Margin = new Padding(3, 4, 3, 4);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(130, 68);
            AddProductButton.TabIndex = 4;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // RemoveProductButton
            // 
            RemoveProductButton.Location = new Point(392, 383);
            RemoveProductButton.Margin = new Padding(3, 4, 3, 4);
            RemoveProductButton.Name = "RemoveProductButton";
            RemoveProductButton.Size = new Size(130, 68);
            RemoveProductButton.TabIndex = 5;
            RemoveProductButton.Text = "Remove";
            RemoveProductButton.UseVisualStyleBackColor = true;
            RemoveProductButton.Click += RemoveProductButton_Click;
            // 
            // CheckOutButton
            // 
            CheckOutButton.Location = new Point(771, 528);
            CheckOutButton.Margin = new Padding(3, 4, 3, 4);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(130, 68);
            CheckOutButton.TabIndex = 6;
            CheckOutButton.Text = "Checkout";
            CheckOutButton.UseVisualStyleBackColor = true;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(421, 560);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(90, 28);
            TotalLabel.TabIndex = 7;
            TotalLabel.Text = "Total : $0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 13);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 8;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(695, 13);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 9;
            label2.Text = "Cart";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerNameLabel.Location = new Point(160, 560);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(96, 28);
            CustomerNameLabel.TabIndex = 13;
            CustomerNameLabel.Text = "Customer";
            CustomerNameLabel.Visible = false;
            // 
            // NewOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(915, 600);
            Controls.Add(CustomerNameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TotalLabel);
            Controls.Add(CheckOutButton);
            Controls.Add(RemoveProductButton);
            Controls.Add(AddProductButton);
            Controls.Add(CartDataGridView);
            Controls.Add(ProductsDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewOrderForm";
            Text = "New Order";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).EndInit();
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
        private Label CustomerNameLabel;
    }
}