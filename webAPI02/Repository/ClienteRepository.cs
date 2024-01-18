using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.ClienteDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContextControle _context;
        private readonly IMapper _mapper;

        public ClienteRepository(DbContextControle context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void AddCliente(CreateClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void DeleteCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public IEnumerable<ReadClienteDto> GetCliente()
        {
            var clientes = _mapper.Map<List<ReadClienteDto>>(_context.Clientes.Include(x => x.Vendas).ToList());
            return clientes;
        }

        public Cliente GetClienteId(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault( c => c.Id == id);
            _mapper.Map<ReadClienteDto>(cliente);
            return cliente;
        }

        public void UpdateCliente(int id, CreateClienteDto clienteDto)
        {
            
        }
    }
}
