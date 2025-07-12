using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmDrMain : Form
    {
        public FrmDrMain()
        {
            InitializeComponent();

            TxtDuration.KeyPress += ClsInputHelper.OnlyNumeric;
            TxtDuration.TextChanged += ClsInputHelper.OnlyNumeric_TextChanged;

            CmbUsage.KeyPress += ClsInputHelper.OnlyAlphabetic;
            CmbUsage.TextChanged += ClsInputHelper.OnlyText_TextChanged;

            CmbUsageInst.KeyPress += ClsInputHelper.OnlyAlphabetic;
            CmbUsageInst.TextChanged += ClsInputHelper.OnlyText_TextChanged;

        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();

        public string SicilNo;
        string tc;
        int randevuID;
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            var props = typeof(T).GetProperties();

            foreach (var prop in props)
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (var item in items)
            {
                var values = props.Select(p => p.GetValue(item, null)).ToArray();
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void ListAllApointment()
        {
            var appointment_query = db.TblRandevus.Where(x => x.DrSicilNo == SicilNo && x.Durum == true && x.Geldimi ==null).Select(x =>
            new
            {
                RandevuID = x.RandevuId,
                TC = x.TblHasta.TC,
                Ad_Soyad = x.TblHasta.Ad + " " + x.TblHasta.Soyad,

                Tarih = x.RandevuTarihi,
                Saat = x.RandevuSaati,
            }).OrderBy(x => x.Tarih).OrderBy(x => x.Saat).ToList();

            var all_prop = ToDataTable(appointment_query);

            foreach (DataRow row in all_prop.Rows)
            {
                string TC = row["TC"].ToString();
                string ptNameSurname = row["Ad_Soyad"].ToString();
                string date = row["Tarih"].ToString();
                string saat = row["Saat"].ToString();
                int randevuID = Convert.ToInt32(row["RandevuID"]);


                int index = gridDr.Rows.Add();
                gridDr.Rows[index].Cells["RandevuID"].Value = randevuID;
                gridDr.Rows[index].Cells["TCC"].Value = TC;
                gridDr.Rows[index].Cells["AdSoyad"].Value = ptNameSurname;
                gridDr.Rows[index].Cells["Tarih"].Value = date;
                gridDr.Rows[index].Cells["Saat"].Value = saat;


            }

        }


        private void ListPersonalAppointments()
        {
            if (gridDr.Rows.Count > 0)
            {
                var personalApt = db.TblRandevus.Where(x => x.HastaTc == tc && x.Durum == true && x.RandevuTarihi <= DateTime.Today).Select(x =>
      new
      {
          x.TblHasta.TC,
          AdSoyad = x.TblHasta.Ad + " " + x.TblHasta.Soyad,
          x.RandevuTarihi,
          x.RandevuSaati
      }
      ).ToList();



                gridPatientApt.Rows.Clear();
                gridPatientApt.DataSource = personalApt;
            }


        }

        private void FrmDr_Load(object sender, EventArgs e)
        {
            gridPatientApt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMedicine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            splitContainer1.SplitterWidth = 1;

            ListAllApointment();
        }


        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnNext.Enabled = false;
            BtnSave.Enabled = true;
            BtnChronicDiseases.Enabled = true;

            if (gridDr.Rows.Count > 0)
            {
                randevuID = Convert.ToInt32(gridDr.Rows[0].Cells["RandevuID"].Value);
                tc = gridDr.Rows[0].Cells["TCC"].Value.ToString();

                var patient_information = db.TblHastas
                    .Where(x => x.TC == tc)
                    .Select(x => new
                    {
                        x.TC,
                        x.Ad,
                        x.Soyad,
                        x.cinsiyet,
                        x.Dogum_Tarihi,
                        x.Telefon,
                        x.Email,
                        x.SGK,
                        x.Adres
                    }).FirstOrDefault();

                var paitent_randevu = db.TblRandevus.Where(x => x.HastaTc == tc).Select(x => new
                {
                    Şikayet = x.HastaSikayet,
                }
                ).FirstOrDefault();

                LblPtNameSurname.Text = patient_information.Ad + " " + patient_information.Soyad;
                TxtSikayet.Text = paitent_randevu.Şikayet;

                ListPersonalAppointments();
                BtnChronicDiseases.Enabled = true;
                BtnNext.Enabled = false;
            }
            else
            {
                MessageBox.Show("Randevu bitti!", "Healora Medical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtnChronicDiseases_Click(object sender, EventArgs e)
        {
            FrmChronicDiseases FrmChrDs = new FrmChronicDiseases();
            if (tc != null)
            {
                FrmChrDs.TC = tc;
                FrmChrDs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Herhangi bi hasta seçilmedi!", "HealoraMedical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool CheckAllFields()
        {
            if (!string.IsNullOrEmpty(TxtDiagnosis.Text) &&
                !string.IsNullOrEmpty(TxtMedicines.Text) &&
                !string.IsNullOrEmpty(CmbTrtMethod.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearFields()
        {
            TxtDiagnosis.Clear();
            TxtMedicines.Clear();
            CmbUsageInst.SelectedIndex = -1;
            CmbTrtMethod.SelectedIndex = -1;

            CmbUsage.Text = "";
            CmbUsageInst.Text = "";
            TxtDose.Clear();
            LblPtNameSurname.Text = "";
            TxtSikayet.Clear();
            gridPatientApt.DataSource = null;
            gridDr.Rows.RemoveAt(0);
            ChcPatientCome.Checked = false;
            
            gridMedicine.Rows.Clear();

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnNext.Enabled = true;
            BtnSave.Enabled = false;
            BtnChronicDiseases.Enabled = false;
          



            if (ChcPatientCome.Checked == false)
            {
                TblTedavi tTedavi = new TblTedavi();
            

                if (CheckAllFields())
                {
                    tTedavi.RandevuID = randevuID;
                    tTedavi.Teşhis = TxtDiagnosis.Text.Trim();
                    tTedavi.Tedavi_Yöntemi = CmbTrtMethod.Text.Trim();


                    db.TblTedavis.Add(tTedavi);

                    var rnd = db.TblRandevus.Where(x => x.RandevuId == randevuID).FirstOrDefault();
                    rnd.Geldimi = true;



                    if (gridMedicine.Rows.Count > 0 )
                    {
                        int tedaviID = Convert.ToInt32(tTedavi.TedaviID);


                        for (int row = 0; row < gridMedicine.Rows.Count; row++)
                        {
                            TblIlac tIlac = new TblIlac();
                            tIlac.TedaviID = tedaviID;
                            tIlac.IlacAd = gridMedicine.Rows[row].Cells["medc"].Value.ToString();
                            tIlac.Dozi = gridMedicine.Rows[row].Cells["Dose"].Value.ToString();
                            tIlac.KullanimSekli = gridMedicine.Rows[row].Cells["Usage"].Value.ToString();
                            tIlac.Kullanim = gridMedicine.Rows[row].Cells["UsageInstr"].Value.ToString();

                            if (gridMedicine.Rows[row].Cells["Duration"].Value != null &&
                               short.TryParse(gridMedicine.Rows[row].Cells["Duration"].Value.ToString(), out short duration))
                            {
                                tIlac.Sure = duration;
                            }
                            else
                            {
                                MessageBox.Show($"Invalid value in 'Duration' at row {row + 1}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            

                            db.TblIlacs.Add(tIlac);

                        }
                    }
              
                    db.SaveChanges();

                    MessageBox.Show("Tedavi Bilgileri Kaydedildi", "HealoraMedical", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Bütün ilgili alanları doldurmanız gerekmektedir!", "HealoraMedical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            
            }
            else
            {
                var rnd = db.TblRandevus.Where(x => x.RandevuId == randevuID).FirstOrDefault();
                rnd.Geldimi = false;
                db.SaveChanges();
                ClearFields();
            }

            if (gridPatientApt.Rows.Count < 0)
            {
                BtnNext.Enabled = false;
            }

     
        }
  

        private void BtnAddMedicine_Click(object sender, EventArgs e)
        {
            string medc, dose, usageInst, usage;
            int duration;

            medc = TxtMedicines.Text.Trim();
            dose = TxtDose.Text.Trim();
            usageInst = CmbUsageInst.Text.Trim();
            usage = CmbUsage.Text.Trim();
            duration = Convert.ToInt32(TxtDuration.Text.Trim());

            int index = gridMedicine.Rows.Add();
            gridMedicine.Rows[index].Cells["medc"].Value = medc;
            gridMedicine.Rows[index].Cells["Dose"].Value = dose;
            gridMedicine.Rows[index].Cells["UsageInstr"].Value = usageInst;
            gridMedicine.Rows[index].Cells["usage"].Value = usage;
            gridMedicine.Rows[index].Cells["duration"].Value = duration;
            
            
        
        }

        #region pnHeader

        int MouseX, MouseY;
        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = MousePosition.X - this.Left;
            MouseY = MousePosition.Y - this.Top;


            timer1.Enabled = true;
        }

        private void splitContainer1_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - MouseX;
            this.Top = MousePosition.Y - MouseY;
        }
        #endregion



        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = gridMedicine.CurrentRow.Cells["medc"].RowIndex;
            gridMedicine.Rows.RemoveAt(index);
        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
           FrmAnnouncement frmAnc = new FrmAnnouncement();
            frmAnc.ShowDialog();
        }

        private void gridPatientApt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RandevuID = Convert.ToInt32(gridDr.CurrentRow.Cells["RandevuID"].Value.ToString());
            FrmPatientMedicine FrmPtMedicine = new FrmPatientMedicine();
            FrmPtMedicine.randevuID = RandevuID;
            FrmPtMedicine.ShowDialog();
           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
