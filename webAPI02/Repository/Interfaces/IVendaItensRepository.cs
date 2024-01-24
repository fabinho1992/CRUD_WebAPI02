using webAPI02.Infraestrutura.Dto.VendaItensDto;
using webAPI02.Models;

namespace webAPI02.Repository.Interfaces
{
    public interface IVendaItensRepository
    {
        void AddVendaItens(CreateVendaItensDto vendaItensDto );
        IEnumerable<ReadVendaItensDto> GetVendaItensDtos();
        ReadVendaItensDto GetVendaItensId(int id);
    }
}
