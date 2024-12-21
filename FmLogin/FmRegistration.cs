using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement.FmLogin
{
    public partial class FmRegistration : Form
    {
        private bool IsValidationCorrect { get; set; } = false;
        public FmRegistration()
        {
            InitializeComponent();
        }

        private bool ValidateSpecialCharacters(String text)
        {
            // Sprawdzanie, czy nazwisko zawiera tylko litery (bez cyfr i znaków specjalnych)
            if (!Regex.IsMatch(text, "^[a-zA-ZąćęłńóśźżĄĘŁŃÓŚŹŻ]+$"))
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using DsLoginTableAdapters.QueriesTableAdapter dsLoginQueriesTableAdapter = new DsLoginTableAdapters.QueriesTableAdapter();
            dsLoginQueriesTableAdapter.user_clientInsert(
                txbLogin.Text, txbPassword.Text, txbName.Text, 
                txbLastName.Text, txbCity.Text, txbStreet.Text, 
                txbZipCode.Text, int.Parse(txbPhoneNumber.Text), txbEmail.Text);

            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        public bool ValidateZipCode(String zipCode)
        {
            // Sprawdzanie, czy kod pocztowy jest w formacie XX-XXX
            return Regex.IsMatch(zipCode, "^[0-9]{2}-[0-9]{3}$");
        }

        public string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Sprawdzenie, czy numer ma dokładnie 9 znaków i składa się tylko z cyfr
            return phoneNumber.Length == 9 && phoneNumber.All(char.IsDigit);
        }

        public static bool ValidateEmail(string email)
        {
            // Wyrażenie regularne sprawdzające prawidłowość adresu email
            string emailPattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void txbLogin_Leave(object sender, EventArgs e)
        {
            if (txbLogin.Text.Length < 6)
            {
                txbLogin.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "Musi zawierać więcej niż 6 znaków.", "Nazwa użytkownika");
                IsValidationCorrect = false;
            }
            else
            {
                txbLogin.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text.Length < 8)
            {
                txbPassword.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "Musi zawierać więcej niż 8 znaków.", "Hasło");
                IsValidationCorrect = false;
            }
            else
            {
                txbPassword.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            if (txbName.Text.Length <= 0)
            {
                txbName.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
                IsValidationCorrect = false;
            }
            else
            {
                if (ValidateSpecialCharacters(txbName.Text) == false)
                {
                    txbName.BackColor = Color.PaleVioletRed;
                    Fmtoast.AddToQueue("ERROR", "Nie może zawierać cyfr ani znaków specjalnych", "Imie");
                    IsValidationCorrect = false;
                    return;
                }

                txbName.Text = CapitalizeFirstLetter(txbName.Text);
                txbName.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            if (txbLastName.Text.Length <= 0)
            {
                txbLastName.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
                IsValidationCorrect = false;
            }
            else
            {
                if (ValidateSpecialCharacters(txbLastName.Text) == false)
                {
                    txbLastName.BackColor = Color.PaleVioletRed;
                    Fmtoast.AddToQueue("ERROR", "Nie może zawierać cyfr ani znaków specjalnych", "Nazwisko");
                    IsValidationCorrect = false;
                    return;
                }
                txbLastName.Text = CapitalizeFirstLetter(txbLastName.Text);
                txbLastName.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbZipCode_Leave(object sender, EventArgs e)
        {
            if (ValidateZipCode(txbZipCode.Text) == false)
            {
                txbZipCode.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "Błędny kod pocztowy", "Kod pocztowy");
                IsValidationCorrect = false;
            }
            else
            {
                txbZipCode.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbCity_Leave(object sender, EventArgs e)
        {
            if (txbCity.Text.Length <= 0)
            {
                txbCity.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROOR", "To pole jest wymagane", "Miasto");
                IsValidationCorrect = false;
            }
            else
            {
                txbCity.Text = CapitalizeFirstLetter(txbCity.Text);
                txbCity.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbStreet_Leave(object sender, EventArgs e)
        {
            if (txbStreet.Text.Length <= 0)
            {
                txbStreet.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagen", "Ulica");
                IsValidationCorrect = false;
            }
            else
            {
                txbStreet.Text = CapitalizeFirstLetter(txbStreet.Text);
                txbStreet.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txbPhoneNumber.Text.Length <= 0)
            {
                txbPhoneNumber.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Numer telefonu");
                IsValidationCorrect = false;
            }
            else
            {
                if (IsValidPhoneNumber(txbPhoneNumber.Text) == false)
                {
                    txbPhoneNumber.BackColor = Color.PaleVioletRed;
                    Fmtoast.AddToQueue("ERROR", "Nieprawidłowy numer telefonu", "Numer telefonu");

                }
                txbPhoneNumber.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text.Length <= 0)
            {
                txbEmail.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Email");
                IsValidationCorrect = false;

            }
            else
            {
                if (ValidateEmail(txbEmail.Text) == false)
                {
                    txbEmail.BackColor = Color.PaleVioletRed;
                    Fmtoast.AddToQueue("ERROR", "Nieprawidłowy email", "Email");
                    IsValidationCorrect = false;
                    return;
                }
                txbEmail.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void txbLastName_Leave(object sender, EventArgs e)
        {
            if (txbLastName.Text.Length <= 0)
            {
                txbLastName.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
                IsValidationCorrect = false;
            }
            else
            {
                if (ValidateSpecialCharacters(txbLastName.Text) == false)
                {
                    txbLastName.BackColor = Color.PaleVioletRed;
                    Fmtoast.AddToQueue("ERROR", "Nie może zawierać cyfr ani znaków specjalnych", "Nazwisko");
                    IsValidationCorrect = false;
                    return;
                }
                txbLastName.Text = CapitalizeFirstLetter(txbLastName.Text);
                txbLastName.BackColor = Color.White;
                IsValidationCorrect = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
