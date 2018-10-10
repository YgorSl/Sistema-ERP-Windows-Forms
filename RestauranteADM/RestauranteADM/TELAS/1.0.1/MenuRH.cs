using RestauranteADM.TELAS.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS._1._0._1
{
    public partial class MenuRH : Form
    {
        public MenuRH()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Folha_de_Pagamento form = new Folha_de_Pagamento();
            form.Show();
            this.Hide();

        }
    }
}
