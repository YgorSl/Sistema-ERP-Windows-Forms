using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fornecedor
{
    public class FornecedorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone{ get; set; }
        public string Endereço { get; set; }
        public string Cidade{ get; set; }
        public string Estado{ get; set; }


    }
}
