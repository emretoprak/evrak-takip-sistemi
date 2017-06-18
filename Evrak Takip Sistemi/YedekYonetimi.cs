using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ETS.Akislar.Islemler;

namespace ETS
{
    public partial class YedekYonetimi : Form
    {
        private readonly string _yedekDizini = ConfigurationManager.AppSettings["YedekDizini"].Replace("|DataDirectory|", AppDomain.CurrentDomain.BaseDirectory);

        public YedekYonetimi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form yüklenirken dizin kontolleri yapılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YedekYonetimi_Load(object sender, EventArgs e)
        {
            // : Dizin yoksa oluştur
            if (!Directory.Exists(_yedekDizini))
            {
                Directory.CreateDirectory(_yedekDizini);
            }

            YedekleriKontrolEt();
        }

        /// <summary>
        /// Yedekle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimdiYedekle_Click(object sender, EventArgs e)
        {
            using (var yd = new YedekIslemleri())
            {
                yd.Yedekle();
            }
            YedekleriKontrolEt();
        }

        /// <summary>
        /// Yedek dizininde bulunan yedekleri listeye aktarır
        /// </summary>
        private void YedekleriKontrolEt()
        {
            lstYedekler.Items.Clear();
            var di = new DirectoryInfo(_yedekDizini);
            var directories = di.GetFiles("*.sdf", SearchOption.TopDirectoryOnly);
            foreach (var d in directories)
            {
                lstYedekler.Items.Add(d.FullName,0);
            }
        }

        /// <summary>
        /// Yedekten geri al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (lstYedekler.SelectedValue == null) return;

            if (MessageBox.Show("Yedek almadayısanız mevcut kayıtlı verileriniz kaybolacak emin misiniz?", "Onay", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var geriAlinacakYedek = lstYedekler.SelectedValue.ToString();
            using (var yd = new YedekIslemleri())
            {
                yd.YedektenGeriDon(geriAlinacakYedek);
            }
        }

        /// <summary>
        /// Yedeğe çift tıklandığında dosya yolunu açar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstYedekler_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(@"" + Path.GetDirectoryName(lstYedekler.SelectedValue.ToString()));
        }
    }
}