namespace RestauranteADM.TELAS.Consulta
{
    partial class crud_funcionario
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
            this.dgvfuncio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.txtfuncio = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfuncio
            // 
            this.dgvfuncio.AllowUserToAddRows = false;
            this.dgvfuncio.AllowUserToDeleteRows = false;
            this.dgvfuncio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfuncio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Rg,
            this.cpr,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.N_local,
            this.Salario,
            this.Gmail,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfuncio.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfuncio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvfuncio.Location = new System.Drawing.Point(0, 185);
            this.dgvfuncio.Name = "dgvfuncio";
            this.dgvfuncio.ReadOnly = true;
            this.dgvfuncio.Size = new System.Drawing.Size(752, 412);
            this.dgvfuncio.TabIndex = 33;
            this.dgvfuncio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(635, 79);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(81, 30);
            this.btnConsultarFuncionario.TabIndex = 31;
            this.btnConsultarFuncionario.Text = "Consultar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(52, 91);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(81, 16);
            this.a.TabIndex = 28;
            this.a.Text = "Funcionario:";
            // 
            // txtfuncio
            // 
            this.txtfuncio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfuncio.Location = new System.Drawing.Point(154, 82);
            this.txtfuncio.Name = "txtfuncio";
            this.txtfuncio.Size = new System.Drawing.Size(465, 25);
            this.txtfuncio.TabIndex = 27;
            this.txtfuncio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeypressFuncionario);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 300F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::RestauranteADM.Properties.Resources._1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::RestauranteADM.Properties.Resources.erro;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "CPF";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(154, 124);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(465, 25);
            this.txtcpf.TabIndex = 34;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 300F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 40;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPF.DataPropertyName = "Cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 20;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Rg
            // 
            this.Rg.DataPropertyName = "Rg";
            this.Rg.HeaderText = "Rg";
            this.Rg.Name = "Rg";
            this.Rg.ReadOnly = true;
            // 
            // cpr
            // 
            this.cpr.DataPropertyName = "Cep";
            this.cpr.HeaderText = "CEP";
            this.cpr.Name = "cpr";
            this.cpr.ReadOnly = true;
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
            // N_local
            // 
            this.N_local.DataPropertyName = "N_local";
            this.N_local.HeaderText = "N_local";
            this.N_local.Name = "N_local";
            this.N_local.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Gmail
            // 
            this.Gmail.DataPropertyName = "Gmail";
            this.Gmail.HeaderText = "Gmail";
            this.Gmail.Name = "Gmail";
            this.Gmail.ReadOnly = true;
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
            this.Column2.Width = 50;
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
            this.Column1.Width = 50;
            // 
            // crud_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(752, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvfuncio);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtfuncio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crud_funcionario";
            this.Text = "crud_funcionario";
            this.Load += new System.EventHandler(this.crud_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtfuncio;
        private System.Windows.Forms.DataGridView dgvfuncio;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gmail;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}