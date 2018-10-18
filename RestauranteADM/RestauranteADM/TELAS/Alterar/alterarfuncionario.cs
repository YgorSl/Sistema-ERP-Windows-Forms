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


        public void Loadscreen(FuncionarioDTO funcio, UsuarioDTO usuario)

        {
            this.funcio = funcio;
            this.usuario = usuario;


            txtnome.Text = this.funcio.Nome;
            txtcpf.Text = this.funcio.Cpf;
             txtsalario.Text= this.funcio.Salario.ToString();
            txtrg.Text = this.funcio.Rg;
            txtendereço.Text = this.funcio.Rg;
            
            txtusuario.Text = this.usuario.login;
            txtsenha.Text = this.usuario.senha;
            chbtotal.Checked = this.usuario.permissaototal;
            chbrh.Checked = this.usuario.permissaoRH;
            chbfinanceiro.Checked = this.usuario.permissaofinanceiro;
            chbcadastro.Checked = this.usuario.permissaocadastro;
            chbvendas.Checked = this.usuario.permissaovendas;
            chbcompras.Checked = this.usuario.permissaocompras;







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
    }
}