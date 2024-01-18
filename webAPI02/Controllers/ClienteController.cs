using Microsoft.AspNetCore.Mvc;
using webAPI02.Infraestrutura.Dto.ClienteDto;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _context;

        public ClienteController(IClienteRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddCliente(CreateClienteDto clienteDto)
        {
            _context.AddCliente(clienteDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetCliente()
        {
            return Ok(_context.GetCliente());
        }
    }
}
