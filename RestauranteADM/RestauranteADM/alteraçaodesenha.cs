using RestauranteADM.BASE.Recuperação;
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
    public partial class alteraçaodesenha : Form
    {
        public alteraçaodesenha()
        {
            InitializeComponent();
        }

        private string nome, senha, id;
  

        public void LoadScreen(string idt)
        {
            id= idt;

        }






        private void alteraçaodesenha_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            nome = txtnome.Text;
            senha = txtsenha.Text;

           int oi = Convert.ToInt32(id);

            AlteraçaoBunisess bunisess = new AlteraçaoBunisess();
            bunisess.alteraçao(oi, senha, nome);

            MessageBox.Show("senha e login alterandos por favor nao esqueça seu corno");




        }
    }
}
