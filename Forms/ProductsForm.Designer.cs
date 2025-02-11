namespace POS_Program.Forms
{
    partial class ProductsForm
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
            AddProductButton = new Button();
            DeleteProductButton = new Button();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(154, 35);
            ProductsDataGridView.Margin = new Padding(3, 4, 3, 4);
            ProductsDataGridView.MultiSelect = false;
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(522, 525);
            ProductsDataGridView.TabIndex = 1;
            ProductsDataGridView.DataBindingComplete += ProductsDataGridView_DataBindingComplete;
            // 
            // AddProductButton
            // 
            AddProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddProductButton.Location = new Point(14, 35);
            AddProductButton.Margin = new Padding(3, 4, 3, 4);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(134, 67);
            AddProductButton.TabIndex = 2;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeleteProductButton.Location = new Point(14, 493);
            DeleteProductButton.Margin = new Padding(3, 4, 3, 4);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(134, 67);
            DeleteProductButton.TabIndex = 3;
            DeleteProductButton.Text = "Delete";
            DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditButton.Location = new Point(14, 243);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(134, 67);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(706, 587);
            Controls.Add(EditButton);
            Controls.Add(DeleteProductButton);
            Controls.Add(AddProductButton);
            Controls.Add(ProductsDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsForm";
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private Button AddProductButton;
        private Button DeleteProductButton;
        private Button EditButton;
    }
}