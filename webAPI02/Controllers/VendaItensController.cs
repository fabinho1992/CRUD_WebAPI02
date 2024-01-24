using Microsoft.AspNetCore.Mvc;
using webAPI02.Infraestrutura.Dto.VendaItensDto;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaItensController : ControllerBase
    {
        private readonly IVendaItensRepository _context;

        public VendaItensController(IVendaItensRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddVendaItens(CreateVendaItensDto vendaItensDto)
        {
            _context.AddVendaItens(vendaItensDto);
            return Ok("Venda concluida!");
        }

        [HttpGet]
        public IActionResult GetVendaItens()
        {
            return Ok(_context.GetVendaItensDtos());
        }
    }
}
