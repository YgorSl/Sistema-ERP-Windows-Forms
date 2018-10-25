namespace RestauranteADM.TELAS.recuperaçao
{
    partial class adicionar_o_codigo
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
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmensagem = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(39, 55);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(258, 20);
            this.txtRecuperacao.TabIndex = 88;
            this.txtRecuperacao.TextChanged += new System.EventHandler(this.txtRecuperacao_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "adicionar senha de recuperaçao";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtmensagem
            // 
            this.txtmensagem.Enabled = false;
            this.txtmensagem.Location = new System.Drawing.Point(93, 126);
            this.txtmensagem.Name = "txtmensagem";
            this.txtmensagem.Size = new System.Drawing.Size(387, 141);
            this.txtmensagem.TabIndex = 89;
            this.txtmensagem.Text = "";
            this.txtmensagem.TextChanged += new System.EventHandler(this.txtmensagem_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adicionar_o_codigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmensagem);
            this.Controls.Add(this.txtRecuperacao);
            this.Controls.Add(this.label5);
            this.Name = "adicionar_o_codigo";
            this.Text = "adicionar_o_codigo";
            this.Load += new System.EventHandler(this.adicionar_o_codigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtmensagem;
        private System.Windows.Forms.Button button1;
    }
}