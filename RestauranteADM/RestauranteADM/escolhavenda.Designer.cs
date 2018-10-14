namespace RestauranteADM
{
    partial class escolhavenda
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
            this.cbmprato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupqnt = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpreço = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupqnt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmprato
            // 
            this.cbmprato.FormattingEnabled = true;
            this.cbmprato.Location = new System.Drawing.Point(147, 71);
            this.cbmprato.Name = "cbmprato";
            this.cbmprato.Size = new System.Drawing.Size(199, 21);
            this.cbmprato.TabIndex = 0;
            this.cbmprato.SelectedIndexChanged += new System.EventHandler(this.cbmprato_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "qnt";
            // 
            // nupqnt
            // 
            this.nupqnt.Location = new System.Drawing.Point(147, 157);
            this.nupqnt.Name = "nupqnt";
            this.nupqnt.Size = new System.Drawing.Size(199, 20);
            this.nupqnt.TabIndex = 3;
            this.nupqnt.ValueChanged += new System.EventHandler(this.nupqnt_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 120);
            this.button1.TabIndex = 4;
            this.button1.Text = "adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "preço";
            // 
            // lblpreço
            // 
            this.lblpreço.AutoSize = true;
            this.lblpreço.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreço.Location = new System.Drawing.Point(222, 95);
            this.lblpreço.Name = "lblpreço";
            this.lblpreço.Size = new System.Drawing.Size(85, 24);
            this.lblpreço.TabIndex = 6;
            this.lblpreço.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(209, 180);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(85, 24);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "R$ 0,00";
            // 
            // escolhavenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 361);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpreço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nupqnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmprato);
            this.Name = "escolhavenda";
            this.Text = "escolhavenda";
            this.Load += new System.EventHandler(this.escolhavenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupqnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmprato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupqnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpreço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal;
    }
}