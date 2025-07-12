using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmDrOperations : Form
    {
        public FrmDrOperations()
        {
            InitializeComponent();

            TxtName.KeyPress += ClsInputHelper.OnlyAlphabetic;
            TxtName.TextChanged += ClsInputHelper.OnlyText_TextChanged;

            TxtSurname.KeyPress += ClsInputHelper.OnlyAlphabetic;
            TxtSurname.TextChanged += ClsInputHelper.OnlyText_TextChanged;
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        private bool CheckAllFields()
        {
            if (!string.IsNullOrWhiteSpace(TxtSicilNo.Text) &&
                !string.IsNullOrWhiteSpace(TxtName.Text) &&
                !string.IsNullOrWhiteSpace(TxtSurname.Text) &&
                !string.IsNullOrWhiteSpace(TxtPassword.Text) &&
                CmbBranch.SelectedIndex != -1 &&
                CmbPolyclinic.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
               MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void ListAllDr(string which = "all")
        {
            object AllDrList;
            if (which == "all")
            {
                AllDrList = db.TblDoktors
           .Join(db.TblBrans,
           dr => dr.DrBrans,
           brans => brans.BransId,
           (dr, brans) => new { dr, brans })
           .Join(db.TblPolikliniks,
           combined => combined.dr.Poliklinik,
           clinic => clinic.PoliklinikNo,
           (combined, clinic) => new
           {
               SicilNO = combined.dr.DrSicilNo,
               Doktor = combined.dr.DrAd + " " + combined.dr.DrSoyad,
               Branş = combined.brans.BransAd,
               Şifre = combined.dr.DrSifre,
               Poliklinik = clinic.PoliklinikAd,
           }).ToList();
            }
            else
            {
                bool choose = string.Equals(which, "true", StringComparison.OrdinalIgnoreCase);

                AllDrList = db.TblDoktors.Where(x => x.Durum == choose)

         .Join(db.TblBrans,
         dr => dr.DrBrans,
         brans => brans.BransId,
         (dr, brans) => new { dr, brans })
         .Join(db.TblPolikliniks,
         combined => combined.dr.Poliklinik,
         clinic => clinic.PoliklinikNo,
         (combined, clinic) => new
         {
             SicilNO = combined.dr.DrSicilNo,
             Doktor = combined.dr.DrAd + " " + combined.dr.DrSoyad,
             Branş = combined.brans.BransAd,
             Şifre = combined.dr.DrSifre,
             Poliklinik = clinic.PoliklinikAd,
         }).ToList();
            }

            gridDr.DataSource = AllDrList;
        }
        private void ListAllPolyclinic()
        {
            var AllPolyclinic = db.TblPolikliniks.Select(x => new
            {
                x.PoliklinikNo,
                x.PoliklinikAd
            }).ToList();
            CmbPolyclinic.DataSource = AllPolyclinic;
            CmbPolyclinic.DisplayMember = "PoliklinikAd";
            CmbPolyclinic.ValueMember = "PoliklinikNo";

        }
        private void ListAllBranch()
        {
            var AllPolyclinic = db.TblBrans.Select(x => new
            {
                x.BransId,
                x.BransAd,
            }).ToList();
            CmbBranch.DataSource = AllPolyclinic;
            CmbBranch.DisplayMember = "BransAd";
            CmbBranch.ValueMember = "BransId";

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmDrAdd_Load(object sender, EventArgs e)
        {
            gridDr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ListAllDr(); ListAllBranch(); ListAllPolyclinic();
        }
        public event EventHandler DoctorAdded;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
          
                string SicilNO = TxtSicilNo.Text.Trim();


                if (db.TblDoktors.Any(x => x.DrSicilNo == SicilNO))
                {
                    MessageBox.Show("Bu sicil numarası zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TblDoktor tDr = new TblDoktor();

                    tDr.DrSicilNo = TxtSicilNo.Text.Trim();
                    tDr.DrAd = TxtName.Text.Trim();
                    tDr.DrSoyad = TxtSurname.Text.Trim();
                    tDr.DrSifre = TxtPassword.Text.Trim();
                    tDr.Poliklinik = Convert.ToByte(CmbPolyclinic.SelectedValue);
                    tDr.DrBrans = Convert.ToByte(CmbBranch.SelectedValue);
                    tDr.Durum = true;

                    db.TblDoktors.Add(tDr);
            
                    db.SaveChanges();
                    
                    DoctorAdded?.Invoke(this, EventArgs.Empty);


                    ListAllDr();
                    MessageBox.Show("Doktor başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSicilNo.Text.Trim()))
            {
                string SicilNO = TxtSicilNo.Text.Trim();

                var x = db.TblDoktors.Find(TxtSicilNo.Text);

                if (x != null)
                {
                    x.DrAd = TxtName.Text.Trim();
                    x.DrSoyad = TxtSurname.Text.Trim();
                    x.DrSifre = TxtPassword.Text.Trim();
                    x.Poliklinik = Convert.ToByte(CmbPolyclinic.SelectedValue);
                    x.DrBrans = Convert.ToByte(CmbBranch.SelectedValue);
                    

                    MessageBox.Show("Doktor bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();
                    ListAllDr(); 
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz doktoru seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz doktorun sicil numarasını girin veya seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            string SicilNO = TxtSicilNo.Text.Trim();

            var x = db.TblDoktors.Find(SicilNO.ToString());
            if (x != null)
            {
                x.Durum = false;
                db.SaveChanges();
                ListAllDr();
                MessageBox.Show("Doktor başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doktor bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Karakter textbox'a yazılmaz
            }
        }

        private void gridDr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string NameSurname = gridDr.CurrentRow.Cells["Doktor"].Value.ToString();
            string[] words = NameSurname.Split(' ');
            TxtName.Text = words[0]; // İlk kelime ad
            TxtSurname.Text = words[1];


            TxtSicilNo.Text = gridDr.CurrentRow.Cells["SicilNO"].Value.ToString();
            CmbBranch.Text = gridDr.CurrentRow.Cells["Branş"].Value.ToString();
            TxtPassword.Text = gridDr.CurrentRow.Cells["Şifre"].Value.ToString();
            CmbPolyclinic.Text = gridDr.CurrentRow.Cells["Poliklinik"].Value.ToString();
        }

        private void BtnDrList_Click(object sender, EventArgs e)
        {
            if (ChcAll.Checked)
            {
                ListAllDr();
            }
            else if (ChcActiveDr.Checked)
            {
                ListAllDr("true");
            }
            else if (ChcPassiveDr.Checked)
            {
                ListAllDr("false");
            }
        }
    }
}
