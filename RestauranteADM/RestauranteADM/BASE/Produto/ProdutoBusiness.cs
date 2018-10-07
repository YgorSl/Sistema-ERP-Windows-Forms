﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    class ProdutoBusiness
    {

        public void Salvar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Salvar(dto);
        }
        public List<ProdutoDTO> filtro( string Nome)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            List<ProdutoDTO> prod = db.filtro( Nome);
            return prod;
        }
        public void Excluir(int id)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Excluir(id);
        }
        public void Alterar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Alterar(dto);
        }
    }
}
