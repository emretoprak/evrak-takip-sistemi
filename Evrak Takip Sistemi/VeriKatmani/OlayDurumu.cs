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
    
    public partial class OlayDurumu
    {
        public OlayDurumu()
        {
            this.GelenEvrak = new HashSet<GelenEvrak>();
            this.GidenEvrak = new HashSet<GidenEvrak>();
        }
    
        public int Id { get; set; }
        public string Durum { get; set; }
    
        public virtual ICollection<GelenEvrak> GelenEvrak { get; set; }
        public virtual ICollection<GidenEvrak> GidenEvrak { get; set; }
    }
}
