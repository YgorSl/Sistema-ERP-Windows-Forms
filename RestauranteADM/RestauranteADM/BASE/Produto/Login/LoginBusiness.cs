using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Login
{
   public class LoginBusiness
    {

        public LoginDTO Login(string login,string senha)
        {

            LoginDatabase db = new LoginDatabase();
            LoginDTO pi = db.Login(login, senha);

            return pi;
        }
    }
}
