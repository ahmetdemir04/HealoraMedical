using DevExpress.Utils;
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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();



            txtTc.KeyPress += ClsInputHelper.OnlyNumeric;
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        
        private void BtnLoıgin_Click(object sender, EventArgs e)
        {
            string tc  = txtTc.Text.Trim();
            string password = TxtPassword.Text.Trim();



            bool girisKontrol = db.TblSekreters.Any(s => s.SktTC == tc && s.SktSifre == password && s.Durum == true);



            if (girisKontrol)
            {
                FrmSecretaryMain fsctmn = new FrmSecretaryMain();
                fsctmn.skttc = tc; // Giriş yapan sekreterin TC'sini ana forma aktar
                fsctmn.Show();
                this.Hide(); // Giriş başarılıysa mevcut formu gizle
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChcPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = ChcPasswordShow.Checked ? TxtPassword.PasswordChar = '\0' : TxtPassword.PasswordChar = '*';
        }
    }
}
