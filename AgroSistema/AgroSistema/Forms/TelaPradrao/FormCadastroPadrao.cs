using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroSistema.Forms.TelaPradrao
{
    public partial class FormCadastroPadrao : Form
    {
        public FormCadastroPadrao()
        {
            InitializeComponent();
        }

        public virtual void SalvarRegistro()
        { 
        
        
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
