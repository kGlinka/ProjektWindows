namespace CourtManagement
{
    partial class FmMain
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
            PanelMenu = new Panel();
            PanelFooter = new Panel();
            PanelMainMenu = new Panel();
            BtnClientCard = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BtnStormCourt = new Button();
            pictureBox2 = new PictureBox();
            PanelMenu.SuspendLayout();
            PanelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnClientCard);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(133, 450);
            PanelMenu.TabIndex = 0;
            // 
            // PanelFooter
            // 
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.Location = new Point(133, 412);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(493, 38);
            PanelFooter.TabIndex = 1;
            // 
            // PanelMainMenu
            // 
            PanelMainMenu.BackColor = Color.DimGray;
            PanelMainMenu.Controls.Add(pictureBox2);
            PanelMainMenu.Controls.Add(BtnStormCourt);
            PanelMainMenu.Dock = DockStyle.Fill;
            PanelMainMenu.Location = new Point(133, 0);
            PanelMainMenu.Name = "PanelMainMenu";
            PanelMainMenu.Size = new Size(493, 412);
            PanelMainMenu.TabIndex = 2;
            // 
            // BtnClientCard
            // 
            BtnClientCard.BackColor = Color.LightSlateGray;
            BtnClientCard.FlatStyle = FlatStyle.Flat;
            BtnClientCard.Location = new Point(12, 146);
            BtnClientCard.Name = "BtnClientCard";
            BtnClientCard.Size = new Size(110, 53);
            BtnClientCard.TabIndex = 0;
            BtnClientCard.Text = "Karta członkowska\r\n";
            BtnClientCard.UseVisualStyleBackColor = false;
            BtnClientCard.Click += BtnClientCard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.User128;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(133, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 17);
            panel1.TabIndex = 2;
            // 
            // BtnStormCourt
            // 
            BtnStormCourt.BackColor = Color.LightSlateGray;
            BtnStormCourt.FlatStyle = FlatStyle.Flat;
            BtnStormCourt.Location = new Point(4, 23);
            BtnStormCourt.Name = "BtnStormCourt";
            BtnStormCourt.Size = new Size(218, 186);
            BtnStormCourt.TabIndex = 1;
            BtnStormCourt.Text = "Storm Court";
            BtnStormCourt.TextAlign = ContentAlignment.BottomCenter;
            BtnStormCourt.UseVisualStyleBackColor = false;
            BtnStormCourt.Click += BtnStormCourt_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(20, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 145);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // FmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(626, 450);
            Controls.Add(panel1);
            Controls.Add(PanelMainMenu);
            Controls.Add(PanelFooter);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FmMain";
            Text = "FmMain";
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            PanelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelFooter;
        private Panel PanelMainMenu;
        private Button BtnClientCard;
        private PictureBox pictureBox1;
        private Button BtnStormCourt;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}