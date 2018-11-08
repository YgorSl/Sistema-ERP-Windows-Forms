using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fornecedor
{
    class FornecedorDatabase
    {
        public int Salvar(FornecedorDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_fornecedor` (nm_nome, ds_cnpj, ds_telefone, ds_endereço, ds_cidade, ds_estado, ds_bairro, ds_cep) 
                                                         VALUES (@nm_nome, @ds_cnpj, @ds_telefone, @ds_endereço, @ds_cidade, @ds_estado, @ds_bairro, @ds_cep)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_endereço", dto.Endereço));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("ds_estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }



        public List<FornecedorDTO> filtro(string Nome, string Cnpj)
        {
            string script = @"select *from tb_fornecedor where nm_nome like @nome and ds_cnpj like @cnpj  ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + Nome + "%"));
            parms.Add(new MySqlParameter("cnpj", "%" + Cnpj + "%"));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read() == true)
            {

                FornecedorDTO funcio = new FornecedorDTO();
                funcio.Id = reader.GetInt32("id_fornecedor");
                funcio.Nome = reader.GetString("nm_nome");
                funcio.Cnpj = reader.GetString("ds_cnpj");
                funcio.Telefone = reader.GetString("ds_telefone");
                funcio.Endereço = reader.GetString("ds_endereço");
                funcio.Cidade = reader.GetString("ds_cidade");
                funcio.Estado = reader.GetString("ds_estado");
                funcio.Bairro = reader.GetString("ds_bairro");
                funcio.CEP = reader.GetString("ds_cep");


                lista.Add(funcio);

            }
            return lista;
        }

        public void Excluir(int id)
        {
            string script = @"DELETE FROM  tb_fornecedor WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alterar(FornecedorDTO dto)
        {
            string script = @"UPDATE 


  tb_fornecedor SET nm_nome = @nm_nome, ds_cnpj = @ds_cnpj, ds_telefone = @ds_telefone, ds_endereço =@ds_endereço , ds_cidade = @ds_cidade , ds_estado = @ds_estado
                            

                              WHERE id_fornecedor= @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.Id));
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_endereço", dto.Endereço));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("ds_estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));



            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
        public List<FornecedorDTO> Listar()
        {
            string script = @"select *from tb_fornecedor ";




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read() == true)
            {

                FornecedorDTO funcio = new FornecedorDTO();
                funcio.Id = reader.GetInt32("id_fornecedor");
                funcio.Nome = reader.GetString("nm_nome");
                funcio.Cnpj = reader.GetString("ds_cnpj");
                funcio.Telefone = reader.GetString("ds_telefone");
                funcio.Endereço = reader.GetString("ds_endereço");
                funcio.Cidade = reader.GetString("ds_cidade");
                funcio.Estado = reader.GetString("ds_estado");
                funcio.Bairro = reader.GetString("ds_bairro");
                funcio.CEP = reader.GetString("ds_cep");

                lista.Add(funcio);

            }
            return lista;
        }
        public int Salvar1(ProvedorDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_prestador` (nm_nome, ds_cnpj, ds_telefone, ds_endereço, ds_cidade, ds_estado, ds_bairro, ds_cep) 
                                                         VALUES (@nm_nome, @ds_cnpj, @ds_telefone, @ds_endereço, @ds_cidade, @ds_estado, @ds_bairro, @ds_cep)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_endereço", dto.Endereço));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("ds_estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }



        public List<ProvedorDTO> filtro1(string Nome, string Cnpj)
        {
            string script = @"select *from tb_prestador where nm_nome like @nome and ds_cnpj like @cnpj";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + Nome + "%"));
            parms.Add(new MySqlParameter("cnpj", "%" + Cnpj + "%"));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProvedorDTO> lista = new List<ProvedorDTO>();
            while (reader.Read() == true)
            {

                ProvedorDTO funcio = new ProvedorDTO();
                funcio.Id = reader.GetInt32("id_prestador");
                funcio.Nome = reader.GetString("nm_nome");
                funcio.Cnpj = reader.GetString("ds_cnpj");
                funcio.Telefone = reader.GetString("ds_telefone");
                funcio.Endereço = reader.GetString("ds_endereço");
                funcio.Cidade = reader.GetString("ds_cidade");
                funcio.Estado = reader.GetString("ds_estado");
                funcio.Bairro = reader.GetString("ds_bairro");
                funcio.CEP = reader.GetString("ds_cep");


                lista.Add(funcio);

            }
            return lista;
        }

        public void Excluir1(int id)
        {
            string script = @"DELETE FROM  tb_prestador WHERE id_prestador = @id_prestador";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_prestador", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alterar1(ProvedorDTO dto)
        {
            string script = @"UPDATE 


  tb_prestador SET nm_nome = @nm_nome, ds_cnpj = @ds_cnpj, ds_telefone = @ds_telefone, ds_endereço =@ds_endereço , ds_cidade = @ds_cidade , ds_estado = @ds_estado
                            

                              WHERE id_prestador= @id_prestador";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_prestador", dto.Id));
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_endereço", dto.Endereço));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("ds_estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));



            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<ProvedorDTO> Consultar()
        {
            string script = @"select *from tb_prestador";





            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProvedorDTO> lista = new List<ProvedorDTO>();
            while (reader.Read() == true)
            {

                ProvedorDTO funcio = new ProvedorDTO();
                funcio.Id = reader.GetInt32("id_prestador");
                funcio.Nome = reader.GetString("nm_nome");
                funcio.Cnpj = reader.GetString("ds_cnpj");
                funcio.Telefone = reader.GetString("ds_telefone");
                funcio.Endereço = reader.GetString("ds_endereço");
                funcio.Cidade = reader.GetString("ds_cidade");
                funcio.Estado = reader.GetString("ds_estado");
                funcio.Bairro = reader.GetString("ds_bairro");
                funcio.CEP = reader.GetString("ds_cep");


                lista.Add(funcio);

            }
            return lista;
        }

    }
}
