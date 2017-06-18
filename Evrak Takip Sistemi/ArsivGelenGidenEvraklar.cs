using DevExpress.Data.PLinq.Helpers;
using DevExpress.XtraBars;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ETS
{
    public partial class ArsivGelenGidenEvraklar : Form
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        /// <summary>
        /// Initial işlemler
        /// </summary>
        public ArsivGelenGidenEvraklar()
        {
            InitializeComponent();
            brGridVeriYili.EditValue = DateTime.Now.ToString("yyyy");
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            entityServerModeSource1.QueryableSource = new ETSEntities().ArsivGelenGiden.Where(w => BaslangicTarihi <= w.Tarih && BitisTarihi >= w.Tarih);
        }

        /// <summary>
        /// Yazdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridVArsivGelenGiden.Print();
        }

        /// <summary>
        /// Yazdırma görüntüleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridVArsivGelenGiden.ShowRibbonPrintPreview();
        }

        /// <summary>
        /// Excel çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarExcelCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Arşiv Gelen Giden Evraklar"
            };

            if (saveFile.ShowDialog() == DialogResult.OK) gridVArsivGelenGiden.ExportToXls(saveFile.FileName);
        }

        /// <summary>
        /// Pdf çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarPdfCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "pdf",
                FileName = "Arşiv Gelen Giden Evraklar"
            };

            if (saveFile.ShowDialog() == DialogResult.OK) gridVArsivGelenGiden.ExportToPdf(saveFile.FileName);
        }

        /// <summary>
        /// Kayıt sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt arşivden kaldırılacak emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rowId = (long)gridVArsivGelenGiden.GetRowCellValue(gridVArsivGelenGiden.FocusedRowHandle, "Id");
            using (var db = new ETSEntities())
            {
                var arsiv = db.ArsivGelenGiden.SingleOrDefault(x => x.Id == rowId);
                if (arsiv != null && arsiv.GelenEvrakId != null)
                {
                    var gelenEvrak = db.GelenEvrak.SingleOrDefault(s => s.Id == arsiv.GelenEvrakId);
                    if (gelenEvrak != null) gelenEvrak.Arsivlendi = false;
                    db.Entry(gelenEvrak).State = EntityState.Modified;
                }
                if (arsiv != null && arsiv.GidenEvrakId != null)
                {
                    var gidenEvrak = db.GidenEvrak.SingleOrDefault(s => s.Id == arsiv.GidenEvrakId);
                    if (gidenEvrak != null) gidenEvrak.Arsivlendi = false;
                    db.Entry(gidenEvrak).State = EntityState.Modified;
                }
                db.ArsivGelenGiden.Remove(arsiv);
                db.SaveChanges();
            }
            RefreshGridDataSource();
        }

        /// <summary>
        /// Grid'i yenile.
        /// </summary>
        private void RefreshGridDataSource()
        {
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            grdArsivGelenGiden.DataSource = new ETSEntities().ArsivGelenGiden.Where(w => BaslangicTarihi <= w.Tarih && BitisTarihi >= w.Tarih).ToList(typeof(ArsivGelenGiden));
            grdArsivGelenGiden.RefreshDataSource();
        }

        /// <summary>
        /// Düzenleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var rowId = (long)gridVArsivGelenGiden.GetRowCellValue(gridVArsivGelenGiden.FocusedRowHandle, "Id");
            var gelenGidenArsivEvrakDuzenle = new YeniGelenGidenArsiv(new KayitDuzenleDTO
            {
                Duzenleme = true,
                EvrakId = rowId,
                EvrakTip = EvrakTip.GelenGidenArsiv
            });
            gelenGidenArsivEvrakDuzenle.ShowDialog();
            RefreshGridDataSource();
        }

        /// <summary>
        /// Yenile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGridiYenile_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        /// <summary>
        /// Seçili tarihi uygula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYiliUygula_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        /// <summary>
        /// Rapor çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaporHazirla_ItemClick(object sender, ItemClickEventArgs e)
        {
            var topluDuzenlenecekIdler = new Collection<long>();
            for (var i = 0; i < gridVArsivGelenGiden.DataRowCount; i++)
            {
                topluDuzenlenecekIdler.Add(int.Parse(gridVArsivGelenGiden.GetRowCellValue(i, "Id").ToString()));
            }
            var gelenGidenArsivRaporAyarlari = new GelenGidenArsivRaporAyarlari(topluDuzenlenecekIdler);
            gelenGidenArsivRaporAyarlari.ShowDialog();
        }
    }
}