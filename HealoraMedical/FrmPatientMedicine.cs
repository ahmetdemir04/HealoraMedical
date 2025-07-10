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
    public partial class FrmPatientMedicine : Form
    {
        public FrmPatientMedicine()
        {
            InitializeComponent();
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();

        public int randevuID; 
        private void ListMedicine()
        {
            var TreatmentID = db.TblTedavis.Where(x => x.RandevuID == randevuID).Select(x => x.TedaviID).FirstOrDefault();

            

            var medicine_query = db.TblIlacs.Where(x=> x.TedaviID == TreatmentID).Select(x => new
            {
                x.IlacAd,
                x.Dozi,
                x.KullanimSekli
            }).ToList();
            gridMedicine.DataSource = medicine_query;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmPatientMedicine_Load(object sender, EventArgs e)
        {
            gridMedicine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ListMedicine();
        }
    }
}
