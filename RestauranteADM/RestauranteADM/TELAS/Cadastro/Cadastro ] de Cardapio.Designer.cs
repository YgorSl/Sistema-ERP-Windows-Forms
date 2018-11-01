namespace RestauranteADM.TELAS.Cadastro
{
    partial class Cadastro___de_Cardapio
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txttamanho = new System.Windows.Forms.TextBox();
            this.txtnomeprato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtvanotaçoes = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(98, 143);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(292, 20);
            this.txtvalor.TabIndex = 3;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txttamanho
            // 
            this.txttamanho.Location = new System.Drawing.Point(98, 104);
            this.txttamanho.Name = "txttamanho";
            this.txttamanho.Size = new System.Drawing.Size(292, 20);
            this.txttamanho.TabIndex = 2;
            // 
            // txtnomeprato
            // 
            this.txtnomeprato.Location = new System.Drawing.Point(98, 66);
            this.txtnomeprato.Name = "txtnomeprato";
            this.txtnomeprato.Size = new System.Drawing.Size(292, 20);
            this.txtnomeprato.TabIndex = 1;
            this.txtnomeprato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tamanho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Valor";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(274, 61);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(169, 24);
            this.label36.TabIndex = 64;
            this.label36.Text = "Cadastrar Prato";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(420, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtvanotaçoes
            // 
            this.rtvanotaçoes.BackColor = System.Drawing.Color.LightYellow;
            this.rtvanotaçoes.Location = new System.Drawing.Point(98, 181);
            this.rtvanotaçoes.Name = "rtvanotaçoes";
            this.rtvanotaçoes.Size = new System.Drawing.Size(292, 85);
            this.rtvanotaçoes.TabIndex = 4;
            this.rtvanotaçoes.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rtvanotaçoes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnomeprato);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttamanho);
            this.groupBox1.Location = new System.Drawing.Point(169, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 333);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // Cadastro___de_Cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label36);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro___de_Cardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro___de_Cardapio";
            this.Load += new System.EventHandler(this.Cadastro___de_Cardapio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txttamanho;
        private System.Windows.Forms.TextBox txtnomeprato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtvanotaçoes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}