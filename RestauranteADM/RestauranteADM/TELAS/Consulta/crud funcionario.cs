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
using RestauranteADM.BASE.Usuario;
using RestauranteADM.Acesso;


namespace RestauranteADM.TELAS.Consulta
{
    public partial class crud_funcionario : Form
    {
        Validacao v = new Validacao();
        public crud_funcionario()
        {
            InitializeComponent();

            dgvfuncio.AutoGenerateColumns = false;
            VerificarPermissoes();
        }
        void VerificarPermissoes()
        {
            if (acesso.usuariologado.permissaototal == false)
            {
                if (acesso.usuariologado.permissaoconsultarfuncionario == false)
                {
                    btnConsultarFuncionario.Enabled = false;
                }
                if (acesso.usuariologado.permissaoalterarfuncionario == false)
                {

                    this.dgvfuncio.Columns["Colunm2"].Visible = false;
                }
                if (acesso.usuariologado.permissaoexcluirfuncionario == false)
                {

                    this.dgvfuncio.Columns["Colunm1"].Visible = false;
                }
            }
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
            List<FuncionarioDTO> opi = ii.filtro(txtfuncio.Text, txtcpf.Text);


            dgvfuncio.DataSource = opi;


        }
    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {

               
                FuncionarioDTO pr = dgvfuncio.Rows[e.RowIndex].DataBoundItem as FuncionarioDTO;


                AlterarUsuario menu = new AlterarUsuario();
                menu.Loadscreen(pr);
                menu.ShowDialog();

            }
            if (e.ColumnIndex == 11)
            {
               
                DialogResult r = MessageBox.Show("vai excluir mesmo", "Amazing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    FuncionarioDTO pr = dgvfuncio.Rows[e.RowIndex].DataBoundItem as FuncionarioDTO;

                    FuncionarioBusiness funciobu = new FuncionarioBusiness();
                    funciobu.Remover(pr.Id);

                    MessageBox.Show("foi");
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
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
