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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fluxo_de_Caixa));
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvfluxo = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.Operação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsituaçao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluxo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfim
            // 
            this.dtpfim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfim.Location = new System.Drawing.Point(94, 85);
            this.dtpfim.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(294, 20);
            this.dtpfim.TabIndex = 60;
            this.dtpfim.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // dtpinicio
            // 
            this.dtpinicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpinicio.Location = new System.Drawing.Point(94, 59);
            this.dtpinicio.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(294, 20);
            this.dtpinicio.TabIndex = 55;
            this.dtpinicio.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 89);
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
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Inicio";
            // 
            // dgvfluxo
            // 
            this.dgvfluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfluxo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operação,
            this.Total});
            this.dgvfluxo.Location = new System.Drawing.Point(0, 128);
            this.dgvfluxo.Name = "dgvfluxo";
            this.dgvfluxo.Size = new System.Drawing.Size(660, 177);
            this.dgvfluxo.TabIndex = 61;
            this.dgvfluxo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfluxo_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(603, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(104, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(152, 25);
            this.label36.TabIndex = 64;
            this.label36.Text = "Fluxo de caixa";
            // 
            // Operação
            // 
            this.Operação.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operação.DataPropertyName = "valorpagar";
            this.Operação.HeaderText = "Operação";
            this.Operação.Name = "Operação";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "valorareceber";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // lblsituaçao
            // 
            this.lblsituaçao.AutoSize = true;
            this.lblsituaçao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituaçao.Location = new System.Drawing.Point(454, 339);
            this.lblsituaçao.Name = "lblsituaçao";
            this.lblsituaçao.Size = new System.Drawing.Size(80, 22);
            this.lblsituaçao.TabIndex = 65;
            this.lblsituaçao.Text = "situaçao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "-------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 67;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fluxo_de_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsituaçao);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvfluxo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblsituaçao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}