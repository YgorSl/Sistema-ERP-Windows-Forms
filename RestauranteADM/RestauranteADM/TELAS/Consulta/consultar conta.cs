using RestauranteADM.BASE.Conta_a_Pagar;
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
    public partial class consultar_conta : Form
    {
        public consultar_conta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ContaPagarDatabase bus = new ContaPagarDatabase();
            List<ContaPagarDTO> compra = bus.Filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

            dgvconta.DataSource = compra;
        }
    }
}
