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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.he = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioliquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvcliente.AllowUserToDeleteRows = false;
            this.dgvcliente.ColumnHeadersHeight = 40;
            this.dgvcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idfuncionario,
            this.he,
            this.dsr,
            this.bonus,
            this.vr,
            this.salarioliquido,
            this.vt,
            this.inss,
            this.irrf,
            this.fgts,
            this.convenio,
            this.cesta,
            this.atraso,
            this.faltas});
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
            this.label2.Text = "Prato:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 20);
            this.textBox1.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // idfuncionario
            // 
            this.idfuncionario.HeaderText = "ID do Funcionário";
            this.idfuncionario.Name = "idfuncionario";
            this.idfuncionario.ReadOnly = true;
            // 
            // he
            // 
            this.he.HeaderText = "Horas Extras";
            this.he.Name = "he";
            this.he.ReadOnly = true;
            // 
            // dsr
            // 
            this.dsr.HeaderText = "DSR";
            this.dsr.Name = "dsr";
            this.dsr.ReadOnly = true;
            // 
            // bonus
            // 
            this.bonus.HeaderText = "Bonus";
            this.bonus.Name = "bonus";
            this.bonus.ReadOnly = true;
            // 
            // vr
            // 
            this.vr.HeaderText = "VR";
            this.vr.Name = "vr";
            this.vr.ReadOnly = true;
            // 
            // salarioliquido
            // 
            this.salarioliquido.HeaderText = "Salario Liquido";
            this.salarioliquido.Name = "salarioliquido";
            this.salarioliquido.ReadOnly = true;
            // 
            // vt
            // 
            this.vt.HeaderText = "VT";
            this.vt.Name = "vt";
            this.vt.ReadOnly = true;
            // 
            // inss
            // 
            this.inss.HeaderText = "INSS";
            this.inss.Name = "inss";
            this.inss.ReadOnly = true;
            // 
            // irrf
            // 
            this.irrf.HeaderText = "IRRF";
            this.irrf.Name = "irrf";
            this.irrf.ReadOnly = true;
            // 
            // fgts
            // 
            this.fgts.HeaderText = "FGTS";
            this.fgts.Name = "fgts";
            this.fgts.ReadOnly = true;
            // 
            // convenio
            // 
            this.convenio.HeaderText = "Convenio";
            this.convenio.Name = "convenio";
            this.convenio.ReadOnly = true;
            // 
            // cesta
            // 
            this.cesta.HeaderText = "Cesta Basica";
            this.cesta.Name = "cesta";
            this.cesta.ReadOnly = true;
            // 
            // atraso
            // 
            this.atraso.HeaderText = "Desconto do Atraso";
            this.atraso.Name = "atraso";
            this.atraso.ReadOnly = true;
            // 
            // faltas
            // 
            this.faltas.HeaderText = "Desconto das Faltas";
            this.faltas.Name = "faltas";
            this.faltas.ReadOnly = true;
            // 
            // Consultar_Folha_de_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Consultar_Folha_de_Pagamento";
            this.Text = "Consultar_Folha_de_Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn he;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioliquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn inss;
        private System.Windows.Forms.DataGridViewTextBoxColumn irrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgts;
        private System.Windows.Forms.DataGridViewTextBoxColumn convenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn atraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas;
    }
}