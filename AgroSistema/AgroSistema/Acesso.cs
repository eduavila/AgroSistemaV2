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
    
    public partial class Acesso
    {
        public int Id { get; set; }
        public string Modulo { get; set; }
        public bool Alterar { get; set; }
        public bool Visualizar { get; set; }
        public bool Excluir { get; set; }
        public int Usuario_Id { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
