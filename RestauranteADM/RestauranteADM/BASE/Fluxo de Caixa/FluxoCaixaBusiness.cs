using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fluxo_de_Caixa
{
   public class FluxoCaixaBusiness
    {

        public int Salvar(FluxoCaixaDTO dto)
        {
            FluxoCaixaDatabase dados = new FluxoCaixaDatabase();
            int pk=dados.Salvar(dto);
            return pk;


        }
    }
}
