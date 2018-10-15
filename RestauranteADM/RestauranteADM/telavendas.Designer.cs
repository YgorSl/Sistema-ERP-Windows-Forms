namespace RestauranteADM
{
    partial class telavendas
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.btnnova = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.nuddes = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpreço = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupqnt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmprato = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuddes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupqnt)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "cliente";
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(450, 2);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(226, 20);
            this.dtpdata.TabIndex = 61;
            this.dtpdata.ValueChanged += new System.EventHandler(this.dtpdata_ValueChanged);
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(70, 5);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(374, 21);
            this.cmbcliente.TabIndex = 62;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // btnnova
            // 
            this.btnnova.Location = new System.Drawing.Point(508, 58);
            this.btnnova.Name = "btnnova";
            this.btnnova.Size = new System.Drawing.Size(141, 23);
            this.btnnova.TabIndex = 65;
            this.btnnova.Text = "nova venda";
            this.btnnova.UseVisualStyleBackColor = true;
            this.btnnova.Click += new System.EventHandler(this.btnnova_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.nuddes);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.lbltotal);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.lblpreço);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.nupqnt);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.cbmprato);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.dgvvendas);
            this.panel.Location = new System.Drawing.Point(18, 93);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(737, 439);
            this.panel.TabIndex = 66;
            this.panel.Visible = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nuddes
            // 
            this.nuddes.Location = new System.Drawing.Point(578, 151);
            this.nuddes.Name = "nuddes";
            this.nuddes.Size = new System.Drawing.Size(199, 20);
            this.nuddes.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(648, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 116;
            this.label9.Text = "0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(592, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 115;
            this.label10.Text = "total";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 57);
            this.button1.TabIndex = 114;
            this.button1.Text = "Colocar no Carrinho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "desconto";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(191, 123);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(52, 24);
            this.lbltotal.TabIndex = 110;
            this.lbltotal.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "total";
            // 
            // lblpreço
            // 
            this.lblpreço.AutoSize = true;
            this.lblpreço.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreço.Location = new System.Drawing.Point(204, 38);
            this.lblpreço.Name = "lblpreço";
            this.lblpreço.Size = new System.Drawing.Size(52, 24);
            this.lblpreço.TabIndex = 108;
            this.lblpreço.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 107;
            this.label6.Text = "preço";
            // 
            // nupqnt
            // 
            this.nupqnt.Location = new System.Drawing.Point(129, 100);
            this.nupqnt.Name = "nupqnt";
            this.nupqnt.Size = new System.Drawing.Size(199, 20);
            this.nupqnt.TabIndex = 106;
            this.nupqnt.ValueChanged += new System.EventHandler(this.nupqnt_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 24);
            this.label7.TabIndex = 105;
            this.label7.Text = "qnt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 104;
            this.label8.Text = "Prato";
            // 
            // cbmprato
            // 
            this.cbmprato.FormattingEnabled = true;
            this.cbmprato.Location = new System.Drawing.Point(129, 14);
            this.cbmprato.Name = "cbmprato";
            this.cbmprato.Size = new System.Drawing.Size(199, 21);
            this.cbmprato.TabIndex = 103;
            this.cbmprato.SelectedIndexChanged += new System.EventHandler(this.cbmprato_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 101;
            this.label4.Text = "Cardapio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(178, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 43);
            this.panel2.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "+";
            // 
            // dgvvendas
            // 
            this.dgvvendas.AllowUserToAddRows = false;
            this.dgvvendas.AllowUserToDeleteRows = false;
            this.dgvvendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.valor_final});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvendas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvvendas.Location = new System.Drawing.Point(81, 234);
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.ReadOnly = true;
            this.dgvvendas.Size = new System.Drawing.Size(634, 199);
            this.dgvvendas.TabIndex = 99;
            this.dgvvendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendas_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 23);
            this.button2.TabIndex = 102;
            this.button2.Text = "Finalizar Compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome_prato";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // valor_final
            // 
            this.valor_final.DataPropertyName = "Valor";
            this.valor_final.HeaderText = "Valor";
            this.valor_final.Name = "valor_final";
            this.valor_final.ReadOnly = true;
            // 
            // telavendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 563);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnnova);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "telavendas";
            this.Text = "telavendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.telavendas_FormClosed);
            this.Load += new System.EventHandler(this.telavendas_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuddes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupqnt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Button btnnova;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblpreço;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupqnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmprato;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvvendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nuddes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_final;
    }
}