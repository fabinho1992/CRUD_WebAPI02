using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webAPI02.Models
{
    public class Venda
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        
        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual ICollection<VendaItens> VendaItens { get; set; }
    }
}
