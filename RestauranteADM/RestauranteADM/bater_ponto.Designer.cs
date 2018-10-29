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
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnalmoçosaida = new System.Windows.Forms.Button();
            this.btnsaida = new System.Windows.Forms.Button();
            this.brnalmoçoentrada = new System.Windows.Forms.Button();
            this.btnebtrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(210, 74);
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
            this.lbldata.Location = new System.Drawing.Point(319, 156);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(60, 24);
            this.lbldata.TabIndex = 1;
            this.lbldata.Text = "label1";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(562, 211);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(98, 29);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(190, 211);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(366, 29);
            this.txtcpf.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            // 
            // btnalmoçosaida
            // 
            this.btnalmoçosaida.Location = new System.Drawing.Point(281, 320);
            this.btnalmoçosaida.Name = "btnalmoçosaida";
            this.btnalmoçosaida.Size = new System.Drawing.Size(98, 43);
            this.btnalmoçosaida.TabIndex = 5;
            this.btnalmoçosaida.Text = "button2";
            this.btnalmoçosaida.UseVisualStyleBackColor = true;
            // 
            // btnsaida
            // 
            this.btnsaida.Location = new System.Drawing.Point(523, 320);
            this.btnsaida.Name = "btnsaida";
            this.btnsaida.Size = new System.Drawing.Size(98, 43);
            this.btnsaida.TabIndex = 6;
            this.btnsaida.Text = "button3";
            this.btnsaida.UseVisualStyleBackColor = true;
            // 
            // brnalmoçoentrada
            // 
            this.brnalmoçoentrada.Location = new System.Drawing.Point(405, 320);
            this.brnalmoçoentrada.Name = "brnalmoçoentrada";
            this.brnalmoçoentrada.Size = new System.Drawing.Size(98, 43);
            this.brnalmoçoentrada.TabIndex = 7;
            this.brnalmoçoentrada.Text = "button4";
            this.brnalmoçoentrada.UseVisualStyleBackColor = true;
            // 
            // btnebtrada
            // 
            this.btnebtrada.Location = new System.Drawing.Point(162, 320);
            this.btnebtrada.Name = "btnebtrada";
            this.btnebtrada.Size = new System.Drawing.Size(98, 43);
            this.btnebtrada.TabIndex = 8;
            this.btnebtrada.Text = "button1";
            this.btnebtrada.UseVisualStyleBackColor = true;
            this.btnebtrada.Click += new System.EventHandler(this.btnebtrada_Click);
            // 
            // bater_ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 410);
            this.Controls.Add(this.btnebtrada);
            this.Controls.Add(this.brnalmoçoentrada);
            this.Controls.Add(this.btnsaida);
            this.Controls.Add(this.btnalmoçosaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcpf);
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
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnalmoçosaida;
        private System.Windows.Forms.Button btnsaida;
        private System.Windows.Forms.Button brnalmoçoentrada;
        private System.Windows.Forms.Button btnebtrada;
    }
}