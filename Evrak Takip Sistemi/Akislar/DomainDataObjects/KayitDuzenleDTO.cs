namespace ETS.Akislar.DomainDataObjects
{
    using ETS.Akislar.Enums;

    /// <summary>
    /// Duzenlenecek kayıt için form'a gönderilecek parametreler
    /// </summary>
    public class KayitDuzenleDTO
    {
        public bool Duzenleme { get; set; }
        public EvrakTip EvrakTip { get; set; }
        public long EvrakId { get; set; }
    }
}