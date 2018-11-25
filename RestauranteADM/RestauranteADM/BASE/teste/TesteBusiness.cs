using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
    public class TesteBusiness
    {
       

        public void Update(int Id)
        {
            TesteDatabase database = new TesteDatabase();
            database.Update(Id);

        }
     

        public void Salvar(TesteDTO teste, List<Teste_item_DTO> testeitem)
        {
            TesteDatabase database = new TesteDatabase();
            int pk = database.Salvar(teste);

            Teste_item_Business itens = new Teste_item_Business();

            foreach (Teste_item_DTO item in testeitem)
            {
                item.teste = new TesteDTO();
                item.teste.Id = pk;

                itens.Salvar(item);
            }
        }

    }



}
