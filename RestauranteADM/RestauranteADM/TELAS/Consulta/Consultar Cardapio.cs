using RestauranteADM.BASE.Cardapio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS.Consulta
{
    public partial class Consultar_Cardapio : Form
    {
        public Consultar_Cardapio()
        {
            InitializeComponent();
            dgvcardapio.AutoGenerateColumns = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvcardapio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                CardapioDTO comp = dgvcardapio.Rows[e.RowIndex].DataBoundItem as CardapioDTO;
                alterarcardapio oi = new alterarcardapio();
                oi.Loadscreen(comp);
                oi.Show();


            }
            if (e.ColumnIndex == 5)
            {
                DialogResult r = MessageBox.Show("Deseja excluir o  registro?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    CardapioDTO forn = dgvcardapio.Rows[e.RowIndex].DataBoundItem as CardapioDTO;

                    CardapioDatabase bus = new CardapioDatabase();
                    bus.Remover(forn.Id);

                    MessageBox.Show("Registro Removido com sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
