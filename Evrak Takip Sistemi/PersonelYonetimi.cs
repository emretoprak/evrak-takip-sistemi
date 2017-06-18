using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class PersonelYonetimi : Form
    {
        private int _personelId;
        
        public PersonelYonetimi()
        {
            InitializeComponent();
            grdPersonel.DataSource = new ETSEntities().Personel.ToList();
            entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
        }

        private static void entityInstantFeedbackSource1_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            var dataContext = new ETSEntities();
            e.QueryableSource = dataContext.Personel;
            e.Tag = dataContext;
        }

        private static void entityInstantFeedbackSource1_DismissQueryable(object sender, GetQueryableEventArgs e)
        {
            ((ETSEntities) e.Tag).Dispose();
        }

        private void btnPersonelSil_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var rowId = (int) gvPersonel.GetRowCellValue(gvPersonel.FocusedRowHandle, "Id");

            using (var db = new ETSEntities())
            {
                var personel = db.Personel.SingleOrDefault(x => x.Id == rowId);

                if (personel != null)
                {
                    personel.Durum = personel.Durum == 1 ? 0 : 1;
                }
                db.Entry(personel).State = EntityState.Modified;

                db.SaveChanges();
            }

            RefreshGridDataSource();

            XtraMessageBox.Show("Kayıt Düzenlendi");
        }

        private void RefreshGridDataSource()
        {
            grdPersonel.DataSource = new ETSEntities().Personel.ToList(typeof (Personel));
            grdPersonel.RefreshDataSource();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate(txtPAdi)) return;
            if (!dxValidationProvider.Validate(txtPSoyadi)) return;
            if (!dxValidationProvider.Validate(txtPRutbesi)) return;

            var yeniPersonel = new Personel
            {
                Adi = txtPAdi.Text,
                Soyadi = txtPSoyadi.Text,
                Durum = 1,
                Rutbesi = txtPRutbesi.Text,
                Tim = txtPTimi.Text,
                AdiSoyadi = txtPAdi.Text + " " + txtPSoyadi.Text,
                TamIsim = txtPRutbesi.Text + " " + txtPAdi.Text + " " + txtPSoyadi.Text,
                Sicili = txtSicili.Text,
                Gorevi = txtGorevi.Text
            };

            using (var db = new ETSEntities())
            {
                db.Personel.Add(yeniPersonel);
                db.SaveChanges();
            }

            RefreshGridDataSource();

            txtPAdi.Text = null;
            txtPSoyadi.Text = null;
            txtPRutbesi.Text = null;
            txtPTimi.Text = null;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnPersonelEkle.Visible = false;
            btnKaydet.Visible = true;

            var rowId = (int)gvPersonel.GetRowCellValue(gvPersonel.FocusedRowHandle, "Id");
            _personelId = rowId;

            using (var db = new ETSEntities())
            {
                var personel = db.Personel.SingleOrDefault(s => s.Id == rowId);

                if (personel == null) return;
                txtGorevi.Text = personel.Gorevi;
                txtPAdi.Text = personel.Adi;
                txtPRutbesi.Text = personel.Rutbesi;
                txtPSoyadi.Text = personel.Soyadi;
                txtPTimi.Text = personel.Tim;
                txtSicili.Text = personel.Sicili;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate(txtPAdi)) return;
            if (!dxValidationProvider.Validate(txtPSoyadi)) return; 
            if (!dxValidationProvider.Validate(txtPRutbesi)) return;
           
            using (var db = new ETSEntities())
            {
                var duzenlenenPersonel = db.Personel.SingleOrDefault(s => s.Id == _personelId);

                if (duzenlenenPersonel != null)
                {
                    duzenlenenPersonel.Adi = txtPAdi.Text;
                    duzenlenenPersonel.Soyadi = txtPSoyadi.Text;
                    duzenlenenPersonel.Durum = 1;
                    duzenlenenPersonel.Rutbesi = txtPRutbesi.Text;
                    duzenlenenPersonel.Tim = txtPTimi.Text;
                    duzenlenenPersonel.AdiSoyadi = txtPAdi.Text + " " + txtPSoyadi.Text;
                    duzenlenenPersonel.TamIsim = txtPRutbesi.Text + " " + txtPAdi.Text + " " + txtPSoyadi.Text;
                    duzenlenenPersonel.Sicili = txtSicili.Text;
                    duzenlenenPersonel.Gorevi = txtGorevi.Text;
                }

                db.Entry(duzenlenenPersonel).State = EntityState.Modified;
                db.SaveChanges();
            }

            RefreshGridDataSource();

            txtPAdi.Text = null;
            txtPSoyadi.Text = null;
            txtPRutbesi.Text = null;
            txtPTimi.Text = null;
            txtGorevi.Text = null;
            txtSicili.Text = null;

            btnPersonelEkle.Visible = true;
            btnKaydet.Visible = false;
        }

        private void gvPersonel_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            var row = gvPersonel.GetRow(e.RowHandle) as Personel;
            if (e.Column != colDurum) return;
            var buttonEditViewInfo = (ButtonEditViewInfo)((GridCellInfo)e.Cell).ViewInfo;
            
            if (row != null && row.Durum == 0)
            {
                buttonEditViewInfo.RightButtons[0].State = ObjectState.Disabled;
            }
            else
            {
                buttonEditViewInfo.RightButtons[0].State = ObjectState.Normal;
            }
        }
    }
}