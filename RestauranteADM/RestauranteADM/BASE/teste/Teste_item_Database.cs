using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
   public class Teste_item_Database
    {
        public void Salvar(Teste_item_DTO dto)
        {
            string script = @"INSERT INTO `tb_biblioteca`.`tb_emprestimo_item` (id_livro,id_emprestimo) VALUES (@id_livro,@id_emprestimo)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_livro", dto.livro.Id));
            parms.Add(new MySqlParameter("id_emprestimo", dto.teste.Id));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}
