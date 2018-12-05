using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
    public class Teste_item_Business
    {
        public void Salvar(Teste_item_DTO dro)
        {
            Teste_item_Database database = new Teste_item_Database();
             database.Salvar(dro);
           

        }
    }
}
