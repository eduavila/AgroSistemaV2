using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaUnidadeMedida
{
    public partial class FormAlterarUnidadeMedida : AgroSistema.Forms.TelaPradrao.FormCadastroPadrao
    {

        AgroDBEntities1 _context;

        UnidadeMedida _unidadeMedida;


        public FormAlterarUnidadeMedida(int idUnidadeMedida)
        {
            InitializeComponent();


            _context = new AgroDBEntities1();

            _unidadeMedida = _context.UnidadeMedidas.Find(idUnidadeMedida);

            unidadeMedidaBindingSource.DataSource = _unidadeMedida;
        }


        // sobreescreve metodo SalvarRegistro
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
