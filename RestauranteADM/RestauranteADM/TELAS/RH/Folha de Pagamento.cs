using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteADM.BASE.Folha_de_Pagamento;
using RestauranteADM.BASE.Funcionario;

namespace RestauranteADM.TELAS.RH
{
    public partial class Folha_de_Pagamento : Form
    {
        Validacao v = new Validacao();

        public Folha_de_Pagamento()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<FuncionarioDTO> lista = business.Listar();

            comboBox1.ValueMember = nameof(FuncionarioDTO.Id);
            comboBox1.DisplayMember = nameof(FuncionarioDTO.Nome);
            comboBox1.DataSource = lista;
        }

        FuncionarioDTO forn;

        public void LoadScreen(FuncionarioDTO forn)

        {
            this.forn = forn;

            lblSalarioBase.Text = Convert.ToString(forn.Salario);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Folha_de_Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {


                double SalarioBase = Convert.ToDouble(lblSalarioBase.Text);
                double PercentualHE = Convert.ToDouble(txtpercentualHE.Text);
                double QuantidadeHE = Convert.ToDouble(txtquntidadeHE.Text);
                double QuantidadeAtraso = Convert.ToDouble(txtquantAtraso.Text);
                double QuanTidadeFaltas = Convert.ToDouble(txtQuantDiasFaltas.Text);
                double QuantidadeDomingosFaltas = Convert.ToDouble(txtQuantDomingosFaltas.Text);
                double QuantdadeDeMenor = Convert.ToDouble(txtQuantSF.Text);
                double ValorConvenio = Convert.ToDouble(txtConvenio.Text);
                lblSubConvenio.Text = Convert.ToString(ValorConvenio);
                double ValorCestaBasica = Convert.ToDouble(txtCestaBasica.Text);
                lblSubCesta.Text = Convert.ToString(ValorCestaBasica);
               


                if (lblSalarioBase != null)
                {


                    FolhaPagamento folha = new FolhaPagamento();
                    double SH = folha.CalcularSH(SalarioBase);


                    double HE = folha.CalcularHE(SH, PercentualHE, QuantidadeHE);
                    lblHE.Text = Convert.ToString(HE);


                    double DSR = folha.CalcularDSRHE(HE, QuanTidadeFaltas, QuantidadeDomingosFaltas);
                    lbldsr.Text = Convert.ToString(DSR);


                    double Atraso = folha.CalcularAtrasos(SH, QuantidadeAtraso);
                    lblAtraso.Text = Convert.ToString(Atraso);



                    double Faltas = folha.CalcularFaltas(SalarioBase, QuanTidadeFaltas, QuantidadeDomingosFaltas);
                    lblSubFaltas.Text = Convert.ToString(Faltas);



                    double INSS = folha.CalcularINSS(SalarioBase, HE, DSR, Faltas, Atraso);
                    lblINSS.Text = Convert.ToString(INSS);



                    double BaseINSS = (SalarioBase + HE + DSR) - (Faltas + Atraso);
                    BaseINSS = Math.Round (BaseINSS, 2);
                    double fgts = folha.CalcularFGTS(BaseINSS);
                    lblFGTS.Text = Convert.ToString(fgts);



                    double IRRF = folha.CalcularIRRF(BaseINSS, INSS);
                    lblIRRF.Text = Convert.ToString(IRRF);



                    double VT = folha.CalcularVT(SalarioBase);
                    lblVT.Text = Convert.ToString(VT);



                    double SalarioFamilia = folha.CalcularSF(SalarioBase, QuantdadeDeMenor);
                    lblsubSF.Text = Convert.ToString(SalarioFamilia);



                    double VR = Convert.ToDouble(txtValorVR.Text);
                    lblSubVR.Text = VR.ToString();


                    double BonusSalarial = Convert.ToDouble(txtBonus.Text);
                    lblsubBonus.Text = BonusSalarial.ToString();


                    double total = folha.CalcularTotal(SalarioBase, HE, DSR, Faltas, Atraso, INSS, IRRF, VT, SalarioFamilia, BonusSalarial, ValorConvenio, ValorCestaBasica);
                    lblTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Todos os campos devem conter digitos presentes no conjunto dos numeros naturais, porém não devem ser nulos. Preencha os campos corretamente e tente outra vez." + ex.Message,
                    "Toc Toc Brasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void txtQuantSF_TextChanged(object sender, EventArgs e)
        {


        }

        private void rbtsim_CheckedChanged(object sender, EventArgs e)
        {
            Desativar(this, txtQuantSF.Text);
        }

        private void Desativar(Form f, String nomeComponente)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == nomeComponente)
                        c.Enabled = true;
                    else
                        c.Enabled = false;
                }

            }
        }

        private void rbtsim_Click(object sender, EventArgs e)
        {
            Desativar(this, "txtQuantSF");
        }

        private void rbtnao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnao_Click(object sender, EventArgs e)
        {
            Desativar(this, "txtQuantSF");
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncionarioDTO dto = comboBox1.SelectedItem as FuncionarioDTO;
            lblSalarioBase.Text = Convert.ToString(dto.Salario);
            lblID.Text = Convert.ToString(dto.Id);
            txtcpf.Text = dto.Cpf;
            txtnome.Text = dto.Nome;
    



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtquntidadeHE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyPressquantHE(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtpercentualHE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyPressPercentualHE(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressValorBonus(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressQuantSF(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressQuantAtrasos(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtQuantFaltas(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressQuantDomingos(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtKeyPressValorVR(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void KeyPressValorCesta(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtValorConvenio(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();

                dto.IdFuncionario = Convert.ToInt32(lblID.Text);
                dto.FGTS = Convert.ToDouble(lblFGTS.Text);
                dto.VT = Convert.ToDouble(lblVT.Text);
                dto.INSS = Convert.ToDouble(lblINSS.Text);
                dto.IRRF = Convert.ToDouble(lblIRRF.Text);
                dto.VR = Convert.ToDouble(lblSubVR.Text);
                dto.SalarioFamilia = Convert.ToDouble(lblsubSF.Text);
                dto.DSR = Convert.ToDouble(lbldsr.Text);
                dto.HE = Convert.ToDouble(lblHE.Text);
                dto.Atraso = Convert.ToDouble(lblID.Text);
                dto.Falta = Convert.ToDouble(lblSubFaltas.Text);
                dto.Convenio = Convert.ToDouble(lblSubConvenio.Text);
                dto.CestaBasica = Convert.ToDouble(lblSubCesta.Text);
                dto.Bonus = Convert.ToDouble(lblsubBonus.Text);
                dto.SalarioLiquido = Convert.ToDouble(lblTotal.Text);
               
                dto.CPF = txtcpf.Text;


                FolhaPagamentoBusiness ft = new FolhaPagamentoBusiness();
                ft.salvar(dto);

                MessageBox.Show("Folha de Pagamento foi salva com sucesso! :)");

            }
            catch 
            {
                MessageBox.Show("Ocorreu um erro! Verifique se todos os campos estão preenchidos corretamente ou entre em contato com o administrador. :(");

            }
               
           
        }

        private void lblSalarioBase_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblSubAtraso_Click(object sender, EventArgs e)
        {
           
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menuinicial oi = new Menuinicial();
            oi.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}



