namespace POS_Program
{
    partial class AddCustomer
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
            label1 = new Label();
            NameTextBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            PhoneTextBox = new TextBox();
            label2 = new Label();
            AddressTextBox = new TextBox();
            label3 = new Label();
            CityTextBox = new TextBox();
            label4 = new Label();
            StateTextBox = new TextBox();
            label5 = new Label();
            ZipTextBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(120, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 296);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 38);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(222, 296);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 38);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(120, 61);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(100, 23);
            PhoneTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 69);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Phone :";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(120, 110);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 118);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Address :";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(120, 160);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 23);
            CityTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 168);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "City :";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(120, 209);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(100, 23);
            StateTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 217);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "State :";
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(120, 258);
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(100, 23);
            ZipTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 266);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 12;
            label6.Text = "Zip :";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 346);
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
            Name = "AddCustomer";
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox PhoneTextBox;
        private Label label2;
        private TextBox AddressTextBox;
        private Label label3;
        private TextBox CityTextBox;
        private Label label4;
        private TextBox StateTextBox;
        private Label label5;
        private TextBox ZipTextBox;
        private Label label6;
    }
}