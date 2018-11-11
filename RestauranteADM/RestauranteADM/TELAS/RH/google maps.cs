using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace RestauranteADM.TELAS
{
    public partial class google_maps : Form
    {
        public google_maps()
        {
            InitializeComponent();
        }

        public void loadscren(string cpf)
        {
            textBox2.Text = cpf;
        }



        private void button1_Click(object sender, EventArgs e)
        {







            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("insira o ponto de inicio e de chegada");
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("insira o ponto de inicio");
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("insira o ponto de inicio");
            }
            else
            {
                NavigateToRoute(new string[2] { textBox1.Text, textBox2.Text });
            }











        }

        private void google_maps_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void map_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        public void NavigateToRoute(IEnumerable<string> points)
        {
      
            StringBuilder url = new StringBuilder("https://www.google.com.br/maps/dir/");
            foreach (string point in points)
            {
                url.Append(Uri.EscapeDataString(point));
                url.Append("/");
            }

            webBrowser1.Navigate(new Uri(url.ToString()));
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void google_maps_Load_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


