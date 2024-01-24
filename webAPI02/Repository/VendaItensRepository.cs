using AutoMapper;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.VendaItensDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Repository
{
    public class VendaItensRepository : IVendaItensRepository
    {
        private readonly DbContextControle _context;
        private readonly IMapper _mapper;
        public VendaItensRepository(DbContextControle context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddVendaItens(CreateVendaItensDto vendaItensDto)
        {
            var venda = _mapper.Map<VendaItens>(vendaItensDto);
            _context.VendaItens.Add(venda);
            _context.SaveChanges();
            
        }

        public IEnumerable<ReadVendaItensDto> GetVendaItensDtos()
        {
            var vendas = _mapper.Map<List<ReadVendaItensDto>>(_context.VendaItens.ToList());
            return vendas;
        }

        public ReadVendaItensDto GetVendaItensId(int id)
        {
            var venda = _context.VendaItens.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ReadVendaItensDto>(venda);
        }

        
    }
}
