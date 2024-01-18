using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.ClienteDto
{
    public class CreateClienteDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}
