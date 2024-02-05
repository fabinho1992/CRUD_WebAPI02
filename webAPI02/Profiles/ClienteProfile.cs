using AutoMapper;
using webAPI02.Infraestrutura.Dto.ClienteDto;
using webAPI02.Models;

namespace webAPI02.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<Cliente, ReadClienteIdDto>();
            CreateMap<UpdateClienteDto, Cliente>().ReverseMap();
        }
    }
}
