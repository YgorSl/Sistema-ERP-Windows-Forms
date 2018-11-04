using RestauranteADM.BASE.criptografia;
using RestauranteADM.BASE.Recuperação;
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

namespace RestauranteADM
{
    public partial class cript : Form
    {
        public cript()
        {
            InitializeComponent();
        }

        AlteracaoLogin alteraçao = new AlteracaoLogin();


          AlteraçaoBunisess login = new AlteraçaoBunisess();

        private void button1_Click(object sender, EventArgs e)
        {
         
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtmensagem.Text = login.recuperaçao(txtRecuperacao.Text);
            pan1.Enabled = true;
        }

        private void cript_Load(object sender, EventArgs e)
        {

        }

        private void btncodigo_Click(object sender, EventArgs e)
        {
            AlteraçaoBunisess oi = new AlteraçaoBunisess();


              oi.verificacao(txtcodigo.Text);

            Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
