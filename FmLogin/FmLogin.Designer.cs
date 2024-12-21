namespace CourtManagement.FmLogin
{
    partial class FmLogin
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
            txbLogin = new TextBox();
            txbPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            lbLogin = new Label();
            lbRegister = new Label();
            SuspendLayout();
            // 
            // txbLogin
            // 
            txbLogin.BackColor = Color.Silver;
            txbLogin.BorderStyle = BorderStyle.None;
            txbLogin.Location = new Point(244, 85);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(125, 20);
            txbLogin.TabIndex = 0;
            txbLogin.Leave += txbLogin_Leave;
            // 
            // txbPassword
            // 
            txbPassword.BackColor = Color.Silver;
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Location = new Point(239, 143);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(125, 20);
            txbPassword.TabIndex = 1;
            txbPassword.Leave += txbPassword_Leave;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Silver;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(206, 233);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(116, 56);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Rejestracja";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(344, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 56);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Zaloguj";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(91, 88);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(139, 20);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Nazwa uzytkownika";
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Location = new Point(183, 150);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(47, 20);
            lbRegister.TabIndex = 5;
            lbRegister.Text = "Hasło";
            // 
            // FmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRegister);
            Controls.Add(lbLogin);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txbPassword);
            Controls.Add(txbLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FmLogin";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbLogin;
        private TextBox txbPassword;
        private Button btnRegister;
        private Button btnLogin;
        private Label lbLogin;
        private Label lbRegister;
    }
}