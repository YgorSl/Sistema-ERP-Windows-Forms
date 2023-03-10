using RestauranteADM.BASE.Fornecedor;
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

namespace RestauranteADM.TELAS
{
    public partial class AlterarProduto : Form
    {
        Validacao v = new Validacao();

        public AlterarProduto()
        {
            InitializeComponent();
            CarregarCombo();
        }

        void CarregarCombo()
        {
            FornecedorBusiness bus = new FornecedorBusiness();
            List<FornecedorDTO> comp = bus.Listar();

            cboforn.DataSource = comp;
            cboforn.DisplayMember = "Nome";
            cboforn.ValueMember = "Id";
        }

        ProdutoDTO produt;

        public void LoadScren(ProdutoDTO produt)
        {
            this.produt = produt;
            txtnome.Text = produt.Nome;
            txtpre.Text = produt.Preço.ToString();

            cboforn.SelectedValue = produt.Fornecedor.Id;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produt.Nome = txtnome.Text;

            produt.Preço = Convert.ToDecimal(txtpre.Text);

            produt.Fornecedor = cboforn.SelectedItem as FornecedorDTO;

            ProdutoBusiness bus = new ProdutoBusiness();
            bus.Alterar(produt);

            MessageBox.Show("Produto Alterado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulta_produto oi = new Consulta_produto();
            oi.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();


        }

        private void Keypress_txtValor(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }
    }
}
