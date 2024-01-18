using AutoMapper;
using webAPI02.Infraestrutura.Dto.VendaDto;
using webAPI02.Models;

namespace webAPI02.Profiles
{
    public class VendaProfile : Profile
    {
        public VendaProfile()
        {
            CreateMap<CreateVendaDto, Venda>();
            CreateMap<Venda, ReadVendaDto>();
        }
    }
}
