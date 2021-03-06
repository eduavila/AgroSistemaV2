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
    
    public partial class DocEntrada
    {
        public DocEntrada()
        {
            this.ProdDocEntradas = new HashSet<ProdDocEntrada>();
        }
    
        public int Id { get; set; }
        public string NDoc { get; set; }
        public string Serie { get; set; }
        public string ChaveAcesso { get; set; }
        public System.DateTime DataEmissao { get; set; }
        public System.DateTime DataEntrada { get; set; }
        public int Fornecedor_Cod_Fornecedor { get; set; }
        public int Safra_Cod_Safra { get; set; }
    
        public virtual ICollection<ProdDocEntrada> ProdDocEntradas { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Safra Safra { get; set; }
    }
}
