using Microsoft.AspNetCore.Mvc;
using webAPI02.Infraestrutura.Dto.VendedorDto;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorRepository _context;

        public VendedorController(IVendedorRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddVendedor(CreateVendedorDto vendedorDto)
        {
            _context.AddVendedor(vendedorDto);
            return Ok("Vendedor cadastrado!");
        }

        [HttpGet]
        public IActionResult GetVendedores()
        {
            return Ok(_context.GetVendedor());
        }
    }
}
