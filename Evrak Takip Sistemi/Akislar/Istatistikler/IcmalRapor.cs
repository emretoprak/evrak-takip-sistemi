namespace ETS.Akislar.Istatistikler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO;
    using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;
    using ETS.VeriKatmani;

    /// <summary>
    /// İcmal rapor hazırlama sınıfı
    /// </summary>
    public class IcmalRapor
    {
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();
        internal int GiyabiTevkifID = 4; //int.Parse(ConfigurationManager.AppSettings["GiyabiTevkifId"]);
        internal int HapsenTazyikID = 3; //int.Parse(ConfigurationManager.AppSettings["HapsenTazyikId"]);
        internal int KemerKarakolID = 2; //int.Parse(ConfigurationManager.AppSettings["KemerKarakolId"]);
        internal int MerkezKarakolID = 1; //int.Parse(ConfigurationManager.AppSettings["MerkezKarakolId"]);
        internal int YakalamaKarariID = 2; //int.Parse(ConfigurationManager.AppSettings["YakalamaKarariId"]);
        internal int ZorlaGetirmeKarariID = 1; //int.Parse(ConfigurationManager.AppSettings["ZorlaGetirmeKarariId"]);

        /// <summary>
        /// Aylık icmal hazırlayan fonksiyon
        /// </summary>
        /// <param name="yil">Yıl</param>
        /// <param name="ay">Ay</param>
        /// <param name="tanzimEdenId">Tanzim eden personel ID</param>
        /// <param name="tastikEdenId">Tastik eden personel ID</param>
        /// <returns></returns>
        public List<IcmalAylikRaporDTO> Aylik(int yil, string ay, int tanzimEdenId, int tastikEdenId)
        {
            var istatistik = new List<IcmalAylikRaporDTO>();

            using (var db = new ETSEntities())
            {
                BaslangicTarihi = new DateTime(yil, 01, 01);
                BitisTarihi = new DateTime(yil, 12, 31);

                var icmaller = db.MuzekkereIcmalDefteri.Where(w => BaslangicTarihi <= w.GeldigiTarih && BitisTarihi >= w.GeldigiTarih).ToList();
                var tanzimEden = db.Personel.SingleOrDefault(s => s.Id == tanzimEdenId);
                var tastikEden = db.Personel.SingleOrDefault(s => s.Id == tastikEdenId);

                var seciliAy = AyHesapla(ay);
                var indexAy = 1;
                var toplamAy = 13;
                if (seciliAy > 0)
                {
                    indexAy = seciliAy;
                    toplamAy = seciliAy + 1;
                }

                // : Tüm aylar
                var indexIstatistik = 0;
                for (var i = indexAy; i < toplamAy; i++, indexIstatistik++)
                {
                    var ayAdi = Regex.Replace(new DateTime(2000, i, 1).ToString("M"), "[0-9.] ", "");

                    var aylikIcmalRapor = new IcmalAylikRaporDTO();
                    aylikIcmalRapor.IcmalAyi = ayAdi.ToUpper();
                    aylikIcmalRapor.IcmalYili = yil;

                    aylikIcmalRapor.TanzimEdenIsim = tanzimEden.AdiSoyadi;
                    aylikIcmalRapor.TanzimEdenRutbe = tanzimEden.Rutbesi;
                    aylikIcmalRapor.TanzimEdenTim = tanzimEden.Tim;
                    aylikIcmalRapor.TastikEdenIsim = tastikEden.AdiSoyadi;
                    aylikIcmalRapor.TastikEdenRutbe = tastikEden.Rutbesi;
                    aylikIcmalRapor.TastikEdenTim = tastikEden.Tim;

                    aylikIcmalRapor.AyicindeGelen = new AyicindeGelenDTO();
                    aylikIcmalRapor.AyicindeGelen.KgTevkif = icmaller.Count(w => w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == GiyabiTevkifID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.KhTazyik = icmaller.Count(w => w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == HapsenTazyikID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.KYakalama = icmaller.Count(w => w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == YakalamaKarariID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.KZorlaGetirme = icmaller.Count(w => w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == ZorlaGetirmeKarariID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.MgTevkif = icmaller.Count(w => w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == GiyabiTevkifID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.MhTazyik = icmaller.Count(w => w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == HapsenTazyikID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.MYakalama = icmaller.Count(w => w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == YakalamaKarariID && w.GeldigiTarih.Month == i);
                    aylikIcmalRapor.AyicindeGelen.MZorlaGetirme = icmaller.Count(w => w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == ZorlaGetirmeKarariID && w.GeldigiTarih.Month == i);

                    aylikIcmalRapor.GecenAyDevir = new GecenAyDevirDTO();
                    aylikIcmalRapor.GecenAyDevir.KgTevkif = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.KgTevkif;
                    aylikIcmalRapor.GecenAyDevir.KhTazyik = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.KhTazyik;
                    aylikIcmalRapor.GecenAyDevir.KYakalama = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.KYakalama;
                    aylikIcmalRapor.GecenAyDevir.KZorlaGetirme = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.KZorlaGetirme;
                    aylikIcmalRapor.GecenAyDevir.MgTevkif = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.MgTevkif;
                    aylikIcmalRapor.GecenAyDevir.MhTazyik = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.MhTazyik;
                    aylikIcmalRapor.GecenAyDevir.MYakalama = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.MYakalama;
                    aylikIcmalRapor.GecenAyDevir.MZorlaGetirme = i == 1 ? 0 : istatistik[indexIstatistik - 1].BirSonrakiAyaDevir.MZorlaGetirme;

                    aylikIcmalRapor.InfazMevcuten = new InfazMevcutenDTO();
                    aylikIcmalRapor.InfazMevcuten.KgTevkif = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == GiyabiTevkifID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.KhTazyik = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == HapsenTazyikID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.KYakalama = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == YakalamaKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.KZorlaGetirme = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == ZorlaGetirmeKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.MgTevkif = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == GiyabiTevkifID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.MhTazyik = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == HapsenTazyikID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.MYakalama = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == YakalamaKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));
                    aylikIcmalRapor.InfazMevcuten.MZorlaGetirme = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == ZorlaGetirmeKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 1));

                    aylikIcmalRapor.InfazMuameleten = new InfazMuameletenDTO();
                    aylikIcmalRapor.InfazMuameleten.KgTevkif = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == GiyabiTevkifID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.KhTazyik = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == HapsenTazyikID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.KYakalama = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == YakalamaKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.KZorlaGetirme = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == KemerKarakolID && w.MuzekkereCinsiId == ZorlaGetirmeKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.MgTevkif = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == GiyabiTevkifID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.MhTazyik = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == HapsenTazyikID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.MYakalama = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == YakalamaKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));
                    aylikIcmalRapor.InfazMuameleten.MZorlaGetirme = icmaller.Count(w => w.GonderildigiTarih != null && (w.KomutanlikId == MerkezKarakolID && w.MuzekkereCinsiId == ZorlaGetirmeKarariID && w.GeldigiTarih.Month <= i && w.GonderildigiTarih.Value.Month == i && w.Durum == 0));

                    var kgTevkif = (aylikIcmalRapor.GecenAyDevir.KgTevkif + aylikIcmalRapor.AyicindeGelen.KgTevkif) - (aylikIcmalRapor.InfazMevcuten.KgTevkif + aylikIcmalRapor.InfazMuameleten.KgTevkif);
                    var khTazyik =(aylikIcmalRapor.GecenAyDevir.KhTazyik + aylikIcmalRapor.AyicindeGelen.KhTazyik) - (aylikIcmalRapor.InfazMevcuten.KhTazyik + aylikIcmalRapor.InfazMuameleten.KhTazyik);
                    var kYakalama = (aylikIcmalRapor.GecenAyDevir.KYakalama + aylikIcmalRapor.AyicindeGelen.KYakalama) - (aylikIcmalRapor.InfazMevcuten.KYakalama + aylikIcmalRapor.InfazMuameleten.KYakalama);
                    var kZorlaGetirme =(aylikIcmalRapor.GecenAyDevir.KZorlaGetirme + aylikIcmalRapor.AyicindeGelen.KZorlaGetirme) - (aylikIcmalRapor.InfazMevcuten.KZorlaGetirme + aylikIcmalRapor.InfazMuameleten.KZorlaGetirme);
                    var mgTevkif = (aylikIcmalRapor.GecenAyDevir.MgTevkif + aylikIcmalRapor.AyicindeGelen.MgTevkif) - (aylikIcmalRapor.InfazMevcuten.MgTevkif + aylikIcmalRapor.InfazMuameleten.MgTevkif);
                    var mhTazyik = (aylikIcmalRapor.GecenAyDevir.MhTazyik + aylikIcmalRapor.AyicindeGelen.MhTazyik) - (aylikIcmalRapor.InfazMevcuten.MhTazyik + aylikIcmalRapor.InfazMuameleten.MhTazyik);
                    var mYakalama = (aylikIcmalRapor.GecenAyDevir.MYakalama + aylikIcmalRapor.AyicindeGelen.MYakalama) - (aylikIcmalRapor.InfazMevcuten.MYakalama + aylikIcmalRapor.InfazMuameleten.MYakalama);
                    var mZorlaGetirme = (aylikIcmalRapor.GecenAyDevir.MZorlaGetirme + aylikIcmalRapor.AyicindeGelen.MZorlaGetirme) - (aylikIcmalRapor.InfazMevcuten.MZorlaGetirme + aylikIcmalRapor.InfazMuameleten.MZorlaGetirme);

                    aylikIcmalRapor.BirSonrakiAyaDevir = new BirSonrakiAyaDevirDTO();
                    aylikIcmalRapor.BirSonrakiAyaDevir.KgTevkif = kgTevkif;
                    aylikIcmalRapor.BirSonrakiAyaDevir.KhTazyik = khTazyik;
                    aylikIcmalRapor.BirSonrakiAyaDevir.KYakalama = kYakalama;
                    aylikIcmalRapor.BirSonrakiAyaDevir.KZorlaGetirme = kZorlaGetirme;
                    aylikIcmalRapor.BirSonrakiAyaDevir.MgTevkif = mgTevkif;
                    aylikIcmalRapor.BirSonrakiAyaDevir.MhTazyik = mhTazyik;
                    aylikIcmalRapor.BirSonrakiAyaDevir.MYakalama = mYakalama;
                    aylikIcmalRapor.BirSonrakiAyaDevir.MZorlaGetirme = mZorlaGetirme;

                    istatistik.Add(aylikIcmalRapor);

                    // : AyicindeGelen
                    istatistik[indexIstatistik].AyicindeGelen.TgTevkif = istatistik[indexIstatistik].AyicindeGelen.MgTevkif + istatistik[indexIstatistik].AyicindeGelen.KgTevkif;
                    istatistik[indexIstatistik].AyicindeGelen.ThTazyik = istatistik[indexIstatistik].AyicindeGelen.MhTazyik + istatistik[indexIstatistik].AyicindeGelen.KhTazyik;
                    istatistik[indexIstatistik].AyicindeGelen.TYakalama = istatistik[indexIstatistik].AyicindeGelen.MYakalama + istatistik[indexIstatistik].AyicindeGelen.KYakalama;
                    istatistik[indexIstatistik].AyicindeGelen.TZorlaGetirme = istatistik[indexIstatistik].AyicindeGelen.MZorlaGetirme + istatistik[indexIstatistik].AyicindeGelen.KZorlaGetirme;
                    // : BirSonrakiAyaDevir
                    istatistik[indexIstatistik].BirSonrakiAyaDevir.TgTevkif = istatistik[indexIstatistik].BirSonrakiAyaDevir.MgTevkif + istatistik[indexIstatistik].BirSonrakiAyaDevir.KgTevkif;
                    istatistik[indexIstatistik].BirSonrakiAyaDevir.ThTazyik = istatistik[indexIstatistik].BirSonrakiAyaDevir.MhTazyik + istatistik[indexIstatistik].BirSonrakiAyaDevir.KhTazyik;
                    istatistik[indexIstatistik].BirSonrakiAyaDevir.TYakalama = istatistik[indexIstatistik].BirSonrakiAyaDevir.MYakalama + istatistik[indexIstatistik].BirSonrakiAyaDevir.KYakalama;
                    istatistik[indexIstatistik].BirSonrakiAyaDevir.TZorlaGetirme = istatistik[indexIstatistik].BirSonrakiAyaDevir.MZorlaGetirme + istatistik[indexIstatistik].BirSonrakiAyaDevir.KZorlaGetirme;
                    // : GecenAyDevir
                    istatistik[indexIstatistik].GecenAyDevir.TgTevkif = istatistik[indexIstatistik].GecenAyDevir.MgTevkif + istatistik[indexIstatistik].GecenAyDevir.KgTevkif;
                    istatistik[indexIstatistik].GecenAyDevir.ThTazyik = istatistik[indexIstatistik].GecenAyDevir.MhTazyik + istatistik[indexIstatistik].GecenAyDevir.KhTazyik;
                    istatistik[indexIstatistik].GecenAyDevir.TYakalama = istatistik[indexIstatistik].GecenAyDevir.MYakalama + istatistik[indexIstatistik].GecenAyDevir.KYakalama;
                    istatistik[indexIstatistik].GecenAyDevir.TZorlaGetirme = istatistik[indexIstatistik].GecenAyDevir.MZorlaGetirme + istatistik[indexIstatistik].GecenAyDevir.KZorlaGetirme;
                    // : InfazMevcuten
                    istatistik[indexIstatistik].InfazMevcuten.TgTevkif = istatistik[indexIstatistik].InfazMevcuten.MgTevkif + istatistik[indexIstatistik].InfazMevcuten.KgTevkif;
                    istatistik[indexIstatistik].InfazMevcuten.ThTazyik = istatistik[indexIstatistik].InfazMevcuten.MhTazyik + istatistik[indexIstatistik].InfazMevcuten.KhTazyik;
                    istatistik[indexIstatistik].InfazMevcuten.TYakalama = istatistik[indexIstatistik].InfazMevcuten.MYakalama + istatistik[indexIstatistik].InfazMevcuten.KYakalama;
                    istatistik[indexIstatistik].InfazMevcuten.TZorlaGetirme = istatistik[indexIstatistik].InfazMevcuten.MZorlaGetirme + istatistik[indexIstatistik].InfazMevcuten.KZorlaGetirme;
                    // : InfazMuameleten
                    istatistik[indexIstatistik].InfazMuameleten.TgTevkif = istatistik[indexIstatistik].InfazMuameleten.MgTevkif + istatistik[indexIstatistik].InfazMuameleten.KgTevkif;
                    istatistik[indexIstatistik].InfazMuameleten.ThTazyik = istatistik[indexIstatistik].InfazMuameleten.MhTazyik + istatistik[indexIstatistik].InfazMuameleten.KhTazyik;
                    istatistik[indexIstatistik].InfazMuameleten.TYakalama = istatistik[indexIstatistik].InfazMuameleten.MYakalama + istatistik[indexIstatistik].InfazMuameleten.KYakalama;
                    istatistik[indexIstatistik].InfazMuameleten.TZorlaGetirme = istatistik[indexIstatistik].InfazMuameleten.MZorlaGetirme + istatistik[indexIstatistik].InfazMuameleten.KZorlaGetirme;
                }
            }

            return istatistik;
        }

        /// <summary>
        /// Yıllık icmal hazırlayan fonksiyon
        /// </summary>
        /// <param name="yil">Yıl</param>
        /// <param name="tanzimEdenId">Tanzim eden personel ID</param>
        /// <param name="tastikEdenId">Tastik eden personel ID</param>
        /// <returns></returns>
        internal List<IcmalYillikRaporDTO> Yillik(int yil, int tanzimEdenId, int tastikEdenId)
        {
            var aylikDataSource = Aylik(yil, "Hepsi", tanzimEdenId, tastikEdenId);

            var istatistikler = new List<IcmalYillikRaporDTO>();

            var istatistik = new IcmalYillikRaporDTO
            {
                IcmalYili = yil,
                TanzimEdenIsim = aylikDataSource[0].TanzimEdenIsim,
                TanzimEdenRutbe = aylikDataSource[0].TanzimEdenRutbe,
                TanzimEdenTim = aylikDataSource[0].TanzimEdenTim,
                TastikEdenIsim = aylikDataSource[0].TastikEdenIsim,
                TastikEdenRutbe = aylikDataSource[0].TastikEdenRutbe,
                TastikEdenTim = aylikDataSource[0].TastikEdenTim,
                RaporAylari = new List<AylarDTO>()
            };

            foreach (var t in aylikDataSource)
            {
                istatistik.RaporAylari.Add(new AylarDTO
                {
                    Ay = t.IcmalAyi,
                    AyiciGelenGiyabiTevkif = t.AyicindeGelen.TgTevkif,
                    AyiciGelenTazyik = t.AyicindeGelen.ThTazyik,
                    AyiciGelenYakalama = t.AyicindeGelen.TYakalama,
                    AyiciGelenZorlaGetirme = t.AyicindeGelen.TZorlaGetirme,
                    BirsonrakiAyaDevirGiyabiTevkif = t.BirSonrakiAyaDevir.TgTevkif,
                    BirsonrakiAyaDevirTazyik = t.BirSonrakiAyaDevir.ThTazyik,
                    BirsonrakiAyaDevirYakalama = t.BirSonrakiAyaDevir.TYakalama,
                    BirsonrakiAyaDevirZorlaGetirme = t.BirSonrakiAyaDevir.TZorlaGetirme,
                    GecenAyDevirGiyabiTevkif = t.GecenAyDevir.TgTevkif,
                    GecenAyDevirTazyik = t.GecenAyDevir.ThTazyik,
                    GecenAyDevirYakalama = t.GecenAyDevir.TYakalama,
                    GecenAyDevirZorlaGetirme = t.GecenAyDevir.TZorlaGetirme,
                    MevcudenGiyabiTevkif = t.InfazMevcuten.TgTevkif,
                    MevcudenTazyik = t.InfazMevcuten.ThTazyik,
                    MevcudenYakalama = t.InfazMevcuten.TYakalama,
                    MevcudenZorlaGetirme = t.InfazMevcuten.TZorlaGetirme,
                    MuameletenGiyabiTevkif = t.InfazMuameleten.TgTevkif,
                    MuameletenTazyik = t.InfazMuameleten.ThTazyik,
                    MuameletenYakalama = t.InfazMuameleten.TYakalama,
                    MuameletenZorlaGetirme = t.InfazMuameleten.TZorlaGetirme
                }
                    );
            }

            // : Genel Toplamlar
            istatistik.AyiciToplamGiyabiTevkif = istatistik.RaporAylari.Sum(w => w.AyiciGelenGiyabiTevkif);
            istatistik.AyiciToplamTazyik = istatistik.RaporAylari.Sum(w => w.AyiciGelenTazyik);
            istatistik.AyiciToplamYakalama = istatistik.RaporAylari.Sum(w => w.AyiciGelenYakalama);
            istatistik.AyiciToplamZorlaGetirme = istatistik.RaporAylari.Sum(w => w.AyiciGelenZorlaGetirme);

            istatistik.BirsonrakiAyaDevirToplamGiyabiTevkif = istatistik.RaporAylari.Sum(w => w.BirsonrakiAyaDevirGiyabiTevkif);
            istatistik.BirsonrakiAyaDevirToplamTazyik = istatistik.RaporAylari.Sum(w => w.BirsonrakiAyaDevirTazyik);
            istatistik.BirsonrakiAyaDevirToplamYakalama = istatistik.RaporAylari.Sum(w => w.BirsonrakiAyaDevirYakalama);
            istatistik.BirsonrakiAyaDevirToplamZorlaGetirme = istatistik.RaporAylari.Sum(w => w.BirsonrakiAyaDevirZorlaGetirme);

            istatistik.GecenAyToplamGiyabiTevkif = istatistik.RaporAylari.Sum(w => w.GecenAyDevirGiyabiTevkif);
            istatistik.GecenAyToplamTazyik = istatistik.RaporAylari.Sum(w => w.GecenAyDevirTazyik);
            istatistik.GecenAyToplamYakalama = istatistik.RaporAylari.Sum(w => w.GecenAyDevirYakalama);
            istatistik.GecenAyToplamZorlaGetirme = istatistik.RaporAylari.Sum(w => w.GecenAyDevirZorlaGetirme);

            istatistik.MevcudenToplamGiyabiTevkif = istatistik.RaporAylari.Sum(w => w.MevcudenGiyabiTevkif);
            istatistik.MevcudenToplamTazyik = istatistik.RaporAylari.Sum(w => w.MevcudenTazyik);
            istatistik.MevcudenToplamYakalama = istatistik.RaporAylari.Sum(w => w.MevcudenYakalama);
            istatistik.MevcudenToplamZorlaGetirme = istatistik.RaporAylari.Sum(w => w.MevcudenZorlaGetirme);

            istatistik.MuameletenToplamGiyabiTevkif = istatistik.RaporAylari.Sum(w => w.MuameletenGiyabiTevkif);
            istatistik.MuameletenToplamTazyik = istatistik.RaporAylari.Sum(w => w.MuameletenTazyik);
            istatistik.MuameletenToplamYakalama = istatistik.RaporAylari.Sum(w => w.MuameletenYakalama);
            istatistik.MuameletenToplamZorlaGetirme = istatistik.RaporAylari.Sum(w => w.MuameletenZorlaGetirme);

            istatistikler.Add(istatistik);

            return istatistikler;
        }

        /// <summary>
        /// Gönderilen ayın ismini rakamsal halini geri döndürür
        /// </summary>
        /// <param name="ay">Ay ismi</param>
        /// <returns>Ay rakamı</returns>
        internal int AyHesapla(string ay)
        {
            switch (ay)
            {
                case "Hepsi":
                    return 0;
                case "Ocak":
                    return 1;
                case "Şubat":
                    return 2;
                case "Mart":
                    return 3;
                case "Nisan":
                    return 4;
                case "Mayıs":
                    return 5;
                case "Haziran":
                    return 6;
                case "Temmuz":
                    return 7;
                case "Ağustos":
                    return 8;
                case "Eylül":
                    return 9;
                case "Ekim":
                    return 10;
                case "Kasım":
                    return 11;
                case "Aralık":
                    return 12;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Yıllık raporu hazırlar
        /// </summary>
        /// <returns></returns>
        internal List<IcmalTumYillarRaporDTO> Yilliklar(int yil)
        {

            var baslangicTarihi = new DateTime(yil, 01, 01);
            var bitisTarihi = new DateTime(yil, 12, 31);

            var istatistikler = new List<IcmalTumYillarRaporDTO>();
            var raporYillari = new List<YillarDTO>();
            using (var db = new ETSEntities())
            {
                var tumYillar = db.MuzekkereIcmalDefteri.Where(w => baslangicTarihi <= w.GeldigiTarih && bitisTarihi >= w.GeldigiTarih).GroupBy(p => p.GeldigiTarih.Year).Select(g => new { Yil = g.Key, Toplam = g.Count(), Mevcuten = g.Count(w => w.Durum == 1), Muameleten = g.Count(w => w.Durum == 0) });

                if (tumYillar.ToList().Count == 0)
                {
                    raporYillari.Add(new YillarDTO
                    {
                        Yil = yil,
                        Toplam = 0,
                        Mevcuden = 0,
                        Muameleten = 0
                    });
                }
                else
                {
                    raporYillari.AddRange(tumYillar.Select(t => new YillarDTO
                    {
                        Yil = t.Yil,
                        Toplam = t.Toplam,
                        Mevcuden = t.Mevcuten,
                        Muameleten = t.Muameleten
                    }));
                }
            
                istatistikler.Add(new IcmalTumYillarRaporDTO
                {
                    RaporYillari = raporYillari,
                    GenelToplam = new GenelToplamDTO
                    {
                        Mevcuden = raporYillari.Sum(s => s.Mevcuden),
                        Muameleten = raporYillari.Sum(s => s.Muameleten),
                        Toplam = raporYillari.Sum(s => s.Toplam)
                    }
                });
            }

            return istatistikler;
        }
    }
}