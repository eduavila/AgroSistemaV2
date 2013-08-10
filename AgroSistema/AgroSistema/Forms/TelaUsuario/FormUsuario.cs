using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.EntityClient;
using AgroSistema.Model;
using AgroSistema.Forms.TelaPrincipal;
using AgroSistema.Forms.TelaSelecao;
namespace AgroSistema.Forms.TelaUsuario
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// coloca usuario pelo id
        private void ProcurarLogin()
        {
            AgroDBEntities1 AgroDb = new AgroDBEntities1();

            if (tb_cod_usuario.Text != string.Empty)
            {
               var usuario = AgroDb.Usuarios.Find(int.Parse(tb_cod_usuario.Text));

               if (usuario == null)
               {
                   MessageBox.Show("Cod do Usuário não existe.");

               }
               else {
                   tb_usuario.Text = usuario.Login;
                   tb_senha.Focus();           
               }

            }
            else
            {
                MessageBox.Show("Não pode deixa campo Cod em branco.");
            
            }
        }

        private void tb_cod_usuario_TabIndexChanged(object sender, EventArgs e)
        {
            ProcurarLogin();
        }

        private void tb_cod_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                ProcurarLogin();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_cod_usuario.Text == string.Empty && tb_senha.Text == string.Empty)
            {
                MessageBox.Show("Não pode deicha campos em branco.");
            }
            else{
                 AltenticarUsuario();
            }
        }

        private void AltenticarUsuario()
        {

            AgroDBEntities1 Agrodb = new AgroDBEntities1();

            var Usuario = Agrodb.Usuarios.Find(int.Parse(tb_cod_usuario.Text));

            try
            {
                if (Usuario.Login == tb_usuario.Text && Usuario.Senha == tb_senha.Text)
                {
                    

                    // colocando Usuario conectado dentro da prp
                   


                    // abrindo tela de selecao fazenda
                    this.Visible = false;
                    FormSelecaoFazenda selecaoFazenda = new FormSelecaoFazenda();
                    selecaoFazenda.ShowDialog();



                    // iniciando formulario principal enviando objeto Usuario , e fazenda selecionada  como contrutor.
                    FormPrincipal formprincipal = new FormPrincipal(Usuario,selecaoFazenda.FazendaConectada());
                    formprincipal.Show();
                   



               


                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um Erro ao autenticar Usuário.  ERRO: " + erro.Message);
               
            }
                

        }


    }
}
