using RestauranteADM.BASE;
using RestauranteADM.BASE.FluxoDeCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS.Financeiro
{
    public partial class Fluxo_de_Caixa : Form
    {
        public Fluxo_de_Caixa()
        {
            InitializeComponent();

            dgvfluxo.AutoGenerateColumns = false;
        }

        FluxodecaixaDTO fluxo;
        private void Fluxo_de_Caixa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FluxodecaixaBunisess bus = new FluxodecaixaBunisess();
            List<FluxodecaixaDTO> vendas = bus.filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

           dgvfluxo.DataSource = vendas;
        }

        private void dgvfluxo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FluxodecaixaDTO comp = dgvfluxo.Rows[e.RowIndex].DataBoundItem as FluxodecaixaDTO;
            this.fluxo = comp.valorareceber;
            this.fluxo = comp.valorpagar;
        }
    }
}
