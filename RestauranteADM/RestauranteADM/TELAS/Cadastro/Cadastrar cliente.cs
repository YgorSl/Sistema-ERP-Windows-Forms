﻿using RestauranteADM.BASE.Cliente;
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
    public partial class Cadastrar_cliente : Form
    {
        public Cadastrar_cliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_cliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtphoje.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();



            dto.Nome = txtnome.Text;
            dto.Cpf = txtcpf.Text;
            dto.Telefone = txttelefone.Text;
            dto.Cep = txtcep.Text;
            dto.Bairro = txtbairro.Text;
            dto.NumeroCasa = txtnumcasa.Text;
        
            dto.Cnpj = txtcnpj.Text;
            dto.anotaçao_cliente = rtvanotaçoes.Text;


            dto.data_hoje = dtphoje.Value;


            ClienteBusiness ft = new ClienteBusiness();
            ft.Salvar(dto);

            MessageBox.Show("cliente Salvo com sucesso! :)");
        }
    }
}
