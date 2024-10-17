namespace LoginForm
{
    partial class Login
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
            EnterButton = new Button();
            RegistrationButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(30, 178);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(216, 30);
            EnterButton.TabIndex = 0;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(29, 234);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(216, 30);
            RegistrationButton.TabIndex = 1;
            RegistrationButton.Text = "Registration";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 89);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 211);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 4;
            label3.Text = "or";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(30, 46);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(215, 27);
            LoginTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(30, 123);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(215, 27);
            PasswordTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 303);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegistrationButton);
            Controls.Add(EnterButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterButton;
        private Button RegistrationButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
    }
}
