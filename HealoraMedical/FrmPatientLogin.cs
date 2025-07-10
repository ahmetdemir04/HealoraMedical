using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace HealoraMedical
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent(); 
            txtTc.KeyPress += ClsInputHelper.OnlyNumeric;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        private void BtnLoıgin_Click(object sender, EventArgs e)
        {

            string tc = txtTc.Text.Trim();
            string sifre = TxtPassword.Text.Trim();

            bool girisBasarili = db.TblHastas.Any(X => X.TC == tc && X.sifre == sifre);


            if (girisBasarili)
            {
                FrmPatientMain FrmPatient = new FrmPatientMain();
                FrmPatient.TC = tc;
                FrmPatient.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC Kimlik No veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void ChcPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = ChcPasswordShow.Checked ? TxtPassword.PasswordChar = '\0' : TxtPassword.PasswordChar = '*';
        }
    }
}
