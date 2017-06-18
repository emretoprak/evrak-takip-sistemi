using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ETS.Akislar.Alarmlar;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Islemler;
using ETS.Akislar.Istatistikler;
using ETS.VeriKatmani;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ETS
{
    public partial class AnaEkran : RibbonForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Yeni Gelen Evrak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniGelenEvrak_Click(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Yeni Gelen Evrak" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }

            if (isOpen) return;
            var child = new YeniGelenEvrak(new KayitDuzenleDTO()) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Gelen Evraklar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenEvraklar_Click(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Gelen Evraklar" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new GelenEvraklar(false) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Giden Evraklar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGidenEvraklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Giden Evraklar" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new GidenEvraklar(false) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Evrak Zimmet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvrakZimmet_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Evrak Zimmet" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new EvrakZimmet {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Giden Evraklar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniGidenEvrak_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Yeni Giden Evrak" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new YeniGidenEvrak(new KayitDuzenleDTO()) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Sistem Ayarları
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSistemAyarlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Genel Ayarlar" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new GenelAyarlar {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// OlayListesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTunanaklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Olay Listesi" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new OlayListesi(false) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Yeni Olay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniTutanak_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Yeni Olay" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;            
            var child = new YeniOlay(new KayitDuzenleDTO {Duzenleme = false,}) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Personel Yönetimi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonelYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Personel Yönetimi" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new PersonelYonetimi {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Çıkış
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Yedek Yönetimi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYedekYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Yedek Yönetimi" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new YedekYonetimi {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Rapor Tasarlayıcısı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaporTasarlayicisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var raporSecimi = new RaporSecimEkrani();
            raporSecimi.ShowDialog();
        }

        /// <summary>
        /// Ana Ekran yüklenirken veritabanı alarm kontrolleri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            brIstYil.EditValue = DateTime.Now.ToString("yyyy");
            if (!VeritabaniKontrol()) return;
            AlarmlariKontrolEt();
            Text = "Evrak Takip Sistemi | " + ConfigurationManager.AppSettings["Karakol"];
        }

        /// <summary>
        /// Alarmları kontrol eder
        /// </summary>
        private void AlarmlariKontrolEt()
        {
            using (var db = new ETSEntities())
            {
                // : Veritabanın dan ayarlar alınır eğer ayarlarda kontoller tanımlanmış ise kontrol yapılır.
                var ayarlar = db.Ayarlar.SingleOrDefault();
                if (ayarlar != null && (ayarlar.GelenEvrakKontrol != null && (bool) ayarlar.GelenEvrakKontrol))
                {
                    var thGelenEvrakKontrol = new Thread(GelenEvraklarKontrol);
                    thGelenEvrakKontrol.Start();
                }
                if (ayarlar != null && (ayarlar.GidenEvrakKontrol != null && (bool) ayarlar.GidenEvrakKontrol))
                {
                    var thGidenEvrakKontrol = new Thread(GidenEvraklarKontrol);
                    thGidenEvrakKontrol.Start();
                }
                if (ayarlar != null && (ayarlar.DaimiAramaTKontrol != null && (bool) ayarlar.DaimiAramaTKontrol))
                {
                    var thDaimiAramaTKontrol = new Thread(DaimiAramaTKontrol);
                    thDaimiAramaTKontrol.Start();
                }
            }
        }

        /// <summary>
        /// Süresi gelen daimi aramaların kontrolü yapılır
        /// </summary>
        private void DaimiAramaTKontrol()
        {
            var alarm = new Alarm().DaimiAramaTKontrol();
            if (alarm <= 0) return;
            if (InvokeRequired) BeginInvoke(new MethodInvoker(DaimiAramaTKontrol));
            else
            {
                alertControl.Show(this, new AlertInfo("Daimi Arama Tutanakları", String.Format("{0} adet tutanak için zaman yaklaştı.", alarm)));
                alertControl.AlertClick += alertControl_AlertClick;
            }
        }

        /// <summary>
        /// Süresi gelen giden evrakların kontrolü yapılır
        /// </summary>
        private void GidenEvraklarKontrol()
        {
            var alarm = new Alarm().GidenEvraklarKontrol();
            if (alarm <= 0) return;
            if (InvokeRequired) BeginInvoke(new MethodInvoker(GidenEvraklarKontrol));
            else
            {
                alertControl.Show(this, new AlertInfo("Giden Evraklar", String.Format("{0} adet evrak için zaman yaklaştı.", alarm)));
                alertControl.AlertClick += alertControl_AlertClick;
            }
        }

        /// <summary>
        /// Süresi gelen gelen evrakların kontrolü yapılır
        /// </summary>
        private void GelenEvraklarKontrol()
        {
            var alarm = new Alarm().GelenEvraklarKontrol();
            if (alarm <= 0) return;
            if (InvokeRequired) BeginInvoke(new MethodInvoker(GelenEvraklarKontrol));
            else
            {
                alertControl.Show(this, new AlertInfo("Gelen Evraklar", String.Format("{0} adet evrak için zaman yaklaştı.", alarm)));
                alertControl.AlertClick += alertControl_AlertClick;
            }
        }

        /// <summary>
        /// Çıkan alarm a tıklandığında ilgili ekrana gönderir.
        /// </summary>
        private void alertControl_AlertClick(object sender, AlertClickEventArgs e)
        {
            // : Tıklanan alarm
            var caption = e.Info.Caption;
            if (caption.Contains("Gelen"))
            {
                var child = new GelenEvraklar(true) {MdiParent = this};
                child.Show();
            }
            else if (caption.Contains("Giden"))
            {
                var child = new GidenEvraklar(true) {MdiParent = this};
                child.Show();
            }
            else if (caption.Contains("Daimi Arama"))
            {
                var child = new OlayListesi(true) {MdiParent = this};
                child.Show();
            }
        }

        /// <summary>
        /// MDI formlar açılırken ribbon menüler birleştirilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ribbonControl_Merge(object sender, RibbonMergeEventArgs e)
        {
            var mergedRibbon = e.MergeOwner.MergedRibbon;
            if (mergedRibbon != null) ribbonControl.SelectedPage = mergedRibbon.SelectedPage;
        }

        /// <summary>
        /// Gelen Giden Evrak İstatistik verileri hazırlanır ve raporu çıkartılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIstatistikler_ItemClick(object sender, ItemClickEventArgs e){
            var istatistikGelenGidenEvrak = new XtraReport();
            istatistikGelenGidenEvrak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\GelenGidenIstatistik.repx");
            
            var dataSource = new GelenGidenIstatistik().Hazirla(int.Parse(brIstYil.EditValue.ToString()));
            istatistikGelenGidenEvrak.DataSource = dataSource;
            
            if (dataSource.Count <= 0)
            {
                XtraMessageBox.Show("Gösterilecek kayıt bulunamadı.");
                return;
            }
            istatistikGelenGidenEvrak.ShowRibbonPreviewDialog();
        }
        
        /// <summary>
        /// Ana Ekran kapatılırken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmadan önce güncel bir yedekleme yapılsın mı?", "Yedekleme", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            using (var yd = new YedekIslemleri())
            {
                yd.Yedekle();
            }
        }

        /// <summary>
        /// Veritabanı bağlantısı yapılamadı ise yeni yol istenir ve yeni yol kayıt edilir.
        /// </summary>
        /// <returns></returns>
        private static bool VeritabaniKontrol()
        {
            var config = ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.FriendlyName.Replace("vshost.", ""));
            var match = Regex.Match(config.ConnectionStrings.ConnectionStrings["ETSEntities"].ConnectionString, @"""[\s\S]+", RegexOptions.IgnoreCase).Value;
            var cs = config.ConnectionStrings.ConnectionStrings["ETSEntities"].ConnectionString;

            using (var db = new ETSEntities())
            {
                if (db.Database.Exists()) return true;
                XtraMessageBox.Show("Veritabanı bulunamadı...");
                FileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Lütfen veritabanının yolunu seçiniz.";
                fileDialog.Filter = "Veri Tabanı Dosyası |*.sdf";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dosyaAdi = fileDialog.FileName;
                    config.ConnectionStrings.ConnectionStrings["ETSEntities"].ConnectionString = cs.Replace(match, "data source=" + dosyaAdi);
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection("connectionStrings");
                    Process.Start(Application.ExecutablePath);
                    Process.GetCurrentProcess().Kill();
                    return false;
                }
                Process.GetCurrentProcess().Kill();
            }
            return false;
        }

        /// <summary>
        /// Müzekkere İcmal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniMuzekkereIcmal_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Müzekkere İcmal" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new YeniMuzekkereIcmal(new KayitDuzenleDTO {Duzenleme = false}) {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Müzekkere İcmaller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMuzekkereIcmalDefteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Müzekkere İcmaller" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new MuzekkereIcmaller {MdiParent = this};
            child.Show();
        }

        /// <summary>
        /// Hakkında
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHakkinda_ItemClick(object sender, ItemClickEventArgs e)
        {
            var hakkinda = new Hakkinda();
            hakkinda.ShowDialog();
        }

        /// <summary>
        /// Yeni Arşiv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniArsiv_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Yeni Gelen Giden Arşiv" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new YeniGelenGidenArsiv(new KayitDuzenleDTO{Duzenleme = false}) { MdiParent = this };
            child.Show();
        }

        /// <summary>
        /// Gelen Giden Arşiv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGelenGidenArsiv_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Arşiv Gelen Giden Evraklar" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new ArsivGelenGidenEvraklar { MdiParent = this };
            child.Show();
        }

        /// <summary>
        /// Yeni olay girişi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniOlay_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Yeni Olay Bilgisi" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new YeniOlayBilgisi(new KayitDuzenleDTO { Duzenleme = false }) { MdiParent = this };
            child.Show();
        }

        /// <summary>
        /// Olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOlaylar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Olay Bilgileri" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new OlayBilgileri { MdiParent = this };
            child.Show();
        }

        /// <summary>
        /// Tasnifler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTasnifler_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isOpen = false;
            foreach (var f in from Form f in Application.OpenForms where f.Text == "Tasnifler" select f)
            {
                isOpen = true;
                f.Focus();
                break;
            }
            if (isOpen) return;
            var child = new TasnifAyarlari { MdiParent = this };
            child.Show();
        }

        /// <summary>
        /// Alarmları tetikler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGunuGelenEvraklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            AlarmlariKontrolEt();}

        /// <summary>
        /// Siyah görünüm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiyahTema_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
        }

        /// <summary>
        /// Renkli görünüm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRenkliTema_ItemClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SetDefaultStyle();
        }
    }
}