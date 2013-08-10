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
    public partial class FormCadastroFazenda : Form
    {
        Fazenda _fazenda;
        AgroDBEntities1 _context;

        public FormCadastroFazenda()
        {
            InitializeComponent();

            _context = new AgroDBEntities1();

            _fazenda = new Fazenda();

            this.fazendaBindingSource.DataSource = _fazenda;


        }

        public FormCadastroFazenda(int id_fazenda)
        {
            InitializeComponent();

            _context = new AgroDBEntities1();

            _fazenda = this._context.Fazendas.Find(id_fazenda);

            this.fazendaBindingSource.DataSource = _fazenda;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {

                 // VALIDANDO AREA AGRICOLA
                int areaagricola = int.Parse(area_AgricolaMaskedTextBox.Text);
                int total = int.Parse(area_totalMaskedTextBox.Text);
                if (areaagricola <= total)
                {
                    // FIM


                    this.Validate();


                    this._context.Fazendas.Add(_fazenda);



                    this._context.SaveChanges();



                    fazendaBindingSource.Clear();

                    MessageBox.Show("Registro Salvo com Sucesso.");
                    Close();
                }
                else {

                    MessageBox.Show("A área agricola não pode ser maior que  a área total da fazenda! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um ERRO ao Salvar MSG: "+erro.Message, "ERRO",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroFazenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                this.Close();
            }
        
        }

        private void area_AgricolaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
