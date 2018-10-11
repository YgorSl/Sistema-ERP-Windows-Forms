using RestauranteADM.BASE.Folha_de_Pagamento;
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
    public partial class Consultar_Folha_de_Pagamento : Form
    {
        public Consultar_Folha_de_Pagamento()
        {
            InitializeComponent();
            dgvcliente.AutoGenerateColumns = false;
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
            if (e.ColumnIndex == 15)
            {
                DialogResult r = MessageBox.Show("Deseja excluir o  registro?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    FolhaPagamentoDTO forn = dgvcliente.Rows[e.RowIndex].DataBoundItem as FolhaPagamentoDTO;

                   FolhaPagamentoDatabase bus = new FolhaPagamentoDatabase();
                    bus.Remover(forn.Id);

                    MessageBox.Show("Registro Removido com sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                }
             }
                 

        private void Consultar_Folha_de_Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolhaPagamentoBusiness bus = new FolhaPagamentoBusiness();
            List<FolhaPagamentoDTO> prod = bus.Consultar(txtnome.Text,txtcpf.Text);

            dgvcliente.DataSource = prod;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
