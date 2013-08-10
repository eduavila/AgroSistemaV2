using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroSistema.Forms.TelaPrincipal;
using AgroSistema.Model;
using System.Data.Entity;
using System.Data.EntityClient;

namespace AgroSistema.Forms.TelaFazenda
{
    public partial class FormFazenda : Form
    {
        AgroDBEntities1 _context;
      


        public FormFazenda()
        {
           
            InitializeComponent();


            this.Width = 493;
            this.Height = 360;
            

            //position

         

            // carrega dados do banco no grid
            CarregandoGrid();


        }

        private void CarregandoGrid()
        {

            // inciando dados no grid
            try
            {
                _context = new AgroDBEntities1();

                fazendaBindingSource.DataSource = _context.Fazendas.ToList();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.   MSGERRO: " + erro.Message, "Erro Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

            FormCadastroFazenda cadastrofazenda = new FormCadastroFazenda();
            cadastrofazenda.ShowDialog();

            CarregandoGrid();

        }


        
        private void btn_excluir_Click(object sender, EventArgs e)
        {

            try
            {
                // remove intens selecionado.
                fazendaBindingSource.RemoveCurrent();
                _context.Fazendas.Remove((Fazenda)fazendaBindingSource.Current);
                 // salva auterações no banco.
                _context.SaveChanges();


                MessageBox.Show("Registro Excluido com Sucesso ", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir registro do Banco de Dados.   MSGERRO: " + erro.Message, "Erro Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
              
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FormAlterarFazenda cadastrofazenda = new FormAlterarFazenda(int.Parse(Dgw_Fazenda.CurrentRow.Cells[0].Value.ToString()));
            cadastrofazenda.ShowDialog();

            CarregandoGrid();

        }

      
    }
}
