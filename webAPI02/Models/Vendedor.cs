using System.ComponentModel.DataAnnotations;

namespace webAPI02.Models
{
    public class Vendedor
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public DateTime DataContratacao { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        
    }
}
