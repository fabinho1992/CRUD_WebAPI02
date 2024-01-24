
using AutoMapper;
using webAPI02.Infraestrutura.Dto.ProdutoDto;
using webAPI02.Models;

namespace webAPI02.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produtos>().ReverseMap();
            CreateMap<Produtos, ReadProdutoDto>().ForMember(X => X.VendasItens, opt => opt.MapFrom(x => x.VendaItens));
            CreateMap<Produtos, UpdateProdutoDto>().ReverseMap();
        }
    }
}
