namespace AgroSistema.Forms.TelaFuncionario
{
    partial class FormCadastroFuncionario
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
            System.Windows.Forms.Label nome_FuncionarioLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label salario_AtualLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label data_AdmissaoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.data_AdmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_DemissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.uFComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.salario_AtualMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nome_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            nome_FuncionarioLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            salario_AtualLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            data_AdmissaoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_FuncionarioLabel
            // 
            nome_FuncionarioLabel.AutoSize = true;
            nome_FuncionarioLabel.Location = new System.Drawing.Point(10, 16);
            nome_FuncionarioLabel.Name = "nome_FuncionarioLabel";
            nome_FuncionarioLabel.Size = new System.Drawing.Size(82, 13);
            nome_FuncionarioLabel.TabIndex = 0;
            nome_FuncionarioLabel.Text = "Nome Completo";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(308, 16);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(23, 13);
            rgLabel.TabIndex = 2;
            rgLabel.Text = "RG";
            // 
            // salario_AtualLabel
            // 
            salario_AtualLabel.AutoSize = true;
            salario_AtualLabel.Location = new System.Drawing.Point(10, 190);
            salario_AtualLabel.Name = "salario_AtualLabel";
            salario_AtualLabel.Size = new System.Drawing.Size(66, 13);
            salario_AtualLabel.TabIndex = 4;
            salario_AtualLabel.Text = "Salario Atual";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(10, 140);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(539, 81);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 8;
            uFLabel.Text = "UF:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(10, 81);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 10;
            enderecoLabel.Text = "Endereço";
            enderecoLabel.Click += new System.EventHandler(this.enderecoLabel_Click);
            // 
            // data_AdmissaoLabel
            // 
            data_AdmissaoLabel.AutoSize = true;
            data_AdmissaoLabel.Location = new System.Drawing.Point(309, 137);
            data_AdmissaoLabel.Name = "data_AdmissaoLabel";
            data_AdmissaoLabel.Size = new System.Drawing.Size(78, 13);
            data_AdmissaoLabel.TabIndex = 14;
            data_AdmissaoLabel.Text = "Data Admissao";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(309, 80);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(40, 13);
            cidadeLabel.TabIndex = 16;
            cidadeLabel.Text = "Cidade";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new System.Drawing.Point(142, 137);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(35, 13);
            cargoLabel.TabIndex = 18;
            cargoLabel.Text = "Cargo";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(465, 16);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(27, 13);
            cpfLabel.TabIndex = 20;
            cpfLabel.Text = "CPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(cpfLabel);
            this.groupBox1.Controls.Add(this.cpfMaskedTextBox);
            this.groupBox1.Controls.Add(cargoLabel);
            this.groupBox1.Controls.Add(this.cargoTextBox);
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(data_AdmissaoLabel);
            this.groupBox1.Controls.Add(this.data_AdmissaoDateTimePicker);
            this.groupBox1.Controls.Add(this.data_DemissaoDateTimePicker);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Controls.Add(uFLabel);
            this.groupBox1.Controls.Add(this.uFComboBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(salario_AtualLabel);
            this.groupBox1.Controls.Add(this.salario_AtualMaskedTextBox);
            this.groupBox1.Controls.Add(rgLabel);
            this.groupBox1.Controls.Add(this.rgMaskedTextBox);
            this.groupBox1.Controls.Add(nome_FuncionarioLabel);
            this.groupBox1.Controls.Add(this.nome_FuncionarioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 250);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(AgroSistema.Funcionario);
            // 
            // fazendaBindingSource
            // 
            this.fazendaBindingSource.DataSource = typeof(AgroSistema.Fazenda);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(502, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Demissão";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(468, 32);
            this.cpfMaskedTextBox.Mask = "000.000.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(146, 20);
            this.cpfMaskedTextBox.TabIndex = 21;
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Cargo", true));
            this.cargoTextBox.Location = new System.Drawing.Point(145, 156);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(133, 20);
            this.cargoTextBox.TabIndex = 19;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(311, 97);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(208, 20);
            this.cidadeTextBox.TabIndex = 17;
            // 
            // data_AdmissaoDateTimePicker
            // 
            this.data_AdmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.funcionarioBindingSource, "Data_Admissao", true));
            this.data_AdmissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_AdmissaoDateTimePicker.Location = new System.Drawing.Point(312, 156);
            this.data_AdmissaoDateTimePicker.Name = "data_AdmissaoDateTimePicker";
            this.data_AdmissaoDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.data_AdmissaoDateTimePicker.TabIndex = 15;
            // 
            // data_DemissaoDateTimePicker
            // 
            this.data_DemissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.funcionarioBindingSource, "Data_Demissao", true));
            this.data_DemissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_DemissaoDateTimePicker.Location = new System.Drawing.Point(502, 156);
            this.data_DemissaoDateTimePicker.Name = "data_DemissaoDateTimePicker";
            this.data_DemissaoDateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.data_DemissaoDateTimePicker.TabIndex = 13;
            this.data_DemissaoDateTimePicker.Visible = false;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(10, 97);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(268, 20);
            this.enderecoTextBox.TabIndex = 11;
            // 
            // uFComboBox
            // 
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "UF", true));
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.funcionarioBindingSource, "UF", true));
            this.uFComboBox.FormattingEnabled = true;
            this.uFComboBox.Items.AddRange(new object[] {
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS, ",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.uFComboBox.Location = new System.Drawing.Point(542, 96);
            this.uFComboBox.Name = "uFComboBox";
            this.uFComboBox.Size = new System.Drawing.Size(72, 21);
            this.uFComboBox.TabIndex = 9;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(13, 156);
            this.telefoneMaskedTextBox.Mask = "(99) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneMaskedTextBox.TabIndex = 7;
            // 
            // salario_AtualMaskedTextBox
            // 
            this.salario_AtualMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Salario_Atual", true));
            this.salario_AtualMaskedTextBox.Location = new System.Drawing.Point(13, 206);
            this.salario_AtualMaskedTextBox.Name = "salario_AtualMaskedTextBox";
            this.salario_AtualMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.salario_AtualMaskedTextBox.TabIndex = 5;
            // 
            // rgMaskedTextBox
            // 
            this.rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Rg", true));
            this.rgMaskedTextBox.Location = new System.Drawing.Point(311, 32);
            this.rgMaskedTextBox.Mask = "000000";
            this.rgMaskedTextBox.Name = "rgMaskedTextBox";
            this.rgMaskedTextBox.Size = new System.Drawing.Size(127, 20);
            this.rgMaskedTextBox.TabIndex = 3;
            // 
            // nome_FuncionarioTextBox
            // 
            this.nome_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome_Funcionario", true));
            this.nome_FuncionarioTextBox.Location = new System.Drawing.Point(13, 32);
            this.nome_FuncionarioTextBox.Name = "nome_FuncionarioTextBox";
            this.nome_FuncionarioTextBox.Size = new System.Drawing.Size(265, 20);
            this.nome_FuncionarioTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 63);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Funcionário ";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(360, 314);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(132, 38);
            this.btn_salvar.TabIndex = 16;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(512, 314);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 364);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.DateTimePicker data_AdmissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_DemissaoDateTimePicker;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.ComboBox uFComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox salario_AtualMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rgMaskedTextBox;
        private System.Windows.Forms.TextBox nome_FuncionarioTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource fazendaBindingSource;
    }
}