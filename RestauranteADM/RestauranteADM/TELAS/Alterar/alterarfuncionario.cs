using RestauranteADM.BASE.Funcionario;
using RestauranteADM.BASE.Login;
using RestauranteADM.BASE.Usuario;
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
    public partial class alterarfuncionario : Form
    {
        Validacao v = new Validacao();

        public alterarfuncionario()
        {
            InitializeComponent();


        }

        FuncionarioDTO funcio;
        UsuarioDTO usuario;


        public void Loadscreen(FuncionarioDTO funcio)

        {
            this.funcio = funcio;
            


            txtnome.Text = funcio.Nome;
            txtcpf.Text = funcio.Cpf;
             txtsalario.Text= funcio.Salario.ToString();
            txtrg.Text = funcio.Rg;
            txtendereço.Text = funcio.Rg;
            
          






        }

      

        private void btnCadastrarusuario_Click(object sender, EventArgs e)
        {
            

        

           this.funcio.Nome = txtnome.Text;
            this.funcio.Cpf = txtcpf.Text;
            this.funcio.Salario = Convert.ToDouble(txtsalario.Text);
            this.funcio.Rg = txtrg.Text;
            this.funcio.Endereço = txtendereço.Text;


            this.usuario.login = txtusuario.Text;
            this.usuario.senha = txtsenha.Text;
            this.usuario.permissaototal = chbtotal.Checked;
            this.usuario.permissaoRH = chbrh.Checked;
            this.usuario.permissaofinanceiro = chbfinanceiro.Checked;
            this.usuario.permissaocadastro = chbcadastro.Checked;
            this.usuario.permissaovendas = chbvendas.Checked;
            this.usuario.permissaocompras = chbcompras.Checked;

            FuncionarioBusiness iop = new FuncionarioBusiness();
            iop.Update(this.funcio, this.usuario);

            MessageBox.Show("Alterado Com Sucesso!");
            this.Hide();


        }

        private void alterarfuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crud_funcionario oi = new crud_funcionario();
            oi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Keypress_txtNome(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void Keypress_txtCPF(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void Keypress_txtRG(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }
    }
}