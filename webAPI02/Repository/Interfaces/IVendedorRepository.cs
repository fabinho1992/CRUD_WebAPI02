using webAPI02.Infraestrutura.Dto.VendedorDto;

namespace webAPI02.Repository.Interfaces
{
    public interface IVendedorRepository
    {
        void AddVendedor(CreateVendedorDto vendedorDto);
        void UpdateVendedor(int id, UpdateVendedorDto vendedorDto);
        IEnumerable<ReadVendedorDto> GetVendedor();
        ReadVendedorDto GetVendedorId(int id);
        void DeleteVendedor(int id);
    }
}
