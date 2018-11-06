﻿using RestauranteADM.BASE.CP_Pagar;
using RestauranteADM.BASE.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS.Cadastro
{
    public partial class ContasPagar : Form
    {
        public ContasPagar()
        {
            InitializeComponent();
        }

        void CarregarCombo()
        {
            FornecedorBusiness bus = new FornecedorBusiness();
            List<ProvedorDTO> comp = bus.Listar1();

            cboforn.DataSource = comp;
            cboforn.DisplayMember = "Nome";
        }
        private void Desativar(Form f, String nomeComponente)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == nomeComponente)
                        c.Enabled = true;
                    else
                        c.Enabled = false;
                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Desativar(this, Convert.ToString(numericUpDown1.Value));
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProvedorDTO forn = cboforn.SelectedItem as ProvedorDTO;

            DateTime vencimento = Convert.ToDateTime(dataGridView1.Columns[1]);
            double valor = Convert.ToDouble(dataGridView1.Columns[2]);
            string operação = Convert.ToString(dataGridView1.Columns[3]);
            int conta = Convert.ToInt32(dataGridView1.Columns[4]);
            string banco = Convert.ToString(dataGridView1.Columns[5]);
            int agencia = Convert.ToInt32(dataGridView1.Columns[6]);
            bool ok = Convert.ToBoolean(dataGridView1.Columns[7]);

            CP_DTO compra = new CP_DTO();
            compra.Prestador = cboforn.Text;
            compra.Documento = textBox1.Text;
            compra.vencimento = vencimento;
            compra.Valor = valor;
            compra.Operacao = operação;
            compra.Conta = conta;
            compra.Banco = banco;
            compra.Agencia = agencia;
            compra.ok = ok;
            compra.Prazo = textBox3.Text;

 

            CP_Business bus = new CP_Business();
            bus.Salvar(compra);

            
        }
    }
}
