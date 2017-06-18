namespace ETS.Akislar.DomainDataObjects.GridGorunumDTO
{
    using System;

    /// <summary>
    /// Zimmet ekranında gösterilmek amaçlı GidenEvrak kopya sınıfı
    /// </summary>
    public class GidenEvrakViewDTO{
        public GidenEvraklarViewDTO GidenEvraklarView { get; set; }
    }

    public class GidenEvraklarViewDTO
    {
        public long EvrakKayitNo { get; set; }

        public DateTime EvrakKayitTarihi { get; set; }

        public DateTime TarihTsg { get; set; }

        public string DosyaNoKonusu { get; set; }

        public string Aciklama { get; set; }

        public int Durum { get; set; }

        public DateTime EvrakSonTarihi { get; set; }

        public string EvrakiCikaranMakam { get; set; }

        public string GizlilikDerecesi { get; set; }

        public string GonderdigiMakam { get; set; }

        public string GuvenlikNoOncelikDerecesi { get; set; }
    }
}
