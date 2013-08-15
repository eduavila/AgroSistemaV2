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
    public partial class FormCadastroFornecedor : Form
    {
        AgroDBEntities1 _context;
        Fornecedor _fornecedor;



        public FormCadastroFornecedor()
        {
            InitializeComponent();

            nomeFantasiaTextBox.Focus();

            _context =new  AgroDBEntities1();

            _fornecedor = new Fornecedor();


            

            _fornecedor.DataCadastro = DateTime.Now;

            fornecedorBindingSource.DataSource = _fornecedor;

        }

        private void iELabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            





        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                cnpjMaskedTextBox.Mask = "000.000.000-00";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                cnpjMaskedTextBox.Mask = "00.000.000/0000-00";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {


                    //this.Validate();


                    this._context.Fornecedors.Add(_fornecedor);



                    this._context.SaveChanges();



                    fornecedorBindingSource.Clear();

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
