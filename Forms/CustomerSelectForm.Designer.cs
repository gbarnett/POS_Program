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
            CustomerSelectButton.Location = new Point(136, 528);
            CustomerSelectButton.Margin = new Padding(3, 4, 3, 4);
            CustomerSelectButton.Name = "CustomerSelectButton";
            CustomerSelectButton.Size = new Size(130, 68);
            CustomerSelectButton.TabIndex = 15;
            CustomerSelectButton.Text = "Select";
            CustomerSelectButton.UseVisualStyleBackColor = true;
            CustomerSelectButton.Click += CustomerSelectButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 8);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
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
            CustomerDataGridView.Location = new Point(32, 40);
            CustomerDataGridView.Margin = new Padding(3, 4, 3, 4);
            CustomerDataGridView.MultiSelect = false;
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.Size = new Size(328, 475);
            CustomerDataGridView.TabIndex = 13;
            CustomerDataGridView.DataBindingComplete += CustomerDataGridView_DataBindingComplete;
            // 
            // CustomerSelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(387, 602);
            Controls.Add(CustomerSelectButton);
            Controls.Add(label3);
            Controls.Add(CustomerDataGridView);
            Name = "CustomerSelectForm";
            Text = "CustomerSelectForm";
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