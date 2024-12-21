using CourtManagement.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToastAlerts
{
    public partial class Fmtoast : Form
    {
        private int ToastX, ToastY;
        private float ScreenHeightFactor;
        private int PauseCounter = 0; // Licznik do zatrzymania w najwyższym punkcie
        private int ToastOffset; // Przechowuje pozycję tego powiadomienia w stosie

        public Fmtoast(string type, string message, string controlName, int toasOffset)
        {
            InitializeComponent();

            // Ustawienie TopMost, aby powiadomienia były zawsze na wierzchu
            this.TopMost = true;

            ControlName.Text = controlName;
            LbMessage.Text = message;
            ToastOffset = toasOffset;

            // Ustawienie odpowiednich stylów powiadomień
            switch (type)
            {
                case "SUCCESS":
                    toastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    picIcon.Image = Resources.icons8_ok_32; 
                    break;
                case "ERROR":
                    toastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    picIcon.Image = Resources.icons8_error_32;
                    break;
                case "INFO":
                    toastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    picIcon.Image = Resources.icons8_info_32;
                    break;
                case "WARNING":
                    picIcon.Image = Resources.icons8_cancel_32;
                    toastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    break;
            }
        }

        public static void AddToQueue(string type, string message, string controlName)
        {
            ToastQueueManager.AddToastToQueue(type, message, controlName);
        }
        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            // Przesuwaj wiadomość do góry w proporcji do wysokości ekranu
            ToastY -= (int)(ScreenHeightFactor * Screen.PrimaryScreen.WorkingArea.Height * 0.01f); // 1% wysokości ekranu
            this.Location = new Point(ToastX, ToastY);

            // Zatrzymaj animację w najwyższym punkcie na krótką chwilę
            if (ToastY <= Screen.PrimaryScreen.WorkingArea.Height - ToastOffset && PauseCounter == 0)
            {
                toastTimer.Stop();
                PauseCounter = 50; // Liczba ticków, przez które toast pozostaje w najwyższym punkcie
                var pauseTimer = new System.Windows.Forms.Timer
                {
                    Interval = 50 // Interwał w milisekundach (dostosuj według potrzeby)
                };
                pauseTimer.Tick += (s, args) =>
                {
                    PauseCounter--;
                    if (PauseCounter <= 0)
                    {
                        pauseTimer.Stop();
                        pauseTimer.Dispose();
                        toastHide.Start();
                    }
                };
                pauseTimer.Start();
            }
        }

        private void toastHide_Tick(object sender, EventArgs e)
        {
            ToastY += (int)(ScreenHeightFactor * Screen.PrimaryScreen.WorkingArea.Height * 0.01f); // 1% wysokości ekranu
            this.Location = new Point(ToastX, ToastY);

            // Zamknij formę, gdy opuści ekran
            if (ToastY > Screen.PrimaryScreen.WorkingArea.Height)
            {
                toastHide.Stop();
                ToastManager.ReleaseToastOffset(ToastOffset);
                this.Close();
            }
        }

        private void Position()
        {
            // Pobierz wymiary obszaru roboczego
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Oblicz współczynnik wysokości dla skalowania animacji
            ScreenHeightFactor = 1.0f; // Skala oparta na wysokości ekranu, proporcjonalna

            // Ustaw pozycję początkową w prawym dolnym rogu z marginesem nad paskiem zadań
            ToastX = screenWidth - this.Width - 10; // 10 px margines od prawej krawędzi
            ToastY = Math.Max(screenHeight - this.Height - ToastOffset - 10, 0); // 10 px margines od dolnej krawędzi

            // Ustaw pozycję formy
            this.Location = new Point(ToastX, ToastY);
        }

    }
}