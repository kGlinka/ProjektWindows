
namespace ToastAlerts
{
    partial class Fmtoast
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
            components = new System.ComponentModel.Container();
            toastBorder = new Panel();
            ControlName = new Label();
            picIcon = new PictureBox();
            toastTimer = new System.Windows.Forms.Timer(components);
            toastHide = new System.Windows.Forms.Timer(components);
            LbMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // toastBorder
            // 
            toastBorder.BackColor = Color.FromArgb(57, 155, 53);
            toastBorder.Dock = DockStyle.Left;
            toastBorder.Location = new Point(0, 0);
            toastBorder.Name = "toastBorder";
            toastBorder.Size = new Size(10, 55);
            toastBorder.TabIndex = 0;
            // 
            // ControlName
            // 
            ControlName.AutoSize = true;
            ControlName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ControlName.Location = new Point(52, 6);
            ControlName.Name = "ControlName";
            ControlName.Size = new Size(42, 20);
            ControlName.TabIndex = 2;
            ControlName.Text = "Type";
            // 
            // picIcon
            // 
            picIcon.Image = CourtManagement.Properties.Resources.icons8_ok_32;
            picIcon.Location = new Point(16, 16);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(20, 20);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 1;
            picIcon.TabStop = false;
            // 
            // toastTimer
            // 
            toastTimer.Enabled = true;
            toastTimer.Interval = 10;
            toastTimer.Tick += toastTimer_Tick;
            // 
            // toastHide
            // 
            toastHide.Interval = 10;
            toastHide.Tick += toastHide_Tick;
            // 
            // LbMessage
            // 
            LbMessage.AutoSize = true;
            LbMessage.Location = new Point(52, 27);
            LbMessage.Name = "LbMessage";
            LbMessage.Size = new Size(106, 20);
            LbMessage.TabIndex = 3;
            LbMessage.Text = "Toast Message";
            // 
            // Fmtoast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 55);
            Controls.Add(LbMessage);
            Controls.Add(ControlName);
            Controls.Add(picIcon);
            Controls.Add(toastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fmtoast";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel toastBorder;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label ControlName;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
        private Label LbMessage;
    }
}