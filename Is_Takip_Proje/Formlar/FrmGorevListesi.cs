using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Is_Takip_Proje.Entity;

namespace Is_Takip_Proje.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities(); 

        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.ID,
                                           x.Aciklama
                                       }).ToList();

            lblAGorev.Text = db.TblGorevler.Count(p=>p.Durum=="1").ToString();
            lblPSayisi.Text = db.TblGorevler.Count(p=>p.Durum=="0").ToString();
            lblTDep.Text = db.TblDepartmanlar.Count().ToString();


            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblPSayisi.Text));
        }

       
    }
}
