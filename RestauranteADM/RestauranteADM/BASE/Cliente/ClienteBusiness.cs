using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Cliente
{
    public class ClienteBusiness
    {
        public List<ClienteDTO> filtro(string nome ,string cpf)
        {
            ClienteDatabase db = new ClienteDatabase();
            List<ClienteDTO> tb = db.Consultar(nome,cpf);

            return tb;
        }




        public void Remover(int idcliente)
        {
            ClienteDatabase usuarioDB = new ClienteDatabase();
            usuarioDB.Remover(idcliente);
        }
        public void Update(ClienteDTO funcio)
        {
            ClienteDatabase usuarioDB = new ClienteDatabase();
            usuarioDB.Update(funcio);
        }







        public void Salvar(ClienteDTO funcio)
        {
            ClienteDatabase foi = new ClienteDatabase();
            int pk = foi.Salvar(funcio);

        }

    }
}
