using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Produto;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Estoque
{
    public class EstoqueDatabase
    {
        public void Salvar(EstoqueDTO dto)
        {
            string script = @"INSERT INTO `tb_estoque` (id_compras_produto, id_compra_item) 
                            VALUES (@id_compras_produto, @id_compra_item)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compras_produto", dto.Produto.Id));
            parms.Add(new MySqlParameter("dt_compra", dto.CompraItem.Id));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
           
        }
        public List<EstoqueDTO> Listar()
        {
            string script = @"select *from tb_estoque";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read() == true)
            {
                EstoqueDTO comp = new EstoqueDTO();
                comp.Id = reader.GetInt32("id_estoque");

                comp.Produto = new ProdutoDTO();
                comp.Produto.Id = reader.GetInt32("id_compra_produto");

                comp.CompraItem = new CompraItemDTO();
                comp.CompraItem.Id = reader.GetInt32("id_compra_item");

                lista.Add(comp);
            }
            return lista;
        }

    }
}
