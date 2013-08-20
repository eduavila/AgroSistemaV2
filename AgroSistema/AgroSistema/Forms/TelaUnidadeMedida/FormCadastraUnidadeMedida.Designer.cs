namespace AgroSistema.Forms.TelaUnidadeMedida
{
    partial class FormCadastraUnidadeMedida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label unidadeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unidadeTextBox = new System.Windows.Forms.TextBox();
            this.unidadeMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            unidadeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeMedidaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(39, 29);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(55, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descrição";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new System.Drawing.Point(39, 89);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new System.Drawing.Size(47, 13);
            unidadeLabel.TabIndex = 4;
            unidadeLabel.Text = "Unidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(unidadeLabel);
            this.groupBox1.Controls.Add(this.unidadeTextBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 264);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // unidadeTextBox
            // 
            this.unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeMedidaBindingSource, "Unidade", true));
            this.unidadeTextBox.Location = new System.Drawing.Point(42, 105);
            this.unidadeTextBox.Name = "unidadeTextBox";
            this.unidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.unidadeTextBox.TabIndex = 5;
            // 
            // unidadeMedidaBindingSource
            // 
            this.unidadeMedidaBindingSource.DataSource = typeof(AgroSistema.UnidadeMedida);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeMedidaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(42, 45);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(309, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 63);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Unidade Medida";
            // 
            // FormCadastraUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(704, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadastraUnidadeMedida";
            this.Text = "Unidade Medida";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeMedidaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource unidadeMedidaBindingSource;
        private System.Windows.Forms.TextBox unidadeTextBox;
    }
}
