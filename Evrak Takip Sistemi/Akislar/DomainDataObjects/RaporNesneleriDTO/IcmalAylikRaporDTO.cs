using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO
{
    public class IcmalAylikRaporDTO
    {
        public string IcmalAyi { get; set; }
        public GecenAyDevirDTO GecenAyDevir { get; set; }
        public AyicindeGelenDTO AyicindeGelen { get; set; }
        public InfazMevcutenDTO InfazMevcuten { get; set; }
        public InfazMuameletenDTO InfazMuameleten { get; set; }
        public BirSonrakiAyaDevirDTO BirSonrakiAyaDevir { get; set; }
        public string TanzimEdenIsim { get; set; }
        public string TanzimEdenRutbe { get; set; }
        public string TanzimEdenTim { get; set; }
        public string TastikEdenIsim { get; set; }
        public string TastikEdenRutbe { get; set; }
        public string TastikEdenTim { get; set; }
        public int IcmalYili { get; set; }
    }
}
