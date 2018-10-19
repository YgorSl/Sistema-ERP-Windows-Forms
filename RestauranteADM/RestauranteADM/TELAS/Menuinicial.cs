using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.Acesso;
using RestauranteADM.TELAS.Cadastro;
using RestauranteADM.TELAS.RH;
using RestauranteADM.TELAS.Financeiro;
using RestauranteADM.TELAS.Consulta;

namespace RestauranteADM.TELAS
{
    public partial class Menuinicial : Form
    {
        public Menuinicial()
        {
            InitializeComponent();
            VerificarPermissoes();
        }

        void VerificarPermissoes()
        {
            if (acesso.usuariologado.permissaototal == false)
            {
                if (acesso.usuariologado.permissaocadastro == false)
                {
                    cadastroToolStripMenuItem.Enabled = false;
                }
                if (acesso.usuariologado.permissaovendas == false)
                {
                    vendasToolStripMenuItem.Enabled = false;
                }
                if (acesso.usuariologado.permissaocompras == false)
                {
                    comprasToolStripMenuItem.Enabled = false;
                }
                if (acesso.usuariologado.permissaoRH == false)
                {
                    rhToolStripMenuItem.Enabled = false;
                }
                if (acesso.usuariologado.permissaofinanceiro == false)
                {
                    financeiroToolStripMenuItem.Enabled = false;
                }
            }
        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void rHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fonanceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void Menu_Load(object sender, EventArgs e)
        {




        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_cliente form = new Cadastrar_cliente();
            form.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_fornecedor form = new Cadastro_de_fornecedor();
            form.Show();
            this.Hide();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_usuário_do_sistema form = new Cadastro_usuário_do_sistema();
            form.Show();
            this.Hide();

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastro_de_estoque form = new Cadastro_de_estoque();
            form.Show();
            this.Hide();

        }

        private void cardapioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro___de_Cardapio form = new Cadastro___de_Cardapio();
            form.Show();
            this.Hide();
        }

        private void controleDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bater_Ponto form = new Bater_Ponto();
            form.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Folha_de_Pagamento form = new Folha_de_Pagamento();
            form.Show();
            this.Hide();

        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fluxo_de_Caixa form = new Fluxo_de_Caixa();
            form.Show();
            this.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void realizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoCompra form = new PedidoCompra();
            form.Show();
            this.Hide();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_produto form = new Consulta_produto();
            form.Show();
            this.Hide();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Fornecedor form = new Consultar_Fornecedor();
            form.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Folha_de_Pagamento form = new Consultar_Folha_de_Pagamento();
            form.Show();
            this.Hide();

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPedido FORM = new ConsultarPedido();
            FORM.Show();
            this.Hide();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crud_funcionario form = new crud_funcionario();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

