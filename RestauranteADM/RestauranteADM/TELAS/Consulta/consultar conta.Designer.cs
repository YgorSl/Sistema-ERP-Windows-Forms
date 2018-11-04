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
            this.data_de_recebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(572, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 85;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvconta
            // 
            this.dgvconta.AllowUserToAddRows = false;
            this.dgvconta.AllowUserToDeleteRows = false;
            this.dgvconta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_de_recebimento,
            this.data_validade,
            this.Valor,
            this.Tipo});
            this.dgvconta.Location = new System.Drawing.Point(3, 150);
            this.dgvconta.Name = "dgvconta";
            this.dgvconta.Size = new System.Drawing.Size(718, 244);
            this.dgvconta.TabIndex = 84;
            // 
            // data_de_recebimento
            // 
            this.data_de_recebimento.DataPropertyName = "chegou";
            this.data_de_recebimento.HeaderText = "data de recebimento";
            this.data_de_recebimento.Name = "data_de_recebimento";
            // 
            // data_validade
            // 
            this.data_validade.DataPropertyName = "validade";
            this.data_validade.HeaderText = "data validade";
            this.data_validade.Name = "data_validade";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "preço";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // dtpfim
            // 
            this.dtpfim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfim.Location = new System.Drawing.Point(172, 86);
            this.dtpfim.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(394, 20);
            this.dtpfim.TabIndex = 83;
            this.dtpfim.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // dtpinicio
            // 
            this.dtpinicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpinicio.Location = new System.Drawing.Point(172, 60);
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
            this.label2.Location = new System.Drawing.Point(120, 90);
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
            this.label1.Location = new System.Drawing.Point(111, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "Início";
            // 
            // consultar_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvconta);
            this.Controls.Add(this.dtpfim);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "consultar_conta";
            this.Text = "consultar_conta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvconta;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_de_recebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}