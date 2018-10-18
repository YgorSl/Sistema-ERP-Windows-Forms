﻿using RestauranteADM.BASE.Fornecedor;
using RestauranteADM.TELAS.Consulta;
using RestauranteADM.TELAS.MENU;
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
    public partial class AlterarFornecedor : Form
    {
        public AlterarFornecedor()
        {
            InitializeComponent();
        }

        FornecedorDTO forn;
        
        public void LoadScreen(FornecedorDTO forn)

        {
            this.forn = forn;

            txtnome.Text = forn.Nome;
            txtcnpj.Text = forn.Cnpj;
            txttelefone.Text = forn.Telefone;
            txtend.Text = forn.Endereço;
            txtcid.Text = forn.Cidade;
            txtest.Text = forn.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            forn.Nome = txtnome.Text;
            forn.Cnpj = txtcnpj.Text;
            forn.Telefone = txttelefone.Text;
            forn.Endereço = txtend.Text;
            forn.Cidade = txtcid.Text;
            forn.Estado = txtest.Text;

            FornecedorBusiness bus = new FornecedorBusiness();
            bus.Alterar(forn);

            MessageBox.Show("Fornecedor Alterado com Sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void AlterarFornecedor_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
