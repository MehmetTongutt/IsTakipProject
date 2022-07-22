using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Is_Takip_Proje.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Is_Takip_Proje.Formlar
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();
        void PersonellerListele()
        {
            var elemalar = (from x in db.TblPersonel select new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.Mail,
                Departman=x.TblDepartmanlar.Ad  ,
                x.Durum
            });
            gridControl1.DataSource = elemalar.Where(p=>p.Durum==true).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            PersonellerListele();
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            PersonellerListele();
            var departmanlar = (from x in db.TblDepartmanlar
                               select new
                               {
                                   x.ID,
                                   x.Ad
                               }).ToList();
            lookUpEdit1.Properties.ValueMember="ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.Ad = TxtName.Text;
            t.Soyad = TxtSoyad.Text;
            t.Mail = TxtMail.Text;
            t.Gorsel = TxtGorsel.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel kaydı başarılı bir şekilde gerçekleşti","Bilgi"
                ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            PersonellerListele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtId.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel  başarılı bir şekilde Silindi", "Bilgi"
              , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonellerListele();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtName.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtId.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Ad = TxtName.Text;
            deger.Soyad = TxtSoyad.Text;
            deger.Mail = TxtMail.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel  başarılı bir şekilde Güncellendi", "Bilgi"
             , MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonellerListele();
        }
    }
}
