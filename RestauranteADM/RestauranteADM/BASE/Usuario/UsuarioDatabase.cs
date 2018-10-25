using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
    public class UsuarioDatabase
    {
        public int Salvar(UsuarioDTO dto)
        {
            string script = @"INSERT INTO tb_permissao ( nm_login, ds_senha , perm_total , perm_cadastro ,perm_vendas, perm_compras, perm_rh, perm_financeiro) 
                                  VALUES ( @nm_login, @ds_senha , @perm_total , @perm_cadastro ,@perm_vendas, @perm_compras, @perm_rh, @perm_financeiro)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        internal UsuarioDatabase logar(string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioDTO dto)
        {
            string script = @"UPDATE tb_permissao SET nm_login =@nm_login,ds_senha=@ds_senha, id_funcionario = @id_funcionario ,perm_total=@perm_total,perm_cadastro=@perm_cadastro,perm_vendas=@perm_vendas,perm_compras=@perm_compras,perm_rh=@perm_rh,perm_financeiro=@perm_financeiro WHERE id_permissao = @id_permissao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_permissao", dto.Id));
            parms.Add(new MySqlParameter("id_funcionario", dto.usuario.Id));
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_permissao WHERE id_usuario = @id_usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_usuario", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<UsuarioDTO> Consultar(string usuario)
        {
            string script = @"SELECT * FROM usuario WHERE nm_nome like @nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", usuario + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.login = reader.GetString("nm_login");
                dto.senha = reader.GetString("ds_senha");
                dto.permissaototal = reader.GetBoolean("perm_total");
                dto.permissaocadastro = reader.GetBoolean("perm_cadastro");
                dto.permissaovendas = reader.GetBoolean("perm_vendas");
                dto.permissaocompras = reader.GetBoolean("perm_compras");
                dto.permissaoRH = reader.GetBoolean("perm_rh");
                dto.permissaofinanceiro = reader.GetBoolean("perm_financeiro");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
        public List<UsuarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_permissao";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.login = reader.GetString("nm_login");
                dto.senha = reader.GetString("ds_senha");
                dto.permissaototal = reader.GetBoolean("perm_total");
                dto.permissaocadastro = reader.GetBoolean("perm_cadastro");
                dto.permissaovendas = reader.GetBoolean("perm_vendas");
                dto.permissaocompras = reader.GetBoolean("perm_compras");
                dto.permissaoRH = reader.GetBoolean("perm_rh");
                dto.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
            }
            reader.Close();

            return lista;
        }





        public UsuarioDTO Logar(string login, string senha)
        {

            string script =
                @"select * from tb_permissao where nm_login = @nm_login and ds_senha = @ds_senha";



            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("nm_login", login));
            parametros.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parametros);

            UsuarioDTO dt = null;

            if (reader.Read() == true)
            {

                dt = new UsuarioDTO();
                dt.login = reader.GetString("nm_login");
                dt.senha = reader.GetString("ds_senha");
                dt.permissaototal = reader.GetBoolean("perm_total");
                dt.permissaocadastro = reader.GetBoolean("perm_cadastro");
                dt.permissaovendas = reader.GetBoolean("perm_vendas");
                dt.permissaocompras = reader.GetBoolean("perm_compras");
                dt.permissaoRH = reader.GetBoolean("perm_rh");
                dt.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
            }
            reader.Close();
            return dt;
        }

        public void Salvor(UsuarioDTO dto)
        {
            string script = @"INSERT INTO tb_permissao ( nm_login, ds_senha ,id_funcionario, perm_total , perm_cadastro ,perm_vendas, perm_compras, perm_rh, perm_financeiro) 
                                  VALUES ( @nm_login, @ds_senha ,@id_funcionario, @perm_total , @perm_cadastro ,@perm_vendas, @perm_compras, @perm_rh, @perm_financeiro)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("id_funcionario", dto.usuario.Id));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alteraçao(UsuarioDTO dto)
        {
            string script = @"UPDATE tb_permissao SET nm_login =@nm_login,ds_senha=@ds_senha, id_funcionario = @id_funcionario ,perm_total=@perm_total,perm_cadastro=@perm_cadastro,perm_vendas=@perm_vendas,perm_compras=@perm_compras,perm_rh=@perm_rh,perm_financeiro=@perm_financeiro WHERE id_permissao = @id_permissao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_permissao", dto.Id));
            parms.Add(new MySqlParameter("id_funcionario", dto.usuario.Id));
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}

    






    

