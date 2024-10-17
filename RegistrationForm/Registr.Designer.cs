namespace RegistrationForm
{
    partial class Registr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LoginTextBox = new TextBox();
            EmailTextBox = new TextBox();
            label2 = new Label();
            ConfirmPasswordTextBox = new TextBox();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            label4 = new Label();
            RegisterButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(34, 42);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(215, 27);
            LoginTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(34, 96);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(215, 27);
            EmailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(34, 204);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(215, 27);
            ConfirmPasswordTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 181);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 6;
            label3.Text = "Repeat Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(34, 150);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(215, 27);
            PasswordTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 127);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(34, 249);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(133, 31);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(185, 249);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(64, 31);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Registr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 303);
            Controls.Add(BackButton);
            Controls.Add(RegisterButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label4);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(LoginTextBox);
            Controls.Add(label1);
            Name = "Registr";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private Label label2;
        private TextBox ConfirmPasswordTextBox;
        private Label label3;
        private TextBox PasswordTextBox;
        private Label label4;
        private Button RegisterButton;
        private Button BackButton;
    }
}
