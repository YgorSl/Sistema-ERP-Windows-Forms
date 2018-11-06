using RestauranteADM.BASE;
using RestauranteADM.BASE.Fluxo_de_Caixa;
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
            carregamentoFluxo(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
        }

        void carregamentoFluxo(DateTime inicio, DateTime fim)
        {
            FluxodecaixaBunisessView tb = new FluxodecaixaBunisessView();
            List<FluxodecaixaView> bt = tb.filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));


            dgvfluxo.DataSource = bt;


        }


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
            FluxodecaixaBunisessView bus = new FluxodecaixaBunisessView();
            List<FluxodecaixaView> vendas = bus.filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

            dgvfluxo.DataSource = vendas;
        }

        private void dgvfluxo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dtpinicio_ValueChanged(object sender, EventArgs e)
        {
            carregamentoFluxo(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
        }

        private void dtpfim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvfluxo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            

            decimal saldo = 0;
            decimal totalentrada = 0;
            decimal totalsaida = 0;

            foreach (DataGridViewRow row in dgvfluxo.Rows)
            {
                FluxodecaixaView dto = row.DataBoundItem as FluxodecaixaView;

                if (dto.tipo_de_operacao == "Entrada")
                {
                    decimal entrada = dto.valortotal;
                    totalentrada = entrada + totalentrada;
                }
                else
                {
                    decimal saida = dto.valortotal;
                    totalsaida = saida + totalsaida;
                }
               
            }
            lblentrada.Text = totalentrada.ToString();
            lblsaida.Text = totalsaida.ToString();
            saldo = totalentrada - totalsaida;
            lblsituaca.Text = saldo.ToString();



        }

        private void btnfluxo_Click(object sender, EventArgs e)
        {
           FluxoCaixaDTO  dto = new FluxoCaixaDTO();

            dto.ganhor = Convert.ToDouble(lblentrada.Text);
            dto.perdar = Convert.ToDouble(lblsaida.Text);
            dto.saldo = Convert.ToSingle(lblsituaca.Text);
            dto.Perido_inicial = dtpinicio.Value;
            dto.Perido_final = dtpfim.Value;



            FluxoCaixaBusiness ft = new FluxoCaixaBusiness();
            ft.Salvar(dto);
            MessageBox.Show("foi");
        }

        private void lblsaida_Click(object sender, EventArgs e)
        {

        }
    }
}  


