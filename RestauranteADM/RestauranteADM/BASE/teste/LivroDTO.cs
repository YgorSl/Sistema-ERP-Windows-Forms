using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public int Categoria { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public DateTime lançamento{ get; set; }
        public int codigo { get; set; }
}
}

