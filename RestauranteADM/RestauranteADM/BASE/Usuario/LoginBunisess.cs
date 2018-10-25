using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
   public class LoginBunisess
    {

        public void Alterar(LoginDTO dto)
        {
            LoginDatabase login = new LoginDatabase();
            login.Alteraçao(dto);
        
        }
    }
}
