using RestauranteADM.BASE.Cardapio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM
{
    public partial class alterarcardapio : Form
    {
        public alterarcardapio()
        {
            InitializeComponent();
        }
        CardapioDTO cardapio;

        public void Loadscreen(CardapioDTO cardapio)
        {


            this.cardapio = cardapio;

            txtnomeprato.Text = this.cardapio.nome_Prato;
            txttamanho.Text = this.cardapio.Tamanho;
            rtvanotaçoes.Text = this.cardapio.Descrição;
            txtvalor.Text = this.cardapio.Valor.ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardapio.nome_Prato = txtnomeprato.Text;
            cardapio.Tamanho = txttamanho.Text;
            cardapio.Descrição = rtvanotaçoes.Text;
            cardapio.Valor = Convert.ToDouble(txtvalor.Text);


            CardapioDatabase oi = new CardapioDatabase();
            oi.Update(cardapio);

        }

        private void txtnomeprato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttamanho_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtvanotaçoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alterarcardapio_Load(object sender, EventArgs e)
        {

        }
    }
}
