﻿using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.ProdutoDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Repository
{
    public class ProdutosRepository : IProdutoRepository
    {
        private readonly DbContextControle _context;
        private readonly IMapper _mapper;

        public ProdutosRepository(DbContextControle context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddProduto(Produtos produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void DeleteProdutos(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public IEnumerable<ReadProdutoDto> GetProdutos()
        {
            var produtos = _mapper.Map<List<ReadProdutoDto>>( _context.Produtos.Include(x => x.VendaItens).ToList());
            return produtos;
        }

        public ReadProdutoIdDto GetProdutosId(int id)
        {
            var produto = _context.Produtos. FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ReadProdutoIdDto>(produto);
        }

        public void UpdateProdutos(int id, UpdateProdutoDto produtoDto)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            _mapper.Map(produtoDto, produto);
            _context.SaveChanges();
            
        }
    }
}
