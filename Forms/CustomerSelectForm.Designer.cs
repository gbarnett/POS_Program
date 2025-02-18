namespace POS_Program.Forms
{
    partial class CustomerSelectForm
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
            CustomerSelectButton = new Button();
            label3 = new Label();
            CustomerDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CustomerSelectButton
            // 
            CustomerSelectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerSelectButton.Location = new Point(119, 396);
            CustomerSelectButton.Name = "CustomerSelectButton";
            CustomerSelectButton.Size = new Size(114, 51);
            CustomerSelectButton.TabIndex = 15;
            CustomerSelectButton.Text = "Select";
            CustomerSelectButton.UseVisualStyleBackColor = true;
            CustomerSelectButton.Click += CustomerSelectButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 6);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 14;
            label3.Text = "Customer";
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.AllowUserToAddRows = false;
            CustomerDataGridView.AllowUserToDeleteRows = false;
            CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(28, 30);
            CustomerDataGridView.MultiSelect = false;
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.Size = new Size(287, 356);
            CustomerDataGridView.TabIndex = 13;
            CustomerDataGridView.DataBindingComplete += CustomerDataGridView_DataBindingComplete;
            // 
            // CustomerSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(339, 452);
            Controls.Add(CustomerSelectButton);
            Controls.Add(label3);
            Controls.Add(CustomerDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerSelectForm";
            Text = "Select Customer";
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CustomerSelectButton;
        private Label label3;
        private DataGridView CustomerDataGridView;
    }
}