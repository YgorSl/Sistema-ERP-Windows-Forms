using RestauranteADM.BASE.Cardapio;
using RestauranteADM.BASE.Cliente;
using RestauranteADM.BASE.Produto;
using RestauranteADM.BASE.vendas;
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
    public partial class telavendas : Form
    {
        public telavendas()
        {
            InitializeComponent();
            CarregarCombo();


        }
        public CardapioDTO ProdSelec { get; set; }
        public int Qtd { get; set; }
        void CarregarCombo()
        {
            ClienteBusiness bus = new ClienteBusiness();
            List<ClienteDTO> comp = bus.lista();


            cmbcliente.DataSource = comp;
            cmbcliente.DisplayMember = "Nome";
            cmbcliente.ValueMember = "Id";

            CardapioBusiness prod = new CardapioBusiness();
            List<CardapioDTO> pro = prod.lista();

            cbmprato.DataSource = pro;
            cbmprato.DisplayMember = "nome_prato";
            cbmprato.ValueMember = "Id";



        }












        private void telavendas_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void telavendas_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void cbmprato_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            CardapioDTO prod = cbmprato.SelectedItem as CardapioDTO;

            lblpreço.Text = "R$" + prod.Valor.ToString();



            decimal total = Convert.ToDecimal(prod.Valor) * nupqnt.Value;







            lbltotal.Text = "R$" + total.ToString();

            



        }

        private void nupqnt_ValueChanged(object sender, EventArgs e)
        {
            

            CardapioDTO prod = cbmprato.SelectedItem as CardapioDTO;


            decimal total = Convert.ToDecimal(prod.Valor) * nupqnt.Value ;

            lbltotal.Text = "R$" + total.ToString();




        }

        private void btnnova_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            btnnova.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteDTO forn = cmbcliente.SelectedItem as ClienteDTO;
            CardapioDTO cardapio = cbmprato.SelectedItem as CardapioDTO;

            VendasDTO compra = new VendasDTO();
            compra.Data = dtpdata.Value;
            compra.cliente = forn;


            List<CardapioDTO> itens=dgvvendas.DataSource as List<CardapioDTO>;
            List<vendas_item_DTO> item =new List<vendas_item_DTO>();

            foreach (CardapioDTO ite in itens)
            {
                vendas_item_DTO itemvenda= new vendas_item_DTO();
                itemvenda.cardapio = ite;

                item.Add(itemvenda);
            }
            VendasBunisess bus = new VendasBunisess();
            bus.Salvar(compra,item);






            MessageBox.Show("Compra Feita com sucesso!", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {






            int m = dgvvendas.Rows.Add();
            dgvvendas.Rows[m].Cells[0].Value = cbmprato.Text;
            dgvvendas.Rows[m].Cells[1].Value = lblpreço.Text;
            dgvvendas.Rows[m].Cells[2].Value = nupqnt.Text;
            dgvvendas.Rows[m].Cells[3].Value = lbltotal.Text;


        }

        private void dgvvendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbdes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtpdata_ValueChanged(object sender, EventArgs e)
        {
            dtpdata.Value = DateTime.Now;
        }
    }
}

