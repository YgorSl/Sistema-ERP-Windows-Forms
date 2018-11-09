namespace RestauranteADM
{
    partial class bater_ponto
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
            this.components = new System.ComponentModel.Container();
            this.lblhora = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lbldata = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnalmoçosaida = new System.Windows.Forms.Button();
            this.btnsaida = new System.Windows.Forms.Button();
            this.brnalmoçoentrada = new System.Windows.Forms.Button();
            this.btnebtrada = new System.Windows.Forms.Button();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(187, 74);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(284, 73);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "00:00:00";
            this.lblhora.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(291, 158);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(60, 24);
            this.lbldata.TabIndex = 1;
            this.lbldata.Text = "label1";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(480, 217);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(98, 25);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Confirmar";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            // 
            // btnalmoçosaida
            // 
            this.btnalmoçosaida.Enabled = false;
            this.btnalmoçosaida.Location = new System.Drawing.Point(238, 321);
            this.btnalmoçosaida.Name = "btnalmoçosaida";
            this.btnalmoçosaida.Size = new System.Drawing.Size(98, 43);
            this.btnalmoçosaida.TabIndex = 5;
            this.btnalmoçosaida.Text = "Almoço ";
            this.btnalmoçosaida.UseVisualStyleBackColor = true;
            this.btnalmoçosaida.Click += new System.EventHandler(this.btnalmoçosaida_Click);
            // 
            // btnsaida
            // 
            this.btnsaida.Enabled = false;
            this.btnsaida.Location = new System.Drawing.Point(480, 321);
            this.btnsaida.Name = "btnsaida";
            this.btnsaida.Size = new System.Drawing.Size(98, 43);
            this.btnsaida.TabIndex = 6;
            this.btnsaida.Text = "Saida";
            this.btnsaida.UseVisualStyleBackColor = true;
            this.btnsaida.Click += new System.EventHandler(this.btnsaida_Click);
            // 
            // brnalmoçoentrada
            // 
            this.brnalmoçoentrada.Enabled = false;
            this.brnalmoçoentrada.Location = new System.Drawing.Point(362, 321);
            this.brnalmoçoentrada.Name = "brnalmoçoentrada";
            this.brnalmoçoentrada.Size = new System.Drawing.Size(98, 43);
            this.brnalmoçoentrada.TabIndex = 7;
            this.brnalmoçoentrada.Text = "Almoço volta";
            this.brnalmoçoentrada.UseVisualStyleBackColor = true;
            this.brnalmoçoentrada.Click += new System.EventHandler(this.brnalmoçoentrada_Click);
            // 
            // btnebtrada
            // 
            this.btnebtrada.Enabled = false;
            this.btnebtrada.Location = new System.Drawing.Point(119, 321);
            this.btnebtrada.Name = "btnebtrada";
            this.btnebtrada.Size = new System.Drawing.Size(98, 43);
            this.btnebtrada.TabIndex = 8;
            this.btnebtrada.Text = "Entrada";
            this.btnebtrada.UseVisualStyleBackColor = true;
            this.btnebtrada.Click += new System.EventHandler(this.btnebtrada_Click);
            // 
            // mtbcpf
            // 
            this.mtbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbcpf.Location = new System.Drawing.Point(176, 217);
            this.mtbcpf.Mask = "999.999.999-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(282, 24);
            this.mtbcpf.TabIndex = 9;
            // 
            // bater_ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(698, 410);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.btnebtrada);
            this.Controls.Add(this.brnalmoçoentrada);
            this.Controls.Add(this.btnsaida);
            this.Controls.Add(this.btnalmoçosaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblhora);
            this.Name = "bater_ponto";
            this.Text = "bater_ponto";
            this.Load += new System.EventHandler(this.bater_ponto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnalmoçosaida;
        private System.Windows.Forms.Button btnsaida;
        private System.Windows.Forms.Button brnalmoçoentrada;
        private System.Windows.Forms.Button btnebtrada;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
    }
}