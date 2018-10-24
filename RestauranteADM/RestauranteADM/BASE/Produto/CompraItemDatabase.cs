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

        public List<VerView> Filtro(string forn)
        {

            string script = @"select * from estoqueavw where nm_produto like @produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("produto", "%" + forn + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VerView> lista = new List<VerView>();
            while (reader.Read() == true)
            {
                VerView comp = new VerView();
                comp.IdCompra = reader.GetInt32("id_compra");
                comp.IdCompraItem = reader.GetInt32("id_compra_item");
                comp.Produto = reader.GetString("nm_produto");
                comp.Preço = reader.GetInt32("vl_valor");
                comp.Fornecedor = reader.GetString("nm_nome");

                lista.Add(comp);
            }
            return lista;
        }
            public List<CompraItemDTO> Filtro1(int compraid)
            {

                string script = @"select * from tb_compra_item where id_compra = @id_compra";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_compra", compraid));

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

                List<CompraItemDTO> lista = new List<CompraItemDTO>();
                while (reader.Read() == true)
                {
                    CompraItemDTO comp = new CompraItemDTO();
                    comp.Id = reader.GetInt32("id_compra_item");

                    comp.Compra = new CompraDTO();
                    comp.Compra.Id = reader.GetInt32("id_compra");

                    comp.Produto = new ProdutoDTO();
                    comp.Produto.Id = reader.GetString("nm_produto");

                    lista.Add(comp);
                }
                return lista;


            }
        }
    }
}
