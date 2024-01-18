using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.VendaItensDto
{
    public class UpdateVendaItensDto
    {
        
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public int VendaId { get; set; }
    }
}
