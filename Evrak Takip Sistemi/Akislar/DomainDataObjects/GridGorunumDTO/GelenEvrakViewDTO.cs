namespace ETS.Akislar.DomainDataObjects.GridGorunumDTO
{
    using System;

    /// <summary>
    /// Zimmet ekranında gösterilmek amaçlı GelenEvrak kopya sınıfı
    /// </summary>
    public class GelenEvrakViewDTO
    {
        public GelenEvraklarViewDTO GelenEvraklarView { get; set; }
    }

    public class GelenEvraklarViewDTO
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

        public string Personel { get; set; }

        public string GuvenlikNoOncelikDerecesi { get; set; }
    }
}
