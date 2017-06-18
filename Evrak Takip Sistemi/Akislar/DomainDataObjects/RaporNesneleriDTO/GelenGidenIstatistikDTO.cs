using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;
using System.Collections.Generic;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO
{
    public class GelenGidenIstatistiklerDTO 
    {
        public List<IstatistikDTO> Istatistikler { get; set; }
        public List<ToplamDTO> GenelToplam { get; set; }
        public List<MahalleOlaylariDTO> KoylerdekiOlaySayilari { get; set; }
    }
}
