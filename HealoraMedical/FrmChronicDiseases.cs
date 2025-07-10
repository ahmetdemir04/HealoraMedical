using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealoraMedical
{
    public partial class FrmChronicDiseases : Form
    {
        public FrmChronicDiseases()
        {
            InitializeComponent();
        }
        public string TC = "";

        DbHealoraMedicalEntities5 db = new DbHealoraMedicalEntities5();
        void ListAllChronicInformation()
        {
            if (db.TblHastaDetayı.Any(x => x.HastaTC == TC))
            {
                var ListAllChronic = db.TblHastaDetayı.Where(x => x.HastaTC == TC).Select(x => new
                {
                    x.HastaTC,
                    x.KanGrubu,
                    x.Şeker,
                    x.Hipertansiyon,
                    x.Hipotansiyon,
                    x.Astım,
                    x.Hipotiroidi,
                    x.Hepatit_B,
                    x.Hepatit_C,
                    x.HIV,
                    x.AIDS,
                    x.Depresyon,
                    x.Alzheimer,
                    x.Epilepsi,
                    x.Parkinson,
                }).FirstOrDefault();




                LblTc.Text = ListAllChronic.HastaTC;
                LblBloodGroup.Text = ListAllChronic.KanGrubu;

                LblNameSurname.Text = db.TblHastas.Where(x => x.TC == TC).Select(x => x.Ad + " " + x.Soyad).FirstOrDefault();

                var properties = ListAllChronic.GetType().GetProperties().Skip(2);


                List<string> chronicDiseases = new List<string>();


                foreach (var item in properties)
                {

                    var value = item.GetValue(ListAllChronic);

                    if (value is bool && (bool)value)
                    {
                        chronicDiseases.Add("Var");
                    }
                    else
                    {
                        chronicDiseases.Add("Yok");
                    }
                }

                LblSugar.Text = chronicDiseases[0];
                LblHypertension.Text = chronicDiseases[1];
                LblHypotension.Text = chronicDiseases[2];
                LblAsthma.Text = chronicDiseases[3];
                LblHypothyroidism.Text = chronicDiseases[4];
                LblHepatitisB.Text = chronicDiseases[5];
                LblHepatitisC.Text = chronicDiseases[6];
                LblHIV.Text = chronicDiseases[7];
                LblAIDS.Text = chronicDiseases[8];
                LblDepresion.Text = chronicDiseases[9];
                LblAlzhemier.Text = chronicDiseases[10];
                LblEpilepsy.Text = chronicDiseases[11];
                LblParkinson.Text = chronicDiseases[12];

            }
            else
            {
                MessageBox.Show("Bu hasta için kronik hastalık bilgisi bulunamadı!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void FrmChronicDiseases_Load(object sender, EventArgs e)
        {
            ListAllChronicInformation();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
