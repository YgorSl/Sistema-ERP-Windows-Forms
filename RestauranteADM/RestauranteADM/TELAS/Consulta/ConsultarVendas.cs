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
using RestauranteADM.Acesso;

namespace RestauranteADM.TELAS.Consulta
{
    public partial class ConsultarVendas : Form
    {
        public ConsultarVendas()
        {
            InitializeComponent();
            dgvvendas.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (acesso.usuariologado.permissaototal == false)
            {
                if (acesso.usuariologado.permissaoconsultarvenda == false)
                {
                    btnConsultarVenda.Enabled = false;
                }
                else
                {
                    VendasViewBunisess bus = new VendasViewBunisess();
                    List<VendasViewDto> vendas = bus.Filtro(dti.Value.Date, dtpdate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

                    dgvvendas.DataSource = vendas;
                }
            }
           
        }

        private void dgvvendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
