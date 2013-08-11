
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaFuncionario
{
    public partial class FormFuncionario : Form
    {
        AgroDBEntities1 _context;

        Funcionario _funcionario;
        
        Fazenda _fazenda;

        


        public FormFuncionario(Fazenda Fazenda)
        {
            InitializeComponent();


            _fazenda = Fazenda;

        }

        private void CarregandoGrid()
        {

            // inciando dados no grid
            try
            {
                

                // Criando banco
                _context = new AgroDBEntities1();

                funcionarioBindingSource.DataSource = _context.Funcionarios.Where(func => func.Fazenda.Equals(_fazenda)).ToList();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.   MSGERRO: " + erro.Message, "Erro Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario cadastrofuncionario = new FormCadastroFuncionario(_fazenda.Id);
            cadastrofuncionario.ShowDialog();
        }
    }
}
