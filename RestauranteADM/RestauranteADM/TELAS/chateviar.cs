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
    public partial class chateviar : Form
    {
        public chateviar()
        {
            InitializeComponent();
        }
        public void LoadScreen(string msg, DateTime inclusao)
        {
            lblMensagem.Text = msg;
            lblHorario.Text = inclusao.ToShortTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
