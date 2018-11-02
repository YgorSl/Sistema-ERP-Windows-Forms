using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.BASE.Funcionario;

namespace RestauranteADM.Acesso
{
     public class acesso
    {
        public static UsuarioDTO usuariologado { get; set; }

        public static FuncionarioDTO  funcionariologado { get; set; }

    }
}
