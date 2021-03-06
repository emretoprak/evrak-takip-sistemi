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
    
    public partial class ArsivGelenGiden
    {
        public long Id { get; set; }
        public long IlkEvrak { get; set; }
        public Nullable<long> IlgiliEvrak { get; set; }
        public Nullable<long> DosyaNo { get; set; }
        public System.DateTime Tarih { get; set; }
        public int SubeId { get; set; }
        public int EsasKonuNo { get; set; }
        public int AraSayiNo { get; set; }
        public int Yil { get; set; }
        public int IlgiliBirimId { get; set; }
        public int CikaranMakamId { get; set; }
        public string Konusu { get; set; }
        public int GizililikDerecesiId { get; set; }
        public int EkSayisi { get; set; }
        public Nullable<int> ImhaYili { get; set; }
        public Nullable<long> GelenEvrakId { get; set; }
        public Nullable<long> GidenEvrakId { get; set; }
    
        public virtual EvrakiCikaranMakam EvrakiCikaranMakam { get; set; }
        public virtual GizlilikDerecesi GizlilikDerecesi { get; set; }
        public virtual Birimler Birimler { get; set; }
        public virtual Subeler Subeler { get; set; }
    }
}
