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
using AgroSistema.Forms.TelaFazenda;

namespace AgroSistema.Forms.TelaSelecao
{
    public partial class FormSelecaoFazenda : Form
    {


        Fazenda _fazenda;

        AgroDBEntities1 _context;
        

         // get da propriedade _fazenda

        public Fazenda FazendaConectada()
        {
            return _fazenda;
        
        }

       


        public FormSelecaoFazenda()
        {
            InitializeComponent();


            //
            // carrega dados do banco no grid
            CarregandoGrid();

            if (_context.Fazendas.Count() == 0)
            {
                Application.Exit();
            
            }


        }

        private void CarregandoGrid()
        {

            // inciando dados no grid
            try
            {
                _context = new AgroDBEntities1();

                if (_context.Fazendas.Count() == 0)
                {
                    MessageBox.Show("Não contém nenhuma fazenda cadastrada.");
                    FormCadastroFazenda cadastrofazenda = new FormCadastroFazenda();
                    cadastrofazenda.ShowDialog();
                    fazendaBindingSource.DataSource = _context.Fazendas.ToList();
                }
                else
                {
                    fazendaBindingSource.DataSource = _context.Fazendas.ToList();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.   MSGERRO: " + erro.Message, "Erro Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (fazendaDataGridView.CurrentRow.Cells[0].Value != null)
            {
                _fazenda = _context.Fazendas.Find(fazendaDataGridView.CurrentRow.Cells[0].Value);
                
                this.Close();
            }
        }
    }
}
