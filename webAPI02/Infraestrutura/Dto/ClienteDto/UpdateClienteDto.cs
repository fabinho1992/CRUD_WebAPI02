using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.ClienteDto
{
    public class UpdateClienteDto
    {
        
        public string Nome { get; set; }
        
        public string Cpf { get; set; }
        
        public DateTime DataNascimento { get; set; }
        
        public string Endereco { get; set; }
    }
}
