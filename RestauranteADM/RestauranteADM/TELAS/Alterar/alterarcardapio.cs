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
        Validacao v = new Validacao();

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
            nupdes.Value = Convert.ToDecimal(this.cardapio.Desconto);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            cardapio.nome_Prato = txtnomeprato.Text;
            cardapio.Tamanho = txttamanho.Text;
            cardapio.Descrição = rtvanotaçoes.Text;
            cardapio.Valor = Convert.ToDouble(txtvalor.Text);
            cardapio.Desconto = Convert.ToDouble(nupdes.Value);


            CardapioDatabase oi = new CardapioDatabase();
            oi.Update(cardapio);
            this.Hide();


            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se preencheu todos os campos corretamente", "TocToc Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyPress_txtNome(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtTamanho(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtvalor(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }
    }
}
