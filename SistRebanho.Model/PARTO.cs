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
    
    public partial class PARTO
    {
        public int id { get; set; }
        public string animal { get; set; }
        public System.DateTime dataParto { get; set; }
        public string sexoCria { get; set; }
        public string observacao { get; set; }
        public Nullable<int> raca { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
    
        public virtual CADASTRO CADASTRO { get; set; }
    }
}
