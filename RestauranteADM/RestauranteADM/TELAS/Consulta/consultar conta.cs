using RestauranteADM.Acesso;
using RestauranteADM.BASE.Conta_a_Pagar;
using RestauranteADM.TELAS.Cadastro;
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
            dgvconta.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ContaPagarDatabase bus = new ContaPagarDatabase();
            List<ContaPagarDTO> compra = bus.Filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

            dgvconta.DataSource = compra;
        }

        private void consultar_conta_Load(object sender, EventArgs e)
        {

        }

        private void dgvconta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.ColumnIndex == 4 )
            {


                DialogResult r = MessageBox.Show("A conta estar pagar?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    ContaPagarDTO forn = dgvconta.Rows[e.RowIndex].DataBoundItem as ContaPagarDTO;

                    ContaPagarDatabase bus = new ContaPagarDatabase();
                    bus.Update(forn);

                    MessageBox.Show("A conta foi pagar", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estrapago.ThreeState = true;


                }
                else  
                {
                 


                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cadastrar_conta from = new cadastrar_conta();
            from.ShowDialog();
        }
    }
}
