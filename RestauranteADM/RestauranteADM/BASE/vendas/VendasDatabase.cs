using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
   public class VendasDatabase
    {

        public int Salvar(VendasDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_venda_prato` (id_venda_prato, id_cardapio, data_venda, id_cliente) VALUES (@id_venda_prato,@id_cardapio,@data_venda,@id_cliente)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_venda_prator", dto.Id));
            parms.Add(new MySqlParameter("id_cardapio", dto.cardapio.Id));
            parms.Add(new MySqlParameter("data_venda", dto.Data));
            parms.Add(new MySqlParameter("id_cliente", dto.cliente.Id));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
    }
}
