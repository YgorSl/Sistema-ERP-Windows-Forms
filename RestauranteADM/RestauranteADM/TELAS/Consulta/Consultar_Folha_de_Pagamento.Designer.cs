namespace RestauranteADM.TELAS.Consulta
{
    partial class Consultar_Folha_de_Pagamento
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
            this.label36 = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioliquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Yellow;
            this.label36.Location = new System.Drawing.Point(281, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(318, 30);
            this.label36.TabIndex = 54;
            this.label36.Text = "Consultar Folha de Pagamento";
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AllowUserToDeleteRows = false;
            this.dgvcliente.ColumnHeadersHeight = 40;
            this.dgvcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.vr,
            this.dsr,
            this.salarioliquido,
            this.HEr,
            this.vt,
            this.inss,
            this.irrf,
            this.fgts,
            this.convenio,
            this.atraso,
            this.cesta,
            this.faltas,
            this.bonus,
            this.j});
            this.dgvcliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcliente.Location = new System.Drawing.Point(0, 132);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.RowHeadersVisible = false;
            this.dgvcliente.Size = new System.Drawing.Size(800, 318);
            this.dgvcliente.TabIndex = 51;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(192, 57);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(380, 20);
            this.txtnome.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
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
            // vr
            // 
            this.vr.DataPropertyName = "VR";
            this.vr.HeaderText = "VR";
            this.vr.Name = "vr";
            this.vr.ReadOnly = true;
            // 
            // dsr
            // 
            this.dsr.DataPropertyName = "DSR";
            this.dsr.HeaderText = "DSR";
            this.dsr.Name = "dsr";
            this.dsr.ReadOnly = true;
            // 
            // salarioliquido
            // 
            this.salarioliquido.DataPropertyName = "SalarioLiquido";
            this.salarioliquido.HeaderText = "Salario Liquido";
            this.salarioliquido.Name = "salarioliquido";
            this.salarioliquido.ReadOnly = true;
            // 
            // HEr
            // 
            this.HEr.DataPropertyName = "HE";
            this.HEr.HeaderText = "HE";
            this.HEr.Name = "HEr";
            this.HEr.ReadOnly = true;
            // 
            // vt
            // 
            this.vt.DataPropertyName = "VT";
            this.vt.HeaderText = "VT";
            this.vt.Name = "vt";
            this.vt.ReadOnly = true;
            // 
            // inss
            // 
            this.inss.DataPropertyName = "INSS";
            this.inss.HeaderText = "INSS";
            this.inss.Name = "inss";
            this.inss.ReadOnly = true;
            // 
            // irrf
            // 
            this.irrf.DataPropertyName = "IRRF";
            this.irrf.HeaderText = "IRRF";
            this.irrf.Name = "irrf";
            this.irrf.ReadOnly = true;
            // 
            // fgts
            // 
            this.fgts.DataPropertyName = "FGTS";
            this.fgts.HeaderText = "FGTS";
            this.fgts.Name = "fgts";
            this.fgts.ReadOnly = true;
            // 
            // convenio
            // 
            this.convenio.DataPropertyName = "Convenio";
            this.convenio.HeaderText = "Convenio";
            this.convenio.Name = "convenio";
            this.convenio.ReadOnly = true;
            // 
            // atraso
            // 
            this.atraso.DataPropertyName = "Atraso";
            this.atraso.HeaderText = "Desconto do Atraso";
            this.atraso.Name = "atraso";
            this.atraso.ReadOnly = true;
            // 
            // cesta
            // 
            this.cesta.DataPropertyName = "CestaBasica";
            this.cesta.HeaderText = "Cesta Basica";
            this.cesta.Name = "cesta";
            this.cesta.ReadOnly = true;
            // 
            // faltas
            // 
            this.faltas.DataPropertyName = "Falta";
            this.faltas.HeaderText = "Desconto das Faltas";
            this.faltas.Name = "faltas";
            this.faltas.ReadOnly = true;
            // 
            // bonus
            // 
            this.bonus.DataPropertyName = "Bonus";
            this.bonus.HeaderText = "Bonus";
            this.bonus.Name = "bonus";
            this.bonus.ReadOnly = true;
            // 
            // j
            // 
            this.j.HeaderText = "";
            this.j.Image = global::RestauranteADM.Properties.Resources.erro;
            this.j.Name = "j";
            this.j.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "cpf";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(192, 84);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(380, 20);
            this.txtcpf.TabIndex = 55;
            this.txtcpf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Consultar_Folha_de_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.button1);
            this.Name = "Consultar_Folha_de_Pagamento";
            this.Text = "Consultar_Folha_de_Pagamento";
            this.Load += new System.EventHandler(this.Consultar_Folha_de_Pagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioliquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEr;
        private System.Windows.Forms.DataGridViewTextBoxColumn vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn inss;
        private System.Windows.Forms.DataGridViewTextBoxColumn irrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgts;
        private System.Windows.Forms.DataGridViewTextBoxColumn convenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn atraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewImageColumn j;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcpf;
    }
}