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
            EmployeeDataGridView.Location = new Point(135, 12);
            EmployeeDataGridView.MultiSelect = false;
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.RowHeadersVisible = false;
            EmployeeDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDataGridView.Size = new Size(653, 394);
            EmployeeDataGridView.TabIndex = 1;
            EmployeeDataGridView.DataBindingComplete += EmployeeDataGridView_DataBindingComplete;
            // 
            // EditEmployeeButton
            // 
            EditEmployeeButton.Location = new Point(12, 168);
            EditEmployeeButton.Name = "EditEmployeeButton";
            EditEmployeeButton.Size = new Size(117, 50);
            EditEmployeeButton.TabIndex = 7;
            EditEmployeeButton.Text = "Edit";
            EditEmployeeButton.UseVisualStyleBackColor = true;
            EditEmployeeButton.Click += EditEmployeeButton_Click;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Location = new Point(12, 356);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(117, 50);
            DeleteEmployeeButton.TabIndex = 6;
            DeleteEmployeeButton.Text = "Delete";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new Point(12, 12);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(117, 50);
            AddEmployeeButton.TabIndex = 5;
            AddEmployeeButton.Text = "Add";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(EditEmployeeButton);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(AddEmployeeButton);
            Controls.Add(EmployeeDataGridView);
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