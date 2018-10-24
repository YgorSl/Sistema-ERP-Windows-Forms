using RestauranteADM.BASE.criptografia;
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
        criptgrafia criptografia = new criptgrafia();

        private void button1_Click(object sender, EventArgs e)
        {
         
            txt2.Text = criptografia.Codificar(txt1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt3.Text = criptografia.Decodificar(txt2.Text);
        }
    }
}
