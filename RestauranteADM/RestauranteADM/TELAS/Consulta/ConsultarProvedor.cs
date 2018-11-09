using RestauranteADM.BASE.Fornecedor;
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
    public partial class ConsultarProvedor : Form
    {
        public ConsultarProvedor()
        {
            InitializeComponent();
            dgvcliente.AutoGenerateColumns = false;
           
        }
        
        

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                FornecedorBusiness bus = new FornecedorBusiness();
                List<ProvedorDTO> com = bus.filtro1(txtforn.Text, txtc.Text);

                dgvcliente.DataSource = com;

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro! Entre em contato com o administrador. :(");
            }
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {

                ProvedorDTO comp = dgvcliente.Rows[e.RowIndex].DataBoundItem as ProvedorDTO;
                AlterarProvedor frm = new AlterarProvedor();
                frm.LoadScreen(comp);
                frm.ShowDialog();

            }

            if (e.ColumnIndex == 4)
            {

                DialogResult r = MessageBox.Show("Deseja excluir o  registro?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    ProvedorDTO forn = dgvcliente.Rows[e.RowIndex].DataBoundItem as ProvedorDTO;

                    FornecedorBusiness bus = new FornecedorBusiness();
                    bus.Excluir1(forn.Id);

                    MessageBox.Show("Registro Removido com sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
            this.Hide();
        }
    }
}
