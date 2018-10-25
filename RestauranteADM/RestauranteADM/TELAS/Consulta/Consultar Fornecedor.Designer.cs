namespace RestauranteADM.TELAS.Consulta
{
    partial class Consultar_Fornecedor
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
            this.a = new System.Windows.Forms.Label();
            this.txtforn = new System.Windows.Forms.TextBox();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label36 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(90, 95);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(81, 16);
            this.a.TabIndex = 35;
            this.a.Text = "Fornecedor:";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // txtforn
            // 
            this.txtforn.Location = new System.Drawing.Point(188, 94);
            this.txtforn.Name = "txtforn";
            this.txtforn.Size = new System.Drawing.Size(380, 20);
            this.txtforn.TabIndex = 34;
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(587, 117);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarFornecedor.TabIndex = 33;
            this.btnConsultarFornecedor.Text = "Consultar";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AllowUserToDeleteRows = false;
            this.dgvcliente.ColumnHeadersHeight = 40;
            this.dgvcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nome,
            this.CPF,
            this.CEP,
            this.Column3,
            this.Column2});
            this.dgvcliente.Location = new System.Drawing.Point(0, 185);
            this.dgvcliente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 32);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.RowHeadersVisible = false;
            this.dgvcliente.Size = new System.Drawing.Size(752, 412);
            this.dgvcliente.TabIndex = 32;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPF.DataPropertyName = "Cnpj";
            this.CPF.HeaderText = "Cnpj";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CEP.DataPropertyName = "Telefone";
            this.CEP.HeaderText = "Telefone";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Image = global::RestauranteADM.Properties.Resources.aff;
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Image = global::RestauranteADM.Properties.Resources.xx;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 30;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(263, 42);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(220, 25);
            this.label36.TabIndex = 47;
            this.label36.Text = "Consultar Fornecedor";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(188, 120);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(380, 20);
            this.txtc.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cnpj:";
            // 
            // Consultar_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 597);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtforn);
            this.Controls.Add(this.btnConsultarFornecedor);
            this.Controls.Add(this.dgvcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_Fornecedor";
            this.Load += new System.EventHandler(this.Consultar_Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtforn;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}