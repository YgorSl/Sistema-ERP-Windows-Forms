﻿using RestauranteADM.BASE.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS
{
    public partial class Cadastro_de_fornecedor : Form
    {
        public Cadastro_de_fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FornecedorDTO forn = new FornecedorDTO();
            forn.Nome = txtnome.Text;
            forn.Cnpj = txtcnpj.Text;
            forn.Telefone = txttelefone.Text;
            forn.Endereço = txtend.Text;
            forn.Cidade = txtcid.Text;
            forn.Estado = txtest.Text;

            FornecedorBusiness bus = new FornecedorBusiness();
            bus.Salvar(forn);

            MessageBox.Show("Fornecedor Cadastrado com Sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cadastro_de_fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
            this.Hide();
        }
    }
}
