namespace POS_Program.Forms
{
    partial class AddProduct
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
            DescriptionTextBox = new TextBox();
            label3 = new Label();
            PriceTextBox = new TextBox();
            label2 = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            NameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(92, 129);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(257, 97);
            DescriptionTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(185, 111);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 20;
            label3.Text = "Description :";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(185, 61);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(122, 69);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 18;
            label2.Text = "Price : ";
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(344, 232);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 38);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.FlatAppearance.BorderColor = Color.Black;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(22, 232);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 38);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(185, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(122, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 14;
            label1.Text = "Name : ";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(433, 282);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label3);
            Controls.Add(PriceTextBox);
            Controls.Add(label2);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "Add / Edit Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox DescriptionTextBox;
        private Label label3;
        private TextBox PriceTextBox;
        private Label label2;
        private Button CancelButton;
        private Button SaveButton;
        private TextBox NameTextBox;
        private Label label1;
    }
}