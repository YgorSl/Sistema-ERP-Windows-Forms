﻿namespace RestauranteADM.TELAS.Cadastro
{
    partial class Comprar
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
            this.cboforn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nupt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblt = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nupt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboforn
            // 
            this.cboforn.FormattingEnabled = true;
            this.cboforn.Location = new System.Drawing.Point(48, 54);
            this.cboforn.Name = "cboforn";
            this.cboforn.Size = new System.Drawing.Size(204, 21);
            this.cboforn.TabIndex = 54;
            this.cboforn.SelectedIndexChanged += new System.EventHandler(this.cboforn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Produto";
            // 
            // nupt
            // 
            this.nupt.Location = new System.Drawing.Point(48, 174);
            this.nupt.Name = "nupt";
            this.nupt.Size = new System.Drawing.Size(204, 20);
            this.nupt.TabIndex = 55;
            this.nupt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 85;
            this.button1.Text = "Colocar no Carrinho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.ForeColor = System.Drawing.Color.White;
            this.lblt.Location = new System.Drawing.Point(142, 197);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(55, 16);
            this.lblt.TabIndex = 86;
            this.lblt.Text = "R$0,00";
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.Color.White;
            this.lblp.Location = new System.Drawing.Point(142, 78);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(55, 16);
            this.lblp.TabIndex = 87;
            this.lblp.Text = "R$0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Preço";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(349, 96);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(102, 24);
            this.label36.TabIndex = 89;
            this.label36.Text = "Comprar";
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblp);
            this.panel1.Controls.Add(this.lblt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nupt);
            this.panel1.Controls.Add(this.cboforn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(247, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 237);
            this.panel1.TabIndex = 90;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(752, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(365, 210);
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboforn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel1;
    }
}