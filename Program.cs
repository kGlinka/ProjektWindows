using CourtManagement;
using CourtManagement.Login;

namespace CourtManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicjalizowanie aplikacji Windows Forms
            ApplicationConfiguration.Initialize();

            // Uruchomienie formularza logowania
            FmLogin fmLogin = new FmLogin();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                // Jeœli wynik DialogResult to OK, uruchamiamy g³ówny formularz
                Application.Run(new FmMain());
            }
            else
            {
                // Jeœli wynik DialogResult nie jest OK, zamykamy aplikacjê
                Application.Exit();
            }
        }
    }
}