using ETS.VeriKatmani;
using System;
using System.Data.Entity;
using System.Linq;

namespace ETS.Akislar.Alarmlar
{
    public class Alarm
    {
        /// <summary>
        /// Süresi gelmiş Gelen evrakları kontrol eder
        /// Veri tabanında ayarlar bölümünde "GelenEvrakKontrolSuresi" kontrol edilecek ek gün sayısını belirler buna göre kontrol yapılır.
        /// </summary>
        /// <returns></returns>
        public int GelenEvraklarKontrol()
        {
            using (var db = new ETSEntities())
            {
                var ayarlar = db.Ayarlar.SingleOrDefault();
                var ekGun = ayarlar == null ? 0 : int.Parse(ayarlar.GelenEvrakKontrolSuresi.ToString());
                return db.GelenEvrak.Count(x => x.EvrakSonTarihi <= DbFunctions.AddDays(DateTime.Now, ekGun) && x.Durum == 0);
            }
        }

        /// <summary>
        /// Süresi gelmiş Daimi Aramaları kontrol eder
        /// Veri tabanında ayarlar bölümünde "DaimiAramaKontrolSuresi" kontrol edilecek ek gün sayısını belirler buna göre kontrol yapılır.
        /// </summary>
        /// <returns></returns>
        public int DaimiAramaTKontrol()
        {
            using (var db = new ETSEntities())
            {
                var ayarlar = db.Ayarlar.SingleOrDefault();
                var ekGun = ayarlar == null ? 0 : int.Parse(ayarlar.DaimiAramaKontrolSuresi.ToString());
                return db.DaimiArastirmaTutanaklari.Count(x => x.ZamanAsimi <= DbFunctions.AddDays(DateTime.Now, ekGun));
            }
        }

        /// <summary>
        /// Süresi gelmiş Giden evrakları kontrol eder
        /// Veri tabanında ayarlar bölümünde "GidenEvrakKontrolSuresi" kontrol edilecek ek gün sayısını belirler buna göre kontrol yapılır.
        /// </summary>
        /// <returns></returns>
        public int GidenEvraklarKontrol()
        {
            using (var db = new ETSEntities())
            {
                var ayarlar = db.Ayarlar.SingleOrDefault();
                var ekGun = ayarlar == null ? 0 : int.Parse(ayarlar.GidenEvrakKontrolSuresi.ToString());
                return db.GidenEvrak.Count(x => x.EvrakSonTarihi <= DbFunctions.AddDays(DateTime.Now, ekGun) && x.Durum == 0);
            }
        }
    }
}
