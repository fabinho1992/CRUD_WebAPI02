using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto
{
    public class ReadProdutoDto
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
       
        public double Preco { get; set; }
        
        public string Categoria { get; set; }
    }
}
