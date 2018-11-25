using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
   public  class TesteDTO
    {
       public int Id { get; set; }
        public int Id_aluno { get; set; }

      
        public DateTime emprestimo { get; set; }
        public DateTime vencimento { get; set; }

        public string nome { get; set; }
        public bool Estar_emuso { get; set; }
    }
}
