using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.VendaItensDto
{
    public class ReadVendaItensDto
    {
        
        public int Id { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; } 
        public int ProdutoId { get; set; }
        public int VendaId { get; set; }
    }
}
