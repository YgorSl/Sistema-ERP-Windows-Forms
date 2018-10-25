using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
   public  class LoginDatabase
    {
        public void Alteraçao(LoginDTO dto)
        {
            string script = @" UPDATE Login SET Login =@nm_login,Senha=@ds_senha where id=@id";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", dto.id));
            parms.Add(new MySqlParameter("nm_login", dto.Login));
            parms.Add(new MySqlParameter("ds_senha", dto.senhar));
        
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}
