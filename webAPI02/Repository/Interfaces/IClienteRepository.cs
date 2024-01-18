using webAPI02.Infraestrutura.Dto.ClienteDto;
using webAPI02.Models;

namespace webAPI02.Repository.Interfaces
{
    public interface IClienteRepository
    {
        void AddCliente(CreateClienteDto clienteDto);
        Cliente GetClienteId(int id);
        IEnumerable<ReadClienteDto> GetCliente();
        void UpdateCliente(int id, CreateClienteDto clienteDto);
        void DeleteCliente(int id);

    }
}
