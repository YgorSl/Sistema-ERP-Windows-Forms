using RestauranteADM.BASE.Usuario;
using RestauranteADM.TELAS;
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
using RestauranteADM.TELAS._1._0._1;

namespace RestauranteADM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            UsuarioBusiness bs = new UsuarioBusiness();
            
            UsuarioDTO usuario = bs.Logar(txtnome.Text, txtsenha.Text);
        
            if (usuario != null)
            {
                acesso.usuariologado = usuario;
                menu2 menu = new menu2();
                menu.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Credenciais Inválidas.", "Toc Toc Brasil",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
          

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
