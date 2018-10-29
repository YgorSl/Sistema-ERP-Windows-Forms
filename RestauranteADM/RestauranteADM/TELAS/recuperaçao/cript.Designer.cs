namespace RestauranteADM
{
    partial class cript
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
            this.txtmensagem = new System.Windows.Forms.RichTextBox();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btncodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtmensagem
            // 
            this.txtmensagem.Enabled = false;
            this.txtmensagem.Location = new System.Drawing.Point(15, 87);
            this.txtmensagem.Name = "txtmensagem";
            this.txtmensagem.Size = new System.Drawing.Size(387, 141);
            this.txtmensagem.TabIndex = 93;
            this.txtmensagem.Text = "";
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(15, 61);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(258, 20);
            this.txtRecuperacao.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "adicionar senha de recuperaçao";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(480, 207);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(258, 20);
            this.txtcodigo.TabIndex = 95;
            // 
            // btncodigo
            // 
            this.btncodigo.Location = new System.Drawing.Point(755, 205);
            this.btncodigo.Name = "btncodigo";
            this.btncodigo.Size = new System.Drawing.Size(75, 23);
            this.btncodigo.TabIndex = 96;
            this.btncodigo.Text = "button2";
            this.btncodigo.UseVisualStyleBackColor = true;
            this.btncodigo.Click += new System.EventHandler(this.btncodigo_Click);
            // 
            // cript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 425);
            this.Controls.Add(this.btncodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmensagem);
            this.Controls.Add(this.txtRecuperacao);
            this.Controls.Add(this.label5);
            this.Name = "cript";
            this.Text = "cript";
            this.Load += new System.EventHandler(this.cript_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtmensagem;
        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btncodigo;
    }
}