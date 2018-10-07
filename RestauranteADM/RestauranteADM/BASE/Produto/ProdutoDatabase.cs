using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Fornecedor;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class ProdutoDatabase
    {
        public void Salvar(ProdutoDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_compras_produto` (nm_produto, vl_valor, ds_quantidade, id_fornecedor) 
                            VALUES (@nm_produto, @vl_valor, @ds_quantidade, @id_fornecedor)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", dto.Nome));
            parms.Add(new MySqlParameter("vl_valor", dto.Preço));
            parms.Add(new MySqlParameter("ds_quantidade", dto.Quantidade));
            parms.Add(new MySqlParameter("id_fornecedor", dto.Fornecedor.Id));
            



            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
            
        }
        public List<ProdutoDTO> filtro( string Nome)
        {
            string script = @"select *from tb_compras_produto where nm_produto like @nome ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + Nome + "%"));


           

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read() == true)
            {
                ProdutoDTO prod = new ProdutoDTO();
                prod.Id = reader.GetInt32("id_compras");
                prod.Nome = reader.GetString("nm_produto");
                prod.Preço = reader.GetDecimal("vl_valor");
                prod.Quantidade = reader.GetDecimal("ds_quantidade");
                prod.Fornecedor = new FornecedorDTO(); 
                prod.Fornecedor.Id = reader.GetInt32("id_fornecedor");

                lista.Add(prod);
            }
            return lista;
        }
        public void Excluir(int id)
        {
            string script = @" DELETE FROM  `mydb`.`tb_compras_produto` WHERE id_compras = @id_compras 
                            ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compras", id));




            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Alterar(ProdutoDTO dto)
        {
            string script = @" UPDATE  `mydb`.`tb_compras_produto` SET nm_produto = @nm_produto, vl_valor = @vl_valor, ds_quantidade = @ds_quantidade, id_fornecedor = @id_fornecedor WHERE id_compras = @id_compras 
                            ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compras", dto.Id));
            parms.Add(new MySqlParameter("nm_produto", dto.Nome));
            parms.Add(new MySqlParameter("vl_valor", dto.Preço));
            parms.Add(new MySqlParameter("ds_quantidade", dto.Quantidade));
            parms.Add(new MySqlParameter("id_fornecedor", dto.Fornecedor.Id));




            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
