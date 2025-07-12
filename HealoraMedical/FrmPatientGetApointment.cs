using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmPatientGetApointment : Form
    {
        public FrmPatientGetApointment()
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


        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        public string TC ;
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
        private void FrmPatientGetApointment_Load(object sender, EventArgs e)
        {

            ListNotTakenAppotiment();
            ListDr();


            DtStart.Value = DateTime.Today;
            gridAppotiment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region  pnHeader
        int MouseX, MouseY;
        private void pHeader_MouseDown_1(object sender, MouseEventArgs e)
        {
            MouseX = MousePosition.X - this.Left;
            MouseY = MousePosition.Y - this.Top;


            timer1.Enabled = true;
        }

        private void pHeader_MouseUp_1(object sender, MouseEventArgs e)
        {
            timer1.Stop();

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
                      Poliklinik = clinic.PoliklinikNo,

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
        int? RandevuID;
        private void gridAppotiment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RandevuID = Convert.ToInt32(gridAppotiment.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }

        private void BtnGetApointment_Click(object sender, EventArgs e)
        {
            if (RandevuID != null)
            {
                var tApointment = db.TblRandevus.FirstOrDefault(x => x.RandevuId == RandevuID);

                if (tApointment != null)
                {
                    if (!string.IsNullOrEmpty(TxtSymptom.Text))
                    {
                        DialogResult result = MessageBox.Show($"{RandevuID} Numarasına sahip olan randevuyu almak istediğinize emin misiniz?", "HealOraMedical", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            tApointment.Durum = true;
                            tApointment.HastaTc = TC;

                            db.SaveChanges();

                            MessageBox.Show("Randevu oluşturuldu!", "HealOraMedical", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Randevu talebi iptal başarıyla iptal edildi.", "HealOraMedical", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        CmbDr.SelectedIndex = -1;
                        TxtSymptom.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Lütfen şikayet alanını doldurunuz!", "HealOraMedical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Randevu alınamadı. Lütfen tekrar deneyin.", "HealOraMedical", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan randevu seçiniz!", "HealOraMedical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - MouseX;
            this.Top = MousePosition.Y - MouseY;
        }

        #endregion
    }
}
