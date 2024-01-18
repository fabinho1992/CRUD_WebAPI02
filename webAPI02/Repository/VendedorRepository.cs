using AutoMapper;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.VendedorDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Repository
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly DbContextControle _context;
        private readonly IMapper _mapper;

        public VendedorRepository(DbContextControle context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddVendedor(CreateVendedorDto vendedorDto)
        {
            var cliente = _mapper.Map<Vendedor>(vendedorDto);
            _context.Vendedores.Add(cliente);
            _context.SaveChanges();
        }

        public void DeleteVendedor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReadVendedorDto> GetVendedor()
        {
            var clientes = _mapper.Map<List<ReadVendedorDto>>(_context.Vendedores.ToList());
            return clientes;
        }

        public ReadVendedorDto GetVendedorId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVendedor(int id, UpdateVendedorDto vendedorDto)
        {
            throw new NotImplementedException();
        }
    }
}
