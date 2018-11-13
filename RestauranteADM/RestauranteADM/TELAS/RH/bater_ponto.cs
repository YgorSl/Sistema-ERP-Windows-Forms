using RestauranteADM.Acesso;
using RestauranteADM.BASE.BaterPonto;
using RestauranteADM.TELAS._1._0._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM
{
    public partial class bater_ponto : Form
    {
        public bater_ponto()
        {
            InitializeComponent();
        }
        private string cpf;



        public void ConfirmaçaoPonto(DateTime entrada, DateTime almoçoida, DateTime almoçovolta, DateTime saida)
        {
            if (entrada.Hour > 00 && entrada.Minute > 00 && entrada.Second > 00)
            {
                btnebtrada.Visible = false;
                btnsaida.Visible = true;
                btnalmoçosaida.Visible = true;

            }
            else
            {
                btnebtrada.Visible = true;
            }
        }




        private void tmr_Tick(object sender, EventArgs e)
        {

            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbldata.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            


           cpf = mtbcpf.Text;

            BaterPontoBusiness bunisess = new BaterPontoBusiness();
            bunisess.verificar(cpf);

            btnebtrada.Enabled = true;


            int id = acesso.funcionariologado.Id;
            DateTime dataagora = DateTime.Now;
            ///////metodo para listar e carregar minha variaveis com os valores do banco ,resultador da pesquisa/////////////
            BaterPontoDatabase business = new BaterPontoDatabase();
            BaterpontoConfirmaçao carregamentoponto = business.listar(id, dataagora);
            acesso.BaterPontoConfirmaçao = carregamentoponto;
////////////////////////////caregamento das informaçoes do banco//////////////////////////////////////////////////////////////
            DateTime entrada = acesso.BaterPontoConfirmaçao.Entrada;
            DateTime almoçoida = acesso.BaterPontoConfirmaçao.IdaAlmoço;
            DateTime almoçovolta = acesso.BaterPontoConfirmaçao.VoltaAlmoço;
            DateTime saida = acesso.BaterPontoConfirmaçao.Saida;
            //////////////////////////////////////////////////////////////////////////////

            ConfirmaçaoPonto(entrada, almoçoida, almoçovolta, saida);


            ////click para ter um grande penis azul //////
        }

        private void btnebtrada_Click(object sender, EventArgs e)
        {

            if (mtbcpf.Text != string.Empty)
            {
                int id = acesso.funcionariologado.Id;
                BaterPontoDTO dto = new BaterPontoDTO();
                dto.IdFuncionario = Convert.ToInt32(id);
                dto.Data = Convert.ToDateTime(lbldata.Text);
                dto.Entrada = Convert.ToDateTime(lblhora.Text);



                BaterPontoBusiness bunisess = new BaterPontoBusiness();
                bunisess.Salvar(dto);

                MessageBox.Show("foi");
                btnalmoçosaida.Enabled = true;
                btnsaida.Enabled = true;
                btnebtrada.Enabled = false;
                btnok.Enabled = false;
            }

            BaterPontoDatabase bpft = new BaterPontoDatabase();
            BaterPontoDTO baterponto = bpft.atualizar();
            acesso.BaterPonto = baterponto;


        }




        private void bater_ponto_Load(object sender, EventArgs e)
        {

        }

        private void btnalmoçosaida_Click(object sender, EventArgs e)
        {
            int idponto = acesso.BaterPonto.Id;

            BaterPontoDTO dto = new BaterPontoDTO();
            dto.Id = Convert.ToInt32(idponto);
            dto.IdaAlmoço = Convert.ToDateTime(lblhora.Text);



            BaterPontoBusiness bunisess = new BaterPontoBusiness();
            bunisess.Primeiro_ponto(dto);

            MessageBox.Show("foi");
            brnalmoçoentrada.Enabled = true;
            btnalmoçosaida.Enabled = false;
        }

        private void btnsaida_Click(object sender, EventArgs e)
        {
            int idponto = acesso.BaterPonto.Id;

            BaterPontoDTO dto = new BaterPontoDTO();
            dto.Id = Convert.ToInt32(idponto);
            dto.VoltaAlmoço = Convert.ToDateTime(lblhora.Text);



            BaterPontoBusiness bunisess = new BaterPontoBusiness();
            bunisess.terceiro_ponto(dto);

            MessageBox.Show("Obrigado pelo dia de trabalho");

            btnsaida.Enabled = false;
       
        }

        private void brnalmoçoentrada_Click(object sender, EventArgs e)
        {
            int idponto = acesso.BaterPonto.Id;

            BaterPontoDTO dto = new BaterPontoDTO();
            dto.Id = Convert.ToInt32(idponto);
            dto.VoltaAlmoço = Convert.ToDateTime(lblhora.Text);



            BaterPontoBusiness bunisess = new BaterPontoBusiness();
            bunisess.segundo_ponto(dto);

            MessageBox.Show("foi");

            brnalmoçoentrada.Enabled = false;
            


        }
    }
}



