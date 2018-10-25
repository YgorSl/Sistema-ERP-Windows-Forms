using RestauranteADM.BASE.Estoque;
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
    public partial class Estoque_L : Form
    {
        public Estoque_L()
        {
            InitializeComponent();
            CarregarEstoque();
            dataGridView1.AutoGenerateColumns = false;

        }
        void CarregarEstoque()
        {
            EstoqueBusiness bus = new EstoqueBusiness();
            List<Estoque_View> estoq = bus.Lista();

            dataGridView1.DataSource = estoq;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DialogResult r = MessageBox.Show("Deseja Retirar do Estoque?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    Estoque_View forn = dataGridView1.Rows[e.RowIndex].DataBoundItem as Estoque_View;

                    EstoqueBusiness bus = new EstoqueBusiness();
                    bus.Excluir(forn.Id);

                    MessageBox.Show("Retirado Do estoque com sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
