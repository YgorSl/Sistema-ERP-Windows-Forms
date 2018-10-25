using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
    public class LoginDTO
    {


        public int id { get; set; }

        public string Login {get;set;}

        public string senhar { get; set; }
    }
}
