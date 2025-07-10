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

namespace HealoraMedical
{
    public partial class FrmAnnouncement : Form
    {
        public FrmAnnouncement()
        {
            InitializeComponent(); 
          
        }
        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        private void AllAnnouncement()
        {
            var AllAnnoucement = db.TblDuyurus.Select(x =>
            new
            {
                Başlık = x.DyrBaslik,
                İçerik = x.DyrIcerik,
                Tarih = x.DyrTarih
            }
            ).ToList();

            gridAnnouncement.DataSource = AllAnnoucement;
        }
        private void FrmAnnouncement_Load(object sender, EventArgs e)
        {
            gridAnnouncement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AllAnnouncement();
       
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridAnnouncement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTitle.Text = gridAnnouncement.CurrentRow.Cells["Başlık"].Value.ToString();
            TxtContext.Text = gridAnnouncement.CurrentRow.Cells["İçerik"].Value.ToString();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            if (ChAllAnc.Checked)
            {
                AllAnnouncement();
            }
            else if (ChTodayAnc.Checked)
            {
                var today = DateTime.Today;
                var TodayAnc = db.TblDuyurus.Select(x => new
                {
                    Başlık = x.DyrBaslik,
                    İçerik = x.DyrIcerik,
                    Tarih = x.DyrTarih
                }).Where(x => DbFunctions.TruncateTime(x.Tarih)== today).ToList();

                gridAnnouncement.DataSource = TodayAnc;

            }
        }
    }
}
