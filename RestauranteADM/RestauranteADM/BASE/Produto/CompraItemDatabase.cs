using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class CompraItemDatabase
    {
        public void Salvar(CompraItemDTO dto)
        {
            string script = @"INSERT INTO `tb_compra` (id_compra, id_compra_produto) 
                            VALUES (@id_compra, @id_compra_produto)"
;
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.Compra.Id));
            parms.Add(new MySqlParameter("id_compra_produto", dto.Produto.Id));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}
