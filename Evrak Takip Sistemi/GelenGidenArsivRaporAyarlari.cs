using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO;
using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;
using ETS.VeriKatmani;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ETS
{
    public partial class GelenGidenArsivRaporAyarlari : Form
    {
        private readonly Collection<long> _topluCiktilar;

        /// <summary>
        /// Initial işlemler
        /// </summary>
        /// <param name="topluCiktilar">Çıktısı alınacak evrakların idleri</param>
        public GelenGidenArsivRaporAyarlari(Collection<long> topluCiktilar)
        {
            _topluCiktilar = topluCiktilar;
            InitializeComponent();
            SetPersonel();
        }

        /// <summary>
        /// Personel listesini doldurur
        /// </summary>
        private void SetPersonel()
        {
            txtPersonel.Properties.Columns.Clear();
            txtPersonel.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel.Properties.DisplayMember = "TamIsim";
            txtPersonel.Properties.ValueMember = "Id";
            txtPersonel.Properties.DataSource = new ETSEntities().Personel.ToList();
        }

        /// <summary>
        /// Kategori seçimi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkKategori_CheckedChanged(object sender, EventArgs e)
        {
            chkKategori.Text = chkKategori.Checked ? "A Kategorisi" : "B Kategorisi";
        }

        /// <summary>
        /// Raporu hazırla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaporla_Click(object sender, EventArgs e)
        {
            var raporSayfa1Data = new List<GelenGidenArsivSayfa1DTO>();
            var raporSayfa2Data = new List<GelenGidenArsivSayfa2DTO>();
            var raporSayfa3Data = new List<GelenGidenArsivSayfa3DTO>();

            using (var db = new ETSEntities())
            {
                var raporlanacakEvraklar = db.ArsivGelenGiden.Where(w => _topluCiktilar.Contains(w.Id)).ToList();
                raporSayfa1Data.Add(new GelenGidenArsivSayfa1DTO
                {
                    ArsivKategorisi = chkKategori.Checked ? "A" : "B",
                    BaskanlikAdi = txtBaskanlik.Text,
                    DaireAdi = txtDaire.Text,
                    DepoNu = txtDepoNu.Text,
                    DepoOdaNu = txtDepoOdaNu.Text,
                    DolapNu = txtDolapNu.Text,
                    EnvanterNumarasi = txtEnvaterNu.Text,
                    EnvanteriDuzenlenenArsivDonemi = txtEnvaterArsivDonemi.Text,
                    EnvanterinDuzenlendigiTarih = txtEnvaterinDuzenlendigiTarih.DateTime,
                    EnvanterinDuzenlenmeAmaci = txtEnvaterDuzenlemeAmaci.Text,
                    KomutanlikKurumAdi = txtKomutanlik.Text,
                    KonuGrubuNu = txtKonuGrupNu.Text,
                    KonusYeri = txtKonusYeri.Text,
                    KutuDosyaNu = txtKutuDosyaNu.Text,
                    RafNu = txtRafNu.Text,
                    SandikNu = txtSandikNu.Text,
                    SubeAdi = txtSube.Text,
                    TasnifKuruluPersonelleri = new List<RaporPersonelDTO>()
                });

                raporSayfa2Data.Add(new GelenGidenArsivSayfa2DTO
                {
                    ArsivGelenGiden = new List<ArsivGelenGidenDTO>()
                });

                raporlanacakEvraklar.ForEach(f => raporSayfa2Data[0].ArsivGelenGiden.Add(new ArsivGelenGidenDTO
                {
                    AraSayiNo = f.AraSayiNo,
                    CikaranMakam = f.EvrakiCikaranMakam.Makam,
                    DosyaNo = f.DosyaNo,
                    IlgiliEvrak = f.IlgiliEvrak,
                    Tarih = f.Tarih,
                    IlkEvrak = f.IlkEvrak,
                    Sube = f.Subeler.Sube,
                    EkSayisi = f.EkSayisi,
                    EsasKonuNo = f.EsasKonuNo,
                    ImhaYili = f.ImhaYili,
                    Konusu = f.Konusu,
                    Yil = f.Yil,
                    GelenEvrak = f.GelenEvrakId,
                    GidenEvrak = f.GidenEvrakId,
                    GizililikDerecesi = f.GizlilikDerecesi.Derece,
                    IlgiliBirim = f.Birimler.Birim
                }));

                raporSayfa3Data.Add(new GelenGidenArsivSayfa3DTO
                {
                    DevirTeslimPersonelleri = new List<RaporPersonelDTO>()
                });

                for (var i = 0; i < lstDevirTeslimPersonelleri.Items.Count; i++)
                {
                    var personelId = int.Parse(lstDevirTeslimPersonelleri.Items[i].ToString().Split('|')[0]);
                    var personel = db.Personel.SingleOrDefault(s => s.Id == personelId);
                    if (personel != null)
                        raporSayfa3Data[0].DevirTeslimPersonelleri.Add(new RaporPersonelDTO
                        {
                            Pozisyon = i % 2 != 0 ? "Teslim Eden" : "Teslim Alan",
                            Adi = personel.Adi,
                            Gorevi = personel.Gorevi,
                            Rutbesi = personel.Rutbesi,
                            Sicili = personel.Sicili,
                            Soyadi = personel.Soyadi
                        });
                }

                for (var i = 0; i < lstTasnifPersoneller.Items.Count; i++)
                {
                    var personelId = int.Parse(lstTasnifPersoneller.Items[i].ToString().Split('|')[0]);
                    var personel = db.Personel.SingleOrDefault(s => s.Id == personelId);
                    if (personel != null)
                        raporSayfa1Data[0].TasnifKuruluPersonelleri.Add(new RaporPersonelDTO
                        {
                            Pozisyon = i == 0 ? "Başkan" : "Üye",
                            Adi = personel.Adi,
                            Gorevi = personel.Gorevi,
                            Rutbesi = personel.Rutbesi,
                            Sicili = personel.Sicili,
                            Soyadi = personel.Soyadi
                        });
                }

                var raporSayfa1 = new XtraReport();
                raporSayfa1.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\GelenGidenArsivSayfa1.repx");

                var raporSayfa2 = new XtraReport();
                raporSayfa1.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\GelenGidenArsivSayfa2.repx");

                var raporSayfa3 = new XtraReport();
                raporSayfa1.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\GelenGidenArsivSayfa3.repx");

                raporSayfa1.DataSource = raporSayfa1Data;
                raporSayfa2.DataSource = raporSayfa2Data;
                raporSayfa3.DataSource = raporSayfa3Data;

                raporSayfa1.ShowRibbonPreview();
                raporSayfa2.ShowRibbonPreview();
                raporSayfa3.ShowRibbonPreview();
            }
        }

        /// <summary>
        /// Rapora Tasnif ekle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTasnifPEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonel.EditValue == null) return;
            lstTasnifPersoneller.Items.Add(txtPersonel.EditValue + "|" + txtPersonel.Text, 0);
        }

        /// <summary>
        /// Rapordan Tasnif çıkart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTasnifPCikart_Click(object sender, EventArgs e)
        {
            lstTasnifPersoneller.Items.Remove(lstTasnifPersoneller.SelectedItem);
        }

        /// <summary>
        /// Rapora Teslim ekle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDevirTeslimPEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonel.EditValue == null) return;
            lstDevirTeslimPersonelleri.Items.Add(txtPersonel.EditValue + "|" + txtPersonel.Text, 1);
        }

        /// <summary>
        /// Rapordan Teslim çıkart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDevirTeslimPCikart_Click(object sender, EventArgs e)
        {
            lstDevirTeslimPersonelleri.Items.Remove(lstDevirTeslimPersonelleri.SelectedItem);
        }
    }
}