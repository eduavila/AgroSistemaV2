using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaFornecedor
{
    public partial class FormFornecedor : Form
    {

        AgroDBEntities1 _context;


        public FormFornecedor()
        {
            InitializeComponent();


            CarregandoGrid();
        }
        private void CarregandoGrid()
        {

            // inciando dados no grid
            try
            {
                _context = new AgroDBEntities1();

                fornecedorBindingSource.DataSource = _context.Fornecedors.ToList();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.   MSGERRO: " + erro.Message, "Erro Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor cadastrofornedor = new FormCadastroFornecedor();
            cadastrofornedor.ShowDialog();
            CarregandoGrid();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
          if(Dgw_Fazenda.CurrentRow != null)
          {
              FormAlterarFornecedor alterarfornecedor = new FormAlterarFornecedor(int.Parse(Dgw_Fazenda.CurrentRow.Cells[0].Value.ToString()));
              alterarfornecedor.ShowDialog();
          }
       }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                // remove intens selecionado.
               var result =  MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Excluir Registro", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);



               if (result == DialogResult.Yes)
               {
                  
                   _context.Fornecedors.Remove((Fornecedor)fornecedorBindingSource.Current);
                   // salva auterações no banco.
                   _context.SaveChanges();


                   MessageBox.Show("Registro Excluido com Sucesso ", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
             
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir registro do Banco de Dados.   MSGERRO: " + erro.Message, "Erro Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            // atualizando grid

            CarregandoGrid();
        }
    }
}
