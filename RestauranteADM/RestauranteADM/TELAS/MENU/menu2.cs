using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RestauranteADM.TELAS.MENU;
using RestauranteADM.TELAS.Cadastro;
using RestauranteADM.TELAS.Financeiro;
using RestauranteADM.Acesso;
using RestauranteADM.TELAS.Consulta;
using RestauranteADM.TELAS.RH;
using RestauranteADM.TELAS.Estoque;

namespace RestauranteADM.TELAS._1._0._1
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
            VerificarPermissoes();
        }
        void VerificarPermissoes()
        {
            if (acesso.usuariologado.permissaototal == false)
            {
                if (acesso.usuariologado.permissaocadastro == false)
                {
                    btnmenucad.Enabled = false;
                }
                if (acesso.usuariologado.permissaovendas == false)
                {
                    btnmenuven.Enabled = false;
                }
                if (acesso.usuariologado.permissaocompras == false)
                {
                    btnmenucom.Enabled = false;
                }
                if (acesso.usuariologado.permissaoRH == false)
                {
                    btnmenurh.Enabled = false;
                }
                if (acesso.usuariologado.permissaofinanceiro == false)
                {
                    btnmenufin.Enabled = false;
                }
                if (acesso.usuariologado.permissaoestoque == false)
                {
                    btnmenuest.Enabled = false;
                }
                if (acesso.usuariologado.permissaocadastrarcliente == false)
                {
                    btnCadastrarCliente.Enabled = false;
                }
                if (acesso.usuariologado.permissaocadastrarfornecedor == false)
                {
                    btnCadastrarFornecedor.Enabled = false;
                }
                if (acesso.usuariologado.permissaocadastrarfuncionario == false)
                {
                    btnCadastrarFuncionario.Enabled = false;
                }
                if (acesso.usuariologado.permissaocadastrarproduto == false)
                {
                    btnCadastrarProduto.Enabled = false;
                }
                if (acesso.usuariologado.permissaocadastrarcardapio == false)
                {
                    btnCadastrarCardapio.Enabled = false;
                }


            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }


        public void AbrirForminPanel(object Formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }





        private void MenuVertical_Paint_1(object sender, PaintEventArgs e)
        {
            
            

        }
        private void btn1_Click_1(object sender, EventArgs e)
        {


            if (SubMenuConsultar.Visible == true)
            {
                SubMenuConsultar.Visible = false;
            }
           

            if (SubMenuCadastro.Visible == false)
            {
                SubMenuCadastro.Visible = true;
            }
            else
            {
                SubMenuCadastro.Visible = false;
            }





            if (SubMenuRH.Visible == true)
            {
                SubMenuRH.Visible = false;
            }
            if (SubMenuEstoque.Visible == true)
            {
                SubMenuEstoque.Visible = false;
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (SubMenuConsultar.Visible == true)
            {
                SubMenuConsultar.Visible = false;
            }
     

            if (SubMenuCadastro.Visible == true)
            {
                SubMenuCadastro.Visible = false;
            }






            if (SubMenuRH.Visible == true)
            {
                SubMenuRH.Visible = false;
            }
            if (SubMenuEstoque.Visible == true)
            {
                SubMenuEstoque.Visible = false;
            }


            AbrirForminPanel(new telavendas());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (SubMenuConsultar.Visible == false)
            {
                SubMenuConsultar.Visible = true;
            }
            else
            {
                SubMenuConsultar.Visible = false;
            }

            if (SubMenuCadastro.Visible == true)
            {
                SubMenuCadastro.Visible = false;
            }
          


       


            if (SubMenuRH.Visible == true)
            {
                SubMenuRH.Visible = false;
            }
            if (SubMenuEstoque.Visible == true)
            {
                SubMenuEstoque.Visible = false;
            }


        }

   
       

      
 
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (SubMenuConsultar.Visible == true)
            {
                SubMenuConsultar.Visible = false;
            }
         

            if (SubMenuCadastro.Visible == true)
            {
                SubMenuCadastro.Visible = false;
            }






            if (SubMenuRH.Visible == true)
            {
                SubMenuRH.Visible = false;
            }
            if (SubMenuEstoque.Visible == true)
            {
                SubMenuEstoque.Visible = false;
            }

            AbrirForminPanel(new PedidoCompra());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Fluxo_de_Caixa());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SubMenuConsultar.Visible == true)
            {
                SubMenuConsultar.Visible = false;
            }
       

            if (SubMenuCadastro.Visible == true)
            {
                SubMenuCadastro.Visible = false;
            }






            if (SubMenuRH.Visible == true)
            {
                SubMenuRH.Visible = false;
            }
            if (SubMenuEstoque.Visible == false)
            {
                SubMenuEstoque.Visible = true;
            }

            else
            {
                SubMenuEstoque.Visible = false;
            }
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
           
            
       
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SubMenuCadastro.Visible = false;
            AbrirForminPanel(new Cadastrar_cliente());
        }

        private void SubMenuCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SubMenuCadastro.Visible = false;
            AbrirForminPanel(new Cadastro_de_fornecedor());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastro_usuário_do_sistema());
            SubMenuCadastro.Visible = false;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastro_de_estoque());
            SubMenuCadastro.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastro___de_Cardapio());
            SubMenuCadastro.Visible = false;
        }

        private void SubMenuConsultar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

            AbrirForminPanel(new Estoque_L());
            SubMenuEstoque.Visible = false;
        }

        private void SubMenuCadastro_Click(object sender, EventArgs e)
        {
            if (SubMenuCadastro.Visible == false)
            {
                SubMenuCadastro.Visible = true;
            }
            else
            {
                SubMenuCadastro.Visible = false;
            }


            if (SubMenuConsultar.Visible == true)
            {
                SubMenuConsultar.Visible = false;
            }


            if (SubMenuRH.Visible == true)
            {
                SubMenuRH.Visible = false;
            }

            if (SubMenuEstoque.Visible == true)
            {
                SubMenuEstoque.Visible = false;
            }
        }

        private void btnmenurh_Click(object sender, EventArgs e)
        {
            {

                if (SubMenuRH.Visible == false)
                {
                    SubMenuRH.Visible = true;
                }
                else
                {
                    SubMenuRH.Visible = false;
                }

                if (SubMenuConsultar.Visible == true)
                {
                    SubMenuConsultar.Visible = false;
                }
             
                if (SubMenuEstoque.Visible == true)
                {
                    SubMenuEstoque.Visible = false;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Consultar_cliente());
            SubMenuConsultar.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Consultar_Fornecedor());
            SubMenuConsultar.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Consulta_produto());
            SubMenuConsultar.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Consultar_Cardapio());
            SubMenuConsultar.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AbrirForminPanel(new crud_funcionario());
            SubMenuConsultar.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new ConsultarPedido());
            SubMenuConsultar.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new ConsultarVendas());
            SubMenuConsultar.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Folha_de_Pagamento());
            SubMenuRH.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new bater_ponto());
            SubMenuRH.Visible = false;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
           
            
        
        private void button13_Click(object sender, EventArgs e)
        {

            AbrirForminPanel(new ReceberEstoque());
            SubMenuEstoque.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
