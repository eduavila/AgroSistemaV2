using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaTipodeProduto
{
    public partial class FormAlterarTipodeProduto : AgroSistema.Forms.TelaPradrao.FormCadastroPadrao
    {


        AgroDBEntities1 _context;

        Tipo_Produto _TipodeProduto;




        public FormAlterarTipodeProduto(int IDTipoProduto)
        {
            InitializeComponent();



            _context = new AgroDBEntities1();


            _TipodeProduto = _context.Tipo_Produto.Find(IDTipoProduto);


            tipo_ProdutoBindingSource.DataSource = _TipodeProduto;
        }


        public override void SalvarRegistro()
        {
            try
            {

                this.Validate();

                this._context.SaveChanges();

                MessageBox.Show("Registro Salvo com Sucesso.");

                Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um ERRO ao Salvar MSG: " + erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}
