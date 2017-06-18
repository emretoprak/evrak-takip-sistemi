using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class OlayBilgileri : Form
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        /// <summary>
        /// Olay Bilgileri Initial işlemler
        /// </summary>
        public OlayBilgileri()
        {
            InitializeComponent();
            brGridVeriYili.EditValue = DateTime.Now.ToString("yyyy");
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            entityServerModeSource.QueryableSource = new ETSEntities().OlaylarBilgisi.Where(w => BaslangicTarihi <= w.OlayTarihi && BitisTarihi >= w.OlayTarihi);
        }

        /// <summary>
        /// Yazdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            grdVOlayBilgileri.Print();
        }

        /// <summary>
        /// Önizleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            grdVOlayBilgileri.ShowRibbonPrintPreview();
        }

        /// <summary>
        /// Excel çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcelCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Olay Bilgileri"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                grdVOlayBilgileri.ExportToXls(saveFile.FileName);
            }
        }

        /// <summary>
        /// Pdf çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPdfCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "pdf",
                FileName = "Olay Bilgileri"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                grdVOlayBilgileri.ExportToPdf(saveFile.FileName);
            }
        }

        /// <summary>
        /// Gridi yenile
        /// </summary>
        private void RefreshGridDataSource()
        {
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            grdOlayBilgileri.DataSource = new ETSEntities().OlaylarBilgisi.Where(w => BaslangicTarihi <= w.OlayTarihi && BitisTarihi >= w.OlayTarihi).ToList(typeof(OlaylarBilgisi));
            grdOlayBilgileri.RefreshDataSource();
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
        /// Yıl filtresini uygula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYiliUygula_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }
        
        /// <summary>
        /// Kayıtlar arşivlenmiş zimmetlenmiş ise butonlar pasif yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridviewGelenEvraklar_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e){
            //var row = grdVOlayBilgileri.GetRow(e.RowHandle) as GelenEvrak;
            //if (e.Column == colArsivle)
            //{
            //    var buttonEditViewInfo = (ButtonEditViewInfo)((GridCellInfo)e.Cell).ViewInfo;
            //    if (row != null && row.Arsivlendi)
            //    {
            //        buttonEditViewInfo.RightButtons[0].State = ObjectState.Disabled;
            //        e.Column.OptionsColumn.AllowEdit = false;
            //    }
            //    else
            //    {
            //        buttonEditViewInfo.RightButtons[0].State = ObjectState.Normal;
            //        e.Column.OptionsColumn.AllowEdit = true;
            //    }
            //}
        }
        
        /// <summary>
        /// Yıllık döküm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYillikDokum_ItemClick(object sender, ItemClickEventArgs e)
        {
            var olayBilgileriYillikDokumAyarlari = new OlayBilgileriYillikDokumAyarlari();
            olayBilgileriYillikDokumAyarlari.ShowDialog();
        }

        /// <summary>
        /// Olay dağılımı raporu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOlayDagilimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var olayBilgileriOlayDagilimiAyarlari = new OlayBilgileriOlayDagilimiAyarlari();
            olayBilgileriOlayDagilimiAyarlari.ShowDialog();
        }

        /// <summary>
        /// Kayıt sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKayitSil_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt kaldırılacak emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rowId = (long)grdVOlayBilgileri.GetRowCellValue(grdVOlayBilgileri.FocusedRowHandle, "Id");
            using (var db = new ETSEntities())
            {
                db.OlaylarBilgisi.Remove(db.OlaylarBilgisi.SingleOrDefault(x => x.Id == rowId));
                db.SaveChanges();
            }
            RefreshGridDataSource();
        }

        /// <summary>
        /// Evrağı düzenle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuzenle_Click_1(object sender, EventArgs e)
        {
            var rowId = (long)grdVOlayBilgileri.GetRowCellValue(grdVOlayBilgileri.FocusedRowHandle, "Id");
            var olayBilgisiDuzenle = new YeniOlayBilgisi(new KayitDuzenleDTO
            {
                Duzenleme = true,
                EvrakId = rowId,
                EvrakTip = EvrakTip.OlayBilgisi
            });
            olayBilgisiDuzenle.ShowDialog();
            RefreshGridDataSource();        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var db = new ETSEntities())
            {
                ////////// Toplu girdi
                //var tempData = db.TempOlaylar.ToList();
                //var olaylarBilgisi = new List<OlaylarBilgisi>();
                //foreach (var t in tempData)
                //{
                //    var olaylar = db.Suclar.SingleOrDefault(s => s.Suc.Equals(t.val5));
                //    int olayId;
                //    if (olaylar != null)
                //    {
                //        olayId = olaylar.Id;
                //    }
                //    else
                //    {
                //        db.Suclar.Add(new Suclar
                //        {
                //            Suc = t.val5
                //        });
                //        db.SaveChanges();
                //        olayId = db.Suclar.SingleOrDefault(s => s.Suc.Equals(t.val5)).Id;
                //    }
                    
                //    // : tasnif al
                //    var tasnif = db.Tasnifler.SingleOrDefault(s => s.Baslik.Equals(t.val8) && s.AltBaslik.Equals(t.val9) && s.Suc.Equals(t.val10) && s.Grup.Equals(t.val11));
                //    if (tasnif == null)
                //    {
                //        return;
                //    }
                    
                //    var tasnifId = tasnif.Id;

                //    olaylarBilgisi.Add(new OlaylarBilgisi
                //    {
                //        SiraNo = long.Parse(t.val1),
                //        OlayBilNo = long.Parse(t.val2),
                //        OlayTarihi = DateTime.Parse(t.val3),
                //        OlayYeriId = int.Parse(t.val4),
                //        OlayId = olayId,
                //        KomutanlikId = int.Parse(t.val7),
                //        TansifId = tasnifId
                //    });
                //}

                //foreach (var o in olaylarBilgisi)
                //{
                //    db.OlaylarBilgisi.Add(o);
                //}
                //////////

                db.SaveChanges();
            }
        }
    }
}