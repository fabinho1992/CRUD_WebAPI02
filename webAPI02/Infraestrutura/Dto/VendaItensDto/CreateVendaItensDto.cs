using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.VendaItensDto
{
    public class CreateVendaItensDto
    {
        [Required]
        public double Valor { get; set; }
        [Required]
        public double Quantidade { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int VendaId { get; set; }
    }
}
