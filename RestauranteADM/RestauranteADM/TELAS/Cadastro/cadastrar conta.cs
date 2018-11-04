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
            ContaPagarDTO dto = new ContaPagarDTO();

            dto.tipo = txttipo.Text;
            dto.chegou = Convert.ToDateTime(dtphoje.Text);
            dto.validade = Convert.ToDateTime(txtvalidade.Text);
            dto.Preço = Convert.ToDouble(txtpreço.Text);







            ContaPagarBusiness ft = new ContaPagarBusiness();
            ft.Salvar(dto);

            MessageBox.Show("conta Salvo com sucesso! :)");
        }
    }
}
