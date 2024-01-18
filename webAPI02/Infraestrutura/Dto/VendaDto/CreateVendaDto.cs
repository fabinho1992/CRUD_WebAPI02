using System.ComponentModel.DataAnnotations;
using webAPI02.Models;

namespace webAPI02.Infraestrutura.Dto.VendaDto
{
    public class CreateVendaDto
    {
       
        [Required]
        public int ClienteId { get; set;}
        [Required]
        public int VendedorId { get; set;}
        

    }
}
