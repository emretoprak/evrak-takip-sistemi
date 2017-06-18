using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class GidenEvraklar : Form
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        /// <summary>
        /// Giden evraklar inital işlemler
        /// </summary>
        /// <param name="suresiGelenleriGoster">Sadece süresi gelen evrakları gösterir</param>
        public GidenEvraklar(bool suresiGelenleriGoster)
        {
            InitializeComponent();
            brGridVeriYili.EditValue = DateTime.Now.ToString("yyyy");
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            entitySource.QueryableSource = new ETSEntities().GidenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi);

            if (suresiGelenleriGoster)
            {
                btnZamaniGelenEvraklar_ItemClick(null, null);
            }
        }

        /// <summary>
        /// Yazdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGidenEvraklarYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridviewGidenEvraklar.Print();
        }

        /// <summary>
        /// Önizleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGidenEvraklarYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridviewGidenEvraklar.ShowRibbonPrintPreview();
        }

        /// <summary>
        /// Excel çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGidenEvraklarExcelCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Giden Evraklar"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridviewGidenEvraklar.ExportToXls(saveFile.FileName);
            }
        }

        /// <summary>
        /// Pdf çıktısı al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGidenEvraklarPdfCiktiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "pdf",
                FileName = "Giden Evraklar"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridviewGidenEvraklar.ExportToPdf(saveFile.FileName);
            }
        }

        /// <summary>
        /// Zimmetle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZimmetle_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var rowId = (long)gridviewGidenEvraklar.GetRowCellValue(gridviewGidenEvraklar.FocusedRowHandle, "Id");

            if ((int)gridviewGidenEvraklar.GetRowCellValue(gridviewGidenEvraklar.FocusedRowHandle, "Durum") != 0)
            {
                XtraMessageBox.Show("Bu evrak daha önce zimmetlenmiş.", "Uyarı :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var evrakiZimmetle = new EvrakZimmetle(rowId, EvrakTip.GidenEvrak, false);
            evrakiZimmetle.ShowDialog();
            RefreshGridDataSource();
        }

        /// <summary>
        /// Evrakı sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKayitSil_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if ((int)gridviewGidenEvraklar.GetRowCellValue(gridviewGidenEvraklar.FocusedRowHandle, "Durum") != 0)
            {
                XtraMessageBox.Show("Zimmetlenen evrak silinemez.", "Uyarı :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Kayıt kaldırılacak emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            var rowId = (long)gridviewGidenEvraklar.GetRowCellValue(gridviewGidenEvraklar.FocusedRowHandle, "Id");

            using (var db = new ETSEntities())
            {
                db.GidenEvrak.Remove(db.GidenEvrak.SingleOrDefault(x => x.Id == rowId));
                db.SaveChanges();
            }
            RefreshGridDataSource();
        }

        /// <summary>
        /// Gridi yenile
        /// </summary>
        private void RefreshGridDataSource()
        {
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            grdGidenEvrak.DataSource = new ETSEntities().GidenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).ToList(typeof(GidenEvrak));
            grdGidenEvrak.RefreshDataSource();
        }

        /// <summary>
        /// Evrağı Düzenle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuzenle_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var rowId = (long)gridviewGidenEvraklar.GetRowCellValue(gridviewGidenEvraklar.FocusedRowHandle, "Id");

            var gidenEvrakDuzenle = new YeniGidenEvrak(new KayitDuzenleDTO
            {
                Duzenleme = true,
                EvrakId = rowId,
                EvrakTip = EvrakTip.GelenEvrak
            });

            gidenEvrakDuzenle.ShowDialog();
            RefreshGridDataSource();
        }

        private void btnGridiYenile_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        private void btnZamaniGelenEvraklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ayarlar = new ETSEntities().Ayarlar.SingleOrDefault();
            var ekGun = ayarlar == null ? 0 : int.Parse(ayarlar.GidenEvrakKontrolSuresi.ToString());
            grdGidenEvrak.DataSource = new ETSEntities().GidenEvrak.Where(x => x.EvrakSonTarihi <= DbFunctions.AddDays(DateTime.Now, ekGun) && x.Durum == 0).ToList(typeof(GidenEvrak));
            grdGidenEvrak.RefreshDataSource();
        }

        private void btnYiliUygula_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        private void btnArsivle_Click(object sender, EventArgs e)
        {
            var rowId = (long)gridviewGidenEvraklar.GetRowCellValue(gridviewGidenEvraklar.FocusedRowHandle, "Id");

            using (var db = new ETSEntities())
            {
                var gidenEvrak = db.GidenEvrak.SingleOrDefault(s => s.Id == rowId);
                if (gidenEvrak != null && gidenEvrak.Arsivlendi)
                {
                    XtraMessageBox.Show("Evrak daha önce arşivlenmiş");
                    return;
                }
            }
            var gelenGidenEvrakArsivle = new YeniGelenGidenArsivle(rowId, EvrakTip.GidenEvrak);
            gelenGidenEvrakArsivle.ShowDialog();
            RefreshGridDataSource();
        }

        private void gridviewGidenEvraklar_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            var row = gridviewGidenEvraklar.GetRow(e.RowHandle) as GidenEvrak;
            if (e.Column == colArsivle)
            {
                var buttonEditViewInfo = (ButtonEditViewInfo)((GridCellInfo)e.Cell).ViewInfo;
                if (row != null && row.Arsivlendi)
                {
                    buttonEditViewInfo.RightButtons[0].State = ObjectState.Disabled;
                    e.Column.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    buttonEditViewInfo.RightButtons[0].State = ObjectState.Normal;
                    e.Column.OptionsColumn.AllowEdit = true;
                }
            }
            else if (e.Column == colEvrakiZimmetle)
            {
                var buttonEditViewInfo = (ButtonEditViewInfo)((GridCellInfo)e.Cell).ViewInfo;
                if (row != null && row.Durum == 1)
                {
                    buttonEditViewInfo.RightButtons[0].State = ObjectState.Disabled;
                    e.Column.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    buttonEditViewInfo.RightButtons[0].State = ObjectState.Normal;
                    e.Column.OptionsColumn.AllowEdit = true;
                }
            }
            else if (e.Column == colKayitSil)
            {
                var buttonEditViewInfo = (ButtonEditViewInfo)((GridCellInfo)e.Cell).ViewInfo;
                if (row != null && row.Durum == 1)
                {
                    buttonEditViewInfo.RightButtons[0].State = ObjectState.Disabled;
                    e.Column.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    buttonEditViewInfo.RightButtons[0].State = ObjectState.Normal;
                    e.Column.OptionsColumn.AllowEdit = true;
                }
            }
        }

        private void GidenEvraklar_Load(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                infoToplamEvrak.Caption = string.Format("Toplam Evrak Sayısı : {0}", db.GidenEvrak.Count());
                infoFailiMechul.Caption = string.Format("Faili Meçhul Evrak Sayısı : {0}", db.GidenEvrak.Count(c => c.OlayDurumu.Id == 5));
                infoAileiciSiddet.Caption = string.Format("Aileiçi Şiddet Evrak Sayısı : {0}", db.GidenEvrak.Count(c => c.OlayDurumu.Id == 6));
            }
        }
    }
}
