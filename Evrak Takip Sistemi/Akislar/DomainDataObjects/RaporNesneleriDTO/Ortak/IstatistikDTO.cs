using System.Collections.Generic;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak
{
    public class IstatistikDTO
    {
        public string PersonelAdi { get; set; }
        public int PersonelEvrakSayisi { get; set; }
        public int Gitti { get; set; }
        public int Gitmedi { get; set; }
        public int MudahaleEttigiOlaySayisi { get; set; }
        public int FmOlaySayisi { get; set; }
        public List<MahalleEvraklariDTO> MahalleEvraklari { get; set; }
    }
}
