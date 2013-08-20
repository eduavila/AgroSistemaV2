using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaUnidadeMedida
{
    public partial class FormCadastraUnidadeMedida : AgroSistema.Forms.TelaPradrao.FormCadastroPadrao
    {

        // 

        AgroDBEntities1 _context;

        UnidadeMedida _unidadeMedida;


        public FormCadastraUnidadeMedida()
        {
            InitializeComponent();

            _context = new AgroDBEntities1();


            _unidadeMedida = new UnidadeMedida();



            unidadeMedidaBindingSource.DataSource = _unidadeMedida;


        }


        public override void SalvarRegistro()
        {
            try
            {


                this.Validate();


                this._context.UnidadeMedidas.Add(_unidadeMedida);



                this._context.SaveChanges();



                unidadeMedidaBindingSource.Clear();

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
