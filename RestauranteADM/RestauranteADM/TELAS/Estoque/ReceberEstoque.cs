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
            CompraItemBusiness buss = new CompraItemBusiness();
            List<CompraItemDTO> item = buss.Filtro1(Convert.ToInt32(textBox1.Text));

            dgvest.DataSource = item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EstoqueDTO> estoq = new List<EstoqueDTO>();

            List<CompraItemDTO> items = dgvest.DataSource as List<CompraItemDTO>;
            foreach(CompraItemDTO item in items)
            {
                EstoqueDTO estoque = new EstoqueDTO();
                estoque.Produto = item.Produto;
                estoque.CompraItem = item;

                estoq.Add(estoque);
            }

            EstoqueBusiness bus = new EstoqueBusiness();
            bus.Salvar(estoq);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
