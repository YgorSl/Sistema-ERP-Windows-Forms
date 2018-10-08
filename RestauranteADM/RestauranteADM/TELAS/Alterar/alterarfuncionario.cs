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
        public alterarfuncionario()
        {
            InitializeComponent();


        }

        FuncionarioDTO funcio;
        UsuarioDTO usuario;


        public void Loadscreen(FuncionarioDTO funcio)

        {
            this.funcio = funcio;
           

            txtnome.Text = this.funcio.Nome;
            txtcpf.Text = this.funcio.Cpf;
             txtsalario.Text= this.funcio.Salario.ToString();
            txtrg.Text = this.funcio.Rg;
            txtendereço.Text = this.funcio.Rg;









        }

      

        private void btnCadastrarusuario_Click(object sender, EventArgs e)
        {
            

            FuncionarioDTO funcio = new FuncionarioDTO();

            funcio.Nome = txtnome.Text;
            funcio.Cpf = txtcpf.Text;
            funcio.Salario = Convert.ToDouble(txtsalario.Text);
            funcio.Rg = txtrg.Text;
            funcio.Endereço = txtendereço.Text;
            

            UsuarioDTO usuario = new UsuarioDTO();
            usuario.login = txtusuario.Text;
            usuario.senha = txtsenha.Text;
            usuario.permissaototal = chbtotal.Checked;
            usuario.permissaoRH = chbrh.Checked;
            usuario.permissaofinanceiro = chbfinanceiro.Checked;
            usuario.permissaocadastro = chbcadastro.Checked;
            usuario.permissaovendas = chbvendas.Checked;
            usuario.permissaocompras = chbcompras.Checked;

            FuncionarioBusiness iop = new FuncionarioBusiness();
            iop.Update(funcio, usuario);

            MessageBox.Show("foi alterou");


        }

        private void alterarfuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crud_funcionario oi = new crud_funcionario();
            oi.Show();
        }
    }
}