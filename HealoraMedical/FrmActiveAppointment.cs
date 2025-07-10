using DevExpress.XtraExport.Xls;
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
    public partial class FrmActiveAppointment : Form
    {
        public FrmActiveAppointment()
        {
            InitializeComponent();
        }

        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();

        private void FrmActiveAppointment_Load(object sender, EventArgs e)
        {
            gridAppotiment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var ListActiveAppoitment = (from t1 in db.TblRandevus
                                         join t2 in db.TblDoktors on t1.DrSicilNo equals t2.DrSicilNo
                                         join t3 in db.TblPolikliniks on t1.PoliklinikNo equals t3.PoliklinikNo
                                         where t1.Durum == true && t1.Geldimi ==null
                                         select new
                                         {
                                             ID = t1.RandevuId,
                                             Doktor = t2.DrAd + " " + t2.DrSoyad,
                                             Poliklinik = t3.PoliklinikAd,
                                             Tarih = t1.RandevuTarihi,
                                             Saat = t1.RandevuSaati,
                                         }).ToList();
             
            gridAppotiment.DataSource = ListActiveAppoitment;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
