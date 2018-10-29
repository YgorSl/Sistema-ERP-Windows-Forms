using RestauranteADM.BASE.BaterPonto;
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
    public partial class bater_ponto : Form
    {
        public bater_ponto()
        {
            InitializeComponent();
        }
        private string cpf ,id;
  

        public void LoadScreen(string idt)
        {
            
            id = idt;

        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbldata.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

            cpf = txtcpf.Text;

            BaterPontoBusiness bunisess = new BaterPontoBusiness();
            bunisess.verificar(cpf);
        }

        private void btnebtrada_Click(object sender, EventArgs e)
        {

            BaterPontoDTO dto = new BaterPontoDTO();
            dto.Data =Convert.ToDateTime( lbldata.Text);
            dto.Entrada = Convert.ToDateTime(lblhora.Text);

           dto.IdFuncionario = Convert.ToInt32(id);


            BaterPontoBusiness bunisess = new BaterPontoBusiness();
            bunisess.Salvar(dto);

            MessageBox.Show("foi");
        }

        private void bater_ponto_Load(object sender, EventArgs e)
        {

        }
    }
}
