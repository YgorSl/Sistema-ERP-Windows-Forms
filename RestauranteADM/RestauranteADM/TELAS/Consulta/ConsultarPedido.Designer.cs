namespace RestauranteADM.TELAS.Consulta
{
    partial class ConsultarPedido
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
            this.gvprod = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dti = new System.Windows.Forms.DateTimePicker();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // gvprod
            // 
            this.gvprod.AllowUserToAddRows = false;
            this.gvprod.AllowUserToDeleteRows = false;
            this.gvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.gvprod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvprod.Location = new System.Drawing.Point(0, 188);
            this.gvprod.Name = "gvprod";
            this.gvprod.ReadOnly = true;
            this.gvprod.Size = new System.Drawing.Size(752, 461);
            this.gvprod.TabIndex = 0;
            this.gvprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvprod_CellContentClick);
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
            this.Column4.DataPropertyName = "Nome";
            this.Column4.HeaderText = "Fornecedor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Total";
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPedido.Location = new System.Drawing.Point(452, 133);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarPedido.TabIndex = 1;
            this.btnConsultarPedido.Text = "Consultar";
            this.btnConsultarPedido.UseVisualStyleBackColor = false;
            this.btnConsultarPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fim Pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inicio Pedido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dti
            // 
            this.dti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dti.Location = new System.Drawing.Point(275, 110);
            this.dti.Name = "dti";
            this.dti.Size = new System.Drawing.Size(151, 20);
            this.dti.TabIndex = 4;
            this.dti.ValueChanged += new System.EventHandler(this.dti_ValueChanged);
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(275, 136);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(151, 20);
            this.dtpdate.TabIndex = 5;
            this.dtpdate.ValueChanged += new System.EventHandler(this.dtpdate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(263, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consultar Pedido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConsultarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(752, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.dti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.gvprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarPedido";
            this.Text = "ConsultarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.gvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvprod;
        private System.Windows.Forms.Button btnConsultarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dti;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}