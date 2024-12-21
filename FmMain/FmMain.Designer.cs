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
            PanelMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(161, 450);
            PanelMenu.TabIndex = 0;
            // 
            // PanelFooter
            // 
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.Location = new Point(161, 412);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(639, 38);
            PanelFooter.TabIndex = 1;
            // 
            // PanelMainMenu
            // 
            PanelMainMenu.Controls.Add(BtnClientCard);
            PanelMainMenu.Dock = DockStyle.Fill;
            PanelMainMenu.Location = new Point(161, 0);
            PanelMainMenu.Name = "PanelMainMenu";
            PanelMainMenu.Size = new Size(639, 412);
            PanelMainMenu.TabIndex = 2;
            // 
            // BtnClientCard
            // 
            BtnClientCard.Location = new Point(74, 115);
            BtnClientCard.Name = "BtnClientCard";
            BtnClientCard.Size = new Size(100, 100);
            BtnClientCard.TabIndex = 0;
            BtnClientCard.Text = "Karta członkowska\r\n";
            BtnClientCard.UseVisualStyleBackColor = true;
            BtnClientCard.Click += BtnClientCard_Click;
            // 
            // FmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelMainMenu);
            Controls.Add(PanelFooter);
            Controls.Add(PanelMenu);
            Name = "FmMain";
            Text = "FmMain";
            PanelMainMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelFooter;
        private Panel PanelMainMenu;
        private Button BtnClientCard;
    }
}