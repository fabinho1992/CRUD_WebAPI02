using AutoMapper;
using Microsoft.EntityFrameworkCore;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.VendaDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly DbContextControle _context;
        private readonly IMapper _mapper;

        public VendaRepository(IMapper mapper, DbContextControle context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void AddVenda(CreateVendaDto vendaDto)
        {
            var cliente = _mapper.Map<Venda>(vendaDto);
            _context.Vendas.Add(cliente);
            _context.SaveChanges();
        }

       

        public IEnumerable<ReadVendaDto> GetVendedores()
        {
            
            var vendedores = _mapper.Map<List<ReadVendaDto>>(_context.Vendas.Include(x => x.Cliente). ToList());
            return vendedores;
        }
    }
}
