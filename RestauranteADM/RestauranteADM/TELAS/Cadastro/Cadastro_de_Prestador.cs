using RestauranteADM.BASE.Fornecedor;
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
    public partial class Cadastro_de_Prestador : Form
    {
        Validacao v = new Validacao();

        public Cadastro_de_Prestador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            ProvedorDTO forn = new ProvedorDTO();
                forn.Nome = txtnome.Text;
                forn.Cnpj = txtcnpj.Text;
                forn.Telefone = txttelefone.Text;
                forn.Endereço = txtend.Text;
                forn.Cidade = txtcid.Text;
                forn.Estado = txtest.Text;
                forn.Bairro = txtbairro.Text;
                forn.CEP = txtcep.Text;



                FornecedorBusiness bus = new FornecedorBusiness();
                bus.Salvar1(forn);

                MessageBox.Show("Prestador Cadastrado com Sucesso", "Amazing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "TocToc Basil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cadastro_de_fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
            this.Hide();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtCidade_Keypress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void mbtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                var result = ws.consultaCEP(txtcep.Text);
                txtbairro.Text = result.bairro;
                txtcid.Text = result.cidade;
                txtend.Text = result.end;
                txtest.Text = result.uf;

            }

            }
            catch (Exception)
            {

                MessageBox.Show("CEP Invalido", "TocToc Basil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void white(object sender, PaintEventArgs e)
        {

        }
    }
}
