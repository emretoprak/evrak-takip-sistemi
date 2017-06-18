using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.LookAndFeel.Design;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class OlayListesi : Form
    {
        private string _seciliKolon;

        public OlayListesi(bool suresiGelenleriGoster)
        {
            InitializeComponent();
            entityServerModeSource1.QueryableSource = new ETSEntities().DaimiArastirmaTutanaklari;

            if (suresiGelenleriGoster)
            {
                btnZamaniGelenT_ItemClick(null, null);
            }
        }

        private void btnCikti_ItemClick(object sender, ItemClickEventArgs e)
        {
            var topluCiktilar = new Collection<long>();
            for (var i = 0; i < grdVOlaylar.DataRowCount; i++)
            {
                topluCiktilar.Add(int.Parse(grdVOlaylar.GetRowCellValue(i, "Id").ToString()));
            }

            var ustYazi = new XtraReport();
            var tutanak = new XtraReport();
            ustYazi.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\UstYazi.repx");
            tutanak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\Tutanak.repx");
            
            var daimiCikti = (new ETSEntities().DaimiArastirmaTutanaklari.AsEnumerable()
                .Select(r => new { r, list = topluCiktilar })
                .Where(@t => (@t.list.Contains(@t.r.Id)))
                .Select(@t => @t.r)).ToList();

            foreach (var t in daimiCikti.Where(t => t.Personel3Id == null && t.Personel4Id == null))
            {
                tutanak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\Tutanak2Imza.repx");
            }

            foreach (var t in daimiCikti.Where(t => t.Personel3Id != null && t.Personel4Id == null))
            {
                tutanak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\Tutanak3Imza.repx");
            }

            ustYazi.DataSource = daimiCikti;
            ustYazi.ShowRibbonPreview();

            tutanak.DataSource = daimiCikti;
            tutanak.ShowRibbonPreview();
        }

        private void btnUstYaziDegisiklerle_ItemClick(object sender, ItemClickEventArgs e)
        {
            var topluCiktilar = new Collection<long>();
            for (var i = 0; i < grdVOlaylar.DataRowCount; i++)
            {
                topluCiktilar.Add(int.Parse(grdVOlaylar.GetRowCellValue(i, "Id").ToString()));
            }

            var ustYaziDegisikleri = new UstYaziDegisikleri(topluCiktilar);
            ustYaziDegisikleri.ShowDialog();
        }

        private void btnTopluDuzenle_ItemClick(object sender, ItemClickEventArgs e)
        {
            var topluDuzenlenecekIdler = new Collection<long>();
            for (var i = 0; i < grdVOlaylar.DataRowCount; i++)
            {
                topluDuzenlenecekIdler.Add(int.Parse(grdVOlaylar.GetRowCellValue(i, "Id").ToString()));
            }

            if (_seciliKolon != null)
            {
                var olayListesiTopluDuzenleme = new OlayListesiTopluDuzenleme(topluDuzenlenecekIdler, _seciliKolon);
                switch (_seciliKolon)
                {
                    case "PeriyotYili":
                    case "Periyotlar.Periyot":
                    case "Personel.AdiSoyadi":
                    case "Personel1.AdiSoyadi":
                    case "Personel2.AdiSoyadi":
                    case "Personel3.AdiSoyadi":
                        olayListesiTopluDuzenleme.ShowDialog();
                        break;
                }

                RefreshGridDataSource();
            }
            else
            {
                XtraMessageBox.Show("Seçili bir kolon yok");
            }
        }

        private void grdVOlaylar_Click(object sender, EventArgs e)
        {
            var clickInfo = grdVOlaylar.CalcHitInfo(grdOlaylar.PointToClient(MousePosition));

            if (clickInfo.InColumn)
            {
                _seciliKolon = clickInfo.Column.FieldName;
            }
        }

        private void RefreshGridDataSource()
        {
            grdOlaylar.DataSource = new ETSEntities().DaimiArastirmaTutanaklari.ToList(typeof (DaimiArastirmaTutanaklari));
            grdOlaylar.RefreshDataSource();
        }

        private void btnYazdirmaGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem())
            {
                Component = grdOlaylar,
                Margins = new Margins
                {
                    Bottom = 5,
                    Left = 5,
                    Right = 5,
                    Top = 5
                },
                Landscape = true
            };

            link.ShowRibbonPreviewDialog(new UserLookAndFeelDefault());
        }

        private void btnExcelCiktisiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Olay Listesi"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                grdVOlaylar.ExportToXls(saveFile.FileName);
            }
        }

        private void btnPdfCiktisiAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "pdf",
                FileName = "Olay Listesi"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                grdVOlaylar.ExportToPdf(saveFile.FileName);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var rowId = (long)grdVOlaylar.GetRowCellValue(grdVOlaylar.FocusedRowHandle, "Id");
            var olayListesi = new YeniOlay(new KayitDuzenleDTO
            {
                Duzenleme = true,
                EvrakId = rowId,
                EvrakTip = EvrakTip.Olay
            });

            olayListesi.ShowDialog();
            RefreshGridDataSource();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt kaldırılacak emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            var rowId = (long)grdVOlaylar.GetRowCellValue(grdVOlaylar.FocusedRowHandle, "Id");

            using (var db = new ETSEntities())
            {
                db.DaimiArastirmaTutanaklari.Remove(db.DaimiArastirmaTutanaklari.SingleOrDefault(x => x.Id == rowId));
                db.SaveChanges();
            }
            RefreshGridDataSource();
        }

        private void btnGridiYenile_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGridDataSource();
        }

        private void btnZamaniGelenT_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ayarlar = new ETSEntities().Ayarlar.SingleOrDefault();
            var ekGun = ayarlar == null ? 0 : int.Parse(ayarlar.DaimiAramaKontrolSuresi.ToString());
            grdOlaylar.DataSource = new ETSEntities().DaimiArastirmaTutanaklari.Where(x => x.ZamanAsimi <= DbFunctions.AddDays(DateTime.Now, ekGun)).ToList(typeof(DaimiArastirmaTutanaklari));
            grdOlaylar.RefreshDataSource();   
        }
    }
}