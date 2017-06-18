namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak
{
    public class AylarDTO
    {
        public string Ay { get; set; }

        public int GecenAyDevirYakalama { get; set; }
        public int GecenAyDevirGiyabiTevkif { get; set; }
        public int GecenAyDevirTazyik { get; set; }
        public int GecenAyDevirZorlaGetirme { get; set; }

        public int AyiciGelenYakalama { get; set; }
        public int AyiciGelenGiyabiTevkif { get; set; }
        public int AyiciGelenTazyik { get; set; }
        public int AyiciGelenZorlaGetirme { get; set; }

        public int MevcudenYakalama { get; set; }
        public int MevcudenGiyabiTevkif { get; set; }
        public int MevcudenTazyik { get; set; }
        public int MevcudenZorlaGetirme { get; set; }

        public int MuameletenYakalama { get; set; }
        public int MuameletenGiyabiTevkif { get; set; }
        public int MuameletenTazyik { get; set; }
        public int MuameletenZorlaGetirme { get; set; }

        public int BirsonrakiAyaDevirYakalama { get; set; }
        public int BirsonrakiAyaDevirGiyabiTevkif { get; set; }
        public int BirsonrakiAyaDevirTazyik { get; set; }
        public int BirsonrakiAyaDevirZorlaGetirme { get; set; }
    }
}
