using System.ComponentModel.DataAnnotations;

namespace webAPI02.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Endereco { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        

    }
}
