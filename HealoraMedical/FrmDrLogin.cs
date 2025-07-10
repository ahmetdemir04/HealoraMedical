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
    public partial class FrmDrLogin : Form
    {
        public FrmDrLogin()
        {
            InitializeComponent();
            txtSicilNo.KeyPress += ClsInputHelper.OnlyNumeric;
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        private void BtnLoıgin_Click(object sender, EventArgs e)
        {
            string sicilno = txtSicilNo.Text;
            string password = TxtPassword.Text.Trim();

            bool girisbasarili = db.TblDoktors.Any(x => x.DrSicilNo == sicilno && x.DrSifre == password && x.Durum ==true );
            


            if (girisbasarili)
            {
                FrmDrMain FrmDrMain = new FrmDrMain();
                FrmDrMain.SicilNo = sicilno; 
                FrmDrMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Sicil No. veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void ChcPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = ChcPasswordShow.Checked ? TxtPassword.PasswordChar = '\0' : TxtPassword.PasswordChar = '*';
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
