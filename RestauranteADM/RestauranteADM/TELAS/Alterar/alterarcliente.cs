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

namespace RestauranteADM.TELAS.Alterar
{
    public partial class alterarcliente : Form
    {
        public alterarcliente()
        {
            InitializeComponent();
        }
        ClienteDTO cliente;

        private void alterarcliente_Load(object sender, EventArgs e)
        {


           

        }

        public void Loadscreen(ClienteDTO cliente)

        {
            this.cliente = cliente;

            txtnome.Text = this.cliente.Nome;
            txtcpf.Text = this.cliente.Cpf;
            txttelefone.Text = this.cliente.Telefone;
            txtcep.Text = this.cliente.Cep;
            txtbairro.Text = this.cliente.Bairro;
            txtnumcasa.Text = this.cliente.NumeroCasa;
            txtcnpj.Text = this.cliente.Cnpj;
            rtvanotaçoes.Text = this.cliente.anotaçao_cliente;
            dtphoje.Value = this.cliente.data_hoje;



        }

        private void button1_Click(object sender, EventArgs e)
        {


            cliente.Nome = txtnome.Text;
          
            cliente.Telefone = txttelefone.Text;
            cliente.Cep = txtcep.Text;
            cliente.Bairro = txtbairro.Text;
            cliente.NumeroCasa = txtnumcasa.Text;
            cliente.Cpf = txtcpf.Text;

            if (txtfisica.Checked == true)
            {
                cliente.Tipopessoa = "PF";
             

            }
            else if (txtjuridica.Checked == true)
            {
                cliente.Tipopessoa = "PJ";
          


            }

            cliente.Cnpj = txtcnpj.Text;
            cliente.anotaçao_cliente = rtvanotaçoes.Text;


            cliente.data_hoje = dtphoje.Value;


            ClienteBusiness ft = new ClienteBusiness();
            ft.Update(cliente);

            MessageBox.Show("cliente alterado:)");

            this.Hide();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtfisica_CheckedChanged(object sender, EventArgs e)
        {
            if (txtfisica.Checked == true)
            {
                txtcnpj.Enabled = false;

            }
            else
            {
                txtcnpj.Enabled = true;

            }

        }

        private void txtjuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (txtjuridica.Checked == true)
            {
                txtcpf.Enabled = false;

            }
            else
            {
                txtcpf.Enabled = true;

            }

        

        }

      
    }
    }

