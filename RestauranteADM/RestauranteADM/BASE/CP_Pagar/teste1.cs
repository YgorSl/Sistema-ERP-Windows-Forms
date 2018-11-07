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
    public partial class teste1 : Form
    {
        public teste1()
        {
            InitializeComponent();
            CarregarCombo();
        }
        void CarregarCombo()
        {
            FornecedorBusiness bus = new FornecedorBusiness();
            List<FornecedorDTO> comp = bus.Listar();


            cboforn.DataSource = comp;
            cboforn.DisplayMember = "Nome";
            cboforn.ValueMember = "Id";

            FornecedorDTO dto = cboforn.SelectedItem as FornecedorDTO;
            lbl1.Text = dto.Cnpj;



        }

        private void teste1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            dto.parcelados = Convert.ToInt32(nudparcelas.TextAlign);

        ContaPagarBusiness ft = new ContaPagarBusiness();
            ft.Salvar(dto);
        }

        private void cboforn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
