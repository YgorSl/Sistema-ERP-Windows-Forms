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
    public partial class Consulta_produto : Form
    {
        public Consulta_produto()
        {
            InitializeComponent();
            dgvcliente.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutoBusiness bus = new ProdutoBusiness();
            List<ProdutoDTO> prod = bus.filtro(textBox1.Text);

            dgvcliente.DataSource = prod;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                ProdutoDTO comp = dgvcliente.Rows[e.RowIndex].DataBoundItem as ProdutoDTO;
                AlterarProduto frm = new AlterarProduto();
                frm.LoadScren(comp);
                frm.ShowDialog();

            }
            if (e.ColumnIndex == 7)
            {
                DialogResult r = MessageBox.Show("Deseja excluir o  registro?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    ProdutoDTO forn = dgvcliente.Rows[e.RowIndex].DataBoundItem as ProdutoDTO;

                    ProdutoBusiness bus = new ProdutoBusiness();
                    bus.Excluir(forn.Id);

                    MessageBox.Show("Registro Removido com sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
            this.Hide();
        }
    }
}
