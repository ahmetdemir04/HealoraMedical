using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmSecretaryMain : Form
    {
        public FrmSecretaryMain()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");


            // DateTimePicker formatını özelleştir
            DtStart.Format = DateTimePickerFormat.Custom;
            DtStart.CustomFormat = "dd.MM.yyyy HH:mm"; // Örnek: 24.06.2024 14:30
            DtEnd.Format = DateTimePickerFormat.Custom;
            DtEnd.CustomFormat = "dd.MM.yyyy HH:mm"; // Örnek: 24.06.2024 14:30
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();

        public string skttc;

        private void BringSecretaryName()
        {
            var secreter = db.TblSekreters.Where(x => x.SktTC == skttc).Select(x => new
            {
                x.SktAd,
                x.SktSoyad
            }
            ).FirstOrDefault();

            LblSecreterNS.Text = secreter.SktAd + " " + secreter.SktSoyad;
        }
        private void ListNotTakenAppotiment()
        {
            var notTakenAppotiment = (from t1 in db.TblRandevus
                                      join t2 in db.TblDoktors on t1.DrSicilNo equals t2.DrSicilNo
                                      join t3 in db.TblPolikliniks on t1.PoliklinikNo equals t3.PoliklinikNo
                                      where t1.Durum == false
                                      select new
                                      {
                                          ID = t1.RandevuId,
                                          Doktor = t2.DrAd + " " + t2.DrSoyad,
                                          Poliklinik = t3.PoliklinikAd,
                                          Tarih = t1.RandevuTarihi,
                                          Saat = t1.RandevuSaati,
                                      }).ToList();

            gridAppotiment.DataSource = notTakenAppotiment;
        }

        private void ListDr()
        {
            var ListDr = db.TblDoktors.Where(x => x.Durum == true).Select(x => new
            {
                DrSicilNo = x.DrSicilNo,
                Doktor = x.DrAd + " " + x.DrSoyad,
               
            }).ToList();
            CmbDr.DataSource = ListDr;
            CmbDr.ValueMember = "DrSicilNo";
            CmbDr.DisplayMember = "Doktor";
        }
              
          
       
        private void FrmSecretaryMain_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("tr-TR");

            // Ana thread'e kültür atanır
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            BringSecretaryName();
            ListNotTakenAppotiment();
            ListDr();

            CmbDr.SelectedIndex = -1;
            gridAppotiment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

     

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text;


            if (tc.Length == 11)
            {
                if (db.TblHastas.Any(x => x.TC == tc))
                {

                    var sorgula = db.TblHastas.Where(x => x.TC == txtTc.Text).Select(x => new
                    {
                        x.TC,
                        x.Ad,
                        x.Soyad,
                        x.Telefon,
                        x.Email,
                        x.SGK
                    }).FirstOrDefault();



                    txtTc.Text = sorgula.TC;
                    TxtName.Text = sorgula.Ad;
                    TxtSurname.Text = sorgula.Soyad;
                    TxtPhoneNumber.Text = sorgula.Telefon;
                    TxtEmail.Text = sorgula.Email;

                    bool SGK = sorgula.SGK;

                    if (SGK == true)
                    {
                        TxtSgk.Text = "Var";
                    }
                    else
                    {
                        TxtSgk.Text = "Yok";
                    }


                }

                else
                {
                    MessageBox.Show("Sistemde bu TC Kimlik Numarasına Ait Hasta Bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Eksik ya da Hatalı TC Kimlik Numarası Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void BtnFilitrele_Click(object sender, EventArgs e)
        {
            DateTime startDate = DtStart.Value;
            DateTime endDate = DtEnd.Value;


           if (CmbDr.SelectedValue == null)
            {
                var filteredAppointments = db.TblRandevus
              .Where(x => x.RandevuTarihi >= startDate && x.RandevuTarihi <= endDate && x.Durum == false)
              .Join(db.TblDoktors,
                  appointment => appointment.DrSicilNo,
                  doctor => doctor.DrSicilNo,
                  (appointment, doctor) => new { appointment, doctor })
              .Join(db.TblPolikliniks,
                  combined => combined.appointment.PoliklinikNo,
                  clinic => clinic.PoliklinikNo,
                  (combined, clinic) => new
                  {

                      ID = combined.appointment.RandevuId,
                      Doktor = combined.doctor.DrAd + combined.doctor.DrSoyad,
                      Poliklinik = clinic.PoliklinikAd,

                      Tarih = combined.appointment.RandevuTarihi,
                      Saat = combined.appointment.RandevuSaati


                  })
              .ToList();

                gridAppotiment.DataSource = filteredAppointments;
            }
            else if (CmbDr.SelectedValue != null)
            {

            var filteredAppointments = db.TblRandevus
                .Where(x => x.RandevuTarihi >= startDate && x.RandevuTarihi <= endDate && x.Durum == false && x.DrSicilNo == CmbDr.SelectedValue.ToString())
                .Join(db.TblDoktors,
                    appointment => appointment.DrSicilNo,
                    doctor => doctor.DrSicilNo,
                    (appointment, doctor) => new { appointment, doctor })
                .Join(db.TblPolikliniks,
                    combined => combined.appointment.PoliklinikNo,
                    clinic => clinic.PoliklinikNo,
                    (combined, clinic) => new
                    {
                       
                        ID = combined.appointment.RandevuId,
                        Doktor = combined.doctor.DrAd + combined.doctor.DrSoyad,
                        Poliklinik = clinic.PoliklinikNo,

                        Tarih = combined.appointment.RandevuTarihi,
                        Saat = combined.appointment.RandevuSaati


                    })
                .ToList();

            gridAppotiment.DataSource = filteredAppointments;
            }
            else
            {
                MessageBox.Show("Lütfen filitrelemek için filitleme koşullarını seçiniz!", "HealOraMedical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int? appoitmentID;
        bool CheckAllFields() 
        {
            if (string.IsNullOrWhiteSpace(txtTc.Text) ||
                string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtSurname.Text) ||
                string.IsNullOrWhiteSpace(TxtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtSgk.Text) ||
                string.IsNullOrWhiteSpace(TxtSikayet.Text) ||
                appoitmentID != null )
                
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BtnMakeAnAppointment_Click(object sender, EventArgs e)
        {
            appoitmentID = Convert.ToInt32(gridAppotiment.CurrentRow.Cells["ID"].Value);

            if (appoitmentID != null ) 
            {
                var rnd = db.TblRandevus.Find(appoitmentID);

                rnd.Durum = true;
                rnd.HastaTc = txtTc.Text.Trim();
                rnd.HastaSikayet = TxtSikayet.Text.Trim();


                db.SaveChanges();
                MessageBox.Show("Randevu sisteme alındı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListNotTakenAppotiment();

            }

        }

        private void BtnAncCreate_Click(object sender, EventArgs e)
        {
            string caption = TxtAncCaption.Text.Trim();
            string context = TxtAncContext.Text.Trim();


            if (!string.IsNullOrEmpty(caption) && !string.IsNullOrEmpty(context))
            {
                TblDuyuru tDuyuru = new TblDuyuru();

                tDuyuru.DyrBaslik = caption;
                tDuyuru.DyrIcerik = context;
                tDuyuru.DyrTarih = DateTime.Now;

                db.TblDuyurus.Add(tDuyuru);
                db.SaveChanges();
                MessageBox.Show("Duyuru başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen duyuru başlığı ve içeriğini doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TxtAncCaption.Clear();
            TxtAncContext.Clear();
        }


        #region AllOtherFormDirection
        private void BtnAnnouncementOperations_Click(object sender, EventArgs e)
        {
            FrmAnnouncement FrmAnc = new FrmAnnouncement();
            FrmAnc.ShowDialog();
        }

        private void BtnAppointmentOperations_Click(object sender, EventArgs e)
        {
            FrmAppointmentOperation FrmAppOrg = new FrmAppointmentOperation();
            FrmAppOrg.ShowDialog();
        }
        private void FrmActiveAppo_Click(object sender, EventArgs e)
        {
            FrmActiveAppointment frm = new FrmActiveAppointment();
            frm.ShowDialog();
        }
        private void BtnPatientOperations_Click(object sender, EventArgs e)
        {
            FrmPatientOperations frmPtnOp = new FrmPatientOperations();
            frmPtnOp.ShowDialog();
        }
        private void BtnDrOperations_Click(object sender, EventArgs e)
        {
            FrmDrOperations frmDrAdd = new FrmDrOperations();
            frmDrAdd.ShowDialog();
        }
        #endregion

        #region pnHeader
        int MouseX, MouseY;


        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = MousePosition.X - this.Left;
            MouseY = MousePosition.Y - this.Top;


            timer1.Enabled = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - MouseX;
            this.Top = MousePosition.Y - MouseY;
        }
      
        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
        #endregion
        private void gridAppotiment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSorgula.PerformClick();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
