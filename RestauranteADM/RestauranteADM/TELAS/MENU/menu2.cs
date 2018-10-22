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

namespace RestauranteADM.TELAS._1._0._1
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
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



        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirForminPanel(new ());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  AbrirForminPanel(new MenuVendas());
        }

        private void MenuVertical_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
          
             if (SubMenuCadastro.Visible == false)
            {
                SubMenuCadastro.Visible = true;
            }
            else
            {
                SubMenuCadastro.Visible = false;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu_Vendas form = new Menu_Vendas();
            form.Show();
            this.Hide();
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu_RH form = new Menu_RH();
            form.Show();
            this.Hide();
        }

      
 
        private void button3_Click_1(object sender, EventArgs e)
        {
            
            AbrirForminPanel(new PedidoCompra());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Fluxo_de_Caixa());
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {

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

            }
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
            AbrirForminPanel(new Cadastro_de_fornecedor());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastro_usuário_do_sistema());
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastro_de_estoque());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastro___de_Cardapio());
        }

        private void SubMenuConsultar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
