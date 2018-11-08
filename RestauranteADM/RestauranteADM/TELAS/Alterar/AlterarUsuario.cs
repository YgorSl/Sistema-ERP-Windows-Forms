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
using RestauranteADM.BASE.Fornecedor;

namespace RestauranteADM.TELAS
{
    public partial class AlterarUsuario : Form
    {
        Validacao v = new Validacao();


        criptgrafia criptografia = new criptgrafia();

        public AlterarUsuario()
        {
            InitializeComponent();
            
        }
        FuncionarioDTO dto;
        public void Loadscreen(FuncionarioDTO dto)
        {
            txtnome.Text =dto.Nome;
            mtbcpf.Text = dto.Cpf ;
            maskedTextBox1.Text = dto.Rg ;
            txtsalario.Text = dto.Salario.ToString();
            txtrecuperacao.Text= dto.senha_recuperaçao ;
            txtgmail.Text=dto.Gmail;
            mbtcep.Text = dto.Cep ;
            txtbairro.Text=dto.Bairro ;
            txtnumerocasa.Text = dto.N_local;
            txtrua.Text=dto.Rua;
            txtcidade.Text = dto.Cidade;
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

        private void btnCadastrarusuario_Click(object sender, EventArgs e)
        {
            try
            {




                FuncionarioDTO dto = new FuncionarioDTO();


                dto.Nome = txtnome.Text;
                dto.Cpf = mtbcpf.Text;
                dto.Rg = maskedTextBox1.Text;
                dto.Salario = Convert.ToDouble(txtsalario.Text);
                dto.senha_recuperaçao = txtrecuperacao.Text;
                dto.Gmail = txtgmail.Text;
                dto.Cep = mbtcep.Text;
                dto.Bairro = txtbairro.Text;
                dto.N_local = txtnumerocasa.Text;
                dto.Rua = txtrua.Text;
                dto.Cidade = txtcidade.Text;




                UsuarioDTO usuario = new UsuarioDTO();

                string Login = criptografia.Codificar(txtusuario.Text);
                string Senhar = criptografia.Codificar(txtsenha.Text);

                usuario.login = Login;
                usuario.senha = Senhar;




                usuario.permissaototal = chbtotal.Checked;
                usuario.permissaoRH = chbrh.Checked;
                usuario.permissaofinanceiro = chbfinanceiro.Checked;
                usuario.permissaocadastro = chbcadastro.Checked;
                usuario.permissaovendas = chbvendas.Checked;
                usuario.permissaocompras = chbcompras.Checked;
                usuario.permissaoestoque = chbMenuEstoque.Checked;
                usuario.permissaoconsultar = chbConsultar.Checked;
                usuario.permissaocadastrarcliente = chbCadastroCliente.Checked;
                usuario.permissaocadastrarproduto = chbCadastroProduto.Checked;
                usuario.permissaocadastrarfuncionario = chbCadastroFuncionario.Checked;
                usuario.permissaocadastrarfornecedor = chbCadastroFornecedor.Checked;
                usuario.permissaocadastrarcardapio = chbCardapio.Checked;
                usuario.permissaocadastrarfolha = chbCadastrarFolha.Checked;
                usuario.permissaoconsultarcliente = chbConsultarCliente.Checked;
                usuario.permissaoconsultarfornecedor = chbConsultarFornecedor.Checked;
                usuario.permissaoconsultarproduto = chbConsultarProduto.Checked;
                usuario.permissaoconsultarcardapio = chbExcluirCardapio.Checked;
                usuario.permissaoconsultarfuncionario = chbConsultarFuncionario.Checked;
                usuario.permissaoconsultarpedido = chbConsultarFuncionario.Checked;
                usuario.permissaoconsultarvenda = chbConsultarVendas.Checked;
                usuario.permissaoconsultarfolha = chbConsultarFolha.Checked;
                usuario.permissaoalterarcliente = chbAlterarCliente.Checked;
                usuario.permissaoalterarfornecedor = chbAlterarFornecedor.Checked;
                usuario.permissaoalterarproduto = chbAlterarProduto.Checked;
                usuario.permissaoalterarcardapio = chbAlterarCardapio.Checked;
                usuario.permissaoalterarfuncionario = chbAlterarFuncionario.Checked;
                usuario.permissaoalterarpedido = chbAlterarPedido.Checked;
                usuario.permissaoalterarvenda = chbAlterarVendas.Checked;
                usuario.permissaoexcluircliente = chbExcluirCliente.Checked;
                usuario.permissaoexcluirfornecedor = chbExcluirFornecedor.Checked;
                usuario.permissaoexcluirproduto = chbExcluirProduto.Checked;
                usuario.permissaoexcluircardapio = chbExcluirCardapio.Checked;
                usuario.permissaoexcluirfuncionario = chbExcluirFuncionario.Checked;
                usuario.permissaoexcluirpedido = chbExcluirPedido.Checked;
                usuario.permissaoexcluirvenda = chbExcluirVendas.Checked;
                usuario.permissaoexcluirfolha = chbExcluirFolha.Checked;



                FuncionarioBusiness ft = new FuncionarioBusiness();
                ft.Update(dto, usuario);

                MessageBox.Show("Usuário Salvo com sucesso! :)");
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente", "TocTocBrasil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void chbConsultarCardapio_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                var result = ws.consultaCEP(mbtcep.Text);
                txtbairro.Text = result.bairro;
                txtcidade.Text = result.cidade;
                txtrua.Text = result.end;
            }

            }
            catch (Exception)
            {

                MessageBox.Show("CEP Invalido" ,"TocToc Basil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyPress_txtGmail(object sender, KeyPressEventArgs e)
        {

        }

        private void KeyPress_txtCEP(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void KeyPress_txtCidade(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtNumero(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void KeyPress_txtBairro(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void KeyPress_txtRua(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }
    }
}
    

