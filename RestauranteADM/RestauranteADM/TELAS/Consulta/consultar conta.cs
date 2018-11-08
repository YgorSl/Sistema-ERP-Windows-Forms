using RestauranteADM.Acesso;
using RestauranteADM.BASE.Conta_a_Pagar;
using RestauranteADM.BASE.Fornecedor;
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
            foreach (DataGridViewRow item in dgvconta.SelectedRows)
            {

                ContaPagarDTO dto = item.DataBoundItem as ContaPagarDTO;

                Pagor(dto);


            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cadastrar_conta from = new cadastrar_conta();
            from.ShowDialog();
        }
        private void Pagor(ContaPagarDTO dto)
        {

            if(dto.pagou==true)
            {
                MessageBox.Show("Essa conta ja foi pagar");

            }
            else
            {
                dto.pagou = true;

                ContaPagarBusiness business = new ContaPagarBusiness();
                business.Update(dto);

            }
        }
    }
}
