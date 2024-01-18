using System.ComponentModel.DataAnnotations;
using webAPI02.Models;

namespace webAPI02.Infraestrutura.Dto.VendaDto
{
    public class ReadVendaDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
    }
}
