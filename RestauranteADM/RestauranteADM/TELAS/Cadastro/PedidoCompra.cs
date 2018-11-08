using RestauranteADM.BASE.Estoque;
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

namespace RestauranteADM.TELAS.Cadastro
{
    public partial class PedidoCompra : Form
    {
        public PedidoCompra()
        {
            InitializeComponent();
            CarregarCombo();
            gvprod.AutoGenerateColumns = false;
        }
        void CarregarCombo()
        {
            FornecedorBusiness bus = new FornecedorBusiness();
            List<FornecedorDTO> comp = bus.Listar();

            cboforn.DataSource = comp;
            cboforn.DisplayMember = "Nome";
            cboforn.ValueMember = "Id";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                FornecedorDTO forn = cboforn.SelectedItem as FornecedorDTO;

                Comprar frm = new Comprar();
                frm.LoadSreen(forn.Id);
                frm.ShowDialog();

                if (frm.ProdSelec != null)
                {
                    List<ProdutoDTO> prods = gvprod.DataSource as List<ProdutoDTO>;
                    if (prods == null)
                        prods = new List<ProdutoDTO>();


                    for (int i = 0; i < frm.Qtd; i++)
                    {
                        prods.Add(frm.ProdSelec);
                    }
                    gvprod.DataSource = null;
                    gvprod.DataSource = prods;

                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro! Entre em contato com o administrador. :(");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
             FornecedorDTO forn = cboforn.SelectedItem as FornecedorDTO;


            CompraDTO compra = new CompraDTO();
            compra.Data = dtpdate.Value;
            compra.Forneceddor = forn;
            List<ProdutoDTO> prods = gvprod.DataSource as List<ProdutoDTO>;
            List<CompraItemDTO> compitem = new List<CompraItemDTO>();
            foreach (ProdutoDTO item in prods)
            {
                CompraItemDTO itemcomp = new CompraItemDTO();
                itemcomp.Produto = item;
                compitem.Add(itemcomp);
            }

           
            CompraBusiness bus = new CompraBusiness();
            bus.Salvar(compra, compitem);

            MessageBox.Show("Compra Feita com sucesso!", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos corretamente!", "TocTocBrasil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           

        }

        private void PedidoCompra_Load(object sender, EventArgs e)
        {

        }

        private void gvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
            this.Hide();
        }
    }
}
