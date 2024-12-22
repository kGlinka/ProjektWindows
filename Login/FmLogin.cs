using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement.Login
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        private bool IsValidationCorrected { get; set; } = false;

        private void txbLogin_Leave(object sender, EventArgs e)
        {
            if (txbLogin.Text.Length <= 0)
            {
                txbLogin.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Nazwa użytkownika");
                IsValidationCorrected = false;
            }
            else
            {
                txbLogin.BackColor = Color.White;
                IsValidationCorrected = true;
            }
        }
        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text.Length <= 0)
            {
                txbPassword.BackColor = Color.PaleVioletRed;
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Nazwa użytkownika");
                IsValidationCorrected = false;
            }
            else
            {
                txbPassword.BackColor = Color.White;
                IsValidationCorrected = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FmRegistration fmRegistration = new FmRegistration();
            fmRegistration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidationCorrected) 
            {
                Fmtoast.AddToQueue("ERROR", "Fromularz zawiera błędy", "Logowanie");
                return;
            }
            int? userRole = null;
            int? userId = null;
            using DsLoginTableAdapters.QueriesTableAdapter dsLoginQueriesTableAdapter = new DsLoginTableAdapters.QueriesTableAdapter();
            dsLoginQueriesTableAdapter.userSelectIdAndRole(txbLogin.Text, txbPassword.Text, ref userRole, ref userId);
            if (userRole == null
                || userRole == 0)
            {
                Fmtoast.AddToQueue("ERROR", "Błędny login lub hasło", "logowanie");
                return;
            }

            GlobalVariables.SetUserRole(userRole.Value);
            GlobalVariables.SetUserId(userId.Value);
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
