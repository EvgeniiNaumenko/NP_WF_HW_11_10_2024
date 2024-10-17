namespace LobbyForm
{
    partial class Lobby
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
            SendButton = new Button();
            OnlineUsersTextBox = new TextBox();
            UsersMessageTextBox = new TextBox();
            SendMessageTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Users Online:";
            // 
            // SendButton
            // 
            SendButton.Location = new Point(606, 343);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(149, 33);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // OnlineUsersTextBox
            // 
            OnlineUsersTextBox.Location = new Point(38, 49);
            OnlineUsersTextBox.Multiline = true;
            OnlineUsersTextBox.Name = "OnlineUsersTextBox";
            OnlineUsersTextBox.ReadOnly = true;
            OnlineUsersTextBox.Size = new Size(210, 326);
            OnlineUsersTextBox.TabIndex = 2;
            // 
            // UsersMessageTextBox
            // 
            UsersMessageTextBox.BackColor = SystemColors.ButtonHighlight;
            UsersMessageTextBox.Location = new Point(273, 49);
            UsersMessageTextBox.Multiline = true;
            UsersMessageTextBox.Name = "UsersMessageTextBox";
            UsersMessageTextBox.ReadOnly = true;
            UsersMessageTextBox.Size = new Size(482, 255);
            UsersMessageTextBox.TabIndex = 3;
            // 
            // SendMessageTextBox
            // 
            SendMessageTextBox.Location = new Point(273, 310);
            SendMessageTextBox.Name = "SendMessageTextBox";
            SendMessageTextBox.Size = new Size(482, 27);
            SendMessageTextBox.TabIndex = 4;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendMessageTextBox);
            Controls.Add(UsersMessageTextBox);
            Controls.Add(OnlineUsersTextBox);
            Controls.Add(SendButton);
            Controls.Add(label1);
            Name = "Lobby";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SendButton;
        private TextBox OnlineUsersTextBox;
        private TextBox UsersMessageTextBox;
        private TextBox SendMessageTextBox;
    }
}
