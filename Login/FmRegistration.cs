using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement.Login
{
    public partial class FmRegistration : Form
    {
        private bool IsValidationCorrect { get; set; } = false;
        public FmRegistration()
        {
            InitializeComponent();
        }

        private bool ValidateSpecialCharacters(String text, TextBox textBox)
        {
            // Sprawdzanie, czy nazwisko zawiera tylko litery (bez cyfr i znaków specjalnych)
            if (!Regex.IsMatch(text, "^[a-zA-ZąćęłńóśźżĄĘŁŃÓŚŹŻ]+$"))
            {
                textBox.BackColor = Color.PaleVioletRed;
                return false;
            }
            textBox.Text = CapitalizeFirstLetter(textBox.Text);
            textBox.BackColor = Color.White;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidationCorrect)
            {
                Fmtoast.AddToQueue("ERROR", "Fromularz zawiera błędy", "Rejestracja");
                return;
            }

            using DsLoginTableAdapters.QueriesTableAdapter dsLoginQueriesTableAdapter = new DsLoginTableAdapters.QueriesTableAdapter();
                dsLoginQueriesTableAdapter.user_clientInsert(
                    txbLogin.Text, txbPassword.Text, txbName.Text,
                    txbLastName.Text, txbCity.Text, txbStreet.Text,
                    txbZipCode.Text, int.Parse(txbPhoneNumber.Text), txbEmail.Text);

                this.Close();
                this.DialogResult = DialogResult.OK;
            
        }

        public string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        private void txbLogin_Leave(object sender, EventArgs e)
        {
            if (!ValidateLogin())
            {
                Fmtoast.AddToQueue("ERROR", "Musi zawierać więcej niż 6 znaków.", "Nazwa użytkownika");
            }
        }

        private bool ValidateLogin()
        {
            if (txbLogin.Text.Length < 6)
            {
                txbLogin.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                txbLogin.BackColor = Color.White;
                return true;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (!ValidatePassword())
            {
                Fmtoast.AddToQueue("ERROR", "Musi zawierać więcej niż 8 znaków.", "Hasło");
            }
        }

        private bool ValidatePassword()
        {
            if (txbPassword.Text.Length < 8)
            {
                txbPassword.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "Musi zawierać więcej niż 8 znaków.", "Hasło");
                return false;
            }
            else
            {
                txbPassword.BackColor = Color.White;
                return true;
            }
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            if (!ValidateName())
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
            }
            if (ValidateSpecialCharacters(txbName.Text, txbName) == false)
            {
                Fmtoast.AddToQueue("ERROR", "Nie może zawierać cyfr ani znaków specjalnych", "Imie");
            }
        }

        private bool ValidateName()
        {
            if (txbName.Text.Length <= 0)
            {
                txbName.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
                return false;
            }

            txbName.BackColor = Color.White;
            return true;
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            if (txbLastName.Text.Length <= 0)
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
            }
            if (ValidateSpecialCharacters(txbLastName.Text, txbLastName) == false)
            {
                Fmtoast.AddToQueue("ERROR", "Nie może zawierać cyfr ani znaków specjalnych", "Nazwisko");
            }
        }

        private void txbZipCode_Leave(object sender, EventArgs e)
        {
            if (!ValidateZipCode())
            {
                Fmtoast.AddToQueue("ERROR", "Błędny kod pocztowy", "Kod pocztowy");
            }
        }

        private bool ValidateZipCode()
        {
            if (Regex.IsMatch(txbZipCode.Text, "^[0-9]{2}-[0-9]{3}$") == false)
            {
                txbZipCode.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                txbZipCode.BackColor = Color.White;
                return true;
            }
        }

        private void txbCity_Leave(object sender, EventArgs e)
        {
            if (!ValidateCity())
            {
                Fmtoast.AddToQueue("ERROOR", "To pole jest wymagane", "Miasto");
            }
        }

        private bool ValidateCity()
        {
            if (txbCity.Text.Length <= 0)
            {
                txbCity.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                txbCity.Text = CapitalizeFirstLetter(txbCity.Text);
                txbCity.BackColor = Color.White;
                return true;
            }
        }

        private void txbStreet_Leave(object sender, EventArgs e)
        {
            if (!ValidateStreet())
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagen", "Ulica");
            }
        }

        private bool ValidateStreet()
        {
            if (txbStreet.Text.Length <= 0)
            {
                txbStreet.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                txbStreet.Text = CapitalizeFirstLetter(txbStreet.Text);
                txbStreet.BackColor = Color.White;
                return true;
            }
        }

        private void txbPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (!ValidatePhoneNumber())
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Numer telefonu");
            }
            if (IsValidPhoneNumber(txbPhoneNumber.Text, txbPhoneNumber) == false)
            {
                Fmtoast.AddToQueue("ERROR", "Nieprawidłowy numer telefonu", "Numer telefonu");

            }
        }

        private bool ValidatePhoneNumber()
        {
            if (txbPhoneNumber.Text.Length <= 0)
            {
                txbPhoneNumber.BackColor = Color.PaleVioletRed;
                return false;
            }
            txbPhoneNumber.BackColor = Color.White;
            return true;
        }
        public static bool IsValidPhoneNumber(string phoneNumber, TextBox textBox)
        {

            if(!(phoneNumber.Length == 9 && phoneNumber.All(char.IsDigit)))
            {
                textBox.BackColor = Color.PaleVioletRed;
                return false;
            }

            textBox.BackColor = Color.White;
            return true;
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidateEmail(txbEmail.Text))
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Email");
            }
            if(!ValidateEmail(txbEmail.Text, txbEmail))
            {
                Fmtoast.AddToQueue("ERROR", "Nieprawidłowy email", "Email");
            }
        }

        private bool ValidateEmail(string email)
        {
            if(email.Length <= 0)
            {
                txbEmail.BackColor = Color.PaleVioletRed;
                return false;
            }

            txbEmail.BackColor = Color.White;
            return true;
        }
        private bool ValidateEmail(string email, TextBox textBox)
        {
            // Wyrażenie regularne sprawdzające prawidłowość adresu email
            string emailPattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";
            if(!Regex.IsMatch(email, emailPattern))
            {
                textBox.BackColor = Color.PaleVioletRed;
                return false;
            }

            textBox.BackColor = Color.White;
            return true;
        }

        private void txbLastName_Leave(object sender, EventArgs e)
        {
            if (!ValidateLastName())
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane.", "Imie");
            }
            if (ValidateSpecialCharacters(txbLastName.Text, txbLastName) == false)
            {
                Fmtoast.AddToQueue("ERROR", "Nie może zawierać cyfr ani znaków specjalnych", "Nazwisko");
            }
            txbLastName.BackColor = Color.White;
        }

        private bool ValidateLastName()
        {
            if (txbLastName.Text.Length <= 0)
            {
                txbLastName.BackColor = Color.PaleVioletRed;
                return false;
            }

            txbLastName.BackColor = Color.White;
            return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
