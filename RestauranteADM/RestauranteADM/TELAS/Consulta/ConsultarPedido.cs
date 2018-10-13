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

namespace RestauranteADM.TELAS.Consulta
{
    public partial class ConsultarPedido : Form
    {
        public ConsultarPedido()
        {
            InitializeComponent();
            gvprod.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                ComprasViewBusiness bus = new ComprasViewBusiness();
                List<ComprasView> compra = bus.Filtro(dti.Value.Date, dtpdate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

                gvprod.DataSource = compra;
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro! Entre em contato com o administrador. :(");
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
