using Microsoft.AspNetCore.JsonPatch;
using webAPI02.Infraestrutura.Dto.ClienteDto;
using webAPI02.Models;

namespace webAPI02.Repository.Interfaces
{
    public interface IClienteRepository
    {
        void AddCliente(CreateClienteDto clienteDto);
        ReadClienteIdDto GetClienteId(int id);
        IEnumerable<ReadClienteDto> GetCliente();
        void UpdateCliente(int id, UpdateClienteDto clienteDto);
        void DeleteCliente(int id);
        void UpdatePath(int id, JsonPatchDocument<UpdateClienteDto> path);

    }
}
