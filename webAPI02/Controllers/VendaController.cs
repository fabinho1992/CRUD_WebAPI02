using Microsoft.AspNetCore.Mvc;
using webAPI02.Infraestrutura.Dto.VendaDto;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly IVendaRepository _context;


        public VendaController(IVendaRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddVenda(CreateVendaDto vendaDto)
        {
            _context.AddVenda(vendaDto);
            return Ok("Venda criada!");
        }

        [HttpGet]
        public IActionResult GetVenda()
        {

            return Ok(_context.GetVendedores());
        }

       
    }
}
