using AgroSistema.Forms.TelaUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroSistema.Forms.splash
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressoBar.Value < 100)
            {
                ProgressoBar.Value += 10;
            }
            else {

                timer1.Enabled = false;
                FormUsuario formusuario = new FormUsuario();
                formusuario.Show();
                this.Visible = false;
            }
        }
    }
}
