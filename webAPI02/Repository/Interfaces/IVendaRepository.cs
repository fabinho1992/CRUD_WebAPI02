using webAPI02.Infraestrutura.Dto.VendaDto;

namespace webAPI02.Repository.Interfaces
{
    public interface IVendaRepository
    {
        void AddVenda(CreateVendaDto vendaDto);

        IEnumerable<ReadVendaDto> GetVendedores();

        
    }
}
