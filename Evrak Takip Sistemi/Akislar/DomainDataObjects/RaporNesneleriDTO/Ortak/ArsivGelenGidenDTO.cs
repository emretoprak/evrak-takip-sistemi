using System;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak
{
    public class ArsivGelenGidenDTO
    {
        public int Id { get; set; }
        public long IlkEvrak { get; set; }
        public long? IlgiliEvrak { get; set; }
        public long? DosyaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Sube { get; set; }
        public int EsasKonuNo { get; set; }
        public int AraSayiNo { get; set; }
        public int Yil { get; set; }
        public string IlgiliBirim { get; set; }
        public string CikaranMakam { get; set; }
        public string Konusu { get; set; }
        public string GizililikDerecesi { get; set; }
        public int EkSayisi { get; set; }
        public int? ImhaYili { get; set; }
        public long? GelenEvrak { get; set; }
        public long? GidenEvrak { get; set; }
    }
}
