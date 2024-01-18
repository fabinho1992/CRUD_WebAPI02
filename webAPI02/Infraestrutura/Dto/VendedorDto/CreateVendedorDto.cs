using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.VendedorDto
{
    public class CreateVendedorDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public DateTime DataContratacao { get; set; }
    }
}
