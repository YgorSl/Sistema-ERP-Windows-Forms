using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Estoque;
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

        public List<Estoque_View> Filtro (int CompraId)
        {
            {
                string script = @"select *from estoquevw where id_compra= @id_compra ";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_compra", CompraId));

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

                List<Estoque_View> lista = new List<Estoque_View>();
                while (reader.Read() == true)
                {
                    Estoque_View comp = new Estoque_View();
                    comp.Id = reader.GetInt32("id_estoque");
                    comp.IdCompra = reader.GetInt32("id_compra");
                    comp.IdCompraItem = reader.GetInt32("id_compra_item");
                    comp.IdProduto = reader.GetInt32("id_compras");
                    comp.Preço = reader.GetInt32("vl_valor");
                    comp.Produto = reader.GetString("nm_produto");
                    comp.Fornecedor = reader.GetString("nm_fornecedor");
    

                        lista.Add(comp);
                }
                return lista;
            }

        }

    }
}
