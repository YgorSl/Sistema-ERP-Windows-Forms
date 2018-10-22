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
        public List<Estoque_View> Lista()
        {
            string script = @"select *from estoquevw";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<Estoque_View> lista = new List<Estoque_View>();
            while (reader.Read() == true)
            {
                Estoque_View comp = new Estoque_View();
                comp.Id = reader.GetInt32("id_estoque");               
                comp.IdCompra = reader.GetInt32("id_compra_produto");              
                comp.IdCompraItem = reader.GetInt32("id_compra_item");
                comp.IdProduto = reader.GetInt32("id_compras");
                comp.Preço = reader.GetInt32("vl_valor");
                comp.Produto = reader.GetString("nm_produto");
                comp.Fornecedor = reader.GetString("nm_fornecedor");

                lista.Add(comp);
            }
            return lista;
        }
        public void Excluir(int id)
        {
            string script = @" DELETE FROM  `mydb`.`tb_estoque` WHERE id_estoque = @id_estoque
                            ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estoque", id));




            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
