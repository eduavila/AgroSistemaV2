using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroSistema.Model;
using System.Data.Entity;
using System.Data.EntityClient;

namespace AgroSistema.Forms.TelaFazenda
{
    public partial class FormAlterarFazenda : Form
    {

        AgroDBEntities1 _context;

        Fazenda _fazenda;



        public FormAlterarFazenda(int IDfazenda)
        {
            InitializeComponent();

            _context = new AgroDBEntities1();


           _fazenda = _context.Fazendas.Find(IDfazenda);

           fazendaBindingSource.DataSource = _fazenda;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
