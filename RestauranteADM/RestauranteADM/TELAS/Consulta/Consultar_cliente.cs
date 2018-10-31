using RestauranteADM.BASE.Cliente;
using RestauranteADM.TELAS.Alterar;
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


namespace RestauranteADM.TELAS
{
    public partial class Consultar_cliente : Form
    {
        public Consultar_cliente()
        {
            InitializeComponent();

            dgvcliente.AutoGenerateColumns = false;
          
        }
       


        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                

                ClienteBusiness bunisess = new ClienteBusiness();
                List<ClienteDTO> com = bunisess.filtro(txtcliente.Text, txtcpf.Text);

                dgvcliente.DataSource = com;

       
       
        }

        private void dgvcliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
               
                ClienteDTO comp = dgvcliente.Rows[e.RowIndex].DataBoundItem as ClienteDTO;
                alterarcliente frm = new alterarcliente();
                frm.Loadscreen(comp);
                frm.Show();


            }
            if (e.ColumnIndex == 13)
            {
                
                DialogResult r = MessageBox.Show("Deseja excluir o  registro?", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    ClienteDTO forn = dgvcliente.Rows[e.RowIndex].DataBoundItem as ClienteDTO;

                    ClienteDatabase bus = new ClienteDatabase();
                    bus.Remover(forn.Id);

                    MessageBox.Show("Registro Removido com sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            

        private void Consultar_cliente_Load(object sender, EventArgs e)
        {

        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
