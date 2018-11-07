using RestauranteADM.BASE.Conta_a_Pagar;
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
    public partial class cadastrar_conta : Form
    {
        public cadastrar_conta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("conta Salvo com sucesso! :)");
        }

        private void cadastrar_conta_Load(object sender, EventArgs e)
        {

        }
    }
}
