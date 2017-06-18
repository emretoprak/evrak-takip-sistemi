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
    
    public partial class DaimiArastirmaTutanaklari
    {
        public long Id { get; set; }
        public string Kimlikler { get; set; }
        public int SucId { get; set; }
        public System.DateTime OlayTarihi { get; set; }
        public int OlayYeriId { get; set; }
        public string OlaySorusturmaNo { get; set; }
        public string DaimiAramaNo { get; set; }
        public System.DateTime DaimiAramaKarariTarihi { get; set; }
        public System.DateTime ZamanAsimi { get; set; }
        public string Ozet { get; set; }
        public int Durum { get; set; }
        public int Personel1Id { get; set; }
        public int Personel2Id { get; set; }
        public Nullable<int> Personel3Id { get; set; }
        public Nullable<int> Personel4Id { get; set; }
        public int PeriyotYili { get; set; }
        public int BaslikId { get; set; }
        public int PeriyotId { get; set; }
    
        public virtual Baslik Baslik { get; set; }
        public virtual OlayYerleri OlayYerleri { get; set; }
        public virtual Periyotlar Periyotlar { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Personel Personel1 { get; set; }
        public virtual Personel Personel2 { get; set; }
        public virtual Personel Personel3 { get; set; }
        public virtual Suclar Suclar { get; set; }
    }
}