using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;
using System.IO;

namespace ETS
{
    public partial class GelenEvraklar : Form
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        /// <summary>
        /// Gelen Evraklar Initial işlemler
        /// </summary>
        /// <param name="suresiGelenleriGoster">Alarm üzerine tıklandığında true olarak gelir ve sayafada sadece süresi gelenler gösterilir.</param>
        public GelenEvraklar(bool suresiGelenleriGoster)
        {
            InitializeComponent();
            brGridVeriYili.EditValue = DateTime.Now.ToString("yyyy");
            BaslangicTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 01, 01);
            BitisTarihi = new DateTime(int.Parse(brGridVeriYili.EditValue.ToString()), 12, 31);
            entityServerModeSource1.QueryableSource = new ETSEntities().GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi);

            if (suresiGelenleriGoster)
            {
                btnSuresiGelenEvraklar_ItemClick(null, null);
            }
        }

        /// <summary>
        /// Yazdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridviewGelenEvraklar.Print();
        }

        /// <summary>
        /// Önizleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklarYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridviewGelenEvraklar.ShowRibbonPrintPreview();
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
                FileName = "Gelen Evraklar"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridviewGelenEvraklar.ExportToXls(saveFile.FileName);
            }
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
                FileName = "Gelen Evraklar"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridviewGelenEvraklar.ExportToPdf(saveFile.FileName);
            }
        }

        /// <summary>
        /// Kayıt sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if ((int) gridviewGelenEvraklar.GetRowCellValue(gridviewGelenEvraklar.FocusedRowHandle, "Durum") != 0)
            {
                XtraMessageBox.Show("Zimmetlenen evrak silinemez.", "Uyarı :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Kayıt kaldırılacak emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            var rowId = (long)gridviewGelenEvraklar.GetRowCellValue(gridviewGelenEvraklar.FocusedRowHandle, "Id");
            using (var db = new ETSEntities())
            {
                db.GelenEvrak.Remove(db.GelenEvrak.SingleOrDefault(x => x.Id == rowId));
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
            grdGelenEvrak.DataSource = new ETSEntities().GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).ToList(typeof (GelenEvrak));
            grdGelenEvrak.RefreshDataSource();
        }

        /// <summary>
        /// Evrağı zimmetle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            var rowId = (long)gridviewGelenEvraklar.GetRowCellValue(gridviewGelenEvraklar.FocusedRowHandle, "Id");
            if ((int) gridviewGelenEvraklar.GetRowCellValue(gridviewGelenEvraklar.FocusedRowHandle, "Durum") != 0)
            {
                XtraMessageBox.Show("Bu evrak daha önce zimmetlenmiş.", "Uyarı :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var evrakiZimmetle = new EvrakZimmetle(rowId, EvrakTip.GelenEvrak, false);
            evrakiZimmetle.ShowDialog();
            RefreshGridDataSource();
        }

        /// <summary>
        /// Evrağı düzenle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var rowId = (long) gridviewGelenEvraklar.GetRowCellValue(gridviewGelenEvraklar.FocusedRowHandle, "Id");
            var gelenEvrakDuzenle = new YeniGelenEvrak(new KayitDuzenleDTO
            {
                Duzenleme = true,
                EvrakId = rowId,
                EvrakTip = EvrakTip.GelenEvrak
            });
            gelenEvrakDuzenle.ShowDialog();
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
        /// Süresi gelen evrakları göster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuresiGelenEvraklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ayarlar = new ETSEntities().Ayarlar.SingleOrDefault();
            var ekGun = ayarlar == null ? 0 : int.Parse(ayarlar.GelenEvrakKontrolSuresi.ToString());
            grdGelenEvrak.DataSource = new ETSEntities().GelenEvrak.Where(x => x.EvrakSonTarihi <= DbFunctions.AddDays(DateTime.Now, ekGun) && x.Durum == 0).ToList(typeof (GelenEvrak));
            grdGelenEvrak.RefreshDataSource();
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
        /// Evrağı arşive gönder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArsivle_Click(object sender, EventArgs e)
        {
            var rowId = (long)gridviewGelenEvraklar.GetRowCellValue(gridviewGelenEvraklar.FocusedRowHandle, "Id");
            using (var db = new ETSEntities())
            {
                var gelenEvrak = db.GelenEvrak.SingleOrDefault(s => s.Id == rowId);
                if (gelenEvrak != null && gelenEvrak.Arsivlendi)
                {
                    XtraMessageBox.Show("Evrak daha önce arşivlenmiş");
                    return;
                }
            }
            var gelenGidenEvrakArsivle = new YeniGelenGidenArsivle(rowId, EvrakTip.GelenEvrak);
            gelenGidenEvrakArsivle.ShowDialog();
            RefreshGridDataSource();
        }

        /// <summary>
        /// Kayıtlar arşivlenmiş zimmetlenmiş ise butonlar pasif yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridviewGelenEvraklar_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            var row = gridviewGelenEvraklar.GetRow(e.RowHandle) as GelenEvrak;
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
            else if (e.Column == colKaydiSil)
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

        /// <summary>
        /// Gelen Evrak genel istatistikleri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GelenEvraklar_Load(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                infoToplamEvrak.Caption = string.Format("Toplam Evrak Sayısı : {0}", db.GelenEvrak.Count());
                infoCevapVerilen.Caption = string.Format("Cevap Verilen Evrak Sayısı : {0}", db.GelenEvrak.Count(c => c.Durum == 1));
                infoCevapVerilmeyen.Caption = string.Format("Cevap Verilmeyen Evrak Sayısı : {0}", db.GelenEvrak.Count(c => c.Durum == 0));
            }
        }

        /// <summary>
        /// Bekleyen kayıtların köy köy excel çıktısı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBekleyenEvraklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var htmlTable = "<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns=\"http://www.w3.org/TR/REC-html40\"><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>Bekleyen Evraklar</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]-->" +
                            "<style>" +
                            "th {text-align:center; font-weight:bold;}" +
                            "</style>" +
                            "</head>" +
                            "<body>" +
                            "<table>" +
                            "<tr>" +
                            "<th>Mahalle</th>" +
                            "<th>Bekleyen Evrak Sayısı</th>" +
                            "</tr>";

            using (var db = new ETSEntities())
            {
                var koyler = db.GelenEvrak.Where(w => w.Durum == 0).Select(s => s.OlayYerleri).Distinct();

                foreach (var koy in koyler)
                {
                    htmlTable += "<tr>";
                    htmlTable += "<td>" + koy.OlayYeri + "</td>";
                    htmlTable += "<td>" + db.GelenEvrak.Count(c => c.Durum == 0 && c.OlayYeriId == koy.Id) + "</td>";
                    htmlTable += "</tr>";
                }
            }

            htmlTable += "</table>";
            htmlTable += "</body>";
            htmlTable += "</html>";

            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Bekleyen Evrak Sayısı"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(saveFile.FileName, htmlTable, Encoding.UTF8);
        }
    }
}