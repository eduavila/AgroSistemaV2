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
    
    public partial class Aplicacao
    {
        public Aplicacao()
        {
            this.ProdutoAplicacaos = new HashSet<ProdutoAplicacao>();
        }
    
        public int Id { get; set; }
        public System.DateTime Data_Cadastro { get; set; }
        public string Descricao { get; set; }
        public System.DateTime Data_Aplicacao { get; set; }
        public bool Finalizada { get; set; }
        public int AreaAplicada { get; set; }
        public System.TimeSpan Horas_incial { get; set; }
        public int Horas_final { get; set; }
        public int Fazenda_Cod_Fazenda { get; set; }
        public int Implemento_Cod_Implementos { get; set; }
    
        public virtual ICollection<ProdutoAplicacao> ProdutoAplicacaos { get; set; }
        public virtual Fazenda Fazenda { get; set; }
        public virtual Implemento Implemento { get; set; }
    }
}