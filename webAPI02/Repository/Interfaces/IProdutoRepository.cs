﻿using webAPI02.Infraestrutura.Dto.ProdutoDto;
using webAPI02.Models;

namespace webAPI02.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        void AddProduto(Produtos produto);
        IEnumerable<ReadProdutoDto> GetProdutos();
        ReadProdutoIdDto GetProdutosId(int id);
        void UpdateProdutos(int id, UpdateProdutoDto produtos);
        void DeleteProdutos(int id);
    }
}
