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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.btnnova = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txtvlfinal = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txttota = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttaxa = new System.Windows.Forms.TextBox();
            this.lblValorTaxa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpor = new System.Windows.Forms.TextBox();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpreço = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupqnt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmprato = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupqnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cliente";
            // 
            // dtpdata
            // 
            this.dtpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdata.Location = new System.Drawing.Point(478, 63);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(226, 20);
            this.dtpdata.TabIndex = 61;
            this.dtpdata.ValueChanged += new System.EventHandler(this.dtpdata_ValueChanged);
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(79, 66);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(374, 21);
            this.cmbcliente.TabIndex = 62;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // btnnova
            // 
            this.btnnova.BackColor = System.Drawing.Color.SeaGreen;
            this.btnnova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnova.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnova.Location = new System.Drawing.Point(553, 97);
            this.btnnova.Name = "btnnova";
            this.btnnova.Size = new System.Drawing.Size(141, 23);
            this.btnnova.TabIndex = 65;
            this.btnnova.Text = "Nova Venda";
            this.btnnova.UseVisualStyleBackColor = false;
            this.btnnova.Click += new System.EventHandler(this.btnnova_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.txtvlfinal);
            this.panel.Controls.Add(this.button4);
            this.panel.Controls.Add(this.txtfn);
            this.panel.Controls.Add(this.txttota);
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.groupBox3);
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.lbltotal);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.lblpreço);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.nupqnt);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.cbmprato);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.dgvvendas);
            this.panel.Location = new System.Drawing.Point(9, 135);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(733, 473);
            this.panel.TabIndex = 66;
            this.panel.Visible = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtvlfinal
            // 
            this.txtvlfinal.Location = new System.Drawing.Point(150, 436);
            this.txtvlfinal.Name = "txtvlfinal";
            this.txtvlfinal.Size = new System.Drawing.Size(82, 20);
            this.txtvlfinal.TabIndex = 131;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(5, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 28);
            this.button4.TabIndex = 130;
            this.button4.Text = "Calcular Produtos";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtfn
            // 
            this.txtfn.Location = new System.Drawing.Point(152, 254);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(82, 20);
            this.txtfn.TabIndex = 126;
            this.txtfn.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txttota
            // 
            this.txttota.AutoSize = true;
            this.txttota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttota.ForeColor = System.Drawing.Color.White;
            this.txttota.Location = new System.Drawing.Point(3, 256);
            this.txttota.Name = "txttota";
            this.txttota.Size = new System.Drawing.Size(123, 16);
            this.txttota.TabIndex = 129;
            this.txttota.Text = "Valor dos Produtos";
            this.txttota.Click += new System.EventHandler(this.txttota_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(558, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 28);
            this.button3.TabIndex = 104;
            this.button3.Text = "Calcular Total";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttaxa);
            this.groupBox3.Controls.Add(this.lblValorTaxa);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(452, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 80);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taxa de entrega";
            // 
            // txttaxa
            // 
            this.txttaxa.Location = new System.Drawing.Point(120, 28);
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(100, 20);
            this.txttaxa.TabIndex = 124;
            this.txttaxa.TextChanged += new System.EventHandler(this.txttaxa_TextChanged);
            this.txttaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            // 
            // lblValorTaxa
            // 
            this.lblValorTaxa.AutoSize = true;
            this.lblValorTaxa.Location = new System.Drawing.Point(49, 52);
            this.lblValorTaxa.Name = "lblValorTaxa";
            this.lblValorTaxa.Size = new System.Drawing.Size(13, 13);
            this.lblValorTaxa.TabIndex = 120;
            this.lblValorTaxa.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 113;
            this.label11.Text = "Valor da Taxa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpor);
            this.groupBox2.Controls.Add(this.lblValorDesconto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(452, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 80);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desconto";
            // 
            // txtpor
            // 
            this.txtpor.Location = new System.Drawing.Point(120, 27);
            this.txtpor.Name = "txtpor";
            this.txtpor.Size = new System.Drawing.Size(100, 20);
            this.txtpor.TabIndex = 123;
            this.txtpor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtpor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpor_KeyPress);
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Location = new System.Drawing.Point(49, 54);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(13, 13);
            this.lblValorDesconto.TabIndex = 122;
            this.lblValorDesconto.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Percentual";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 121;
            this.label15.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttroco);
            this.groupBox1.Controls.Add(this.lbltroco);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(452, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 94);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Troco";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txttroco
            // 
            this.txttroco.Location = new System.Drawing.Point(181, 28);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(82, 20);
            this.txttroco.TabIndex = 125;
            this.txttroco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTroco_KeyPress);
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Location = new System.Drawing.Point(54, 51);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(13, 13);
            this.lbltroco.TabIndex = 124;
            this.lbltroco.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 16);
            this.label12.TabIndex = 124;
            this.label12.Text = "Cédula paga pelo cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 123;
            this.label17.Text = "Troco";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "Total do Pedido";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 67);
            this.button1.TabIndex = 114;
            this.button1.Text = "Colocar no Carrinho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(164, 116);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 20);
            this.lbltotal.TabIndex = 110;
            this.lbltotal.Text = "0,00";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 109;
            this.label5.Text = "Total de Produtos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblpreço
            // 
            this.lblpreço.AutoSize = true;
            this.lblpreço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreço.ForeColor = System.Drawing.Color.White;
            this.lblpreço.Location = new System.Drawing.Point(184, 34);
            this.lblpreço.Name = "lblpreço";
            this.lblpreço.Size = new System.Drawing.Size(32, 16);
            this.lblpreço.TabIndex = 108;
            this.lblpreço.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(115, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "preço";
            // 
            // nupqnt
            // 
            this.nupqnt.Location = new System.Drawing.Point(109, 76);
            this.nupqnt.Name = "nupqnt";
            this.nupqnt.Size = new System.Drawing.Size(199, 20);
            this.nupqnt.TabIndex = 106;
            this.nupqnt.ValueChanged += new System.EventHandler(this.nupqnt_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 104;
            this.label8.Text = "Prato";
            // 
            // cbmprato
            // 
            this.cbmprato.FormattingEnabled = true;
            this.cbmprato.Location = new System.Drawing.Point(109, 10);
            this.cbmprato.Name = "cbmprato";
            this.cbmprato.Size = new System.Drawing.Size(199, 21);
            this.cbmprato.TabIndex = 103;
            this.cbmprato.SelectedIndexChanged += new System.EventHandler(this.cbmprato_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(51, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "Cardápio";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvendas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvvendas.Location = new System.Drawing.Point(55, 310);
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvvendas.Size = new System.Drawing.Size(634, 120);
            this.dgvvendas.TabIndex = 99;
            this.dgvvendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendas_CellContentClick);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(526, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 28);
            this.button2.TabIndex = 102;
            this.button2.Text = "Finalizar Compra";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(294, 26);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 25);
            this.label36.TabIndex = 103;
            this.label36.Text = " Vendas";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RestauranteADM.Properties.Resources.ok;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(8, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 44);
            this.panel1.TabIndex = 132;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // telavendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(752, 649);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnnova);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telavendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telavendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.telavendas_FormClosed);
            this.Load += new System.EventHandler(this.telavendas_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupqnt)).EndInit();
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
        private System.Windows.Forms.Label lblpreço;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupqnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmprato;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvvendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_final;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblValorTaxa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtpor;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txttaxa;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label txttota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtvlfinal;
        private System.Windows.Forms.Panel panel1;
    }
}