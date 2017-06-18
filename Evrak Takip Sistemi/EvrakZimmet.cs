using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using ETS.Akislar.DomainDataObjects.GridGorunumDTO;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class EvrakZimmet : Form
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        /// <summary>
        /// Initial işlemler
        /// </summary>
        public EvrakZimmet()
        {
            InitializeComponent();
            brGridVeriYili.EditValue = DateTime.Now.ToString("yyyy");
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            grdZimmet.DataSource = new ETSEntities().ZimmetDefteri.Where(w => BaslangicTarihi <= w.ZimmetTarihi && BitisTarihi >= w.ZimmetTarihi).OrderBy(o => o.SiraNo).ToList();
        }

        /// <summary>
        /// Excel çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvrakZimmetExcelCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Gelen Evraklar"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                grdZimmet.ExportToXls(saveFile.FileName);
            }
        }

        /// <summary>
        /// Pdf çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvrakZimmetPdfCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "pdf",
                FileName = "Gelen Evraklar"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                grdZimmet.ExportToPdf(saveFile.FileName);
            }
        }

        /// <summary>
        /// Yazdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvrakZimmetYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            grdZimmet.ShowRibbonPrintPreview();
        }

        /// <summary>
        /// Zimmetlenen evrağın bilgisini alt satır olarak gösterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            var c = (ZimmetDefteri) grdVZimmet.GetRow(e.RowHandle);
            e.IsEmpty = c.Id == 0;
        }

        /// <summary>
        /// Master row ilişkisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        /// <summary>
        /// İlişki adı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "GelenEvrak";
        }

        /// <summary>
        /// Alt satır bilgilerini doldurur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var zimmet = (ZimmetDefteri) grdVZimmet.GetRow(e.RowHandle);
            if (zimmet.GelenEvrakId != null)
            {
                var dataSource = new GelenEvrakViewDTO
                {
                    GelenEvraklarView = new GelenEvraklarViewDTO
                    {
                        Aciklama = zimmet.GelenEvrak.Aciklama,
                        DosyaNoKonusu = zimmet.GelenEvrak.DosyaNoKonusu,
                        Personel = zimmet.GelenEvrak.Personel.TamIsim,
                        Durum = zimmet.GelenEvrak.Durum,
                        TarihTsg = zimmet.GelenEvrak.TarihTSG,
                        EvrakiCikaranMakam = zimmet.GelenEvrak.EvrakiCikaranMakam.Makam,
                        EvrakKayitNo = zimmet.GelenEvrak.EvrakKayitNo,
                        EvrakKayitTarihi = zimmet.GelenEvrak.EvrakKayitTarihi,
                        EvrakSonTarihi = zimmet.GelenEvrak.EvrakSonTarihi,
                        GizlilikDerecesi = zimmet.GelenEvrak.GizlilikDerecesi.Derece,
                        GuvenlikNoOncelikDerecesi = zimmet.GelenEvrak.GuvenlikNoOncelikDerecesi.Derece
                    }
                };
                e.ChildList = new BindingSource(dataSource, "GelenEvraklarView");
            }
            else
            {
                if (zimmet.GidenEvrakId == null) return;
                var dataSource = new GidenEvrakViewDTO
                {
                    GidenEvraklarView = new GidenEvraklarViewDTO
                    {
                        Aciklama = zimmet.GidenEvrak.Aciklama,
                        DosyaNoKonusu = zimmet.GidenEvrak.DosyaNoKonusu,
                        GonderdigiMakam = zimmet.GidenEvrak.GonderdigiMakam.Makam,
                        Durum = zimmet.GidenEvrak.Durum,
                        TarihTsg = zimmet.GidenEvrak.TarihTSG,
                        EvrakiCikaranMakam = zimmet.GidenEvrak.EvrakiCikaranMakam.Makam,
                        EvrakKayitNo = zimmet.GidenEvrak.EvrakKayitNo,
                        EvrakKayitTarihi = zimmet.GidenEvrak.EvrakKayitTarihi,
                        EvrakSonTarihi = zimmet.GidenEvrak.EvrakSonTarihi,
                        GizlilikDerecesi = zimmet.GidenEvrak.GizlilikDerecesi.Derece,
                        GuvenlikNoOncelikDerecesi = zimmet.GidenEvrak.GuvenlikNoOncelikDerecesi.Derece
                    }
                };
                e.ChildList = new BindingSource(dataSource, "GidenEvraklarView");
            }
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
        /// Gridi yeniler
        /// </summary>
        private void RefreshGridDataSource()
        {
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            grdZimmet.DataSource = new ETSEntities().ZimmetDefteri.Where(w => BaslangicTarihi <= w.ZimmetTarihi && BitisTarihi >= w.ZimmetTarihi).OrderBy(o => o.SiraNo).ToList(typeof(ZimmetDefteri));
            grdZimmet.RefreshDataSource();
        }

        /// <summary>
        /// Seçili yılı uygular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYiliUygula_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (var db = new ETSEntities())
            //{
            //    var yeniZimmetler = db.TempZimmet.ToList();

            //    foreach (var z in yeniZimmetler)
            //    {
            //        var gidEvrak = db.GidenEvrak.SingleOrDefault(w => w.EvrakKayitNo.Equals(z.GelGidNo));
            //        if (gidEvrak == null) return;

            //        var zimmetDefteri = new ZimmetDefteri
            //        {
            //            KategoriId = 8,
            //            SiraNo = z.SirNo,
            //            ZimmetTarihi = z.Tar,
            //            TeslimAlanId = z.PerID,
            //            GelenEvrakId = null,
            //            GidenEvrakId = gidEvrak.Id
            //        };

            //        db.ZimmetDefteri.Add(zimmetDefteri);

            //        gidEvrak.Durum = 1;
            //        db.Entry(gidEvrak).State = EntityState.Modified;
            //        db.SaveChanges();

            //        var zimID = db.ZimmetDefteri.First(s => s.GidenEvrakId == gidEvrak.Id);
            //        gidEvrak.ZimmetId = zimID.Id;
            //        db.Entry(gidEvrak).State = EntityState.Modified;
            //        db.SaveChanges();
            //    }
            //}
        }
    }
}