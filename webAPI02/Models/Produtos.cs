using System.ComponentModel.DataAnnotations;

namespace webAPI02.Models
{
    public class Produtos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public string Categoria { get; set; }
        public virtual ICollection<VendaItens> VendaItens { get; set; }
        

    }
}
