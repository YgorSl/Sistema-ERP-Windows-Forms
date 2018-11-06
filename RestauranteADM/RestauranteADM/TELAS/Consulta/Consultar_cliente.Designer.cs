namespace RestauranteADM.TELAS
{
    partial class Consultar_cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.a = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_da_casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotaçao_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(90, 83);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(52, 16);
            this.a.TabIndex = 17;
            this.a.Text = "Cliente:";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(152, 81);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(380, 20);
            this.txtcliente.TabIndex = 16;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCliente.Location = new System.Drawing.Point(538, 107);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 15;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(263, 42);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(183, 24);
            this.label36.TabIndex = 47;
            this.label36.Text = "Consultar cliente";
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Telefone,
            this.CEP,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.Numero_da_casa,
            this.Tipo_Pessoa,
            this.Cnpj,
            this.anotaçao_cliente,
            this.Data_Cadastro,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcliente.Location = new System.Drawing.Point(0, 164);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.Size = new System.Drawing.Size(752, 485);
            this.dgvcliente.TabIndex = 48;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick_1);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 300F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 40;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "Cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 70;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "Cep";
            this.CEP.HeaderText = "CEP";
            this.CEP.MinimumWidth = 20;
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "Rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // Numero_da_casa
            // 
            this.Numero_da_casa.DataPropertyName = "Numerocasa";
            this.Numero_da_casa.HeaderText = "Numero_da_casa";
            this.Numero_da_casa.Name = "Numero_da_casa";
            this.Numero_da_casa.ReadOnly = true;
            this.Numero_da_casa.Width = 48;
            // 
            // Tipo_Pessoa
            // 
            this.Tipo_Pessoa.DataPropertyName = "tipopessoa";
            this.Tipo_Pessoa.HeaderText = "Tipo_Pessoa";
            this.Tipo_Pessoa.Name = "Tipo_Pessoa";
            this.Tipo_Pessoa.ReadOnly = true;
            this.Tipo_Pessoa.Width = 70;
            // 
            // Cnpj
            // 
            this.Cnpj.DataPropertyName = "Cnpj";
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ReadOnly = true;
            // 
            // anotaçao_cliente
            // 
            this.anotaçao_cliente.DataPropertyName = "anotaçao_cliente";
            this.anotaçao_cliente.HeaderText = "anotaçao_cliente";
            this.anotaçao_cliente.Name = "anotaçao_cliente";
            this.anotaçao_cliente.ReadOnly = true;
            // 
            // Data_Cadastro
            // 
            this.Data_Cadastro.DataPropertyName = "data_hoje";
            this.Data_Cadastro.HeaderText = "Data_Cadastro";
            this.Data_Cadastro.Name = "Data_Cadastro";
            this.Data_Cadastro.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 300F;
            this.Column2.HeaderText = "";
            this.Column2.Image = global::RestauranteADM.Properties.Resources._1;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::RestauranteADM.Properties.Resources.erro;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "CPF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(152, 110);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(380, 20);
            this.txtcpf.TabIndex = 50;
            this.txtcpf.TextChanged += new System.EventHandler(this.txtcpf_TextChanged);
            // 
            // Consultar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 649);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_cliente";
            this.Load += new System.EventHandler(this.Consultar_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_da_casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotaçao_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}