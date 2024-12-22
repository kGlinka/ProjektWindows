namespace CourtManagement.Login
{
    partial class FmRegistration
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
            lbLogin = new Label();
            lbPassword = new Label();
            txbPassword = new TextBox();
            lbName = new Label();
            txbName = new TextBox();
            lbLastName = new Label();
            txbLastName = new TextBox();
            lbZipCode = new Label();
            txbZipCode = new TextBox();
            lbCity = new Label();
            txbCity = new TextBox();
            lbStreet = new Label();
            txbStreet = new TextBox();
            lbPhoneNumber = new Label();
            lbEmail = new Label();
            txbEmail = new TextBox();
            txbPhoneNumber = new TextBox();
            btnSave = new Button();
            PBUserImage = new PictureBox();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)PBUserImage).BeginInit();
            SuspendLayout();
            // 
            // txbLogin
            // 
            txbLogin.BackColor = Color.Silver;
            txbLogin.BorderStyle = BorderStyle.None;
            txbLogin.Location = new Point(157, 12);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(125, 20);
            txbLogin.TabIndex = 0;
            txbLogin.Leave += txbLogin_Leave;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(12, 9);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(139, 20);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Nazwa użytkownika\r\n";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(95, 38);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(47, 40);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Hasło\r\n\r\n";
            // 
            // txbPassword
            // 
            txbPassword.BackColor = Color.Silver;
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Location = new Point(157, 38);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(125, 20);
            txbPassword.TabIndex = 1;
            txbPassword.Leave += txbPassword_Leave;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(104, 64);
            lbName.Name = "lbName";
            lbName.Size = new Size(38, 20);
            lbName.TabIndex = 5;
            lbName.Text = "Imię\r\n";
            // 
            // txbName
            // 
            txbName.BackColor = Color.Silver;
            txbName.BorderStyle = BorderStyle.None;
            txbName.Location = new Point(157, 64);
            txbName.Name = "txbName";
            txbName.Size = new Size(125, 20);
            txbName.TabIndex = 2;
            txbName.Leave += txbName_Leave;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(70, 90);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(72, 20);
            lbLastName.TabIndex = 7;
            lbLastName.Text = "Nazwisko\r\n";
            // 
            // txbLastName
            // 
            txbLastName.BackColor = Color.Silver;
            txbLastName.BorderStyle = BorderStyle.None;
            txbLastName.Location = new Point(157, 90);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(125, 20);
            txbLastName.TabIndex = 3;
            txbLastName.Leave += txbLastName_Leave;
            // 
            // lbZipCode
            // 
            lbZipCode.AutoSize = true;
            lbZipCode.Location = new Point(10, 150);
            lbZipCode.Name = "lbZipCode";
            lbZipCode.Size = new Size(104, 20);
            lbZipCode.TabIndex = 9;
            lbZipCode.Text = "Kod pocztowy\r\n";
            // 
            // txbZipCode
            // 
            txbZipCode.BackColor = Color.Silver;
            txbZipCode.BorderStyle = BorderStyle.None;
            txbZipCode.Location = new Point(120, 150);
            txbZipCode.Name = "txbZipCode";
            txbZipCode.Size = new Size(81, 20);
            txbZipCode.TabIndex = 4;
            txbZipCode.Leave += txbZipCode_Leave;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(207, 150);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(54, 20);
            lbCity.TabIndex = 11;
            lbCity.Text = "Miasto";
            // 
            // txbCity
            // 
            txbCity.BackColor = Color.Silver;
            txbCity.BorderStyle = BorderStyle.None;
            txbCity.Location = new Point(267, 150);
            txbCity.Name = "txbCity";
            txbCity.Size = new Size(154, 20);
            txbCity.TabIndex = 5;
            txbCity.Leave += txbCity_Leave;
            // 
            // lbStreet
            // 
            lbStreet.AutoSize = true;
            lbStreet.Location = new Point(70, 176);
            lbStreet.Name = "lbStreet";
            lbStreet.Size = new Size(42, 20);
            lbStreet.TabIndex = 13;
            lbStreet.Text = "Ulica";
            // 
            // txbStreet
            // 
            txbStreet.BackColor = Color.Silver;
            txbStreet.BorderStyle = BorderStyle.None;
            txbStreet.Location = new Point(120, 176);
            txbStreet.Name = "txbStreet";
            txbStreet.Size = new Size(303, 20);
            txbStreet.TabIndex = 6;
            txbStreet.Leave += txbStreet_Leave;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(-1, 202);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(113, 20);
            lbPhoneNumber.TabIndex = 15;
            lbPhoneNumber.Text = "Numer telefonu";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(66, 228);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 17;
            lbEmail.Text = "Email";
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbEmail.BackColor = Color.Silver;
            txbEmail.BorderStyle = BorderStyle.None;
            txbEmail.Location = new Point(120, 228);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(222, 20);
            txbEmail.TabIndex = 8;
            txbEmail.Leave += txbEmail_Leave;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbPhoneNumber.BackColor = Color.Silver;
            txbPhoneNumber.BorderStyle = BorderStyle.None;
            txbPhoneNumber.Location = new Point(120, 202);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(125, 20);
            txbPhoneNumber.TabIndex = 7;
            txbPhoneNumber.Leave += txbPhoneNumber_Leave;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.Silver;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(305, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 56);
            btnSave.TabIndex = 9;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // PBUserImage
            // 
            PBUserImage.BackgroundImageLayout = ImageLayout.None;
            PBUserImage.Image = Properties.Resources.User128;
            PBUserImage.Location = new Point(293, 9);
            PBUserImage.Name = "PBUserImage";
            PBUserImage.Size = new Size(128, 128);
            PBUserImage.SizeMode = PictureBoxSizeMode.AutoSize;
            PBUserImage.TabIndex = 20;
            PBUserImage.TabStop = false;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCancel.BackColor = Color.Silver;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Location = new Point(12, 261);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(116, 56);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "Anuluj";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(428, 329);
            Controls.Add(BtnCancel);
            Controls.Add(PBUserImage);
            Controls.Add(btnSave);
            Controls.Add(lbEmail);
            Controls.Add(txbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(txbPhoneNumber);
            Controls.Add(lbStreet);
            Controls.Add(txbStreet);
            Controls.Add(lbCity);
            Controls.Add(txbCity);
            Controls.Add(lbZipCode);
            Controls.Add(txbZipCode);
            Controls.Add(lbLastName);
            Controls.Add(txbLastName);
            Controls.Add(lbName);
            Controls.Add(txbName);
            Controls.Add(lbPassword);
            Controls.Add(txbPassword);
            Controls.Add(lbLogin);
            Controls.Add(txbLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FmRegistration";
            Text = "Rejestracja";
            ((System.ComponentModel.ISupportInitialize)PBUserImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbLogin;
        private Label lbLogin;
        private Label lbPassword;
        private TextBox txbPassword;
        private Label lbName;
        private TextBox txbName;
        private Label lbLastName;
        private TextBox txbLastName;
        private Label lbZipCode;
        private TextBox txbZipCode;
        private Label lbCity;
        private TextBox txbCity;
        private Label lbStreet;
        private TextBox txbStreet;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private TextBox txbEmail;
        private TextBox txbPhoneNumber;
        private Button btnSave;
        private PictureBox PBUserImage;
        private Button BtnCancel;
    }
}