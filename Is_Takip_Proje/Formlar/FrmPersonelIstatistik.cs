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
    public partial class FrmPersonelIstatistik : Form
    {
        public FrmPersonelIstatistik()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();

        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            lblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            lblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            lblAktifIsSayisi.Text = db.TblGorevler.Count(x => x.Durum =="1").ToString();
            lblPasifIsSayisi.Text = db.TblGorevler.Count(x => x.Durum =="0").ToString();
            lblSonGorev.Text = db.TblGorevler.Select(x => x.Aciklama).ToList().Last().ToString();

            lblSonGorevDetayi.Text = db.TblGorevDetaylar.Select(x => x.Aciklama).ToList().Last().ToString();

            lblSehirSayisi.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            lblSektorSayisi.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblBugunkuGorevler.Text = db.TblGorevler.Count(p => p.Tarih == bugun).ToString();
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.TblPersonel.Where(p => p.ID == d1).Select(y => y.Ad +" "+y.Soyad).FirstOrDefault().ToString();

            lblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID ==db.TblPersonel.Where(T=>T.ID==d1).Select(z=>z.Departman).FirstOrDefault() ).Select(p => p.Ad).FirstOrDefault().ToString();

        }

       
    }
}
