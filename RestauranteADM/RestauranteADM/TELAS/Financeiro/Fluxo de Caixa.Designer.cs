namespace RestauranteADM.TELAS.Financeiro
{
    partial class Fluxo_de_Caixa
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
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvfluxo = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label36 = new System.Windows.Forms.Label();
            this.lblsituaçao = new System.Windows.Forms.Label();
            this.lblsituaca = new System.Windows.Forms.Label();
            this.txtbuscarfluxo = new System.Windows.Forms.Button();
            this.lblsaida = new System.Windows.Forms.Label();
            this.lblcompra = new System.Windows.Forms.Label();
            this.lblvenda = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblentrada = new System.Windows.Forms.Label();
            this.btnfluxo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluxo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfim
            // 
            this.dtpfim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfim.Location = new System.Drawing.Point(202, 163);
            this.dtpfim.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(294, 20);
            this.dtpfim.TabIndex = 60;
            this.dtpfim.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            this.dtpfim.ValueChanged += new System.EventHandler(this.dtpfim_ValueChanged);
            // 
            // dtpinicio
            // 
            this.dtpinicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpinicio.Location = new System.Drawing.Point(202, 137);
            this.dtpinicio.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(294, 20);
            this.dtpinicio.TabIndex = 55;
            this.dtpinicio.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            this.dtpinicio.ValueChanged += new System.EventHandler(this.dtpinicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Início";
            // 
            // dgvfluxo
            // 
            this.dgvfluxo.AllowUserToAddRows = false;
            this.dgvfluxo.AllowUserToDeleteRows = false;
            this.dgvfluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfluxo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Valor,
            this.Movimento,
            this.Column1});
            this.dgvfluxo.Location = new System.Drawing.Point(0, 226);
            this.dgvfluxo.Name = "dgvfluxo";
            this.dgvfluxo.ReadOnly = true;
            this.dgvfluxo.Size = new System.Drawing.Size(752, 244);
            this.dgvfluxo.TabIndex = 61;
            this.dgvfluxo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfluxo_CellContentClick);
            this.dgvfluxo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvfluxo_DataBindingComplete);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valortotal";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Movimento
            // 
            this.Movimento.DataPropertyName = "movimento";
            this.Movimento.HeaderText = "Movimento";
            this.Movimento.Name = "Movimento";
            this.Movimento.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tipo_de_operacao";
            this.Column1.HeaderText = "Operação";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(294, 51);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(152, 25);
            this.label36.TabIndex = 64;
            this.label36.Text = "Fluxo de caixa";
            // 
            // lblsituaçao
            // 
            this.lblsituaçao.AutoSize = true;
            this.lblsituaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituaçao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsituaçao.Location = new System.Drawing.Point(542, 481);
            this.lblsituaçao.Name = "lblsituaçao";
            this.lblsituaçao.Size = new System.Drawing.Size(82, 24);
            this.lblsituaçao.TabIndex = 65;
            this.lblsituaçao.Text = "Situação";
            // 
            // lblsituaca
            // 
            this.lblsituaca.AutoSize = true;
            this.lblsituaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsituaca.Location = new System.Drawing.Point(638, 481);
            this.lblsituaca.Name = "lblsituaca";
            this.lblsituaca.Size = new System.Drawing.Size(52, 24);
            this.lblsituaca.TabIndex = 66;
            this.lblsituaca.Text = "-------";
            // 
            // txtbuscarfluxo
            // 
            this.txtbuscarfluxo.BackColor = System.Drawing.Color.SeaGreen;
            this.txtbuscarfluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbuscarfluxo.Location = new System.Drawing.Point(521, 154);
            this.txtbuscarfluxo.Name = "txtbuscarfluxo";
            this.txtbuscarfluxo.Size = new System.Drawing.Size(80, 29);
            this.txtbuscarfluxo.TabIndex = 67;
            this.txtbuscarfluxo.Text = "Buscar";
            this.txtbuscarfluxo.UseVisualStyleBackColor = false;
            this.txtbuscarfluxo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsaida
            // 
            this.lblsaida.AutoSize = true;
            this.lblsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsaida.Location = new System.Drawing.Point(224, 476);
            this.lblsaida.Name = "lblsaida";
            this.lblsaida.Size = new System.Drawing.Size(52, 24);
            this.lblsaida.TabIndex = 69;
            this.lblsaida.Text = "-------";
            this.lblsaida.Click += new System.EventHandler(this.lblsaida_Click);
            // 
            // lblcompra
            // 
            this.lblcompra.AutoSize = true;
            this.lblcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcompra.Location = new System.Drawing.Point(128, 476);
            this.lblcompra.Name = "lblcompra";
            this.lblcompra.Size = new System.Drawing.Size(57, 24);
            this.lblcompra.TabIndex = 68;
            this.lblcompra.Text = "Saída";
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblvenda.Location = new System.Drawing.Point(224, 498);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(0, 24);
            this.lblvenda.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(128, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 70;
            this.label7.Text = "Entrada";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 72;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblentrada
            // 
            this.lblentrada.AutoSize = true;
            this.lblentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblentrada.Location = new System.Drawing.Point(224, 498);
            this.lblentrada.Name = "lblentrada";
            this.lblentrada.Size = new System.Drawing.Size(52, 24);
            this.lblentrada.TabIndex = 73;
            this.lblentrada.Text = "-------";
            // 
            // btnfluxo
            // 
            this.btnfluxo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnfluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfluxo.Location = new System.Drawing.Point(452, 476);
            this.btnfluxo.Name = "btnfluxo";
            this.btnfluxo.Size = new System.Drawing.Size(84, 37);
            this.btnfluxo.TabIndex = 74;
            this.btnfluxo.Text = "Salvar Fluxo";
            this.btnfluxo.UseVisualStyleBackColor = false;
            this.btnfluxo.Click += new System.EventHandler(this.btnfluxo_Click);
            // 
            // Fluxo_de_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 597);
            this.Controls.Add(this.btnfluxo);
            this.Controls.Add(this.lblentrada);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblsaida);
            this.Controls.Add(this.lblcompra);
            this.Controls.Add(this.txtbuscarfluxo);
            this.Controls.Add(this.lblsituaca);
            this.Controls.Add(this.lblsituaçao);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dgvfluxo);
            this.Controls.Add(this.dtpfim);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fluxo_de_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo_de_Caixa";
            this.Load += new System.EventHandler(this.Fluxo_de_Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluxo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvfluxo;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblsituaçao;
        private System.Windows.Forms.Label lblsituaca;
        private System.Windows.Forms.Button txtbuscarfluxo;
        private System.Windows.Forms.Label lblsaida;
        private System.Windows.Forms.Label lblcompra;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblentrada;
        private System.Windows.Forms.Button btnfluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}