using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaTipodeProduto
{
    public partial class FormCadastroTipodeProduto : AgroSistema.Forms.TelaPradrao.FormCadastroPadrao
    {

        // 

        AgroDBEntities1 _context;

        Tipo_Produto _TipodeProduto;


        public FormCadastroTipodeProduto()
        {
            InitializeComponent();

            _context = new AgroDBEntities1();


            _TipodeProduto = new Tipo_Produto();


            tipo_ProdutoBindingSource.DataSource = _TipodeProduto;
        }



        public override void SalvarRegistro()
        {
            try
            {


                this.Validate();


                this._context.Tipo_Produto.Add(_TipodeProduto);



                this._context.SaveChanges();



                tipo_ProdutoBindingSource.Clear();

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
