using System.ComponentModel.DataAnnotations;

namespace webAPI02.Models
{
    public class VendaItens
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public double Quantidade { get; set; }
        //[Required]
        //public int ProdutoId { get; set; }
        //public virtual Produtos Produtos { get; set; }
        //[Required]
        //public int VendaId { get; set; }
        //public virtual Venda Venda { get; set; }

        
        


    }
}
