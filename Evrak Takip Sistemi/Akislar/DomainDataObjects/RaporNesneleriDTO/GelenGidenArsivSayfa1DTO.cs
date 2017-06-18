using System;
using System.Collections.Generic;
using ETS.Akislar.DomainDataObjects.RaporNesneleriDTO.Ortak;

namespace ETS.Akislar.DomainDataObjects.RaporNesneleriDTO
{
    public class GelenGidenArsivSayfa1DTO 
    {
        public string KomutanlikKurumAdi { get; set; }
        public string BaskanlikAdi { get; set; }
        public string DaireAdi { get; set; }
        public string SubeAdi { get; set; }
        public string KonusYeri { get; set; }
        public DateTime EnvanterinDuzenlendigiTarih { get; set; }
        public string EnvanteriDuzenlenenArsivDonemi { get; set; }
        public string EnvanterinDuzenlenmeAmaci { get; set; }

        public string DepoNu { get; set; }
        public string DepoOdaNu { get; set; }
        public string DolapNu { get; set; }
        public string RafNu { get; set; }
        public string SandikNu { get; set; }
        public string KutuDosyaNu { get; set; }
        public string KonuGrubuNu { get; set; }
        public string ArsivKategorisi { get; set; }
        public string EnvanterNumarasi { get; set; }

        public List<RaporPersonelDTO> TasnifKuruluPersonelleri { get; set; }
    }
}
