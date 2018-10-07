using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }

            else
            {

                timer1.Enabled = false;
                this.Visible = false;
                Login login = new Login();
                login.Show();


            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
