using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement.FmLogin
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
                txbLogin.BackColor = Color.Red;
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
                txbPassword.BackColor = Color.Red;
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidationCorrected) 
            {
                Fmtoast.AddToQueue("ERROR", "Fromularz zawiera błędy", "Logowanie");
                return;
            }
            int? userRole = null;
            using DsLoginTableAdapters.QueriesTableAdapter dsLoginQueriesTableAdapter = new DsLoginTableAdapters.QueriesTableAdapter();
            dsLoginQueriesTableAdapter.userSelectRole(txbLogin.Text, txbPassword.Text, ref userRole);
            if (userRole == null
                || userRole == 0)
            {
                Fmtoast.AddToQueue("ERROR", "Błędny login lub hasło", "logowanie");
                return;
            }

            FmMain fmMain = new FmMain();
            fmMain.Show();
            this.Close();
            this.DialogResult = DialogResult.OK;

        }
    }
}
