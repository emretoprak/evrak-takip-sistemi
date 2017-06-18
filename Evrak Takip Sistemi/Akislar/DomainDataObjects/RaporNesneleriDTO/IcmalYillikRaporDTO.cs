using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;
using System.Collections.Generic;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO
{
    public class IcmalYillikRaporDTO 
    {
        public int IcmalYili { get; set; }
        public List<AylarDTO> RaporAylari { get; set; }
        public string TanzimEdenIsim { get; set; }
        public string TanzimEdenRutbe { get; set; }
        public string TanzimEdenTim { get; set; }
        public string TastikEdenIsim { get; set; }
        public string TastikEdenRutbe { get; set; }
        public string TastikEdenTim { get; set; }

        public int GecenAyToplamYakalama { get; set; }
        public int GecenAyToplamGiyabiTevkif { get; set; }
        public int GecenAyToplamTazyik { get; set; }
        public int GecenAyToplamZorlaGetirme { get; set; }

        public int AyiciToplamYakalama { get; set; }
        public int AyiciToplamGiyabiTevkif { get; set; }
        public int AyiciToplamTazyik { get; set; }
        public int AyiciToplamZorlaGetirme { get; set; }

        public int MevcudenToplamYakalama { get; set; }
        public int MevcudenToplamGiyabiTevkif { get; set; }
        public int MevcudenToplamTazyik { get; set; }
        public int MevcudenToplamZorlaGetirme { get; set; }

        public int MuameletenToplamYakalama { get; set; }
        public int MuameletenToplamGiyabiTevkif { get; set; }
        public int MuameletenToplamTazyik { get; set; }
        public int MuameletenToplamZorlaGetirme { get; set; }

        public int BirsonrakiAyaDevirToplamYakalama { get; set; }
        public int BirsonrakiAyaDevirToplamGiyabiTevkif { get; set; }
        public int BirsonrakiAyaDevirToplamTazyik { get; set; }
        public int BirsonrakiAyaDevirToplamZorlaGetirme { get; set; }
    }
}
