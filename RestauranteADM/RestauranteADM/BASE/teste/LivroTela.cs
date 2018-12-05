using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.BASE.teste
{
    public partial class LivroTela : Form
    {
        public LivroTela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LivroDTO dto = new LivroDTO();
            dto.nome = txt1.Text;
            dto.editora = txt2.Text;
            dto.Categoria = Convert.ToInt32(txt3.Text);
            dto.autor = txt4.Text;
            dto.codigo = Convert.ToInt32(txt5.Text);
            dto.lançamento = Convert.ToDateTime(dtp1.Value);

            Livrobusiness ok = new Livrobusiness();
            ok.Salvar(dto);

        }
    }
}
