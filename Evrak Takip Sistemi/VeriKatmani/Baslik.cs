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
    
    public partial class Baslik
    {
        public Baslik()
        {
            this.DaimiArastirmaTutanaklari = new HashSet<DaimiArastirmaTutanaklari>();
        }
    
        public int Id { get; set; }
        public string AnaBaslik { get; set; }
        public int PersonelId { get; set; }
        public string UstYaziBaslik { get; set; }
        public int EkSayisi { get; set; }
    
        public virtual ICollection<DaimiArastirmaTutanaklari> DaimiArastirmaTutanaklari { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
