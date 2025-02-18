namespace POS_Program.Forms
{
    partial class LoginForm
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
            label2 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 96);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(98, 54);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(110, 23);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(98, 96);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(110, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.Location = new Point(98, 138);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(114, 39);
            LoginButton.TabIndex = 16;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 128, 0);
            ClientSize = new Size(291, 182);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}