namespace RestauranteADM.TELAS.Cadastro
{
    partial class cadastrar_conta
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
            this.dtphoje = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtvalidade = new System.Windows.Forms.MaskedTextBox();
            this.txtpreço = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 104;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtphoje
            // 
            this.dtphoje.Location = new System.Drawing.Point(179, 46);
            this.dtphoje.Name = "dtphoje";
            this.dtphoje.Size = new System.Drawing.Size(200, 20);
            this.dtphoje.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = "tipo";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(134, 85);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(245, 20);
            this.txttipo.TabIndex = 97;
            // 
            // txtvalidade
            // 
            this.txtvalidade.Location = new System.Drawing.Point(134, 120);
            this.txtvalidade.Mask = "9999-99-99";
            this.txtvalidade.Name = "txtvalidade";
            this.txtvalidade.Size = new System.Drawing.Size(245, 20);
            this.txtvalidade.TabIndex = 98;
            // 
            // txtpreço
            // 
            this.txtpreço.Location = new System.Drawing.Point(134, 163);
            this.txtpreço.Name = "txtpreço";
            this.txtpreço.Size = new System.Drawing.Size(245, 20);
            this.txtpreço.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "validade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(60, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "preço";
            // 
            // cadastrar_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtphoje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtvalidade);
            this.Controls.Add(this.txtpreço);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Name = "cadastrar_conta";
            this.Text = "cadastrar_conta";
            this.Load += new System.EventHandler(this.cadastrar_conta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtphoje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.MaskedTextBox txtvalidade;
        private System.Windows.Forms.TextBox txtpreço;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
    }
}