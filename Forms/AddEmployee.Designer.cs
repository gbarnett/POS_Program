namespace POS_Program.Forms
{
    partial class AddEmployee
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
            ZipTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            CityTextBox = new TextBox();
            label4 = new Label();
            AddressTextBox = new TextBox();
            label3 = new Label();
            PhoneTextBox = new TextBox();
            label2 = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            NameTextBox = new TextBox();
            label1 = new Label();
            PositionTextBox = new TextBox();
            SalaryTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            StateComboBox = new ComboBox();
            IsAdminCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(117, 228);
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(100, 23);
            ZipTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(77, 234);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 26;
            label6.Text = "Zip :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(70, 192);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 24;
            label5.Text = "State :";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(117, 144);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 23);
            CityTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(77, 150);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 22;
            label4.Text = "City :";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(117, 102);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(54, 108);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 20;
            label3.Text = "Address :";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(117, 61);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(100, 23);
            PhoneTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(63, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 18;
            label2.Text = "Phone :";
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(240, 444);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 38);
            CancelButton.TabIndex = 12;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(12, 444);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 38);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(117, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 14;
            label1.Text = "Name : ";
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(117, 270);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(100, 23);
            PositionTextBox.TabIndex = 6;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(117, 312);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(100, 23);
            SalaryTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(49, 276);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 30;
            label7.Text = "Position :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(63, 318);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 31;
            label8.Text = "Salary :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(42, 402);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 35;
            label9.Text = "Password :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(42, 360);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 34;
            label10.Text = "Username :";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(119, 396);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 9;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(119, 354);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(100, 23);
            UsernameTextBox.TabIndex = 8;
            // 
            // StateComboBox
            // 
            StateComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Location = new Point(119, 186);
            StateComboBox.Margin = new Padding(3, 2, 3, 2);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(100, 23);
            StateComboBox.TabIndex = 4;
            // 
            // IsAdminCheckBox
            // 
            IsAdminCheckBox.AutoSize = true;
            IsAdminCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsAdminCheckBox.Location = new Point(133, 444);
            IsAdminCheckBox.Margin = new Padding(3, 2, 3, 2);
            IsAdminCheckBox.Name = "IsAdminCheckBox";
            IsAdminCheckBox.Size = new Size(62, 19);
            IsAdminCheckBox.TabIndex = 10;
            IsAdminCheckBox.Text = "Admin";
            IsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(327, 494);
            Controls.Add(IsAdminCheckBox);
            Controls.Add(StateComboBox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SalaryTextBox);
            Controls.Add(PositionTextBox);
            Controls.Add(ZipTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CityTextBox);
            Controls.Add(label4);
            Controls.Add(AddressTextBox);
            Controls.Add(label3);
            Controls.Add(PhoneTextBox);
            Controls.Add(label2);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "AddEmployee";
            Text = "Add / Edit Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ZipTextBox;
        private Label label6;
        private Label label5;
        private TextBox CityTextBox;
        private Label label4;
        private TextBox AddressTextBox;
        private Label label3;
        private TextBox PhoneTextBox;
        private Label label2;
        private Button CancelButton;
        private Button SaveButton;
        private TextBox NameTextBox;
        private Label label1;
        private TextBox PositionTextBox;
        private TextBox SalaryTextBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private ComboBox StateComboBox;
        private CheckBox IsAdminCheckBox;
    }
}