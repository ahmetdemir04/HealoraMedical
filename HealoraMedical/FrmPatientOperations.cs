using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmPatientOperations : Form
    {
        public FrmPatientOperations()
        {
            InitializeComponent();


            // DateTimePicker formatını özelleştir
            DtBirthday.Format = DateTimePickerFormat.Custom;
            DtBirthday.CustomFormat = "dd.MM.yyyy"; // 



            TxtSize.KeyPress += ClsInputHelper.OnlyNumeric;
            TxtSize.TextChanged += ClsInputHelper.OnlyNumeric_TextChanged;


            TxtKg.KeyPress += ClsInputHelper.OnlyNumeric;
            TxtKg.TextChanged += ClsInputHelper.OnlyNumeric_TextChanged;



            TxtName.KeyPress += ClsInputHelper.OnlyAlphabetic;
            TxtName.TextChanged += ClsInputHelper.OnlyText_TextChanged;


            TxtSurname.KeyPress += ClsInputHelper.OnlyAlphabetic;
            TxtSurname.TextChanged += ClsInputHelper.OnlyText_TextChanged;


            TxtPhone.KeyPress += ClsInputHelper.OnlyNumeric;
            TxtPhone.TextChanged += ClsInputHelper.OnlyNumeric_TextChanged;


           
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();

        private bool CheckAllFields()
        {
            if (string.IsNullOrEmpty(TxtTC.Text) ||
                string.IsNullOrEmpty(TxtName.Text) ||
                string.IsNullOrEmpty(TxtSurname.Text) ||
                CmbCinsiyet.SelectedIndex == -1 ||
                CmbSGK.SelectedIndex == -1 ||
                string.IsNullOrEmpty(TxtPhone.Text) ||
                string.IsNullOrEmpty(TxtMail.Text) ||
                string.IsNullOrEmpty(TxtPassword.Text) ||
                string.IsNullOrEmpty(TxtAddress.Text) ||
                string.IsNullOrEmpty(TxtMail.Text) ||
                string.IsNullOrEmpty(CmbBloodType.Text) ||
                string.IsNullOrEmpty(TxtKg.Text) ||
                string.IsNullOrEmpty(TxtSize.Text) || 
                Convert.ToInt16(TxtKg.Text ) < 20 || 
                Convert.ToInt16(TxtSize.Text) < 70 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearAllFields()
        {
            CmbCinsiyet.SelectedItem = -1;
            CmbSGK.SelectedItem = -1;
            TxtName.Clear();
            TxtSurname.Clear();
            TxtPhone.Clear();
            TxtMail.Clear();
            TxtTC.Clear();
            TxtPassword.Clear();
            TxtAddress.Clear();
            TxtFindPatient.Clear();
        }
        private void ListAllPatients()
        {
            var ListAllPatients = (from patient in db.TblHastas
                                  from detail in db.TblHastaDetayis
                                  where patient.TC == detail.HastaTC
                                  select new
                                  {
                                      TC = patient.TC,
                                      Cinsiyet = patient.cinsiyet,
                                      AdSoyad = patient.Ad + " " + patient.Soyad,
                                      Email = patient.Email,
                                      Telefon = patient.Telefon,
                                      DoğumTarihi = patient.Dogum_Tarihi,
                                      SGK = patient.SGK,
                                      Şifre = patient.sifre,
                                      Adres = patient.Adres,
                                      Kangrubu = detail.KanGrubu,
                                      Kilo = detail.Kg,
                                      Boy = detail.Boy,

                                  }).ToList();
            gridPatient.DataSource = ListAllPatients;
        }

    

        private void FrmPatientOperations_Load(object sender, EventArgs e)
        {
            gridPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ListAllPatients();
        }

        private void BtnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                string tc = TxtTC.Text;
                var findtc = db.TblHastas.Find(tc);
                var findtc2 = db.TblHastaDetayis.FirstOrDefault(x => x.HastaTC == tc);
                
                if (findtc != null && findtc2 != null)
                {
                    findtc.cinsiyet = CmbCinsiyet.SelectedItem.ToString();
                    findtc.Ad = TxtName.Text;
                    findtc.Soyad = TxtSurname.Text;
                    findtc.Telefon = TxtPhone.Text;
                    findtc.Email = TxtMail.Text;
                    if (DateTime.TryParse(DtBirthday.Text, out DateTime parsedDate))
                    {
                        findtc.Dogum_Tarihi = parsedDate;
                    }
                    
                    findtc.Dogum_Tarihi = Convert.ToDateTime(DtBirthday.Text);
                    findtc.SGK = CmbSGK.SelectedItem.ToString() == "Var" ? true : false;
                    findtc.sifre = TxtPassword.Text;
                    findtc.Adres = TxtAddress.Text.Trim();

                    findtc2.Yas = Convert.ToByte(DateTime.Now.Year - Convert.ToDateTime(DtBirthday.Text).Year);
                    findtc2.KanGrubu = CmbBloodType.SelectedItem.ToString();
                    findtc2.Kg = Convert.ToByte(TxtKg.Text);



                    db.SaveChanges();
                    ListAllPatients();
                    ClearAllFields();

                    MessageBox.Show("Hasta Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             

            }
            else
            {
                MessageBox.Show("Var olan hasta kayıdını güncellemek için bütün ilgili alnaları doldurmanız gerekmektedir!", "Healore Medical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            TblHasta tHasta = new TblHasta();
    

            if (CheckAllFields())
            {
                string tc = TxtTC.Text.Trim();


                tHasta.TC = tc;
                tHasta.cinsiyet = CmbCinsiyet.SelectedItem.ToString();
                tHasta.Ad = TxtName.Text;
                tHasta.Soyad = TxtSurname.Text;
                tHasta.Telefon = TxtPhone.Text;
                tHasta.Email = TxtMail.Text;
                tHasta.Dogum_Tarihi = Convert.ToDateTime(DtBirthday.Text);
                tHasta.SGK = CmbSGK.SelectedItem.ToString() == "Var" ? true : false;
                tHasta.sifre = TxtPassword.Text;
                tHasta.Adres = TxtAddress.Text.Trim();



                if (!db.TblHastas.Any(x => x.TC == tc))
                {
                    db.TblHastas.Add(tHasta);
                    db.SaveChanges();

                    var related_patient  = db.TblHastaDetayis.FirstOrDefault(x => x.HastaTC == tc);


                    related_patient.Yas = Convert.ToByte(DateTime.Now.Year - Convert.ToDateTime(DtBirthday.Text).Year);
                    related_patient.KanGrubu = CmbBloodType.SelectedItem.ToString();
                    related_patient.Kg = Convert.ToByte(TxtKg.Text);
                    related_patient.Boy = Convert.ToByte(TxtSize.Text);
                      
                    db.SaveChanges();

                    ListAllPatients();
                    ClearAllFields();
                    MessageBox.Show("Hasta Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu TC Kimlik Numarasına Ait Hasta Zaten Var", "Healore Medical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

           
            }
            else
            {
                MessageBox.Show("Yeni hasta kayıtı eklemek için bütün alanları doldurmanız gerekiyor!", "Healore Medical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtTC.Text = gridPatient.CurrentRow.Cells["TC"].Value.ToString();

            string cinsiyet = gridPatient.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            if (cinsiyet == "Erkek")
            {
                CmbCinsiyet.SelectedIndex = 0;
            }
            else
            {
                CmbCinsiyet.SelectedIndex = 1;
            }


            string[] adsoyad = gridPatient.CurrentRow.Cells["AdSoyad"].Value.ToString().Split(' ');
            TxtName.Text = adsoyad[0];
            TxtSurname.Text = adsoyad[1];

            TxtPhone.Text = gridPatient.CurrentRow.Cells["Telefon"].Value.ToString();
            TxtMail.Text = gridPatient.CurrentRow.Cells["Email"].Value.ToString();
            DtBirthday.Text = Convert.ToDateTime(gridPatient.CurrentRow.Cells["DoğumTarihi"].Value)
                               .ToString("dd.MM.yyyy"); ;
            TxtKg.Text = gridPatient.CurrentRow.Cells["Kilo"].Value.ToString();
            TxtSize.Text = gridPatient.CurrentRow.Cells["Boy"].Value.ToString();

            string BloodType = CmbBloodType.Text = gridPatient.CurrentRow.Cells["Kangrubu"].Value.ToString();

            switch (BloodType)
            {
                case "A+": CmbBloodType.SelectedIndex = 0; break;
                case "A-": CmbBloodType.SelectedIndex = 1; break;
                case "B+": CmbBloodType.SelectedIndex = 2; break;
                case "B-": CmbBloodType.SelectedIndex = 3; break;
                case "AB+": CmbBloodType.SelectedIndex = 4; break;
                case "AB-": CmbBloodType.SelectedIndex = 5; break;
                case "0+": CmbBloodType.SelectedIndex = 6; break;
                case "0-": CmbBloodType.SelectedIndex = 7; break;
            }


            string SGK = gridPatient.CurrentRow.Cells["SGK"].Value.ToString();
            if (SGK == "true")
            {
                CmbSGK.SelectedIndex = 0;
            }
            else
            {
                CmbSGK.SelectedIndex = 1;
            }

            TxtPassword.Text = gridPatient.CurrentRow.Cells["Şifre"].Value.ToString();
            TxtAddress.Text = gridPatient.CurrentRow.Cells["Adres"].Value.ToString();
        }



        private void TxtFindPatient_TextChanged(object sender, EventArgs e)
        {
            var list = (from hasta in db.TblHastas
                        join detay in db.TblHastaDetayis on hasta.TC equals detay.HastaTC
                        where (!ChcName.Checked && !ChcTC.Checked) ||
                              (ChcName.Checked && hasta.Ad.Contains(TxtFindPatient.Text)) ||
                              (ChcTC.Checked && hasta.TC.Contains(TxtFindPatient.Text))
                        select new
                        {
                            TC = hasta.TC,
                            Cinsiyet = hasta.cinsiyet,
                            AdSoyad = hasta.Ad + " " + hasta.Soyad,
                            Telefon = hasta.Telefon,
                            Email = hasta.Email,
                            DoğumTarihi = hasta.Dogum_Tarihi,
                            SGK = hasta.SGK,
                            Şifre = hasta.sifre,
                            Adres = hasta.Adres,

                            // Detay tablosundan gelen alanlar
                            KanGrubu = detay.KanGrubu,
                            Kilo = detay.Kg,
                            Boy = detay.Boy

                        }).ToList();


            gridPatient.DataSource = list;

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
