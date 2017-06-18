using System.Collections.Generic;
using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO
{
    public class IcmalTumYillarRaporDTO
    {
        public List<YillarDTO> RaporYillari { get; set; }
        public GenelToplamDTO GenelToplam { get; set; }
    }
}
