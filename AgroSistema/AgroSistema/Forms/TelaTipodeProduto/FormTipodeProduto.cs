using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AgroSistema.Forms.TelaTipodeProduto
{
    public partial class FormTipodeProduto : AgroSistema.Forms.TelaPradrao.TelaPadrao
    {

        AgroDBEntities1 _context;



        public FormTipodeProduto()
        {
            InitializeComponent();


            

            CarregandoGrid();
        }


        private void CarregandoGrid()
        {

            _context = new AgroDBEntities1();
            tipoProdutoBindingSource.DataSource = _context.Tipo_Produto.ToList();     
        
        }

        public override void AdicionarRegistro()
        {
            FormCadastroTipodeProduto cadastrotipodeproduto = new FormCadastroTipodeProduto();
            cadastrotipodeproduto.ShowDialog();


            CarregandoGrid();
        }


        public override void AlterarRegistro()
        {
            if (Dgw.CurrentRow != null)
            {
                FormAlterarTipodeProduto alterartipoproduto = new FormAlterarTipodeProduto(int.Parse(Dgw.CurrentRow.Cells[0].Value.ToString()));
                alterartipoproduto.ShowDialog();
                CarregandoGrid();

            }


          


           
        }




        public override void ExcluirRegistro()
        {
            try
            {
                if (Dgw.CurrentRow != null)
                {
                    // remove intens selecionado.
                    var result = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                    if (result == DialogResult.Yes)
                    {

                        _context.Tipo_Produto.Remove((Tipo_Produto)tipoProdutoBindingSource.Current);
                        // salva auterações no banco.
                        _context.SaveChanges();


                        MessageBox.Show("Registro Excluido com Sucesso ", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
