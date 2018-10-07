using RestauranteADM.BASE.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteADM.TELAS.Consulta;

namespace RestauranteADM.TELAS.Consulta
{
    public partial class crud_funcionario : Form
    {
        Validacao v = new Validacao();
        public crud_funcionario()
        {
            InitializeComponent();

            dgvfuncio.AutoGenerateColumns = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void crud_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness ii = new FuncionarioBusiness();
            List<FuncionarioDTO> opi=ii.filtro(txtfuncio.Text);


            dgvfuncio.DataSource = opi;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {
              
                FuncionarioDTO pr = dgvfuncio.Rows[e.RowIndex].DataBoundItem as FuncionarioDTO;

                alterarfuncionario menu = new alterarfuncionario();
                menu.Loadscreen(pr);
                menu.Show();
                this.Hide();

            }
            if (e.ColumnIndex == 5)
            {
                DialogResult r = MessageBox.Show("vai excluir mesmo", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r==DialogResult.Yes)
                {
                    FuncionarioDTO pr = dgvfuncio.Rows[e.RowIndex].DataBoundItem as FuncionarioDTO;

                    FuncionarioBusiness funciobu = new FuncionarioBusiness();
                    funciobu.Remover(pr.Id);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKeypressFuncionario(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
        }
    }
}
