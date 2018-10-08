using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Cliente
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string NumeroCasa { get; set; }
        public string Tipopessoa { get; set; }
        public string Cnpj { get; set; }
        public string anotaçao_cliente { get; set; }
        public DateTime data_hoje { get; set; }





    }
}
