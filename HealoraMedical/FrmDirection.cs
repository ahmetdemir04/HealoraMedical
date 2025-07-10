using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmDirection : Form
    {
        public FrmDirection()
        {
            InitializeComponent();
        }
        FrmDrLogin FdrLogin = new FrmDrLogin();
        FrmSecretaryLogin FcrLogin = new FrmSecretaryLogin();
        FrmPatientLogin FptLogin = new FrmPatientLogin();
        private void BtnDrLogin_Click(object sender, EventArgs e)
        {
            FdrLogin.Show();
            this.Hide();
        }

        private void BtnSecretaryLogin_Click(object sender, EventArgs e)
        {
            FcrLogin.Show();
            this.Hide();
        }

        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            FptLogin.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
