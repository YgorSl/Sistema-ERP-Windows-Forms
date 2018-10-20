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
            string script = @"INSERT INTO `tb_compra_item` (id_compra, id_compra_produto) 
                            VALUES (@id_compra, @id_compra_produto)"
;
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.Compra.Id));
            parms.Add(new MySqlParameter("id_compra_produto", dto.Produto.Id));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<CompraItemDTO> Filtro (int CompraId)
        {
            {
                string script = @"select *from tb_compra_item where id_compra= @id_compra ";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_compra", CompraId));

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

                List<CompraItemDTO> lista = new List<CompraItemDTO>();
                while (reader.Read() == true)
                {
                    CompraItemDTO comp = new CompraItemDTO();
                    comp.Id = reader.GetInt32("id_compra_item");

                    comp.Compra = new CompraDTO();
                    comp.Compra.Id = reader.GetInt32("Id_compra");

                    comp.Produto = new ProdutoDTO();
                    comp.Produto.Id = reader.GetInt32("id_compra_produto");

                    lista.Add(comp);
                }
                return lista;
            }

        }

    }
}
