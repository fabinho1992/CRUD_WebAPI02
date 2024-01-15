
using AutoMapper;
using webAPI02.Infraestrutura.Dto;
using webAPI02.Models;

namespace webAPI02.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produtos>().ReverseMap();
            CreateMap<Produtos, ReadProdutoDto>();
            CreateMap<Produtos, UpdateProdutoDto>().ReverseMap();
        }
    }
}
