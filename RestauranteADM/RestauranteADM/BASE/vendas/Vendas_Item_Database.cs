using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class Vendas_Item_Database
    {

        public void Salvar(vendas_item_DTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_venda_item` ( id_cardapio,id_venda) VALUES (@id_cardapio,@id_venda)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cardapio", dto.cardapio.Id));
            parms.Add(new MySqlParameter("id_venda", dto.vendas.Id));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
           
        }
    }
}
