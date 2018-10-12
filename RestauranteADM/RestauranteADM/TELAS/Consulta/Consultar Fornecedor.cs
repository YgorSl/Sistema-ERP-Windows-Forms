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

namespace RestauranteADM.TELAS.Consulta
{
    public partial class Consultar_Fornecedor : Form
    {
        public Consultar_Fornecedor()
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
            FornecedorBusiness bus = new FornecedorBusiness();
            List<FornecedorDTO> com = bus.filtro(txtforn.Text, txtc.Text);

            dgvcliente.DataSource = com;
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                FornecedorDTO comp = dgvcliente.Rows[e.RowIndex].DataBoundItem as FornecedorDTO;
                AlterarFornecedor frm = new AlterarFornecedor();
                frm.ShowDialog();
               
            }
            if (e.ColumnIndex == 5)
            {
                DialogResult r = MessageBox.Show("Deseja excluir o  registro?", "Amazing",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    FornecedorDTO forn = dgvcliente.Rows[e.RowIndex].DataBoundItem as FornecedorDTO;

                    FornecedorBusiness bus = new FornecedorBusiness();
                    bus.Excluir(forn.Id);

                    MessageBox.Show("Registro Removido com sucesso","Amazing", MessageBoxButtons.OK , MessageBoxIcon.Information);
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
