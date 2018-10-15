using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Cliente
{
    public class ClienteDatabase
    {
        public int Salvar(ClienteDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_cliente` (nm_nome,ds_cpf, ds_telefone, ds_cep, ds_bairro,ds_numero_casa, ds_tipo_pessoa, ds_cnpj, ds_anotaçao_cliente, ds_data_hoje) 
                                                       VALUES (@nm_nome,@ds_cpf,@ds_telefone,@ds_cep,@ds_bairro,@ds_numero_casa,@ds_tipo_pessoa,@ds_cnpj,@ds_anotaçao_cliente,@ds_data_hoje);";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_numero_casa", dto.NumeroCasa));
            parms.Add(new MySqlParameter("ds_tipo_pessoa", dto.Tipopessoa));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("ds_anotaçao_cliente", dto.anotaçao_cliente));
            parms.Add(new MySqlParameter("ds_data_hoje", dto.data_hoje));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }




        public void Update(ClienteDTO dto)
        {
            string script = @"UPDATE tb_cliente SET nm_nome=@nm_nome ,ds_cpf=@ds_cpf, ds_telefone=@ds_telefone, ds_cep=@ds_cep, ds_bairro=@ds_bairro,ds_numero_casa=@ds_numero_casa, ds_tipo_pessoa=@ds_tipo_pessoa, ds_cnpj=@ds_cnpj, ds_anotaçao_cliente=@ds_anotaçao_cliente, ds_data_hoje=@ds_data_hoje   where id_cliente=@id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", dto.Id));
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_numero_casa", dto.NumeroCasa));
            parms.Add(new MySqlParameter("ds_tipo_pessoa", dto.Tipopessoa));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("ds_anotaçao_cliente", dto.anotaçao_cliente));
            parms.Add(new MySqlParameter("ds_data_hoje", dto.data_hoje));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<ClienteDTO> Consultar(string nome,string cpf)
        {
            

            string script = @"select *from tb_cliente where nm_nome like @nome and ds_cpf like @cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + nome + "%"));
            parms.Add(new MySqlParameter("cpf", "%" + cpf + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_nome");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.NumeroCasa = reader.GetString("ds_numero_casa");

 
                dto.Tipopessoa = reader.GetString("ds_tipo_pessoa");
                dto.Cnpj = reader.GetString("ds_cnpj");
                dto.anotaçao_cliente = reader.GetString("ds_anotaçao_cliente");
                dto.data_hoje = reader.GetDateTime("ds_data_hoje");

                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }
        public List<ClienteDTO> listar()
        {


            string script = @"select *from tb_cliente " ;

    


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_nome");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.NumeroCasa = reader.GetString("ds_numero_casa");
                dto.Tipopessoa = reader.GetString("ds_tipo_pessoa");
                dto.Cnpj = reader.GetString("ds_cnpj");
                dto.anotaçao_cliente = reader.GetString("ds_anotaçao_cliente");
                dto.data_hoje = reader.GetDateTime("ds_data_hoje");

                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }

    }

}
