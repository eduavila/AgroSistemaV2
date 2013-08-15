namespace AgroSistema.Forms.TelaTipodeProduto
{
    partial class FormTipodeProduto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgw = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Dgw);
            this.panel2.Location = new System.Drawing.Point(162, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 355);
            this.panel2.TabIndex = 7;
            // 
            // Dgw
            // 
            this.Dgw.AllowUserToAddRows = false;
            this.Dgw.AllowUserToDeleteRows = false;
            this.Dgw.AutoGenerateColumns = false;
            this.Dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoProdutoDataGridViewTextBoxColumn});
            this.Dgw.DataSource = this.tipoProdutoBindingSource;
            this.Dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgw.Location = new System.Drawing.Point(0, 0);
            this.Dgw.Name = "Dgw";
            this.Dgw.ReadOnly = true;
            this.Dgw.RowHeadersVisible = false;
            this.Dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw.Size = new System.Drawing.Size(493, 355);
            this.Dgw.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProdutoDataGridViewTextBoxColumn
            // 
            this.tipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "TipoProduto";
            this.tipoProdutoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.tipoProdutoDataGridViewTextBoxColumn.Name = "tipoProdutoDataGridViewTextBoxColumn";
            this.tipoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProdutoBindingSource
            // 
            this.tipoProdutoBindingSource.DataSource = typeof(AgroSistema.Tipo_Produto);
            // 
            // FormTipodeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(657, 359);
            this.Controls.Add(this.panel2);
            this.Name = "FormTipodeProduto";
            this.Text = "Tipo de Produto";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoProdutoBindingSource;
    }
}
