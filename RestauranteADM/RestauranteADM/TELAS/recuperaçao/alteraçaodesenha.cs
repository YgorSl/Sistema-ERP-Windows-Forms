using RestauranteADM.Acesso;
using RestauranteADM.BASE.criptografia;
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

        private string id;
  

        public void LoadScreen(string idt)
        {
            id= idt;

        }






        private void alteraçaodesenha_Load(object sender, EventArgs e)
        {
           
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtsenha.Text==txtsenha2.Text)
            {
                criptgrafia criptografia = new criptgrafia();
                string Login = criptografia.Codificar(txtnome.Text);
                string Senhar = criptografia.Codificar(txtsenha2.Text);
                    int oi = acesso.funcionariologado.Id;

                 

                AlteraçaoBunisess bunisess = new AlteraçaoBunisess();
                bunisess.alteraçao(oi, Login, Senhar);

                MessageBox.Show("senha e login alterandos por favor ");

                Login login = new Login();
                login.Show();

                Close();

            }
            else
            {
                MessageBox.Show("As duas mensagem nao estao iguais por favor verifique");


            }

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos corretamente!", "TocTocBrasil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          




        }

        private void label5_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();

            Close();
        }
    }
}
