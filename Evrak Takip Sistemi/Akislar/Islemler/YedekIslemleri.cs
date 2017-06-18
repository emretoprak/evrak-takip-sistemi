using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ETS.Akislar.Islemler
{
    using System;
    using System.Configuration;
    using System.IO;

    /// <summary>
    /// Yedekleme işlemlerini yapan sınıf
    /// </summary>
    public class YedekIslemleri : IDisposable
    {
        // : Yedekleme dizini config dosyasında bulunuyor.
        private readonly string _yedekDizini = ConfigurationManager.AppSettings["YedekDizini"].Replace("|DataDirectory|", AppDomain.CurrentDomain.BaseDirectory);

        /// <summary>
        /// Yedekeleme yapan fonksiyon
        /// </summary>
        public void Yedekle()
        {
            var cs = VeritabaniYolu();
            if (string.IsNullOrEmpty(cs)) throw new Exception("App.config dosyasında bulunan connectionStrings bulunamadı veya doğru girilmemiş. \nLütfen doğruluğunu kontrol ediniz.");
            if (!Directory.Exists(_yedekDizini)) Directory.CreateDirectory(_yedekDizini);
            File.Copy(cs, _yedekDizini + "Yedek_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".sdf");
        }

        /// <summary>
        /// Seçili yedekten geri döner
        /// </summary>
        /// <param name="geriAlinacakYedek"></param>
        public void YedektenGeriDon(string geriAlinacakYedek)
        {
            var cs = VeritabaniYolu();
            File.Copy(geriAlinacakYedek, cs, true);
            Process.Start(Application.ExecutablePath);
            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// Veritabanı yolunu getirir
        /// </summary>
        /// <returns></returns>
        private static string VeritabaniYolu()
        {
            var conns = ConfigurationManager.ConnectionStrings["ETSEntities"].ConnectionString.Split('=');
            var cs = string.Empty;
            for (var i = 0; i < conns.Length; i++) if (conns[i].Contains("data source")) cs = conns[i + 1];
            var invalidChars = Path.GetInvalidPathChars();
            cs = invalidChars.Aggregate(cs, (current, t) => current.Replace(t.ToString(CultureInfo.InvariantCulture), ""));
            return Path.GetFullPath(cs);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            // already disposed
        }
    }
}
