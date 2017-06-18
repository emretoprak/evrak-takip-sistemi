namespace ETS.Akislar.Istatistikler
{
    using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO;
    using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;
    using ETS.VeriKatmani;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Gelen Giden evrakların istatistik çıkartma sınıfı
    /// </summary>
    public class GelenGidenIstatistik
    {
        internal int FmToplam = 0;
        internal int AisToplam = 0;
        internal int AileiciSiddetId = 6; //int.Parse(ConfigurationManager.AppSettings["AileiciSiddetId"]);
        internal int FailiMechulId = 5; //int.Parse(ConfigurationManager.AppSettings["FailiMechulId"]);
        internal DateTime BaslangicTarihi = new DateTime();
        internal DateTime BitisTarihi = new DateTime();

        /// <summary>
        /// İstatistik hazırlama fonksiyonu
        /// </summary>
        /// <param name="yil">istatistik yılı</param>
        /// <returns></returns>
        public List<GelenGidenIstatistiklerDTO> Hazirla(int yil)
        {
            var istatistik = new List<GelenGidenIstatistiklerDTO>();
            using (var db = new ETSEntities())
            {
                BaslangicTarihi = new DateTime(yil, 01, 01);
                BitisTarihi = new DateTime(yil, 12, 31);
                var personel = db.GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Select(x => x.Personel).Distinct().ToList();
                istatistik.AddRange(personel.Select(p => new GelenGidenIstatistiklerDTO
                {
                    Istatistikler = new List<IstatistikDTO>
                    {
                        new IstatistikDTO
                        {
                            PersonelAdi = p.TamIsim, PersonelEvrakSayisi = db.GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(c => c.PersonelId == p.Id),
                            FmOlaySayisi = db.GidenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(c => c.OlayDurumuId == FailiMechulId && c.PersonelId == p.Id), 
                            Gitmedi = db.GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(c => c.Durum != 1 && c.PersonelId == p.Id), 
                            Gitti = db.GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(c => c.Durum == 1 && c.PersonelId == p.Id), 
                            MudahaleEttigiOlaySayisi = db.GidenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(c => c.PersonelId == p.Id), 
                            MahalleEvraklari = MahalleEvraklari(p.Id),
                        }
                    },
                    GenelToplam = new List<ToplamDTO>
                    {
                      new ToplamDTO
                      {
                          AisToplam = AisToplam,
                          FmToplam = FmToplam
                      }  
                    },
                    KoylerdekiOlaySayilari = MahalleOlaylari(p.Id)
                }));
            }
            return istatistik;
        }

        /// <summary>
        /// Mahalle evrakları
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        internal List<MahalleEvraklariDTO> MahalleEvraklari(int id)
        {
            var mahalleEvraklari = new List<MahalleEvraklariDTO>();
            using (var db = new ETSEntities())
            {
                FmToplam = 0;
                AisToplam = 0;

                var evrak = db.GelenEvrak.Where(w => w.PersonelId == id && BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).GroupBy(g => g.OlayYerleri).OrderBy(o => o.Key.OlayYeri);

                foreach (var e in evrak)
                {
                    var aisSayisi = db.GelenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(w => w.PersonelId == id && w.OlayDurumuId == AileiciSiddetId && w.OlayYeriId == e.Key.Id);
                    var eSayisi = db.GelenEvrak.Count(s => s.PersonelId == id && s.OlayYerleri.OlayYeri == e.Key.OlayYeri);
                    
                    mahalleEvraklari.Add(new MahalleEvraklariDTO
                    {
                        EvrakSayisi = eSayisi,
                        Koy = e.Key.OlayYeri,
                        AileiciSiddetSayisi = aisSayisi
                    });

                    FmToplam += eSayisi;
                    AisToplam += aisSayisi;
                }
            }

            return mahalleEvraklari;
        }

        /// <summary>
        /// Mahalle olayları
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        internal List<MahalleOlaylariDTO> MahalleOlaylari(int id)
        {
            var mahalleOlaylari = new List<MahalleOlaylariDTO>();
            using (var db = new ETSEntities())
            {
                var koyler = db.GidenEvrak.Where(w => w.OlayDurumuId == FailiMechulId && w.PersonelId == id && BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).GroupBy(g => g.OlayYerleri);

                mahalleOlaylari.AddRange(koyler.Select(k => new MahalleOlaylariDTO
                {
                    Koy = k.Key.OlayYeri,
                    OlaySayisi = db.GidenEvrak.Where(w => BaslangicTarihi <= w.EvrakKayitTarihi && BitisTarihi >= w.EvrakKayitTarihi).Count(w => w.PersonelId == id && w.OlayDurumuId == 5 && w.OlayYeriId == k.Key.Id)
                }));
            }

            return mahalleOlaylari;
        }
    }
}
