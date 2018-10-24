using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.BASE.Funcionario;
using RestauranteADM.BASE.Login;
using RestauranteADM.BASE.criptografia;

namespace RestauranteADM.TELAS
{
    public partial class Cadastro_usuário_do_sistema : Form
    {
        Validacao v = new Validacao();


        criptgrafia criptografia = new criptgrafia();

        public Cadastro_usuário_do_sistema()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                FuncionarioDTO dto = new FuncionarioDTO();


                dto.Nome = txtnome.Text;
                dto.Cpf = txtcpf.Text;

                dto.Rg = txtrg.Text;
                dto.Endereço = txtendereço.Text;

                dto.Gmail = txtgmail.Text;
                dto.senha_recuperaçao = txtrecuperacao.Text;




                dto.Salario = Convert.ToDouble(txtsalario.Text);


                UsuarioDTO usuario = new UsuarioDTO();

                string senha = criptografia.Codificar(txtsenha.Text);
                string login = criptografia.Codificar(txtusuario.Text);

                usuario.login = login;
                usuario.senha = senha;
                usuario.permissaototal = chbtotal.Checked;
                usuario.permissaoRH = chbrh.Checked;
                usuario.permissaofinanceiro = chbfinanceiro.Checked;
                usuario.permissaocadastro = chbcadastro.Checked;
                usuario.permissaovendas = chbvendas.Checked;
                usuario.permissaocompras = chbcompras.Checked;

                FuncionarioBusiness ft = new FuncionarioBusiness();
                ft.Salvar(dto, usuario);

                MessageBox.Show("Usuário Salvo com sucesso! :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador. " + ex.Message,
                    "Toc Toc Brasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chbcompras_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void chbfinanceiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbrh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbvendas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbtotal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_usuário_do_sistema_Load(object sender, EventArgs e)
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

        private void txtKeyPressNome(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void txtKeyPressCPF(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressRG(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressSalario(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
            this.Hide();
        }
    }
}
