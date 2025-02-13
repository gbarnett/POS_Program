namespace POS_Program.Forms
{
    partial class SalesReports
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
            OrderDataGridView = new DataGridView();
            DailyButton = new Button();
            MonthlyButton = new Button();
            YearlyButton = new Button();
            TotalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDataGridView.BorderStyle = BorderStyle.Fixed3D;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Location = new Point(200, 16);
            OrderDataGridView.Margin = new Padding(3, 4, 3, 4);
            OrderDataGridView.MultiSelect = false;
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.ReadOnly = true;
            OrderDataGridView.RowHeadersVisible = false;
            OrderDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            OrderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderDataGridView.Size = new Size(746, 525);
            OrderDataGridView.TabIndex = 4;
            // 
            // DailyButton
            // 
            DailyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DailyButton.Location = new Point(32, 24);
            DailyButton.Margin = new Padding(3, 4, 3, 4);
            DailyButton.Name = "DailyButton";
            DailyButton.Size = new Size(134, 67);
            DailyButton.TabIndex = 6;
            DailyButton.Text = "Daily Sales";
            DailyButton.UseVisualStyleBackColor = true;
            DailyButton.Click += DailyButton_Click;
            // 
            // MonthlyButton
            // 
            MonthlyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MonthlyButton.Location = new Point(32, 168);
            MonthlyButton.Margin = new Padding(3, 4, 3, 4);
            MonthlyButton.Name = "MonthlyButton";
            MonthlyButton.Size = new Size(134, 67);
            MonthlyButton.TabIndex = 7;
            MonthlyButton.Text = "Monthly Sales";
            MonthlyButton.UseVisualStyleBackColor = true;
            MonthlyButton.Click += MonthlyButton_Click;
            // 
            // YearlyButton
            // 
            YearlyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            YearlyButton.Location = new Point(32, 320);
            YearlyButton.Margin = new Padding(3, 4, 3, 4);
            YearlyButton.Name = "YearlyButton";
            YearlyButton.Size = new Size(134, 67);
            YearlyButton.TabIndex = 8;
            YearlyButton.Text = "Yearly Sales";
            YearlyButton.UseVisualStyleBackColor = true;
            YearlyButton.Click += YearlyButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TotalLabel.Location = new Point(8, 472);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(70, 28);
            TotalLabel.TabIndex = 14;
            TotalLabel.Text = "Total :";
            // 
            // SalesReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(964, 552);
            Controls.Add(TotalLabel);
            Controls.Add(YearlyButton);
            Controls.Add(MonthlyButton);
            Controls.Add(DailyButton);
            Controls.Add(OrderDataGridView);
            Name = "SalesReports";
            Text = "SalesReports";
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderDataGridView;
        private Button DailyButton;
        private Button MonthlyButton;
        private Button YearlyButton;
        private Label TotalLabel;
    }
}