using AgroSistema.Forms.TelaFazenda;
using AgroSistema.Forms.TelaFuncionario;
using AgroSistema.Forms.TelaUsuario;
using AgroSistema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaPrincipal
{
    public partial class FormPrincipal : Form
    {

        public int UsuarioConectado { get; set; }

        public int FazendaConectada { get; set; }

        Fazenda _fazenda;



        public FormPrincipal(Usuario usuario, Fazenda fazenda)
        {
            InitializeComponent();

            status1.Text = " Usuário : " + usuario.Login + "  Fazenda : " + fazenda.Nome_fazenda;

            _fazenda = fazenda;

        }

        

        private void taToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fazendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTelasMDI(new FormFazenda());
        }

        public void AbrirTelasMDI(Form form)
        {
            // procura se o form ja esta aberto se estiver ele da um focus() ;
            foreach (Form formFilho in this.MdiChildren)
            {
                if (formFilho.GetType() == form.GetType())
                {
                    formFilho.Focus();
                    return;
                }
            }
            form.MdiParent = this;

            // maximiza janela filha
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTelasMDI(new FormFuncionario(_fazenda));
        }
    }
}
