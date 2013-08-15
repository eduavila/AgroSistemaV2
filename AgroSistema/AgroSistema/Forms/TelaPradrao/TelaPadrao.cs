using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaPradrao
{
    public partial class TelaPadrao : Form
    {
        public TelaPadrao()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            AdicionarRegistro();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            AlterarRegistro();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
        }


        public virtual void AdicionarRegistro()
        { 
        
        
        }

        public virtual void AlterarRegistro()
        { 
        
        }

        public virtual void Pesquisar()
        { 
        
        
        }

        public virtual void ExcluirRegistro()
        { 
        
        
        
        }




    }
}
