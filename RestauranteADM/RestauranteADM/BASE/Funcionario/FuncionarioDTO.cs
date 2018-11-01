using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADM.BASE.Login;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.BASE.Folha_de_Pagamento;

namespace RestauranteADM.BASE.Funcionario
{
    public class FuncionarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereço { get; set; }
        public double Salario { get; set; }
        public string Gmail { get; set; }
        public string senha_recuperaçao { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string N_local { get; set; }

        public UsuarioDTO eui { get; set; }

        public FolhaPagamentoDTO fpama { get; set; }

    }
}
