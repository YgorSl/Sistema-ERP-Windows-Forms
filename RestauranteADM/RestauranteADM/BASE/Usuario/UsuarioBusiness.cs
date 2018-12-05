using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.BASE.Funcionario;
using RestauranteADM.BASE.Login;

namespace RestauranteADM.BASE.Usuario
{
    public class UsuarioBusiness
    {
        public int Salvar(UsuarioDTO dto)
        {
            if (dto.login == string.Empty)
            {
                throw new Exception("Insira o login do usuário  por favor.");
            }
            if (dto.senha == string.Empty)
            {
                throw new Exception("Insira a senha do usuário por favor.");
            }

            UsuarioDatabase usuarioDB = new UsuarioDatabase();
            int id = usuarioDB.Salvar(dto);
            return id;
        }

        public void save(UsuarioDTO i)
        {
        UsuarioDatabase bd = new UsuarioDatabase();
        bd.Salvar(i);
        }

    public List<UsuarioDTO> Listar()
        {
            UsuarioDatabase usuarioDB = new UsuarioDatabase();
            List<UsuarioDTO> usuarios = usuarioDB.Listar();
            return usuarios;
        }

        public void Update(UsuarioDTO usuario)
        {
            UsuarioDatabase usuarioDB = new UsuarioDatabase();
            usuarioDB.Update(usuario);
        }

        public void Remover(int idusuario)
        {
            UsuarioDatabase usuarioDB = new UsuarioDatabase();
            usuarioDB.Remover(idusuario);
        }

        public UsuarioDTO Logar(string login, string senha)
        {
            
                if (login == string.Empty)
                {
                    throw new ArgumentException("Usuário é obrigatório");

                }
                if (senha == string.Empty)
                {
                    throw new ArgumentException("Senha é obrigatóriac");

                }

     
          
            UsuarioDatabase db = new UsuarioDatabase();
            return db.Logar(login, senha);


        }

        public void Update(FuncionarioDTO dto,UsuarioDTO usuario)
        {
            FuncionarioDatabse oi = new FuncionarioDatabse();
            oi.Salvar(dto);

            UsuarioBusiness tiu = new UsuarioBusiness();
            tiu.Salvar(usuario);



        }
        public void update(UsuarioDTO usuario)
        {
            UsuarioDatabase oi = new UsuarioDatabase();
            oi.Update(usuario);


        }


    }

    
}


