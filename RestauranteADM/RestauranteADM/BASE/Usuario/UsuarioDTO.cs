using RestauranteADM.BASE.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string Observacao { get; set; }
        public int IdFuncionario { get; set; }
        public bool permissaototal { get; set; }
        public bool permissaoRH { get; set; }
        public bool permissaofinanceiro { get; set; }
        public bool permissaovendas { get; set; }
        public bool permissaocompras { get; set; }
        public bool permissaocadastro { get; set; }



        public FuncionarioDTO usuario { get; set; }


}
  
}
