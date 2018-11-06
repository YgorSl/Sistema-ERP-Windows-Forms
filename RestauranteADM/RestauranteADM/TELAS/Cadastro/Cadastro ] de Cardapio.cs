using RestauranteADM.BASE.Cardapio;
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
    public partial class Cadastro___de_Cardapio : Form
    {
        Validacao v = new Validacao();

        public Cadastro___de_Cardapio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cadastro___de_Cardapio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                CardapioDTO dto = new CardapioDTO();


                dto.nome_Prato = txtnomeprato.Text;
                dto.Tamanho = txttamanho.Text;

                dto.Descrição = rtvanotaçoes.Text;
                dto.Valor = Convert.ToDouble(txtvalor.Text);

                CardapioBusiness bus = new CardapioBusiness();
                bus.salvar(dto);


                MessageBox.Show("Prato salvo com sucesso! :)");
     
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }
    }

















        }
    


