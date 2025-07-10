using DevExpress.XtraBars.Painters;
using DevExpress.XtraLayout.Painting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmPatientMain : Form
    {
        public FrmPatientMain()
        {
            InitializeComponent();
        }

        public string TC;
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        private void ListPersonalInformation()
        {
            var QueryGender = db.TblHastas.Where(x => x.TC == TC).Select(x => new { x.cinsiyet }).FirstOrDefault();
           
            var QueryPrsInfo = db.TblHastaDetayı.Where(x => x.HastaTC == TC).Select(x => new
            {
                x.Yas,
                x.Boy,
                x.Kg,
                x.KanGrubu,
                
            }
            ).FirstOrDefault();

            LblAge.Text = QueryPrsInfo.Yas.ToString();
            LblSize.Text = QueryPrsInfo.Boy + " cm";
            LblWeight.Text = QueryPrsInfo.Kg + " kg";
            LblBloodType.Text = QueryPrsInfo.KanGrubu.ToString();
            LblGender.Text = QueryGender.cinsiyet;
        }

        private void BringPersonalInfo()
        {
            var QueryNameSurname = db.TblHastas.Where(x => x.TC == TC).Select(x => new
            {
                FullName = x.Ad + " " + x.Soyad,
                Telefon = x.Telefon,
                Email = x.Email,
                Adres = x.Adres
            }).FirstOrDefault();
            LblNameSurname.Text = QueryNameSurname.FullName;
            TxtPhone.Text = QueryNameSurname.Telefon;
            TxtMail.Text = QueryNameSurname.Email;
            TxtAddress.Text = QueryNameSurname.Adres;
        }

        private void BringAllApointments()
        {
            var appointment_query = db.TblRandevus.Where(x => x.TblHasta.TC == TC && x.Durum == true).Select(x =>
            new
            {
                RandevuID = x.RandevuId,
                TC = x.TblHasta.TC,
                Ad_Soyad = x.TblHasta.Ad + " " + x.TblHasta.Soyad,
                Tarih = x.RandevuTarihi,
                Saat = x.RandevuSaati,
            }).OrderBy(x => x.Tarih).OrderBy(x => x.Saat).ToList();
            gridPatient.DataSource = appointment_query;
        }

        private void BringPastApointments()
        {
            var appointment_query = db.TblRandevus.Where(x => x.TblHasta.TC == TC && x.Durum == true && x.RandevuTarihi < DateTime.Today && x.Geldimi == null).Select(x =>
        new
        {
            RandevuID = x.RandevuId,
            TC = x.TblHasta.TC,
            Ad_Soyad = x.TblHasta.Ad + " " + x.TblHasta.Soyad,
            Tarih = x.RandevuTarihi,
            Saat = x.RandevuSaati,
        }).OrderBy(x => x.Tarih).OrderBy(x => x.Saat).ToList();
            gridPatient.DataSource = appointment_query;
        }
        private void BringFutureApointments()
        {
            var appointment_query = db.TblRandevus.Where(x => x.TblHasta.TC == TC && x.Durum == true && x.RandevuTarihi >= DateTime.Today && x.Geldimi == null).Select(x =>
        new
        {
            RandevuID = x.RandevuId,
            TC = x.TblHasta.TC,
            Ad_Soyad = x.TblHasta.Ad + " " + x.TblHasta.Soyad,
            Tarih = x.RandevuTarihi,
            Saat = x.RandevuSaati,
        }).OrderBy(x => x.Tarih).OrderBy(x => x.Saat).ToList();
            gridPatient.DataSource = appointment_query;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RdAllApoint.Checked)
            {
                BringAllApointments();
            }
            else if (RdFutureApoint.Checked)
            {
                BringFutureApointments();
            }
            else if (RdPastApoint.Checked)
            {
                BringPastApointments();
            }
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            ListPersonalInformation();
            BringPersonalInfo();
            BringFutureApointments(); 
            gridPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void gridPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RandevuID = Convert.ToInt32(gridPatient.Rows[e.RowIndex].Cells["RandevuID"].Value.ToString());

            FrmPatientMedicine frmPatientMedicine = new FrmPatientMedicine();
            frmPatientMedicine.randevuID = RandevuID;
            frmPatientMedicine.ShowDialog();
        }
        private void BtnGetApointment_Click(object sender, EventArgs e)
        {
            FrmPatientGetApointment FrmPtGetApoint = new FrmPatientGetApointment();
            FrmPtGetApoint.TC = TC;
            FrmPtGetApoint.ShowDialog();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region  pnHeader
        int MouseX, MouseY;
        private void pHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = MousePosition.X - this.Left;
            MouseY = MousePosition.Y - this.Top;


            timer1.Enabled = true;
        }

        private void pHeader_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void BtnChronicDiseases_Click(object sender, EventArgs e)
        {
            FrmChronicDiseases FrmChrcDs = new FrmChronicDiseases();
            FrmChrcDs.TC = TC;
            FrmChrcDs.ShowDialog();
        }

        private bool CheckAllFields()
        {
            if (!string.IsNullOrWhiteSpace(TxtPhone.Text) || !string.IsNullOrWhiteSpace(TxtMail.Text) || !string.IsNullOrWhiteSpace(TxtAddress.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void BtnUpdatePtInfo_Click(object sender, EventArgs e)
        {
            var tPatient = db.TblHastas.Where(x => x.TC == TC).FirstOrDefault();

       
            if (CheckAllFields())
            {

                DialogResult result = MessageBox.Show( $"{tPatient.Ad +  " " +  tPatient.Soyad} ait hasta bilgilerini güncellemek istediğinize emin misiniz?", "Healora Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    if (TC != null)
                    {
                        tPatient.Telefon = TxtPhone.Text.Trim();
                        tPatient.Email = TxtMail.Text.Trim();
                        tPatient.Adres = TxtAddress.Text.Trim();


                        db.SaveChanges();
                        BringPersonalInfo();
                        MessageBox.Show("Hasta bilgileri başarıyla güncellendi.", "Healora Medical", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("TC kimlik numarası bulunamadı!", "Healora Medical", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }





            }
            else
            {
                MessageBox.Show("Lütfen en az bir alanı doldurun!", "Healora Medical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - MouseX;
            this.Top = MousePosition.Y - MouseY;
        }
        #endregion
    }
}
