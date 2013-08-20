using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.EntityClient;
using System.Linq;

namespace AgroSistema.Forms.TelaUnidadeMedida
{
    public partial class FormUnidadeMedida : AgroSistema.Forms.TelaPradrao.TelaPadrao
    {
        AgroDBEntities1 _context;
        
        public FormUnidadeMedida()
        {
            InitializeComponent();

           
        }

        private void CarregandoGrid()
        {

            _context = new AgroDBEntities1();
            unidadeMedidaBindingSource.DataSource = _context.UnidadeMedidas.ToList();

        }

        public override void AdicionarRegistro()
        {
            FormCadastraUnidadeMedida cadastrounidademedida = new FormCadastraUnidadeMedida();
            cadastrounidademedida.ShowDialog();


            CarregandoGrid();
        }


        public override void AlterarRegistro()
        {
            if (Dgw.CurrentRow != null)
            {
                FormAlterarUnidadeMedida alterarunidademedida = new FormAlterarUnidadeMedida(int.Parse(Dgw.CurrentRow.Cells[0].Value.ToString()));
                alterarunidademedida.ShowDialog();
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

                        _context.UnidadeMedidas.Remove((UnidadeMedida)unidadeMedidaBindingSource.Current);
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
