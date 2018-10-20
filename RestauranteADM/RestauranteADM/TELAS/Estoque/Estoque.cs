using RestauranteADM.BASE.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.TELAS.Estoque
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            CarregarEstoque();

        }
        void CarregarEstoque()
        {
            EstoqueBusiness bus = new EstoqueBusiness();
            List<EstoqueDTO> estoq = bus.Listar();

            dataGridView1.DataSource = estoq;
        }

    }
}
