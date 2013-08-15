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
    public partial class FormAlterarFornecedor : Form
    {
        AgroDBEntities1 _context;

        Fornecedor _fornecedor;


        public FormAlterarFornecedor(int IDFornecedor)
        {
            InitializeComponent();
            
            _context = new AgroDBEntities1();


            _fornecedor = _context.Fornecedors.Find(IDFornecedor);

            fornecedorBindingSource.DataSource = _fornecedor;


        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();

                this._context.SaveChanges();

                MessageBox.Show("Registro Salvo com Sucesso.");



            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um ERRO ao Salvar MSG: " + erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
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

    }
}
