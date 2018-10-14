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
    public partial class escolhavenda : Form
    {
        public escolhavenda()
        {
            InitializeComponent();
        }

        public CardapioDTO ProdSelec { get; set; }
        public int Qtd { get; set; }
        int cardapio;


        public void LoadSreen(int cardapio)
        {
            this.cardapio = cardapio;
            CarregarCombo();
        }

        void CarregarCombo()
        {
            CardapioBusiness prod = new CardapioBusiness();
            List<CardapioDTO> pro = prod.lista();

            cbmprato.DataSource = pro;
            cbmprato.DisplayMember = "Nome";
            cbmprato.ValueMember = "Id";
        }


        private void escolhavenda_Load(object sender, EventArgs e)
        {

        }

        private void cbmprato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardapioDTO prod = cbmprato.SelectedItem as CardapioDTO;

            lblpreço.Text = "R$" + prod.Valor.ToString();



            decimal total = Convert.ToDecimal(prod.Valor) * nupqnt.Value;

            lbltotal.Text = "R$" + total.ToString();



          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CardapioDTO pro = cbmprato.SelectedItem as CardapioDTO;
            int qtd = Convert.ToInt32(nupqnt.Value);

            this.ProdSelec = pro;
            this.Qtd = qtd;

            Close();
        }

        private void nupqnt_ValueChanged(object sender, EventArgs e)
        {


            CardapioDTO prod = cbmprato.SelectedItem as CardapioDTO;




            decimal total = Convert.ToDecimal(prod.Valor) * nupqnt.Value;

            lbltotal.Text = "R$" + total.ToString();
        }
    }
}
