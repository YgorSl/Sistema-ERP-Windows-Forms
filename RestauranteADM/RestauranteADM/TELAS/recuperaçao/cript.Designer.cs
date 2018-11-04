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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 94;
            this.button1.Text = "Confirmar senha de recuperaçao";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtmensagem
            // 
            this.txtmensagem.Enabled = false;
            this.txtmensagem.Location = new System.Drawing.Point(18, 66);
            this.txtmensagem.Name = "txtmensagem";
            this.txtmensagem.Size = new System.Drawing.Size(387, 141);
            this.txtmensagem.TabIndex = 93;
            this.txtmensagem.Text = "";
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(18, 40);
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
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "adicionar senha de recuperaçao";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(3, 124);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(258, 20);
            this.txtcodigo.TabIndex = 95;
            // 
            // btncodigo
            // 
            this.btncodigo.Location = new System.Drawing.Point(275, 124);
            this.btncodigo.Name = "btncodigo";
            this.btncodigo.Size = new System.Drawing.Size(108, 23);
            this.btncodigo.TabIndex = 96;
            this.btncodigo.Text = "Confirmar codigo";
            this.btncodigo.UseVisualStyleBackColor = true;
            this.btncodigo.Click += new System.EventHandler(this.btncodigo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRecuperacao);
            this.panel1.Controls.Add(this.txtmensagem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(23, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 333);
            this.panel1.TabIndex = 97;
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.txtcodigo);
            this.pan1.Controls.Add(this.btncodigo);
            this.pan1.Enabled = false;
            this.pan1.Location = new System.Drawing.Point(465, 32);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(386, 335);
            this.pan1.TabIndex = 98;
            this.pan1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(875, 425);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.panel1);
            this.Name = "cript";
            this.Text = "cript";
            this.Load += new System.EventHandler(this.cript_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtmensagem;
        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btncodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan1;
    }
}