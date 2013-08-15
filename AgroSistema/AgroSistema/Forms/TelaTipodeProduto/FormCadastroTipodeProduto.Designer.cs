namespace AgroSistema.Forms.TelaTipodeProduto
{
    partial class FormCadastroTipodeProduto
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
            System.Windows.Forms.Label tipoProdutoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tipo_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProdutoTextBox = new System.Windows.Forms.TextBox();
            tipoProdutoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_ProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tipoProdutoLabel);
            this.groupBox1.Controls.Add(this.tipoProdutoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 264);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 63);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Tipo de Produto";
            // 
            // tipo_ProdutoBindingSource
            // 
            this.tipo_ProdutoBindingSource.DataSource = typeof(AgroSistema.Tipo_Produto);
            // 
            // tipoProdutoLabel
            // 
            tipoProdutoLabel.AutoSize = true;
            tipoProdutoLabel.Location = new System.Drawing.Point(30, 23);
            tipoProdutoLabel.Name = "tipoProdutoLabel";
            tipoProdutoLabel.Size = new System.Drawing.Size(86, 13);
            tipoProdutoLabel.TabIndex = 0;
            tipoProdutoLabel.Text = "Tipo de Produto ";
            // 
            // tipoProdutoTextBox
            // 
            this.tipoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipo_ProdutoBindingSource, "TipoProduto", true));
            this.tipoProdutoTextBox.Location = new System.Drawing.Point(33, 39);
            this.tipoProdutoTextBox.Name = "tipoProdutoTextBox";
            this.tipoProdutoTextBox.Size = new System.Drawing.Size(339, 20);
            this.tipoProdutoTextBox.TabIndex = 1;
            // 
            // FormCadastroTipodeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(704, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadastroTipodeProduto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_ProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipoProdutoTextBox;
        private System.Windows.Forms.BindingSource tipo_ProdutoBindingSource;
    }
}
