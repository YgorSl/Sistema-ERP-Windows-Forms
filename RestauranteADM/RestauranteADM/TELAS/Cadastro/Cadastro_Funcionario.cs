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

namespace RestauranteADM.TELAS.Cadastro
{
    public partial class Cadastro_Funcionario : Form
    {
        Validacao v = new Validacao();

        public Cadastro_Funcionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void Cadastro_Funcionario_Load(object sender, EventArgs e)
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

        private void txtKeyPressCEP(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }
    }
}
