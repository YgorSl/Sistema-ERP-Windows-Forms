namespace RestauranteADM.TELAS.Consulta
{
    partial class consultar_conta
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvconta = new System.Windows.Forms.DataGridView();
            this.Prestador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conta_Contabil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta_contabil_ds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_de_recebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estrapago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(544, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 22);
            this.button1.TabIndex = 85;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvconta
            // 
            this.dgvconta.AllowUserToDeleteRows = false;
            this.dgvconta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prestador,
            this.Cnpj,
            this.Tipo,
            this.Conta_Contabil,
            this.conta_contabil_ds,
            this.Banco,
            this.Agencia,
            this.Conta,
            this.data_de_recebimento,
            this.data_validade,
            this.Valor,
            this.Total_Parcelas,
            this.Parcelas,
            this.estrapago});
            this.dgvconta.Location = new System.Drawing.Point(11, 112);
            this.dgvconta.Name = "dgvconta";
            this.dgvconta.Size = new System.Drawing.Size(710, 244);
            this.dgvconta.TabIndex = 84;
            this.dgvconta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconta_CellContentClick);
            // 
            // Prestador
            // 
            this.Prestador.DataPropertyName = "Prestador";
            this.Prestador.HeaderText = "Prestador";
            this.Prestador.Name = "Prestador";
            // 
            // Cnpj
            // 
            this.Cnpj.DataPropertyName = "Cnpj";
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo_cobrança";
            this.Tipo.HeaderText = "Tipo Cobrança";
            this.Tipo.Name = "Tipo";
            // 
            // Conta_Contabil
            // 
            this.Conta_Contabil.DataPropertyName = "conta_contabil";
            this.Conta_Contabil.HeaderText = "Conta Contabil";
            this.Conta_Contabil.Name = "Conta_Contabil";
            // 
            // conta_contabil_ds
            // 
            this.conta_contabil_ds.DataPropertyName = "conta_contabil";
            this.conta_contabil_ds.HeaderText = "Conta_Descrição";
            this.conta_contabil_ds.Name = "conta_contabil_ds";
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            // 
            // Agencia
            // 
            this.Agencia.DataPropertyName = "agencia";
            this.Agencia.HeaderText = "Agencia";
            this.Agencia.Name = "Agencia";
            // 
            // Conta
            // 
            this.Conta.DataPropertyName = "conta";
            this.Conta.HeaderText = "Conta";
            this.Conta.Name = "Conta";
            // 
            // data_de_recebimento
            // 
            this.data_de_recebimento.DataPropertyName = "data_cadastro";
            this.data_de_recebimento.HeaderText = "Data Cadastro";
            this.data_de_recebimento.Name = "data_de_recebimento";
            this.data_de_recebimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // data_validade
            // 
            this.data_validade.DataPropertyName = "vencimento";
            this.data_validade.HeaderText = "Vencimento";
            this.data_validade.Name = "data_validade";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor_titulo";
            this.Valor.HeaderText = "ValorTtitulo";
            this.Valor.Name = "Valor";
            // 
            // Total_Parcelas
            // 
            this.Total_Parcelas.DataPropertyName = "parcelados";
            this.Total_Parcelas.HeaderText = "Total Parcelas";
            this.Total_Parcelas.Name = "Total_Parcelas";
            // 
            // Parcelas
            // 
            this.Parcelas.DataPropertyName = "valor_parcelas";
            this.Parcelas.HeaderText = "Valor_Parcelas";
            this.Parcelas.Name = "Parcelas";
            // 
            // estrapago
            // 
            this.estrapago.DataPropertyName = "pagou";
            this.estrapago.HeaderText = "Estar pagor";
            this.estrapago.Name = "estrapago";
            // 
            // dtpfim
            // 
            this.dtpfim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfim.Location = new System.Drawing.Point(144, 86);
            this.dtpfim.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(394, 20);
            this.dtpfim.TabIndex = 83;
            this.dtpfim.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // dtpinicio
            // 
            this.dtpinicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpinicio.Location = new System.Drawing.Point(144, 60);
            this.dtpinicio.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(394, 20);
            this.dtpinicio.TabIndex = 82;
            this.dtpinicio.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(670, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 39);
            this.label3.TabIndex = 86;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(523, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "Adicionar conta";
            // 
            // consultar_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(797, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvconta);
            this.Controls.Add(this.dtpfim);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultar_conta";
            this.Text = "consultar_conta";
            this.Load += new System.EventHandler(this.consultar_conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvconta;
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta_Contabil;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta_contabil_ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_de_recebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcelas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estrapago;
    }
}