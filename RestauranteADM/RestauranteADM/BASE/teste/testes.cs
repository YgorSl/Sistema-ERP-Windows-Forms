using RestauranteADM.BASE.teste;
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
    public partial class testes : Form
    {
        public testes()
        {
            InitializeComponent();
            dgvbibli.AutoGenerateColumns = false;
            carregarcombo();

        }
        public LivroDTO dto { get; set; }
        public int Qtd { get; set; }

        public void carregarcombo()
        {

            Livrobusiness ok = new Livrobusiness();
            List<LivroDTO> com = ok.Lista();

            cbmLivro.DataSource = com;
            cbmLivro.DisplayMember = "nome";
            cbmLivro.ValueMember = "Id";

        }







        private void testes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LivroDTO livro = cbmLivro.SelectedItem as LivroDTO;



            this.dto = livro;

            int qtd = 1;

            this.Qtd = qtd;

            if (dto != null)
            {
                List<LivroDTO> prods = dgvbibli.DataSource as List<LivroDTO>;
                if (prods == null)
                    prods = new List<LivroDTO>();


                for (int i = 0; i < Qtd; i++)
                {
                    prods.Add(dto);
                }
                dgvbibli.DataSource = null;
                dgvbibli.DataSource = prods;

            }

        }

        private void dgvbibli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            foreach (DataGridViewRow row in dgvbibli.Rows)
            {
                TesteDTO dto = row.DataBoundItem as TesteDTO;
                int id = dto.Id;
                 
                TesteDatabase database = new TesteDatabase();
                database.Update(id);
               
               

            }
        }

        private void cbmLivro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TesteDTO teste = new TesteDTO();
            teste.emprestimo = dtp1.Value;
            teste.vencimento = dtp2.Value;
            teste.Id_aluno = Convert.ToInt32(textBox1.Text);

            List<LivroDTO> itens = dgvbibli.DataSource as List<LivroDTO>;
            List<Teste_item_DTO> item = new List<Teste_item_DTO>();

            foreach (LivroDTO ite in itens)
            {
                Teste_item_DTO itemvenda = new Teste_item_DTO();
                itemvenda.livro= ite;

                item.Add(itemvenda);
            }
            TesteBusiness bus = new TesteBusiness();
            bus.Salvar(teste, item);
        }

     

            
    }
}