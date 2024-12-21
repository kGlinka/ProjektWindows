using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastAlerts;

namespace CourtManagement.FmLogin
{
    public partial class FmRegistration : Form
    {
        public FmRegistration()
        {
            InitializeComponent();
        }

        private void ValidateData()
        {
            if (txbLogin.Text.Length < 6)
            {
                txbLogin.BackColor = Color.Red;
                //Fmtoast.AddToQueue("ERROR", "Nazwa użytkownika musi zawierać więcej niż 6 znaków.");
            }
            else
            {
                txbLogin.BackColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           using DsLoginTableAdapters.QueriesTableAdapter dsLoginQueriesTableAdapter = new DsLoginTableAdapters.QueriesTableAdapter();
            Fmtoast.AddToQueue("WARNING", "Musi mieć więcej niż 6 znaków", "Nazwa użytkownika");
            //dsLoginQueriesTableAdapter.user_clientInsert()

        }
    }
}
