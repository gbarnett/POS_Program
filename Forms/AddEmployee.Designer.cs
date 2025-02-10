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
            StateTextBox = new TextBox();
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
            SuspendLayout();
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(117, 258);
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(100, 23);
            ZipTextBox.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 266);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 26;
            label6.Text = "Zip :";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(117, 209);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(100, 23);
            StateTextBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 217);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 24;
            label5.Text = "State :";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(117, 160);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 23);
            CityTextBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 168);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 22;
            label4.Text = "City :";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(117, 110);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 118);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 20;
            label3.Text = "Address :";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(117, 61);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(100, 23);
            PhoneTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 69);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 18;
            label2.Text = "Phone :";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(240, 388);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 38);
            CancelButton.TabIndex = 17;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 396);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 38);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(117, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 14;
            label1.Text = "Name : ";
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(117, 305);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(100, 23);
            PositionTextBox.TabIndex = 28;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(117, 352);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(100, 23);
            SalaryTextBox.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 313);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 30;
            label7.Text = "Position :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 360);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 31;
            label8.Text = "Salary :";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 438);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SalaryTextBox);
            Controls.Add(PositionTextBox);
            Controls.Add(ZipTextBox);
            Controls.Add(label6);
            Controls.Add(StateTextBox);
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
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ZipTextBox;
        private Label label6;
        private TextBox StateTextBox;
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
    }
}