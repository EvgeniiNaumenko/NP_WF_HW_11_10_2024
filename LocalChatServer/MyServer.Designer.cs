namespace LocalChatServer
{
    partial class MyServer
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
            StartServerButton = new Button();
            label1 = new Label();
            ServerStatusLable = new Label();
            SuspendLayout();
            // 
            // StartServerButton
            // 
            StartServerButton.Location = new Point(45, 87);
            StartServerButton.Name = "StartServerButton";
            StartServerButton.Size = new Size(165, 49);
            StartServerButton.TabIndex = 0;
            StartServerButton.Text = "Start Server";
            StartServerButton.UseVisualStyleBackColor = true;
            StartServerButton.Click += StartServerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 42);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Server status :";
            // 
            // ServerStatusLable
            // 
            ServerStatusLable.AutoSize = true;
            ServerStatusLable.Location = new Point(143, 42);
            ServerStatusLable.Name = "ServerStatusLable";
            ServerStatusLable.Size = new Size(54, 20);
            ServerStatusLable.TabIndex = 2;
            ServerStatusLable.Text = "Offline";
            // 
            // MyServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 187);
            Controls.Add(ServerStatusLable);
            Controls.Add(label1);
            Controls.Add(StartServerButton);
            Name = "MyServer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartServerButton;
        private Label label1;
        private Label ServerStatusLable;
    }
}
