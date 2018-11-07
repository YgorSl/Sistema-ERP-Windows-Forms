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
        Validacao v = new Validacao();

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
            txtbairro.Text = forn.Bairro;
            txtcep.Text = forn.CEP;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            forn.Nome = txtnome.Text;
            forn.Cnpj = txtcnpj.Text;
            forn.Telefone = txttelefone.Text;
            forn.Endereço = txtend.Text;
            forn.Cidade = txtcid.Text;
            forn.Estado = txtest.Text;
            forn.Bairro = txtbairro.Text;
            forn.CEP = txtcep.Text;

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

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void KeyPress_txtNome(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtCNPJ(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void KeyPress_txtCEP(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void KeyPress_txtTelefone(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void KeyPress_txtCidade(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtEstado(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtBairro(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }
    }
}
