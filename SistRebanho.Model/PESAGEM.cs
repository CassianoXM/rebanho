//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistRebanho.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PESAGEM
    {
        public int id { get; set; }
        public string animal { get; set; }
        public System.DateTime datapesagem { get; set; }
        public double peso { get; set; }
        public string obsaervaçao { get; set; }
    
        public virtual CADASTRO CADASTRO { get; set; }
    }
}
