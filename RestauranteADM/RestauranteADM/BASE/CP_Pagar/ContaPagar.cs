using RestauranteADM.BASE.Conta_a_Pagar;
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

namespace RestauranteADM.BASE.CP_Pagar
{
    public partial class ContaPagar : Form
    {
        public ContaPagar()
        {
            InitializeComponent();
            CarregarCombo();
        }
        void CarregarCombo()
        {
            FornecedorBusiness bus = new FornecedorBusiness();
            List<ProvedorDTO> comp = bus.Consultar();


            cboforn.DataSource = comp;
            cboforn.DisplayMember = "Nome";
            cboforn.ValueMember = "Id";

            ProvedorDTO dto = cboforn.SelectedItem as ProvedorDTO;
            dto.Cnpj = mtbcnpj.Text;



        }


        private void teste1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdb1.Checked == true)
            {
                ContaPagarDTO dto = new ContaPagarDTO();


                dto.tipo_cobrança = cbmtipocobraça.Text;

                dto.conta_contabil = cbxcontabil.Text;
                dto.conta_contabil_ds = txtcontabil.Text;
                dto.conta = txtconta.Text;
                dto.agencia = txtagencia.Text;
                dto.banco = txtbanco.Text;
                dto.observaçao = rtvanotaçoes.Text;
                dto.emissao = Convert.ToDateTime(dtpemissa.Value);
                dto.data_cadastro = Convert.ToDateTime(dtpdatacadastro.Value);
                dto.vencimento = Convert.ToDateTime(dtpvencimento.Value);
                dto.valor_titulo = Convert.ToInt32(txtvalortitulo.Text);
                dto.parcelados = Convert.ToInt32(nudparcelas.Value);
                dto.Cnpj = mtbcnpj.Text;
                dto.Prestador = cboforn.Text;
                dto.valor_parcelas = Convert.ToDouble(txtparcelas.Text);

                ContaPagarBusiness ft = new ContaPagarBusiness();
                ft.Salvar(dto);

                MessageBox.Show("a conta foi salva");
            }
          
            else if( rdb2.Checked==true)
            {
                ContaPagarDTO dto = new ContaPagarDTO();


                dto.tipo_cobrança = cbmtipocobraça.Text;

                dto.conta_contabil = cbxcontabil.Text;
                dto.conta_contabil_ds = txtcontabil.Text;
                dto.conta = txtconta.Text;
                dto.agencia = txtagencia.Text;
                dto.banco = txtbanco.Text;
                dto.observaçao = rtvanotaçoes.Text;
                dto.emissao = Convert.ToDateTime(dtpemissa.Value);
                dto.data_cadastro = Convert.ToDateTime(dtpdatacadastro.Value);
                dto.vencimento = Convert.ToDateTime(dtpvencimento.Value);
                dto.valor_titulo = Convert.ToInt32(txtvalortitulo.Text);
                dto.Cnpj = mtbcnpj.Text;
                dto.Prestador = cboforn.Text;
        

                ContaPagarBusiness ft = new ContaPagarBusiness();
                ft.Salvar(dto);

                MessageBox.Show("a conta foi salva");

            }
        }

        private void cboforn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvedorDTO dto = cboforn.SelectedItem as ProvedorDTO;
            mtbcnpj.Text = dto.Cnpj;
            
    }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Enabled = true;
            pnl1.Visible = true;
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Enabled = false;
            pnl1.Visible = false;

       


        }
    }
}
