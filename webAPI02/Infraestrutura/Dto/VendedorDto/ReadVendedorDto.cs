using System.ComponentModel.DataAnnotations;
using webAPI02.Infraestrutura.Dto.VendaDto;
using webAPI02.Models;

namespace webAPI02.Infraestrutura.Dto.VendedorDto
{
    public class ReadVendedorDto
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Cpf { get; set; }
        
        public DateTime DataContratacao { get; set; }
        public virtual ICollection<ReadVendaDto> Vendas { get; set; }
    }
}
