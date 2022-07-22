using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Is_Takip_Proje.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Is_Takip_Proje.Formlar
{
    public partial class frmDepartmans : Form
    {
        public frmDepartmans()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();
        void Listele()
        {
            
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.Ad = TxtName.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtId.Text);
            var deger = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silme işlemi başarılı bir şekilde gerçekleşti,","Bilgi"
                ,MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtName.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtId.Text);
            var deger = db.TblDepartmanlar.Find(x);
            deger.Ad = TxtName.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncelleme işlemi başarılı bir şekilde gerçekleşti,", "Bilgi"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele(); 
          
        }
    }
}
