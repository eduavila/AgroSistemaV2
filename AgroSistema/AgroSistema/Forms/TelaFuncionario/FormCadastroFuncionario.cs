
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
    public partial class FormCadastroFuncionario : Form
    {
        
        Funcionario _funcionario;
        AgroDBEntities1 _context;
       

        public FormCadastroFuncionario(int fazenda)
        {
            InitializeComponent();


            //inicializando banco e funcionario 

            _context = new AgroDBEntities1();

           //Funcionario


            _funcionario = new Funcionario();
            
            //

            //funcionarioBindingSource.Insert(7, fazenda);


            // 
         
            this.funcionarioBindingSource.DataSource = _funcionario;
        }

        private void enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                data_DemissaoDateTimePicker.Visible = true;
            }
            else {

                data_DemissaoDateTimePicker.Visible = false;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {


                
                // Fazenda

               
                

                if (checkBox1.Checked != true)
                {
                    _funcionario.Data_Demissao = "";
                    
                }

                this._context.Funcionarios.Add(_funcionario);

                // salvando registro no banco
                this._context.SaveChanges();


                // limpando campos do formulario
                this.funcionarioBindingSource.Clear();

                MessageBox.Show("Registro Salvo com Sucesso.");
                Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um ERRO ao Salvar MSG: " + erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }
    }
}
