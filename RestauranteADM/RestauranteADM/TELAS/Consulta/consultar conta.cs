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
            ContaPagarDTO forn = dgvconta.Rows[e.RowIndex].DataBoundItem as ContaPagarDTO;

            if (e.ColumnIndex == 13 && forn.pagou == false)
            {


                DialogResult r = MessageBox.Show("A conta estar paga?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    ContaPagarDTO forn1 = dgvconta.Rows[e.RowIndex].DataBoundItem as ContaPagarDTO;

                    ContaPagarDatabase bus = new ContaPagarDatabase();
                    bus.Update(forn1);

                    MessageBox.Show("A conta foi paga", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (r == DialogResult.No)
                {
                    MessageBox.Show("OK", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ContaPagarDatabase bus = new ContaPagarDatabase();
                    List<ContaPagarDTO> compra = bus.Filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

                    dgvconta.DataSource = compra;


                }
            }
              else if  ( e.ColumnIndex == 13 && forn.pagou ==true)
                {
                  MessageBox.Show("A conta ja foi paga", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContaPagarDatabase bus = new ContaPagarDatabase();
                List<ContaPagarDTO> compra = bus.Filtro(dtpinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

                dgvconta.DataSource = compra;


            }

        }




        private void label3_Click(object sender, EventArgs e)
        {
            cadastrar_conta from = new cadastrar_conta();
            from.ShowDialog();
        }
        private void Pagor(ContaPagarDTO dto)
        {

            if (dto.pagou == true)
            {
                MessageBox.Show("Essa conta ja foi pagar");

            }
            else
            {
                dto.pagou = true;

                ContaPagarDatabase business = new ContaPagarDatabase();
                business.Update(dto);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
                foreach (DataGridViewRow item in dgvconta.SelectedRows)
                {

                    ContaPagarDTO dto = item.DataBoundItem as ContaPagarDTO;

                    Pagor(dto);


                }
            }
        }

    }
