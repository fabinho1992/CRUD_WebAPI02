using AutoMapper;
using webAPI02.Infraestrutura.Dto.VendaItensDto;
using webAPI02.Models;

namespace webAPI02.Profiles
{
    public class VendaItensProfile : Profile
    {
        public VendaItensProfile()
        {
            CreateMap<CreateVendaItensDto, VendaItens>();
            CreateMap<VendaItens, ReadVendaItensDto>();
        }
    }
}
