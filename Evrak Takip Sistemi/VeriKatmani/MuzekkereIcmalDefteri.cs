//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETS.VeriKatmani
{
    using System;
    using System.Collections.Generic;
    
    public partial class MuzekkereIcmalDefteri
    {
        public long Id { get; set; }
        public long SiraNo { get; set; }
        public string DosyaNo { get; set; }
        public string AdiSoyadi { get; set; }
        public System.DateTime GeldigiTarih { get; set; }
        public Nullable<System.DateTime> GonderildigiTarih { get; set; }
        public int Durum { get; set; }
        public string Aciklama { get; set; }
        public int MahalleId { get; set; }
        public int MuzekkereCinsiId { get; set; }
        public int KomutanlikId { get; set; }
    
        public virtual Komutanliklar Komutanliklar { get; set; }
        public virtual MuzekkereCinsleri MuzekkereCinsleri { get; set; }
        public virtual OlayYerleri OlayYerleri { get; set; }
    }
}
