using RestauranteADM.BASE.Produto;
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
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        public ProdutoDTO ProdSelec { get; set; }
        public int Qtd { get; set; }
        int forn;
        public void LoadSreen(int forn)
        {
            this.forn = forn;
            CarregarCombo();
        }
        void CarregarCombo()
        {
            ProdutoBusiness prod = new ProdutoBusiness();
            List<ProdutoDTO> pro = prod.listar(this.forn);

            cboforn.DataSource = pro;
            cboforn.DisplayMember = "Nome";
            cboforn.ValueMember = "Id";
        }

        private void cboforn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoDTO prod = cboforn.SelectedItem as ProdutoDTO;

            lblp.Text = "R$" + prod.Preço.ToString();

            decimal total = prod.Preço * nupt.Value;

            lblt.Text = "R$" + total.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ProdutoDTO pro = cboforn.SelectedItem as ProdutoDTO;

            decimal total = pro.Preço * nupt.Value;
            lblt.Text = "R$" + total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                ProdutoDTO pro = cboforn.SelectedItem as ProdutoDTO;
                int qtd = Convert.ToInt32(nupt.Value);

                this.ProdSelec = pro;
                this.Qtd = qtd;

                Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro! Verifique se todos os campos estão preenchidos corretamente ou entre em contato com o administrador. :(");
            }
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
