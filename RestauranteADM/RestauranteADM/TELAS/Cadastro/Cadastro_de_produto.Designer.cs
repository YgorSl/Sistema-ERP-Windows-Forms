namespace RestauranteADM.TELAS
{
    partial class Cadastro_de_estoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboforn = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fornecedor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(134, 47);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(204, 20);
            this.txtnome.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(359, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(298, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(192, 24);
            this.label36.TabIndex = 47;
            this.label36.Text = "Cadastro produto";
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(134, 122);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(204, 20);
            this.txtpre.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Preço";
            // 
            // cboforn
            // 
            this.cboforn.FormattingEnabled = true;
            this.cboforn.Location = new System.Drawing.Point(134, 83);
            this.cboforn.Name = "cboforn";
            this.cboforn.Size = new System.Drawing.Size(204, 21);
            this.cboforn.TabIndex = 50;
            this.cboforn.SelectedIndexChanged += new System.EventHandler(this.cboforn_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboforn);
            this.panel1.Controls.Add(this.txtpre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(177, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 187);
            this.panel1.TabIndex = 51;
            // 
            // Cadastro_de_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 579);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro_de_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ,";
            this.Load += new System.EventHandler(this.Cadastro_de_estoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboforn;
        private System.Windows.Forms.Panel panel1;
    }
}