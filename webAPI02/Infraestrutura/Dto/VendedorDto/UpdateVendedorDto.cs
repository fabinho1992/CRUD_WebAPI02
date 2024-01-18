using System.ComponentModel.DataAnnotations;
using webAPI02.Models;

namespace webAPI02.Infraestrutura.Dto.VendedorDto
{
    public class UpdateVendedorDto
    {
        
        
        public string Nome { get; set; }
        
        public string Cpf { get; set; }
        
        public DateTime DataContratacao { get; set; }
        
    }
}
