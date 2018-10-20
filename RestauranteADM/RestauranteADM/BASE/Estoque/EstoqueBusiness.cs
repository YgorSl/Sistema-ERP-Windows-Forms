﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Estoque
{
    public class EstoqueBusiness
    {
        public void Salvar(List<EstoqueDTO> estoques)
        {
            EstoqueDatabase db = new EstoqueDatabase();

            foreach (EstoqueDTO estoque in estoques)
            {
                db.Salvar(estoque);
            }
        }
        public List<EstoqueDTO> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            List<EstoqueDTO> estoque = db.Listar();

            return estoque;
        }
    }
}
