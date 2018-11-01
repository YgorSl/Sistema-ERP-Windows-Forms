namespace RestauranteADM.TELAS.Consulta
{
    partial class ConsultarVendas
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.dti = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarVenda = new System.Windows.Forms.Button();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_prato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Consultar Vendas";
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(275, 115);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(151, 20);
            this.dtpdate.TabIndex = 12;
            // 
            // dti
            // 
            this.dti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dti.Location = new System.Drawing.Point(275, 89);
            this.dti.Name = "dti";
            this.dti.Size = new System.Drawing.Size(151, 20);
            this.dti.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inicio Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fim Pedido";
            // 
            // btnConsultarVenda
            // 
            this.btnConsultarVenda.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVenda.Location = new System.Drawing.Point(452, 112);
            this.btnConsultarVenda.Name = "btnConsultarVenda";
            this.btnConsultarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVenda.TabIndex = 8;
            this.btnConsultarVenda.Text = "Consultar";
            this.btnConsultarVenda.UseVisualStyleBackColor = false;
            this.btnConsultarVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvvendas
            // 
            this.dgvvendas.AllowUserToAddRows = false;
            this.dgvvendas.AllowUserToDeleteRows = false;
            this.dgvvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Nome_prato,
            this.Column1});
            this.dgvvendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvvendas.Location = new System.Drawing.Point(0, 185);
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.ReadOnly = true;
            this.dgvvendas.Size = new System.Drawing.Size(752, 412);
            this.dgvvendas.TabIndex = 7;
            this.dgvvendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendas_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Data";
            this.Column2.HeaderText = "Data";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Qtd";
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Nome_cliente";
            this.Column4.HeaderText = "Cliente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Nome_prato
            // 
            this.Nome_prato.DataPropertyName = "Nome_prato";
            this.Nome_prato.HeaderText = "Prato";
            this.Nome_prato.Name = "Nome_prato";
            this.Nome_prato.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Total";
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(752, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.dti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultarVenda);
            this.Controls.Add(this.dgvvendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarVendas";
            this.Text = "ConsultarVendas";
            this.Load += new System.EventHandler(this.ConsultarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.DateTimePicker dti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarVenda;
        private System.Windows.Forms.DataGridView dgvvendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_prato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}