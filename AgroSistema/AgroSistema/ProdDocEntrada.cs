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
    
    public partial class ProdDocEntrada
    {
        public int Id { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public int Produto_Cod_Produto { get; set; }
        public int CentrodeCusto_Cod_CentroCusto { get; set; }
        public int Fazenda_Cod_Fazenda { get; set; }
        public int DocEntrada_Cod_DocEntrada { get; set; }
    
        public virtual CentrodeCusto CentrodeCusto { get; set; }
        public virtual DocEntrada DocEntrada { get; set; }
        public virtual Fazenda Fazenda { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
