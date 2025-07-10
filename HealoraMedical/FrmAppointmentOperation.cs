using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HealoraMedical
{
    public partial class FrmAppointmentOperation : Form
    {
        public FrmAppointmentOperation()
        {
            InitializeComponent();



            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

            DtApointDate.Format = DateTimePickerFormat.Custom;
            DtApointDate.CustomFormat = "dd.MM.yyyy";
        }

        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        private void ListAllAppointment()
        {
            var AllAppointment = db.TblRandevus
                .Join(db.TblDoktors,
                randevu => randevu.DrSicilNo,
                doktor => doktor.DrSicilNo,
                (randevu, doktor) => new { randevu, doktor })
                .Join(db.TblPolikliniks,
                combined => combined.randevu.PoliklinikNo,
                poliklinik => poliklinik.PoliklinikNo,
                (combined, poliklinik) => new
                {
                    ID = combined.randevu.RandevuId,
                    Poliklinik = poliklinik.PoliklinikAd,
                    DoktorSicilNo = combined.doktor.DrSicilNo,
                    Doktor = combined.doktor.DrAd + " " + combined.doktor.DrSoyad,
                    Tarih = combined.randevu.RandevuTarihi,
                    Saat = combined.randevu.RandevuSaati,

                }).ToList();


            gridAppointment.DataSource = AllAppointment;
        }



        private void FrmAppointmentOperation_Load(object sender, EventArgs e)
        {
            gridAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ListAllAppointment();


            dtApointHours.Format = DateTimePickerFormat.Custom;
            dtApointHours.CustomFormat = "HH:mm";
            dtApointHours.ShowUpDown = true;


            var Poliklinik = db.TblPolikliniks.Select(x => new
            {
                x.PoliklinikNo,
                x.PoliklinikAd
            }).ToList();

            CmbPolyclinic.DataSource = Poliklinik;
            CmbPolyclinic.DisplayMember = "PoliklinikAd";
            CmbPolyclinic.ValueMember = "PoliklinikNo";


            var Dr = db.TblDoktors.Select(x => new
            {
                x.DrSicilNo,
                AdSoyad = x.DrAd + " " + x.DrSoyad
            }).ToList();

            CmbSicilNo.DataSource = Dr;
            CmbSicilNo.DisplayMember = "AdSoyad";
            CmbSicilNo.ValueMember = "DrSicilNo";

        }

        private void BtnList_Click(object sender, EventArgs e)
        {

            if (ChAllApo.Checked)
            {
                ListAllAppointment();
            }
            else if (ChTodayApo.Checked)
            {

                var today = DateTime.Today;


                var AllAppointment = db.TblRandevus
              .Join(db.TblDoktors,
              randevu => randevu.DrSicilNo,
              doktor => doktor.DrSicilNo,
              (randevu, doktor) => new { randevu, doktor })
              .Join(db.TblPolikliniks,
              combined => combined.randevu.PoliklinikNo,
              poliklinik => poliklinik.PoliklinikNo,
              (combined, poliklinik) => new
              {
                  ID = combined.randevu.RandevuId,
                  PoliklinikId = combined.randevu.PoliklinikNo,
                  Poliklinik = poliklinik.PoliklinikAd,
                  DoktorSicilNo = combined.doktor.DrSicilNo,
                  Doktor = combined.doktor.DrAd + " " + combined.doktor.DrSoyad,
                  Tarih = combined.randevu.RandevuTarihi,
                  Saat = combined.randevu.RandevuSaati,

              }).Where(x => DbFunctions.TruncateTime(x.Tarih) == today).ToList();


                gridAppointment.DataSource = AllAppointment;
            }
            else if (ChWeekApo.Checked)
            {
                var Start = DateTime.Today.AddDays(1); // tomorrow 

                DateTime End = Start.AddDays(7);

                var AllAppointment = db.TblRandevus
   .Join(db.TblDoktors,
   randevu => randevu.DrSicilNo,
   doktor => doktor.DrSicilNo,
   (randevu, doktor) => new { randevu, doktor })
   .Join(db.TblPolikliniks,
   combined => combined.randevu.PoliklinikNo,
   poliklinik => poliklinik.PoliklinikNo,
   (combined, poliklinik) => new
   {
       ID = combined.randevu.RandevuId,
       PoliklinikId = combined.randevu.PoliklinikNo,
       Poliklinik = poliklinik.PoliklinikAd,
       DoktorSicilNo = combined.doktor.DrSicilNo,
       Doktor = combined.doktor.DrAd + " " + combined.doktor.DrSoyad,
       Tarih = combined.randevu.RandevuTarihi,
       Saat = combined.randevu.RandevuSaati,

   }).Where(x => DbFunctions.TruncateTime(x.Tarih) >= Start && DbFunctions.TruncateTime(x.Tarih) <= End).ToList();


                gridAppointment.DataSource = AllAppointment;

            }
            else if (ChMonthApo.Checked)
            {
                var Start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // Start of the month
                var End = Start.AddMonths(1).AddDays(-1); // End of the month


                var AllAppointment = db.TblRandevus
 .Join(db.TblDoktors,
 randevu => randevu.DrSicilNo,
 doktor => doktor.DrSicilNo,
 (randevu, doktor) => new { randevu, doktor })
 .Join(db.TblPolikliniks,
 combined => combined.randevu.PoliklinikNo,
 poliklinik => poliklinik.PoliklinikNo,
 (combined, poliklinik) => new
 {
     ID = combined.randevu.RandevuId,
     PoliklinikId = combined.randevu.PoliklinikNo,
     Poliklinik = poliklinik.PoliklinikAd,
     DoktorSicilNo = combined.doktor.DrSicilNo,
     Doktor = combined.doktor.DrAd + " " + combined.doktor.DrSoyad,
     Tarih = combined.randevu.RandevuTarihi,
     Saat = combined.randevu.RandevuSaati,

 }).Where(x => DbFunctions.TruncateTime(x.Tarih) >= Start && DbFunctions.TruncateTime(x.Tarih) <= End).ToList();


                gridAppointment.DataSource = AllAppointment;
            }

            else if (ChYearApo.Checked)
            {
                var Start = new DateTime(DateTime.Today.Year, 1, 1); // Start of the year
                var End = new DateTime(DateTime.Today.Year, 12, 31); // End of the year


                var AllAppointment = db.TblRandevus
   .Join(db.TblDoktors,
   randevu => randevu.DrSicilNo,
   doktor => doktor.DrSicilNo,
   (randevu, doktor) => new { randevu, doktor })
   .Join(db.TblPolikliniks,
   combined => combined.randevu.PoliklinikNo,
   poliklinik => poliklinik.PoliklinikNo,
   (combined, poliklinik) => new
   {
       ID = combined.randevu.RandevuId,
       PoliklinikId = combined.randevu.PoliklinikNo,
       Poliklinik = poliklinik.PoliklinikAd,
       DoktorSicilNo = combined.doktor.DrSicilNo,
       Doktor = combined.doktor.DrAd + " " + combined.doktor.DrSoyad,
       Tarih = combined.randevu.RandevuTarihi,
       Saat = combined.randevu.RandevuSaati,

   }).Where(x => DbFunctions.TruncateTime(x.Tarih) >= Start && DbFunctions.TruncateTime(x.Tarih) <= End).ToList();


                gridAppointment.DataSource = AllAppointment;

            }
        }


     
        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            string SicilNO = CmbSicilNo.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(SicilNO))
            {
                TblRandevu tRandevu = new TblRandevu();

                DateTime date, hours;
                date = DtApointDate.Value;
                hours = dtApointHours.Value;

                if (db.TblRandevus.Any(x => x.RandevuTarihi == date && x.RandevuSaati == hours.TimeOfDay && x.DrSicilNo == SicilNO))
                {
                    MessageBox.Show("Bu tarihte ve saatte bu doktora ait bir randevu zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tRandevu.DrSicilNo = SicilNO;
                    tRandevu.PoliklinikNo = Convert.ToInt16(CmbPolyclinic.SelectedValue);
                    tRandevu.RandevuTarihi = date;
                    tRandevu.RandevuSaati = hours.TimeOfDay;



                    db.TblRandevus.Add(tRandevu);

                    if (db.TblRandevus.Any(x => DbFunctions.TruncateTime(x.RandevuTarihi) == DtApointDate.Value &&
                    x.RandevuSaati == dtApointHours.Value.TimeOfDay))
                    {
                        MessageBox.Show("Bu tarihte ve saatte bir randevu zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Randevu Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListAllAppointment();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Randevu eklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir doktor seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        
        }

        private void BtnUpdateAppointment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtApointId.Text);

            var BringID = db.TblRandevus.Find(id);

            BringID.DrSicilNo = CmbSicilNo.SelectedValue.ToString();
            BringID.PoliklinikNo = Convert.ToInt16(CmbPolyclinic.SelectedValue);
            BringID.RandevuTarihi = DtApointDate.Value;
            BringID.RandevuSaati = dtApointHours.Value.TimeOfDay;

            try
            {
                db.SaveChanges();
                MessageBox.Show("Randevu güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListAllAppointment();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu güncellenemedi: \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtApointId.Text = gridAppointment.CurrentRow.Cells["ID"].Value.ToString();
            CmbPolyclinic.SelectedValue = gridAppointment.CurrentRow.Cells["PoliklinikId"].Value;
            CmbSicilNo.SelectedValue = gridAppointment.CurrentRow.Cells["DoktorSicilNo"].Value;
            DtApointDate.Value = Convert.ToDateTime(gridAppointment.CurrentRow.Cells["Tarih"].Value);
            TimeSpan hours = (TimeSpan)gridAppointment.CurrentRow.Cells["Saat"].Value;
            dtApointHours.Value = DateTime.Today.Add(hours);

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
