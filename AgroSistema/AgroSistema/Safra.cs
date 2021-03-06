//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgroSistema
{
    using System;
    using System.Collections.Generic;
    
    public partial class Safra
    {
        public Safra()
        {
            this.DocEntradas = new HashSet<DocEntrada>();
            this.Estoques = new HashSet<Estoque>();
        }
    
        public int Id { get; set; }
        public System.DateTime DataInicio { get; set; }
        public Nullable<System.DateTime> DataFinal { get; set; }
        public string Curtivo { get; set; }
        public string TipoPlantio { get; set; }
        public bool Finaliza { get; set; }
        public string Descricao { get; set; }
        public int Fazenda_Cod_Fazenda { get; set; }
    
        public virtual ICollection<DocEntrada> DocEntradas { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
        public virtual Fazenda Fazenda { get; set; }
    }
}
