namespace ETS.RaporTasarlayicisi
{
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraReports.UI;
    using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO;
    using ETS.VeriKatmani;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class RaporDuzenle : RibbonForm
    {
        /// <summary>
        /// Rapor düzenleme sınıfı
        /// </summary>
        /// <param name="dosyaYolu">Düzenlenecek raporun dosya yolu</param>
        /// <param name="veri">Düzenlecek datanın örnek veri şablonu adı</param>
        public RaporDuzenle(string dosyaYolu, string veri)
        {
            InitializeComponent();
            var rapor = new XtraReport();
            if (!string.IsNullOrWhiteSpace(dosyaYolu)) rapor.LoadLayout(dosyaYolu);

            switch (veri)
            {
                case "Daimi Arama Tutanakları":
                    rapor.DataSource = new BindingSource().DataSource = new List<DaimiArastirmaTutanaklari>();
                    break;
                case "Gelen Evrak":
                    rapor.DataSource = new BindingSource().DataSource = new List<GelenEvrak>();
                    break;
                case "Giden Evrak":
                    rapor.DataSource = new BindingSource().DataSource = new List<GidenEvrak>();
                    break;
                case "Zimmet Defteri":
                    rapor.DataSource = new BindingSource().DataSource = new List<ZimmetDefteri>();
                    break;
                case "Gelen Giden Evrak Istatistik":
                    rapor.DataSource = new BindingSource().DataSource = new List<GelenGidenIstatistiklerDTO>();
                    break;
                case "Aylık İcmal":
                    rapor.DataSource = new BindingSource().DataSource = new List<IcmalAylikRaporDTO>();
                    break;
                case "Yıllık İcmal":
                    rapor.DataSource = new BindingSource().DataSource = new List<IcmalYillikRaporDTO>();
                break;
                case "Yıllık İcmaller":
                    rapor.DataSource = new BindingSource().DataSource = new List<IcmalTumYillarRaporDTO>();
                break;
                case "Gelen Giden Evrak Arşiv Sayfa 1":
                    rapor.DataSource = new BindingSource().DataSource = new List<GelenGidenArsivSayfa1DTO>();
                break;
                case "Gelen Giden Evrak Arşiv Sayfa 2":
                    rapor.DataSource = new BindingSource().DataSource = new List<GelenGidenArsivSayfa2DTO>();
                break;
                case "Gelen Giden Evrak Arşiv Sayfa 3":
                    rapor.DataSource = new BindingSource().DataSource = new List<GelenGidenArsivSayfa3DTO>();
                break;
            }
            reportDesigner.OpenReport(rapor);
        }
    }
}