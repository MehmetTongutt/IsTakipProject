
namespace Is_Takip_Proje.Formlar
{
    partial class FrmGorevListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGorevListesi));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTDep = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamDepartman = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblPSayisi = new DevExpress.XtraEditors.LabelControl();
            this.lblPasifGorev = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.lblAktifGorev = new DevExpress.XtraEditors.PanelControl();
            this.lblAGorev = new DevExpress.XtraEditors.LabelControl();
            this.lblGorevSayisi = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAktifGorev)).BeginInit();
            this.lblAktifGorev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(472, 400);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblTDep);
            this.panelControl1.Controls.Add(this.lblToplamDepartman);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Location = new System.Drawing.Point(502, 13);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelControl1.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(203, 124);
            this.panelControl1.TabIndex = 2;
            // 
            // lblTDep
            // 
            this.lblTDep.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTDep.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTDep.Appearance.Options.UseFont = true;
            this.lblTDep.Appearance.Options.UseForeColor = true;
            this.lblTDep.Location = new System.Drawing.Point(67, 52);
            this.lblTDep.Name = "lblTDep";
            this.lblTDep.Size = new System.Drawing.Size(15, 28);
            this.lblTDep.TabIndex = 2;
            this.lblTDep.Text = "0";
            // 
            // lblToplamDepartman
            // 
            this.lblToplamDepartman.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamDepartman.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToplamDepartman.Appearance.Options.UseFont = true;
            this.lblToplamDepartman.Appearance.Options.UseForeColor = true;
            this.lblToplamDepartman.Location = new System.Drawing.Point(15, 3);
            this.lblToplamDepartman.Name = "lblToplamDepartman";
            this.lblToplamDepartman.Size = new System.Drawing.Size(173, 24);
            this.lblToplamDepartman.TabIndex = 1;
            this.lblToplamDepartman.Text = "Toplam Departman";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(128, 33);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(72, 80);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblPSayisi);
            this.panelControl2.Controls.Add(this.lblPasifGorev);
            this.panelControl2.Controls.Add(this.pictureEdit3);
            this.panelControl2.Location = new System.Drawing.Point(923, 12);
            this.panelControl2.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelControl2.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelControl2.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(194, 125);
            this.panelControl2.TabIndex = 3;
            // 
            // lblPSayisi
            // 
            this.lblPSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPSayisi.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPSayisi.Appearance.Options.UseFont = true;
            this.lblPSayisi.Appearance.Options.UseForeColor = true;
            this.lblPSayisi.Location = new System.Drawing.Point(57, 56);
            this.lblPSayisi.Name = "lblPSayisi";
            this.lblPSayisi.Size = new System.Drawing.Size(15, 28);
            this.lblPSayisi.TabIndex = 5;
            this.lblPSayisi.Text = "0";
            // 
            // lblPasifGorev
            // 
            this.lblPasifGorev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasifGorev.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPasifGorev.Appearance.Options.UseFont = true;
            this.lblPasifGorev.Appearance.Options.UseForeColor = true;
            this.lblPasifGorev.Location = new System.Drawing.Point(13, 7);
            this.lblPasifGorev.Name = "lblPasifGorev";
            this.lblPasifGorev.Size = new System.Drawing.Size(157, 24);
            this.lblPasifGorev.TabIndex = 4;
            this.lblPasifGorev.Text = "Pasif Görev Sayısı";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(118, 37);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(72, 80);
            this.pictureEdit3.TabIndex = 3;
            // 
            // lblAktifGorev
            // 
            this.lblAktifGorev.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.lblAktifGorev.Appearance.Options.UseBackColor = true;
            this.lblAktifGorev.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblAktifGorev.Controls.Add(this.lblAGorev);
            this.lblAktifGorev.Controls.Add(this.lblGorevSayisi);
            this.lblAktifGorev.Controls.Add(this.pictureEdit2);
            this.lblAktifGorev.Location = new System.Drawing.Point(714, 13);
            this.lblAktifGorev.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.lblAktifGorev.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.lblAktifGorev.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.lblAktifGorev.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblAktifGorev.Name = "lblAktifGorev";
            this.lblAktifGorev.Size = new System.Drawing.Size(203, 124);
            this.lblAktifGorev.TabIndex = 2;
            // 
            // lblAGorev
            // 
            this.lblAGorev.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAGorev.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAGorev.Appearance.Options.UseFont = true;
            this.lblAGorev.Appearance.Options.UseForeColor = true;
            this.lblAGorev.Location = new System.Drawing.Point(61, 56);
            this.lblAGorev.Name = "lblAGorev";
            this.lblAGorev.Size = new System.Drawing.Size(15, 28);
            this.lblAGorev.TabIndex = 5;
            this.lblAGorev.Text = "0";
            // 
            // lblGorevSayisi
            // 
            this.lblGorevSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevSayisi.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGorevSayisi.Appearance.Options.UseFont = true;
            this.lblGorevSayisi.Appearance.Options.UseForeColor = true;
            this.lblGorevSayisi.Location = new System.Drawing.Point(21, 7);
            this.lblGorevSayisi.Name = "lblGorevSayisi";
            this.lblGorevSayisi.Size = new System.Drawing.Size(155, 24);
            this.lblGorevSayisi.TabIndex = 4;
            this.lblGorevSayisi.Text = "Aktif Görev Sayısı";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(119, 33);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(72, 80);
            this.pictureEdit2.TabIndex = 3;
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(502, 143);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Durum";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(615, 270);
            this.chartControl1.TabIndex = 4;
            // 
            // FrmGorevListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 416);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.lblAktifGorev);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGorevListesi";
            this.Text = "Görev Listesi";
            this.Load += new System.EventHandler(this.FrmGorevListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAktifGorev)).EndInit();
            this.lblAktifGorev.ResumeLayout(false);
            this.lblAktifGorev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl lblAktifGorev;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl lblToplamDepartman;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblTDep;
        private DevExpress.XtraEditors.LabelControl lblPSayisi;
        private DevExpress.XtraEditors.LabelControl lblPasifGorev;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl lblAGorev;
        private DevExpress.XtraEditors.LabelControl lblGorevSayisi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}