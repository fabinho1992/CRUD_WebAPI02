using webAPI02.Infraestrutura.Dto.VendaItensDto;

namespace webAPI02.Infraestrutura.Dto.ProdutoDto
{
    public class ReadProdutoIdDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Categoria { get; set; }
        public virtual ICollection<ReadVendaItensDto> VendasItens { get; set; }
    }
}
