//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgroSistema.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdutoAplicacao
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Quantidade { get; set; }
        public string Valor { get; set; }
        public int Aplicacao_Cod_Aplicacao { get; set; }
    
        public virtual Aplicacao Aplicacao { get; set; }
    }
}
