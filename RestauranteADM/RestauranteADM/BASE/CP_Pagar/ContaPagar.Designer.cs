namespace RestauranteADM.BASE.CP_Pagar
{
    partial class ContaPagar
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
            this.txtntitulo = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdatacadastro = new System.Windows.Forms.DateTimePicker();
            this.cbmtipocobraça = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboforn = new System.Windows.Forms.ComboBox();
            this.dtpvencimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpemissa = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvalortitulo = new System.Windows.Forms.TextBox();
            this.rtvanotaçoes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxcontabil = new System.Windows.Forms.ComboBox();
            this.txtcontabil = new System.Windows.Forms.TextBox();
            this.txttitpodocumento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtagencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.nudparcelas = new System.Windows.Forms.NumericUpDown();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.mtbcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtparcelas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudparcelas)).BeginInit();
            this.pnl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtntitulo
            // 
            this.txtntitulo.Location = new System.Drawing.Point(74, 31);
            this.txtntitulo.Name = "txtntitulo";
            this.txtntitulo.Size = new System.Drawing.Size(100, 20);
            this.txtntitulo.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(11, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "N*titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Cadastro";
            // 
            // dtpdatacadastro
            // 
            this.dtpdatacadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatacadastro.Location = new System.Drawing.Point(295, 32);
            this.dtpdatacadastro.Name = "dtpdatacadastro";
            this.dtpdatacadastro.Size = new System.Drawing.Size(90, 20);
            this.dtpdatacadastro.TabIndex = 3;
            // 
            // cbmtipocobraça
            // 
            this.cbmtipocobraça.FormattingEnabled = true;
            this.cbmtipocobraça.Items.AddRange(new object[] {
            "Dinheiro",
            "Boleto bancario"});
            this.cbmtipocobraça.Location = new System.Drawing.Point(538, 34);
            this.cbmtipocobraça.Name = "cbmtipocobraça";
            this.cbmtipocobraça.Size = new System.Drawing.Size(148, 21);
            this.cbmtipocobraça.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Cobrança";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "Fornecedor/ Prestador";
            // 
            // cboforn
            // 
            this.cboforn.FormattingEnabled = true;
            this.cboforn.Location = new System.Drawing.Point(10, 19);
            this.cboforn.Name = "cboforn";
            this.cboforn.Size = new System.Drawing.Size(133, 21);
            this.cboforn.TabIndex = 113;
            this.cboforn.SelectedIndexChanged += new System.EventHandler(this.cboforn_SelectedIndexChanged);
            // 
            // dtpvencimento
            // 
            this.dtpvencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimento.Location = new System.Drawing.Point(121, 39);
            this.dtpvencimento.Name = "dtpvencimento";
            this.dtpvencimento.Size = new System.Drawing.Size(87, 20);
            this.dtpvencimento.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 117;
            this.label5.Text = "Data emissao";
            // 
            // dtpemissa
            // 
            this.dtpemissa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpemissa.Location = new System.Drawing.Point(121, 18);
            this.dtpemissa.Name = "dtpemissa";
            this.dtpemissa.Size = new System.Drawing.Size(87, 20);
            this.dtpemissa.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 119;
            this.label6.Text = "Valor do titulo";
            // 
            // txtvalortitulo
            // 
            this.txtvalortitulo.Location = new System.Drawing.Point(225, 37);
            this.txtvalortitulo.Name = "txtvalortitulo";
            this.txtvalortitulo.Size = new System.Drawing.Size(144, 20);
            this.txtvalortitulo.TabIndex = 120;
            this.txtvalortitulo.Text = "00,0";
            // 
            // rtvanotaçoes
            // 
            this.rtvanotaçoes.BackColor = System.Drawing.Color.LightYellow;
            this.rtvanotaçoes.Location = new System.Drawing.Point(16, 470);
            this.rtvanotaçoes.Name = "rtvanotaçoes";
            this.rtvanotaçoes.Size = new System.Drawing.Size(486, 73);
            this.rtvanotaçoes.TabIndex = 121;
            this.rtvanotaçoes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 122;
            this.label7.Text = "Observaçao";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.SeaGreen;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Location = new System.Drawing.Point(586, 500);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(119, 43);
            this.cadastrar.TabIndex = 123;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 125;
            this.label8.Text = "Conta contabil";
            // 
            // cbxcontabil
            // 
            this.cbxcontabil.FormattingEnabled = true;
            this.cbxcontabil.Items.AddRange(new object[] {
            "Despesas c/vendas",
            "Despesas com pessoal",
            "Despesas com produçao",
            "despensas com veiculos ",
            "impostos ",
            "insumos",
            "investimentos",
            ""});
            this.cbxcontabil.Location = new System.Drawing.Point(117, 76);
            this.cbxcontabil.Name = "cbxcontabil";
            this.cbxcontabil.Size = new System.Drawing.Size(104, 21);
            this.cbxcontabil.TabIndex = 124;
            // 
            // txtcontabil
            // 
            this.txtcontabil.Location = new System.Drawing.Point(237, 77);
            this.txtcontabil.Name = "txtcontabil";
            this.txtcontabil.Size = new System.Drawing.Size(85, 20);
            this.txtcontabil.TabIndex = 127;
            // 
            // txttitpodocumento
            // 
            this.txttitpodocumento.Location = new System.Drawing.Point(542, 38);
            this.txttitpodocumento.Name = "txttitpodocumento";
            this.txttitpodocumento.Size = new System.Drawing.Size(148, 20);
            this.txttitpodocumento.TabIndex = 129;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(539, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 128;
            this.label9.Text = "tipo documento";
            // 
            // txtagencia
            // 
            this.txtagencia.Location = new System.Drawing.Point(160, 63);
            this.txtagencia.Name = "txtagencia";
            this.txtagencia.Size = new System.Drawing.Size(153, 20);
            this.txtagencia.TabIndex = 136;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(157, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 135;
            this.label13.Text = "Agencia";
            // 
            // txtbanco
            // 
            this.txtbanco.Location = new System.Drawing.Point(398, 38);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(124, 20);
            this.txtbanco.TabIndex = 138;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(395, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 137;
            this.label14.Text = "Banco";
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(10, 63);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(133, 20);
            this.txtconta.TabIndex = 140;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 139;
            this.label15.Text = "Conta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(132, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 141;
            this.label16.Text = "N° de Parcelas";
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.ForeColor = System.Drawing.Color.White;
            this.rdb2.Location = new System.Drawing.Point(602, 90);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(45, 17);
            this.rdb2.TabIndex = 143;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Não";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // nudparcelas
            // 
            this.nudparcelas.Location = new System.Drawing.Point(164, 45);
            this.nudparcelas.Name = "nudparcelas";
            this.nudparcelas.Size = new System.Drawing.Size(48, 20);
            this.nudparcelas.TabIndex = 144;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.ForeColor = System.Drawing.Color.White;
            this.rdb1.Location = new System.Drawing.Point(549, 90);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(42, 17);
            this.rdb1.TabIndex = 142;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Sim";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // mtbcnpj
            // 
            this.mtbcnpj.Location = new System.Drawing.Point(160, 18);
            this.mtbcnpj.Mask = "99.999.999/9999-99";
            this.mtbcnpj.Name = "mtbcnpj";
            this.mtbcnpj.Size = new System.Drawing.Size(153, 20);
            this.mtbcnpj.TabIndex = 146;
            // 
            // txtparcelas
            // 
            this.txtparcelas.Location = new System.Drawing.Point(6, 41);
            this.txtparcelas.Name = "txtparcelas";
            this.txtparcelas.Size = new System.Drawing.Size(100, 20);
            this.txtparcelas.TabIndex = 148;
            this.txtparcelas.Text = "00,0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 149;
            this.label10.Text = "Valor das Parcelas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(262, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 30);
            this.label11.TabIndex = 150;
            this.label11.Text = "Contas a Pagar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(546, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 151;
            this.label12.Text = "Parcelas";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.label10);
            this.pnl1.Controls.Add(this.txtparcelas);
            this.pnl1.Controls.Add(this.label16);
            this.pnl1.Controls.Add(this.nudparcelas);
            this.pnl1.Enabled = false;
            this.pnl1.Location = new System.Drawing.Point(476, 286);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(229, 95);
            this.pnl1.TabIndex = 149;
            this.pnl1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pnl1);
            this.groupBox1.Controls.Add(this.cadastrar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtvanotaçoes);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 588);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtcontabil);
            this.panel1.Controls.Add(this.cbxcontabil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbmtipocobraça);
            this.panel1.Controls.Add(this.dtpdatacadastro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtntitulo);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(10, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 120);
            this.panel1.TabIndex = 152;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rdb2);
            this.panel2.Controls.Add(this.rdb1);
            this.panel2.Controls.Add(this.txtbanco);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txttitpodocumento);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtvalortitulo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpemissa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpvencimento);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(10, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 115);
            this.panel2.TabIndex = 153;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.mtbcnpj);
            this.panel3.Controls.Add(this.txtconta);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtagencia);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboforn);
            this.panel3.Location = new System.Drawing.Point(10, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 100);
            this.panel3.TabIndex = 154;
            // 
            // ContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(752, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContaPagar";
            this.Text = "teste1";
            this.Load += new System.EventHandler(this.teste1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudparcelas)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtntitulo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdatacadastro;
        private System.Windows.Forms.ComboBox cbmtipocobraça;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboforn;
        private System.Windows.Forms.DateTimePicker dtpvencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpemissa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvalortitulo;
        private System.Windows.Forms.RichTextBox rtvanotaçoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxcontabil;
        private System.Windows.Forms.TextBox txtcontabil;
        private System.Windows.Forms.TextBox txttitpodocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtagencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.NumericUpDown nudparcelas;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.MaskedTextBox mtbcnpj;
        private System.Windows.Forms.TextBox txtparcelas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}