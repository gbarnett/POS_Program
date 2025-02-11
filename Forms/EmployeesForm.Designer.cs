namespace POS_Program.Forms
{
    partial class EmployeesForm
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
            EmployeeDataGridView = new DataGridView();
            EditEmployeeButton = new Button();
            DeleteEmployeeButton = new Button();
            AddEmployeeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.AllowUserToAddRows = false;
            EmployeeDataGridView.AllowUserToDeleteRows = false;
            EmployeeDataGridView.BorderStyle = BorderStyle.Fixed3D;
            EmployeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGridView.Location = new Point(154, 16);
            EmployeeDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeeDataGridView.MultiSelect = false;
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.RowHeadersVisible = false;
            EmployeeDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDataGridView.Size = new Size(746, 525);
            EmployeeDataGridView.TabIndex = 1;
            EmployeeDataGridView.DataBindingComplete += EmployeeDataGridView_DataBindingComplete;
            // 
            // EditEmployeeButton
            // 
            EditEmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditEmployeeButton.Location = new Point(14, 224);
            EditEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            EditEmployeeButton.Name = "EditEmployeeButton";
            EditEmployeeButton.Size = new Size(134, 67);
            EditEmployeeButton.TabIndex = 7;
            EditEmployeeButton.Text = "Edit";
            EditEmployeeButton.UseVisualStyleBackColor = true;
            EditEmployeeButton.Click += EditEmployeeButton_Click;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeleteEmployeeButton.Location = new Point(14, 475);
            DeleteEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(134, 67);
            DeleteEmployeeButton.TabIndex = 6;
            DeleteEmployeeButton.Text = "Delete";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddEmployeeButton.Location = new Point(14, 16);
            AddEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(134, 67);
            AddEmployeeButton.TabIndex = 5;
            AddEmployeeButton.Text = "Add";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(914, 600);
            Controls.Add(EditEmployeeButton);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(AddEmployeeButton);
            Controls.Add(EmployeeDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeesForm";
            Text = "EmployeesForm";
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EmployeeDataGridView;
        private Button EditEmployeeButton;
        private Button DeleteEmployeeButton;
        private Button AddEmployeeButton;
    }
}