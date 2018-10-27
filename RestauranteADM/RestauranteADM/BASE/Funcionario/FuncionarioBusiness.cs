using RestauranteADM.BASE.Login;
using RestauranteADM.BASE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Funcionario
{
    public class FuncionarioBusiness
    {
        public List<FuncionarioDTO> filtro(string Nome,string cpf)
        {
            FuncionarioDatabse db = new FuncionarioDatabse();
            List<FuncionarioDTO> tb = db.filtro(Nome,cpf);

            return tb;
        }
        public void Remover(int idusuario)
        {
           FuncionarioDatabse usuarioDB = new FuncionarioDatabse();
            usuarioDB.Excluir(idusuario);
        }
        public void Update(FuncionarioDTO funcio,UsuarioDTO acesso)
        {
            FuncionarioDatabse usuarioDB = new FuncionarioDatabse();
            usuarioDB.Update(funcio);

            UsuarioBusiness o = new UsuarioBusiness();
            o.Update(acesso);

        }
        public List<FuncionarioDTO> Listar()
        {
            FuncionarioDatabse db = new FuncionarioDatabse();
            List<FuncionarioDTO> tb = db.Listar();

            return tb;
        }






        public void Salvar(FuncionarioDTO funcio, UsuarioDTO usua)
        {
            FuncionarioDatabse foi = new FuncionarioDatabse();
            int pk=foi.Salvar(funcio);


            usua.usuario = new FuncionarioDTO();
            usua.usuario.Id = pk;

            UsuarioBusiness i= new UsuarioBusiness();
            i.save(usua);

        }
       


    }
}
