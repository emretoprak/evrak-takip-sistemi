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
    
    public partial class Personel
    {
        public Personel()
        {
            this.Baslik = new HashSet<Baslik>();
            this.DaimiArastirmaTutanaklari = new HashSet<DaimiArastirmaTutanaklari>();
            this.DaimiArastirmaTutanaklari1 = new HashSet<DaimiArastirmaTutanaklari>();
            this.DaimiArastirmaTutanaklari2 = new HashSet<DaimiArastirmaTutanaklari>();
            this.DaimiArastirmaTutanaklari3 = new HashSet<DaimiArastirmaTutanaklari>();
            this.GelenEvrak = new HashSet<GelenEvrak>();
            this.GidenEvrak = new HashSet<GidenEvrak>();
            this.ZimmetDefteri = new HashSet<ZimmetDefteri>();
        }
    
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Rutbesi { get; set; }
        public string Tim { get; set; }
        public int Durum { get; set; }
        public string TamIsim { get; set; }
        public string AdiSoyadi { get; set; }
        public string Sicili { get; set; }
        public string Gorevi { get; set; }
    
        public virtual ICollection<Baslik> Baslik { get; set; }
        public virtual ICollection<DaimiArastirmaTutanaklari> DaimiArastirmaTutanaklari { get; set; }
        public virtual ICollection<DaimiArastirmaTutanaklari> DaimiArastirmaTutanaklari1 { get; set; }
        public virtual ICollection<DaimiArastirmaTutanaklari> DaimiArastirmaTutanaklari2 { get; set; }
        public virtual ICollection<DaimiArastirmaTutanaklari> DaimiArastirmaTutanaklari3 { get; set; }
        public virtual ICollection<GelenEvrak> GelenEvrak { get; set; }
        public virtual ICollection<GidenEvrak> GidenEvrak { get; set; }
        public virtual ICollection<ZimmetDefteri> ZimmetDefteri { get; set; }
    }
}
