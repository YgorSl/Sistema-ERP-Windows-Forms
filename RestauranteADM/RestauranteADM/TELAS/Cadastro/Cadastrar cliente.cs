using RestauranteADM.BASE.Cliente;
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
    public partial class Cadastrar_cliente : Form
    {
        public Cadastrar_cliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_cliente_Load(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

    
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtphoje.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text != string.Empty || mtbcpf.Text != string.Empty || mtbtelefone.Text != string.Empty || mbtcep.Text != string.Empty || txtbairro.Text != string.Empty || txtnumcasa.Text != string.Empty || txtfisica.Checked == false & txtjuridica.Checked == false)
                {

                    ClienteDTO dto = new ClienteDTO();

                    dto.Nome = txtnome.Text;
                    dto.Cpf = mtbcpf.Text;
                    dto.Telefone = mtbtelefone.Text;
                    dto.Cep = mbtcep.Text;
                    dto.Bairro = txtbairro.Text;
                    dto.NumeroCasa = txtnumcasa.Text;
                    dto.Rua = txtrua.Text;
                    dto.Cidade = txtcidade.Text;

                    if (txtfisica.Checked == true)
                    {
                        dto.Tipopessoa = "PF";
                        dto.Cpf = mtbcpf.Text;


                    }
                    if (txtjuridica.Checked == true)
                    {
                        dto.Tipopessoa = "PJ";



                    }

                    dto.Cnpj = mtbcnpj.Text;






                    dto.anotaçao_cliente = rtvanotaçoes.Text;


                    dto.data_hoje = dtphoje.Value;


                    ClienteBusiness ft = new ClienteBusiness();
                    ft.Salvar(dto);

                    MessageBox.Show("cliente Salvo com sucesso! :)");
                }
                else
                {
                    MessageBox.Show("Por favor preencha todos os campos! Principalmente se o cliente é pessoa fisica ou juridica.");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos!"); 
            }
           
        }



        private void txtfisica_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtfisica.Checked == true)
            {
                mtbcnpj.Enabled = false;
                mtbcnpj.Text = "-";

            }
            else
            {
                mtbcnpj.Enabled = true;
                mtbcnpj.Text = string.Empty;
            }

        }

        private void txtjuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (txtjuridica.Checked == true)
            {
                mtbcpf.Enabled = false;
                mtbcpf.Text = "-";

            }
            else
            {
                mtbcpf.Enabled = true;
                mtbcpf.Text = string.Empty;

            }

        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                var result = ws.consultaCEP(mbtcep.Text);
                txtbairro.Text = result.bairro;
                txtcidade.Text = result.cidade;
                txtrua.Text = result.end;
            }

            }
            catch (Exception)
            {

                MessageBox.Show("CEP Invalido.", "Toc Toc Brasil",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mbtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
