namespace RestauranteADM.TELAS.Consulta
{
    partial class Consultar_fluxo_caixa
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
            this.dgvfluxo = new System.Windows.Forms.DataGridView();
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ganhor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluxo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(532, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 73;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvfluxo
            // 
            this.dgvfluxo.AllowUserToAddRows = false;
            this.dgvfluxo.AllowUserToDeleteRows = false;
            this.dgvfluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfluxo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganhor,
            this.perdau,
            this.Column1,
            this.Column2});
            this.dgvfluxo.Location = new System.Drawing.Point(11, 187);
            this.dgvfluxo.Name = "dgvfluxo";
            this.dgvfluxo.Size = new System.Drawing.Size(752, 244);
            this.dgvfluxo.TabIndex = 72;
            // 
            // dtpfim
            // 
            this.dtpfim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfim.Location = new System.Drawing.Point(213, 124);
            this.dtpfim.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(294, 20);
            this.dtpfim.TabIndex = 71;
            this.dtpfim.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // dtpinicio
            // 
            this.dtpinicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpinicio.Location = new System.Drawing.Point(213, 98);
            this.dtpinicio.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(294, 20);
            this.dtpinicio.TabIndex = 70;
            this.dtpinicio.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Início";
            // 
            // ganhor
            // 
            this.ganhor.DataPropertyName = "ganhor";
            this.ganhor.HeaderText = "Ganhou";
            this.ganhor.Name = "ganhor";
            // 
            // perdau
            // 
            this.perdau.DataPropertyName = "perdeu";
            this.perdau.HeaderText = "Perdar";
            this.perdau.Name = "perdau";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "saldo";
            this.Column1.HeaderText = "Saldo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Periodo inicial";
            this.Column2.Name = "Column2";
            // 
            // Consultar_fluxo_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvfluxo);
            this.Controls.Add(this.dtpfim);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultar_fluxo_caixa";
            this.Text = "Consultar_fluxo_caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluxo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvfluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganhor;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}