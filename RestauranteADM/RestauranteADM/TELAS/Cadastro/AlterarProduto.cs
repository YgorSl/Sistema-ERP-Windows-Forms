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
            cboforn.DisplayMember = "Name";
            cboforn.ValueMember = "Id";
        }

        ProdutoDTO produt;

        public void LoadScren(ProdutoDTO produt)
        {
            txtnome.Text = produt.Nome;
            txtpre.Text = produt.Preço.ToString();

            cboforn.SelectedValue = produt.Fornecedor.Id;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutoDTO prod = new ProdutoDTO();
            prod.Nome = txtnome.Text;

            prod.Preço = Convert.ToDecimal(txtpre.Text);

            prod.Fornecedor = cboforn.SelectedItem as FornecedorDTO;

            ProdutoBusiness bus = new ProdutoBusiness();
            bus.Alterar(prod);

            MessageBox.Show("Produto Alterado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
