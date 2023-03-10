using RestauranteADM.BASE.Estoque;
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

namespace RestauranteADM.TELAS.Estoque
{
    public partial class ReceberEstoque : Form
    {
        public ReceberEstoque()
        {
            InitializeComponent();
            dgvest.AutoGenerateColumns = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                CompraItemBusiness buss = new CompraItemBusiness();
                List<VerView> item = buss.Filtro(textBox1.Text);

                dgvest.DataSource = item;
            }
            catch (Exception)

            {

                MessageBox.Show("Por favor preencha todos os campos corretamente!", "TocTocBrasil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            List<EstoqueDTO> estoq = new List<EstoqueDTO>();

            List<VerView> items = dgvest.DataSource as List<VerView>;
            foreach(VerView item in items)
            {
                EstoqueDTO estoque = new EstoqueDTO();
                estoque.Produto = item.IdProduto;
                estoque.CompraItem = item.IdCompraItem;

                estoq.Add(estoque);
            }

            EstoqueBusiness bus = new EstoqueBusiness();
            bus.Salvar(estoq);
            MessageBox.Show("Recebido No Estoque");
                button1.Enabled = false;


            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se esta tudo certo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
