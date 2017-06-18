using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class MuzekkereIcmaller : Form
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        public MuzekkereIcmaller()
        {
            InitializeComponent();
            brGridVeriYili.EditValue = DateTime.Now.ToString("yyyy");
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            entityServerModeSource.QueryableSource = new ETSEntities().MuzekkereIcmalDefteri.Where(w => BaslangicTarihi <= w.GeldigiTarih && BitisTarihi >= w.GeldigiTarih);
        }

        private void btnGelenEvraklarYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridVMuzekkereIcmalDefteri.Print();
        }

        private void btnGelenEvraklarYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridVMuzekkereIcmalDefteri.ShowRibbonPrintPreview();
        }

        private void btnGelenEvraklarExcelCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Müzekkere İcmal"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridVMuzekkereIcmalDefteri.ExportToXls(saveFile.FileName);
            }
        }

        private void btnGelenEvraklarPdfCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "pdf",
                FileName = "Müzekkere İcmal"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridVMuzekkereIcmalDefteri.ExportToPdf(saveFile.FileName);
            }
        }

        private void RefreshGridDataSource()
        {
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            grdMuzekkereIcmalDefteri.DataSource = new ETSEntities().MuzekkereIcmalDefteri.Where(w => BaslangicTarihi <= w.GeldigiTarih && BitisTarihi >= w.GeldigiTarih).ToList(typeof(MuzekkereIcmalDefteri));
            grdMuzekkereIcmalDefteri.RefreshDataSource();
        }

        private void btnGridiYenile_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        private void btnYiliUygula_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var rowId = gridVMuzekkereIcmalDefteri.GetRowCellValue(gridVMuzekkereIcmalDefteri.FocusedRowHandle, "Id");

            var icmalDuzenle = new YeniMuzekkereIcmal(new KayitDuzenleDTO
            {
                Duzenleme = true,
                EvrakId = int.Parse(rowId.ToString()),
                EvrakTip = EvrakTip.MuzekkereIcmal
            });

            icmalDuzenle.ShowDialog();
            RefreshGridDataSource();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt kaldırılacak emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            var rowId = (long)gridVMuzekkereIcmalDefteri.GetRowCellValue(gridVMuzekkereIcmalDefteri.FocusedRowHandle, "Id");
            using (var db = new ETSEntities())
            {
                db.MuzekkereIcmalDefteri.Remove(db.MuzekkereIcmalDefteri.SingleOrDefault(x => x.Id == rowId));
                db.SaveChanges();
            }
            RefreshGridDataSource();
        }

        private void btnRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var icmalAyarlari = new MuzekkereIcmalAyarlari();
            icmalAyarlari.ShowDialog();
        }
    }
}