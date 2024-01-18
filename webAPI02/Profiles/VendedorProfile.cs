using AutoMapper;
using webAPI02.Infraestrutura.Dto.VendedorDto;
using webAPI02.Models;

namespace webAPI02.Profiles
{
    public class VendedorProfile : Profile
    {
        public VendedorProfile()
        {
            CreateMap<CreateVendedorDto, Vendedor>();
            CreateMap<Vendedor, ReadVendedorDto>();
        }
    }
}
